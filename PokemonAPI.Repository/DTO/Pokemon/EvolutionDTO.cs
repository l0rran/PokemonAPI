using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO.Pokemon
{
    public class EvolutionDTO
    {
        public int Id { get; set; }

        [Range(0, 20)]
        public int OrderInSequence { get; set; }

        public int PokemonId { get; set; }

        public int BasePokemonId { get; set; }

        [Range(0, 100)]
        public int Level { get; set; }
    }
}
