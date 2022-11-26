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
    public partial class ConsultarDatosProdSuministaProv : Form
    {
        public ConsultarDatosProdSuministaProv()
        {
            InitializeComponent();
            cmbProdSuministraProv.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Volver a las consultas del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolProdSuministraProv_Click(object sender, EventArgs e)
        {
            ConsultasDatos volconsProdSuminProv = new ConsultasDatos();
            volconsProdSuminProv.Show();
            this.Hide();
        }

        private void ConsultarDatosProdSuministaProv_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Producto";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbProdSuministraProv.Items.Add(t.Rows[i]["Id"]);
            }
            conex.close();
        }

        /// <summary>
        /// Consulta los datos del producto
        /// que fue suministrado por el proveedor en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdSuministraProd_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();


            if (cmbProdSuministraProv.Text != "")
            {
                string query = "Select p2.ProductoId, p1.Nombre, p1.Precio, p1.CantidadStock, p2.ProveedorRut, p2.cantidadSuministrada from producto p1 INNER JOIN proveedor_producto p2 ON p1.Id=p2.ProductoId INNER JOIN proveedor p3 ON p2.ProveedorRut=p3.Rut WHERE p1.Id = ('" + cmbProdSuministraProv.Text + "')";
                DataTable t2 = conex.selectQuery(query);
                dgvProdSuministraProd.DataSource = t2;
                dgvProdSuministraProd.Show();
            }
            else
            {
                MessageBox.Show("Seleccione el Id del producto para continuar. ");
            }
        }
    }
}
