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
    public partial class ConsultarDatosOrdenCompra : Form
    {
        public ConsultarDatosOrdenCompra()
        {
            InitializeComponent();
            cmbListOrdenCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListVendOrdenCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListRutCliOrdenCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListIdProdOrden.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolvConsOrdCom_Click(object sender, EventArgs e)
        {
            ConsultasDatos consultasDatos1 = new ConsultasDatos();
            consultasDatos1.Show();
            this.Hide();
        }

        /// <summary>
        /// Consulta 4
        /// Datos de una orden de compra, incluyendo el cliente, el vendedor y los productos de la orden. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultaOrdenCompra_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (cmbListOrdenCompra.Text != "" && cmbListVendOrdenCompra.Text != "" && cmbListRutCliOrdenCompra.Text != "" && cmbListIdProdOrden.Text != "")
            {
                string query = "Select distinct o1.OrdenCompraId AS Id_Orden, c.Rut AS Rut_Cliente, v.NumeroEmpleado AS Num_Vendedor, o1.ProductoId AS Id_Prod, p.Precio AS Precio_Prod , o1.cantProdVendido, o2.MontoTotalOrden AS Monto_Total, o2.PorcentajeDescuento AS Descunecto, o2.MontoFinalOrden AS Monto_Final from producto p, ordencompra_producto o1, ordencompra o2, vendedor v, cliente c WHERE p.Id=o1.ProductoId AND o1.OrdenCompraId=o2.Id AND o2.ClienteRut=c.Rut AND o2.VendedorNumeroEmpleado=v.NumeroEmpleado AND o2.Id='" + cmbListOrdenCompra.Text + "' AND v.NumeroEmpleado = '" + cmbListVendOrdenCompra.Text + "' AND c.Rut = '" + cmbListRutCliOrdenCompra.Text + "'AND p.Id= '" + cmbListIdProdOrden.Text + "'";
                DataTable dt = conex.selectQuery(query);

                DetallesOrdCompDGV.DataSource = dt;
                DetallesOrdCompDGV.Show();
            }
            else
            {                               
                MessageBox.Show("Debes seleccionar los datos para continuar");
            }
            conex.close();
        }

        private void ConsultarDatosOrdenCompra_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "SELECT * FROM OrdenCompra";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListOrdenCompra.Items.Add(t.Rows[i]["Id"]);
            }

            string query2 = "SELECT * FROM Vendedor";
            DataTable t2 = conex.selectQuery(query2);

            for (int i = 0; i < t2.Rows.Count; i++)
            {
                cmbListVendOrdenCompra.Items.Add(t2.Rows[i]["NumeroEmpleado"]);
            }

            string query3 = "SELECT * FROM Cliente";
            DataTable t3 = conex.selectQuery(query3);

            for (int i = 0; i < t3.Rows.Count; i++)
            {
                cmbListRutCliOrdenCompra.Items.Add(t3.Rows[i]["Rut"]);
            }

            string query4 = "SELECT * FROM Producto";
            DataTable t4 = conex.selectQuery(query4);

            for (int i = 0; i < t4.Rows.Count; i++)
            {
                cmbListIdProdOrden.Items.Add(t4.Rows[i]["Id"]);
            }

            conex.close();
        }
    }
}
