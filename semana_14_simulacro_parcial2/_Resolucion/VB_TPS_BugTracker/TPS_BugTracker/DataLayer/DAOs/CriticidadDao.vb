Class CriticidadDao
    Public Function getAll() As List(Of Criticidad)
        Dim lst As List(Of Criticidad) = New List(Of Criticidad)()
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()

            For Each row As DataRow In dm.ConsultaSQL("Select * from Criticidades").Rows
                lst.Add(map(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Criticidad
        Dim oCriticidad As Criticidad = New Criticidad()
        oCriticidad.id_criticidad = Convert.ToInt32(row("id_criticidad").ToString())
        oCriticidad.nombre = row("n_criticidad").ToString()
        Return oCriticidad
    End Function
End Class