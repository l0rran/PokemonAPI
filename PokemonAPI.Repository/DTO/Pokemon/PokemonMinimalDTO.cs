using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Repository.DTO.Pokemon
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
