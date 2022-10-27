
namespace Taller2_DB
{
    partial class EliminarCliente
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rutEliminar = new System.Windows.Forms.TextBox();
            this.EliminarCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(93, 41);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dataCliente
            // 
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCliente.Location = new System.Drawing.Point(165, 80);
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.RowHeadersWidth = 51;
            this.dataCliente.RowTemplate.Height = 24;
            this.dataCliente.Size = new System.Drawing.Size(592, 191);
            this.dataCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rut a eliminar";
            // 
            // rutEliminar
            // 
            this.rutEliminar.Location = new System.Drawing.Point(358, 294);
            this.rutEliminar.Name = "rutEliminar";
            this.rutEliminar.Size = new System.Drawing.Size(192, 22);
            this.rutEliminar.TabIndex = 3;
            // 
            // EliminarCli
            // 
            this.EliminarCli.Location = new System.Drawing.Point(401, 322);
            this.EliminarCli.Name = "EliminarCli";
            this.EliminarCli.Size = new System.Drawing.Size(102, 35);
            this.EliminarCli.TabIndex = 4;
            this.EliminarCli.Text = "Eliminar";
            this.EliminarCli.UseVisualStyleBackColor = true;
            this.EliminarCli.Click += new System.EventHandler(this.EliminarCli_Click);
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 384);
            this.Controls.Add(this.EliminarCli);
            this.Controls.Add(this.rutEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCliente);
            this.Controls.Add(this.btn_Volver);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rutEliminar;
        private System.Windows.Forms.Button EliminarCli;
    }
}