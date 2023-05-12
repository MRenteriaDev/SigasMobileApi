using API.Models;
using API.Models.DTOs;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Ente, EnteDto>();
        }
    }
}