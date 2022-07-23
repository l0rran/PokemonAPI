namespace PokemonAPI.Repository.Model.Pokemon
{
    public class PokemonStatus
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        public int Base { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

    }
}