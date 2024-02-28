

using BLL.Interfases.Base;
using DTO;
using DTO.Request;

namespace BLL.Interfases
{
    public interface IUserService: IBaseService<UserDto,int>
    {
        Task Registration(UserDto userDto);

        bool Authorization (AuthorizationDto request);

    }
}
