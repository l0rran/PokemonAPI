using PokemonAPI.Repository.DTO.Pokemon;

namespace PokemonAPI.Repository.Services
{
    public interface IPokemonService
    {
        Task<List<PokemonMinimalDTO>> GetAllAsync();

        Task<List<PokemonMinimalDTO>> GetPaginatedAsync(int skip, int take);

        Task<PokemonDTO> GetByIdAsync(int id);
    }
}
