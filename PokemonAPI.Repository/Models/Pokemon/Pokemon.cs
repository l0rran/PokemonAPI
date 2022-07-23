namespace PokemonAPI.Repository.Models.Pokemon
{
    public class Pokemon
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<PokemonType> Types { get; set; }

        public PokemonSpecies Species { get; set; }

        public float HeightInMeters { get; set; }

        public float WeightInKg { get; set; }

        public List<Local> Locals { get; set; }

        public PokemonStatus Stats { get; set; }

        public List<Evolution> Evolutions { get; set; }


    }
}
