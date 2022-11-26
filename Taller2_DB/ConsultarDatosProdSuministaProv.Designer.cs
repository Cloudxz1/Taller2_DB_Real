
namespace Taller2_DB
{
    partial class ConsultarDatosProdSuministaProv
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
            this.btnVolProdSuministraProv = new System.Windows.Forms.Button();
            this.dgvProdSuministraProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProdSuministraProd = new System.Windows.Forms.Button();
            this.cmbProdSuministraProv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSuministraProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolProdSuministraProv
            // 
            this.btnVolProdSuministraProv.Location = new System.Drawing.Point(23, 400);
            this.btnVolProdSuministraProv.Name = "btnVolProdSuministraProv";
            this.btnVolProdSuministraProv.Size = new System.Drawing.Size(75, 23);
            this.btnVolProdSuministraProv.TabIndex = 0;
            this.btnVolProdSuministraProv.Text = "Volver";
            this.btnVolProdSuministraProv.UseVisualStyleBackColor = true;
            this.btnVolProdSuministraProv.Click += new System.EventHandler(this.btnVolProdSuministraProv_Click);
            // 
            // dgvProdSuministraProd
            // 
            this.dgvProdSuministraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdSuministraProd.Location = new System.Drawing.Point(103, 199);
            this.dgvProdSuministraProd.Name = "dgvProdSuministraProd";
            this.dgvProdSuministraProd.ReadOnly = true;
            this.dgvProdSuministraProd.Size = new System.Drawing.Size(619, 150);
            this.dgvProdSuministraProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalles:";
            // 
            // btnProdSuministraProd
            // 
            this.btnProdSuministraProd.Location = new System.Drawing.Point(370, 136);
            this.btnProdSuministraProd.Name = "btnProdSuministraProd";
            this.btnProdSuministraProd.Size = new System.Drawing.Size(75, 23);
            this.btnProdSuministraProd.TabIndex = 3;
            this.btnProdSuministraProd.Text = "Consultar";
            this.btnProdSuministraProd.UseVisualStyleBackColor = true;
            this.btnProdSuministraProd.Click += new System.EventHandler(this.btnProdSuministraProd_Click);
            // 
            // cmbProdSuministraProv
            // 
            this.cmbProdSuministraProv.FormattingEnabled = true;
            this.cmbProdSuministraProv.Location = new System.Drawing.Point(349, 105);
            this.cmbProdSuministraProv.Name = "cmbProdSuministraProv";
            this.cmbProdSuministraProv.Size = new System.Drawing.Size(121, 21);
            this.cmbProdSuministraProv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producto suministrado por Proveedor";
            // 
            // ConsultarDatosProdSuministaProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProdSuministraProv);
            this.Controls.Add(this.btnProdSuministraProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdSuministraProd);
            this.Controls.Add(this.btnVolProdSuministraProv);
            this.Name = "ConsultarDatosProdSuministaProv";
            this.Text = "ConsultarDatosProdSuministaProv";
            this.Load += new System.EventHandler(this.ConsultarDatosProdSuministaProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdSuministraProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolProdSuministraProv;
        private System.Windows.Forms.DataGridView dgvProdSuministraProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdSuministraProd;
        private System.Windows.Forms.ComboBox cmbProdSuministraProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}