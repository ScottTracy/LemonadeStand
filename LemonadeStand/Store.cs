using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        
        public Dictionary<string, double> priceGuide = new Dictionary<string, double> { { "cups of sugar", .30 }, { "lemons", .60 }, { "cups of ice", .10 }, { "cups", .05 } };
        public double DetermineSale(double ingredient, int quantity)
        {
            return quantity * ingredient;
        }
        public void DisplayPrice(KeyValuePair<string,double>item)
        {
            Console.WriteLine(item.Key+ ": $" +item.Value );
            Console.ReadLine();
        }
        public void DisplayPrices()
        {
            foreach(KeyValuePair<string, double> item in priceGuide)
            {
                DisplayPrice(item);
            }

            
        }


    }


}
