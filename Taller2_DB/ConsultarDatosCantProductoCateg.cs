﻿using System;
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
    public partial class ConsultarDatosCantProductoCateg : Form
    {
        public ConsultarDatosCantProductoCateg()
        {
            InitializeComponent();
            cmbListaCateg2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnVolverConCantProCat_Click(object sender, EventArgs e)
        {
            ConsultasDatos volconcantpc = new ConsultasDatos();
            volconcantpc.Show();
            this.Hide();
        }
        /// <summary>
        /// Cantidad de productos vendidos por su categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarCantProdCateg_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (cmbListaCateg2.Text != "")
            {
                string query = "Select COUNT(p.id) AS Producto_Encontrado, sum(p.cantidadstock) AS Total_Stock  From Producto p INNER JOIN categoria c ON p.CategoriaId=c.Id WHERE c.Nombre= '" + cmbListaCateg2.Text + "'";
                DataTable t2 = conex.selectQuery(query);

                listaCantProdCatDGV.DataSource = t2;
                listaCantProdCatDGV.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar el nombre de una categoria para continuar. ");
            }
            
        }

        private void listaCantProdCatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Carga el listado de las categorias
        /// que se asocia el producto en especifico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultarDatosCantProductoCateg_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM Categoria";
            DataTable t = conex.selectQuery(query);

            for (int i = 0; i < t.Rows.Count; i++)
            {
                cmbListaCateg2.Items.Add(t.Rows[i]["Nombre"]);
            }
            conex.close();
        }
    }
    }

