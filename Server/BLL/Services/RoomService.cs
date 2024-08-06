using AutoMapper;
using BLL.Common;
using BLL.Interfases;
using BLL.Services.Base;
using DAL.Base.Interfaces;
using DAL.Models;
using DTO;
using DTO.Request;
using System.Data;


namespace BLL.Services
{
    public class RoomService : BaseService<RoomDto, Room, int>, IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> EnterRoom(EnterRoomDto request)
        {
            var room = GetAll().FirstOrDefault(s => s.Id == request.RoomId);
            if (room.Password != request.Password)
                throw new Exception(ErrorCode.ServerError00004);
            if (_unitOfWork.Users.GetAll().Count(s=> s.RoomId == request.RoomId)>1)
                throw new Exception(ErrorCode.ServerError00005);

            var user = await _unitOfWork.Users.GetByIdAsync(request.UserId);
            user.RoomId = request.RoomId;
            _unitOfWork.Users.Update(user);
            await _unitOfWork.SaveAsync();

            return true;
        }
    }
}
