
namespace Taller2_DB
{
    partial class ConsultarDatosCantTotalProdSuminProv
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
            this.btnVolCantTProdSuminProv = new System.Windows.Forms.Button();
            this.dgvCantTotProdSuminProv = new System.Windows.Forms.DataGridView();
            this.btnCantTotProdSumProv = new System.Windows.Forms.Button();
            this.cmbRutProvCantTotProdSum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantTotProdSuminProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolCantTProdSuminProv
            // 
            this.btnVolCantTProdSuminProv.Location = new System.Drawing.Point(30, 398);
            this.btnVolCantTProdSuminProv.Name = "btnVolCantTProdSuminProv";
            this.btnVolCantTProdSuminProv.Size = new System.Drawing.Size(75, 23);
            this.btnVolCantTProdSuminProv.TabIndex = 0;
            this.btnVolCantTProdSuminProv.Text = "Volver";
            this.btnVolCantTProdSuminProv.UseVisualStyleBackColor = true;
            this.btnVolCantTProdSuminProv.Click += new System.EventHandler(this.btnVolCantTProdSuminProv_Click);
            // 
            // dgvCantTotProdSuminProv
            // 
            this.dgvCantTotProdSuminProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantTotProdSuminProv.Location = new System.Drawing.Point(134, 187);
            this.dgvCantTotProdSuminProv.Name = "dgvCantTotProdSuminProv";
            this.dgvCantTotProdSuminProv.ReadOnly = true;
            this.dgvCantTotProdSuminProv.Size = new System.Drawing.Size(573, 181);
            this.dgvCantTotProdSuminProv.TabIndex = 1;
            // 
            // btnCantTotProdSumProv
            // 
            this.btnCantTotProdSumProv.Location = new System.Drawing.Point(383, 135);
            this.btnCantTotProdSumProv.Name = "btnCantTotProdSumProv";
            this.btnCantTotProdSumProv.Size = new System.Drawing.Size(75, 23);
            this.btnCantTotProdSumProv.TabIndex = 2;
            this.btnCantTotProdSumProv.Text = "Consultar";
            this.btnCantTotProdSumProv.UseVisualStyleBackColor = true;
            this.btnCantTotProdSumProv.Click += new System.EventHandler(this.btnCantTotProdSumProv_Click);
            // 
            // cmbRutProvCantTotProdSum
            // 
            this.cmbRutProvCantTotProdSum.FormattingEnabled = true;
            this.cmbRutProvCantTotProdSum.Location = new System.Drawing.Point(358, 108);
            this.cmbRutProvCantTotProdSum.Name = "cmbRutProvCantTotProdSum";
            this.cmbRutProvCantTotProdSum.Size = new System.Drawing.Size(121, 21);
            this.cmbRutProvCantTotProdSum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad Total de Productos que suministra un Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rut Proveedor:";
            // 
            // ConsultarDatosCantTotalProdSuminProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRutProvCantTotProdSum);
            this.Controls.Add(this.btnCantTotProdSumProv);
            this.Controls.Add(this.dgvCantTotProdSuminProv);
            this.Controls.Add(this.btnVolCantTProdSuminProv);
            this.Name = "ConsultarDatosCantTotalProdSuminProv";
            this.Text = "ConsultarDatosCantTotalProdSuminProv";
            this.Load += new System.EventHandler(this.ConsultarDatosCantTotalProdSuminProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantTotProdSuminProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolCantTProdSuminProv;
        private System.Windows.Forms.DataGridView dgvCantTotProdSuminProv;
        private System.Windows.Forms.Button btnCantTotProdSumProv;
        private System.Windows.Forms.ComboBox cmbRutProvCantTotProdSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}