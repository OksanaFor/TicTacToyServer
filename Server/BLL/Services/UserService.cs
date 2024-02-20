using AutoMapper;
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
    }
}
