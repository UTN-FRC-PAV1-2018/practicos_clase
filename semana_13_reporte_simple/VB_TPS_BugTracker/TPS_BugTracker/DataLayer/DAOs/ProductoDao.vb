Class ProductoDao
    Public Function getAll() As List(Of Producto)
        Dim lst As List(Of Producto) = New List(Of Producto)()
        Dim oProducto As Producto = Nothing

        For Each row As DataRow In BDHelper.getBDHelper().ConsultaSQL("Select * from Productos").Rows
            lst.Add(map(row))
        Next

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Producto
        Dim oProducto As Producto = New Producto()
        oProducto.id_Producto = Convert.ToInt32(row("id_producto").ToString())
        oProducto.nombre = row("nombre").ToString()
        Return oProducto
    End Function
End Class
