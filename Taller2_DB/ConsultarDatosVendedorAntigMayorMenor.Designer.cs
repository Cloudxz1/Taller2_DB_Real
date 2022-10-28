
namespace Taller2_DB
{
    partial class ConsultarDatosVendedorAntigMayorMenor
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
            this.btnVolverVendAntigMayMen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverVendAntigMayMen
            // 
            this.btnVolverVendAntigMayMen.Location = new System.Drawing.Point(29, 404);
            this.btnVolverVendAntigMayMen.Name = "btnVolverVendAntigMayMen";
            this.btnVolverVendAntigMayMen.Size = new System.Drawing.Size(75, 23);
            this.btnVolverVendAntigMayMen.TabIndex = 0;
            this.btnVolverVendAntigMayMen.Text = "Volver";
            this.btnVolverVendAntigMayMen.UseVisualStyleBackColor = true;
            this.btnVolverVendAntigMayMen.Click += new System.EventHandler(this.btnVolverVendAntigMayMen_Click);
            // 
            // ConsultarDatosVendedorAntigMayorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverVendAntigMayMen);
            this.Name = "ConsultarDatosVendedorAntigMayorMenor";
            this.Text = "ConsultarDatosVendedorAntigMayorMenor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverVendAntigMayMen;
    }
}