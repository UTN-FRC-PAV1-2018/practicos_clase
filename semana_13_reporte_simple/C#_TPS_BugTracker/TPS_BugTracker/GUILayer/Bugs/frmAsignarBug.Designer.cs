namespace TPS_BugTracker.GUILayer.Bugs
{
    partial class frmAsignarBug
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtIdBug = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbo_desa = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(186, 123);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(105, 123);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(91, 52);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(244, 20);
            this.txtTitulo.TabIndex = 13;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(49, 55);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Título:";
            // 
            // txtIdBug
            // 
            this.txtIdBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIdBug.Enabled = false;
            this.txtIdBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBug.ForeColor = System.Drawing.Color.Black;
            this.txtIdBug.Location = new System.Drawing.Point(91, 27);
            this.txtIdBug.Name = "txtIdBug";
            this.txtIdBug.Size = new System.Drawing.Size(85, 20);
            this.txtIdBug.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(49, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "# Bug:";
            // 
            // cbo_desa
            // 
            this.cbo_desa.FormattingEnabled = true;
            this.cbo_desa.Location = new System.Drawing.Point(91, 78);
            this.cbo_desa.Name = "cbo_desa";
            this.cbo_desa.Size = new System.Drawing.Size(244, 21);
            this.cbo_desa.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Asignar a (*):";
            // 
            // frmAsignarBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 172);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtIdBug);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cbo_desa);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignarBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignar Bug a desarrollador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_cancelar;
        internal System.Windows.Forms.Button btn_aceptar;
        internal System.Windows.Forms.TextBox txtTitulo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtIdBug;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbo_desa;
        internal System.Windows.Forms.Label Label1;

    }
}