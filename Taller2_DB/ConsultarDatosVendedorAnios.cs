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
    public partial class ConsultarDatosVendedorAnios : Form
    {
        public ConsultarDatosVendedorAnios()
        {
            InitializeComponent();
        }

        private void btnVolDatosVendAnios_Click(object sender, EventArgs e)
        {
            ConsultasDatos volcons2 = new ConsultasDatos();
            volcons2.Show();
            this.Hide();
        }
    }
}
