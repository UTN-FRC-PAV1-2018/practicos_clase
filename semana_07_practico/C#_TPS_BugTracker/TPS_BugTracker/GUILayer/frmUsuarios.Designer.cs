namespace TPS_BugTracker.GUILayer
{
    partial class frmUsuarios
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
            this.btn_quitar = new System.Windows.Forms.Button();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_perfil_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.pnl_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quitar
            // 
            this.btn_quitar.Enabled = false;
            this.btn_quitar.Image = global::TPS_BugTracker.Properties.Resources.eliminar;
            this.btn_quitar.Location = new System.Drawing.Point(104, 331);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(40, 40);
            this.btn_quitar.TabIndex = 11;
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nombre,
            this.id_perfil_col,
            this.col_email,
            this.col_perfil,
            this.col_id,
            this.col_pass});
            this.dgv_users.Location = new System.Drawing.Point(26, 115);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(372, 192);
            this.dgv_users.TabIndex = 8;
            this.dgv_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellClick);
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // id_perfil_col
            // 
            this.id_perfil_col.HeaderText = "id_perfil";
            this.id_perfil_col.Name = "id_perfil_col";
            this.id_perfil_col.ReadOnly = true;
            this.id_perfil_col.Visible = false;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "Email";
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            this.col_email.Width = 130;
            // 
            // col_perfil
            // 
            this.col_perfil.HeaderText = "Perfil";
            this.col_perfil.Name = "col_perfil";
            this.col_perfil.ReadOnly = true;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_pass
            // 
            this.col_pass.HeaderText = "Password";
            this.col_pass.Name = "col_pass";
            this.col_pass.ReadOnly = true;
            this.col_pass.Visible = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::TPS_BugTracker.Properties.Resources.salir;
            this.btn_salir.Location = new System.Drawing.Point(385, 331);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(40, 40);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Image = global::TPS_BugTracker.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(58, 331);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(40, 40);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = global::TPS_BugTracker.Properties.Resources.agregar;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 331);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(40, 40);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(74, 75);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 2;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
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
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(74, 22);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(181, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(311, 86);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(87, 23);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // cbo_perfiles
            // 
            this.cbo_perfiles.FormattingEnabled = true;
            this.cbo_perfiles.Location = new System.Drawing.Point(74, 48);
            this.cbo_perfiles.Name = "cbo_perfiles";
            this.cbo_perfiles.Size = new System.Drawing.Size(181, 21);
            this.cbo_perfiles.TabIndex = 1;
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
            this.pnl_filtros.Controls.Add(this.dgv_users);
            this.pnl_filtros.Controls.Add(this.chk_todos);
            this.pnl_filtros.Controls.Add(this.Label3);
            this.pnl_filtros.Controls.Add(this.txt_nombre);
            this.pnl_filtros.Controls.Add(this.btn_consultar);
            this.pnl_filtros.Controls.Add(this.cbo_perfiles);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Location = new System.Drawing.Point(12, 12);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(413, 313);
            this.pnl_filtros.TabIndex = 8;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 393);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.pnl_filtros);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_quitar;
        internal System.Windows.Forms.DataGridView dgv_users;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        internal System.Windows.Forms.DataGridViewTextBoxColumn id_perfil_col;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col_perfil;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        internal System.Windows.Forms.DataGridViewTextBoxColumn col_pass;
        internal System.Windows.Forms.Button btn_salir;
        internal System.Windows.Forms.Button btn_editar;
        internal System.Windows.Forms.Button btn_nuevo;
        internal System.Windows.Forms.CheckBox chk_todos;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.Button btn_consultar;
        internal System.Windows.Forms.ComboBox cbo_perfiles;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.GroupBox pnl_filtros;
    }
}