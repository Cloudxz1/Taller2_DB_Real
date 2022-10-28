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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablacategoria = new DataTable();
            string query = "SELECT * FROM Categoria ORDER BY Id ASC";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablacategoria);
            dataCategorias.DataSource = tablacategoria;
            conex.close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            validarCategoria();
        }

        public void validarCategoria()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            DialogResult dr = MessageBox.Show("¿Seguro que desea agregar la categoria?", "Confirmación", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                if (nombreCat.Text != "" && DescripCat.Text != "")
                {
                    string query = "INSERT INTO Categoria(Nombre,Descripcion) VALUES('" + nombreCat.Text + "','" + DescripCat.Text + "')";
                    int saber = conex.executeNonQuery(query);

                    if (saber == 1)
                    {
                        string query2 = "SELECT Nombre FROM Categoria WHERE Nombre = '" + nombreCat.Text + "'";
                        int estacat = conex.executeNonQuery(query2);

                        if (estacat == 1)
                        {
                            MessageBox.Show("Esta categoria ya existe");
                        }
                        else
                        {
                            MessageBox.Show("Se ha registrado la categoria");
                            nombreCat.Clear();
                            DescripCat.Clear();
                            MostrarCategorias();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta categoria ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Porfarvor, rellenar los campos correctamente");
                }
            }
            conex.close();
        }

        public void MostrarCategorias()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable Cat = new DataTable();
            string query = "SELECT * FROM Categoria ORDER BY Id ASC";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(Cat);
            dataCategorias.DataSource = Cat;
            conex.close();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador admin = new MenuAdministrador();
            admin.Show();
        }
    }


}
