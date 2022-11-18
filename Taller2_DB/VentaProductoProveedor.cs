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
            MySqlDataAdapter listProd, listaProv, listaProvProd;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable productos = new DataTable();
            string query = "SELECT Id,Nombre,CantidadStock FROM Producto";
            listProd = new MySqlDataAdapter(query, conex.GetConnection());

            listProd.Fill(productos);
            dataProd.DataSource = productos;

            DataTable proveedor = new DataTable();
            query = "SELECT Rut,Nombre FROM Proveedor";
            listaProv = new MySqlDataAdapter(query, conex.GetConnection());

            listaProv.Fill(proveedor);
            dataProv.DataSource = proveedor;

            DataTable ProductoProveedor = new DataTable();
            query = "SELECT ProveedorRut AS Rut_del_Proveedor,ProductoId AS ID_Producto, cantidad FROM Proveedor_Producto";
            listaProvProd = new MySqlDataAdapter(query, conex.GetConnection());

            listaProvProd.Fill(ProductoProveedor);
            dataProdProv.DataSource = ProductoProveedor;
            conex.close();
        }


        private void btn_ConfirmarProvProd_Click(object sender, EventArgs e)
        {
            //Solucion Provisional
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (txtRutProveedor.Text != "" && txtIdProducto.Text != "")
            {
                int cantVender = Int32.Parse(txtCantidadCompraProvProd.Text);

                        if (cantVender > 0)
                        {
                            //////////////Consultar Datos del Proveedor que NO posee producto///////////////
                            //Rut Proveedor
                            string query11 = "Select Rut From Proveedor where Rut = ('" + txtRutProveedor.Text + "')";
                            string RutProveedorProd = conex.selectQueryScalar(query11);

                            //Id Producto
                            string query2 = "Select Id From Producto Where Id = ('" + txtIdProducto.Text + "')";
                            string IdProd = conex.selectQueryScalar(query2);

                            //Cant stock Actual Producto
                            string query3 = "Select CantidadStock From Producto Where Id = ('" + IdProd + "')";
                            string CantStock = conex.selectQueryScalar(query3);
                            int cantstock = Int32.Parse(CantStock);
      
                                ///SI hay stock del producto
                                int diferencia = (cantstock - cantVender);

                                if (diferencia > 0)
                                {
                                    string query4 = "UPDATE Producto SET CantidadStock = ('" + diferencia + "') WHERE Id = ('" + IdProd + "')";
                                    int verificar = conex.executeNonQuery(query4);

                                    if (verificar == 1)
                                    {
                                        string query5 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, cantidad) VALUES('" + RutProveedorProd + "','" + IdProd + "','" + cantVender + "')";
                                        int ver2 = conex.executeNonQuery(query5);

                                        if (ver2 == 1)
                                        {
                                            //Mensaje de prueba, si compro y registro la cantidad
                                            MessageBox.Show("Proveedor si lo hizo");
                                            txtRutProveedor.Clear();
                                            txtIdProducto.Clear();
                                            txtCantidadCompraProvProd.Clear();
                                        }
                                        else
                                        {
                                            //Mensaje de prueba, si no compro y registro la cantidad
                                            MessageBox.Show("Proveedor no lo hizo");
                                        }
                                    }
                                }
                                //Si el proveedor compra TODO el stock del producto disponible
                                if (diferencia == 0)
                                {
                                    string query6 = "UPDATE Producto SET CantidadStock = ('" + diferencia + "') WHERE Id = ('" + IdProd + "')";
                                    int verificarsinstock = conex.executeNonQuery(query6);

                                    if (verificarsinstock == 1)
                                    {
                                        string query7 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, cantidad) VALUES('" + RutProveedorProd + "','" + IdProd + "','" + cantVender + "')";
                                        int verificarsinstock2 = conex.executeNonQuery(query7);

                                        if (verificarsinstock2 == 1)
                                        {
                                            //Mensaje de prueba, si compro y registro la cantidad
                                            MessageBox.Show("El Producto acaba de quedar agotado. Ya no posee stock disponible");
                                            txtRutProveedor.Clear();
                                            txtIdProducto.Clear();
                                            txtCantidadCompraProvProd.Clear();
                                        }
                                        //Poner algo contrario
                                    }
                                    //Poner algo contrario
                                }
                                //Poner algo contrario                           
                        }
                if (cantVender == 0)
                {
                    MessageBox.Show("Debe ingresar una cantidad al menos para continuar");
                }                                              
            }
            else
            {
                MessageBox.Show("Debe rellenar los datos para continuar");
            }
            conex.close();
        } 
        
        public void ProvSeguirProd()
        {

        }

    }
}


