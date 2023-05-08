namespace CarritoDeCompras
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaGestionCliente = new GestionClientes();
            ventanaGestionCliente.Show();
        }
    }
}