using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOOP
{
    internal class Pokemon
    {
        // STATE - member variables
        string _name;
        string _type;
        string _nature;
        string _ability;
        bool _isShiny;
        // hp, atk, def, spAt, spDf, spd
        const int StatCount = 6;
        int[] stats;
        int _exp;
        int _lvl;

        public string Name
        {
            get { return _name; }
           
        }

        // This is the default constructor - it has no parameters.
        public Pokemon() 
        {

        }

        // This is a greedy constructor - it takes parameters, and is used to make the object creation easier.
        public Pokemon(string name, string type, int level, string nature)
        {
            _name = name;
            _type = type;
            _lvl = level;
            _exp = 0;
            _isShiny = false;
            _nature = nature;
        }

        public Pokemon(string name, string type, string ability)
        {
            _name = name;
            _type = type;
            _lvl = 1;
            _exp = 0;
            _isShiny = false;
            _ability = ability;
        }
    }
}
