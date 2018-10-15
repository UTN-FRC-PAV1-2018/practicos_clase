<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleBug
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.estado_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCriticidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFechaAlta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrioridad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.responsable_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_historiales = New System.Windows.Forms.DataGridView()
        Me.asignado_a_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNroBug = New System.Windows.Forms.TextBox()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        CType(Me.dgv_historiales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(451, 420)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 21
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'estado_col
        '
        Me.estado_col.HeaderText = "Estado"
        Me.estado_col.Name = "estado_col"
        Me.estado_col.ReadOnly = True
        '
        'txtCriticidad
        '
        Me.txtCriticidad.Enabled = False
        Me.txtCriticidad.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriticidad.Location = New System.Drawing.Point(146, 284)
        Me.txtCriticidad.Name = "txtCriticidad"
        Me.txtCriticidad.Size = New System.Drawing.Size(262, 22)
        Me.txtCriticidad.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(93, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Criticidad:"
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Enabled = False
        Me.txtFechaAlta.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaAlta.Location = New System.Drawing.Point(146, 102)
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.Size = New System.Drawing.Size(123, 22)
        Me.txtFechaAlta.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Fecha creación:"
        '
        'txtPrioridad
        '
        Me.txtPrioridad.Enabled = False
        Me.txtPrioridad.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrioridad.Location = New System.Drawing.Point(146, 258)
        Me.txtPrioridad.Name = "txtPrioridad"
        Me.txtPrioridad.Size = New System.Drawing.Size(262, 22)
        Me.txtPrioridad.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(98, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Prioridad:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(146, 233)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(262, 22)
        Me.txtEstado.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Estado:"
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(146, 77)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(262, 22)
        Me.txtProducto.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Producto:"
        '
        'responsable_col
        '
        Me.responsable_col.HeaderText = "Responsable"
        Me.responsable_col.Name = "responsable_col"
        Me.responsable_col.ReadOnly = True
        '
        'fec_col
        '
        Me.fec_col.HeaderText = "Fecha"
        Me.fec_col.Name = "fec_col"
        Me.fec_col.ReadOnly = True
        '
        'dgv_historiales
        '
        Me.dgv_historiales.AllowUserToAddRows = False
        Me.dgv_historiales.AllowUserToDeleteRows = False
        Me.dgv_historiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historiales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fec_col, Me.responsable_col, Me.estado_col, Me.asignado_a_col})
        Me.dgv_historiales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_historiales.Location = New System.Drawing.Point(3, 3)
        Me.dgv_historiales.Name = "dgv_historiales"
        Me.dgv_historiales.ReadOnly = True
        Me.dgv_historiales.Size = New System.Drawing.Size(498, 351)
        Me.dgv_historiales.TabIndex = 23
        '
        'asignado_a_col
        '
        Me.asignado_a_col.HeaderText = "Asignado a"
        Me.asignado_a_col.Name = "asignado_a_col"
        Me.asignado_a_col.ReadOnly = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.dgv_historiales)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(504, 357)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Historial"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(146, 130)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(262, 97)
        Me.txtDescripcion.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Descripción:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(146, 51)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(262, 22)
        Me.txtTitulo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Título:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "# Bug:"
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.txtCriticidad)
        Me.tabPage1.Controls.Add(Me.Label10)
        Me.tabPage1.Controls.Add(Me.txtFechaAlta)
        Me.tabPage1.Controls.Add(Me.Label9)
        Me.tabPage1.Controls.Add(Me.txtPrioridad)
        Me.tabPage1.Controls.Add(Me.Label7)
        Me.tabPage1.Controls.Add(Me.txtEstado)
        Me.tabPage1.Controls.Add(Me.Label5)
        Me.tabPage1.Controls.Add(Me.txtProducto)
        Me.tabPage1.Controls.Add(Me.Label4)
        Me.tabPage1.Controls.Add(Me.txtDescripcion)
        Me.tabPage1.Controls.Add(Me.Label3)
        Me.tabPage1.Controls.Add(Me.txtTitulo)
        Me.tabPage1.Controls.Add(Me.Label2)
        Me.tabPage1.Controls.Add(Me.txtNroBug)
        Me.tabPage1.Controls.Add(Me.Label1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(504, 357)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Detalle"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'txtNroBug
        '
        Me.txtNroBug.Enabled = False
        Me.txtNroBug.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroBug.Location = New System.Drawing.Point(146, 23)
        Me.txtNroBug.Name = "txtNroBug"
        Me.txtNroBug.Size = New System.Drawing.Size(68, 22)
        Me.txtNroBug.TabIndex = 22
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(18, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(512, 383)
        Me.tabControl1.TabIndex = 20
        '
        'frmDetalleBug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 454)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "frmDetalleBug"
        Me.Text = "Detalle de bug"
        CType(Me.dgv_historiales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents estado_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCriticidad As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFechaAlta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrioridad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents responsable_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_historiales As System.Windows.Forms.DataGridView
    Friend WithEvents asignado_a_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtNroBug As System.Windows.Forms.TextBox
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
End Class
