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
    public partial class ConsultarDatosProductoCompradoClientePorAnio : Form
    {
        public ConsultarDatosProductoCompradoClientePorAnio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton para volver al menu de Consultas de Datos del Sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverProdCompCliAno_Click(object sender, EventArgs e)
        {
            ConsultasDatos volpprodcompclianio = new ConsultasDatos();
            volpprodcompclianio.Show();
            this.Hide();
        }

        /// <summary>
        /// Buscar el nombre del producto, en l cual el cliente
        /// se encuentra vinculado en la orden de compra
        /// en el anio actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscProdCliAnio_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            //dgvListProdCliAnio.DataSource = t2;
            //dgvListProdCliAnio.Show();

            if (cmbListProdCliAnio.Text != "")
            {
                int anio_actual = DateTime.Now.Year;
                string anio = anio_actual.ToString();

                string query = "Select o.Id AS ID_ORD, p.Id AS ID_PROD, COUNT(p.id) AS Cant_Prod From producto p INNER JOIN ordencompra o ON p.Id=o.ProductoId INNER JOIN  cliente c ON o.ClienteRut=c.Rut WHERE YEAR(o.FechaCompra) BETWEEN '" + anio + "' and '" + anio + "' AND c.Rut= '" + cmbListProdCliAnio.Text + "'";

                DataTable t2 = conex.selectQuery(query);
                dgvListProdCliAnio.DataSource = t2;
                dgvListProdCliAnio.Show();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un rut para continuar. ");
            }
            
        }

        /// <summary>
        /// Carga la lista con el rut en especifico del cliente
        /// para seleccionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosProductoCompradoClientePorAnio_Load(object sender, EventArgs e)
        {

            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "SELECT Rut FROM Cliente";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListProdCliAnio.Items.Add(t.Rows[i]["Rut"]);
            }
            conex.close();
        }
    }
}
