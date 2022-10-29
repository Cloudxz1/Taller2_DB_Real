
namespace Taller2_DB
{
    partial class AgregarOrdenCompraCliente
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
            this.btnVolOrdCom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbListaRutCli = new System.Windows.Forms.ComboBox();
            this.cmbListaNumeroEmp = new System.Windows.Forms.ComboBox();
            this.cmbListaProductoVenta = new System.Windows.Forms.ComboBox();
            this.btnVentaRealizada = new System.Windows.Forms.Button();
            this.txtCantProdVenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolOrdCom
            // 
            this.btnVolOrdCom.Location = new System.Drawing.Point(12, 308);
            this.btnVolOrdCom.Name = "btnVolOrdCom";
            this.btnVolOrdCom.Size = new System.Drawing.Size(75, 23);
            this.btnVolOrdCom.TabIndex = 0;
            this.btnVolOrdCom.Text = "Volver";
            this.btnVolOrdCom.UseVisualStyleBackColor = true;
            this.btnVolOrdCom.Click += new System.EventHandler(this.btnVolOrdCom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Realizar Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // cmbListaRutCli
            // 
            this.cmbListaRutCli.FormattingEnabled = true;
            this.cmbListaRutCli.Location = new System.Drawing.Point(249, 153);
            this.cmbListaRutCli.Name = "cmbListaRutCli";
            this.cmbListaRutCli.Size = new System.Drawing.Size(121, 21);
            this.cmbListaRutCli.TabIndex = 6;
            // 
            // cmbListaNumeroEmp
            // 
            this.cmbListaNumeroEmp.FormattingEnabled = true;
            this.cmbListaNumeroEmp.Location = new System.Drawing.Point(249, 117);
            this.cmbListaNumeroEmp.Name = "cmbListaNumeroEmp";
            this.cmbListaNumeroEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbListaNumeroEmp.TabIndex = 7;
            // 
            // cmbListaProductoVenta
            // 
            this.cmbListaProductoVenta.FormattingEnabled = true;
            this.cmbListaProductoVenta.Location = new System.Drawing.Point(249, 192);
            this.cmbListaProductoVenta.Name = "cmbListaProductoVenta";
            this.cmbListaProductoVenta.Size = new System.Drawing.Size(121, 21);
            this.cmbListaProductoVenta.TabIndex = 8;
            // 
            // btnVentaRealizada
            // 
            this.btnVentaRealizada.Location = new System.Drawing.Point(167, 272);
            this.btnVentaRealizada.Name = "btnVentaRealizada";
            this.btnVentaRealizada.Size = new System.Drawing.Size(127, 23);
            this.btnVentaRealizada.TabIndex = 9;
            this.btnVentaRealizada.Text = "Aceptar";
            this.btnVentaRealizada.UseVisualStyleBackColor = true;
            this.btnVentaRealizada.Click += new System.EventHandler(this.btnVentaRealizada_Click);
            // 
            // txtCantProdVenta
            // 
            this.txtCantProdVenta.Location = new System.Drawing.Point(249, 231);
            this.txtCantProdVenta.Name = "txtCantProdVenta";
            this.txtCantProdVenta.Size = new System.Drawing.Size(121, 20);
            this.txtCantProdVenta.TabIndex = 10;
            // 
            // AgregarOrdenCompraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 354);
            this.Controls.Add(this.txtCantProdVenta);
            this.Controls.Add(this.btnVentaRealizada);
            this.Controls.Add(this.cmbListaProductoVenta);
            this.Controls.Add(this.cmbListaNumeroEmp);
            this.Controls.Add(this.cmbListaRutCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolOrdCom);
            this.Name = "AgregarOrdenCompraCliente";
            this.Text = "AgregarOrdenCompraCliente";
            this.Load += new System.EventHandler(this.AgregarOrdenCompraCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolOrdCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbListaRutCli;
        private System.Windows.Forms.ComboBox cmbListaNumeroEmp;
        private System.Windows.Forms.ComboBox cmbListaProductoVenta;
        private System.Windows.Forms.Button btnVentaRealizada;
        private System.Windows.Forms.TextBox txtCantProdVenta;
    }
}