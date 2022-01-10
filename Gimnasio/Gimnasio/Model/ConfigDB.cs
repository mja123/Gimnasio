using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    class ConfigDB
    {
        private MySqlConnection mySql = new MySqlConnection("Server=localhost; Database=gym_uda; Uid=root; Pwd=159123456asd");
        
        public ConfigDB()
        {
            try
            {
                mySql.Open();
                Console.WriteLine("Opened correctly");
            } catch (Exception e)
            {
                Console.WriteLine("Error openning" + e.Message);
            }
        }


    }
}
