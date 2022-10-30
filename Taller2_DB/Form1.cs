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
namespace Taller2_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton que accede al modo adiministrador del sistema
        /// Como: Ingresar, modificar, eliminar, realizar orden de compra, etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clave_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador admin = new Administrador();
            admin.Show();
        }
        /// <summary>
        /// Boton que accede al sub menu
        /// de las consultas de datos del sistema en general
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ConsultasDatos cons = new ConsultasDatos();
            cons.Show();
            this.Hide();
        }
    }
}
