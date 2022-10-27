
namespace Taller2_DB
{
    partial class CambiarSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarSalario));
            this.dataVendedor = new System.Windows.Forms.DataGridView();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Cambiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nVendedor = new System.Windows.Forms.TextBox();
            this.salarioN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVendedor
            // 
            this.dataVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVendedor.Location = new System.Drawing.Point(134, 73);
            this.dataVendedor.Name = "dataVendedor";
            this.dataVendedor.RowHeadersWidth = 51;
            this.dataVendedor.RowTemplate.Height = 24;
            this.dataVendedor.Size = new System.Drawing.Size(370, 216);
            this.dataVendedor.TabIndex = 0;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(91, 41);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Cambiar
            // 
            this.btn_Cambiar.Location = new System.Drawing.Point(265, 385);
            this.btn_Cambiar.Name = "btn_Cambiar";
            this.btn_Cambiar.Size = new System.Drawing.Size(95, 38);
            this.btn_Cambiar.TabIndex = 2;
            this.btn_Cambiar.Text = "Confirmar";
            this.btn_Cambiar.UseVisualStyleBackColor = true;
            this.btn_Cambiar.Click += new System.EventHandler(this.btn_Cambiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "N°Vendedor";
            // 
            // nVendedor
            // 
            this.nVendedor.Location = new System.Drawing.Point(237, 312);
            this.nVendedor.Name = "nVendedor";
            this.nVendedor.Size = new System.Drawing.Size(159, 22);
            this.nVendedor.TabIndex = 4;
            // 
            // salarioN
            // 
            this.salarioN.Location = new System.Drawing.Point(237, 357);
            this.salarioN.Name = "salarioN";
            this.salarioN.Size = new System.Drawing.Size(159, 22);
            this.salarioN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario Nuevo";
            // 
            // CambiarSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 438);
            this.Controls.Add(this.salarioN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cambiar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.dataVendedor);
            this.Name = "CambiarSalario";
            this.Text = "CambiarSalario";
            this.Load += new System.EventHandler(this.CambiarSalario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVendedor;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Cambiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nVendedor;
        private System.Windows.Forms.TextBox salarioN;
        private System.Windows.Forms.Label label2;
    }
}