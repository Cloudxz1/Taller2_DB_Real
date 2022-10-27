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
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }

        private void btn_AgregarProv_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "INSERT INTO Proveedor VALUES('" + rutProv.Text + "','" + NomProv.Text + "','" + DirProv.Text + "')";
            int saber = conex.executeNonQuery(query);
            if (saber == 1)
            {
                MessageBox.Show("Se ingreso el proveedor correctamente", "Success");
                MostrarProveedor();
            }
            else
            {
                MessageBox.Show("No se ingreso el proveedor correctamente", "Error");
            }
            conex.close();
        }

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaProv = new DataTable();
            string query = "SELECT * FROM Proveedor";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaProv);
            dataProv.DataSource = tablaProv;
            conex.close();
        }
        public void MostrarProveedor()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable proveedor = new DataTable();
            string query = "SELECT * FROM Proveedor";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(proveedor);
            dataProv.DataSource = proveedor;
            conex.close();
        }
    }
}
