
namespace Taller2_DB
{
    partial class ConsultarDatosProductoCompradoCategoria
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
            this.btnVolverProdPorCateg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbListRutCliProdCat = new System.Windows.Forms.ComboBox();
            this.cmbListCatProdCateg = new System.Windows.Forms.ComboBox();
            this.btnProdCategBuscado = new System.Windows.Forms.Button();
            this.ListProdCatDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListProdCatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverProdPorCateg
            // 
            this.btnVolverProdPorCateg.Location = new System.Drawing.Point(21, 404);
            this.btnVolverProdPorCateg.Name = "btnVolverProdPorCateg";
            this.btnVolverProdPorCateg.Size = new System.Drawing.Size(75, 23);
            this.btnVolverProdPorCateg.TabIndex = 0;
            this.btnVolverProdPorCateg.Text = "Volver";
            this.btnVolverProdPorCateg.UseVisualStyleBackColor = true;
            this.btnVolverProdPorCateg.Click += new System.EventHandler(this.btnVolverProdPorCateg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos de una categoria en la Orden de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria del Producto:";
            // 
            // cmbListRutCliProdCat
            // 
            this.cmbListRutCliProdCat.FormattingEnabled = true;
            this.cmbListRutCliProdCat.Location = new System.Drawing.Point(378, 93);
            this.cmbListRutCliProdCat.Name = "cmbListRutCliProdCat";
            this.cmbListRutCliProdCat.Size = new System.Drawing.Size(121, 21);
            this.cmbListRutCliProdCat.TabIndex = 4;
            // 
            // cmbListCatProdCateg
            // 
            this.cmbListCatProdCateg.FormattingEnabled = true;
            this.cmbListCatProdCateg.Location = new System.Drawing.Point(378, 132);
            this.cmbListCatProdCateg.Name = "cmbListCatProdCateg";
            this.cmbListCatProdCateg.Size = new System.Drawing.Size(121, 21);
            this.cmbListCatProdCateg.TabIndex = 5;
            // 
            // btnProdCategBuscado
            // 
            this.btnProdCategBuscado.Location = new System.Drawing.Point(399, 171);
            this.btnProdCategBuscado.Name = "btnProdCategBuscado";
            this.btnProdCategBuscado.Size = new System.Drawing.Size(75, 23);
            this.btnProdCategBuscado.TabIndex = 6;
            this.btnProdCategBuscado.Text = "Consultar";
            this.btnProdCategBuscado.UseVisualStyleBackColor = true;
            this.btnProdCategBuscado.Click += new System.EventHandler(this.btnProdCategBuscado_Click);
            // 
            // ListProdCatDGV
            // 
            this.ListProdCatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProdCatDGV.Location = new System.Drawing.Point(89, 216);
            this.ListProdCatDGV.Name = "ListProdCatDGV";
            this.ListProdCatDGV.ReadOnly = true;
            this.ListProdCatDGV.Size = new System.Drawing.Size(664, 150);
            this.ListProdCatDGV.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detalles de Consulta:";
            // 
            // ConsultarDatosProductoCompradoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListProdCatDGV);
            this.Controls.Add(this.btnProdCategBuscado);
            this.Controls.Add(this.cmbListCatProdCateg);
            this.Controls.Add(this.cmbListRutCliProdCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverProdPorCateg);
            this.Name = "ConsultarDatosProductoCompradoCategoria";
            this.Text = "ConsultarDatosProductoCompradoCategoria";
            this.Load += new System.EventHandler(this.ConsultarDatosProductoCompradoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListProdCatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverProdPorCateg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbListRutCliProdCat;
        private System.Windows.Forms.ComboBox cmbListCatProdCateg;
        private System.Windows.Forms.Button btnProdCategBuscado;
        private System.Windows.Forms.DataGridView ListProdCatDGV;
        private System.Windows.Forms.Label label4;
    }
}