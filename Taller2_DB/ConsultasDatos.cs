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
    public partial class ConsultasDatos : Form
    {
        public ConsultasDatos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Volver al menu principal del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverConsultas_Click(object sender, EventArgs e)
        {
            Form1 voladmin = new Form1();
            voladmin.Show();
            this.Hide();
        }

        private void btnVistoListado_Click(object sender, EventArgs e)
        {
            
        }

        private void ClienteSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Listado con los siguientes datos en el sistema:
        /// Proveedores, Clientes, Productos, Categorias y Vendedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListadoDatos_Click(object sender, EventArgs e)
        {
            ConsultarDatosListados conslis = new ConsultarDatosListados();
            conslis.Show();
            this.Hide();
        }

        /// <summary>
        /// Buscar un vendedor y desplegar sus datos
        /// incluido la edad en anios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatosVendedor1_Click(object sender, EventArgs e)
        {
            ConsultarDatosVendedorAnios consvenanios = new ConsultarDatosVendedorAnios();
            consvenanios.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Datos de los vendedores con mayor y menor antiguedad
        /// en anos(con un maximo de 2 vendedores mayores y menores)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendAntigTipo_Click(object sender, EventArgs e)
        {
            ConsultarDatosVendedorAntigMayorMenor consvat = new ConsultarDatosVendedorAntigMayorMenor();
            consvat.Show();
            this.Hide();
        }

        /// <summary>
        /// Categorias que se encuentra asociadas un producto especifico
        /// en el cual el cliente a comprado en la orden de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCategProd_Click(object sender, EventArgs e)
        {
            ConsultarDatosCategoriaProducto conscatpro = new ConsultarDatosCategoriaProducto();
            conscatpro.Show();
            this.Hide();
        }

        /// <summary>
        /// Cantidad de productos
        /// que fueron comprados por una categoria en especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCantProdCateg_Click(object sender, EventArgs e)
        {
            ConsultarDatosCantProductoCateg conscantpc = new ConsultarDatosCantProductoCateg();
            conscantpc.Show();
            this.Hide();
        }

        /// <summary>
        /// Datos de la orden de compra, incluido:
        /// cliente, vendedor y producto de al orden de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsOrdComp_Click(object sender, EventArgs e)
        {
            ConsultarDatosOrdenCompra datosOrdenCompra = new ConsultarDatosOrdenCompra();
            datosOrdenCompra.Show();
            this.Hide();
        }

        /// <summary>
        /// Productos comprados en un cierto dia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdCompDia_Click(object sender, EventArgs e)
        {
            ConsultarDatosProdCompradoPorDia prodCompradoPorDia = new ConsultarDatosProdCompradoPorDia();
            prodCompradoPorDia.Show();
            this.Hide();
        }

        /// <summary>
        /// Consulta los productos que no tiene una orden de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdSinOrdComp_Click(object sender, EventArgs e)
        {
            ConsultarDatosProductoSinOrdenCompraPorMes sinOrdenCompraPorMes = new ConsultarDatosProductoSinOrdenCompraPorMes();
            sinOrdenCompraPorMes.Show();
            this.Hide();
        }

        /// <summary>
        /// Consulta la categoria del producto comprado por el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdCompPorCateg_Click(object sender, EventArgs e)
        {
            ConsultarDatosProductoCompradoCategoria productoCompradoCategoria = new ConsultarDatosProductoCompradoCategoria();
            productoCompradoCategoria.Show();
            this.Hide();
        }

        private void ConsultasDatos_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Producto comprado por un cierto cliente
        /// durante el anio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdCompCliAno_Click(object sender, EventArgs e)
        {
            ConsultarDatosProductoCompradoClientePorAnio compradoClientePorAnio = new ConsultarDatosProductoCompradoClientePorAnio();
            compradoClientePorAnio.Show();
            this.Hide();
        }
    }
}
