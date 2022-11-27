
namespace Taller2_DB
{
    partial class ConsultarDatosProductosTop5MasVendidoSemana
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
            this.btnVolTop5ProdVend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerTop5ProdVend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTop5ProdMasVendSemAnt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5ProdMasVendSemAnt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolTop5ProdVend
            // 
            this.btnVolTop5ProdVend.Location = new System.Drawing.Point(24, 403);
            this.btnVolTop5ProdVend.Name = "btnVolTop5ProdVend";
            this.btnVolTop5ProdVend.Size = new System.Drawing.Size(75, 23);
            this.btnVolTop5ProdVend.TabIndex = 0;
            this.btnVolTop5ProdVend.Text = "Volver";
            this.btnVolTop5ProdVend.UseVisualStyleBackColor = true;
            this.btnVolTop5ProdVend.Click += new System.EventHandler(this.btnVolTop5ProdVend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top 5 Productos mas vendidos de la semana pasada";
            // 
            // btnVerTop5ProdVend
            // 
            this.btnVerTop5ProdVend.Location = new System.Drawing.Point(359, 91);
            this.btnVerTop5ProdVend.Name = "btnVerTop5ProdVend";
            this.btnVerTop5ProdVend.Size = new System.Drawing.Size(75, 23);
            this.btnVerTop5ProdVend.TabIndex = 2;
            this.btnVerTop5ProdVend.Text = "Ver Top";
            this.btnVerTop5ProdVend.UseVisualStyleBackColor = true;
            this.btnVerTop5ProdVend.Click += new System.EventHandler(this.btnVerTop5ProdVend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalles de informacion:";
            // 
            // dgvTop5ProdMasVendSemAnt
            // 
            this.dgvTop5ProdMasVendSemAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5ProdMasVendSemAnt.Location = new System.Drawing.Point(62, 175);
            this.dgvTop5ProdMasVendSemAnt.Name = "dgvTop5ProdMasVendSemAnt";
            this.dgvTop5ProdMasVendSemAnt.Size = new System.Drawing.Size(675, 194);
            this.dgvTop5ProdMasVendSemAnt.TabIndex = 4;
            this.dgvTop5ProdMasVendSemAnt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTop5ProdMasVendSemAnt_CellContentClick);
            // 
            // ConsultarDatosProductosTop5MasVendidoSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTop5ProdMasVendSemAnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerTop5ProdVend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolTop5ProdVend);
            this.Name = "ConsultarDatosProductosTop5MasVendidoSemana";
            this.Text = "ConsultarDatosProductosTop5MasVendidoSemana";
            this.Load += new System.EventHandler(this.ConsultarDatosProductosTop5MasVendidoSemana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5ProdMasVendSemAnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolTop5ProdVend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerTop5ProdVend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTop5ProdMasVendSemAnt;
    }
}