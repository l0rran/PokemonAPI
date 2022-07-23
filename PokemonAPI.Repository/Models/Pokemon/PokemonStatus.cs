﻿using System.ComponentModel.DataAnnotations;

namespace PokemonAPI.Repository.Models.Pokemon
{
    public class PokemonStatus
    {
        public int Id { get; set; }

        [Required]
        public Status Status { get; set; }

        [Range(0, 9999)]
        public int Base { get; set; }

        [Range(0, 9999)]
        public int Min { get; set; }

        [Range(0, 9999)]
        public int Max { get; set; }

    }
}