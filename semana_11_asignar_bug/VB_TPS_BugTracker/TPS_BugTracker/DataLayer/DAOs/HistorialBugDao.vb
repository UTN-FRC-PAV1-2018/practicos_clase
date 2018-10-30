Imports System.Data.SqlClient

Class HistorialBugDao
    Public Function getById(ByVal id As Integer) As List(Of HistorialBug)
        Dim sql As String
        Dim list As List(Of HistorialBug) = New List(Of HistorialBug)()
        sql = " SELECT h.*, e.n_estado, resp.n_usuario as n_responsable, asig.n_usuario as n_asignado_a" & "   FROM Historiales_Bug h " & "   INNER JOIN estados e ON h.id_estado = e.id_estado " & "   LEFT JOIN users resp  ON h.responsable = resp.id_usuario" & "   LEFT JOIN users asig  ON h.asignado_a = asig.id_usuario" & "   WHERE h.id_bug =" & id.ToString()

        For Each detail As DataRow In BDHelper.getBDHelper().ConsultaSQL(sql).Rows
            list.Add(mapBug(detail))
        Next

        Return list
    End Function

    Private Function mapBug(ByVal detail As DataRow) As HistorialBug
        Dim oHistorial_bug As HistorialBug = New HistorialBug()
        oHistorial_bug.id_detalle = Convert.ToInt32(detail("id_detalle").ToString())
        oHistorial_bug.responsable = Convert.ToInt32(detail("responsable").ToString())

        If Not Convert.IsDBNull(detail("asignado_a")) Then
            oHistorial_bug.asignado_a = Convert.ToInt32(detail("asignado_a").ToString())
            oHistorial_bug.n_asignado_a = detail("n_asignado_a").ToString()
        End If

        oHistorial_bug.estado = Convert.ToInt32(detail("id_estado").ToString())
        oHistorial_bug.fecha = Convert.ToDateTime(detail("fecha").ToString())
        oHistorial_bug.n_responsable = detail("n_responsable").ToString()
        oHistorial_bug.n_estado = detail("n_estado").ToString()
        Return oHistorial_bug
    End Function

    Public Function create(ByVal idBug As Integer, ByVal historial As HistorialBug) As Boolean
        Dim sql As String = " INSERT INTO Historiales_Bug(id_bug, id_detalle, fecha, responsable, id_estado, asignado_a) " & "    VALUES(@id_bug,@id_detalle, @fecha ,@responsable,@id_estado,@asignado_a)"
        Dim parametros As List(Of SqlParameter) = New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("id_bug", idBug))
        parametros.Add(New SqlParameter("id_detalle", historial.id_detalle))
        parametros.Add(New SqlParameter("fecha", historial.fecha))
        parametros.Add(New SqlParameter("responsable", historial.responsable))
        parametros.Add(New SqlParameter("id_estado", historial.estado))
        parametros.Add(New SqlParameter("asignado_a", historial.asignado_a))
        Return BDHelper.getBDHelper().EjecutarSQL(sql, parametros) = 1
    End Function
End Class
