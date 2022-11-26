
namespace Taller2_DB
{
    partial class ConsultarDatosCantProductoCateg
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
            this.btnVolverConCantProCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listaCantProdCatDGV = new System.Windows.Forms.DataGridView();
            this.btnBuscarCantProdCateg = new System.Windows.Forms.Button();
            this.cmbListaCateg2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCantProdCatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverConCantProCat
            // 
            this.btnVolverConCantProCat.Location = new System.Drawing.Point(23, 338);
            this.btnVolverConCantProCat.Name = "btnVolverConCantProCat";
            this.btnVolverConCantProCat.Size = new System.Drawing.Size(75, 23);
            this.btnVolverConCantProCat.TabIndex = 0;
            this.btnVolverConCantProCat.Text = "Volver";
            this.btnVolverConCantProCat.UseVisualStyleBackColor = true;
            this.btnVolverConCantProCat.Click += new System.EventHandler(this.btnVolverConCantProCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles:";
            // 
            // listaCantProdCatDGV
            // 
            this.listaCantProdCatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCantProdCatDGV.Location = new System.Drawing.Point(117, 185);
            this.listaCantProdCatDGV.Name = "listaCantProdCatDGV";
            this.listaCantProdCatDGV.ReadOnly = true;
            this.listaCantProdCatDGV.Size = new System.Drawing.Size(274, 100);
            this.listaCantProdCatDGV.TabIndex = 2;
            this.listaCantProdCatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCantProdCatDGV_CellContentClick);
            // 
            // btnBuscarCantProdCateg
            // 
            this.btnBuscarCantProdCateg.Location = new System.Drawing.Point(321, 103);
            this.btnBuscarCantProdCateg.Name = "btnBuscarCantProdCateg";
            this.btnBuscarCantProdCateg.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarCantProdCateg.TabIndex = 3;
            this.btnBuscarCantProdCateg.Text = "Buscar";
            this.btnBuscarCantProdCateg.UseVisualStyleBackColor = true;
            this.btnBuscarCantProdCateg.Click += new System.EventHandler(this.btnBuscarCantProdCateg_Click);
            // 
            // cmbListaCateg2
            // 
            this.cmbListaCateg2.FormattingEnabled = true;
            this.cmbListaCateg2.Location = new System.Drawing.Point(185, 103);
            this.cmbListaCateg2.Name = "cmbListaCateg2";
            this.cmbListaCateg2.Size = new System.Drawing.Size(121, 21);
            this.cmbListaCateg2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consultar Cantidad Productos";
            // 
            // ConsultarDatosCantProductoCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbListaCateg2);
            this.Controls.Add(this.btnBuscarCantProdCateg);
            this.Controls.Add(this.listaCantProdCatDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverConCantProCat);
            this.Name = "ConsultarDatosCantProductoCateg";
            this.Text = "ConsultarDatosCantProductoCateg";
            this.Load += new System.EventHandler(this.ConsultarDatosCantProductoCateg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCantProdCatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverConCantProCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaCantProdCatDGV;
        private System.Windows.Forms.Button btnBuscarCantProdCateg;
        private System.Windows.Forms.ComboBox cmbListaCateg2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}