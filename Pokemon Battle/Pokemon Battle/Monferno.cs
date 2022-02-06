using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Monferno : Pokemon
    {
        public Monferno()
        {
            base.name = "monferno";
            base.height = 2.11;
            base.weight = 48.5;

            base.gender = Gender.unknow;
            base.category = Category.playful;
            base.abilities = Abilities.blaze;
            base.type = Type.fire;
            base.weaknesses = Type.weter;
            base.image = Resources._391;

        }
    }
}
