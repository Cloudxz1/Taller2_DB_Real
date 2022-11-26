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
    public partial class ConsultarDatosCantTotalProdSuminProv : Form
    {
        public ConsultarDatosCantTotalProdSuminProv()
        {
            InitializeComponent();
            cmbRutProvCantTotProdSum.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Volver a las Consultas del Sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolCantTProdSuminProv_Click(object sender, EventArgs e)
        {
            ConsultasDatos volConsCantTotProdSuminProd = new ConsultasDatos();
            volConsCantTotProdSuminProd.Show();
            this.Hide();
        }

        /// <summary>
        /// Cantidad Total de los productos
        /// que fueron suministrados por un proveedor en especifico
        /// en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCantTotProdSumProv_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();


            if (cmbRutProvCantTotProdSum.Text != "")
            {
                string query = "Select p2.Rut AS Rut_Proveedor, p2.Nombre AS Nom_Prov, COUNT(p1.ProductoId)AS Prod_Encontados ,SUM(p1.cantidadSuministrada) AS Cant_Total_Suministada from proveedor_producto p1 INNER JOIN proveedor p2 ON p1.ProveedorRut=p2.Rut WHERE p2.Rut = ('" + cmbRutProvCantTotProdSum.Text + "')";
                DataTable t2 = conex.selectQuery(query);
                dgvCantTotProdSuminProv.DataSource = t2;
                dgvCantTotProdSuminProv.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el rut de un proveedor para continuar.");
            }

        }

        private void ConsultarDatosCantTotalProdSuminProv_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Proveedor";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbRutProvCantTotProdSum.Items.Add(t.Rows[i]["Rut"]);
            }
            conex.close();
        }
    }
}
