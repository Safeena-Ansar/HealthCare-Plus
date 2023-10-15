using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class DBConnection
    {
        public static bool connectiontest;
        public static MySqlConnection connectToDb()
        {
            MySqlConnection cnn;
            string connetionString = "server=localhost;database=healthcare_plus;uid=root;pwd='';";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                return cnn;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
