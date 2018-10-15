Partial Public Class frmActualizarBug
    Inherits Form

    Private prioridadService As PrioridadService = New PrioridadService()
    Private productoService As ProductoService = New ProductoService()
    Private criticidadService As CriticidadService = New CriticidadService()
    Private oBugSelected As Bug
    Private oBugService As BugService

    Public Sub New()
        InitializeComponent()
        oBugService = New BugService()
        GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad")
        GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad")
        GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto")
    End Sub

    Friend Sub mostrarBug(ByVal bugSelected As Bug)
        oBugSelected = bugSelected
        txtTitulo.Text = oBugSelected.titulo
        txtDescripcion.Text = oBugSelected.n_producto
        txtDescripcion.Text = oBugSelected.descripcion
        cboPrioridad.SelectedValue = oBugSelected.id_prioridad
        cboCriticidad.SelectedValue = oBugSelected.id_criticidad
        cboProducto.SelectedValue = oBugSelected.id_producto
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_aceptar.Click
        If oBugSelected IsNot Nothing Then
            oBugSelected.titulo = txtTitulo.Text
            oBugSelected.descripcion = txtDescripcion.Text
            oBugSelected.id_prioridad = CInt(cboPrioridad.SelectedValue)
            oBugSelected.id_criticidad = CInt(cboCriticidad.SelectedValue)
            oBugSelected.id_producto = CInt(cboProducto.SelectedValue)
            oBugService.actualizarBug(oBugSelected)
        End If

        Me.Close()
    End Sub
End Class