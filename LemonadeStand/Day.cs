using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Random random = new Random();
        Weather weather = new Weather();
        List<Dictionary<string,double>> customerList;
        int numberOfCustomers;
        int placeholderA;
        int placeholderB;
        
        
        public void StartNewDay()
        {
            weather.SetWeather();
            weather.GetForcast();
        }
        public void SetNumberOfCustomers()
        {
            numberOfCustomers = weather.temperature;
        }
        public void CreateCustomers()
        {
            for(int i = 0; i< numberOfCustomers; i++)
            {
                Customer customer = new Customer();
                customer.SetPreferences(randomFunction(placeholderA, placeholderB));
            }
        }
        public void randomFunction(int min, int max)
        {
            random.Next(min, max);
        }
        
    }
}
