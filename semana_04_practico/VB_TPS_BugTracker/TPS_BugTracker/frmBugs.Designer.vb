<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBugs
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
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.cbo_productos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fec_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fec_desde = New System.Windows.Forms.MaskedTextBox()
        Me.cbo_criticidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_prioridades = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_asignadoA = New System.Windows.Forms.ComboBox()
        Me.lbl_asignado = New System.Windows.Forms.Label()
        Me.cbo_estados = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.dgv_bugs = New System.Windows.Forms.DataGridView()
        Me.btn_comentar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros.SuspendLayout
        CType(Me.dgv_bugs,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.cbo_productos)
        Me.pnl_filtros.Controls.Add(Me.Label5)
        Me.pnl_filtros.Controls.Add(Me.txt_fec_hasta)
        Me.pnl_filtros.Controls.Add(Me.Label4)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_fec_desde)
        Me.pnl_filtros.Controls.Add(Me.cbo_criticidades)
        Me.pnl_filtros.Controls.Add(Me.Label1)
        Me.pnl_filtros.Controls.Add(Me.cbo_prioridades)
        Me.pnl_filtros.Controls.Add(Me.Label2)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.cbo_asignadoA)
        Me.pnl_filtros.Controls.Add(Me.lbl_asignado)
        Me.pnl_filtros.Controls.Add(Me.cbo_estados)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(2, 3)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(561, 365)
        Me.pnl_filtros.TabIndex = 0
        Me.pnl_filtros.TabStop = false
        Me.pnl_filtros.Text = "Filtros"
        '
        'cbo_productos
        '
        Me.cbo_productos.FormattingEnabled = true
        Me.cbo_productos.Location = New System.Drawing.Point(76, 156)
        Me.cbo_productos.Name = "cbo_productos"
        Me.cbo_productos.Size = New System.Drawing.Size(181, 21)
        Me.cbo_productos.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Producto:"
        '
        'txt_fec_hasta
        '
        Me.txt_fec_hasta.Location = New System.Drawing.Point(374, 22)
        Me.txt_fec_hasta.Mask = "00/00/0000"
        Me.txt_fec_hasta.Name = "txt_fec_hasta"
        Me.txt_fec_hasta.Size = New System.Drawing.Size(180, 20)
        Me.txt_fec_hasta.TabIndex = 13
        Me.txt_fec_hasta.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fecha Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha desde:"
        '
        'txt_fec_desde
        '
        Me.txt_fec_desde.Location = New System.Drawing.Point(76, 22)
        Me.txt_fec_desde.Mask = "00/00/0000"
        Me.txt_fec_desde.Name = "txt_fec_desde"
        Me.txt_fec_desde.Size = New System.Drawing.Size(181, 20)
        Me.txt_fec_desde.TabIndex = 9
        Me.txt_fec_desde.ValidatingType = GetType(Date)
        '
        'cbo_criticidades
        '
        Me.cbo_criticidades.FormattingEnabled = True
        Me.cbo_criticidades.Location = New System.Drawing.Point(76, 129)
        Me.cbo_criticidades.Name = "cbo_criticidades"
        Me.cbo_criticidades.Size = New System.Drawing.Size(181, 21)
        Me.cbo_criticidades.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Criticidad:"
        '
        'cbo_prioridades
        '
        Me.cbo_prioridades.FormattingEnabled = True
        Me.cbo_prioridades.Location = New System.Drawing.Point(76, 102)
        Me.cbo_prioridades.Name = "cbo_prioridades"
        Me.cbo_prioridades.Size = New System.Drawing.Size(181, 21)
        Me.cbo_prioridades.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prioridad:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(467, 156)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_asignadoA
        '
        Me.cbo_asignadoA.FormattingEnabled = True
        Me.cbo_asignadoA.Location = New System.Drawing.Point(76, 75)
        Me.cbo_asignadoA.Name = "cbo_asignadoA"
        Me.cbo_asignadoA.Size = New System.Drawing.Size(181, 21)
        Me.cbo_asignadoA.TabIndex = 3
        '
        'lbl_asignado
        '
        Me.lbl_asignado.AutoSize = True
        Me.lbl_asignado.Location = New System.Drawing.Point(7, 78)
        Me.lbl_asignado.Name = "lbl_asignado"
        Me.lbl_asignado.Size = New System.Drawing.Size(63, 13)
        Me.lbl_asignado.TabIndex = 2
        Me.lbl_asignado.Text = "Asignado a:"
        '
        'cbo_estados
        '
        Me.cbo_estados.FormattingEnabled = True
        Me.cbo_estados.Location = New System.Drawing.Point(76, 48)
        Me.cbo_estados.Name = "cbo_estados"
        Me.cbo_estados.Size = New System.Drawing.Size(181, 21)
        Me.cbo_estados.TabIndex = 1
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = true
        Me.lbl_estado.Location = New System.Drawing.Point(32, 51)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(43, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Estado:"
        '
        'dgv_bugs
        '
        Me.dgv_bugs.AllowUserToAddRows = false
        Me.dgv_bugs.AllowUserToDeleteRows = false
        Me.dgv_bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bugs.Location = New System.Drawing.Point(12, 198)
        Me.dgv_bugs.Name = "dgv_bugs"
        Me.dgv_bugs.ReadOnly = true
        Me.dgv_bugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_bugs.Size = New System.Drawing.Size(545, 269)
        Me.dgv_bugs.TabIndex = 5
        '
        'btn_comentar
        '
        Me.btn_comentar.Location = New System.Drawing.Point(0, 0)
        Me.btn_comentar.Name = "btn_comentar"
        Me.btn_comentar.Size = New System.Drawing.Size(75, 23)
        Me.btn_comentar.TabIndex = 6
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(0, 0)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 7
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(0, 0)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_editar.TabIndex = 8
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(0, 0)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 9
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(0, 0)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_nuevo.TabIndex = 10
        '
        'frmBugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(568, 492)
        Me.Controls.Add(Me.dgv_bugs)
        Me.Controls.Add(Me.btn_comentar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmBugs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta General de Bugs"
        Me.pnl_filtros.ResumeLayout(false)
        Me.pnl_filtros.PerformLayout
        CType(Me.dgv_bugs,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_asignadoA As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_asignado As System.Windows.Forms.Label
    Friend WithEvents cbo_estados As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents dgv_bugs As System.Windows.Forms.DataGridView
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_comentar As System.Windows.Forms.Button
    Friend WithEvents txt_fec_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fec_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbo_criticidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_prioridades As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_productos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
