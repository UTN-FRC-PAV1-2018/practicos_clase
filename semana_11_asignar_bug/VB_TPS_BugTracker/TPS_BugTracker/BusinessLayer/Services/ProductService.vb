Class ProductoService
    Private oProductoDao As ProductoDao

    Public Sub New()
        oProductoDao = New ProductoDao()
    End Sub

    Public Function consultarProductos() As List(Of Producto)
        Return oProductoDao.getAll()
    End Function
End Class
