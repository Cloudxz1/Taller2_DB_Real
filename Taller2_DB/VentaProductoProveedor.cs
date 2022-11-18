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
                    string query1 = "Select Rut From Proveedor where Rut = ('" + txtRutProveedor.Text + "')";
                    string RutProveedorProd = conex.selectQueryScalar(query1);

                    //Id Producto
                    string query2 = "Select Id From Producto Where Id = ('" + txtIdProducto.Text + "')";
                    string IdProd = conex.selectQueryScalar(query2);

                    //Cant stock Actual Producto
                    string query3 = "Select CantidadStock From Producto Where Id = ('" + IdProd + "')";
                    string CantStock = conex.selectQueryScalar(query3);
                    int cantstock = Int32.Parse(CantStock);

                    if (cantstock == 0)
                    {
                        cantstockprodprovCero();
                    }

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
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una cantidad minima para continuar");
                }
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos para continuar");
            }
            conex.close();
        }

        /// <summary>
        /// Un proveedor que ya realizo la venta
        /// de un producto, seguir relizando el
        /// mismo proceso
        /// </summary>
        /// 
        /*
        public void ProvSeguirProd()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            int cantVenderprodprov = Int32.Parse(txtCantidadCompraProvProd.Text);

            /////////////Datos del proveedor a comparar//////////////
            //Rut Proveedor
            string query1 = "Select Rut From Proveedor where Rut = ('" + txtRutProveedor.Text + "')";
            string RutProvProd2 = conex.selectQueryScalar(query1);

            //Id Producto
            string query2 = "Select Id From Producto Where Id = ('" + txtIdProducto.Text + "')";
            string IdProvProd2 = conex.selectQueryScalar(query2);

            //Cant stock Actual Producto
            string query3 = "Select CantidadStock From Producto Where Id = ('" + RutProvProd2 + "')";
            string CantStock2 = conex.selectQueryScalar(query3);
            int cantstock2 = Int32.Parse(CantStock2);

            //////////////Datos del proveedor que ya posee producto///////////
            //Rut Proveedor que ya posee producto
            string query4 = "select ProveedorRut from proveedor_producto where ProveedorRut = ('" + txtRutProveedor.Text + "')";
            string RutProveedorProd3 = conex.selectQueryScalar(query4);

            //Id Producto que ya posee producto
            string query5 = "select ProductoId from proveedor_producto where ProductoId = ('" + txtIdProducto.Text + "')";
            string IdProd3 = conex.selectQueryScalar(query5);

            //Stock que ya posee producto
            string query6 = "select cantidad from proveedor_producto where cantidad = ('" + IdProd3 + "')";
            string CantStockprodprov = conex.selectQueryScalar(query6);
            int cantstockprodprov = Int32.Parse(CantStockprodprov);


            if ((RutProvProd2 == RutProveedorProd3) && (IdProvProd2 == IdProd3))
            {

                if (cantVenderprodprov > 0)
                {
                    int diferencia2 = cantstock2 - cantVenderprodprov;

                    if (diferencia2 > 0)
                    {
                        string query7 = "UPDATE Producto SET CantidadStock = ('" + diferencia2 + "') WHERE Id = ('" + IdProvProd2 + "')";
                        int verificarprovprod = conex.executeNonQuery(query7);

                        if (verificarprovprod == 1)
                        {
                            int aumento = cantstockprodprov + cantVenderprodprov;

                            string query8 = "update proveedor_producto set cantidad = ('" + aumento + "') WHERE ProveedorRut = ('" + RutProveedorProd3 + "') and ProductoId = ('" + IdProd3 + "')";
                            int verificarprovprod2 = conex.executeNonQuery(query8);

                            if (verificarprovprod2 == 1)
                            {
                                MessageBox.Show("Funciono");
                            }
                            else
                            {
                                MessageBox.Show("No Funciono");
                            }

                        }
                    }
                    if (diferencia2 == 0)
                    {
                        MessageBox.Show("Echale ganas mijo");
                    }

                }

            }

        }
    }
        */
        //

        /// <summary>
        /// Si el producto NO posee stock disponible
        /// para vender en el sistema
        /// </summary>
        public void cantstockprodprovCero()
        {

            ConexMySQL conex = new ConexMySQL();
            conex.open();

            //Id Producto
            string query = "Select Id From Producto Where Id = ('" + txtIdProducto.Text + "')";
            string considprod = conex.selectQueryScalar(query);

            //Cant stock Actual Producto
            string query2 = "Select CantidadStock From Producto Where Id = ('" + considprod + "')";
            string CantStock = conex.selectQueryScalar(query2);
            int conscantstock = Int32.Parse(CantStock);

            if (conscantstock == 0)
            {
                MessageBox.Show("No hay stock para realizar la venta. Seleccionar otro producto");
                txtIdProducto.Clear();
                txtCantidadCompraProvProd.Clear();
            }
        }
    }
}



