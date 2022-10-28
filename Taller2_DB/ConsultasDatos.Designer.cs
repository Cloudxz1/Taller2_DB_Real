
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
            this.label1.Location = new System.Drawing.Point(100, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado Datos:";
            // 
            // btnListadoDatos
            // 
            this.btnListadoDatos.Location = new System.Drawing.Point(100, 74);
            this.btnListadoDatos.Name = "btnListadoDatos";
            this.btnListadoDatos.Size = new System.Drawing.Size(75, 23);
            this.btnListadoDatos.TabIndex = 2;
            this.btnListadoDatos.Text = "Ir";
            this.btnListadoDatos.UseVisualStyleBackColor = true;
            this.btnListadoDatos.Click += new System.EventHandler(this.btnListadoDatos_Click);
            // 
            // ConsultasDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}