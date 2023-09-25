using Angular_Essential_API.Dtos;
using Angular_Essential_API.Models;
using AutoMapper;


namespace Angular_Essential_API
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<Movie, CreateMovieDto>().ReverseMap();
        }

    }
}
