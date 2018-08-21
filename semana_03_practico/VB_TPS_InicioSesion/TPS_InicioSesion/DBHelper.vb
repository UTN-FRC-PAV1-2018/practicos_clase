
Imports System.Data.SqlClient

Public Class DBHelper
    Private string_conexion As String = "Data Source=.\sqlexpress;Initial Catalog=DB_Bugs;Integrated Security=True"

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function
End Class
