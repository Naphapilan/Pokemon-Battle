using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            name = "mewtwo";
            height = 6.07;
            weight = 269.0;

            gender = Gender.male;
            category = Category.genetic;
            abilities = Abilities.pressure;
            type = Type.psychic;
            wealnesses = Type.Ghost;


        }
    }
}
