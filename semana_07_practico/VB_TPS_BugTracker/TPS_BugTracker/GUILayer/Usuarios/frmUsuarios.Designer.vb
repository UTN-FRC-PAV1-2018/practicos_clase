<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_perfiles = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.col_pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(74, 75)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(311, 86)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_perfiles
        '
        Me.cbo_perfiles.FormattingEnabled = True
        Me.cbo_perfiles.Location = New System.Drawing.Point(74, 48)
        Me.cbo_perfiles.Name = "cbo_perfiles"
        Me.cbo_perfiles.Size = New System.Drawing.Size(181, 21)
        Me.cbo_perfiles.TabIndex = 1
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(32, 51)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(33, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Perfil:"
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_perfil
        '
        Me.col_perfil.HeaderText = "Perfil"
        Me.col_perfil.Name = "col_perfil"
        Me.col_perfil.ReadOnly = True
        '
        'col_email
        '
        Me.col_email.HeaderText = "Email"
        Me.col_email.Name = "col_email"
        Me.col_email.ReadOnly = True
        Me.col_email.Width = 130
        '
        'id_perfil_col
        '
        Me.id_perfil_col.HeaderText = "id_perfil"
        Me.id_perfil_col.Name = "id_perfil_col"
        Me.id_perfil_col.ReadOnly = True
        Me.id_perfil_col.Visible = False
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.id_perfil_col, Me.col_email, Me.col_perfil, Me.col_id, Me.col_pass})
        Me.dgv_users.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_users.Location = New System.Drawing.Point(3, 118)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_users.Size = New System.Drawing.Size(407, 192)
        Me.dgv_users.TabIndex = 8
        '
        'col_pass
        '
        Me.col_pass.HeaderText = "Password"
        Me.col_pass.Name = "col_pass"
        Me.col_pass.ReadOnly = True
        Me.col_pass.Visible = False
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgv_users)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_nombre)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.cbo_perfiles)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(14, 17)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 313)
        Me.pnl_filtros.TabIndex = 13
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.TPS_InicioSesion.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(106, 336)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_quitar.TabIndex = 16
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.TPS_InicioSesion.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(387, 336)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.TPS_InicioSesion.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(60, 336)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 15
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.TPS_InicioSesion.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(14, 336)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 14
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 393)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.Text = "Usuarios"
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents cbo_perfiles As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents col_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_users As System.Windows.Forms.DataGridView
    Friend WithEvents col_pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
End Class
