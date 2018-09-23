Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Forms

Public Class frmConsultaUsuarios
    Inherits Form

    Private idUsuarioSeleccionado As String = String.Empty

    Public Sub New()
        InitializeComponent()
        btnDetalleUsuario.Enabled = False
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultar.Click
        Dim consulta As String = "SELECT id_usuario, nombre_usuario,correo_electronico," & "       (select n_perfil from Perfiles where id_perfil = u.id_perfil) nombre_perfil" & "  FROM Usuarios u WHERE 1=1"

        If Not chkTodos.Checked Then

            If Not String.IsNullOrEmpty(txtNombre.Text) Then
                consulta += " AND nombre_usuario LIKE '%" & txtNombre.Text & "%'"
            ElseIf Not String.IsNullOrEmpty(cboPerfiles.Text) Then
                consulta += " AND id_perfil = " & cboPerfiles.SelectedValue
            Else
                MessageBox.Show("Complete algún filtro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If
        End If

        Dim tabla As DataTable = BDHelper.getBDHelper().ConsultaSQL(consulta)

        If tabla.Rows.Count > 0 Then
            dgvUsuarios.DataSource = tabla
        Else
            MessageBox.Show("No se encontraron registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If

        idUsuarioSeleccionado = Nothing
        btnDetalleUsuario.Enabled = False
    End Sub

    Private Sub frmConsultaUsuarios_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable = BDHelper.getBDHelper().ConsultaSQL("SELECT n_perfil, id_perfil FROM Perfiles")
        GUIHelper.getGUIHelper().llenarCombo(cboPerfiles, tabla, "n_perfil", "id_perfil")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConsultaUsuarios_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
        If MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub btnDetalleUsuario_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDetalleUsuario.Click
        If idUsuarioSeleccionado <> String.Empty Then
            Dim detalleUsuario As frmDetalleUsuario = New frmDetalleUsuario(idUsuarioSeleccionado)
            detalleUsuario.ShowDialog()
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTodos.Click
        If chkTodos.Checked Then
            txtNombre.Enabled = False
            cboPerfiles.Enabled = False
            cboPerfiles.SelectedIndex = -1
        Else
            txtNombre.Enabled = True
            cboPerfiles.Enabled = True
        End If
    End Sub

    Private Sub dgvUsuarios_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            idUsuarioSeleccionado = dgvUsuarios.Rows(e.RowIndex).Cells(0).Value.ToString()
            btnDetalleUsuario.Enabled = True
        End If
    End Sub
End Class