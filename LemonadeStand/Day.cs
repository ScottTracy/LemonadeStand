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
        Customer customer = new Customer();
        Weather weather = new Weather();
        List<Dictionary<string,int>> customerList;
        int numberOfCustomers;
      
        
        
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
                customer.SetPreferences(RandomFunction);
                customerList.Add(customer.customerPreference);
            }
        }
        public  int RandomFunction()
        {
           return random.Next(customer.placeholderA, customer.placeholderB);
        }
        
    }
}
