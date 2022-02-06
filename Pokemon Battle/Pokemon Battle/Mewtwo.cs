using Pokemon_Battle.Properties;
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
            base.name = "mewtwo";
            base.height = 6.07;
            base.weight = 269.0;

            base.gender = Gender.male;
            base.category = Category.genetic;
            base.abilities = Abilities.pressure;
            base.type = Type.psychic;
            base.weaknesses = Type.ghost;
            
            base.image = Resources._150;
        }
    }
}
