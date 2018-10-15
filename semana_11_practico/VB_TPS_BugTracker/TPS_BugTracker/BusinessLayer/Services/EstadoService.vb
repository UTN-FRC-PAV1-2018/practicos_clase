Class EstadoService
    Private oEstadoDao As EstadoDao

    Public Sub New()
        oEstadoDao = New EstadoDao()
    End Sub

    Public Function consultarEstados() As List(Of Estado)
        Return oEstadoDao.getAll()
    End Function
End Class
