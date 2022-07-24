using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.DTO
{
    public class PokemonTypeDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<int> EffectiveAgainstIds { get; set; }

        public List<int> WeakAgainstIds { get; set; }
    }
}
