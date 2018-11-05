Class PerfilService
    Private oPerfilDao As PerfilDao

    Public Sub New()
        oPerfilDao = New PerfilDao()
    End Sub

    Public Function consultarPerfiles() As List(Of Perfil)
        Return oPerfilDao.getAll()
    End Function
End Class