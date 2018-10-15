Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
    End Sub

    Public Function ValidarCredenciales(pUsuario As String, pPassword As String) As Boolean
        Dim helper As BDHelper = New BDHelper()
        Dim tabla As DataTable = helper.ConsultaSQL("SELECT * FROM USERS WHERE n_usuario =  '" & pUsuario & "' AND password = '" & pPassword & "'")

        'If pUsuario = usuario And pPassword = password Then
        If tabla.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
