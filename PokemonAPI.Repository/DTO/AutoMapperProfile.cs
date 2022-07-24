using AutoMapper;
using PokemonAPI.Repository.DTO.Pokemon;

namespace PokemonAPI.Repository.DTO
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Models.Pokemon.Pokemon, PokemonDTO>();
            CreateMap<Models.Pokemon.Pokemon, PokemonMinimalDTO>();
        }
    }
}
