using PokemonAPI.Repository.Models.Pokemon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Repository.DTO.Pokemon
{
    public class PokemonDTO
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

        [Range(0, 100)]
        public float HeightInMeters { get; set; }

        [Range(0, 100)]
        public float WeightInKg { get; set; }

        [Required]
        public List<Local> Locals { get; set; }

        [Required]
        public PokemonStatus Stats { get; set; }

        [Required]
        public List<Evolution> Evolutions { get; set; }
    }
}
