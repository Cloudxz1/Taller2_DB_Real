
namespace Taller2_DB
{
    partial class ConsultarDatosCantOrdenCompraClienteUltimos30dias
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
            this.btnVolOrdCompCli30d = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRutCliCantOrdComp30d = new System.Windows.Forms.ComboBox();
            this.btnBuscarRutCliCantOrdComp30d = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCantOrdenCompCliObtenida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantOrdenCompCliObtenida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolOrdCompCli30d
            // 
            this.btnVolOrdCompCli30d.Location = new System.Drawing.Point(12, 403);
            this.btnVolOrdCompCli30d.Name = "btnVolOrdCompCli30d";
            this.btnVolOrdCompCli30d.Size = new System.Drawing.Size(75, 23);
            this.btnVolOrdCompCli30d.TabIndex = 0;
            this.btnVolOrdCompCli30d.Text = "Volver";
            this.btnVolOrdCompCli30d.UseVisualStyleBackColor = true;
            this.btnVolOrdCompCli30d.Click += new System.EventHandler(this.btnVolOrdCompCli30d_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad Orden de Compra del Cliente en los ultimos 30 dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut del Cliente:";
            // 
            // cmbRutCliCantOrdComp30d
            // 
            this.cmbRutCliCantOrdComp30d.FormattingEnabled = true;
            this.cmbRutCliCantOrdComp30d.Location = new System.Drawing.Point(323, 121);
            this.cmbRutCliCantOrdComp30d.Name = "cmbRutCliCantOrdComp30d";
            this.cmbRutCliCantOrdComp30d.Size = new System.Drawing.Size(121, 21);
            this.cmbRutCliCantOrdComp30d.TabIndex = 3;
            // 
            // btnBuscarRutCliCantOrdComp30d
            // 
            this.btnBuscarRutCliCantOrdComp30d.Location = new System.Drawing.Point(349, 148);
            this.btnBuscarRutCliCantOrdComp30d.Name = "btnBuscarRutCliCantOrdComp30d";
            this.btnBuscarRutCliCantOrdComp30d.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRutCliCantOrdComp30d.TabIndex = 4;
            this.btnBuscarRutCliCantOrdComp30d.Text = "Buscar";
            this.btnBuscarRutCliCantOrdComp30d.UseVisualStyleBackColor = true;
            this.btnBuscarRutCliCantOrdComp30d.Click += new System.EventHandler(this.btnBuscarRutCliCantOrdComp30d_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalles de Busqueda:";
            // 
            // dgvCantOrdenCompCliObtenida
            // 
            this.dgvCantOrdenCompCliObtenida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantOrdenCompCliObtenida.Location = new System.Drawing.Point(123, 205);
            this.dgvCantOrdenCompCliObtenida.Name = "dgvCantOrdenCompCliObtenida";
            this.dgvCantOrdenCompCliObtenida.ReadOnly = true;
            this.dgvCantOrdenCompCliObtenida.Size = new System.Drawing.Size(521, 150);
            this.dgvCantOrdenCompCliObtenida.TabIndex = 6;
            // 
            // ConsultarDatosCantOrdenCompraClienteUltimos30dias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCantOrdenCompCliObtenida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarRutCliCantOrdComp30d);
            this.Controls.Add(this.cmbRutCliCantOrdComp30d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolOrdCompCli30d);
            this.Name = "ConsultarDatosCantOrdenCompraClienteUltimos30dias";
            this.Text = "ConsultarDatosCantOrdenCompraClienteUltimos30dias";
            this.Load += new System.EventHandler(this.ConsultarDatosCantOrdenCompraClienteUltimos30dias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantOrdenCompCliObtenida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolOrdCompCli30d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRutCliCantOrdComp30d;
        private System.Windows.Forms.Button btnBuscarRutCliCantOrdComp30d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCantOrdenCompCliObtenida;
    }
}