
namespace Taller2_DB
{
    partial class AgregarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.idProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precioProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cantProd = new System.Windows.Forms.TextBox();
            this.categorias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Nuevo Producto";
            // 
            // dataProductos
            // 
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Location = new System.Drawing.Point(262, 53);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.RowHeadersWidth = 51;
            this.dataProductos.RowTemplate.Height = 24;
            this.dataProductos.Size = new System.Drawing.Size(549, 150);
            this.dataProductos.TabIndex = 1;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(91, 36);
            this.btn_Volver.TabIndex = 2;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // idProd
            // 
            this.idProd.Location = new System.Drawing.Point(44, 115);
            this.idProd.Name = "idProd";
            this.idProd.Size = new System.Drawing.Size(156, 22);
            this.idProd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // nombreProd
            // 
            this.nombreProd.Location = new System.Drawing.Point(44, 181);
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.Size = new System.Drawing.Size(156, 22);
            this.nombreProd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // precioProd
            // 
            this.precioProd.Location = new System.Drawing.Point(44, 241);
            this.precioProd.Name = "precioProd";
            this.precioProd.Size = new System.Drawing.Size(156, 22);
            this.precioProd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad stock";
            // 
            // cantProd
            // 
            this.cantProd.Location = new System.Drawing.Point(262, 241);
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(156, 22);
            this.cantProd.TabIndex = 9;
            // 
            // categorias
            // 
            this.categorias.FormattingEnabled = true;
            this.categorias.Location = new System.Drawing.Point(487, 239);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(168, 24);
            this.categorias.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categoria";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(368, 292);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(191, 44);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 348);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idProd);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox idProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precioProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cantProd;
        private System.Windows.Forms.ComboBox categorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_agregar;
    }
}