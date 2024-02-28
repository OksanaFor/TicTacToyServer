using AutoMapper;
using BLL.Common;
using BLL.Interfases;
using BLL.Services.Base;
using DAL.Base.Interfaces;
using DAL.Models;
using DTO;
using DTO.Request;

namespace BLL.Services
{
    public class UserService : BaseService<UserDto, User, int>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        public async Task Registration(UserDto userDTO)
        {
            if (GetAll().Any(s => s.Login == userDTO.Login))
                throw new Exception(ErrorCode.ServerError00001);
            if (userDTO.Login.Length > 10)
                throw new Exception(ErrorCode.ServerError00002);
            await Create(userDTO);
        }
        public bool Authorization(AuthorizationDto request)
        {
            var user = GetAll().FirstOrDefault(u => u.Login == request.Login);

            if (user?.Password != request.Password)
            {
                throw new Exception(ErrorCode.ServerError00003);
              
            }
            return true;
        }
    }
}