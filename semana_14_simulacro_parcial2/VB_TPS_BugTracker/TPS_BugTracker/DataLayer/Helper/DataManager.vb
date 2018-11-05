Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DataManager
    Private dbConnection As SqlConnection
    Private dbTransaction As SqlTransaction
    Private string_conexion As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Simulacro2;User id=admin;Password=admin123;"

    Public Sub New()
        dbConnection = New SqlConnection()
        dbConnection.ConnectionString = string_conexion
    End Sub

    Public Sub BeginTransaction()
        If dbConnection.State = ConnectionState.Open Then dbTransaction = dbConnection.BeginTransaction()
    End Sub

    Public Sub Commit()
        If dbTransaction IsNot Nothing Then dbTransaction.Commit()
    End Sub

    Public Sub Rollback()
        If dbTransaction IsNot Nothing Then dbTransaction.Rollback()
    End Sub

    Public Sub Open()
        If dbConnection.State <> ConnectionState.Open Then dbConnection.Open()
    End Sub

    Public Sub Close()
        If dbConnection.State <> ConnectionState.Closed Then dbConnection.Close()
    End Sub

    Public Function ConsultaSQL(ByVal strSql As String) As DataTable
        Dim cmd As SqlCommand = New SqlCommand()
        Dim tabla As DataTable = New DataTable()

        Try
            cmd.Connection = dbConnection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            tabla.Load(cmd.ExecuteReader())
            Return tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ConsultaSQLConParametros(ByVal strSql As String, ByVal sqlParam As List(Of Object)) As DataTable
        Dim cmd As SqlCommand = New SqlCommand()
        Dim tabla As DataTable = New DataTable()

        Try
            cmd.Connection = dbConnection
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
        End Try
    End Function

    Public Function EjecutarSQL(ByVal strSql As String, Optional ByVal parametros As List(Of SqlParameter) = Nothing) As Integer
        Dim cmd As SqlCommand = New SqlCommand()
        Dim rtdo As Integer = 0

        Try
            cmd.Connection = dbConnection
            cmd.Transaction = dbTransaction
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            If parametros IsNot Nothing Then cmd.Parameters.AddRange(parametros.ToArray())
            rtdo = Convert.ToInt32(If(cmd.ExecuteScalar(), 0))
        Catch ex As Exception
            Throw ex
        End Try

        Return rtdo
    End Function
End Class
