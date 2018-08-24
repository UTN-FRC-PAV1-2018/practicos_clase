Public Class frmLogin

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text = "" Then
            MsgBox("Se debe ingresar un usuario.")
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MsgBox("Se debe ingresar una contraseña.")
            Exit Sub
        End If

        If (frmPrincipal.ValidarCredenciales(txtUsuario.Text, txtPassword.Text)) Then
            MsgBox("Usted a ingresado al sistema.")
            Me.Close()
        Else
            txtUsuario.Text = ""
            txtPassword.Text = ""

            MsgBox("Debe ingresar usuario y/o contraseña válidos")

        End If
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class