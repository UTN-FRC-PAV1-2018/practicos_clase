namespace PrimeraClase_MessageBox
{
    partial class frmMensaje
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMensaje = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(79, 79);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(133, 23);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Mostrar mensaje";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(23, 56);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(50, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(79, 53);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(200, 20);
            this.txtMensaje.TabIndex = 2;
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 273);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMensaje);
            this.Name = "frmMensaje";
            this.Text = "Formulario Mensaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMensaje;

        #endregion

    }
}

