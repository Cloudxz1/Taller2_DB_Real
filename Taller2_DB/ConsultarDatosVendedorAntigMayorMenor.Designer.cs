﻿
namespace Taller2_DB
{
    partial class ConsultarDatosVendedorAntigMayorMenor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolverVendAntigMayMen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VendedorMayAntiDGV = new System.Windows.Forms.DataGridView();
            this.VendedorMenAntiDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorMayAntiDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorMenAntiDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverVendAntigMayMen
            // 
            this.btnVolverVendAntigMayMen.Location = new System.Drawing.Point(29, 390);
            this.btnVolverVendAntigMayMen.Name = "btnVolverVendAntigMayMen";
            this.btnVolverVendAntigMayMen.Size = new System.Drawing.Size(75, 23);
            this.btnVolverVendAntigMayMen.TabIndex = 0;
            this.btnVolverVendAntigMayMen.Text = "Volver";
            this.btnVolverVendAntigMayMen.UseVisualStyleBackColor = true;
            this.btnVolverVendAntigMayMen.Click += new System.EventHandler(this.btnVolverVendAntigMayMen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedor con Mayor antiguedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendedor con Menor antiguedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Antiguedad del Vendedor";
            // 
            // VendedorMayAntiDGV
            // 
            this.VendedorMayAntiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendedorMayAntiDGV.Location = new System.Drawing.Point(123, 97);
            this.VendedorMayAntiDGV.Name = "VendedorMayAntiDGV";
            this.VendedorMayAntiDGV.ReadOnly = true;
            this.VendedorMayAntiDGV.Size = new System.Drawing.Size(548, 100);
            this.VendedorMayAntiDGV.TabIndex = 4;
            this.VendedorMayAntiDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendedorMayAntiDGV_CellContentClick);
            // 
            // VendedorMenAntiDGV
            // 
            this.VendedorMenAntiDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendedorMenAntiDGV.Location = new System.Drawing.Point(123, 244);
            this.VendedorMenAntiDGV.Name = "VendedorMenAntiDGV";
            this.VendedorMenAntiDGV.ReadOnly = true;
            this.VendedorMenAntiDGV.Size = new System.Drawing.Size(548, 100);
            this.VendedorMenAntiDGV.TabIndex = 5;
            this.VendedorMenAntiDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendedorMenAntiDGV_CellContentClick);
            // 
            // ConsultarDatosVendedorAntigMayorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.VendedorMenAntiDGV);
            this.Controls.Add(this.VendedorMayAntiDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverVendAntigMayMen);
            this.Name = "ConsultarDatosVendedorAntigMayorMenor";
            this.Text = "ConsultarDatosVendedorAntigMayorMenor";
            this.Load += new System.EventHandler(this.ConsultarDatosVendedorAntigMayorMenor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendedorMayAntiDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendedorMenAntiDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverVendAntigMayMen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView VendedorMayAntiDGV;
        private System.Windows.Forms.DataGridView VendedorMenAntiDGV;
    }
}