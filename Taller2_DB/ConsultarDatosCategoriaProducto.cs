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
    public partial class ConsultarDatosCategoriaProducto : Form
    {
        public ConsultarDatosCategoriaProducto()
        {
            InitializeComponent();
        }

        private void btnVolverCatProd_Click(object sender, EventArgs e)
        {
            ConsultasDatos volcatpro = new ConsultasDatos();
            volcatpro.Show();
            this.Hide();
        }
        //Funcion que busca la categoria que se encuentra asociado el producto
        private void btnBuscarListCateg_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "Select p.Id, p.Nombre AS Nombre_Prod, c.Nombre AS Nombre_Cat,c.Descripcion, p.Precio, p.CantidadStock FROM categoria c INNER JOIN producto p ON c.Id=p.Id WHERE c.Nombre= '" + cmbListaCategoria1.Text + "'";

            DataTable t2 = conex.selectQuery(query);

           CategProdDGV.DataSource = t2;
           CategProdDGV.Show();
        }
        //Consulta en forma de ComboBox, el nombre de la categoria que se asocia el producto
        private void ConsultarDatosCategoriaProducto_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Categoria";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListaCategoria1.Items.Add(t.Rows[i]["Nombre"]);
            }
            conex.close();
        }
    }
}
