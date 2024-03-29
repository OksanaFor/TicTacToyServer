﻿using BLL.Interfases.Base;
using DTO;


namespace BLL.Interfases
{
    public interface IRoomService: IBaseService<RoomDto, int>
    {
         Task<bool> EnterRoom(string password);

    }
}
