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
        Store store = new Store();

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
        
        public void GoShopping()
        {
            Console.WriteLine("Welcome to the store, here is a list of what you can buy:");
            store.DisplayPrices();
            foreach (KeyValuePair<string, double> item in store.priceGuide)
            {
                BuyItem(item);
            }
        }
        public void BuyItem(KeyValuePair<string, double> item)
        {
            Console.WriteLine("You have $" + inventory.money);
            Console.WriteLine("You have " + inventory.inventory[item.Key] + " " + item.Key + " in your inventory.");
            Console.WriteLine("How many " + item.Key + " would you like to buy at $" + item.Value + " a piece?");
            string itemString = Console.ReadLine();
            if (int.TryParse(itemString, out int exception) == false)
            {
                Console.WriteLine("incorrect response, press <enter> to try again.");
                Console.ReadLine();
                BuyItem(item);
                
            }
            else
            {
                int noOfItems = int.Parse(itemString);
                double saleCost = store.DetermineSale(item.Key, noOfItems);
                if (saleCost > inventory.money)
                {
                    Console.WriteLine("You do not have enough money in your inventory for that.  Press <enter>");
                    Console.ReadLine();
                    BuyItem(item);
                }
                else
                {
                    inventory.money -= saleCost;
                    inventory.IncreaseInventory(item.Key, noOfItems);
                }

            }


        }
        

    }
}
