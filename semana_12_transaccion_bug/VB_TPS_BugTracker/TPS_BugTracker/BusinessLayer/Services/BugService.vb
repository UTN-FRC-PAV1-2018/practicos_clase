
Public Class BugService
    Private oBugDao As BugDao
    Private oHistorialBugDao As HistorialBugDao

    Public Sub New()
        oBugDao = New BugDao()
        oHistorialBugDao = New HistorialBugDao()
    End Sub

    Public Function consultarBugsConFiltros(ByVal params As List(Of Object)) As IList(Of Bug)
        Return oBugDao.getBugByFilters(params)
    End Function

    Public Function consultarBugsPorId(ByVal id As Integer) As Bug
        Return oBugDao.getBugById(id)
    End Function

    Public Function actualizarBug(ByVal oBug As Bug) As Boolean
        Return oBugDao.update(oBug)
    End Function

    Public Function crearBug(ByVal oBug As Bug) As Boolean
        Return oBugDao.create(oBug)
    End Function

    Public Function pasarATesting(ByVal oBug As Bug) As Boolean
        Dim historial As HistorialBug = New HistorialBug()
        historial.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario
        historial.estado = 4
        historial.fecha = DateTime.Now
        oBug.addHistorial(historial)
        Return oBugDao.update(oBug)
    End Function

    Public Function cerrar(ByVal oBug As Bug) As Boolean
        Dim historial As HistorialBug = New HistorialBug()
        historial.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario
        historial.estado = 3
        historial.fecha = DateTime.Now
        oBug.addHistorial(historial)
        Return oBugDao.update(oBug)
    End Function
End Class
