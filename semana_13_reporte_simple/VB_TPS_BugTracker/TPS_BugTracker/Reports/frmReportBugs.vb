Imports Microsoft.Reporting.WinForms

Partial Public Class frmReportBugs
    Inherits Form

    Private oBugService As BugService = New BugService()
    Private criticidadService As CriticidadService = New CriticidadService()
    Private prioridadService As PrioridadService = New PrioridadService()
    Private productoService As ProductoService = New ProductoService()
    Private usuarioService As UsuarioService = New UsuarioService()
    Private estadoService As EstadoService = New EstadoService()

    Public Sub New()
        InitializeComponent()
        GUIHelper.getHelper().llenarCombo(cboEstados, estadoService.consultarEstados(), "nombre", "id_estado")
        GUIHelper.getHelper().llenarCombo(cboPrioridades, prioridadService.consultarPrioridades(), "nombre", "id_prioridad")
        GUIHelper.getHelper().llenarCombo(cboCriticidades, criticidadService.consultarCriticidades(), "nombre", "id_criticidad")
        GUIHelper.getHelper().llenarCombo(cboAsignadoA, usuarioService.consultarUsuarios(), "nombre", "id_usuario")
        GUIHelper.getHelper().llenarCombo(cboProductos, productoService.consultarProductos(), "nombre", "id_producto")
    End Sub

    Private Sub frmReportBugs_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.reporteBugs.RefreshReport()
    End Sub

    Private Sub reportViewer1_Load(ByVal sender As Object, ByVal e As EventArgs)
        reporteBugs.ProcessingMode = ProcessingMode.Local
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

        BugBindingSource.DataSource = oBugService.consultarBugsConFiltros(parametros)
        reporteBugs.RefreshReport()
    End Sub
End Class