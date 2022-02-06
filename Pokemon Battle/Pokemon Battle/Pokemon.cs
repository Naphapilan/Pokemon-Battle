using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Pokemon
    {

        protected double height;
        protected double weight;
        protected string name;
        protected Gender gender;
        protected Category category;
        protected Abilities abilities;
        protected Bitmap image;
        protected Type type;
        protected Type weaknesses;

        public string getName() 
        {
            return this.name;
        }
        public  Bitmap getImage()
        {
            return this.image;
        }    
      }   

        public enum Gender
        {
            male,
            female,unknow
        }
        public enum Category
        {
            genetic,flame,mouse,dragon,playful,high_temp
        }

        public enum Abilities
        {
            pressure,blaze,static_, inner_focus,gluttony
        }
        public enum Type
        {
            bug, ghost, psychic, dark, flying, fire, weter, electric, rock, ground, dragon,fairy,ice,fighting
    }
}
