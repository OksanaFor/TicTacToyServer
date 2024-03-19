

using BLL.Interfases.Base;
using DTO;
using DTO.Request;

namespace BLL.Interfases
{
    public interface IUserService: IBaseService<UserDto,int>
    {
        Task<Tuple<string, UserDto>> Registration(UserDto userDto);

        Task<Tuple<string, UserDto>> Authorization (AuthorizationDto request);

    }
}
