using AutoMapper;
using BLL.Common;
using BLL.Interfases;
using BLL.Services.Base;
using DAL.Base.Interfaces;
using DAL.Models;
using DTO;

namespace BLL.Services
{
    public class UserService : BaseService<UserDTO, User, int>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            
        }
        public async Task Registration(UserDTO userDTO)
        {
          if (GetAll().Any(s => s.Login == userDTO.Login))  
                throw new Exception(ErrorCode.ServerError00001);
          if (userDTO.Login.Length>10)
                throw new Exception(ErrorCode.ServerError00002);
            await Create(userDTO);
        }
    }
}
