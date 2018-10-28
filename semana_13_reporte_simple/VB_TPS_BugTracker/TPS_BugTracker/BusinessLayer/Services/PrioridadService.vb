Class PrioridadService
    Private oPrioridadDao As PrioridadDao

    Public Sub New()
        oPrioridadDao = New PrioridadDao()
    End Sub

    Public Function consultarPrioridades() As List(Of Prioridad)
        Return oPrioridadDao.getAll()
    End Function
End Class
