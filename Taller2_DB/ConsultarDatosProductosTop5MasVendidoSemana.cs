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
    public partial class ConsultarDatosProductosTop5MasVendidoSemana : Form
    {
        public ConsultarDatosProductosTop5MasVendidoSemana()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton para volver al
        /// menu de consultas de datos del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolTop5ProdVend_Click(object sender, EventArgs e)
        {
            ConsultasDatos volTop5Prod = new ConsultasDatos();
            volTop5Prod.Show();
            this.Hide();
        }

        /// <summary>
        /// Consulta 12
        /// Muestra en pantalla el Top 5 de los Porductos mas Vendidos
        /// en la semana anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerTop5ProdVend_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select p1.Id AS Id_Prod, p1.Nombre AS Nomb_Prod, p1.Precio AS Precio_Prod, o2.FechaCompra, SUM(o1.cantProdVendido)AS Cant_Mas_Vendida from Producto p1 INNER JOIN ordencompra_producto o1 ON p1.Id=o1.ProductoId INNER JOIN ordencompra o2 ON o1.OrdenCompraId=o2.Id WHERE p1.Id=o1.ProductoId AND o1.OrdenCompraId=o2.Id AND DATE(NOW() - interval 1 week) GROUP BY p1.Nombre HAVING SUM(p1.Id) LIMIT 5;";
            DataTable t = conex.selectQuery(query);

            dgvTop5ProdMasVendSemAnt.DataSource = t;
            dgvTop5ProdMasVendSemAnt.Show();

            conex.close();
        }

        private void ConsultarDatosProductosTop5MasVendidoSemana_Load(object sender, EventArgs e)
        {

        }

        private void dgvTop5ProdMasVendSemAnt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
