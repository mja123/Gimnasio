using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Model
{
    static class ConfigDB
    {
        //Establece la conexión de la base de datos en mySql y se establece su getter.
       static private MySqlConnection mySql = new MySqlConnection("Server=localhost; Database=gym_uda; Uid=root; Pwd=159123456asd");
       static public MySqlConnection MySql { get => mySql; }
    }
}
