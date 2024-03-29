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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btn_InsertCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarCategoria categoria = new AgregarCategoria();
            categoria.Show();
        }

        private void btn_InsertProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProducto producto = new AgregarProducto();
            producto.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_InsertCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarCliente cliente = new AgregarCliente();
            cliente.Show();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void InsertProv_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProveedor proveedor = new AgregarProveedor();
            proveedor.Show();
        }

        private void InsertVend_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarVendedor vendedor = new AgregarVendedor();
            vendedor.Show();
        }

        private void btn_DeleteCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarCliente cliente = new EliminarCliente();
            cliente.Show();
        }

        private void btn_AgregarSaldoCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarDinero dinero = new AgregarDinero();
            dinero.Show();
        }

        private void btn_EditarSalario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambiarSalario salario = new CambiarSalario();
            salario.Show();
        }

        private void btn_ProvProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentaProductoProveedor productoProveedor = new VentaProductoProveedor();
            productoProveedor.Show();
        }

        private void btnAtenderOrdenCompra_Click(object sender, EventArgs e)
        {
            AgregarOrdenCompraCliente agregor = new AgregarOrdenCompraCliente();
            agregor.Show();
            this.Hide();
        }
    }
}
