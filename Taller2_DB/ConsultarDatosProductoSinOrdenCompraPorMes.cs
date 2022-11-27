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
    public partial class ConsultarDatosProductoSinOrdenCompraPorMes : Form
    {
        public ConsultarDatosProductoSinOrdenCompraPorMes()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Volver al menu de Consultas del Sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverProdSinOrdCom_Click(object sender, EventArgs e)
        {
            ConsultasDatos volprosinoc = new ConsultasDatos();
            volprosinoc.Show();
            this.Hide();
        }
        /// <summary>
        /// Consulta 15
        /// Muestra los productos que no poseen
        /// una orden de compra en el ultimo mes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosProductoSinOrdenCompraPorMes_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            //Mes
            string mes = DateTime.Now.Month.ToString("d");
            //Anio
            string ano = DateTime.Now.Year.ToString("d");

            string query = "Select p.Id AS Id_Prod, p.Nombre AS Nombre_Prod, p.Precio AS Precio_Prod, p.CantidadStock AS Cant_Stock  from ordencompra o1 INNER JOIN ordencompra_producto o2 ON o1.Id=o2.OrdenCompraId INNER JOIN producto p ON o2.ProductoId=p.Id WHERE MONTH(o1.FechaCompra) NOT between'" + mes + "' AND '" + ano + "'";

            DataTable t = conex.selectQuery(query);
            ListProdSinOrdCompDGV.DataSource = t;

        }

        private void ListProdSinOrdCompDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
