using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {               
                
        public double money;
        public int cupsInPitcher = 8;
        public Dictionary<string, int> inventory = new Dictionary<string, int> { { "cups of sugar", 0 }, { "lemons", 0 }, { "cups of ice", 0 },{ "cups", 100} };
        public void MakePitcher(Dictionary<string, int> recipe)
        {
            foreach (KeyValuePair<string, int> ingredient in recipe)
            {
                inventory[ingredient.Key] -= recipe[ingredient.Key];
            }
        }
        public void DisplayInventory()
        {
            foreach (KeyValuePair<string, int> item in inventory)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            Console.ReadLine();
        }
        public void IncreaseInventory(string item, int number)
        {
            inventory[item] += number;
        }
       
        
       

        
     

    }
}
