using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    class PBsModel
    {       
 
        private MySqlConnection db;
        private int statusCode;
        private MySqlCommand command;
        private string query;

        public PBsModel()
        {
            db = ConfigDB.MySql;

        }
        public int newPb(ArrayList pbData, int userId)
        {
            try
            {
                db.Open();

                query = "INSERT INTO pbs(exercise, weight, reps, user_id) VALUES('" + pbData[0] + "', " + pbData[1] + ", " + pbData[2] + ", " + userId + ")";

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

        public DataTable getOnePB(string exercise, int userId)
        {
            DataTable pb = new DataTable();
            try
            {                          
                if (this.pbExist(exercise, userId))
                {
                    db.Open();

                    query = "SELECT exercise, weight, reps FROM pbs WHERE(exercise = '" + exercise + "' AND user_id = '" + userId + "')";
                    command = new MySqlCommand(query, db);

                   
                    MySqlDataReader reader = command.ExecuteReader();

                    pb.Load(reader);                 
                }
                return pb;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return pb;
            } finally
            {
                db.Close();
            }
        }

        public DataTable getPBs(int userId)
        {
            DataTable pbs = new DataTable();
            try
            {
                db.Open();

                query = "SELECT exercise, weight, reps FROM pbs WHERE (user_id = " + userId + ")";
                command = new MySqlCommand(query, db);
                MySqlDataReader reader = command.ExecuteReader();
                pbs.Load(reader);

                return pbs;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return pbs;
            }
            finally
            {
                db.Close();
            }
        }

        public int deletePb(string exercise, int userId)
        {
            try
            {
                if (this.pbExist(exercise, userId))
                {
                    db.Open();
                    query = "DELETE FROM pbs WHERE (exercise = '" + exercise + "' AND user_id = " + userId + ")";

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
        private bool pbExist(string exercise, int userId)
        {
            try
            {
                int result;
                db.Open();
                query = "SELECT pb_id FROM pbs WHERE (exercise = '" + exercise + "' AND user_id = " + userId + ")";
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
                Console.WriteLine(e.Message + " pbExist");
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
