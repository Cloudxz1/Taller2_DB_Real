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
            cmbListClienteRutDia.DropDownStyle = ComboBoxStyle.DropDownList;

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

            string query = "Select Rut FROM Cliente";

            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListClienteRutDia.Items.Add(t.Rows[i]["Rut"]);
            }
        }

        /// <summary>
        /// Consulta 16
        /// Busca el producto que fue comprado por el cliente
        /// en una fecha en especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
         
            if (cmbListClienteRutDia.Text != "")
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
         
                string fecha = FechaCompraDGV.Value.ToString("yyyy-MM-dd");
                string query = "Select o2.OrdenCompraId AS Id_Orden, c.Rut AS Rut_Cliente, p.Id AS Id_Prod, p.Nombre AS Nom_Prod, o2.cantProdVendido, o1.FechaCompra from Cliente c INNER JOIN ordencompra o1 ON c.Rut=o1.ClienteRut INNER JOIN ordencompra_producto o2 ON o1.Id=o2.OrdenCompraId INNER JOIN producto p  ON o2.ProductoId=p.Id WHERE c.Rut = '" + cmbListClienteRutDia.Text + "' and o1.FechaCompra = '" + fecha + "';";

                DataTable t2 = conex.selectQuery(query);
                ListaProdCompDiaDGV.DataSource = t2;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el rut del cliente para continuar. ");
            }

           
        }
    }
}
