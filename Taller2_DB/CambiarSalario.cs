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
    public partial class CambiarSalario : Form
    {
        public CambiarSalario()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }

        private void CambiarSalario_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter listaEmp;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable vendedor = new DataTable();
            string query = "SELECT NumeroEmpleado,salario FROM Vendedor";
            listaEmp = new MySqlDataAdapter(query, conex.GetConnection());

            listaEmp.Fill(vendedor);
            dataVendedor.DataSource = vendedor;
            conex.close();
        }
        public void MostrarVendedor()
        {
            MySqlDataAdapter listaEmp;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable vendedor = new DataTable();
            string query = "SELECT NumeroEmpleado,salario FROM Vendedor";
            listaEmp = new MySqlDataAdapter(query, conex.GetConnection());

            listaEmp.Fill(vendedor);
            dataVendedor.DataSource = vendedor;
            conex.close();
        }

        private void btn_Cambiar_Click(object sender, EventArgs e)
        {
            int salario = Int32.Parse(salarioN.Text);
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            DataTable t = new DataTable();
            string vendedor = "SELECT NumeroEmpleado,salario FROM Vendedor";
            adapter = new MySqlDataAdapter(vendedor, conex.GetConnection());

            adapter.Fill(t);
            conex.close();
            bool existeVendedor = false;

            for (int i = 0; i < t.Rows.Count; i++)
            {
                if (t.Rows[i]["NumeroEmpleado"].ToString().Equals(nVendedor.Text))
                {
                    existeVendedor = true;
                }

            }
            if (existeVendedor)
            {
                if (salario > 0)
                {
                    ConexMySQL conex1 = new ConexMySQL();
                    conex1.open();
                    string query = "UPDATE Vendedor SET salario = ('" + salario + "') WHERE NumeroEmpleado = ('" + nVendedor.Text + "') ";
                    int saber = conex1.executeNonQuery(query);
                    if (saber == 1)
                    {
                        MessageBox.Show("Se ha modificado correctamente el salario del empleado");
                        MostrarVendedor();
                    }
                    conex1.close();

                }
                else
                {
                    MessageBox.Show("El salario debe ser positivo","Error");
                }
                
            }
            else
            {
                MessageBox.Show("El rut ingresado no existe", "Error");
            }
            conex.close();
        }
    }
}
