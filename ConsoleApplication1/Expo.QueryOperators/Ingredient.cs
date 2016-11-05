using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo.QueryOperators
{
    class Ingredient
    {

        public string Name { set; get; }
        public int Calories { set; get; }

        public Ingredient(){}

        public Ingredient(string name, int calories)
        {
            this.Name = name;
            this.Calories = calories;
        }
    }
}
