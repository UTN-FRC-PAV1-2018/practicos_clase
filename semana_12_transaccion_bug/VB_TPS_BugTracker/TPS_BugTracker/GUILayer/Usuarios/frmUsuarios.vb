Partial Public Class frmUsuarios
    Inherits Form

    Private oUsuarioService As UsuarioService

    Public Sub New()
        InitializeComponent()
        oUsuarioService = New UsuarioService()
    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As Object, ByVal e As EventArgs)
        GUIHelper.getHelper().llenarCombo(cbo_perfiles, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil")
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_nuevo.Click
        Dim formulario As frmABMUsuario = New frmABMUsuario()
        formulario.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub chk_todos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chk_todos.Click
        If True Then

            If chk_todos.Checked Then
                txt_nombre.Enabled = False
                cbo_perfiles.Enabled = False
            Else
                txt_nombre.Enabled = True
                cbo_perfiles.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Seguro que desea salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then Me.Close()
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        Dim filters As List(Of Object) = New List(Of Object)()
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then

            If cbo_perfiles.Text <> String.Empty Then
                filters.Add(cbo_perfiles.SelectedValue)
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If txt_nombre.Text <> String.Empty Then
                filters.Add(txt_nombre.Text)
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If flag_filtros Then
                llenarGrilla(oUsuarioService.consultarUsuariosConFiltros(filters))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenarGrilla(oUsuarioService.consultarUsuarios())
        End If
    End Sub

    Private Sub llenarGrilla(ByVal source As IList(Of Usuario))
        dgv_users.Rows.Clear()

        For Each oUsuario As Usuario In source
            dgv_users.Rows.Add(New String() {oUsuario.nombre, oUsuario.id_perfil, oUsuario.email, oUsuario.perfil, oUsuario.id_usuario.ToString(), oUsuario.password})
        Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        Dim formulario As frmABMUsuario = New frmABMUsuario()
        formulario.seleccionar_usuario(frmABMUsuario.Opcion.update, map_usuario_fila())
        formulario.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub dgv_users_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_users.CellClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Dim formulario As frmABMUsuario = New frmABMUsuario()
        formulario.seleccionar_usuario(frmABMUsuario.Opcion.delete, map_usuario_fila())
        formulario.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Function map_usuario_fila() As Usuario
        Dim oUsuario As Usuario = New Usuario()
        oUsuario.nombre = dgv_users.CurrentRow.Cells("col_nombre").Value.ToString()
        oUsuario.perfil = dgv_users.CurrentRow.Cells("col_perfil").Value.ToString()
        oUsuario.password = dgv_users.CurrentRow.Cells("col_pass").Value.ToString()
        oUsuario.email = dgv_users.CurrentRow.Cells("col_email").Value.ToString()
        oUsuario.id_usuario = Integer.Parse(dgv_users.CurrentRow.Cells("col_id").Value.ToString())
        oUsuario.id_perfil = dgv_users.CurrentRow.Cells("id_perfil_col").Value.ToString()
        Return oUsuario
    End Function
End Class