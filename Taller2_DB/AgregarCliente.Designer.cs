
namespace Taller2_DB
{
    partial class AgregarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.RutCliente = new System.Windows.Forms.TextBox();
            this.NombreCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaldoCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DireccionCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tefelonoCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(10, 11);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(66, 32);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut";
            // 
            // RutCliente
            // 
            this.RutCliente.Location = new System.Drawing.Point(41, 80);
            this.RutCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RutCliente.Name = "RutCliente";
            this.RutCliente.Size = new System.Drawing.Size(95, 20);
            this.RutCliente.TabIndex = 2;
            // 
            // NombreCli
            // 
            this.NombreCli.Location = new System.Drawing.Point(160, 80);
            this.NombreCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreCli.Name = "NombreCli";
            this.NombreCli.Size = new System.Drawing.Size(95, 20);
            this.NombreCli.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // SaldoCli
            // 
            this.SaldoCli.Location = new System.Drawing.Point(279, 80);
            this.SaldoCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaldoCli.Name = "SaldoCli";
            this.SaldoCli.Size = new System.Drawing.Size(95, 20);
            this.SaldoCli.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // DireccionCli
            // 
            this.DireccionCli.Location = new System.Drawing.Point(512, 80);
            this.DireccionCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DireccionCli.Name = "DireccionCli";
            this.DireccionCli.Size = new System.Drawing.Size(95, 20);
            this.DireccionCli.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            // 
            // tefelonoCli
            // 
            this.tefelonoCli.Location = new System.Drawing.Point(394, 80);
            this.tefelonoCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tefelonoCli.Name = "tefelonoCli";
            this.tefelonoCli.Size = new System.Drawing.Size(95, 20);
            this.tefelonoCli.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tefelono";
            // 
            // dataCliente
            // 
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(41, 121);
            this.dataCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.RowHeadersWidth = 51;
            this.dataCliente.RowTemplate.Height = 24;
            this.dataCliente.Size = new System.Drawing.Size(564, 122);
            this.dataCliente.TabIndex = 11;
            this.dataCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCliente_CellContentClick);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(266, 264);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(107, 35);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 316);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dataCliente);
            this.Controls.Add(this.tefelonoCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DireccionCli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaldoCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RutCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Volver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RutCliente;
        private System.Windows.Forms.TextBox NombreCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaldoCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DireccionCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tefelonoCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.Button btn_Agregar;
    }
}