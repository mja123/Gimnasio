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
        private MySqlCommand command;
        private string query;
        public UsersModel()
        {
            db = ConfigDB.MySql;

        }

        public int createUser(string[] userData)
        {

            try
            {
                Console.WriteLine(statusCode);
                if (this.userExist(userData[0]) != 500)
                {
                    db.Open();

                    query = "INSERT INTO gym_uda.users(username, password) VALUES('" + userData[0] + "', '" + userData[1] + "') ";
                    command = new MySqlCommand(query, db);
                    command.ExecuteNonQuery();
                    statusCode = 201;
                }
                return statusCode;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message + " createUser");
                statusCode = 409;
                return statusCode;

            } finally
            {
                db.Close();
            }
        }
        public int getUser(string[] userData)
        {
            int result;
            try { 

                db.Open();
                Console.WriteLine("Opened");

                query = "SELECT user_id FROM users WHERE username ='" + userData[0] + "'AND password ='" + userData[1] + "' ";
                command = new MySqlCommand(query, db);      
                result = Convert.ToInt32(command.ExecuteScalar());
                if(result != 0)
                {
                    return result;                  
                } else
                {
                    statusCode = 404;                    
                }
                return statusCode;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message + "getUser");
                statusCode = 500;
                return statusCode;
            } finally
            {
                db.Close();
            }
}       private int userExist(string name)
        {
            try
            {
                db.Open();
                query = "SELECT username FROM users WHERE '" + name + "' = username";
                command = new MySqlCommand(query, db);
                if (Convert.ToString(command) != name)
                {
                    statusCode = 404;

                }
                return statusCode;
            } catch(Exception e)
            {
                Console.WriteLine(e.Message + " UserExist");
                statusCode = 500;
                return statusCode;
            } finally
            {
                
                db.Close();
            }
            
        }
    }
}
