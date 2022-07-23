namespace PokemonAPI.Repository.Models.Pokemon
{
    public class Evolution
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public Pokemon Pokemon { get; set; }

        public Pokemon BasePokemon { get; set; }

        public int Level { get; set; }

    }
}