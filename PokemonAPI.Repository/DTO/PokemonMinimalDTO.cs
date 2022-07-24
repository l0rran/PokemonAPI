using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO
{
    public class PokemonMinimalDTO
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
