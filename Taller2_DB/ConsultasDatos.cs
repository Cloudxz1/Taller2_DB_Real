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
    public partial class ConsultasDatos : Form
    {
        public ConsultasDatos()
        {
            InitializeComponent();
        }

        private void btnVolverConsultas_Click(object sender, EventArgs e)
        {
            Form1 voladmin = new Form1();
            voladmin.Show();
            this.Hide();
        }

        private void btnVistoListado_Click(object sender, EventArgs e)
        {
            
        }

        private void ClienteSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListadoDatos_Click(object sender, EventArgs e)
        {
            ConsultarDatosListados conslis = new ConsultarDatosListados();
            conslis.Show();
            this.Hide();
        }

        private void btnDatosVendedor1_Click(object sender, EventArgs e)
        {
            ConsultarDatosVendedorAnios consvenanios = new ConsultarDatosVendedorAnios();
            consvenanios.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVendAntigTipo_Click(object sender, EventArgs e)
        {
            ConsultarDatosVendedorAntigMayorMenor consvat = new ConsultarDatosVendedorAntigMayorMenor();
            consvat.Show();
            this.Hide();
        }
    }
}