using PokemonAPI.Repository.Models;
using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO
{
    public class LocalDTO
    {
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public List<Game> Games { get; set; }
    }
}
