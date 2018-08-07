<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensaje
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
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMensaje
        '
        Me.btnMensaje.Location = New System.Drawing.Point(79, 79)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(133, 23)
        Me.btnMensaje.TabIndex = 0
        Me.btnMensaje.Text = "Mostrar mensaje"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(23, 56)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(50, 13)
        Me.lblMensaje.TabIndex = 1
        Me.lblMensaje.Text = "Mensaje:"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(79, 53)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(200, 20)
        Me.txtMensaje.TabIndex = 2
        '
        'frmMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 273)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnMensaje)
        Me.Name = "frmMensaje"
        Me.Text = "Formulario Mensaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMensaje As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox

End Class
