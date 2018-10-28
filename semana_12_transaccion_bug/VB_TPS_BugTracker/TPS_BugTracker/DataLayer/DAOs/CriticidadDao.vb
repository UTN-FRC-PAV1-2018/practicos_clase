Class CriticidadDao
    Public Function getAll() As List(Of Criticidad)
        Dim lst As List(Of Criticidad) = New List(Of Criticidad)()

        For Each row As DataRow In BDHelper.getBDHelper().ConsultaSQL("Select * from Criticidades").Rows
            lst.Add(map(row))
        Next

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Criticidad
        Dim oCriticidad As Criticidad = New Criticidad()
        oCriticidad.id_criticidad = Convert.ToInt32(row("id_criticidad").ToString())
        oCriticidad.nombre = row("n_criticidad").ToString()
        Return oCriticidad
    End Function
End Class
