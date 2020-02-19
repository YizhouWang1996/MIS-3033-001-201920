using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class PokemonAPI
    {
        public AllPokemonResult info { get; set; }
    }

    public class AllPokemonResult
    {
        public int width { get; set; }
        public int height { get; set; }
        public int image { get; set; }
        public string name { get; set; }
        public Sprite sprites { get; set; }
        

    }

    public class Sprite
    {
        string front_default { get; set; }
        string back_default { get; set; }
    }
}
