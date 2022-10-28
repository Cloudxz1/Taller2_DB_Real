
namespace Taller2_DB
{
    partial class AgregarVendedor
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
            this.btn_AgregarVend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nEmp = new System.Windows.Forms.TextBox();
            this.NomEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fEmp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataVendedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(9, 10);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(70, 32);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_AgregarVend
            // 
            this.btn_AgregarVend.Location = new System.Drawing.Point(299, 232);
            this.btn_AgregarVend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AgregarVend.Name = "btn_AgregarVend";
            this.btn_AgregarVend.Size = new System.Drawing.Size(101, 45);
            this.btn_AgregarVend.TabIndex = 1;
            this.btn_AgregarVend.Text = "Agregar";
            this.btn_AgregarVend.UseVisualStyleBackColor = true;
            this.btn_AgregarVend.Click += new System.EventHandler(this.btn_AgregarVend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N°Empleado";
            // 
            // nEmp
            // 
            this.nEmp.Location = new System.Drawing.Point(96, 75);
            this.nEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nEmp.Name = "nEmp";
            this.nEmp.Size = new System.Drawing.Size(97, 20);
            this.nEmp.TabIndex = 3;
            // 
            // NomEmp
            // 
            this.NomEmp.Location = new System.Drawing.Point(221, 75);
            this.NomEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.Size = new System.Drawing.Size(104, 20);
            this.NomEmp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // salEmp
            // 
            this.salEmp.Location = new System.Drawing.Point(352, 75);
            this.salEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salEmp.Name = "salEmp";
            this.salEmp.Size = new System.Drawing.Size(104, 20);
            this.salEmp.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salario";
            // 
            // fEmp
            // 
            this.fEmp.CustomFormat = "yyyy-MM-dd";
            this.fEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fEmp.Location = new System.Drawing.Point(479, 75);
            this.fEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fEmp.Name = "fEmp";
            this.fEmp.Size = new System.Drawing.Size(128, 20);
            this.fEmp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha contratacion";
            // 
            // dataVendedor
            // 
            this.dataVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVendedor.Location = new System.Drawing.Point(96, 105);
            this.dataVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataVendedor.Name = "dataVendedor";
            this.dataVendedor.RowHeadersWidth = 51;
            this.dataVendedor.RowTemplate.Height = 24;
            this.dataVendedor.Size = new System.Drawing.Size(510, 122);
            this.dataVendedor.TabIndex = 10;
            // 
            // AgregarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 286);
            this.Controls.Add(this.dataVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fEmp);
            this.Controls.Add(this.salEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AgregarVend);
            this.Controls.Add(this.btn_Volver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarVendedor";
            this.Text = "AgregarVendedor";
            this.Load += new System.EventHandler(this.AgregarVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_AgregarVend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nEmp;
        private System.Windows.Forms.TextBox NomEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataVendedor;
    }
}