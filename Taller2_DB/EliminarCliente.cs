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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }

        private void EliminarCli_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            DataTable clientes = new DataTable();
            string eliminarcli = "SELECT Rut,Nombre,Saldo,Direccion,Telefono FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(eliminarcli, conex.GetConnection());

            adapter.Fill(clientes);
            conex.close();
            bool existeCli = false;

            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                if (clientes.Rows[i]["Rut"].ToString().Equals(rutEliminar.Text))
                {
                    existeCli = true;
                    break;
                }

            }
            if (existeCli)
            {
                ConexMySQL conex1 = new ConexMySQL();
                conex1.open();
                string query = "UPDATE Cliente SET estado = 1 WHERE Rut = ('" + rutEliminar.Text + "')";
                int saber = conex1.executeNonQuery(query);
                if (saber == 1)
                {
                    MessageBox.Show("Se ha eliminado correctamente el cliente", "Success");
                    MostrarClientes();
                }
            }
            else
            {
                MessageBox.Show("No existe el rut", "Error");
            }
            conex.close();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaclientes = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo,Direccion,Telefono FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaclientes);
            dataCliente.DataSource = tablaclientes;
            conex.close();
        }
        public void MostrarClientes()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaclientes = new DataTable();
            string query = "SELECT rut,nombre,saldo,Direccion FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaclientes);
            dataCliente.DataSource = tablaclientes;
            conex.close();
        }
    }
}
