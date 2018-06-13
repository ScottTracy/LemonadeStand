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


        public void SetSugarPreference(Func<int, int, int> random)
        {
           customerPreference["cups of sugar"] = random(1, maxSugarPerPitcher + 1);
        }
        public void SetIcePreference(Func<int, int, int> random)
        {
            customerPreference["lemons"] = random(1, maxIcePerPitcher + 1);
        }
        public void SetLemonPreference(Func<int, int, int> random)
        {
            customerPreference["cups of ice"] = random(1, maxLemonsPerPitcher + 1);
        }
        public void SetPriceLimit(Func<int, int, int> random)
        {
            customerPriceLimit = random(1, (int)(priceLimit * 100)  + 1);
        }
        public void SetPreferences(Action<int,int> random)
        {
            SetSugarPreference(random);
            SetIcePreference(random);
            SetLemonPreference(random);
            SetPriceLimit(random);
        }
    }

}
