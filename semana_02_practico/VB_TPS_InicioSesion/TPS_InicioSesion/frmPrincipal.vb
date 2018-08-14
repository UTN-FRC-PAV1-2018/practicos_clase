Public Class frmPrincipal
    'Credenciales Hardcodeadas!!
    Public usuario As String = "test"
    Public password As String = "test"

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
    End Sub

    Public Function ValidarCredenciales(pUsuario As String, pPassword As String) As Boolean
        If pUsuario = usuario And pPassword = password Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
