

using BLL.Interfases.Base;
using DTO;

namespace BLL.Interfases
{
    public interface IUserService: IBaseService<UserDTO,int>
    {
        Task Registration(UserDTO userDTO);

        Task<bool> Authorization (UserDTO userDTO);

    }
}
