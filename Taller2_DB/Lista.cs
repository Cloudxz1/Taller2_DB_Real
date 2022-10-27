using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
namespace Taller2_DB
{
    class Lista
    {
        public static void CargarCategorias(ComboBox listCat)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT Nombre FROM Categoria";
            DataTable categoria = conex.selectQuery(query);
            for (int i = 0; i < categoria.Rows.Count; i++)
            {
                listCat.Items.Add(categoria.Rows[i]["Nombre"]);

            }
            conex.close();
        }
    }
}
