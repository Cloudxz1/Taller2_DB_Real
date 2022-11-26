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
    public partial class ConsultarDatosProvSuministranProd : Form
    {
        public ConsultarDatosProvSuministranProd()
        {
            InitializeComponent();           
            cmbRutProvSuminProd.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Los proveedores que suministran los productos
        /// en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (cmbRutProvSuminProd.Text != "")
            {
                string query = "Select p2.ProveedorRut, p1.Nombre, p3.Id, p3.Nombre, p2.precioUnitario, p3.CantidadStock, p2.cantidadSuministrada from proveedor p1 INNER JOIN proveedor_producto p2 ON p1.Rut=p2.ProveedorRut INNER JOIN producto p3 ON p2.ProductoId=p3.Id WHERE p1.Rut =  ('" + cmbRutProvSuminProd.Text + "')";
                DataTable t2 = conex.selectQuery(query);
                dgvProvSuminisProd.DataSource = t2;
                dgvProvSuminisProd.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor para continuar");
            }
        }

        private void ConsultarDatosProvSuministranProd_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Proveedor";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbRutProvSuminProd.Items.Add(t.Rows[i]["Rut"]);
            }
            conex.close();
        }

        private void btnVolProvSuminProd_Click(object sender, EventArgs e)
        {
            ConsultasDatos consultasDatos = new ConsultasDatos();
            consultasDatos.Show();
            this.Hide();
        }

        private void dgvProvSuminisProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
