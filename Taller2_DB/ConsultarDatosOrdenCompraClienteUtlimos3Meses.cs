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
    public partial class ConsultarDatosOrdenCompraClienteUtlimos3Meses : Form
    {
        public ConsultarDatosOrdenCompraClienteUtlimos3Meses()
        {
            InitializeComponent();
            cmbListRutOrdCompCli.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Consulta 11
        /// Busca el rut del cliente y despilega los datos del cliente y la orden de compra asociada,
        /// en especifico el monto total en los ultimos 3 meses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarRutOrdCompCli3M_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (cmbListRutOrdCompCli.Text != "")
            {             
                string query = "Select c.Rut, c.Nombre, c.Saldo, o1.OrdenCompraId AS Id_Orden, o2.MontoTotalOrden AS Monto_Total_Compras, o2.FechaCompra from ordencompra_producto o1 INNER JOIN ordencompra o2 ON o1.OrdenCompraId=o2.Id INNER JOIN cliente c ON o2.ClienteRut=c.Rut WHERE c.Rut = '" + cmbListRutOrdCompCli.Text + "' AND o2.FechaCompra >= CURDATE() AND o2.FechaCompra <= date_add(CURDATE(), INTERVAL 3 MONTH)";
                DataTable dt = conex.selectQuery(query);

                dgvListRutCliOrdComp3m.DataSource = dt;
                dgvListRutCliOrdComp3m.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar el rut de un cliente para continuar. ");
            }       
            conex.close();
        }

        /// <summary>
        /// Carga la lista de los rut del cliente
        /// en especifico que necesita para los datos de
        /// la orden de compra de los ultimos 3 meses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosOrdenCompraClienteUtlimos3Meses_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query3 = "SELECT Rut FROM Cliente";
            DataTable t3 = conex.selectQuery(query3);

            for (int i = 0; i < t3.Rows.Count; i++)
            {
                cmbListRutOrdCompCli.Items.Add(t3.Rows[i]["Rut"]);
            }
        }

        /// <summary>
        /// Volver al menu de las Consultas de Datos del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolOrdCompCli3Mes_Click(object sender, EventArgs e)
        {
            ConsultasDatos volconorcil3m = new ConsultasDatos();
            volconorcil3m.Show();
            this.Hide();
        }
    }
}
