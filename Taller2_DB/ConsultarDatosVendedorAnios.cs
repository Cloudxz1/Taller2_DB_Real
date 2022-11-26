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
    public partial class ConsultarDatosVendedorAnios : Form
    {
        public ConsultarDatosVendedorAnios()
        {
            InitializeComponent();
            cmbListaVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolDatosVendAnios_Click(object sender, EventArgs e)
        {
            ConsultasDatos volcons2 = new ConsultasDatos();
            volcons2.Show();
            this.Hide();
        }

        private void ConsultarDatosVendedorAnios_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Vendedor";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListaVendedor.Items.Add(t.Rows[i]["NumeroEmpleado"]);
            }
            conex.close();
        }
        /// <summary>
        /// Consulta los datos del vendedor,
        /// incluidos los anios que lleva desepenando su trabajo
        /// en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBusVenAnios_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();          
            string query = "SELECT NumeroEmpleado AS Numero,Nombre,Salario,FechaContratacion,round(datediff(curdate(),FechaContratacion)/365) as Año_de_Antiguedad FROM vendedor WHERE NumeroEmpleado = '" + cmbListaVendedor.Text+"' ORDER BY round(datediff(curdate(),FechaContratacion)/365)";

            DataTable t2 = conex.selectQuery(query);

            ListVenAniosDGV.DataSource = t2;
            ListVenAniosDGV.Show();
        }
    }
}
