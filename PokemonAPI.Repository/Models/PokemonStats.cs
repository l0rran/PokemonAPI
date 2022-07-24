using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models
{
    public class PokemonStats
    {
        public int Id { get; set; }

        [Required]
        public Stats Stats { get; set; }

        [Range(0, 9999)]
        public int Base { get; set; }

        [Range(0, 9999)]
        public int Min { get; set; }

        [Range(0, 9999)]
        public int Max { get; set; }

    }
}