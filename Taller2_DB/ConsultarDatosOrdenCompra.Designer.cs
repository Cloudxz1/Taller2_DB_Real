
namespace Taller2_DB
{
    partial class ConsultarDatosOrdenCompra
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
            this.btnVolvConsOrdCom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultaOrdenCompra = new System.Windows.Forms.Button();
            this.cmbListOrdenCompra = new System.Windows.Forms.ComboBox();
            this.cmbListVendOrdenCompra = new System.Windows.Forms.ComboBox();
            this.cmbListRutCliOrdenCompra = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DetallesOrdCompDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbListIdProdOrden = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesOrdCompDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolvConsOrdCom
            // 
            this.btnVolvConsOrdCom.Location = new System.Drawing.Point(21, 406);
            this.btnVolvConsOrdCom.Name = "btnVolvConsOrdCom";
            this.btnVolvConsOrdCom.Size = new System.Drawing.Size(75, 23);
            this.btnVolvConsOrdCom.TabIndex = 0;
            this.btnVolvConsOrdCom.Text = "Volver";
            this.btnVolvConsOrdCom.UseVisualStyleBackColor = true;
            this.btnVolvConsOrdCom.Click += new System.EventHandler(this.btnVolvConsOrdCom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos de Orden Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero del Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rut del Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero Orden de Compra:";
            // 
            // btnConsultaOrdenCompra
            // 
            this.btnConsultaOrdenCompra.Location = new System.Drawing.Point(383, 189);
            this.btnConsultaOrdenCompra.Name = "btnConsultaOrdenCompra";
            this.btnConsultaOrdenCompra.Size = new System.Drawing.Size(128, 23);
            this.btnConsultaOrdenCompra.TabIndex = 6;
            this.btnConsultaOrdenCompra.Text = "Consultar";
            this.btnConsultaOrdenCompra.UseVisualStyleBackColor = true;
            this.btnConsultaOrdenCompra.Click += new System.EventHandler(this.btnConsultaOrdenCompra_Click);
            // 
            // cmbListOrdenCompra
            // 
            this.cmbListOrdenCompra.FormattingEnabled = true;
            this.cmbListOrdenCompra.Location = new System.Drawing.Point(459, 64);
            this.cmbListOrdenCompra.Name = "cmbListOrdenCompra";
            this.cmbListOrdenCompra.Size = new System.Drawing.Size(121, 21);
            this.cmbListOrdenCompra.TabIndex = 7;
            // 
            // cmbListVendOrdenCompra
            // 
            this.cmbListVendOrdenCompra.FormattingEnabled = true;
            this.cmbListVendOrdenCompra.Location = new System.Drawing.Point(459, 94);
            this.cmbListVendOrdenCompra.Name = "cmbListVendOrdenCompra";
            this.cmbListVendOrdenCompra.Size = new System.Drawing.Size(121, 21);
            this.cmbListVendOrdenCompra.TabIndex = 8;
            // 
            // cmbListRutCliOrdenCompra
            // 
            this.cmbListRutCliOrdenCompra.FormattingEnabled = true;
            this.cmbListRutCliOrdenCompra.Location = new System.Drawing.Point(459, 124);
            this.cmbListRutCliOrdenCompra.Name = "cmbListRutCliOrdenCompra";
            this.cmbListRutCliOrdenCompra.Size = new System.Drawing.Size(121, 21);
            this.cmbListRutCliOrdenCompra.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Detalles de la Orden:";
            // 
            // DetallesOrdCompDGV
            // 
            this.DetallesOrdCompDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesOrdCompDGV.Location = new System.Drawing.Point(53, 243);
            this.DetallesOrdCompDGV.Name = "DetallesOrdCompDGV";
            this.DetallesOrdCompDGV.Size = new System.Drawing.Size(851, 143);
            this.DetallesOrdCompDGV.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id Producto:";
            // 
            // cmbListIdProdOrden
            // 
            this.cmbListIdProdOrden.FormattingEnabled = true;
            this.cmbListIdProdOrden.Location = new System.Drawing.Point(459, 153);
            this.cmbListIdProdOrden.Name = "cmbListIdProdOrden";
            this.cmbListIdProdOrden.Size = new System.Drawing.Size(121, 21);
            this.cmbListIdProdOrden.TabIndex = 13;
            // 
            // ConsultarDatosOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.cmbListIdProdOrden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DetallesOrdCompDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbListRutCliOrdenCompra);
            this.Controls.Add(this.cmbListVendOrdenCompra);
            this.Controls.Add(this.cmbListOrdenCompra);
            this.Controls.Add(this.btnConsultaOrdenCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolvConsOrdCom);
            this.Name = "ConsultarDatosOrdenCompra";
            this.Text = "ConsultarDatosOrdenCompra";
            this.Load += new System.EventHandler(this.ConsultarDatosOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetallesOrdCompDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolvConsOrdCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultaOrdenCompra;
        private System.Windows.Forms.ComboBox cmbListOrdenCompra;
        private System.Windows.Forms.ComboBox cmbListVendOrdenCompra;
        private System.Windows.Forms.ComboBox cmbListRutCliOrdenCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DetallesOrdCompDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbListIdProdOrden;
    }
}