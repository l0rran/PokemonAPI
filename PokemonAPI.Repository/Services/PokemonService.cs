using Microsoft.EntityFrameworkCore;
using PokemonAPI.Repository.Data;
using PokemonAPI.Repository.DTO.Pokemon;
using PokemonAPI.Repository.Models.Pokemon;

namespace PokemonAPI.Repository.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly PokemonContext _pokemonContext;

        public PokemonService(PokemonContext pokemonContext)
        {
            _pokemonContext = pokemonContext;
        }
        public async Task<List<PokemonMinimalDTO>> GetAllAsync()
        {
            return await _pokemonContext.Pokemons.Select(p => new PokemonMinimalDTO()
            {
                Id = p.Id,
                Name = p.Name,
                Number = p.Number
            }).ToListAsync();
        }

        public async Task<List<PokemonMinimalDTO>> GetPaginatedAsync(int skip, int take)
        {
            return await _pokemonContext.Pokemons.Skip(skip).Take(take).Select(p => new PokemonMinimalDTO()
            {
                Id = p.Id,
                Name = p.Name,
                Number = p.Number
            }).ToListAsync();
        }

        public async Task<PokemonDTO> GetByIdAsync(int id)
        {
            Pokemon pokemon = await _pokemonContext.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return null;
            }

            return new PokemonDTO()
            {
                Id = pokemon.Id,
                Description = pokemon.Description,
                Evolutions = pokemon.Evolutions,
                HeightInMeters = pokemon.HeightInMeters,
                Locals = pokemon.Locals,
                Name = pokemon.Name,
                Number = pokemon.Number,
                Species = pokemon.Species,
                Stats = pokemon.Stats,
                Types = pokemon.Types,
                WeightInKg = pokemon.WeightInKg
            };
        }


    }
}
