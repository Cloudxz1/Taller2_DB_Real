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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            //Largo maximo de Rut ej: 129876540
            RutCliente.MaxLength = 9;

            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaCliente = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo,Direccion,Telefono FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaCliente);
            dataCliente.DataSource = tablaCliente;
            conex.close();
        }

        public void MostrarCliente()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablaCliente = new DataTable();
            string query = "SELECT Rut,Nombre,Saldo,Direccion,Telefono FROM Cliente WHERE estado = 0";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablaCliente);
            dataCliente.DataSource = tablaCliente;
            conex.close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int saldo = Int32.Parse(SaldoCli.Text);
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //Validar que los campos no se encuentren vacios 
            if (RutCliente.Text != "" || NombreCli.Text != "" || DireccionCli.Text != "" || tefelonoCli.Text != "")
            {
               
                //Validar que los campos del rut ingresado sean correctos
                if (validarRut() == true)
                {                 
                    //Validar que el saldo del cliente no sea un valor negativo
                    if (saldo>=0)
                    {
                        string query = "INSERT INTO Cliente VALUES('" + RutCliente.Text + "','" + NombreCli.Text + "','" + saldo.ToString() + "','" + DireccionCli.Text + "','" + tefelonoCli.Text + "',0)";
                        int saber = conex.executeNonQuery(query);
                        if (saber == 1)
                        {
                            MessageBox.Show("Se ingreso el cliente correctamente", "Success");
                            RutCliente.Clear();
                            NombreCli.Clear();
                            SaldoCli.Clear();
                            DireccionCli.Clear();
                            tefelonoCli.Clear();
                            MostrarCliente();
                        }
                        else
                        {
                            MessageBox.Show("No se ingreso el cliente correctamente", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El saldo no puede ser un valor negativo");
                    }
                }
                else
                {
                    MessageBox.Show("El largo del rut debe ser de 8 a 9 caracteres");
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }

            
            conex.close();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador menu = new MenuAdministrador();
            menu.Show();
        }
        //Funcion que determina si el largo del rut coincide
        public Boolean validarRut()
        {
            if (RutCliente.Text.Length>=8)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validacion para que el texto del datagridview
        /// no pueda modificarse de forma directa en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewBand band in dataCliente.Columns )
            {
                band.ReadOnly = true;
            }
        }
    }
}
