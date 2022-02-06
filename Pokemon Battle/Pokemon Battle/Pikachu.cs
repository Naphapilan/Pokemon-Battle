using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Pikachu : Pokemon
    {
        public Pikachu()
        {
            base.name = "Pikachu";
            base.height = 1.04;
            base.weight = 13.2;

            base.gender = Gender.male;
            base.category = Category.mounse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources._025;

        }
    }
}
