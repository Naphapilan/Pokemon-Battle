using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Pansear : Pokemon
    {
        public Pansear()
        {
            base.name = "pansear";
            base.height = 2.00;
            base.weight = 24.3;

            base.gender = Gender.unknow;
            base.category = Category.high_temp;
            base.abilities = Abilities.gluttony;
            base.type = Type.fire;
            base.weaknesses = Type.weter;
            base.image = Resources._513;

        }
    }
}
