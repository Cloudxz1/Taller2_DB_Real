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
using MySql.Data.MySqlClient;

namespace Taller2_DB
{
    public partial class ConsultarDatosListados : Form
    {
        public ConsultarDatosListados()
        {
            InitializeComponent();
        }

        private void btnVolverListado_Click(object sender, EventArgs e)
        {
            ConsultasDatos volcons = new ConsultasDatos();
            volcons.Show();
            this.Hide();
        }

        private void btnListaCliente_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select Rut, Nombre, Saldo, Direccion, Telefono from Cliente;";
            DataTable dt = conex.selectQuery(query);
            ConsultarListadoDGV.DataSource = dt;
            ConsultarListadoDGV.Show();
            conex.close();
        }

        private void btnListaProveedor_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select * from Proveedor;";
            DataTable dt = conex.selectQuery(query);
            ConsultarListadoDGV.DataSource = dt;
            ConsultarListadoDGV.Show();
            conex.close();
        }

        private void btnListadoProducto_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select * from Producto;";
            DataTable dt = conex.selectQuery(query);
            ConsultarListadoDGV.DataSource = dt;
            ConsultarListadoDGV.Show();
            conex.close();
        }

        private void btnListadoCategoria_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select * from Categoria;";
            DataTable dt = conex.selectQuery(query);
            ConsultarListadoDGV.DataSource = dt;
            ConsultarListadoDGV.Show();
            conex.close();
        }

        private void btnListadoVendedor_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select * from Vendedor;";
            DataTable dt = conex.selectQuery(query);
            ConsultarListadoDGV.DataSource = dt;
            ConsultarListadoDGV.Show();
            conex.close();
        }
    }
}
