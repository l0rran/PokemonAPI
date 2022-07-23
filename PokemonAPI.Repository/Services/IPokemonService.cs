using PokemonAPI.Repository.DTO.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Repository.Services
{
    public interface IPokemonService
    {
        Task<List<PokemonMinimalDTO>> GetAllAsync();

        Task<List<PokemonMinimalDTO>> GetPaginatedAsync(int skip, int take);

        Task<PokemonDTO> GetByIdAsync(int id);
    }
}
