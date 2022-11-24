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
            cmbListaNumeroEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaProductoVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaRutCli.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolOrdCom_Click(object sender, EventArgs e)
        {
            MenuAdministrador volocc = new MenuAdministrador();
            volocc.Show();
            this.Hide();
        }
        /// <summary>
        /// Se encarga de realizra la orden de la compra
        /// de un cliente en especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVentaRealizada_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.close();
            ////////////////////// Buscar datos de la Venta////////////////////////
            //Buscar datos del Cliente
            string query = "Select Distinct Rut from Cliente where Rut = '" + cmbListaRutCli.Text + "'";
            string rutCliente = conex.selectQueryScalar(query);       

            //Buscar datos del Vendedor
            string query2 = "Select Distinct NumeroEmpleado from Vendedor where NumeroEmpleado = '" + cmbListaNumeroEmp.Text + "'";
            string numVend = conex.selectQueryScalar(query2);

            //Buscar datos del Producto
            string query3 = "Select Distinct Id from Producto where Nombre = '" + cmbListaProductoVenta.Text + "'";
            string idProd = conex.selectQueryScalar(query3);

            //Buscar datos de la fecha actual de la fecha
            DateTime fechaHoraVenta = DateTime.Now;
            string fechahoraventa = fechaHoraVenta.ToString("yyyy-MM-dd HH:mm:ss");

            string cantprodvend = txtCantProdVenta.Text;
            int cantprodvendInt = Int32.Parse(cantprodvend);

            if (cantprodvend != "" && cmbListaNumeroEmp.Text != "" && cmbListaRutCli.Text != "" && cmbListaProductoVenta.Text != "" )
            {
                if (cantprodvend.All(char.IsDigit))
                {
                    if (cantprodvendInt > 0)
                    {
                        string querysaldo = "Select Saldo from Cliente where Rut = '" + rutCliente + "'";
                        string saldorutCliente = conex.selectQueryScalar(querysaldo);
                        int saldocliente = Int32.Parse(saldorutCliente);

                        if (saldocliente <= 0)
                        {
                            MessageBox.Show("Cliente no posee saldo para la compra ");
                        }

                        string queryPrecioProd = "Select Precio from Producto where Id = '" + idProd + "'";
                        string precioProd = conex.selectQueryScalar(queryPrecioProd);
                        int precioProd2 = Int32.Parse(saldorutCliente);

                        if (saldocliente < precioProd2)
                        {
                            MessageBox.Show("Cliente no posee saldo para la compra ");
                        }
                       
                        //Diferencia del saldo del cliente y el precio del producto
                        int diferenciaSaldoPrecio = (saldocliente - precioProd2);
                        //Descuento(NO ha sido usado, solo inserta)
                        int descuento = Int32.Parse(txtDescuentoProd.Text);
                        //Cantidad por Producto
                        int cantPorProducto = (precioProd2 * cantprodvendInt);
                        //
                        //Stock Producto
                        string querystockProd = "Select CantStock from Producto where Id = '" + idProd + "'";
                        string stock = conex.selectQueryScalar(querystockProd);
                        int stockActual = Int32.Parse(stock);
                        //Diferencia del Stock Producto
                        int diferenciaStock =  (stockActual - cantprodvendInt);

                        //Actualizar
                        //Saldo cliente
                        string queryactSaldoCli = "UPDATE Cliente SET Saldo = ('" + diferenciaSaldoPrecio + "') WHERE Rut = ('" + rutCliente + "')";
                        //Stock Producto
                        string queryactStockProd = "UPDATE Producto SET CantidadStock = ('" + diferenciaStock + "') WHERE Id = ('" + idProd + "')";  
                        
                        //Insertar
                        //Realizar Orden de la Compra
                        string insertarOrden = "INSERT INTO OrdenCompra(Id, FechaCompra, PorcentajeDescuento, VendedorNumeroEmpleado, ClienteRut) VALUES('" + fechahoraventa + "','" + descuento + "','" + numVend + "','" + rutCliente + "')";
                        //Orden Compra del Producto
                        //string insertarOrdenProd = "INSERT INTO OrdenCompra_Producto(OrdenCompraId, ProductoId, cantidad) VALUES ('" +  + "','" + idProd + "','" + diferenciaStock + "')";
                        string insertarOrdenProd = "INSERT INTO OrdenCompra_Producto(OrdenCompraId, ProductoId, cantidad) VALUES ('" + idProd + "','" + diferenciaStock + "')";

                        int verificarOrden = conex.executeNonQuery(insertarOrdenProd);
                        if (verificarOrden == 1)
                        {
                            MessageBox.Show("Si compro");
                            txtCantProdVenta.Clear();
                            txtDescuentoProd.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No Compro");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de producto no puede ser menor a 1");
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

        /// <summary>
        /// Carga el listado de los vendedores, clientes y el producto
        /// en especificos, asociados para la orden de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
