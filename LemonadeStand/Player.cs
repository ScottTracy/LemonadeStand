using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class  Player
    {
        public string playerName;
        private Dictionary<string, int> looper = new Dictionary<string, int>();
        Inventory inventory = new Inventory();
        Recipe recipe = new Recipe();


        public virtual void SetName()
        {
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            if (playerName.Length < 3)
            {
                Console.WriteLine("That is not your name.  Let's try this again.");
                SetName();
            }
        }

        public void DetermineRecipe()
        {
            foreach (KeyValuePair<string, int> ingredient in recipe.recipe)
            {
                looper.Add(ingredient.Key, ingredient.Value);
            }
            foreach (KeyValuePair<string, int> ingredient in looper)
            {
                Console.WriteLine("How many " + ingredient.Key);
                string response = Console.ReadLine();
                recipe.recipe[ingredient.Key] = SetInt(response, DetermineRecipe);
            }
        }
        public int SetInt(string input, Action function)
        {
            if (int.TryParse(input, out int exception) == false)
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
        public void BuyLemons()
        {
            Console.WriteLine();
        }
        public void BuySugar()
        {

        }
        public void BuyIce()
        {

        }

    }
}
