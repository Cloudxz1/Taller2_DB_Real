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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btn_acceso_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT Clave FROM Contraseña";
            string clave = conex.selectQueryScalar(query);

            if (contrasenia.Text == "")
            {
                MessageBox.Show("Debe ingresar clave para entrar al sistema.");
            }
            if (contrasenia.Text != clave)
            {
                MessageBox.Show("La clave ingresada no coincide.");
            }
            if (contrasenia.Text == clave)
            {
                MessageBox.Show("Contraseña correcta", "Success");
                this.Hide();
                MenuAdministrador menu = new MenuAdministrador();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error");
            }
            conex.close();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
