Imports System.Data.SqlClient

Public Class BDHelper
    Private string_conexion As String = "Data Source=.\SQLEXPRESS;Initial Catalog=DB_Bugs;User id=admin;Password=admin123;"
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

    Public Function ConsultaSQLConParametros(ByVal strSql As String, ByVal sqlParam As List(Of Object)) As DataTable
        Dim conexion As SqlConnection = New SqlConnection()
        Dim cmd As SqlCommand = New SqlCommand()
        Dim tabla As DataTable = New DataTable()

        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            Dim indice = 0

            For Each param In sqlParam

                If param IsNot Nothing Then
                    Dim n_param = "param" & Convert.ToString(indice + 1)
                    cmd.Parameters.AddWithValue(n_param, param)
                End If

                indice += 1
            Next

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