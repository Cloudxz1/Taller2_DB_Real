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
            cmbRutCliCantOrdComp30d.DropDownStyle = ComboBoxStyle.DropDownList;
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
                string query = "Select c.Rut, o2.OrdenCompraId AS Ordenes_Realizadas, o1.FechaCompra, o2.cantProdVendido AS Total_Prod_Comprados from Cliente c INNER JOIN ordencompra o1 ON c.Rut=o1.ClienteRut INNER JOIN ordencompra_producto o2 ON o1.Id=o2.OrdenCompraId WHERE c.Rut =  '" + cmbRutCliCantOrdComp30d.Text + "' AND o1.FechaCompra BETWEEN CURDATE() - INTERVAL 30 DAY AND SYSDATE(); ";
                DataTable dt = conex.selectQuery(query);

                dgvCantOrdenCompCliObtenida.DataSource = dt;
                dgvCantOrdenCompCliObtenida.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar el rut de un cliente para continuar");
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
