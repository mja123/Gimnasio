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
            //Se inicializa la variable bd con la conexión de la base de datos.
            db = ConfigDB.MySql;            
        }

        public int createTurn(string hour, string day, int userId)
        {
            //Crea el turno
            try
            {  
                if (!this.turnExist(hour, day, userId))
                {
                    //Valida si el turno existe, de no existir, lo crea.
                    db.Open();
                    query = "INSERT INTO gym_uda.turns(day, hour, user_id) VALUES('" + day + "', '" + hour + "', " + userId + ")";

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
            //Crea una tabla en donde se insertan todos los turnos del usuario.
            DataTable appointments = new DataTable();
            try
            {               
                db.Open();

                query = "SELECT day, hour FROM turns WHERE (user_id = " + userId + ")";
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
            //Elimina un turno.
            try
            {
                if (this.turnExist(hour, day, userId))
                {
                    //Valida si el turno existe, de ser así, lo elimina.
                    db.Open();
                    query = "DELETE FROM turns WHERE (day = '" + day + "' AND hour ='" + hour + "' AND user_id = " + userId + ")";

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
            //Método interno que valida si el turno solicitado existe en la db.
            try
            {
                int result;                
                db.Open();

                query = "SELECT turn_id FROM turns WHERE (day = '" + day + "' AND hour ='" + hour + "' AND user_id = " + userId + ")";
                command = new MySqlCommand(query, db);

                result = Convert.ToInt32(command.ExecuteScalar());
                //La petición devuelve el id del turno, de existir (distinto de 0), se retorna verdadero, caso contrario, falso.
                
                if (result == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " turnExist");
                return false;
            }
            finally
            {
                db.Close();
            }
        }
    }
}
