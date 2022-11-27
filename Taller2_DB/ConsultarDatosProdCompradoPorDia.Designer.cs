
namespace Taller2_DB
{
    partial class ConsultarDatosProdCompradoPorDia
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverProdCompDia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbListClienteRutDia = new System.Windows.Forms.ComboBox();
            this.FechaCompraDGV = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCompra = new System.Windows.Forms.Button();
            this.ListaProdCompDiaDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdCompDiaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto por dia";
            // 
            // btnVolverProdCompDia
            // 
            this.btnVolverProdCompDia.Location = new System.Drawing.Point(26, 401);
            this.btnVolverProdCompDia.Name = "btnVolverProdCompDia";
            this.btnVolverProdCompDia.Size = new System.Drawing.Size(75, 23);
            this.btnVolverProdCompDia.TabIndex = 1;
            this.btnVolverProdCompDia.Text = "Volver";
            this.btnVolverProdCompDia.UseVisualStyleBackColor = true;
            this.btnVolverProdCompDia.Click += new System.EventHandler(this.btnVolverProdCompDia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut Cliente:";
            // 
            // cmbListClienteRutDia
            // 
            this.cmbListClienteRutDia.FormattingEnabled = true;
            this.cmbListClienteRutDia.Location = new System.Drawing.Point(418, 84);
            this.cmbListClienteRutDia.Name = "cmbListClienteRutDia";
            this.cmbListClienteRutDia.Size = new System.Drawing.Size(142, 21);
            this.cmbListClienteRutDia.TabIndex = 3;
            // 
            // FechaCompraDGV
            // 
            this.FechaCompraDGV.AccessibleDescription = "No";
            this.FechaCompraDGV.AccessibleName = "No";
            this.FechaCompraDGV.Checked = false;
            this.FechaCompraDGV.Location = new System.Drawing.Point(418, 122);
            this.FechaCompraDGV.Name = "FechaCompraDGV";
            this.FechaCompraDGV.Size = new System.Drawing.Size(142, 20);
            this.FechaCompraDGV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Orden de Compra:";
            // 
            // btnBuscarCompra
            // 
            this.btnBuscarCompra.Location = new System.Drawing.Point(335, 159);
            this.btnBuscarCompra.Name = "btnBuscarCompra";
            this.btnBuscarCompra.Size = new System.Drawing.Size(140, 23);
            this.btnBuscarCompra.TabIndex = 6;
            this.btnBuscarCompra.Text = "Buscar Compra";
            this.btnBuscarCompra.UseVisualStyleBackColor = true;
            this.btnBuscarCompra.Click += new System.EventHandler(this.btnBuscarCompra_Click);
            // 
            // ListaProdCompDiaDGV
            // 
            this.ListaProdCompDiaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProdCompDiaDGV.Location = new System.Drawing.Point(84, 227);
            this.ListaProdCompDiaDGV.Name = "ListaProdCompDiaDGV";
            this.ListaProdCompDiaDGV.ReadOnly = true;
            this.ListaProdCompDiaDGV.Size = new System.Drawing.Size(663, 150);
            this.ListaProdCompDiaDGV.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalles:";
            // 
            // ConsultarDatosProdCompradoPorDia
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListaProdCompDiaDGV);
            this.Controls.Add(this.btnBuscarCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaCompraDGV);
            this.Controls.Add(this.cmbListClienteRutDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolverProdCompDia);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarDatosProdCompradoPorDia";
            this.Text = "ConsultarDatosProdCompradoPorDia";
            this.Load += new System.EventHandler(this.ConsultarDatosProdCompradoPorDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdCompDiaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverProdCompDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbListClienteRutDia;
        private System.Windows.Forms.DateTimePicker FechaCompraDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarCompra;
        private System.Windows.Forms.DataGridView ListaProdCompDiaDGV;
        private System.Windows.Forms.Label label4;
    }
}