using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public Dictionary<string, int> recipe = new Dictionary<string, int> { { "cups of sugar", 0 }, { "lemons", 0 }, { "cups of ice", 0 } };
        
       
        public void DisplayRecipe()
        {
            foreach (KeyValuePair<string, int> item in recipe)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.ReadLine();
        }

    }
}
