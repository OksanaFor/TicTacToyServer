using BLL.Interfases;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Mvc;
using TicTacToyServer.Controllers.Base;

namespace TicTacToyServer.Controllers
{

    public class UserController : BaseController<UserDTO, User, int>
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) : base(userService)
        {
            _userService = userService;
        }
        [HttpPost] 
        [Route("[action]")]
        public async Task Registration(UserDTO user)
        {
            await _userService.Registration(user);
        }
    }
}
