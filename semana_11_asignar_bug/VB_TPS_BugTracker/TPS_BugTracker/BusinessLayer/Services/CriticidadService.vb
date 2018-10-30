Class CriticidadService
    Private oCriticidadDao As CriticidadDao

    Public Sub New()
        oCriticidadDao = New CriticidadDao()
    End Sub

    Public Function consultarCriticidades() As List(Of Criticidad)
        Return oCriticidadDao.getAll()
    End Function
End Class
