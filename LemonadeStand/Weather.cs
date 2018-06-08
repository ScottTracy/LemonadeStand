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
        public int minimumTemperature = 60;
        public int maximumTemperature = 100;
        public int percentChanceOfRain = 20;
        public Dictionary<int, string> sunExpressions = new Dictionary<int, string> { { 0, "Cloudy" }, { 1, "Partly Cloudy" }, { 2, "Partly Sunny" } ,{ 3, "Sunny" } };
        Random random = new Random();

        public void SetTemperature()
        {
            temperature = random.Next(minimumTemperature, maximumTemperature + 1);
        }
        public void SetSunAmount()
        {
            sunAmount = random.Next(0, sunExpressions.Count+1);
        }
        public void SetPrecipitation()
        {
            int randomNumber = random.Next(0, 101);
            if (randomNumber <= percentChanceOfRain)
            {
                precipitation = true;
                sunAmount = 0;
            }
            else
            {
                precipitation = false;
            }
        }
        public void SetWeather()
        {
            SetTemperature();
            SetSunAmount();
            SetPrecipitation();
        }
        public string IsRaining()
        {
            if (precipitation)
            {
                return "rain all day";
            }
            else
            {
                return "drier conditions";
            }
        }
        public string HowSunny()
        {
            return sunExpressions[sunAmount]; 
        }
        public void GetForcast()
        {
            Console.WriteLine("Todays Forcast:");
            Console.WriteLine(temperature + "°, " + HowSunny() + " with " + IsRaining() + ".");

        }
    }
}
