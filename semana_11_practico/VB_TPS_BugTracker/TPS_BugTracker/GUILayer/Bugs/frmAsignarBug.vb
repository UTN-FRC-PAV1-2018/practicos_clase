Partial Public Class frmAsignarBug
    Inherits Form

    Private usuarioService As UsuarioService = New UsuarioService()
    Private oBugSelected As Bug
    Private oBugService As BugService

    Public Sub New()
        InitializeComponent()
        oBugService = New BugService()
        GUIHelper.getHelper().llenarCombo(cbo_desa, usuarioService.consultarDesarrolladores(), "nombre", "id_usuario")
    End Sub

    Friend Sub mostrarBug(ByVal bugSelected As Bug)
        oBugSelected = bugSelected
        txtIdBug.Text = oBugSelected.id_bug.ToString()
        txtTitulo.Text = oBugSelected.titulo
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_aceptar.Click
        If oBugSelected IsNot Nothing Then
            Dim historial As HistorialBug = New HistorialBug()
            historial.asignado_a = CInt(cbo_desa.SelectedValue)
            historial.fecha = DateTime.Now
            historial.estado = 2
            historial.responsable = oBugSelected.historial.Last().responsable
            oBugSelected.addHistorial(historial)
            oBugService.actualizarBug(oBugSelected)
        End If

        Me.Close()
    End Sub
End Class