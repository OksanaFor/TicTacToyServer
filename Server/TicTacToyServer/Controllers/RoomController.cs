using BLL.Interfases;
using DAL.Models;
using DTO;
using TicTacToyServer.Controllers.Base;

namespace TicTacToyServer.Controllers
{
    public class RoomController : BaseController<RoomDto, Room, int>
    {
        private readonly IRoomService roomService;
        public RoomController(IRoomService service) : base(service)
        {
            roomService = service;
        }
    }
}
