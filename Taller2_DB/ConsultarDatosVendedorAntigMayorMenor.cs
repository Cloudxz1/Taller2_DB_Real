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
    public partial class ConsultarDatosVendedorAntigMayorMenor : Form
    {
        public ConsultarDatosVendedorAntigMayorMenor()
        {
            InitializeComponent();
        }

        private void btnVolverVendAntigMayMen_Click(object sender, EventArgs e)
        {
            ConsultasDatos volvenmame = new ConsultasDatos();
            volvenmame.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
        private void VendedorMenAntiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void VendedorMayAntiDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Muestra a los vendedor menos antiguo en el sistema, minimo 2
        public void VendedorMenor()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "Select NumeroEmpleado AS Numero, Nombre, Salario, FechaContratacion AS Fecha_Contratacion, DATEDIFF(CURDATE(), FechaContratacion)/365 AS antiguedad From Vendedor Order by FechaContratacion Desc Limit 2;;";

            DataTable t1 = conex.selectQuery(query);

            VendedorMenAntiDGV.DataSource = t1;
        }
        //Muestra a los vendedores mas antiguo en el sistema, minimo 2
        public void VendedorMayor()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "Select NumeroEmpleado AS Numero, Nombre, Salario, FechaContratacion AS Fecha_Contratacion, DATEDIFF(CURDATE(), FechaContratacion)/365 AS antiguedad From Vendedor Order by FechaContratacion Asc Limit 2;;";

            DataTable t2 = conex.selectQuery(query);

            VendedorMayAntiDGV.DataSource = t2;
        }

        private void ConsultarDatosVendedorAntigMayorMenor_Load(object sender, EventArgs e)
        {
            VendedorMayor();
            VendedorMenor();
        }
    }
}
