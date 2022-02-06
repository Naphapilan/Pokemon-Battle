using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Moltres : Pokemon
    {
        public Moltres()
        {
            base.name = "moltres";
            base.height = 6.07;
            base.weight = 132.3;

            base.gender = Gender.unknow;
            base.category = Category.flame;
            base.abilities = Abilities.pressure;
            base.type = Type.fire;
            base.weaknesses = Type.weter;
            base.image = Resources._146;

        }
    }
}
