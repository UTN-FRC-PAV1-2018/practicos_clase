Public Class UsuarioService
    Private oUsuarioDao As UsuarioDao

    Public Sub New()
        oUsuarioDao = New UsuarioDao()
    End Sub

    Public Function validarUsuario(ByVal nombre As String, ByVal password As String) As Usuario
        Return oUsuarioDao.getUserByNamePass(nombre, password)
    End Function

    Public Function validarNombreUsuario(ByVal nombre As String) As Usuario
        Return oUsuarioDao.getUserByName(nombre)
    End Function

    Public Function consultarUsuariosConFiltros(ByVal params As List(Of Object)) As IList(Of Usuario)
        Return oUsuarioDao.getByFilters(params)
    End Function

    Public Function consultarUsuarios() As IList(Of Usuario)
        Return oUsuarioDao.getAll()
    End Function

    Public Function consultarDesarrolladores() As IList(Of Usuario)
        Dim params As List(Of Object) = New List(Of Object)() From {
            3,
            Nothing
        }
        Return oUsuarioDao.getByFilters(params)
    End Function

    Public Function crearUsuario(ByVal oUsuario As Usuario) As Boolean
        Return oUsuarioDao.create(oUsuario)
    End Function

    Public Function actualizarUsuario(ByVal oUsuario As Usuario) As Boolean
        Return oUsuarioDao.update(oUsuario)
    End Function

    Public Function modificarEstadoUsuario(ByVal oUsuario As Usuario) As Boolean
        Return oUsuarioDao.update(oUsuario)
    End Function
End Class