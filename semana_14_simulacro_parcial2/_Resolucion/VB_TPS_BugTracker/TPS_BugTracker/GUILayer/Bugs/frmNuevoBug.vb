Partial Public Class frmNuevoBug
    Inherits Form

    Private prioridadService As PrioridadService = New PrioridadService()
    Private productoService As ProductoService = New ProductoService()
    Private criticidadService As CriticidadService = New CriticidadService()

    Private bugService As BugService = New BugService()

    Public Sub New()
        InitializeComponent()
        GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad")
        GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad")
        GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto")
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_aceptar.Click
        Try

            If validarCampos() Then
                Dim nuevoBug As Bug = New Bug()
                nuevoBug.titulo = txtTitulo.Text
                nuevoBug.descripcion = txtDescripcion.Text
                nuevoBug.id_estado = 1
                nuevoBug.id_prioridad = CInt(cboPrioridad.SelectedValue)
                nuevoBug.id_criticidad = CInt(cboCriticidad.SelectedValue)
                nuevoBug.id_producto = CInt(cboProducto.SelectedValue)
                Dim historial As HistorialBug = New HistorialBug()
                historial.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario
                historial.fecha = DateTime.Now
                nuevoBug.addHistorial(historial)

                If bugService.crearBug(nuevoBug) Then
                    MessageBox.Show("El bug se creó correctamente", "Nuevo Bug", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("No pudo crear el Bug", "Nuevo Bug", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error al crear un bug: " & ex.Message, "Error creando Bug", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(txtTitulo.Text) Then
            MessageBox.Show("El campo Título es obligatorio.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If cboProducto.SelectedIndex < 0 Then
            MessageBox.Show("El campo Producto es obligatorio.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class