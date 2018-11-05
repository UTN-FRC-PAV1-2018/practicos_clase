Partial Public Class frmNuevoBug
    Inherits Form

    Private prioridadService As PrioridadService = New PrioridadService()
    Private productoService As ProductoService = New ProductoService()
    Private criticidadService As CriticidadService = New CriticidadService()
    Private oBug As Bug
    Private oBugService As BugService = New BugService()

    Public Sub New()
        InitializeComponent()
        oBugService = New BugService()
        GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad")
        GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad")
        GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto")
    End Sub

End Class