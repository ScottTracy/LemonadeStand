using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace LemonadeStand
{
    class Connection
    {
        SqlConnection sql;
        public Connection()
        {
            sql = new SqlConnection("user id = MSI'\'scott_iclhpmu Server=MSI;Database=RockPaperScissors" +
                    "");
        }
        public void OpenConnection()
        {
            try
            {
                sql.Open();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }              
        }
        public void CloseConnection()
        {
            try
            {
                sql.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }
        public void ExecuteQueries(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, sql);
            cmd.ExecuteNonQuery();
        }




    }
}
