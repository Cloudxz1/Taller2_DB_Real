
namespace Taller2_DB
{
    partial class ConsultarDatosProductoCompradoClientePorAnio
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
            this.btnVolverProdCompCliAno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbListProdCliAnio = new System.Windows.Forms.ComboBox();
            this.btnBuscProdCliAnio = new System.Windows.Forms.Button();
            this.dgvListProdCliAnio = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProdCliAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverProdCompCliAno
            // 
            this.btnVolverProdCompCliAno.Location = new System.Drawing.Point(24, 404);
            this.btnVolverProdCompCliAno.Name = "btnVolverProdCompCliAno";
            this.btnVolverProdCompCliAno.Size = new System.Drawing.Size(75, 23);
            this.btnVolverProdCompCliAno.TabIndex = 0;
            this.btnVolverProdCompCliAno.Text = "Volver";
            this.btnVolverProdCompCliAno.UseVisualStyleBackColor = true;
            this.btnVolverProdCompCliAno.Click += new System.EventHandler(this.btnVolverProdCompCliAno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos comprados por cliente en el anio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut del Cliente:";
            // 
            // cmbListProdCliAnio
            // 
            this.cmbListProdCliAnio.FormattingEnabled = true;
            this.cmbListProdCliAnio.Location = new System.Drawing.Point(334, 108);
            this.cmbListProdCliAnio.Name = "cmbListProdCliAnio";
            this.cmbListProdCliAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbListProdCliAnio.TabIndex = 3;
            // 
            // btnBuscProdCliAnio
            // 
            this.btnBuscProdCliAnio.Location = new System.Drawing.Point(344, 135);
            this.btnBuscProdCliAnio.Name = "btnBuscProdCliAnio";
            this.btnBuscProdCliAnio.Size = new System.Drawing.Size(102, 23);
            this.btnBuscProdCliAnio.TabIndex = 4;
            this.btnBuscProdCliAnio.Text = "Buscar Producto";
            this.btnBuscProdCliAnio.UseVisualStyleBackColor = true;
            this.btnBuscProdCliAnio.Click += new System.EventHandler(this.btnBuscProdCliAnio_Click);
            // 
            // dgvListProdCliAnio
            // 
            this.dgvListProdCliAnio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProdCliAnio.Location = new System.Drawing.Point(78, 207);
            this.dgvListProdCliAnio.Name = "dgvListProdCliAnio";
            this.dgvListProdCliAnio.ReadOnly = true;
            this.dgvListProdCliAnio.Size = new System.Drawing.Size(655, 150);
            this.dgvListProdCliAnio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detalles de la Busqueda:";
            // 
            // ConsultarDatosProductoCompradoClientePorAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListProdCliAnio);
            this.Controls.Add(this.btnBuscProdCliAnio);
            this.Controls.Add(this.cmbListProdCliAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverProdCompCliAno);
            this.Name = "ConsultarDatosProductoCompradoClientePorAnio";
            this.Text = "ConsultarDatosProductoCompradoClientePorAnio";
            this.Load += new System.EventHandler(this.ConsultarDatosProductoCompradoClientePorAnio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProdCliAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverProdCompCliAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbListProdCliAnio;
        private System.Windows.Forms.Button btnBuscProdCliAnio;
        private System.Windows.Forms.DataGridView dgvListProdCliAnio;
        private System.Windows.Forms.Label label3;
    }
}