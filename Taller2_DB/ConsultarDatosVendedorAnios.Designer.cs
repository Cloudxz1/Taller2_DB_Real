
namespace Taller2_DB
{
    partial class ConsultarDatosVendedorAnios
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
            this.btnVolDatosVendAnios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolDatosVendAnios
            // 
            this.btnVolDatosVendAnios.Location = new System.Drawing.Point(22, 404);
            this.btnVolDatosVendAnios.Name = "btnVolDatosVendAnios";
            this.btnVolDatosVendAnios.Size = new System.Drawing.Size(75, 23);
            this.btnVolDatosVendAnios.TabIndex = 0;
            this.btnVolDatosVendAnios.Text = "Volver";
            this.btnVolDatosVendAnios.UseVisualStyleBackColor = true;
            this.btnVolDatosVendAnios.Click += new System.EventHandler(this.btnVolDatosVendAnios_Click);
            // 
            // ConsultarDatosVendedorAnios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolDatosVendAnios);
            this.Name = "ConsultarDatosVendedorAnios";
            this.Text = "ConsultarDatosVendedorAnios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolDatosVendAnios;
    }
}