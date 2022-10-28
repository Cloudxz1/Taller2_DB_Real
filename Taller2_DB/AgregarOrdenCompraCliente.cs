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
    public partial class AgregarOrdenCompraCliente : Form
    {
        public AgregarOrdenCompraCliente()
        {
            InitializeComponent();
        }

        private void btnVolOrdCom_Click(object sender, EventArgs e)
        {
            MenuAdministrador volocc = new MenuAdministrador();
            volocc.Show();
            this.Hide();
        }

        private void btnVentaRealizada_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.close();
            ////////////////////// Buscar datos de la Venta////////////////////////
            //Datos del Cliente
            string query = "Select Distinct * from Cliente where Rut = '" + cmbListaRutCli.Text + "'";
            string rutCliente1 = conex.selectQueryScalar(query);

            //Buscar datos del Vendedor
            string query2 = "Select Distinct * from Vendedor where NumeroEmpleado = '" + cmbListaNumeroEmp + "'";
            string numVend = conex.selectQueryScalar(query2);

            //Buscar datos del Producto
            string query3 = "Select Distinct Id from Producto where Nombre = '" + cmbListaProductoVenta.Text + "'";
            string idProd = conex.selectQueryScalar(query3);

            //Buscar datos de la fecha actual de la fecha
            DateTime fechaHoraVenta = DateTime.Now;
            string fechaHoraStr = fechaHoraVenta.ToString("yyyy-MM-dd HH:mm:ss");

            ////////////////////Datos de Producto////////////////////////
            //Nombre del Producto
            string query4 = "Select Nombre from Producto where Nombre = '" + idProd + "'";
            string producto = conex.selectQueryScalar(query4);

            //Precio Producto
            string query5 = "Select Precio from Producto where Nombre = '" + idProd + "'";
            string precioProducto = conex.selectQueryScalar(query5);

            //Cantidad Producto
            string query6 = "Select CantidadStock from Producto where Nombre = '" + idProd + "'";
            string cantProdActual = conex.selectQueryScalar(query6);
            int valor1 = Int32.Parse(cantProdActual);

            //Descuento Producto
            string query7 = "Select Precio from Producto where Nombre = '" + idProd + "'";
            string descProdActual = conex.selectQueryScalar(query7);

            //Reduccion de la cantidad stock
            string query8 = "Select CantidadStock from Producto where Nombre = '" + idProd + "'";
            string nuevoStockProd = conex.selectQueryScalar(query8);

            string query9 = "Select CantidadStock from Producto where CantidadStock = '" + txtCantProdVenta.Text + "'";
            string ventaStockProd = conex.selectQueryScalar(query9);
            int valor2 = Int32.Parse(txtCantProdVenta.Text);

            //Nueva cantidad Stock Producto
            int nuevaCantStockProd = (valor1 - valor2);



   
            
          


            conex.close();
        }

        private void AgregarOrdenCompraCliente_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "SELECT DISTINCT * FROM Cliente";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListaRutCli.Items.Add(t.Rows[i]["Rut"]);
            }

            string query2 = "SELECT DISTINCT  * FROM Vendedor";
            DataTable t2 = conex.selectQuery(query2);

            for (int i = 0; i < t2.Rows.Count; i++)
            {
                cmbListaNumeroEmp.Items.Add(t2.Rows[i]["NumeroEmpleado"]);
            }

            string query3 = "Select DISTINCT * FROM Producto";
            DataTable t3 = conex.selectQuery(query3);

            for (int i = 0; i < t3.Rows.Count; i++)
            {
                cmbListaProductoVenta.Items.Add(t3.Rows[i]["Nombre"]);
            }
            conex.close();
        }
    }
}
