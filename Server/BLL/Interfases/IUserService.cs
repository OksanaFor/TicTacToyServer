

using BLL.Interfases.Base;
using DTO;
using DTO.Request;

namespace BLL.Interfases
{
    public interface IUserService: IBaseService<UserDTO,int>
    {
        Task Registration(UserDTO userDTO);

        bool Authorization (AuthorizationDto request);

    }
}
