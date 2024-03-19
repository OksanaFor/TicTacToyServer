using AutoMapper;
using BLL.Common;
using BLL.Common.Auth;
using BLL.Interfases;
using BLL.Services.Base;
using DAL.Base;
using DAL.Base.Interfaces;
using DAL.Models;
using DTO;
using DTO.Request;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class UserService : BaseService<UserDto, User, int>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        public override Task Create(UserDto dto)
        {
            dto.UserStatistic = new UserStatisticDto();
            return base.Create(dto);
        }
        public async Task<Tuple<string, UserDto>> Registration(UserDto userDTO)
        {
            if (GetAll().Any(s => s.Login == userDTO.Login))
                throw new Exception(ErrorCode.ServerError00001);
            if (userDTO.Login.Length > 10)
                throw new Exception(ErrorCode.ServerError00002);
            await Create(userDTO);
            var dbUser = GetAll().FirstOrDefault(s => s.Login == userDTO.Login);

            return new Tuple<string, UserDto>(
                    await Task.Run(GenerateTokenHelper.GetToken),
                    dbUser);
        }
        public async Task<Tuple<string, UserDto>> Authorization(AuthorizationDto request)
        {
            var user = GetAll().FirstOrDefault(u => u.Login == request.Login);

            if (user?.Password != request.Password)
            {
                throw new Exception(ErrorCode.ServerError00003);
              
            }
            return new Tuple<string, UserDto>(
                    await Task.Run(GenerateTokenHelper.GetToken),
                    user);
        }
    }
}