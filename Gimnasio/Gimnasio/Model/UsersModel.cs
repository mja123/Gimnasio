using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Gimnasio.Model
{

    class UsersModel
    {
        private MySqlConnection db = ConfigDB.MySql;
        public UsersModel()
        {
        }

        public string createUser(string[] userData)
        {
            try
            {
                db.Open();
                Console.WriteLine("Opened");
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO users(username, password) VALUES('" + userData[0] + "', '" + userData[1] + "') ", db);
                Console.WriteLine("Created succesfully");
                return "Ok";
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }
    }
}
