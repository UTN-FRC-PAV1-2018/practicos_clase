Class PerfilDao
    Public Function getAll() As List(Of Perfil)
        Dim lst As List(Of Perfil) = New List(Of Perfil)()
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()

            For Each row As DataRow In dm.ConsultaSQL("Select * from Perfiles").Rows
                lst.Add(map(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return lst
    End Function

    Private Function map(ByVal row As DataRow) As Perfil
        Dim Perfil As Perfil = New Perfil()
        Perfil.id_perfil = Convert.ToInt32(row("id_perfil").ToString())
        Perfil.nombre = row("n_perfil").ToString()
        Return Perfil
    End Function
End Class