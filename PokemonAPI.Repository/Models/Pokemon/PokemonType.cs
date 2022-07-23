namespace PokemonAPI.Repository.Models.Pokemon
{
    public class PokemonType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PokemonType> EffectiveAgainst { get; set; }

        public List<PokemonType> WeakAgainst { get; set; }
    }
}