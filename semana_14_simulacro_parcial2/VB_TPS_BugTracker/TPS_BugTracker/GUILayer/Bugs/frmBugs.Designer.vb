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
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.cboCriticidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPrioridades = New System.Windows.Forms.ComboBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cboAsignadoA = New System.Windows.Forms.ComboBox()
        Me.lbl_asignado = New System.Windows.Forms.Label()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.btn_pasar_a_te = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_detalle_bug = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.dgvBugs = New System.Windows.Forms.DataGridView()
        Me.id_bug_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrioridadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CriticidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgvBugs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProductos
        '
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Location = New System.Drawing.Point(374, 75)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(181, 21)
        Me.cboProductos.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Producto:"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(374, 22)
        Me.txtFechaHasta.Mask = "00/00/0000"
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(180, 20)
        Me.txtFechaHasta.TabIndex = 13
        Me.txtFechaHasta.ValidatingType = GetType(Date)
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
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(76, 22)
        Me.txtFechaDesde.Mask = "00/00/0000"
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(181, 20)
        Me.txtFechaDesde.TabIndex = 9
        Me.txtFechaDesde.ValidatingType = GetType(Date)
        '
        'cboCriticidades
        '
        Me.cboCriticidades.FormattingEnabled = True
        Me.cboCriticidades.Location = New System.Drawing.Point(374, 48)
        Me.cboCriticidades.Name = "cboCriticidades"
        Me.cboCriticidades.Size = New System.Drawing.Size(181, 21)
        Me.cboCriticidades.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Criticidad:"
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
        'cboPrioridades
        '
        Me.cboPrioridades.FormattingEnabled = True
        Me.cboPrioridades.Location = New System.Drawing.Point(76, 102)
        Me.cboPrioridades.Name = "cboPrioridades"
        Me.cboPrioridades.Size = New System.Drawing.Size(181, 21)
        Me.cboPrioridades.TabIndex = 6
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Location = New System.Drawing.Point(738, 103)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(87, 23)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cboAsignadoA
        '
        Me.cboAsignadoA.FormattingEnabled = True
        Me.cboAsignadoA.Location = New System.Drawing.Point(76, 75)
        Me.cboAsignadoA.Name = "cboAsignadoA"
        Me.cboAsignadoA.Size = New System.Drawing.Size(181, 21)
        Me.cboAsignadoA.TabIndex = 3
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
        'cboEstados
        '
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Location = New System.Drawing.Point(76, 48)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(181, 21)
        Me.cboEstados.TabIndex = 1
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(32, 51)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(43, 13)
        Me.lbl_estado.TabIndex = 0
        Me.lbl_estado.Text = "Estado:"
        '
        'pnl_filtros
        '
        Me.pnl_filtros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.cboProductos)
        Me.pnl_filtros.Controls.Add(Me.Label5)
        Me.pnl_filtros.Controls.Add(Me.txtFechaHasta)
        Me.pnl_filtros.Controls.Add(Me.Label4)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txtFechaDesde)
        Me.pnl_filtros.Controls.Add(Me.cboCriticidades)
        Me.pnl_filtros.Controls.Add(Me.Label1)
        Me.pnl_filtros.Controls.Add(Me.cboPrioridades)
        Me.pnl_filtros.Controls.Add(Me.Label2)
        Me.pnl_filtros.Controls.Add(Me.btnConsultar)
        Me.pnl_filtros.Controls.Add(Me.cboAsignadoA)
        Me.pnl_filtros.Controls.Add(Me.lbl_asignado)
        Me.pnl_filtros.Controls.Add(Me.cboEstados)
        Me.pnl_filtros.Controls.Add(Me.lbl_estado)
        Me.pnl_filtros.Location = New System.Drawing.Point(13, 16)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(832, 136)
        Me.pnl_filtros.TabIndex = 20
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Image = Global.TPS_InicioSesion.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(806, 449)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 25
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.TPS_InicioSesion.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(98, 449)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 24
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_asignar
        '
        Me.btn_asignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_asignar.Enabled = False
        Me.btn_asignar.Image = Global.TPS_InicioSesion.My.Resources.Resources.user_log
        Me.btn_asignar.Location = New System.Drawing.Point(55, 449)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(40, 40)
        Me.btn_asignar.TabIndex = 23
        Me.btn_asignar.UseVisualStyleBackColor = True
        '
        'btn_pasar_a_te
        '
        Me.btn_pasar_a_te.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_pasar_a_te.Enabled = False
        Me.btn_pasar_a_te.Image = Global.TPS_InicioSesion.My.Resources.Resources.cerrarBug
        Me.btn_pasar_a_te.Location = New System.Drawing.Point(144, 449)
        Me.btn_pasar_a_te.Name = "btn_pasar_a_te"
        Me.btn_pasar_a_te.Size = New System.Drawing.Size(40, 40)
        Me.btn_pasar_a_te.TabIndex = 27
        Me.btn_pasar_a_te.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo.Enabled = False
        Me.btn_nuevo.Image = Global.TPS_InicioSesion.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(13, 449)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 22
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_detalle_bug
        '
        Me.btn_detalle_bug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_detalle_bug.Enabled = False
        Me.btn_detalle_bug.Image = Global.TPS_InicioSesion.My.Resources.Resources.comentar
        Me.btn_detalle_bug.Location = New System.Drawing.Point(290, 449)
        Me.btn_detalle_bug.Name = "btn_detalle_bug"
        Me.btn_detalle_bug.Size = New System.Drawing.Size(38, 40)
        Me.btn_detalle_bug.TabIndex = 26
        Me.btn_detalle_bug.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Enabled = False
        Me.btn_cerrar.Image = Global.TPS_InicioSesion.My.Resources.Resources.Empty_Recycle_Bin_2000
        Me.btn_cerrar.Location = New System.Drawing.Point(190, 449)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cerrar.TabIndex = 28
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'dgvBugs
        '
        Me.dgvBugs.AllowUserToAddRows = False
        Me.dgvBugs.AllowUserToDeleteRows = False
        Me.dgvBugs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBugs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_bug_col, Me.colTitulo, Me.DescripcionColumn, Me.ProductoColumn, Me.PrioridadColumn, Me.CriticidadColumn, Me.EstadoColumn, Me.FechaAltaColumn})
        Me.dgvBugs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBugs.Location = New System.Drawing.Point(14, 158)
        Me.dgvBugs.MultiSelect = False
        Me.dgvBugs.Name = "dgvBugs"
        Me.dgvBugs.ReadOnly = True
        Me.dgvBugs.RowHeadersVisible = False
        Me.dgvBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBugs.Size = New System.Drawing.Size(832, 275)
        Me.dgvBugs.TabIndex = 29
        '
        'id_bug_col
        '
        Me.id_bug_col.DataPropertyName = "id_bug"
        Me.id_bug_col.HeaderText = "ID"
        Me.id_bug_col.Name = "id_bug_col"
        Me.id_bug_col.ReadOnly = True
        Me.id_bug_col.Visible = False
        '
        'colTitulo
        '
        Me.colTitulo.DataPropertyName = "titulo"
        Me.colTitulo.HeaderText = "Título"
        Me.colTitulo.Name = "colTitulo"
        Me.colTitulo.ReadOnly = True
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "descripcion"
        Me.DescripcionColumn.HeaderText = "Descripción"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        '
        'ProductoColumn
        '
        Me.ProductoColumn.DataPropertyName = "n_producto"
        Me.ProductoColumn.HeaderText = "Producto"
        Me.ProductoColumn.Name = "ProductoColumn"
        Me.ProductoColumn.ReadOnly = True
        '
        'PrioridadColumn
        '
        Me.PrioridadColumn.DataPropertyName = "n_prioridad"
        Me.PrioridadColumn.HeaderText = "Prioridad"
        Me.PrioridadColumn.Name = "PrioridadColumn"
        Me.PrioridadColumn.ReadOnly = True
        '
        'CriticidadColumn
        '
        Me.CriticidadColumn.DataPropertyName = "n_criticidad"
        Me.CriticidadColumn.HeaderText = "Criticidad"
        Me.CriticidadColumn.Name = "CriticidadColumn"
        Me.CriticidadColumn.ReadOnly = True
        '
        'EstadoColumn
        '
        Me.EstadoColumn.DataPropertyName = "n_estado"
        Me.EstadoColumn.HeaderText = "Estado"
        Me.EstadoColumn.Name = "EstadoColumn"
        Me.EstadoColumn.ReadOnly = True
        '
        'FechaAltaColumn
        '
        Me.FechaAltaColumn.DataPropertyName = "fecha_alta"
        Me.FechaAltaColumn.HeaderText = "Fecha Alta"
        Me.FechaAltaColumn.Name = "FechaAltaColumn"
        Me.FechaAltaColumn.ReadOnly = True
        '
        'frmBugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 504)
        Me.Controls.Add(Me.dgvBugs)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_asignar)
        Me.Controls.Add(Me.btn_pasar_a_te)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_detalle_bug)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "frmBugs"
        Me.Text = "Listado de Bugs"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgvBugs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents cboProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents cboCriticidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_pasar_a_te As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents cboPrioridades As System.Windows.Forms.ComboBox
    Friend WithEvents btn_detalle_bug As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents cboAsignadoA As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_asignado As System.Windows.Forms.Label
    Friend WithEvents cboEstados As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBugs As System.Windows.Forms.DataGridView
    Friend WithEvents id_bug_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrioridadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CriticidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
