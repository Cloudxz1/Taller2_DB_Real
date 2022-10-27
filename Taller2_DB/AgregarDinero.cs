using MySql.Data.MySqlClient;
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
    public partial class AgregarDinero : Form
    {
        public AgregarDinero()
        {
            InitializeComponent();
        }

        private void btn_AgregarDinero_Click(object sender, EventArgs e)
        {
            int saldoNuevo1 = Int32.Parse(saldoNuevo.Text);
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            DataTable clientes = new DataTable();
            string abonarSaldo = "SELECT Rut,Nombre,Saldo FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(abonarSaldo, conex.GetConnection());
            adapter.Fill(clientes);
            conex.close();
            bool existeCli = false;

            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                if (clientes.Rows[i]["Rut"].ToString().Equals(rutCliente.Text))
                {
                    existeCli = true;
                    break;
                }

            }
            if (existeCli)
            {
                if (saldoNuevo1 > 0)
                {
                    DialogResult dr = MessageBox.Show("¿Seguro que desea realizar el cambio?", "Confirmación", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ConexMySQL conex1 = new ConexMySQL();
                        conex1.open();
                        string query = "SELECT Saldo FROM Cliente WHERE Rut = '" + rutCliente.Text + "'";
                        int saldoAntiguo = Int32.Parse(conex1.selectQueryScalar(query));
                        query = "UPDATE Cliente SET saldo = ('" + (saldoAntiguo + saldoNuevo1) + "') WHERE Rut = ('" + rutCliente.Text + "')";
                        int saber = conex1.executeNonQuery(query);
                        if (saber == 1)
                        {
                            MessageBox.Show("Se ha abonado saldo correctamente al cliente", "Success");
                            MostrarClienteSaldoNuevo();
                        }
                        else
                        {
                            MessageBox.Show("No se ha abonado saldo correctamente al cliente", "Error");
                        }
                        conex1.close();
                    }
                }
                else
                {

                    MessageBox.Show("No puede ser un saldo negativo", "Error");

                }

            }
            else
            {
                MessageBox.Show("No existe el rut", "Error");
            }
            conex.close();

        }

        private void AgregarDinero_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaclientes = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaclientes);
            dataCliente.DataSource = tablaclientes;
            conex.close();
        }
        public void MostrarClienteSaldoNuevo()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaclientes = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaclientes);
            dataCliente.DataSource = tablaclientes;
            conex.close();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }
    }
}
