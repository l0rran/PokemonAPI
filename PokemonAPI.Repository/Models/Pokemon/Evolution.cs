using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models.Pokemon
{
    public class Evolution
    {
        public int Id { get; set; }

        [Range(0,20)]
        public int OrderInSequence { get; set; }

        [Required]
        public Pokemon Pokemon { get; set; }

        [Required]
        public Pokemon BasePokemon { get; set; }

        [Range(0, 100)]
        public int Level { get; set; }

    }
}