using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(30)]
        public string Name { get; set; }

    }
}