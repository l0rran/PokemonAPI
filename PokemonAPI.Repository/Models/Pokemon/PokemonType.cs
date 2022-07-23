using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models.Pokemon
{
    public class PokemonType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public List<PokemonType> EffectiveAgainst { get; set; }

        [Required]
        public List<PokemonType> WeakAgainst { get; set; }
    }
}