using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarritoDeCompras.dao;
using CarritoDeCompras.entities;
using MySqlX.XDevAPI;

namespace CarritoDeCompras
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        string clienteID = "0";

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.id = clienteID;
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Tarjeta = txtTarjeta.Text;
            cliente.Tlefono = txtTelefono.Text;

            ClienteDao dataBase = new ClienteDao();
            dataBase.saveCliente(cliente);
            updateList();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listCientes.SelectedItem;

            ClienteDao dataBase = new ClienteDao();
            dataBase.deleteCliente(cliente);
            updateList();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void updateList()
        {
            listCientes.Items.Clear();
            ClienteDao dataBase = new ClienteDao();
            List<Cliente> clienteListdb = dataBase.getClienteList();
            foreach (Cliente cliente in clienteListdb)
            {
                listCientes.Items.Add(cliente);
            }
            clearData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listCientes.SelectedItem;
            clienteID = cliente.id;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Tlefono;
            txtTarjeta.Text = cliente.Tarjeta;
        }

        private void clearData()
        {
            clienteID = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
        }
    }
}
