using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer;

namespace TPS_BugTracker.DataLayer.DAOs
{
    public class UsuarioDao
    {
        // Permite recuperar un usuario a partir de un nombre y password
        public Usuario getUserByNamePass(string nombre, string password)
        {
            string sql = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil AND x.n_usuario = '" + nombre + "' AND password = '" + password + "'";
            DataTable oTabla;
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count > 0)
                oUsuario = map_user(oTabla.Rows[0]);

            return oUsuario;
        }

        public Usuario getUserByName(string nombre)
        {
            string sql = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil AND x.n_usuario = '" + nombre + "'";
            DataTable oTabla;
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            oTabla = BDHelper.getBDHelper().ConsultaSQL(sql);
            if (oTabla.Rows.Count >  0)
                oUsuario = map_user(oTabla.Rows[0]);

            return oUsuario;
        }



        // Permite recuperar todos los usuarios cargados
        public IList<Usuario> getAll()
        {
            List<Usuario> lst = new List<Usuario>();
            string sql = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil";
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
                lst.Add(map_user(row));

            return lst;
        }

        // Permite recuperar todos los usuarios cargados para un determinado rango de fechas y/o perfil recibidos como 
        // parámetrosr
        public IList<Usuario> getByFilters(List<object> @params)
        {
            List<Usuario> lst = new List<Usuario>();
            string sql = "Select x.*, y.n_perfil, y.id_perfil as perfil_usuario from Users x, Perfiles y where x.id_perfil=y.id_perfil ";
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            if (@params[0] != null)
                sql += " AND x.id_perfil=@param1 ";
            if (@params[1] != null)
                sql += " AND x.n_usuario LIKE '%' + @param2 + '%' ";

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQLConParametros(sql, @params).Rows)
                lst.Add(map_user(row));

            return lst;
        }

        // Funciones CRUD
        public bool create(Usuario oUsuario)
        {
            string str_sql;

            str_sql = "INSERT INTO users (n_usuario, password, email, id_perfil, estado) VALUES('";
            str_sql += oUsuario.nombre + "','";
            str_sql += oUsuario.password + "','";
            str_sql += oUsuario.email + "',";
            str_sql += oUsuario.id_perfil.ToString() + ", 'S')";

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().EjecutarSQL(str_sql) == 1);
        }
        // Funciones CRUD

        public bool update(Usuario oUsuario)
        {
            string str_sql;

            str_sql = "UPDATE users SET n_usuario = '";
            str_sql += oUsuario.nombre + "', password = '";
            str_sql += oUsuario.password + "', email = '";
            str_sql += oUsuario.email + "', id_perfil = ";
            str_sql += oUsuario.id_perfil.ToString() + ", estado = '";
            str_sql += oUsuario.estado + "'";

            str_sql += " WHERE id_usuario = " + oUsuario.id_usuario.ToString();

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (BDHelper.getBDHelper().EjecutarSQL(str_sql) == 1);
        }

        // Función auxiliar responsable de MAPPEAR una fila de Users a un objeto Usuario
        private Usuario map_user(DataRow row)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.id_usuario = Convert.ToInt32(row["id_usuario"].ToString());
            oUsuario.nombre = row["n_usuario"].ToString();
            oUsuario.password = row["password"].ToString();
            oUsuario.email = row["email"].ToString();
            oUsuario.perfil = row["n_perfil"].ToString();
            oUsuario.estado = row["estado"].ToString();
            oUsuario.id_perfil = row["id_perfil"].ToString();
            return oUsuario;
        }
    }



}
