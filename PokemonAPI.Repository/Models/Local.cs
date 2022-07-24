using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models
{
    public class Local
    {

        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public List<Game> Games { get; set; }

    }
}