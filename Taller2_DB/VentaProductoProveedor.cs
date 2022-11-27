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
            string queryprov = "select Rut from Proveedor where Rut = ('" + cmbRutProveedorProvProd.Text + "')";
            string RutProvProd = conex.selectQueryScalar(queryprov);           
            //Buscar datos del Cliente
            string queryidprod = "select Id from Producto where Id = ('" + cmbIDProdProvProd.Text + "')";
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

                            if (stockprodInt == 0)
                            {
                                cantProdCero();
                            }

                            //Diferencia de stock
                            int diferenciastock2 = (stockprodInt - cantprodproveedorInt);

                            if (diferenciastock2 > 0)
                            {
                                //Actualizar Stock Producto
                                string queryactStockProd2 = "UPDATE Producto SET CantidadStock = ('" + diferenciastock2 + "') WHERE Id = ('" + IDProdProv + "')";
                                int verificardif2 = conex.executeNonQuery(queryactStockProd2);

                                //Insertar Proveedor-Producto
                                string insertarProvProd = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, precioUnitario, cantidadSuministrada) VALUES ('" + RutProvProd + "','" + IDProdProv + "','" + preciounitarioInt + "','" + cantprodproveedorInt + "')";
                                int verificarProvProdInsertado = conex.executeNonQuery(insertarProvProd);

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
                                string insertarProvProd = "INSERT INTO Proveedor_Producto(ProveedorRut, ProductoId, precioUnitario, cantidadSuministrada) VALUES ('" + RutProvProd + "','" + IDProdProv + "','" + preciounitarioInt + "','" + cantprodproveedorInt + "')";
                                int verificarProvProdInsertado = conex.executeNonQuery(insertarProvProd);

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
            else
            {
                MessageBox.Show("Rellenar campos para continuar");
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
    }
}



