Public Class BugService
    Private oBugDao As BugDao

    Public Sub New()
        oBugDao = New BugDao()
    End Sub

    Public Function consultarBugsConFiltros(ByVal params As List(Of Object)) As IList(Of Bug)
        Return oBugDao.getBugByFilters(params)
    End Function

    Public Function consultarBugsPorId(ByVal id As Integer) As Bug
        Return oBugDao.getBugById(id)
    End Function

    Public Function crearBug(ByVal bug As Bug) As Boolean
        Return oBugDao.crearBug(bug)
    End Function
End Class