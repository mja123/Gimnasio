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
        private MySqlConnection db;
        private int statusCode;
        private MySqlCommand command;
        private string query;
        public UsersModel()
        {
            //Se inicializa la variable db con la conexión de la base de datos.
            db = ConfigDB.MySql;
        }
        public int createUser(string[] userData)
        {
            try
            {                
                if (this.userExist(userData[0]) != 500)
                {
                //Valida si el nombre de usuario solicitado existe.
                    db.Open();
                    //Se abre la conexión y se realiza la petición.
                    query = "INSERT INTO gym_uda.users(username, password) VALUES('" + userData[0] + "', '" + userData[1] + "') ";

                    command = new MySqlCommand(query, db);
                    command.ExecuteNonQuery();

                    statusCode = 201;
                } else
                {
                    statusCode = 409;
                }
                return statusCode;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message + " createUser");

                statusCode = 500;
                return statusCode;

            } finally
            {
                db.Close();
            }
        }
        public int getUser(string[] userData)
        {
            //Busca en la base de datos el usuario que ha ingresado.
            int result;
            try { 
                
                db.Open();
                Console.WriteLine("Opened");
               
                query = "SELECT user_id FROM users WHERE username ='" + userData[0] + "'AND password ='" + userData[1] + "' ";

                command = new MySqlCommand(query, db);      

                result = Convert.ToInt32(command.ExecuteScalar());

                //La petición devuelve el id, si es distinto de 0, significa que existe.
                if (result != 0)
                {
                    //Devuelve el id.
                    return result;                  
                } 

                statusCode = 404;
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
            //Método interno que valida si el nombre del usuario existe en la db.
            try
            {
                db.Open();

                query = "SELECT username FROM users WHERE '" + name + "' = username";

                command = new MySqlCommand(query, db);

                if (Convert.ToString(command) != name)
                {
                    //Si el usuario no existe, devuelve 404.
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
