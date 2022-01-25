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
        protected Type wealnesses;

        public string getName()
        {
            return this.name;
        }

        public Bitmap getImage()
        {
            return this.image;
        }

        public enum Gender
        {
            male,
            female
        }
        public enum Category
        {
            genetic
        }

        public enum Abilities
        {
            pressure
        }
        public enum Type
        {
            Bug,
            Ghost,
            psychic,
            Dark

        }
    }
}
