using AutoMapper;
using DAL.Models;
using DTO;
using System.Reflection.Metadata;


namespace BLL
{
    public class DtoToEntitiesMappingProfile : Profile
    {
        public DtoToEntitiesMappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
