using Microsoft.EntityFrameworkCore;
using PokemonAPI.Repository.Models.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Repository.Data
{
    public class PokemonContext : DbContext
    {

        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
        {
        }

        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<PokemonSpecies> Species { get; set; }

        public DbSet<PokemonType> Types { get; set; }

    }
}
