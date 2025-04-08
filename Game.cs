using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego!");
            List<Pokemon> pokeList = new List<Pokemon>();
            Bulbasaur bulbasaur = new Bulbasaur();
            Stantler stantler = new Stantler();
            Simisear simisear = new Simisear();
            Miraidon miraidon = new Miraidon();
            pokeList.Add(bulbasaur);
            pokeList.Add(miraidon);
            pokeList.Add(stantler);
            pokeList.Add(simisear);
            // Ahora pokelist contiene todos los pokemons
            List<Pokemon> catchedPokemons = new List<Pokemon>(); // Esta lista de variable Pokemon sólo contiene Pokemons capturados
            bool gameRunning = true;
            while (gameRunning)
            {
                Random randSpawn = new Random();
                int newSpawn = randSpawn.Next(0, pokeList.Count()); // Escoge entre 0 y el tamaño de la lista pokelist.
                Console.WriteLine("Un nuevo pokemon ha aparecido: " + pokeList[newSpawn]); // newSpawn es el pokemon escogido
                Console.WriteLine("Presiona la tecla <0> si quieres intentar capturar el pokemon.");
                Console.WriteLine("Presiona la tecla <1> si quieres dejar escapar al pokemon.");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Has dejado huir al pokemon.");
                }
                else if (answer == 0)
                {
                    Random catchChance = new Random();
                    int result = catchChance.Next(0, 10); // Chance de capturar o huir
                    if (result <= 4)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("El pokemon se ha escapado. Mala suerte.");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else // Si lo cazas
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Has logrado capturar al pokemon! " + pokeList[newSpawn]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        catchedPokemons.Add(pokeList[newSpawn]); // Le añades a la lista catchedPokemons, el pokemon escogido newSpawn
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("NÚMERO DE POKEMONS CAPTURADOS: " + catchedPokemons.Count());
                foreach (Pokemon pokemon in catchedPokemons)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Nombre: " + pokemon.Name);
                    Console.WriteLine("Vida: " + pokemon.Health);
                    Console.WriteLine("Tipo: " + pokemon.GetPokemonType());
                    pokemon.PokemonShout();
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
