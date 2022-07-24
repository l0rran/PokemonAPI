using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO
{
    public class PokemonStatsDTO
    {
        public int Id { get; set; }

        [Required]
        public StatsDTO Stats { get; set; }

        [Range(0, 9999)]
        public int Base { get; set; }

        [Range(0, 9999)]
        public int Min { get; set; }

        [Range(0, 9999)]
        public int Max { get; set; }
    }
}
