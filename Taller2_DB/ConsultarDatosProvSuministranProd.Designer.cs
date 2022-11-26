
namespace Taller2_DB
{
    partial class ConsultarDatosProvSuministranProd
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
            this.btnVolProvSuminProd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvProvSuminisProd = new System.Windows.Forms.DataGridView();
            this.cmbRutProvSuminProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvSuminisProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolProvSuminProd
            // 
            this.btnVolProvSuminProd.Location = new System.Drawing.Point(35, 397);
            this.btnVolProvSuminProd.Name = "btnVolProvSuminProd";
            this.btnVolProvSuminProd.Size = new System.Drawing.Size(75, 23);
            this.btnVolProvSuminProd.TabIndex = 0;
            this.btnVolProvSuminProd.Text = "Volver";
            this.btnVolProvSuminProd.UseVisualStyleBackColor = true;
            this.btnVolProvSuminProd.Click += new System.EventHandler(this.btnVolProvSuminProd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvProvSuminisProd
            // 
            this.dgvProvSuminisProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvSuminisProd.Location = new System.Drawing.Point(35, 210);
            this.dgvProvSuminisProd.Name = "dgvProvSuminisProd";
            this.dgvProvSuminisProd.ReadOnly = true;
            this.dgvProvSuminisProd.Size = new System.Drawing.Size(736, 101);
            this.dgvProvSuminisProd.TabIndex = 2;
            this.dgvProvSuminisProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvSuminisProd_CellContentClick);
            // 
            // cmbRutProvSuminProd
            // 
            this.cmbRutProvSuminProd.FormattingEnabled = true;
            this.cmbRutProvSuminProd.Location = new System.Drawing.Point(348, 109);
            this.cmbRutProvSuminProd.Name = "cmbRutProvSuminProd";
            this.cmbRutProvSuminProd.Size = new System.Drawing.Size(121, 21);
            this.cmbRutProvSuminProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rut Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor que suministran un producto";
            // 
            // ConsultarDatosProvSuministranProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRutProvSuminProd);
            this.Controls.Add(this.dgvProvSuminisProd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVolProvSuminProd);
            this.Name = "ConsultarDatosProvSuministranProd";
            this.Text = "ConsultarDatosProvSuministranProd";
            this.Load += new System.EventHandler(this.ConsultarDatosProvSuministranProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvSuminisProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolProvSuminProd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvProvSuminisProd;
        private System.Windows.Forms.ComboBox cmbRutProvSuminProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}