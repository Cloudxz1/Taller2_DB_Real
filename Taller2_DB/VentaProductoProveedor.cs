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
            cmbRutProveedorProvProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIDProdProvProd.DropDownStyle = ComboBoxStyle.DropDownList;
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
            string query = "SELECT Id,Nombre,Precio,CantidadStock FROM Producto";
            listProd = new MySqlDataAdapter(query, conex.GetConnection());

            listProd.Fill(productos);
            dataProd.DataSource = productos;

            DataTable proveedor = new DataTable();
            query = "SELECT Rut,Nombre FROM Proveedor";
            listaProv = new MySqlDataAdapter(query, conex.GetConnection());

            listaProv.Fill(proveedor);
            dataProv.DataSource = proveedor;

            DataTable ProductoProveedor = new DataTable();
            query = "SELECT ProveedorRut AS Rut_del_Proveedor,ProductoId AS ID_Producto, precioUnitario, cantidadSuministrada FROM Proveedor_Producto";
            listaProvProd = new MySqlDataAdapter(query, conex.GetConnection());

            listaProvProd.Fill(ProductoProveedor);
            dataProdProv.DataSource = ProductoProveedor;
            conex.close();

           
            for (int i = 0; i < proveedor.Rows.Count; i++)
            {
                cmbRutProveedorProvProd.Items.Add(proveedor.Rows[i]["Rut"]);
            }

            for (int i = 0; i < productos.Rows.Count; i++)
            {
                cmbIDProdProvProd.Items.Add(productos.Rows[i]["Id"]);
            }



        }

        /// <summary>
        /// Proveedor que vende un producto
        /// a un cierto precio y cierta cantidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConfirmarProvProd_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            //Buscar datos del Proveedor
            string queryprov = "select Rut from Proveedor where Rut = '" + cmbRutProveedorProvProd.Text + "'";
            string RutProvProd = conex.selectQueryScalar(queryprov);           
            //Buscar datos del Cliente
            string queryidprod = "select Id from Producto where Id = '" + cmbIDProdProvProd.Text + "'";
            string IDProdProv = conex.selectQueryScalar(queryidprod);
            //Cantidad de Producto
            string cantprodproveedor = txtCantidadCompraProvProd.Text;
            int cantprodproveedorInt = Int32.Parse(cantprodproveedor);
            //Precio Unitario del Producto
            string preciounitario = txtPrecioUnitarioProdProv.Text;
            int preciounitarioInt = Int32.Parse(preciounitario);


            if (cmbRutProveedorProvProd.Text != "" && cmbIDProdProvProd.Text != "" && txtPrecioUnitarioProdProv.Text != "" && txtCantidadCompraProvProd.Text != "")
            {
                if (cantprodproveedor.All(char.IsDigit) && (preciounitario.All(char.IsDigit)))
                {
                    if (preciounitarioInt > 0) {

                        if (cantprodproveedorInt > 0)
                        {
                            //Cantidad Stock Producto
                            string querystockprod = "select CantidadStock from Producto where Id = ('" + IDProdProv + "')";
                            string stockprod = conex.selectQueryScalar(querystockprod);
                            int stockprodInt = Int32.Parse(stockprod);

                            if ((cantprodproveedorInt == 0) && (preciounitarioInt == 0))
                            {
                                MessageBox.Show("Debe poseer una cantidad minima para realizar suministro. ");
                            }

                            if (stockprodInt == 0)
                            {
                                cantProdCero();
                            }
                            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            //Datos del Proveedor que ya realizo suministro previo
                            int verProveedor = validarProveedor();
                            int verID = validarIdProd();
                            if ((verProveedor == 1) && (verID == 1))
                            {
                                                               
                                //Buscar datos del Rut Proveedor-Producto
                                string queryprov2 = "Select ProveedorRut from proveedor_producto WHERE ProveedorRut = ('" + RutProvProd + "')";
                                string RutProvProd2 = conex.selectQueryScalar(queryprov2);

                                //Buscar Id Proveedor-Producto
                                string queryidprod2 = "Select ProductoId from proveedor_producto WHERE ProductoId = ('" + IDProdProv + "')";
                                string IDProdProv2 = conex.selectQueryScalar(queryidprod2);

                                //Cantidad Stock Proveedor-Producto
                                string querystockprovprod = "Select cantidadSuministrada from proveedor_producto WHERE ProveedorRut = ('" + RutProvProd2 + "') AND ProductoId = ('" + IDProdProv2 + "')";
                                string stockprovprod = conex.selectQueryScalar(querystockprovprod);
                                int stockprovprodInt = Int32.Parse(stockprovprod);

                                
                                    //Cantidad Stock Producto
                                    string querystockprod2 = "select CantidadStock from Producto where Id = ('" + IDProdProv + "')";
                                    string stockprod2 = conex.selectQueryScalar(querystockprod2);
                                    int stockprodInt2 = Int32.Parse(stockprod2);

                                    if (stockprodInt2 > cantprodproveedorInt)
                                    {
                                        cantProdCero();
                                    }

                                    if (cantprodproveedorInt > stockprodInt2)
                                    {
                                    MessageBox.Show("No puedes superar el stock disponible del producto. ");
                                    }

                                //diferencia 2, stock producto - cantidad a vender del proveedor
                                int dif2 = (stockprodInt2 - cantprodproveedorInt);
                                    if (dif2 > 0)
                                    {
                                        //Actualizar Stock Producto
                                        string queryactStockProd3 = "UPDATE Producto SET CantidadStock = ('" + dif2 + "') WHERE Id = ('" + IDProdProv + "')";
                                        int verificardif3 = conex.executeNonQuery(queryactStockProd3);
                                     
                                        if (verificardif3 == 1)
                                        {
                                            //Insertar Proveedor-Producto
                                            string insertarProvProd3 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, precioUnitario, cantidadSuministrada) VALUES ('" + RutProvProd + "','" + IDProdProv + "','" + preciounitarioInt + "','" + cantprodproveedorInt + "')";
                                            //Confirma
                                            MessageBox.Show("SI Funciona prov-prod 1");
                                        }
                                        else
                                        {
                                            MessageBox.Show("NO Funciona prov-prod 1");
                                        }
                                    }
                                    if (dif2 == 0)
                                    {
                                        //Actualizar Stock Producto
                                        string queryactStockProd4 = "UPDATE Producto SET CantidadStock = ('" + dif2 + "') WHERE Id = ('" + IDProdProv + "')";
                                        int verificardif4 = conex.executeNonQuery(queryactStockProd4);

                                        if (verificardif4 == 1)
                                        {
                                            //Insertar Proveedor-Producto
                                            string insertarProvProd4 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, precioUnitario, cantidadSuministrada) VALUES ('" + RutProvProd + "','" + IDProdProv + "','" + preciounitarioInt + "','" + cantprodproveedorInt + "')";
                                            MessageBox.Show("SI Funciona prov-prod 2, se acaba de agotar stock");
                                        }
                                        else
                                        {
                                            MessageBox.Show("NO Funciona prov-prod 2, aun no se agota stock");
                                        }
                                    }

                            }
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                            //Diferencia de stock
                            int diferenciastock2 = (stockprodInt - cantprodproveedorInt);

                            if (diferenciastock2 > 0)
                            {
                                //Actualizar Stock Producto
                                string queryactStockProd2 = "UPDATE Producto SET CantidadStock = ('" + diferenciastock2 + "') WHERE Id = ('" + IDProdProv + "')";
                                int verificardif2 = conex.executeNonQuery(queryactStockProd2);

                                //Insertar Proveedor-Producto
                                string insertarProvProd1 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, precioUnitario, cantidadSuministrada) VALUES ('" + RutProvProd + "','" + IDProdProv + "','" + preciounitarioInt + "','" + cantprodproveedorInt + "')";
                                int verificarProvProdInsertado = conex.executeNonQuery(insertarProvProd1);

                                if (verificarProvProdInsertado == 1)
                                {
                                    MessageBox.Show("El proveedor: " + RutProvProd + "Producto Suministado con exito");
                                }
                                else
                                {
                                    MessageBox.Show("No se verifico el registro, reintentar 1");
                                }
                            }

                            if (diferenciastock2 == 0)
                            {
                                //Actualizar Stock Producto
                                string queryactStockProd2 = "UPDATE Producto SET CantidadStock = ('" + diferenciastock2 + "') WHERE Id = ('" + IDProdProv + "')";
                                int verificardif2 = conex.executeNonQuery(queryactStockProd2);

                                //Insertar Proveedor-Producto
                                string insertarProvProd2 = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, precioUnitario, cantidadSuministrada) VALUES ('" + RutProvProd + "','" + IDProdProv + "','" + preciounitarioInt + "','" + cantprodproveedorInt + "')";
                                int verificarProvProdInsertado = conex.executeNonQuery(insertarProvProd2);

                                if (verificarProvProdInsertado == 1)
                                {
                                    MessageBox.Show("El proveedor: " + RutProvProd + "ha suministado todo el stock del producto. ");
                                }
                                else
                                {
                                    MessageBox.Show("No se verifico el registro, reintentar 2");
                                }
                            }                                                      
                        }
                        else
                        {
                            MessageBox.Show("La cantidad de producto no puede ser menor a 1");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El precio unitario no puede ser menor a 1");
                    }
                }
                else
                {
                    MessageBox.Show("El campo cantidad de producto tiene caracteres invalidos");
                }
            }
            //Si no hay datos
            if (cmbRutProveedorProvProd.Text == null || cmbIDProdProvProd.Text == null || txtPrecioUnitarioProdProv.Text == null || txtCantidadCompraProvProd.Text == null);
            {
                MessageBox.Show("Debe rellenar los campos para continiar. ");
            }
            if ((cantprodproveedorInt < 0) || (preciounitarioInt < 0))
            {
                MessageBox.Show("Los valores numericos deben ser positivos");
            }

            conex.close();
        }


        public void cantProdCero()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryprecioCero = "select CantStock from Producto where Id = ('" + cmbIDProdProvProd.Text + "')";
            int cantprodCero = conex.executeNonQuery(queryprecioCero);
            if (cantprodCero == 0)
            {
                MessageBox.Show("No hay stock para realizar suministro de producto. ");
            }
        }

        public int validarProveedor()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryrut = "Select Rut from proveedor WHERE Rut = '" + cmbRutProveedorProvProd.Text + "'";
            int verificacion = conex.executeNonQuery(queryrut);
            return verificacion;
        }

        public int validarIdProd()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryid = "Select Id from Producto WHERE id = '" + cmbIDProdProvProd.Text + "'";
            int verificacion2 = conex.executeNonQuery(queryid);
            return verificacion2;
        }

    }
}



