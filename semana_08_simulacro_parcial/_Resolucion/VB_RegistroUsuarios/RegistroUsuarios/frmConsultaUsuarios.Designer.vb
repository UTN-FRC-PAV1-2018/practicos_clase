<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaUsuarios
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cboPerfiles = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.btnDetalleUsuario = New System.Windows.Forms.Button()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.IDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerfilColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.RegistroUsuarios.My.Resources.Resources.salir
        Me.btnSalir.Location = New System.Drawing.Point(379, 331)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(74, 75)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
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
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(74, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(320, 86)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(87, 23)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cboPerfiles
        '
        Me.cboPerfiles.FormattingEnabled = True
        Me.cboPerfiles.Location = New System.Drawing.Point(74, 48)
        Me.cboPerfiles.Name = "cboPerfiles"
        Me.cboPerfiles.Size = New System.Drawing.Size(181, 21)
        Me.cboPerfiles.TabIndex = 1
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
        'btnDetalleUsuario
        '
        Me.btnDetalleUsuario.Image = Global.RegistroUsuarios.My.Resources.Resources.comentar
        Me.btnDetalleUsuario.Location = New System.Drawing.Point(18, 331)
        Me.btnDetalleUsuario.Name = "btnDetalleUsuario"
        Me.btnDetalleUsuario.Size = New System.Drawing.Size(40, 40)
        Me.btnDetalleUsuario.TabIndex = 14
        Me.btnDetalleUsuario.UseVisualStyleBackColor = True
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgvUsuarios)
        Me.pnl_filtros.Controls.Add(Me.chkTodos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txtNombre)
        Me.pnl_filtros.Controls.Add(Me.btnConsultar)
        Me.pnl_filtros.Controls.Add(Me.cboPerfiles)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(12, 12)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 313)
        Me.pnl_filtros.TabIndex = 13
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDColumn, Me.NombreColumn, Me.EmailColumn, Me.PerfilColumn})
        Me.dgvUsuarios.Location = New System.Drawing.Point(6, 115)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(401, 192)
        Me.dgvUsuarios.TabIndex = 18
        '
        'IDColumn
        '
        Me.IDColumn.DataPropertyName = "id_usuario"
        Me.IDColumn.HeaderText = "ID"
        Me.IDColumn.Name = "IDColumn"
        Me.IDColumn.ReadOnly = True
        Me.IDColumn.Visible = False
        '
        'NombreColumn
        '
        Me.NombreColumn.DataPropertyName = "nombre_usuario"
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.ReadOnly = True
        '
        'EmailColumn
        '
        Me.EmailColumn.DataPropertyName = "correo_electronico"
        Me.EmailColumn.HeaderText = "Email"
        Me.EmailColumn.Name = "EmailColumn"
        Me.EmailColumn.ReadOnly = True
        Me.EmailColumn.Width = 120
        '
        'PerfilColumn
        '
        Me.PerfilColumn.DataPropertyName = "nombre_perfil"
        Me.PerfilColumn.HeaderText = "Perfil"
        Me.PerfilColumn.Name = "PerfilColumn"
        Me.PerfilColumn.ReadOnly = True
        '
        'frmConsultaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 385)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDetalleUsuario)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "frmConsultaUsuarios"
        Me.Text = "Consulta Usuarios"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents cboPerfiles As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents btnDetalleUsuario As System.Windows.Forms.Button
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Private WithEvents IDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents EmailColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents PerfilColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
