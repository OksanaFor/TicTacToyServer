using AutoMapper;
using DAL.Models;
using DTO;
using DTO.Request;



namespace BLL
{
    public class DtoToEntitiesMappingProfile : Profile
    {
        public DtoToEntitiesMappingProfile()
        {
            //CreateMap<User, UserDto>();
            //CreateMap<UserDto, User>();
            //CreateMap<UserStatistics, UserStatisticDto>().AfterMap((model, dto) =>
            //{
            //    dto.Rating = model.Win * 2 + model.Drow - model.Lose * 3;
            //    dto.User = null;
            //});
            //CreateMap<UserStatisticDto, UserStatistics>().AfterMap((dto, model) =>
            //{
            //    dto.User = null;
            //});

            //CreateMap<Room, RoomDto>().AfterMap((model, dto) =>
            //{
            //    if(dto.Users != null)
            //    {
            //        foreach (var user in dto.Users)
            //        {
            //            user.Room = null;
            //        }
            //    }
               

            //});
            //CreateMap<RoomDto, Room>().AfterMap((dto, model) =>
            //{
            //    foreach (var user in model.Users)
            //    {
            //        user.Room = null;
            //    }

            //});

        }
    }
}
