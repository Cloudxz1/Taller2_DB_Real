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
            query = "SELECT ProveedorRut AS Rut_del_Proveedor,ProductoId AS ID_Producto FROM Proveedor_Producto";
            listaProvProd = new MySqlDataAdapter(query,conex.GetConnection());

            listaProvProd.Fill(ProductoProveedor);
            dataProdProv.DataSource = ProductoProveedor;
            conex.close();
        }

        private void btn_ConfirmarProvProd_Click(object sender, EventArgs e)
        {
            
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            int cantVender = Int32.Parse(txtCantidadCompra.Text);
           

                if (cantVender>0)
                { 
                    string query0 = "Select Id From Producto Where Id = '" + txtIdProducto.Text + "')";
                    string idPro = conex.selectQueryScalar(query0);
                    
                    string query = "Select CantidadStock From Producto Where Id = '" + txtIdProducto.Text + "')";
                    string cantStock = conex.selectQueryScalar(query);
                    int StockA = Int32.Parse(cantStock);

                    int AumentoStock = (StockA + cantVender);
                    string aumentostock = AumentoStock.ToString();

                    string query2 = "UPDATE Producto SET CantidadStock = ('" + aumentostock + "') WHERE Id = ('" + idPro + "')";
                    int verificar = conex.executeNonQuery(query2);

                    if (verificar == 1)
                    {
                        MessageBox.Show("SI");
                        string query3 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId) VALUES('" + txtIdProveedor.Text + "','" + txtIdProducto.Text + "')";
                        int confirmar = conex.executeNonQuery(query3);                      
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad de productos no puede tener valores negativos");
                }

            conex.close();
        }
    }
}
