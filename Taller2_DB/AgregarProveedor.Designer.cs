
namespace Taller2_DB
{
    partial class AgregarProveedor
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
            this.rutProv = new System.Windows.Forms.TextBox();
            this.NomProv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DirProv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataProv = new System.Windows.Forms.DataGridView();
            this.btn_AgregarProv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(89, 37);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut";
            // 
            // rutProv
            // 
            this.rutProv.Location = new System.Drawing.Point(115, 84);
            this.rutProv.Name = "rutProv";
            this.rutProv.Size = new System.Drawing.Size(120, 22);
            this.rutProv.TabIndex = 2;
            // 
            // NomProv
            // 
            this.NomProv.Location = new System.Drawing.Point(278, 84);
            this.NomProv.Name = "NomProv";
            this.NomProv.Size = new System.Drawing.Size(126, 22);
            this.NomProv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // DirProv
            // 
            this.DirProv.Location = new System.Drawing.Point(444, 84);
            this.DirProv.Name = "DirProv";
            this.DirProv.Size = new System.Drawing.Size(128, 22);
            this.DirProv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección";
            // 
            // dataProv
            // 
            this.dataProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProv.Location = new System.Drawing.Point(115, 128);
            this.dataProv.Name = "dataProv";
            this.dataProv.RowHeadersWidth = 51;
            this.dataProv.RowTemplate.Height = 24;
            this.dataProv.Size = new System.Drawing.Size(457, 175);
            this.dataProv.TabIndex = 7;
            // 
            // btn_AgregarProv
            // 
            this.btn_AgregarProv.Location = new System.Drawing.Point(290, 309);
            this.btn_AgregarProv.Name = "btn_AgregarProv";
            this.btn_AgregarProv.Size = new System.Drawing.Size(114, 48);
            this.btn_AgregarProv.TabIndex = 8;
            this.btn_AgregarProv.Text = "Agregar";
            this.btn_AgregarProv.UseVisualStyleBackColor = true;
            this.btn_AgregarProv.Click += new System.EventHandler(this.btn_AgregarProv_Click);
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 369);
            this.Controls.Add(this.btn_AgregarProv);
            this.Controls.Add(this.dataProv);
            this.Controls.Add(this.DirProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rutProv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Volver);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            this.Load += new System.EventHandler(this.AgregarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rutProv;
        private System.Windows.Forms.TextBox NomProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DirProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataProv;
        private System.Windows.Forms.Button btn_AgregarProv;
    }
}