using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expo.QueryOperators
{
    public class QueryOperators
    {

        public QueryOperators() { }

        public void WhereOperator()
        {
            Ingredient[] ingredients = { new Ingredient { Name = "Sugar", Calories = 500 },
                                         new Ingredient { Name = "Egg", Calories = 100 },
                                         new Ingredient { Name = "Milk", Calories = 150 },
                                         new Ingredient { Name = "Flour", Calories = 50 },
                                         new Ingredient { Name = "Butter", Calories = 200 } };

            IEnumerable<Ingredient> query = ingredients
                                                .Where(x => x.Calories >= 200);

            foreach (var ingredient in query) {
                Console.WriteLine(ingredient.Name);
            }
            
        }
    }
}
