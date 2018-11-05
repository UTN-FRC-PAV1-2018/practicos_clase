Class PrioridadDao
    Public Function getAll() As List(Of Prioridad)
        Dim lst As List(Of Prioridad) = New List(Of Prioridad)()
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()

            For Each row As DataRow In dm.ConsultaSQL("Select * from Prioridades").Rows
                lst.Add(map(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Prioridad
        Dim oPrioridad As Prioridad = New Prioridad()
        oPrioridad.id_prioridad = Convert.ToInt32(row("id_prioridad").ToString())
        oPrioridad.nombre = row("n_prioridad").ToString()
        Return oPrioridad
    End Function
End Class