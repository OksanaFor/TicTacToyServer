using BLL.Interfases;
using DAL.Models;
using DTO;
using DTO.Request;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TicTacToyServer.Controllers.Base;

namespace TicTacToyServer.Controllers
{

    public class UserController : BaseController<UserDto, User, int>
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) : base(userService)
        {
            _userService = userService;
        }
        [HttpPost] 
        [Route("[action]")]
        public async Task Registration(UserDto user)
        {
            await _userService.Registration(user);
        }

        [HttpPost]
        [Route("[action]")]
        public bool Authorization(AuthorizationDto request )
        {
            return _userService.Authorization(request);
           
        }
    }
}
