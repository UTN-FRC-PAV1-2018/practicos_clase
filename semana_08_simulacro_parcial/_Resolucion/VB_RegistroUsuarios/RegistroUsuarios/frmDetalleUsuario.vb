Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class frmDetalleUsuario
    Inherits Form

    Private idUsuario As String = String.Empty

    Public Sub New(ByVal id As String)
        InitializeComponent()
        idUsuario = id
    End Sub

    Private Sub frmDetalleUsuario_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable = BDHelper.getBDHelper().ConsultaSQL("SELECT id_perfil, n_perfil FROM Perfiles")
        GUIHelper.getGUIHelper().llenarCombo(cboPerfil, tabla, "n_perfil", "id_perfil")
        Dim consulta As String = "SELECT * FROM Usuarios WHERE id_usuario = " & idUsuario
        Dim usuario As DataTable = BDHelper.getBDHelper().ConsultaSQL(consulta)
        txtNombre.Text = usuario.Rows(0).ItemArray(1).ToString()
        txtCorreoElectronico.Text = usuario.Rows(0).ItemArray(3).ToString()
        txtPassword.Text = usuario.Rows(0).ItemArray(2).ToString()
        txtConfirmarPassword.Text = usuario.Rows(0).ItemArray(2).ToString()
        cboPerfil.SelectedValue = usuario.Rows(0).ItemArray(4).ToString()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class

