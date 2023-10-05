using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crud_2023.DAL
{
    internal class UtilsDAL
    {
        //método que realiza a conexão com o banco de dados
        public static MySqlConnection GetConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuario",
                UserID = "root",
                Password = ""
            };

            // criar conexão com o banco de dados
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            conn.Open(); // abre uma conexão
            return conn;
        }
    }
}
