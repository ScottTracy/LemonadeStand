using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    public class DatabaseLoader
    {
        SqlConnection connection;
        public DatabaseLoader()
        {
            connection = new SqlConnection("user id = MSI'\'scott_iclhpmu Server=MSI;Database=RockPaperScissors" +
                    "");
        }
        public void LoadData()
        {
            try
            {
                connection.Open();
               
            }
            catch
            {

            }
        }
    }
}
