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
    public partial class VentaProductoProveedor : Form
    {
        public VentaProductoProveedor()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }

        private void VentaProductoProveedor_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter listProd,listaProv,listaProvProd;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable productos = new DataTable();
            string query = "SELECT Id,Nombre,CantidadStock FROM Producto";
            listProd = new MySqlDataAdapter(query, conex.GetConnection());

            listProd.Fill(productos);
            dataProd.DataSource = productos;

            DataTable proveedor = new DataTable();
            query = "SELECT Rut,Nombre FROM Proveedor";
            listaProv = new MySqlDataAdapter(query,conex.GetConnection());

            listaProv.Fill(proveedor);
            dataProv.DataSource = proveedor;

            DataTable ProductoProveedor = new DataTable();
            query = "SELECT * FROM Proveedor_Producto";
            listaProvProd = new MySqlDataAdapter(query,conex.GetConnection());

            listaProvProd.Fill(ProductoProveedor);
            dataProdProv.DataSource = ProductoProveedor;
            conex.close();
        }

        private void btn_ConfirmarProvProd_Click(object sender, EventArgs e)
        {
            int cantVender = Int32.Parse(txtCantidadCompra.Text);

            if (cantVender > 0)
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query = "SELECT CantidadStock FROM Producto WHERE Id ='"+txtIdProducto.Text+"'";
                int cantStock = Int32.Parse(conex.selectQueryScalar(query));

                    /**
                    * Consulta a la id del producto para verificar que sea el correcto
                    */
                    query = "SELECT Id FROM Producto WHERE Id ='"+txtIdProducto.Text+"'";
                    string idProd = conex.selectQueryScalar(query);
                    /**
                     *  Consulta al rut del Producto
                     */
                    query = "SELECT Rut FROM Proveedor WHERE Rut ='"+txtIdProveedor.Text+"'";
                    string rutProv = conex.selectQueryScalar(query);

                    /**
                     * 
                     */
                    InsertarProvProd(rutProv,idProd,cantVender);
                    
                    conex.close();
            }
            else
            {
                MessageBox.Show("Debe ser un valor positivo","Error"); 
            }

            
        }

        public void Mostrar()
        {
            MySqlDataAdapter listaProvProd;
            ConexMySQL conex = new ConexMySQL();
            DataTable ProductoProveedor = new DataTable();
            string query = "SELECT ProveedorRut AS Rut_del_Proveedor,ProductoId AS ID_Producto FROM Proveedor_Producto";
            listaProvProd = new MySqlDataAdapter(query, conex.GetConnection());

            listaProvProd.Fill(ProductoProveedor);
            dataProdProv.DataSource = ProductoProveedor;
            conex.close();
        }
        /**
         * Al realizar otra compra muere , al realizar una venta repetida se cae 
         */
        public void InsertarProvProd(string rutProveedor,string idProducto,int cantActual) {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query2 = "INSERT INTO Proveedor_Producto VALUES('" + rutProveedor + "','" + idProducto + "','" + cantActual + "')";
            int saber = conex.executeNonQuery(query2);

            if (saber == 1)
            {
                
                MessageBox.Show("Se ha hecho la venta", "Success");
                Mostrar();
            }
            else
            {

                MessageBox.Show("No", "Error");

            }
            conex.close();
        }
    }
}
