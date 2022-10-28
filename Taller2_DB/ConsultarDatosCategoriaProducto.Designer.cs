
namespace Taller2_DB
{
    partial class ConsultarDatosCategoriaProducto
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
            this.btnVolverCatProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategProdDGV = new System.Windows.Forms.DataGridView();
            this.cmbListaCategoria1 = new System.Windows.Forms.ComboBox();
            this.btnBuscarListCateg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverCatProd
            // 
            this.btnVolverCatProd.Location = new System.Drawing.Point(24, 401);
            this.btnVolverCatProd.Name = "btnVolverCatProd";
            this.btnVolverCatProd.Size = new System.Drawing.Size(75, 23);
            this.btnVolverCatProd.TabIndex = 0;
            this.btnVolverCatProd.Text = "Volver";
            this.btnVolverCatProd.UseVisualStyleBackColor = true;
            this.btnVolverCatProd.Click += new System.EventHandler(this.btnVolverCatProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto:";
            // 
            // CategProdDGV
            // 
            this.CategProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategProdDGV.Location = new System.Drawing.Point(48, 173);
            this.CategProdDGV.Name = "CategProdDGV";
            this.CategProdDGV.Size = new System.Drawing.Size(468, 150);
            this.CategProdDGV.TabIndex = 3;
            // 
            // cmbListaCategoria1
            // 
            this.cmbListaCategoria1.FormattingEnabled = true;
            this.cmbListaCategoria1.Location = new System.Drawing.Point(201, 104);
            this.cmbListaCategoria1.Name = "cmbListaCategoria1";
            this.cmbListaCategoria1.Size = new System.Drawing.Size(121, 21);
            this.cmbListaCategoria1.TabIndex = 4;
            // 
            // btnBuscarListCateg
            // 
            this.btnBuscarListCateg.Location = new System.Drawing.Point(328, 102);
            this.btnBuscarListCateg.Name = "btnBuscarListCateg";
            this.btnBuscarListCateg.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarListCateg.TabIndex = 5;
            this.btnBuscarListCateg.Text = "Buscar";
            this.btnBuscarListCateg.UseVisualStyleBackColor = true;
            this.btnBuscarListCateg.Click += new System.EventHandler(this.btnBuscarListCateg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria de Producto";
            // 
            // ConsultarDatosCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarListCateg);
            this.Controls.Add(this.cmbListaCategoria1);
            this.Controls.Add(this.CategProdDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverCatProd);
            this.Name = "ConsultarDatosCategoriaProducto";
            this.Text = "ConsultarDatosCategoriaProducto";
            this.Load += new System.EventHandler(this.ConsultarDatosCategoriaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCatProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CategProdDGV;
        private System.Windows.Forms.ComboBox cmbListaCategoria1;
        private System.Windows.Forms.Button btnBuscarListCateg;
        private System.Windows.Forms.Label label3;
    }
}