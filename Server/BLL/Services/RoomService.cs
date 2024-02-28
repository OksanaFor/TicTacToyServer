using AutoMapper;
using BLL.Interfases;
using BLL.Services.Base;
using DAL.Base.Interfaces;
using DAL.Models;
using DTO;


namespace BLL.Services
{
    public class RoomService : BaseService<RoomDto, Room, int>, IRoomService
    {
        public RoomService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
