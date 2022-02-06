using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Dragonite : Pokemon
    {
        public Dragonite()
        {
            base.name = "dragonite";
            base.height = 6.07;
            base.weight = 132.3;

            base.gender = Gender.male;
            base.category = Category.dragon;
            base.abilities = Abilities.inner_focus;
            base.type = Type.dragon;
            base.weaknesses = Type.fairy;
            base.image = Resources._149;

        }
    }
}
