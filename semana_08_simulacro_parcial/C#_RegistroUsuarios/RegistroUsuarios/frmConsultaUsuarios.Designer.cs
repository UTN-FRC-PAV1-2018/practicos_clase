namespace RegistroUsuarios.GUILayer
{
    partial class frmConsultaUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.btnDetalleUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnl_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(26, 115);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(372, 192);
            this.dgvUsuarios.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::RegistroUsuarios.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(385, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(74, 75);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(311, 86);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(74, 48);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(181, 21);
            this.cboPerfiles.TabIndex = 1;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(32, 51);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(33, 13);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Perfil:";
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.dgvUsuarios);
            this.pnl_filtros.Controls.Add(this.chkTodos);
            this.pnl_filtros.Controls.Add(this.Label3);
            this.pnl_filtros.Controls.Add(this.txtNombre);
            this.pnl_filtros.Controls.Add(this.btnConsultar);
            this.pnl_filtros.Controls.Add(this.cboPerfiles);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Location = new System.Drawing.Point(12, 12);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(413, 313);
            this.pnl_filtros.TabIndex = 8;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // btnDetalleUsuario
            // 
            this.btnDetalleUsuario.Image = global::RegistroUsuarios.Properties.Resources.comentar;
            this.btnDetalleUsuario.Location = new System.Drawing.Point(12, 331);
            this.btnDetalleUsuario.Name = "btnDetalleUsuario";
            this.btnDetalleUsuario.Size = new System.Drawing.Size(40, 40);
            this.btnDetalleUsuario.TabIndex = 9;
            this.btnDetalleUsuario.UseVisualStyleBackColor = true;
            // 
            // frmConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 393);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetalleUsuario);
            this.Controls.Add(this.pnl_filtros);
            this.Name = "frmConsultaUsuarios";
            this.Text = "Consulta Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvUsuarios;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.CheckBox chkTodos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.ComboBox cboPerfiles;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.GroupBox pnl_filtros;
        internal System.Windows.Forms.Button btnDetalleUsuario;
    }
}