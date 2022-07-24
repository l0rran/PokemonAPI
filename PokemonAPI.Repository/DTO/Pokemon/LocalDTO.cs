using PokemonAPI.Repository.Models.Pokemon;
using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO.Pokemon
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
