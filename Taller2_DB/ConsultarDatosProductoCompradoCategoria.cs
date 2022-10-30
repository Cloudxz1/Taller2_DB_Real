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
    public partial class ConsultarDatosProductoCompradoCategoria : Form
    {
        public ConsultarDatosProductoCompradoCategoria()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton para volver al menu de las Consultas de Datos del sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolverProdPorCateg_Click(object sender, EventArgs e)
        {
            ConsultasDatos volprodcompcat = new ConsultasDatos();
            volprodcompcat.Show();
            this.Hide();
        }
        /// <summary>
        /// Muestra las categorias de los productos
        /// comprados por un cliente especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProdCategBuscado_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            
            if (cmbListRutCliProdCat.Text != "" && cmbListCatProdCateg.Text != "")
            {
                string query = "Select distinct o.Id AS ID_Orden, p.Nombre AS Nombre_Prod, k.Nombre AS Nom_Categoria, c.Nombre AS Nom_Cliente From ordencompra o INNER JOIN  cliente c ON o.ClienteRut=c.Rut INNER JOIN producto p ON c.Rut=p.Id INNER JOIN categoria k ON p.CategoriaId=k.Id where c.Rut= '" + cmbListRutCliProdCat.Text + "'AND p.Nombre= '" + cmbListCatProdCateg.Text  + "'";

                DataTable t3 = conex.selectQuery(query);
                ListProdCatDGV.DataSource = t3;
                ListProdCatDGV.Show();
            }
            else
            {
                MessageBox.Show("Debe relenar los campos para continuar");
            }
        }

        /// <summary>
        /// Carga la lista de los clientes por su rut y
        /// la lista de las categoria por nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosProductoCompradoCategoria_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
          
                string query = "Select Rut FROM Cliente";
                DataTable t = conex.selectQuery(query);

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    cmbListRutCliProdCat.Items.Add(t.Rows[i]["Rut"]);
                }

                string query2 = "Select Nombre FROM Categoria";
                DataTable t2 = conex.selectQuery(query2);

                for (int i = 0; i < t2.Rows.Count; i++)
                {
                    cmbListCatProdCateg.Items.Add(t2.Rows[i]["Nombre"]);
                }      
            
        }
    }
}
