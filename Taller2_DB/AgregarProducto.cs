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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            categorias.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            Lista.CargarCategorias(categorias);
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable tablacategoria = new DataTable();
            string query = "SELECT * FROM Producto";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(tablacategoria);
            dataProductos.DataSource = tablacategoria;
            conex.close();
        }
        public void MostrarProductos()
        {
            MySqlDataAdapter adapter;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable Producto = new DataTable();
            string query = "SELECT * FROM Producto";
            adapter = new MySqlDataAdapter(query, conex.GetConnection());

            adapter.Fill(Producto);
            dataProductos.DataSource = Producto;
            conex.close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int precio = Int32.Parse(precioProd.Text);
            int cant = Int32.Parse(cantProd.Text);
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string categoria = "SELECT Id FROM Categoria WHERE Nombre ='" + categorias.Text + "'";
            int idCat = Int32.Parse(conex.selectQueryScalar (categoria));
            DialogResult dr = MessageBox.Show("¿Seguro desea agregar el producto?", "Confirmación", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (precio > 0)
                {
                   
                    string query = "INSERT INTO Producto VALUES('" + idProd.Text + "','"+ nombreProd.Text +"','" + precio + "','" + cant + "','"+idCat+"')";
                    int saber = conex.executeNonQuery(query);
                    if (saber == 1)
                    {
                        MessageBox.Show("Se ha registrado el producto correctamente", "Success");
                        MostrarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado el producto correctamente", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ser valores positivos", "Error");
                }

            }
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
