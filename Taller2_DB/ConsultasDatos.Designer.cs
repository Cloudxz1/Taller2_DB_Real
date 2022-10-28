
namespace Taller2_DB
{
    partial class ConsultasDatos
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
            this.btnVolverConsultas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListadoDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatosVendedor1 = new System.Windows.Forms.Button();
            this.btnVendAntigTipo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolverConsultas
            // 
            this.btnVolverConsultas.Location = new System.Drawing.Point(21, 405);
            this.btnVolverConsultas.Name = "btnVolverConsultas";
            this.btnVolverConsultas.Size = new System.Drawing.Size(75, 23);
            this.btnVolverConsultas.TabIndex = 0;
            this.btnVolverConsultas.Text = "Volver";
            this.btnVolverConsultas.UseVisualStyleBackColor = true;
            this.btnVolverConsultas.Click += new System.EventHandler(this.btnVolverConsultas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1) Listado Datos:";
            // 
            // btnListadoDatos
            // 
            this.btnListadoDatos.Location = new System.Drawing.Point(46, 80);
            this.btnListadoDatos.Name = "btnListadoDatos";
            this.btnListadoDatos.Size = new System.Drawing.Size(75, 23);
            this.btnListadoDatos.TabIndex = 2;
            this.btnListadoDatos.Text = "Ir";
            this.btnListadoDatos.UseVisualStyleBackColor = true;
            this.btnListadoDatos.Click += new System.EventHandler(this.btnListadoDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2) Datos Vendedor";
            // 
            // btnDatosVendedor1
            // 
            this.btnDatosVendedor1.Location = new System.Drawing.Point(191, 80);
            this.btnDatosVendedor1.Name = "btnDatosVendedor1";
            this.btnDatosVendedor1.Size = new System.Drawing.Size(84, 23);
            this.btnDatosVendedor1.TabIndex = 4;
            this.btnDatosVendedor1.Text = "Ir";
            this.btnDatosVendedor1.UseVisualStyleBackColor = true;
            this.btnDatosVendedor1.Click += new System.EventHandler(this.btnDatosVendedor1_Click);
            // 
            // btnVendAntigTipo
            // 
            this.btnVendAntigTipo.Location = new System.Drawing.Point(352, 80);
            this.btnVendAntigTipo.Name = "btnVendAntigTipo";
            this.btnVendAntigTipo.Size = new System.Drawing.Size(75, 23);
            this.btnVendAntigTipo.TabIndex = 6;
            this.btnVendAntigTipo.Text = "Ir";
            this.btnVendAntigTipo.UseVisualStyleBackColor = true;
            this.btnVendAntigTipo.Click += new System.EventHandler(this.btnVendAntigTipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "3) Vendedor Tipo Antiguedad";
            // 
            // ConsultasDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVendAntigTipo);
            this.Controls.Add(this.btnDatosVendedor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListadoDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverConsultas);
            this.Name = "ConsultasDatos";
            this.Text = "ConsultasDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListadoDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatosVendedor1;
        private System.Windows.Forms.Button btnVendAntigTipo;
        private System.Windows.Forms.Label label3;
    }
}