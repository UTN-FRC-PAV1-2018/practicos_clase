Class EstadoDao
    Public Function getAll() As List(Of Estado)
        Dim lst As List(Of Estado) = New List(Of Estado)()
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()

            For Each row As DataRow In dm.ConsultaSQL("Select * from Estados").Rows
                lst.Add(map(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Estado
        Dim oEstado As Estado = New Estado()
        oEstado.id_estado = Convert.ToInt32(row("id_Estado").ToString())
        oEstado.nombre = row("n_estado").ToString()
        Return oEstado
    End Function
End Class