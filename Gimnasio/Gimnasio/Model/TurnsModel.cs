using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    class TurnsModel
    {
        private MySqlConnection db = ConfigDB.MySql;
        private int statusCode;
        private MySqlCommand command;
        private string query;

        public TurnsModel()
        {
            db = ConfigDB.MySql;
            
        }

        public int createTurn(string hour, string day, int userId)
        {
            try
            {               
                db.Open();
                query = "INSERT INTO gym_uda.turns(turn_day, turn_hour, user_id) VALUES('"+ day + "', '"+ hour +"', "+ userId +")";
                
                command = new MySqlCommand(query, db);
                command.ExecuteNonQuery();

                statusCode = 201;
                return statusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                statusCode = 500;
                return statusCode;
            }
            finally
            {
                db.Close();
            }
        }
        public int getUser(string[] userData)
        {
            int result;
            try
            {

                db.Open();
                Console.WriteLine("Opened");

                query = "SELECT user_id FROM users WHERE username ='" + userData[0] + "'AND password ='" + userData[1] + "' ";
                command = new MySqlCommand(query, db);
                result = Convert.ToInt32(command.ExecuteScalar());
                if (result != 0)
                {
                    statusCode = 200;
                }
                else
                {
                    statusCode = 404;
                }
                return statusCode;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "getUser");
                statusCode = 500;
                return statusCode;
            }
            finally
            {
                db.Close();
            }
        }
        private int userExist(string name)
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " UserExist");
                statusCode = 500;
                return statusCode;
            }
            finally
            {

                db.Close();
            }

        }
    }
}
