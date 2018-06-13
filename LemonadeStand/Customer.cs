using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        
        public int maxSugarPerPitcher = 4;
        
        public int maxIcePerPitcher = 64;
        
        public int maxLemonsPerPitcher = 6;
        public double priceLimit = 1.00;
        public Dictionary<string, int> customerPreference = new Dictionary<string, int> { { "cups of sugar", 0 }, { "lemons", 0 }, { "cups of ice", 0 } };
        public double customerPriceLimit;
        public int placeholderA;
        public int placeholderB;


        public void SetSugarPreference(Func<int> random)
        {
            placeholderA = 1;
            placeholderB = maxSugarPerPitcher + 1;

           customerPreference["cups of sugar"] = random();
        }
        public void SetIcePreference(Func<int> random)
        {
            placeholderA = 1;
            placeholderB = maxIcePerPitcher + 1;
            customerPreference["lemons"] = random();
        }
        public void SetLemonPreference(Func<int> random)
        {
            placeholderA = 1;
            placeholderB = maxLemonsPerPitcher + 1;
            customerPreference["cups of ice"] = random();
        }
        public void SetPriceLimit(Func<int> random)
        {
            placeholderA = 1;
            placeholderB = (int)(priceLimit * 100) + 1;
            customerPriceLimit = random(); 
        }
        public void SetPreferences(Func<int> random)
        {
            SetSugarPreference(random);
            SetIcePreference(random);
            SetLemonPreference(random);
            SetPriceLimit(random);
        }
    }

}
