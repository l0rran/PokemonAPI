using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO.Pokemon
{
    public class PokemonStatusDTO
    {
        public int Id { get; set; }

        [Required]
        public StatusDTO Status { get; set; }

        [Range(0, 9999)]
        public int Base { get; set; }

        [Range(0, 9999)]
        public int Min { get; set; }

        [Range(0, 9999)]
        public int Max { get; set; }
    }
}
