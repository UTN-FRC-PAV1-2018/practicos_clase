Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Public Class BDHelper
    Private string_conexion As String = "Data Source=.\SQLEXPRESS;Initial Catalog=DB_USUARIOS;User id=avisuales1;Password=avisuales1;"
    Private Shared instance As BDHelper

    Public Shared Function getBDHelper() As BDHelper
        If instance Is Nothing Then instance = New BDHelper()
        Return instance
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As DataTable
        Dim conexion As SqlConnection = New SqlConnection()
        Dim cmd As SqlCommand = New SqlCommand()
        Dim tabla As DataTable = New DataTable()

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally

            If (conexion.State = ConnectionState.Open) Then
                conexion.Close()
            End If

            conexion.Dispose()
        End Try
    End Function
End Class
