using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
namespace Taller2_DB
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaCliente = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo,Direccion,Telefono FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaCliente);
            dataCliente.DataSource = tablaCliente;
            conex.close();
        }

        public void MostrarCliente()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaCliente = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo,Direccion,Telefono FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaCliente);
            dataCliente.DataSource = tablaCliente;
            conex.close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int saldo = Int32.Parse(SaldoCli.Text);
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "INSERT INTO Cliente VALUES('" + RutCliente.Text + "','" + NombreCli.Text + "','"+saldo+"','" + DireccionCli.Text + "','" + tefelonoCli.Text + "',0)";
            int saber = conex.executeNonQuery(query);
            if (saber == 1)
            {
                MessageBox.Show("Se ingreso el cliente correctamente", "Success");
                MostrarCliente();
            }
            else
            {
                MessageBox.Show("No se ingreso el cliente correctamente", "Error");
            }
            conex.close();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }
    }
}
