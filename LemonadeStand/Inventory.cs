using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int cupsOfSugar;
        public int lemons;
        public int cups;
        public int cupsOfIce;
        public double Money = 20.00;
        public int cupsInPitcher;

        public void MakePitcher()
        {

        }
        public void ReduceInventory(double item,double quantity)
        {
            if (item >= quantity)
            {
                item -= quantity;
            }
            else {
                Console.WriteLine("Insufficient quantity");
                    }
        }


        
     

    }
}
