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
            //Se inicializa la variable db con la conexión de la base de datos.
            db = ConfigDB.MySql;
        }
        public int newPb(ArrayList pbData, int userId)
        {
            try
            {
                //Se crea el PB.
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
            //Se selecciona un PB específico.
            DataTable pb = new DataTable();
            try
            {                          
                if (this.excerciseExist(exercise, userId))
                {
                    //Se valida si el ejercicio existe.
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
            //Se seleccionan todos los PBs del usuario.
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
            //Se eliminan los PBs de un ejercicio.
            try
            {
                if (this.excerciseExist(exercise, userId))
                {
                    //Se valida si el ejercicio existe.
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
        private bool excerciseExist(string exercise, int userId)
        {
            //Método que valida la existencia de un ejercicio.
            try
            {
                int result;
                db.Open();
                query = "SELECT pb_id FROM pbs WHERE (exercise = '" + exercise + "' AND user_id = " + userId + ")";
                command = new MySqlCommand(query, db);

                result = Convert.ToInt32(command.ExecuteScalar());

                //Responde con el id del PB, si es 0, retorna falso (no existe), de otra manera, verdadero.                
                if (result == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " pbExist");                
                return false;
            }
            finally
            {
                db.Close();
            }
        }
        public bool pbExist(string exercise, int weight, int reps, int userId)
        {
            //Valida si el PB existe
            try
            {
                int result;
                db.Open();
                query = "SELECT pb_id FROM pbs WHERE (exercise = '" + exercise + "' AND weight = " + weight + " AND reps = " + reps + " AND user_id = " + userId + ")";
                command = new MySqlCommand(query, db);

                result = Convert.ToInt32(command.ExecuteScalar());
                
                //Responde con el id del PB, si es 0, retorna falso (no existe), de otra manera, verdadero.
                if (result == 0)
                {
                    return false;

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " pbExist");                
                return false;
            }
            finally
            {
                db.Close();
            }

        }
    }
}
