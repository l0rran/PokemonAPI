using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO.Pokemon
{
    public class PokemonDTO
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public List<PokemonTypeDTO> Types { get; set; }

        [Required]
        public PokemonSpeciesDTO Species { get; set; }

        [Range(0, 100)]
        public float HeightInMeters { get; set; }

        [Range(0, 100)]
        public float WeightInKg { get; set; }

        [Required]
        public List<LocalDTO> Locals { get; set; }

        [Required]
        public PokemonStatusDTO Stats { get; set; }

        [Required]
        public List<EvolutionDTO> Evolutions { get; set; }
    }
}
