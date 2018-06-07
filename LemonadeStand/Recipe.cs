using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {

        public int cupsPerPitcher = 8;
        public Dictionary<string, int> recipe = new Dictionary<string, int> { { "cups of sugar", 0 }, { "lemons", 0 }, { "cups of ice", 0 } };

        public void DetermineRecipe()
        {
            foreach (KeyValuePair<string, int> ingredient in recipe)
            {
                Console.WriteLine("How many " + ingredient.Key);
                string response = Console.ReadLine();
                SetInt(response, DetermineRecipe, recipe[ingredient.Key]);
            }
                
            
        }
        public void SetInt(string input, Action function, int targetVariable)
        {
            if ( int.TryParse(input, out int exception) == false)
            {
                Console.WriteLine("incorrect response, press <enter> to try again.");
                function();
            }
            else
            {
                targetVariable = int.Parse(input);
            }
        }
    }
}
