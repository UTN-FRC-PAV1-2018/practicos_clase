namespace TPS_BugTracker.GUILayer.Bugs
{
    partial class frmDetalleBug
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCriticidad = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNroBug = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_historiales = new System.Windows.Forms.DataGridView();
            this.fec_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignado_a_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historiales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCriticidad);
            this.tabPage1.Controls.Add(this.Label10);
            this.tabPage1.Controls.Add(this.txtFechaAlta);
            this.tabPage1.Controls.Add(this.Label9);
            this.tabPage1.Controls.Add(this.txtPrioridad);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.Label5);
            this.tabPage1.Controls.Add(this.txtProducto);
            this.tabPage1.Controls.Add(this.Label4);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Controls.Add(this.txtTitulo);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.txtNroBug);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCriticidad
            // 
            this.txtCriticidad.Enabled = false;
            this.txtCriticidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriticidad.Location = new System.Drawing.Point(146, 279);
            this.txtCriticidad.Name = "txtCriticidad";
            this.txtCriticidad.Size = new System.Drawing.Size(262, 22);
            this.txtCriticidad.TabIndex = 36;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(93, 279);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(53, 13);
            this.Label10.TabIndex = 35;
            this.Label10.Text = "Criticidad:";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Enabled = false;
            this.txtFechaAlta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAlta.Location = new System.Drawing.Point(146, 102);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(123, 22);
            this.txtFechaAlta.TabIndex = 34;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(60, 107);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(84, 13);
            this.Label9.TabIndex = 33;
            this.Label9.Text = "Fecha creación:";
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Enabled = false;
            this.txtPrioridad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioridad.Location = new System.Drawing.Point(146, 253);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.Size = new System.Drawing.Size(262, 22);
            this.txtPrioridad.TabIndex = 32;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(98, 256);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(51, 13);
            this.Label7.TabIndex = 31;
            this.Label7.Text = "Prioridad:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(146, 228);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(262, 22);
            this.txtEstado.TabIndex = 30;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(101, 233);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 13);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Estado:";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(146, 77);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(262, 22);
            this.txtProducto.TabIndex = 28;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(91, 82);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Producto:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(146, 128);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(262, 97);
            this.txtDescripcion.TabIndex = 26;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(78, 171);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(66, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Descripción:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(146, 51);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(262, 22);
            this.txtTitulo.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(107, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Título:";
            // 
            // txtNroBug
            // 
            this.txtNroBug.Enabled = false;
            this.txtNroBug.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroBug.Location = new System.Drawing.Point(146, 26);
            this.txtNroBug.Name = "txtNroBug";
            this.txtNroBug.Size = new System.Drawing.Size(68, 22);
            this.txtNroBug.TabIndex = 22;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(107, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "# Bug:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_historiales);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_historiales
            // 
            this.dgv_historiales.AllowUserToAddRows = false;
            this.dgv_historiales.AllowUserToDeleteRows = false;
            this.dgv_historiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historiales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fec_col,
            this.responsable_col,
            this.estado_col,
            this.asignado_a_col});
            this.dgv_historiales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historiales.Location = new System.Drawing.Point(3, 3);
            this.dgv_historiales.Name = "dgv_historiales";
            this.dgv_historiales.ReadOnly = true;
            this.dgv_historiales.Size = new System.Drawing.Size(498, 351);
            this.dgv_historiales.TabIndex = 23;
            // 
            // fec_col
            // 
            this.fec_col.HeaderText = "Fecha";
            this.fec_col.Name = "fec_col";
            this.fec_col.ReadOnly = true;
            // 
            // responsable_col
            // 
            this.responsable_col.HeaderText = "Responsable";
            this.responsable_col.Name = "responsable_col";
            this.responsable_col.ReadOnly = true;
            // 
            // estado_col
            // 
            this.estado_col.HeaderText = "Estado";
            this.estado_col.Name = "estado_col";
            this.estado_col.ReadOnly = true;
            // 
            // asignado_a_col
            // 
            this.asignado_a_col.HeaderText = "Asignado a";
            this.asignado_a_col.Name = "asignado_a_col";
            this.asignado_a_col.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(455, 421);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmDetalleBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 454);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDetalleBug";
            this.Text = "Detalle de bug";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historiales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.TextBox txtCriticidad;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtFechaAlta;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPrioridad;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtProducto;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtTitulo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNroBug;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.DataGridView dgv_historiales;
        internal System.Windows.Forms.DataGridViewTextBoxColumn fec_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn responsable_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn estado_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn asignado_a_col;
        internal System.Windows.Forms.Button btnAceptar;
    }
}