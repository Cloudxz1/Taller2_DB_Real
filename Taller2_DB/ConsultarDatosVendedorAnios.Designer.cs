
namespace Taller2_DB
{
    partial class ConsultarDatosVendedorAnios
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
            this.btnVolDatosVendAnios = new System.Windows.Forms.Button();
            this.cmbListaVendedor = new System.Windows.Forms.ComboBox();
            this.ListVenAniosDGV = new System.Windows.Forms.DataGridView();
            this.btnBusVenAnios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListVenAniosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolDatosVendAnios
            // 
            this.btnVolDatosVendAnios.Location = new System.Drawing.Point(12, 217);
            this.btnVolDatosVendAnios.Name = "btnVolDatosVendAnios";
            this.btnVolDatosVendAnios.Size = new System.Drawing.Size(75, 23);
            this.btnVolDatosVendAnios.TabIndex = 0;
            this.btnVolDatosVendAnios.Text = "Volver";
            this.btnVolDatosVendAnios.UseVisualStyleBackColor = true;
            this.btnVolDatosVendAnios.Click += new System.EventHandler(this.btnVolDatosVendAnios_Click);
            // 
            // cmbListaVendedor
            // 
            this.cmbListaVendedor.FormattingEnabled = true;
            this.cmbListaVendedor.Location = new System.Drawing.Point(27, 97);
            this.cmbListaVendedor.Name = "cmbListaVendedor";
            this.cmbListaVendedor.Size = new System.Drawing.Size(143, 21);
            this.cmbListaVendedor.TabIndex = 1;
            // 
            // ListVenAniosDGV
            // 
            this.ListVenAniosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListVenAniosDGV.Location = new System.Drawing.Point(220, 71);
            this.ListVenAniosDGV.Name = "ListVenAniosDGV";
            this.ListVenAniosDGV.ReadOnly = true;
            this.ListVenAniosDGV.Size = new System.Drawing.Size(580, 88);
            this.ListVenAniosDGV.TabIndex = 2;
            // 
            // btnBusVenAnios
            // 
            this.btnBusVenAnios.Location = new System.Drawing.Point(58, 124);
            this.btnBusVenAnios.Name = "btnBusVenAnios";
            this.btnBusVenAnios.Size = new System.Drawing.Size(75, 23);
            this.btnBusVenAnios.TabIndex = 3;
            this.btnBusVenAnios.Text = "Buscar";
            this.btnBusVenAnios.UseVisualStyleBackColor = true;
            this.btnBusVenAnios.Click += new System.EventHandler(this.btnBusVenAnios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Vendedor:";
            // 
            // ConsultarDatosVendedorAnios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBusVenAnios);
            this.Controls.Add(this.ListVenAniosDGV);
            this.Controls.Add(this.cmbListaVendedor);
            this.Controls.Add(this.btnVolDatosVendAnios);
            this.Name = "ConsultarDatosVendedorAnios";
            this.Text = "ConsultarDatosVendedorAnios";
            this.Load += new System.EventHandler(this.ConsultarDatosVendedorAnios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListVenAniosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolDatosVendAnios;
        private System.Windows.Forms.ComboBox cmbListaVendedor;
        private System.Windows.Forms.DataGridView ListVenAniosDGV;
        private System.Windows.Forms.Button btnBusVenAnios;
        private System.Windows.Forms.Label label1;
    }
}