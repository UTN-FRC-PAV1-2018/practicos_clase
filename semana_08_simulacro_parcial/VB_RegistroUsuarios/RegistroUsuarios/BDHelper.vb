
Imports System.Data.SqlClient

Public Class BDHelper
    Private string_conexion As String = "Data Source=maquis;Initial Catalog=DB_Usuarios;User id=avisuales;Password=avisuales;"

    Private Shared instance As BDHelper 'Unica instancia de la clase

    Public Shared Function getBDHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

End Class
