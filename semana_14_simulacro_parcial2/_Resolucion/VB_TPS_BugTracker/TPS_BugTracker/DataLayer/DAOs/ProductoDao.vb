Class ProductoDao
    Public Function getAll() As List(Of Producto)
        Dim lst As List(Of Producto) = New List(Of Producto)()
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()

            For Each row As DataRow In dm.ConsultaSQL("Select * from Productos").Rows
                lst.Add(map(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Producto
        Dim oProducto As Producto = New Producto()
        oProducto.id_Producto = Convert.ToInt32(row("id_producto").ToString())
        oProducto.nombre = row("nombre").ToString()
        Return oProducto
    End Function
End Class