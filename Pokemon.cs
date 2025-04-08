namespace POO
{
    public class Pokemon
    {
        public string Name;
        protected string Type; // privado para el resto del mundo, público para las herencias
        public int Health;
        public Pokemon()
        {

        }
        public Pokemon(string pokeName, string pokeType, int pokeHealth)
        {
            this.Name = pokeName;
            this.Type = pokeType;
            this.Health = pokeHealth;
            PokemonShout();
        }
        public void PokemonShout()
        {
            Console.WriteLine(Name);
        }
        public string GetPokemonName()
        {
            return Name;
        }
        public string GetPokemonType()
        {
            return Type;
        }
        public int GetPokemonHealth()
        {
            return Health;
        }
    }
}
