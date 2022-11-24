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
        /// Muestra los productos que no poseen
        /// una orden de compra en el ultimo mes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosProductoSinOrdenCompraPorMes_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string mes = DateTime.Now.Month.ToString("d2");
            string ano = DateTime.Now.Year.ToString("d2");

            string query = "Select distinct o.Id AS ID_Orden, p.Id AS ID_Prod From Producto p INNER JOIN ordencompra o ON p.Id=o.Id WHERE MONTH(o.FechaCompra) NOT BETWEEN'" + mes + "' AND '" + ano + "'";

            DataTable t = conex.selectQuery(query);
            ListProdSinOrdCompDGV.DataSource = t;

        }

        private void ListProdSinOrdCompDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
