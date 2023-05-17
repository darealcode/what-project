using System;
using System.Collections.Generic;

namespace PokemonPocket
{
    public class PokemonMaster
    {
        public string Name { get; set; }
        public int NoToEvolve { get; set; }
        public string EvolveTo { get; set; }

        public PokemonMaster(string name, int noToEvolve, string evolveTo)
        {
            this.Name = name;
            this.NoToEvolve = noToEvolve;
            this.EvolveTo = evolveTo;
        }

        public class Pokemons
        {
            public string Name { get; set; }
            public int HP { get; set; }
            public int EXP { get; set; }

            public Pokemons(string name, int HP, int EXP)
            {
                this.Name = name;
                this.HP = HP;
                this.EXP = EXP;
            }
        }








    }

}