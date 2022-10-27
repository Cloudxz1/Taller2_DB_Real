
namespace Taller2_DB
{
    partial class Administrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.contrasenia = new System.Windows.Forms.TextBox();
            this.btn_acceso = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la contraseña";
            // 
            // contrasenia
            // 
            this.contrasenia.Location = new System.Drawing.Point(98, 105);
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.PasswordChar = '*';
            this.contrasenia.Size = new System.Drawing.Size(173, 22);
            this.contrasenia.TabIndex = 1;
            // 
            // btn_acceso
            // 
            this.btn_acceso.Location = new System.Drawing.Point(140, 133);
            this.btn_acceso.Name = "btn_acceso";
            this.btn_acceso.Size = new System.Drawing.Size(93, 40);
            this.btn_acceso.TabIndex = 2;
            this.btn_acceso.Text = "Acceder";
            this.btn_acceso.UseVisualStyleBackColor = true;
            this.btn_acceso.Click += new System.EventHandler(this.btn_acceso_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(12, 12);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(89, 38);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 269);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_acceso);
            this.Controls.Add(this.contrasenia);
            this.Controls.Add(this.label1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contrasenia;
        private System.Windows.Forms.Button btn_acceso;
        private System.Windows.Forms.Button btn_volver;
    }
}