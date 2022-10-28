using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
