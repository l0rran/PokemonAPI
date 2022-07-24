using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO
{
    public class PokemonSpeciesDTO
    {

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}
