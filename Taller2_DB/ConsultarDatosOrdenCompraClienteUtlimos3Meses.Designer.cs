
namespace Taller2_DB
{
    partial class ConsultarDatosOrdenCompraClienteUtlimos3Meses
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
            this.btnVolOrdCompCli3Mes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbListRutOrdCompCli = new System.Windows.Forms.ComboBox();
            this.btnBuscarRutOrdCompCli3M = new System.Windows.Forms.Button();
            this.dgvListRutCliOrdComp3m = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRutCliOrdComp3m)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolOrdCompCli3Mes
            // 
            this.btnVolOrdCompCli3Mes.Location = new System.Drawing.Point(24, 403);
            this.btnVolOrdCompCli3Mes.Name = "btnVolOrdCompCli3Mes";
            this.btnVolOrdCompCli3Mes.Size = new System.Drawing.Size(75, 23);
            this.btnVolOrdCompCli3Mes.TabIndex = 0;
            this.btnVolOrdCompCli3Mes.Text = "Volver";
            this.btnVolOrdCompCli3Mes.UseVisualStyleBackColor = true;
            this.btnVolOrdCompCli3Mes.Click += new System.EventHandler(this.btnVolOrdCompCli3Mes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos de la orden de compra del cliente de los ultimos 3 meses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut del Cliente:";
            // 
            // cmbListRutOrdCompCli
            // 
            this.cmbListRutOrdCompCli.FormattingEnabled = true;
            this.cmbListRutOrdCompCli.Location = new System.Drawing.Point(330, 102);
            this.cmbListRutOrdCompCli.Name = "cmbListRutOrdCompCli";
            this.cmbListRutOrdCompCli.Size = new System.Drawing.Size(121, 21);
            this.cmbListRutOrdCompCli.TabIndex = 3;
            // 
            // btnBuscarRutOrdCompCli3M
            // 
            this.btnBuscarRutOrdCompCli3M.Location = new System.Drawing.Point(352, 129);
            this.btnBuscarRutOrdCompCli3M.Name = "btnBuscarRutOrdCompCli3M";
            this.btnBuscarRutOrdCompCli3M.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRutOrdCompCli3M.TabIndex = 4;
            this.btnBuscarRutOrdCompCli3M.Text = "Buscar";
            this.btnBuscarRutOrdCompCli3M.UseVisualStyleBackColor = true;
            this.btnBuscarRutOrdCompCli3M.Click += new System.EventHandler(this.btnBuscarRutOrdCompCli3M_Click);
            // 
            // dgvListRutCliOrdComp3m
            // 
            this.dgvListRutCliOrdComp3m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRutCliOrdComp3m.Location = new System.Drawing.Point(93, 211);
            this.dgvListRutCliOrdComp3m.Name = "dgvListRutCliOrdComp3m";
            this.dgvListRutCliOrdComp3m.ReadOnly = true;
            this.dgvListRutCliOrdComp3m.Size = new System.Drawing.Size(620, 150);
            this.dgvListRutCliOrdComp3m.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detalles de Busqueda:";
            // 
            // ConsultarDatosOrdenCompraClienteUtlimos3Meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListRutCliOrdComp3m);
            this.Controls.Add(this.btnBuscarRutOrdCompCli3M);
            this.Controls.Add(this.cmbListRutOrdCompCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolOrdCompCli3Mes);
            this.Name = "ConsultarDatosOrdenCompraClienteUtlimos3Meses";
            this.Text = "ConsultarDatosOrdenCompraClienteUtlimos3Meses";
            this.Load += new System.EventHandler(this.ConsultarDatosOrdenCompraClienteUtlimos3Meses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRutCliOrdComp3m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolOrdCompCli3Mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbListRutOrdCompCli;
        private System.Windows.Forms.Button btnBuscarRutOrdCompCli3M;
        private System.Windows.Forms.DataGridView dgvListRutCliOrdComp3m;
        private System.Windows.Forms.Label label3;
    }
}