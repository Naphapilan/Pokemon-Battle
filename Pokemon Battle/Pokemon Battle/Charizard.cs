using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Charizard : Pokemon
    {
        public Charizard()
        {
            base.name = "charizard";
            base.height = 5.07;
            base.weight = 199.5;

            base.gender = Gender.male;
            base.category = Category.flame;
            base.abilities =  Abilities.blaze ;
            base.type = Type.fire ;
            base.weaknesses = Type.weter; 
            base.image = Resources._006;

        }
    }
}
