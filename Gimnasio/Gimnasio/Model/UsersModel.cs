using System;
using System.Collections.Generic;
using System.Data;
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
                MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO gym_uda.users(username, password) VALUES('" + userData[0] + "', '" + userData[1] + "') ", db);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                return "User created succesfully";
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "We coudn't created the user";
            }
        }
        public string getUser(string[] userData)
        {
            try { 
            db.Open();
                Console.WriteLine("Opened");
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT username, password FROM users WHERE username ='"+ userData[0] + "'AND password ='" + userData[1] + "' ", db);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(); 
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                return "User exist";
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "We coudn't found the user";
            }
}
    }
}
