
namespace Taller2_DB
{
    partial class VentaProductoProveedor
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
            this.dataProd = new System.Windows.Forms.DataGridView();
            this.dataProv = new System.Windows.Forms.DataGridView();
            this.dataProdProv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmarProvProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRutProveedor = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadCompraProvProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProdProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(9, 10);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(70, 32);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dataProd
            // 
            this.dataProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProd.Location = new System.Drawing.Point(40, 59);
            this.dataProd.Margin = new System.Windows.Forms.Padding(2);
            this.dataProd.Name = "dataProd";
            this.dataProd.RowHeadersWidth = 51;
            this.dataProd.RowTemplate.Height = 24;
            this.dataProd.Size = new System.Drawing.Size(352, 180);
            this.dataProd.TabIndex = 1;
            // 
            // dataProv
            // 
            this.dataProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProv.Location = new System.Drawing.Point(421, 58);
            this.dataProv.Margin = new System.Windows.Forms.Padding(2);
            this.dataProv.Name = "dataProv";
            this.dataProv.RowHeadersWidth = 51;
            this.dataProv.RowTemplate.Height = 24;
            this.dataProv.Size = new System.Drawing.Size(325, 180);
            this.dataProv.TabIndex = 2;
            // 
            // dataProdProv
            // 
            this.dataProdProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProdProv.Location = new System.Drawing.Point(823, 60);
            this.dataProdProv.Margin = new System.Windows.Forms.Padding(2);
            this.dataProdProv.Name = "dataProdProv";
            this.dataProdProv.RowHeadersWidth = 51;
            this.dataProdProv.RowTemplate.Height = 24;
            this.dataProdProv.Size = new System.Drawing.Size(347, 179);
            this.dataProdProv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(948, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producto-Proveedor";
            // 
            // btn_ConfirmarProvProd
            // 
            this.btn_ConfirmarProvProd.Location = new System.Drawing.Point(555, 329);
            this.btn_ConfirmarProvProd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfirmarProvProd.Name = "btn_ConfirmarProvProd";
            this.btn_ConfirmarProvProd.Size = new System.Drawing.Size(84, 34);
            this.btn_ConfirmarProvProd.TabIndex = 7;
            this.btn_ConfirmarProvProd.Text = "Confirmar";
            this.btn_ConfirmarProvProd.UseVisualStyleBackColor = true;
            this.btn_ConfirmarProvProd.Click += new System.EventHandler(this.btn_ConfirmarProvProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rut Proveedor";
            // 
            // txtRutProveedor
            // 
            this.txtRutProveedor.Location = new System.Drawing.Point(336, 283);
            this.txtRutProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtRutProveedor.Name = "txtRutProveedor";
            this.txtRutProveedor.Size = new System.Drawing.Size(152, 20);
            this.txtRutProveedor.TabIndex = 9;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(525, 283);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(152, 20);
            this.txtIdProducto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id Producto";
            // 
            // txtCantidadCompraProvProd
            // 
            this.txtCantidadCompraProvProd.Location = new System.Drawing.Point(704, 283);
            this.txtCantidadCompraProvProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadCompraProvProd.Name = "txtCantidadCompraProvProd";
            this.txtCantidadCompraProvProd.Size = new System.Drawing.Size(152, 20);
            this.txtCantidadCompraProvProd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad a comprar";
            // 
            // VentaProductoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 385);
            this.Controls.Add(this.txtCantidadCompraProvProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRutProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ConfirmarProvProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataProdProv);
            this.Controls.Add(this.dataProv);
            this.Controls.Add(this.dataProd);
            this.Controls.Add(this.btn_Volver);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentaProductoProveedor";
            this.Text = "VentaProductoProveedor";
            this.Load += new System.EventHandler(this.VentaProductoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProdProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dataProd;
        private System.Windows.Forms.DataGridView dataProv;
        private System.Windows.Forms.DataGridView dataProdProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmarProvProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRutProveedor;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadCompraProvProd;
        private System.Windows.Forms.Label label6;
    }
}