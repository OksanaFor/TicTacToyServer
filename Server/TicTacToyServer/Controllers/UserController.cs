using BLL.Interfases.Base;
using DAL.Models;
using DTO;
using TicTacToyServer.Controllers.Base;

namespace TicTacToyServer.Controllers
{
    public class UserController : BaseController<UserDTO, User, int>
    {
        public UserController(IBaseService<UserDTO, int> service) : base(service)
        {

        }
    }
}
