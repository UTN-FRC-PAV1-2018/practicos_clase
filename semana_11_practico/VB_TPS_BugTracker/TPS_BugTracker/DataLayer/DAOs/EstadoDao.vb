Class EstadoDao
    Public Function getAll() As List(Of Estado)
        Dim lst As List(Of Estado) = New List(Of Estado)()

        For Each row As DataRow In BDHelper.getBDHelper().ConsultaSQL("Select * from Estados").Rows
            lst.Add(map(row))
        Next

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Estado
        Dim oEstado As Estado = New Estado()
        oEstado.id_estado = Convert.ToInt32(row("id_Estado").ToString())
        oEstado.nombre = row("n_estado").ToString()
        Return oEstado
    End Function
End Class
