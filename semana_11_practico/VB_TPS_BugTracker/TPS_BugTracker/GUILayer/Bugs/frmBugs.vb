Partial Public Class frmBugs
    Inherits Form

    Private oBugService As BugService = New BugService()
    Private criticidadService As CriticidadService = New CriticidadService()
    Private prioridadService As PrioridadService = New PrioridadService()
    Private productoService As ProductoService = New ProductoService()
    Private usuarioService As UsuarioService = New UsuarioService()
    Private estadoService As EstadoService = New EstadoService()
    Friend row_selected As DataGridViewRow

    Public Sub New()
        InitializeComponent()
        dgvBugs.AutoGenerateColumns = False
    End Sub

    Private Sub frmBugs_Load(ByVal sender As Object, ByVal e As EventArgs)
        GUIHelper.getHelper().llenarCombo(cboEstados, estadoService.consultarEstados(), "nombre", "id_estado")
        GUIHelper.getHelper().llenarCombo(cboPrioridades, prioridadService.consultarPrioridades(), "nombre", "id_prioridad")
        GUIHelper.getHelper().llenarCombo(cboCriticidades, criticidadService.consultarCriticidades(), "nombre", "id_criticidad")
        GUIHelper.getHelper().llenarCombo(cboAsignadoA, usuarioService.consultarUsuarios(), "nombre", "id_usuario")
        GUIHelper.getHelper().llenarCombo(cboProductos, productoService.consultarProductos(), "nombre", "id_producto")
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultar.Click
        Dim parametros As List(Of Object) = New List(Of Object)()
        Dim fechaDesde As DateTime
        Dim fechaHasta As DateTime

        If DateTime.TryParse(txtFechaDesde.Text, fechaDesde) AndAlso DateTime.TryParse(txtFechaHasta.Text, fechaHasta) Then
            parametros.Add(txtFechaDesde.Text)
            parametros.Add(txtFechaHasta.Text)
        Else
            parametros.Add(Nothing)
            parametros.Add(Nothing)
        End If

        If Not String.IsNullOrEmpty(cboPrioridades.Text) Then
            Dim prioridad = cboPrioridades.SelectedValue.ToString()
            parametros.Add(prioridad)
        Else
            parametros.Add(Nothing)
        End If

        If Not String.IsNullOrEmpty(cboCriticidades.Text) Then
            Dim criticidad = cboCriticidades.SelectedValue.ToString()
            parametros.Add(criticidad)
        Else
            parametros.Add(Nothing)
        End If

        If Not String.IsNullOrEmpty(cboProductos.Text) Then
            Dim producto = cboProductos.SelectedValue.ToString()
            parametros.Add(producto)
        Else
            parametros.Add(Nothing)
        End If

        If Not String.IsNullOrEmpty(cboEstados.Text) Then
            Dim idEstado = cboEstados.SelectedValue.ToString()
            parametros.Add(idEstado)
        Else
            parametros.Add(Nothing)
        End If

        If Not String.IsNullOrEmpty(cboAsignadoA.Text) Then
            Dim asignadoA = cboAsignadoA.SelectedValue.ToString()
            parametros.Add(asignadoA)
        Else
            parametros.Add(Nothing)
        End If

        dgvBugs.DataSource = oBugService.consultarBugsConFiltros(parametros)

        If dgvBugs.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btn_asignar.Enabled = False
            btn_editar.Enabled = False
            btn_detalle_bug.Enabled = False
            btn_pasar_a_te.Enabled = False
            btn_cerrar.Enabled = False
        End If
    End Sub

    Private Sub btn_detalle_bug_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_detalle_bug.Click
        Dim id As Integer

        If row_selected.Index <> -1 Then
            id = Convert.ToInt32(row_selected.Cells("id_bug_col").Value)
            Dim frmDetalle As frmDetalleBug = New frmDetalleBug()
            frmDetalle.mostrarBug(oBugService.consultarBugsPorId(id))
            frmDetalle.ShowDialog()
        End If
    End Sub

    Private Sub dgvBugs_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvBugs.CellClick
        row_selected = dgvBugs.CurrentRow
        btn_asignar.Enabled = True
        btn_editar.Enabled = True
        btn_detalle_bug.Enabled = True
        btn_cerrar.Enabled = True
    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btn_salir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_editar.Click
        Dim id As Integer

        If row_selected.Index <> -1 Then
            id = Convert.ToInt32(row_selected.Cells("id_bug_col").Value)
            Dim frmActualizar As frmActualizarBug = New frmActualizarBug()
            frmActualizar.mostrarBug(oBugService.consultarBugsPorId(id))
            frmActualizar.ShowDialog()
            btnConsultar_Click(sender, e)
        End If
    End Sub


    Private Sub btn_asignar_Click(sender As Object, e As EventArgs) Handles btn_asignar.Click
        Dim id As Integer

        If row_selected.Index <> -1 Then
            id = Convert.ToInt32(row_selected.Cells("id_bug_col").Value)
            Dim frmAsignar As frmAsignarBug = New frmAsignarBug()
            frmAsignar.mostrarBug(oBugService.consultarBugsPorId(id))
            frmAsignar.ShowDialog()
        End If
    End Sub
End Class