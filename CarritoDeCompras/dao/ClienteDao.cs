using CarritoDeCompras.entities;
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
        public MySqlConnection Connect()
        {
            string server = "localhost";
            string user = "root";
            string password = "";
            string database = "clientes";

            string connection = "Database=" + database + "; Data Source=" + server + "; User Id=" + user + "; Password=" + password + "";

            MySqlConnection connectionDb = new MySqlConnection(connection);
            connectionDb.Open();

            return connectionDb;
        }

        public List<Cliente> getClienteList()
        {
            List<Cliente> clienteList = new List<Cliente>();

            string query = "SELECT * FROM `cliente`";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = Connect();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = reader.GetString("id");
                cliente.Nombre=reader.GetString("nombre");
                cliente.Apellido=reader.GetString("apellido");   
                cliente.Tlefono=reader.GetString("telefono");
                cliente.Tarjeta=reader.GetString("tarjeta");

                clienteList.Add(cliente);
            }
            command.Connection.Close();

            return clienteList;
        }

        public void saveCliente(Cliente cliente)
        {
            string query = "";
            if (cliente.id == "")
            {
                query = "INSERT INTO `cliente` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta`) VALUES " +
                "(NULL, '" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Tlefono + "', '" + cliente.Tarjeta + "');";
            }else
            {
                query = "update cliente set nombre='"+cliente.Nombre+"', apellido='"+cliente.Apellido+"', " +
                    "telefono='"+cliente.Tlefono+"', tarjeta='"+cliente.Tarjeta+"' where id="+cliente.id+" ;";
            }
            
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = Connect();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        internal void deleteCliente(Cliente cliente)
        {
            string query = "DELETE FROM cliente WHERE id=" + cliente.id + ";";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = Connect();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}


