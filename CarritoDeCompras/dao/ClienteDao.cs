using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras.dao
{
    internal class ClienteDao
    {
        public void Connect()
        {
            string server = "localhost";
            string user = "root";
            string password = "";
            string database = "clientes";

            string connection = "Database=" + database + "; Data Source=" + server + "; User Id=" + user + "; Password=" + password + "";

            MySqlConnection connectionDb = new MySqlConnection(connection);
            connectionDb.Open();

            string query = "SELECT * FROM `cliente`";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = connectionDb;
            MySqlDataReader reader = command.ExecuteReader();

            string result = "";
            while (reader.Read())
            {
                result += reader.GetString(0);
            }

            string a = result;
        }
    }
}


