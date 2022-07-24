using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models
{
    public class PokemonSpecies
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}