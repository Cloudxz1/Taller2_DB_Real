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
            cmbListProdCliAnio.DropDownStyle = ComboBoxStyle.DropDownList;
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
        /// Conulta 13
        /// Buscar el nombre del producto, en el cual el cliente
        /// se encuentra vinculado en la orden de compra
        /// en el anio actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscProdCliAnio_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (cmbListProdCliAnio.Text != "")
            {
                int anioactual = DateTime.Now.Year;
                string anio = anioactual.ToString();

                string query = "Select o1.OrdenCompraId, c.Rut, p.Id AS Id_Prod, o1.cantProdVendido AS Total_Comprado, o2.FechaCompra from Producto p INNER JOIN ordencompra_producto o1 ON p.Id=o1.ProductoId INNER JOIN ordencompra o2 ON o1.OrdenCompraId=o2.Id INNER JOIN Cliente c ON o2.ClienteRut=c.Rut WHERE YEAR(o2.FechaCompra) BETWEEN '" + anio + "' and '" + anio + "' AND c.Rut= '" + cmbListProdCliAnio.Text + "'";

                DataTable t2 = conex.selectQuery(query);
                dgvListProdCliAnio.DataSource = t2;
                dgvListProdCliAnio.Show();

            }
            else
            {
                MessageBox.Show("Debe seleccionar el rut de un cliente para continuar. ");
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
