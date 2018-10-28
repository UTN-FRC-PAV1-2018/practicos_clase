<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportBugs
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BugBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaHasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaDesde = New System.Windows.Forms.MaskedTextBox()
        Me.cboCriticidades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPrioridades = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cboAsignadoA = New System.Windows.Forms.ComboBox()
        Me.lbl_asignado = New System.Windows.Forms.Label()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.reporteBugs = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.BugBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'BugBindingSource
        '
        Me.BugBindingSource.DataMember = "Bug"
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
        Me.pnl_filtros.Location = New System.Drawing.Point(12, 12)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(762, 136)
        Me.pnl_filtros.TabIndex = 3
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
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
        'cboPrioridades
        '
        Me.cboPrioridades.FormattingEnabled = True
        Me.cboPrioridades.Location = New System.Drawing.Point(76, 102)
        Me.cboPrioridades.Name = "cboPrioridades"
        Me.cboPrioridades.Size = New System.Drawing.Size(181, 21)
        Me.cboPrioridades.TabIndex = 6
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
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Location = New System.Drawing.Point(668, 103)
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
        'reporteBugs
        '
        Me.reporteBugs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.BugBindingSource
        Me.reporteBugs.LocalReport.DataSources.Add(ReportDataSource2)
        Me.reporteBugs.LocalReport.ReportEmbeddedResource = "TPS_InicioSesion.ReportBugs.rdlc"
        Me.reporteBugs.Location = New System.Drawing.Point(12, 154)
        Me.reporteBugs.Name = "reporteBugs"
        Me.reporteBugs.Size = New System.Drawing.Size(762, 299)
        Me.reporteBugs.TabIndex = 4
        '
        'frmReportBugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 465)
        Me.Controls.Add(Me.reporteBugs)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "frmReportBugs"
        Me.Text = "Reporte de Bugs"
        Me.TopMost = True
        CType(Me.BugBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents cboProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaHasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDesde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboCriticidades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPrioridades As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents cboAsignadoA As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_asignado As System.Windows.Forms.Label
    Friend WithEvents cboEstados As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents reporteBugs As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BugBindingSource As System.Windows.Forms.BindingSource
End Class
