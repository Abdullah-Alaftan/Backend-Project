using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services.Mappers
{
    // Add mapper class
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserReadDto, User>();
        }
    }
}