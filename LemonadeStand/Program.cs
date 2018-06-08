using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe cookbook = new Recipe();
            Inventory items = new Inventory();
            items.DisplayInventory();
            cookbook.DetermineRecipe();
            cookbook.DisplayRecipe();
            items.MakePitcher(cookbook.recipe);
            items.DisplayInventory();

            //Connection connection = new Connection();
            //connection.OpenConnection();
            //connection.CloseConnection();
            //Console.ReadLine();
        }
    }
}
