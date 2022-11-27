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
            cmbListRutCliProdCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListCatProdCateg.DropDownStyle = ComboBoxStyle.DropDownList;
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
        /// Consulta 14
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
                string query = "Select o2.OrdenCompraId AS OrdenCompra, c.Rut, p.Id AS Id_Prod, p.Nombre AS Nombre_Prod, p.CategoriaId AS Cat_Prod, c2.Nombre AS Nombre_Categ from Cliente c INNER JOIN ordencompra o1 ON c.Rut=o1.ClienteRut INNER JOIN ordencompra_producto o2 ON o1.Id=o2.OrdenCompraId INNER JOIN producto p ON o2.ProductoId=p.Id INNER JOIN categoria c2 ON p.CategoriaId=c2.Id WHERE c.Rut = '" + cmbListRutCliProdCat.Text + "'AND c2.Nombre = '" + cmbListCatProdCateg.Text  + "'";

                DataTable t3 = conex.selectQuery(query);
                ListProdCatDGV.DataSource = t3;
                ListProdCatDGV.Show();
            }
            else
            {
                MessageBox.Show("Debe rellenar los campos para continuar. ");
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
