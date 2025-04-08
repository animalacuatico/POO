using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Bulbasaur bulbasaur = new Bulbasaur();
            bulbasaur.PokemonShout();
            Stantler stantler = new Stantler();
            stantler.PokemonShout();
        }
    }
}
