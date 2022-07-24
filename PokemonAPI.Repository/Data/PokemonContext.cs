using Microsoft.EntityFrameworkCore;
using PokemonAPI.Repository.Models;

namespace PokemonAPI.Repository.Data
{
    public class PokemonContext : DbContext
    {

        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.Evolutions)
                .WithOne(e => e.Pokemon);

            modelBuilder.Entity<Evolution>()
                .HasOne(e => e.BasePokemon);
        }

        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<Stats> Stats { get; set; }

        public DbSet<PokemonSpecies> Species { get; set; }

        public DbSet<PokemonType> Types { get; set; }

    }
}
