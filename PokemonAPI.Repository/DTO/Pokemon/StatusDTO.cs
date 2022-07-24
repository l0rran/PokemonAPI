using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO.Pokemon
{
    public class StatusDTO
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
