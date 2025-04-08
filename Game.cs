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
            List<Pokemon> pokeList = new List<Pokemon>();
            Bulbasaur bulbasaur = new Bulbasaur();
            Stantler stantler = new Stantler();
            Simisear simisear = new Simisear();
            Miraidon miraidon = new Miraidon();
            pokeList.Add(bulbasaur);
            pokeList.Add(miraidon);
            pokeList.Add(stantler);
            pokeList.Add(simisear);
            List<Pokemon> catchedPokemons = new List<Pokemon>();
            bool gameRunning = true;
            while (gameRunning)
            {
                Random randSpawn = new Random();
                int newSpawn = randSpawn.Next(0, pokeList.Count());
                Console.WriteLine("Un nuevo pokemon ha aparecido: " + pokeList[newSpawn]);
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
                    int result = catchChance.Next(0, 10);
                    if (result <= 4)
                    {
                        Console.WriteLine("El pokemon se ha escapado. Mala suerte.");
                    }
                    else
                    {
                        Console.WriteLine("Has logrado capturar al pokemon! " + pokeList[newSpawn]);

                    }
                }
            }


        }
    }
}
