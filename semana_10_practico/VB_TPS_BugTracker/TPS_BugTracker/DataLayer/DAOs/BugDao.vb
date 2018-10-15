Imports System.Data.SqlClient

Public Class BugDao
    Public Function getBugById(ByVal id As Integer) As Bug
        Dim sql As String = "   SELECT TOP 20 bug.id_bug, bug.titulo, bug.descripcion, pro.nombre, bug.fecha_alta, n_estado as estado, usr.n_usuario as asignado_a, n_prioridad, cri.n_criticidad, pro.id_producto, pri.id_prioridad, cri.id_criticidad" + _
                            "   FROM  bugs bug" + _
                            "   INNER JOIN Historiales_Bug his ON bug.id_bug = his.id_bug" + _
                            "   INNER JOIN Estados est ON his.id_estado = est.id_estado" + _
                            "   LEFT JOIN Users usr ON his.asignado_a = usr.id_usuario" + _
                            "   INNER JOIN Productos pro ON bug.id_producto = pro.id_producto" + _
                            "   INNER JOIN Prioridades pri ON bug.id_prioridad = pri.id_prioridad" + _
                            "   INNER JOIN Criticidades cri ON bug.id_criticidad = cri.id_criticidad" + _
                            "   WHERE his.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug his2 WHERE bug.id_bug = his2.id_bug)" + _
                            "         AND bug.id_bug = " + id.ToString
        Return mapBug(BDHelper.getBDHelper().ConsultaSQL(sql).Rows(0))
    End Function

    Public Function getBugByFilters(ByVal parametros As List(Of Object)) As IList(Of Bug)
        Dim lst As List(Of Bug) = New List(Of Bug)()
        Dim sql As String = "   SELECT TOP 20 bug.id_bug, bug.titulo, bug.descripcion, pro.nombre, bug.fecha_alta, n_estado as estado, usr.n_usuario as asignado_a, n_prioridad, cri.n_criticidad" + _
                            "   FROM  bugs bug" + _
                            "   INNER JOIN Historiales_Bug his ON bug.id_bug = his.id_bug" + _
                            "   INNER JOIN Estados est ON his.id_estado = est.id_estado" + _
                            "   LEFT JOIN Users usr ON his.asignado_a = usr.id_usuario" + _
                            "   INNER JOIN Productos pro ON bug.id_producto = pro.id_producto" + _
                            "   INNER JOIN Prioridades pri ON bug.id_prioridad = pri.id_prioridad" + _
                            "   INNER JOIN Criticidades cri ON bug.id_criticidad = cri.id_criticidad" + _
                            "   WHERE his.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug his2 WHERE bug.id_bug = his2.id_bug)"

        If parametros(0) IsNot Nothing AndAlso parametros(1) IsNot Nothing Then sql += " AND (bug.fecha_alta>=@param1 AND bug.fecha_alta<=@param2) "
        If parametros(2) IsNot Nothing Then sql += "AND bug.id_prioridad=@param3 "
        If parametros(3) IsNot Nothing Then sql += "AND bug.id_criticidad=@param4 "
        If parametros(4) IsNot Nothing Then sql += "AND bug.id_producto=@param5 "
        If parametros(5) IsNot Nothing Then sql += " AND his.id_estado=@param6 "
        If parametros(6) IsNot Nothing Then sql += " AND his.asignado_a=@param7 "
        sql += "ORDER BY bug.fecha_alta DESC"
        For Each row As DataRow In BDHelper.getBDHelper().ConsultaSQLConParametros(sql, parametros).Rows
            lst.Add(mapSmallBug(row))
        Next

        Return lst
    End Function

    Private Function mapSmallBug(ByVal row As DataRow) As Bug
        Dim oBug As Bug = New Bug()
        oBug.id_bug = Convert.ToInt32(row("id_bug").ToString())
        oBug.titulo = row("titulo").ToString()
        oBug.descripcion = row("descripcion").ToString()
        oBug.fecha_alta = Convert.ToDateTime(row("fecha_alta").ToString())
        oBug.n_producto = row("nombre").ToString()
        oBug.estado = row("estado").ToString()
        oBug.asignado_a = row("asignado_a").ToString()
        oBug.n_prioridad = row("n_prioridad").ToString()
        oBug.n_criticidad = row("n_criticidad").ToString()
        Return oBug
    End Function

    Private Function mapBug(ByVal row As DataRow) As Bug
        Dim oBug As Bug = New Bug()
        Dim sql As String
        Dim oHistorial_bug As HistorialBug
        oBug.id_bug = Convert.ToInt32(row("id_bug").ToString())
        oBug.titulo = row("titulo").ToString()
        oBug.descripcion = row("descripcion").ToString()
        oBug.fecha_alta = Convert.ToDateTime(row("fecha_alta").ToString())
        oBug.id_producto = Convert.ToInt32(row("id_producto").ToString())
        oBug.id_prioridad = Convert.ToInt32(row("id_prioridad").ToString())
        oBug.id_criticidad = Convert.ToInt32(row("id_criticidad").ToString())
        oBug.n_producto = row("nombre").ToString()
        oBug.n_criticidad = row("n_criticidad").ToString()
        oBug.n_prioridad = row("n_prioridad").ToString()
        oBug.estado = row("estado").ToString()
        sql = " SELECT h.*, e.n_estado, resp.n_usuario as n_responsable, asig.n_usuario as n_asignado_a" + _
            "   FROM Historiales_Bug h " + _
            "   INNER JOIN estados e ON h.id_estado = e.id_estado " + _
            "   INNER JOIN users resp  ON h.responsable = resp.id_usuario" + _
            "   INNER JOIN users asig  ON h.asignado_a = asig.id_usuario" + _
            "   WHERE h.id_bug =" & oBug.id_bug.ToString()

        For Each detail As DataRow In BDHelper.getBDHelper().ConsultaSQL(sql).Rows
            oHistorial_bug = New HistorialBug()
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
            oBug.addHistorial(oHistorial_bug)
        Next

        Return oBug
    End Function

    Friend Shared Sub updateBug(ByVal oBugSelected As Bug)
        Dim sql As String = "  UPDATE bugs" &
                            "     SET titulo = @titulo," &
                            "         descripcion = @descripcion, " &
                            "         id_producto = @id_producto," &
                            "         id_prioridad = @id_prioridad," &
                            "         id_criticidad = @id_criticidad" &
                            "   WHERE id_bug = @id_bug;"
        Dim parametros As List(Of SqlParameter) = New List(Of SqlParameter)()
        parametros.Add(New SqlParameter("id_bug", oBugSelected.id_bug))
        parametros.Add(New SqlParameter("titulo", oBugSelected.titulo))
        parametros.Add(New SqlParameter("descripcion", oBugSelected.descripcion))
        parametros.Add(New SqlParameter("id_producto", oBugSelected.id_producto))
        parametros.Add(New SqlParameter("id_prioridad", oBugSelected.id_prioridad))
        parametros.Add(New SqlParameter("id_criticidad", oBugSelected.id_criticidad))
        BDHelper.getBDHelper().EjecutarSQL(sql, parametros)
    End Sub
End Class