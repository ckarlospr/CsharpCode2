using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarritoDeCompras
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Tarjeta = txtTarjeta.Text;
            cliente.Tlefono = txtTelefono.Text;



            String nombre = txtNombre.Text;
            listCientes.Items.Add(cliente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int item = listCientes.SelectedIndex;
            listCientes.Items.RemoveAt(item);
        }
    }
}
