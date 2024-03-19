using BLL.Interfases;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicTacToyServer.Controllers.Base;

namespace TicTacToyServer.Controllers
{
    [Authorize]
    public class RoomController : BaseController<RoomDto, Room, int>
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService service) : base(service)
        {
            roomService = service;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<bool> EnterRoom([FromBody]string password)
        {

            return await roomService.EnterRoom(password);
        }
    }
}
