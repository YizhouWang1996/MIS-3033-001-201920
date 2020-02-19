using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }

        public List<AllPokemonResult> results { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }



    public class AllPokemonResult
    {
        public string name { get; set; }
       
        public string url { get; set; }


        public override string ToString()
        {
            return $"({url}) {name}";
        }

    }



  
}
