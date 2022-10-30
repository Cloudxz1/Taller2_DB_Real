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
    public partial class ConsultarDatosProdCompradoPorDia : Form
    {
        public ConsultarDatosProdCompradoPorDia()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Volver al menu de Consultas de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverProdCompDia_Click(object sender, EventArgs e)
        {
            ConsultasDatos volconppd = new ConsultasDatos();
            volconppd.Show();
            this.Hide();
        }
        /// <summary>
        /// Carga la lista de productos
        /// usando la Id del producto como referencia en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosProdCompradoPorDia_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "Select Id FROM Producto";

            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListProdCompDia.Items.Add(t.Rows[i]["Id"]);
            }
        }

        /// <summary>
        /// Busca el producto que fue comprado por el cliente
        /// en una fecha en especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
         
            if (cmbListProdCompDia.Text != "")
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string fecha = FechaCompraDGV.Value.ToString("yyyy-MM-dd");
                string query = "Select o.Id, o.FechaCompra, c.Rut AS Rut_Cliente, p.Id AS ID_Prod From ordencompra o INNER JOIN cliente c ON o.Id=c.Rut INNER JOIN producto p ON c.Rut=p.Id WHERE p.Id = '" + cmbListProdCompDia.Text + "' and o.FechaCompra = '" + fecha + "';";

                DataTable t2 = conex.selectQuery(query);
                ListaProdCompDiaDGV.DataSource = t2;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la Id de un producto para continuar.");
            }

           
        }
    }
}
