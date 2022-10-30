
namespace Taller2_DB
{
    partial class ConsultarDatosProductoSinOrdenCompraPorMes
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
            this.btnVolverProdSinOrdCom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListProdSinOrdCompDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListProdSinOrdCompDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverProdSinOrdCom
            // 
            this.btnVolverProdSinOrdCom.Location = new System.Drawing.Point(12, 405);
            this.btnVolverProdSinOrdCom.Name = "btnVolverProdSinOrdCom";
            this.btnVolverProdSinOrdCom.Size = new System.Drawing.Size(75, 23);
            this.btnVolverProdSinOrdCom.TabIndex = 0;
            this.btnVolverProdSinOrdCom.Text = "Volver";
            this.btnVolverProdSinOrdCom.UseVisualStyleBackColor = true;
            this.btnVolverProdSinOrdCom.Click += new System.EventHandler(this.btnVolverProdSinOrdCom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos Sin Orden de Compra en el Ultimo Mes:";
            // 
            // ListProdSinOrdCompDGV
            // 
            this.ListProdSinOrdCompDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListProdSinOrdCompDGV.Location = new System.Drawing.Point(89, 122);
            this.ListProdSinOrdCompDGV.Name = "ListProdSinOrdCompDGV";
            this.ListProdSinOrdCompDGV.Size = new System.Drawing.Size(634, 251);
            this.ListProdSinOrdCompDGV.TabIndex = 2;
            // 
            // ConsultarDatosProductoSinOrdenCompraPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListProdSinOrdCompDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverProdSinOrdCom);
            this.Name = "ConsultarDatosProductoSinOrdenCompraPorMes";
            this.Text = "ConsultarDatosProductoSinOrdenCompraPorMes";
            this.Load += new System.EventHandler(this.ConsultarDatosProductoSinOrdenCompraPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListProdSinOrdCompDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverProdSinOrdCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListProdSinOrdCompDGV;
    }
}