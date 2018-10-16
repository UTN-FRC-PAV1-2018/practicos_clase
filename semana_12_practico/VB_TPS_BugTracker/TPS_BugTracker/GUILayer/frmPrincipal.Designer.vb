<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeBugsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Mnu_principal = New System.Windows.Forms.MenuStrip()
        Me.statusStrip1.SuspendLayout()
        Me.Mnu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem})
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SoporteToolStripMenuItem.Text = "&Soporte"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'BugsToolStripMenuItem
        '
        Me.BugsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeBugsToolStripMenuItem})
        Me.BugsToolStripMenuItem.Name = "BugsToolStripMenuItem"
        Me.BugsToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.BugsToolStripMenuItem.Text = "&Bugs"
        '
        'ConsultaDeBugsToolStripMenuItem
        '
        Me.ConsultaDeBugsToolStripMenuItem.Name = "ConsultaDeBugsToolStripMenuItem"
        Me.ConsultaDeBugsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ConsultaDeBugsToolStripMenuItem.Text = "&Consulta de bugs"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 321)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(430, 22)
        Me.statusStrip1.TabIndex = 6
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Mnu_principal
        '
        Me.Mnu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoporteToolStripMenuItem, Me.BugsToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.Mnu_principal.Location = New System.Drawing.Point(0, 0)
        Me.Mnu_principal.Name = "Mnu_principal"
        Me.Mnu_principal.Size = New System.Drawing.Size(430, 24)
        Me.Mnu_principal.TabIndex = 5
        Me.Mnu_principal.Text = "MenuStrip1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 343)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.Mnu_principal)
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.Mnu_principal.ResumeLayout(False)
        Me.Mnu_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BugsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeBugsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Mnu_principal As System.Windows.Forms.MenuStrip

End Class
