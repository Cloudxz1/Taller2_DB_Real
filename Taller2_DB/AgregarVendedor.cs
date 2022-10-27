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
    public partial class AgregarVendedor : Form
    {
        public AgregarVendedor()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }

        private void btn_AgregarVend_Click(object sender, EventArgs e)
        {
            int salario = Int32.Parse(salEmp.Text);
            if (salario > 0)
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query = "INSERT INTO Vendedor VALUES('" + nEmp.Text + "','" + NomEmp.Text + "','" + salario + "',str_to_date('" + fEmp.Text + "', '%d-%c-%Y'))";

                int saber = conex.executeNonQuery(query);
                if (saber == 1)
                {
                    MessageBox.Show("Se ha registrado correctamente el empleado", "Success");
                    MostrarVendedor();
                }
                else
                {
                    MessageBox.Show("No se ha registrado correctamente el empleado", "Error");
                }
                conex.close();
            }
            else
            {
                MessageBox.Show("Debe ser un salario positivo","Error");
            }
        }

        private void AgregarVendedor_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaVendedor = new DataTable();
            string query = "SELECT * FROM Vendedor";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaVendedor);
            dataVendedor.DataSource = tablaVendedor;
            conex.close();
        }
        public void MostrarVendedor()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaVendedor = new DataTable();
            string query = "SELECT * FROM Vendedor";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaVendedor);
            dataVendedor.DataSource = tablaVendedor;
            conex.close();
        }
    }
}
