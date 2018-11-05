Imports System.Data.SqlClient

Public Class UsuarioDao
    Public Function getUserByNamePass(ByVal nombre As String, ByVal password As String) As Usuario
        Dim dm As DataManager = New DataManager()
        Dim oUsuario As Usuario = Nothing

        Try
            dm.Open()
            Dim sql As String = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario" & "         FROM Users u " & "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " & "         WHERE estado = 'S'" & "           AND u.n_usuario = @param1 " & "           AND password = @param2"
            Dim parametros As List(Of Object) = New List(Of Object)()
            parametros.Add(nombre)
            parametros.Add(password)
            Dim oTabla As DataTable
            oTabla = dm.ConsultaSQLConParametros(sql, parametros)
            If oTabla.Rows.Count > 0 Then oUsuario = map_user(oTabla.Rows(0))
            Return oUsuario
        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return oUsuario
    End Function

    Public Function getUserByName(ByVal nombre As String) As Usuario
        Dim dm As DataManager = New DataManager()
        Dim oUsuario As Usuario = Nothing

        Try
            dm.Open()
            Dim sql As String = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario" & "         FROM Users u " & "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " & "         WHERE estado = 'S'" & "           AND u.n_usuario = @param1 "
            Dim parametros As List(Of Object) = New List(Of Object)()
            parametros.Add(nombre)
            Dim oTabla As DataTable
            oTabla = dm.ConsultaSQLConParametros(sql, parametros)
            If oTabla.Rows.Count > 0 Then oUsuario = map_user(oTabla.Rows(0))
        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return oUsuario
    End Function

    Public Function getAll() As IList(Of Usuario)
        Dim dm As DataManager = New DataManager()
        Dim oUsuario As List(Of Usuario) = Nothing

        Try
            dm.Open()
            oUsuario = New List(Of Usuario)()
            Dim sql As String = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario" & "         FROM Users u " & "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " & "        WHERE estado = 'S'"

            For Each row As DataRow In dm.ConsultaSQL(sql).Rows
                oUsuario.Add(map_user(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return oUsuario
    End Function

    Public Function getByFilters(ByVal parametros As List(Of Object)) As List(Of Usuario)
        Dim dm As DataManager = New DataManager()
        Dim oUsuario As List(Of Usuario) = Nothing

        Try
            dm.Open()
            oUsuario = New List(Of Usuario)()
            Dim sql As String = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario, estado" & "         FROM Users u " & "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " & "        WHERE estado = 'S'"
            If parametros(0) IsNot Nothing Then sql += " AND u.id_perfil=@param1 "
            If parametros(1) IsNot Nothing Then sql += " AND u.n_usuario LIKE '%' + @param2 + '%' "

            For Each row As DataRow In dm.ConsultaSQLConParametros(sql, parametros).Rows
                oUsuario.Add(map_user(row))
            Next

        Catch ex As Exception
            dm.Rollback()
        Finally
            dm.Close()
        End Try

        Return oUsuario
    End Function

    Public Function create(ByVal oUsuario As Usuario) As Boolean
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()
            Dim str_sql As String = "INSERT INTO users (n_usuario, password, email, id_perfil, estado)" & "     VALUES(@n_usuario, @password, @email, @id_perfil, 'S')"
            Dim parametros As List(Of SqlParameter) = New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("n_usuario", oUsuario.nombre))
            parametros.Add(New SqlParameter("password", oUsuario.password))
            parametros.Add(New SqlParameter("email", oUsuario.email))
            parametros.Add(New SqlParameter("id_perfil", oUsuario.id_perfil))
            dm.EjecutarSQL(str_sql, parametros)
        Catch ex As Exception
            dm.Rollback()
            Return False
        Finally
            dm.Close()
        End Try

        Return True
    End Function

    Public Function update(ByVal oUsuario As Usuario) As Boolean
        Dim dm As DataManager = New DataManager()

        Try
            dm.Open()
            Dim str_sql As String = "UPDATE users" & "     SET n_usuario = @n_usuario," & "         password = @password, " & "         email = @email, " & "         estado = @estado, " & "         id_perfil = @id_perfil" & "   WHERE id_usuario = @id_usuario"
            Dim parametros As List(Of SqlParameter) = New List(Of SqlParameter)()
            parametros.Add(New SqlParameter("id_usuario", oUsuario.id_usuario))
            parametros.Add(New SqlParameter("n_usuario", oUsuario.nombre))
            parametros.Add(New SqlParameter("password", oUsuario.password))
            parametros.Add(New SqlParameter("email", oUsuario.email))
            parametros.Add(New SqlParameter("estado", oUsuario.estado))
            parametros.Add(New SqlParameter("id_perfil", oUsuario.id_perfil))
            dm.EjecutarSQL(str_sql, parametros)
        Catch ex As Exception
            dm.Rollback()
            Return False
        Finally
            dm.Close()
        End Try

        Return True
    End Function

    Private Function map_user(ByVal row As DataRow) As Usuario
        Dim oUsuario As Usuario = New Usuario()
        oUsuario.id_usuario = Convert.ToInt32(row("id_usuario").ToString())
        oUsuario.nombre = row("n_usuario").ToString()
        oUsuario.password = row("password").ToString()
        oUsuario.email = row("email").ToString()
        oUsuario.perfil = row("n_perfil").ToString()
        oUsuario.estado = row("estado").ToString()
        oUsuario.id_perfil = row("id_perfil").ToString()
        Return oUsuario
    End Function
End Class