using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {

        public int cupsPerPitcher = 8;
        public Dictionary<string, int> recipe = new Dictionary<string, int> { { "cups of sugar", 0 }, { "lemons", 0 }, { "cups of ice", 0 } };
        public Dictionary<string, int> looper = new Dictionary<string, int>();
        public void DetermineRecipe()
        {
            foreach (KeyValuePair<string, int> ingredient in recipe)
            {
                looper.Add(ingredient.Key, ingredient.Value);
            }
            foreach (KeyValuePair<string, int> ingredient in looper)
            { 
                Console.WriteLine("How many " + ingredient.Key);
                string response = Console.ReadLine();
                recipe[ingredient.Key] = SetInt(response, DetermineRecipe);
            }           
        }
        public int SetInt(string input, Action function)
        {
            if ( int.TryParse(input, out int exception) == false)
            {
                Console.WriteLine("incorrect response, press <enter> to try again.");
                function();
                return 0;
            }
            else
            {
                return int.Parse(input);
            }
        }
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
