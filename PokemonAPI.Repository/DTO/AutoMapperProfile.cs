using AutoMapper;
using PokemonAPI.Repository.Models;

namespace PokemonAPI.Repository.DTO
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<Pokemon, PokemonMinimalDTO>();
        }
    }
}
