<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMUsuario
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.cbo_perfil = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_confirmar_pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(213, 174)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 23)
        Me.btn_cancelar.TabIndex = 34
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(129, 174)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(78, 23)
        Me.btn_aceptar.TabIndex = 33
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'cbo_perfil
        '
        Me.cbo_perfil.FormattingEnabled = True
        Me.cbo_perfil.Location = New System.Drawing.Point(155, 117)
        Me.cbo_perfil.Name = "cbo_perfil"
        Me.cbo_perfil.Size = New System.Drawing.Size(192, 21)
        Me.cbo_perfil.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Perfil(*):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Repetir Contraseña(*):"
        '
        'txt_confirmar_pass
        '
        Me.txt_confirmar_pass.Location = New System.Drawing.Point(155, 90)
        Me.txt_confirmar_pass.Name = "txt_confirmar_pass"
        Me.txt_confirmar_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_pass.Size = New System.Drawing.Size(138, 20)
        Me.txt_confirmar_pass.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Contraseña(*):"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(155, 64)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(138, 20)
        Me.txt_password.TabIndex = 30
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(155, 38)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(192, 20)
        Me.txt_email.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nombre(*):"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(155, 12)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 27
        '
        'frmABMUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 209)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cbo_perfil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_confirmar_pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMUsuario"
        Me.Text = "Nuevo Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents cbo_perfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_confirmar_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
End Class
