using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    class TurnsModel
    {
        private MySqlConnection db;
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
                if (!this.turnExist(hour, day, userId))
                {
                    db.Open();
                    query = "INSERT INTO gym_uda.turns(turn_day, turn_hour, user_id) VALUES('" + day + "', '" + hour + "', " + userId + ")";

                    command = new MySqlCommand(query, db);
                    command.ExecuteNonQuery();

                    statusCode = 201;
                    return statusCode;
                }
                statusCode = 409;
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
        public DataTable getAppoitments(int userId)
        {
            DataTable appointments = new DataTable();
            try
            {               
                db.Open();

                query = "SELECT turn_day, turn_hour FROM turns WHERE (user_id = " + userId + ")";
                command = new MySqlCommand(query, db);
                MySqlDataReader reader = command.ExecuteReader();
                appointments.Load(reader);

                return appointments;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return appointments;
            } finally
            {
                db.Close();
            }
        }
       
        public int deleteTurn(string hour, string day, int userId)
        {
            try
            {
                if (this.turnExist(hour, day, userId))
                {
                    db.Open();
                    query = "DELETE FROM turns WHERE (turn_day = '" + day + "' AND turn_hour ='" + hour + "' AND user_id = " + userId + ")";

                    command = new MySqlCommand(query, db);
                    command.ExecuteNonQuery();

                    statusCode = 200;
                    return statusCode;

                }
                statusCode = 404;
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
        private bool turnExist(string hour, string day, int userId)
        {
            try
            {
                int result;                
                db.Open();
                query = "SELECT turn_id FROM turns WHERE (turn_day = '" + day + "' AND turn_hour ='" + hour + "' AND user_id = " + userId + ")";
                command = new MySqlCommand(query, db);

                result = Convert.ToInt32(command.ExecuteScalar());

                statusCode = 200;
                if (result == 0)
                {
                    return false;

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " turnExist");
                statusCode = 500;
                return false;
            }
            finally
            {

                db.Close();
            }

        }
    }
}
