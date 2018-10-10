namespace TPS_BugTracker.GUILayer.Bugs
{
    partial class frmActualizarBug
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
            this.cbo_criticidades = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbo_prioridades = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_descri = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cbo_productos = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbo_criticidades
            // 
            this.cbo_criticidades.FormattingEnabled = true;
            this.cbo_criticidades.Location = new System.Drawing.Point(87, 178);
            this.cbo_criticidades.Name = "cbo_criticidades";
            this.cbo_criticidades.Size = new System.Drawing.Size(254, 21);
            this.cbo_criticidades.TabIndex = 35;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(34, 181);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 13);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Prioridad:";
            // 
            // cbo_prioridades
            // 
            this.cbo_prioridades.FormattingEnabled = true;
            this.cbo_prioridades.Location = new System.Drawing.Point(87, 151);
            this.cbo_prioridades.Name = "cbo_prioridades";
            this.cbo_prioridades.Size = new System.Drawing.Size(254, 21);
            this.cbo_prioridades.TabIndex = 34;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(32, 154);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 13);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Criticidad:";
            // 
            // txt_descri
            // 
            this.txt_descri.Location = new System.Drawing.Point(87, 46);
            this.txt_descri.MaxLength = 1000;
            this.txt_descri.Multiline = true;
            this.txt_descri.Name = "txt_descri";
            this.txt_descri.Size = new System.Drawing.Size(254, 72);
            this.txt_descri.TabIndex = 32;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(194, 224);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 23);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(110, 224);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(78, 23);
            this.btn_aceptar.TabIndex = 36;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cbo_productos
            // 
            this.cbo_productos.FormattingEnabled = true;
            this.cbo_productos.Location = new System.Drawing.Point(87, 124);
            this.cbo_productos.Name = "cbo_productos";
            this.cbo_productos.Size = new System.Drawing.Size(254, 21);
            this.cbo_productos.TabIndex = 33;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(18, 124);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "Producto(*):";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "Descripción:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(38, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "Titulo(*):";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(87, 19);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(254, 20);
            this.txt_nombre.TabIndex = 31;
            // 
            // frmActualizarBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 272);
            this.Controls.Add(this.cbo_criticidades);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cbo_prioridades);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_descri);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cbo_productos);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_nombre);
            this.Name = "frmActualizarBug";
            this.Text = "Actualizar Bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbo_criticidades;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbo_prioridades;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_descri;
        internal System.Windows.Forms.Button btn_cancelar;
        internal System.Windows.Forms.Button btn_aceptar;
        internal System.Windows.Forms.ComboBox cbo_productos;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_nombre;
    }
}