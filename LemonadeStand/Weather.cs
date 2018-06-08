using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int temperature;
        public int sunAmount;
        public bool precipitation;
        Random random = new Random();

        public void SetTemperature()
        {
            temperature = random.Next(60, 101);
        }
        public void SetSunAmount()
        {
            sunAmount = random.Next(0, 5);
        }

    }
}
