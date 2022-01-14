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
        private int statusCode;
        public UsersModel()
        {
        }

        public int createUser(string[] userData)
        {

            try
            {
                if (this.getUser(userData) == 400)
                {
                    Console.WriteLine("here");
                    db.Open();
                    Console.WriteLine("Opened");

                    MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO gym_uda.users(username, password) VALUES('" + userData[0] + "', '" + userData[1] + "') ", db);

                    statusCode = 201;
                    return statusCode;
                } else
                {
                    return 400;
                }

               
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                statusCode = 409;
                return statusCode; ;
            }
        }
        public int getUser(string[] userData)
        {
            int result;
            try { 

                db.Open();
                Console.WriteLine("Opened");

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT user_id FROM users WHERE username ='"+ userData[0] + "'AND password ='" + userData[1] + "' ", db);      
                result = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                Console.WriteLine(result);
                if(result != 0)
                {
                    statusCode = 200;                  
                } else
                {
                    statusCode = 400;                    
                }
                                
                return statusCode;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                statusCode = 500;
                return statusCode;
            }
}
    }
}
