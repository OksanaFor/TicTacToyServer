using BLL.Interfases.Base;
using DTO;
using DTO.Request;


namespace BLL.Interfases
{
    public interface IRoomService: IBaseService<RoomDto, int>
    {
         Task<bool> EnterRoom(EnterRoomDto request);

    }
}
