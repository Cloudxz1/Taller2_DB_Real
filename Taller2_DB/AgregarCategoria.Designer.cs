
namespace Taller2_DB
{
    partial class AgregarCategoria
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
            this.dataCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreCat = new System.Windows.Forms.TextBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCategorias
            // 
            this.dataCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategorias.Location = new System.Drawing.Point(161, 55);
            this.dataCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dataCategorias.Name = "dataCategorias";
            this.dataCategorias.ReadOnly = true;
            this.dataCategorias.RowHeadersWidth = 51;
            this.dataCategorias.RowTemplate.Height = 24;
            this.dataCategorias.Size = new System.Drawing.Size(344, 173);
            this.dataCategorias.TabIndex = 0;
            this.dataCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategorias_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // nombreCat
            // 
            this.nombreCat.Location = new System.Drawing.Point(21, 95);
            this.nombreCat.Margin = new System.Windows.Forms.Padding(2);
            this.nombreCat.Name = "nombreCat";
            this.nombreCat.Size = new System.Drawing.Size(126, 20);
            this.nombreCat.TabIndex = 2;
            this.nombreCat.TextChanged += new System.EventHandler(this.nombreCat_TextChanged);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(9, 10);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(78, 34);
            this.btn_Volver.TabIndex = 3;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar Nueva Categoria";
            // 
            // DescripCat
            // 
            this.DescripCat.Location = new System.Drawing.Point(21, 154);
            this.DescripCat.Margin = new System.Windows.Forms.Padding(2);
            this.DescripCat.Multiline = true;
            this.DescripCat.Name = "DescripCat";
            this.DescripCat.Size = new System.Drawing.Size(126, 76);
            this.DescripCat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(76, 264);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(358, 36);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 338);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.DescripCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.nombreCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCategorias);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCategoria";
            this.Text = "AgregarCategoria";
            this.Load += new System.EventHandler(this.AgregarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreCat;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Agregar;
    }
}