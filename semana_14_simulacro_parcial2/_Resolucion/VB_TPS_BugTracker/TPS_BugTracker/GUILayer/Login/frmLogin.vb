Partial Public Class frmLogin
    Inherits Form

    Private frmPrincipal As frmPrincipal

    Public Sub New(ByVal principal As frmPrincipal)
        InitializeComponent()
        frmPrincipal = principal
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Environment.[Exit](0)
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnIngresar.Click
        Dim oUsuarioService As UsuarioService = New UsuarioService()
        Dim oUsuario As Usuario = Nothing

        If txtPassword.Text = String.Empty Or txtUsuario.Text = String.Empty Then
            MessageBox.Show("Olvidó ingresar usuario y/o password", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            oUsuario = oUsuarioService.validarUsuario(txtUsuario.Text, txtPassword.Text)

            If oUsuario IsNot Nothing Then
                frmPrincipal.actualizarUsuarioLogueado(oUsuario)
                Me.Close()
            Else
                MessageBox.Show("Usuario y/o password incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtPassword.Text = String.Empty
                txtUsuario.Text = String.Empty
                txtUsuario.Focus()
            End If
        End If
    End Sub
End Class