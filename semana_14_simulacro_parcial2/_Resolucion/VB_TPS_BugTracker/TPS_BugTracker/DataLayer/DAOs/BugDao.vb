Imports System.Data.SqlClient

Public Class BugDao
    Public Function getBugById(ByVal id As Integer) As Bug
        Dim dm As DataManager = New DataManager()
        Dim bug As Bug = Nothing

        Try
            dm.Open()
            Dim sql As String = "SELECT " & " b.id_bug," & " b.titulo," & " b.descripcion," & " b.id_producto," & " b.id_prioridad," & " b.fecha_alta," & " b.id_criticidad," & " b.id_asignado_a, " & " pro.nombre," & " pri.n_prioridad," & " cri.n_criticidad," & " e.n_estado FROM bugs b, Productos pro, Prioridades pri, Criticidades cri, Estados e " & " WHERE b.id_producto = pro.id_producto" & " AND b.id_prioridad = pri.id_prioridad" & " AND b.id_criticidad = cri.id_criticidad" & " AND b.id_estado = e.id_estado" & "         AND b.id_bug = " & id.ToString()
            bug = mapBug(dm.ConsultaSQL(sql).Rows(0))
        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return bug
    End Function

    Public Function getBugByFilters(ByVal parametros As List(Of Object)) As IList(Of Bug)
        Dim dm As DataManager = New DataManager()
        Dim lst As List(Of Bug) = New List(Of Bug)()

        Try
            dm.Open()
            Dim sql As String = "SELECT " & " b.id_bug," & " b.titulo," & " b.descripcion," & " b.id_producto," & " b.id_prioridad," & " b.fecha_alta," & " b.id_criticidad," & " b.id_asignado_a, " & " pro.nombre," & " pri.n_prioridad," & " cri.n_criticidad," & " e.n_estado FROM bugs b, Productos pro, Prioridades pri, Criticidades cri, Estados e " & " WHERE b.id_producto = pro.id_producto" & " AND b.id_prioridad = pri.id_prioridad" & " AND b.id_criticidad = cri.id_criticidad" & " AND b.id_estado = e.id_estado"
            If parametros(0) IsNot Nothing AndAlso parametros(1) IsNot Nothing Then sql += " AND (b.fecha_alta>=@param1 AND b.fecha_alta<=@param2) "
            If parametros(2) IsNot Nothing Then sql += " AND b.id_prioridad=@param3 "
            If parametros(3) IsNot Nothing Then sql += " AND b.id_criticidad=@param4 "
            If parametros(4) IsNot Nothing Then sql += " AND b.id_producto=@param5 "
            If parametros(5) IsNot Nothing Then sql += " AND b.id_estado=@param6 "
            If parametros(6) IsNot Nothing Then sql += " AND b.id_asignado_a=@param7 "
            sql += " ORDER BY b.fecha_alta DESC "

            For Each row As DataRow In dm.ConsultaSQLConParametros(sql, parametros).Rows
                lst.Add(mapSmallBug(row))
            Next

            Return lst
            dm.Commit()
        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return lst
    End Function

    Private Function mapSmallBug(ByVal row As DataRow) As Bug
        Dim oBug As Bug = New Bug()
        oBug.id_bug = Convert.ToInt32(row("id_bug").ToString())
        oBug.titulo = row("titulo").ToString()
        oBug.descripcion = row("descripcion").ToString()
        oBug.fecha_alta = Convert.ToDateTime(row("fecha_alta").ToString())
        oBug.n_producto = row("nombre").ToString()
        oBug.n_estado = row("n_estado").ToString()
        oBug.n_prioridad = row("n_prioridad").ToString()
        oBug.n_criticidad = row("n_criticidad").ToString()
        Return oBug
    End Function

    Private Function mapBug(ByVal row As DataRow) As Bug
        Dim oBug As Bug = New Bug()
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
        oBug.n_estado = row("n_estado").ToString()
        Return oBug
    End Function

    Public Function crearBug(ByVal bug As Bug) As Boolean
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()
            dm.BeginTransaction()
            Dim insertBug As String = "INSERT INTO Bugs (titulo, descripcion, id_producto, id_prioridad, id_criticidad, id_estado, fecha_alta)" & " VALUES (@titulo, @descripcion, @id_producto, @id_prioridad, @id_criticidad, @id_estado, GETDATE()) ;"
            Dim paramBug As List(Of SqlParameter) = New List(Of SqlParameter)()
            paramBug.Add(New SqlParameter("id_bug", bug.id_bug))
            paramBug.Add(New SqlParameter("titulo", bug.titulo))
            paramBug.Add(New SqlParameter("descripcion", bug.descripcion))
            paramBug.Add(New SqlParameter("id_producto", bug.id_producto))
            paramBug.Add(New SqlParameter("id_prioridad", bug.id_prioridad))
            paramBug.Add(New SqlParameter("id_criticidad", bug.id_criticidad))
            paramBug.Add(New SqlParameter("id_estado", bug.id_estado))
            dm.EjecutarSQL(insertBug, paramBug)
            Dim insertHistorico As String = " INSERT INTO BugsHistorico (id_bug, titulo, descripcion, id_producto, id_prioridad, id_criticidad, id_responsable, id_estado, fecha_historico) " & " VALUES(@@IDENTITY, @titulo, @descripcion, @id_producto, @id_prioridad, @id_criticidad, @id_responsable, @id_estado, GETDATE()) ;"
            Dim historial As HistorialBug = bug.historial.First()
            Dim paramHistorico As List(Of SqlParameter) = New List(Of SqlParameter)()
            paramHistorico.Add(New SqlParameter("titulo", bug.titulo))
            paramHistorico.Add(New SqlParameter("descripcion", bug.descripcion))
            paramHistorico.Add(New SqlParameter("id_producto", bug.id_producto))
            paramHistorico.Add(New SqlParameter("id_prioridad", bug.id_prioridad))
            paramHistorico.Add(New SqlParameter("id_criticidad", bug.id_criticidad))
            paramHistorico.Add(New SqlParameter("id_responsable", historial.responsable))
            paramHistorico.Add(New SqlParameter("id_estado", bug.id_estado))
            dm.EjecutarSQL(insertHistorico, paramHistorico)
            dm.Commit()
            Return True
        Catch ex As Exception
            dm.Rollback()
            Return False
        Finally
            dm.Close()
        End Try
    End Function
    
End Class