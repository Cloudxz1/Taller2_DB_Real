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
    public partial class ConsultarDatosCantOrdenCompraClienteUltimos30dias : Form
    {
        public ConsultarDatosCantOrdenCompraClienteUltimos30dias()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Volver al menu de las consultas de datos
        /// en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolOrdCompCli30d_Click(object sender, EventArgs e)
        {
            ConsultasDatos volordcli30d = new ConsultasDatos();
            volordcli30d.Show();
            this.Hide();
        }

        /// <summary>
        /// Busca el rut del cliente y despilega los datos del
        /// cliente y la cantidad de la orden de compra asociada,
        /// en especifico en los ultimos 3 meses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarRutCliCantOrdComp30d_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (cmbRutCliCantOrdComp30d.Text != "")
            {
                string query = "Select COUNT(o.Id) AS Cant_Orden From ordencompra o INNER JOIN cliente c ON o.ClienteRut=c.Rut WHERE c.Rut =  '" + cmbRutCliCantOrdComp30d.Text + "' AND o.FechaCompra BETWEEN CURDATE() - INTERVAL 30 DAY AND SYSDATE(); ";
                DataTable dt = conex.selectQuery(query);

                dgvCantOrdenCompCliObtenida.DataSource = dt;
                dgvCantOrdenCompCliObtenida.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un rut para continuar");
            }
            conex.close();
        }

        /// <summary>
        /// Carga la lista de los rut del cliente
        /// en especifico que necesita para la
        /// cantidad de la orden de compra de los ultimos 30 dias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosCantOrdenCompraClienteUltimos30dias_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query3 = "SELECT Rut FROM Cliente";
            DataTable t3 = conex.selectQuery(query3);

            for (int i = 0; i < t3.Rows.Count; i++)
            {
                cmbRutCliCantOrdComp30d.Items.Add(t3.Rows[i]["Rut"]);
            }
        }
    }
}
