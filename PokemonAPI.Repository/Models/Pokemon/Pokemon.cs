using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models.Pokemon
{
    public class Pokemon
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public List<PokemonType> Types { get; set; }

        [Required]
        public PokemonSpecies Species { get; set; }

        [Range(0,100)]
        public float HeightInMeters { get; set; }

        [Range(0,100)]
        public float WeightInKg { get; set; }

        [Required]
        public List<Local> Locals { get; set; }

        [Required]
        public PokemonStatus Stats { get; set; }

        [Required]
        public List<Evolution> Evolutions { get; set; }


    }
}
