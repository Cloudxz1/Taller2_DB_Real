
namespace Taller2_DB
{
    partial class AgregarDinero
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.btn_AgregarDinero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rutCliente = new System.Windows.Forms.TextBox();
            this.saldoNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(90, 42);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dataCliente
            // 
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(86, 75);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.RowHeadersWidth = 51;
            this.dataCliente.RowTemplate.Height = 24;
            this.dataCliente.Size = new System.Drawing.Size(451, 208);
            this.dataCliente.TabIndex = 1;
            // 
            // btn_AgregarDinero
            // 
            this.btn_AgregarDinero.Location = new System.Drawing.Point(253, 386);
            this.btn_AgregarDinero.Name = "btn_AgregarDinero";
            this.btn_AgregarDinero.Size = new System.Drawing.Size(98, 34);
            this.btn_AgregarDinero.TabIndex = 2;
            this.btn_AgregarDinero.Text = "Agregar";
            this.btn_AgregarDinero.UseVisualStyleBackColor = true;
            this.btn_AgregarDinero.Click += new System.EventHandler(this.btn_AgregarDinero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rut";
            // 
            // rutCliente
            // 
            this.rutCliente.Location = new System.Drawing.Point(207, 306);
            this.rutCliente.Name = "rutCliente";
            this.rutCliente.Size = new System.Drawing.Size(201, 22);
            this.rutCliente.TabIndex = 4;
            // 
            // saldoNuevo
            // 
            this.saldoNuevo.Location = new System.Drawing.Point(207, 358);
            this.saldoNuevo.Name = "saldoNuevo";
            this.saldoNuevo.Size = new System.Drawing.Size(201, 22);
            this.saldoNuevo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo a cargar";
            // 
            // AgregarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 431);
            this.Controls.Add(this.saldoNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rutCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AgregarDinero);
            this.Controls.Add(this.dataCliente);
            this.Controls.Add(this.btn_Volver);
            this.Name = "AgregarDinero";
            this.Text = "AgregarDinero";
            this.Load += new System.EventHandler(this.AgregarDinero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.Button btn_AgregarDinero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rutCliente;
        private System.Windows.Forms.TextBox saldoNuevo;
        private System.Windows.Forms.Label label2;
    }
}