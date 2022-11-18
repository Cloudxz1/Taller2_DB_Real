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
            txtRutProveedor.MaxLength = 9;

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
           /* 
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
                        DialogResult dr = MessageBox.Show("¿Seguro que desea confirmar? ", "Confirmación", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
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
                                    MessageBox.Show("Proveedor acaba de suministrar el producto con exito. ");
                                    txtRutProveedor.Clear();
                                    txtIdProducto.Clear();
                                    txtCantidadCompraProvProd.Clear();
                                }
                                else
                                {
                                    //Mensaje de prueba, si no compro y registro la cantidad
                                    MessageBox.Show("Proveedor no pudo suministrar el producto. ");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vuelva a intentarlo mas tarde. ");
                            txtRutProveedor.Clear();
                            txtIdProducto.Clear();
                            txtCantidadCompraProvProd.Clear();                          
                        }

                        //Si el proveedor compra TODO el stock del producto disponible
                        if (diferencia == 0)
                        {
                            DialogResult dr2 = MessageBox.Show("¿Seguro que desea confirmar? ", "Confirmación", MessageBoxButtons.YesNo);
                            if (dr2 == DialogResult.Yes)
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
                            }
                            else
                            {
                                MessageBox.Show("Vuelva a intentarlo mas tarde. ");
                                txtRutProveedor.Clear();
                                txtIdProducto.Clear();
                                txtCantidadCompraProvProd.Clear();                              
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
            */
        }

        
        /// <summary>
        /// Si el producto NO posee stock disponible para vender en el sistema
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
                MessageBox.Show("No hay stock para suministar el producto. Porfavor, seleccionar otro producto.");
                txtIdProducto.Clear();
                txtCantidadCompraProvProd.Clear();
            }
        }

        /// <summary>
        /// Validar el largo del rut del proveedor ingresado coincide en el sistema
        /// </summary>
        /// <returns></returns>
        public Boolean validarRut()
        {
            if (txtRutProveedor.Text.Length >= 8)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        ///Proveedor que ya realizo la venta de un producto, seguir relizando el mismo proceso
        /// </summary>
        /// 
        /*
        public void RutprovExiste()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            int cantvend2 = Int32.Parse(txtCantidadCompraProvProd.Text);

            ///Datos del proveedor
            //Rut Proveedor Actual
            string query11 = "Select Rut From Proveedor where Rut = ('" + txtRutProveedor.Text + "')";
            string RutProveedorA = conex.selectQueryScalar(query11);
;
            //////////////Datos del Producto Actual//////////////
            //Id Producto
            string query2 = "Select Id From Producto Where Id = ('" + txtIdProducto.Text + "')";
            string IdProdA = conex.selectQueryScalar(query2);
            //Cant stock Actual Producto
            string query3 = "Select CantidadStock From Producto Where Id = ('" + IdProdA + "')";
            string CantStockA = conex.selectQueryScalar(query3);
            int cantstockA = Int32.Parse(CantStockA);

            
            ////////////Datos del Proveedor-Producto//////////
            //Rut Proveedor Prov-Prod
            string query4 = "select ProveedorRut from proveedor_producto where ProveedorRut = ('" + RutProveedorA + "')";
            string RutProvProdE = conex.selectQueryScalar(query4);
            //Id Producto Prov-Prod
            string query5 = "select ProductoId from proveedor_producto where ProductoId = ('" + IdProdA + "')";
            string IdProvProdE = conex.selectQueryScalar(query5);
            //Stock Producro que ya vendio el proveedor
            string query66 = "select cantidad from proveedor_producto where ProveedorRut = ('" + RutProvProdE + "') and ProductoId = ('" + IdProvProdE + "')";
            string CantStockprodprovE = conex.selectQueryScalar(query66);
            int cantstockprodprovE = Int32.Parse(CantStockprodprovE);


            //Aumento de la cantidad stock del proveedor
            int aumento = (cantstockprodprovE + cantvend2);

            //Diderencia del stock del prod
            // int diferencia2 = (cantstock2 - cantvend2);

            if (cantstockA == 0)
            {
                cantstockprodprovCero();
            }

            if (txtRutProveedor.Text != "" && txtIdProducto.Text != "")
            {
                //Si es el mismo valor
                if (( RutProvProdE == RutProveedorA ) && (IdProvProdE == IdProdA))
                {
                    //si el valor es mayor a cero
                    if (cantvend2 > 0)
                    {
                        //Diderencia del stock del prod
                        int diferencia2 = (cantstockA - cantvend2);

                        if (diferencia2 > 0)
                        {
                            string query6 = "UPDATE Producto SET CantidadStock = ('" + diferencia2 + "') WHERE Id = ('" + IdProvProdE + "')";
                            int verificardif = conex.executeNonQuery(query6);

                            if (verificardif == 1)
                            {
                                string query7 = "Update proveedor_producto SET cantidad =  ('" + aumento + "') WHERE ProveedorRut = ('" + RutProvProdE + "') AND ProveedorRut = ('" + IdProvProdE + "')";
                                int verificaraum = conex.executeNonQuery(query7);

                                if (verificaraum == 1)
                                {
                                    MessageBox.Show("Producto a vuelto a ser vendido 1.");
                                }
                                else
                                {
                                    MessageBox.Show("No Funciono 1");
                                }
                            }
                            else
                            {
                                //No se verifico la dif
                            }
                        }
                        if (diferencia2 == 0)
                        {
                            string query8 = "UPDATE Producto SET CantidadStock = ('" + diferencia2 + "') WHERE Id = ('" + IdProvProdE + "')";
                            int verificardif2 = conex.executeNonQuery(query8);

                            if (verificardif2 == 1)
                            {
                                string query9 = "Update proveedor_producto SET cantidad =  ('" + aumento + "') WHERE ProveedorRut = ('" + RutProvProdE + "') AND ProveedorRut = ('" + IdProvProdE + "')";
                                int verificaraum2 = conex.executeNonQuery(query9);

                                if (verificaraum2 == 1)
                                {
                                    MessageBox.Show("Producto se ha quedado sin Stock 2 .");
                                }
                                else
                                {
                                    MessageBox.Show("No Funciono 2");
                                }
                            }
                            else
                            {
                                //No se verifico la dif
                            }
                        }
                        else
                        {
                            MessageBox.Show("No es Igual a cero");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede ser negativo");
                    }
                }
                else
                {
                    //Si No son iguales, diferentes
                    //Deberia hacer la compra normal
                    
                }
            }
            else
            {
                MessageBox.Show("Debes rellenar todos los campos para continuar");
            }
        }
        */
    }
}



