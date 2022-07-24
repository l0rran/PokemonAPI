using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Repository.Data;
using PokemonAPI.Repository.DTO;
using PokemonAPI.Repository.Models;

namespace PokemonAPI.Repository.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly PokemonContext _pokemonContext;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _configuration;

        public PokemonService(PokemonContext pokemonContext, IMapper mapper, IConfigurationProvider configuration)
        {
            _pokemonContext = pokemonContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<List<PokemonMinimalDTO>> GetAllAsync()
        {
            return await _pokemonContext.Pokemons.ProjectTo<PokemonMinimalDTO>(_configuration).ToListAsync();
        }

        public async Task<List<PokemonMinimalDTO>> GetPaginatedAsync(int skip, int take)
        {
            return await _pokemonContext.Pokemons.Skip(skip).Take(take).ProjectTo<PokemonMinimalDTO>(_configuration).ToListAsync();
        }

        public async Task<PokemonDTO> GetByIdAsync(int id)
        {
            Pokemon pokemon = await _pokemonContext.Pokemons.FindAsync(id);
            if (pokemon is null)
            {
                return null;
            }
            return _mapper.Map<PokemonDTO>(pokemon);
        }


    }
}
