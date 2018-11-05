using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;

namespace TPS_BugTracker.DataLayer.DAOs
{
    public class UsuarioDao
    {
        // Permite recuperar un usuario a partir de un nombre y password
        public Usuario getUserByNamePass(string nombre, string password)
        {
            DataManager dm = new DataManager();
            Usuario oUsuario = null;
            try
            {
                dm.Open();
                string sql = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario" +
                        "         FROM Users u " +
                        "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                        "         WHERE estado = 'S'" +
                        "           AND u.n_usuario = @param1 " +
                        "           AND password = @param2";

                List<object> parametros = new List<object>();
                parametros.Add(nombre);
                parametros.Add(password);

                DataTable oTabla;

                oTabla = dm.ConsultaSQLConParametros(sql, parametros);
                if (oTabla.Rows.Count > 0)
                    oUsuario = map_user(oTabla.Rows[0]);

                return oUsuario;

            }
            catch (Exception ex)
            {
                dm.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return oUsuario;
        }

        public Usuario getUserByName(string nombre)
        {
            DataManager dm = new DataManager();
            Usuario oUsuario = null;
            try
            {
                dm.Open();
                string sql = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario" +
                        "         FROM Users u " +
                        "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                        "         WHERE estado = 'S'" +
                        "           AND u.n_usuario = @param1 ";

                List<object> parametros = new List<object>();
                parametros.Add(nombre);

                DataTable oTabla;

                oTabla = dm.ConsultaSQLConParametros(sql, parametros);
                if (oTabla.Rows.Count > 0)
                    oUsuario = map_user(oTabla.Rows[0]);
            }
            catch (Exception ex)
            {
                dm.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return oUsuario;
        }

        // Permite recuperar todos los usuarios cargados
        public IList<Usuario> getAll()
        {
            DataManager dm = new DataManager();
            List<Usuario> oUsuario = null;
            try
            {
                dm.Open();
                oUsuario = new List<Usuario>();
                string sql = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario" +
                         "         FROM Users u " +
                         "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                         "        WHERE estado = 'S'";

                foreach (DataRow row in dm.ConsultaSQL(sql).Rows)
                    oUsuario.Add(map_user(row));

            }
            catch (Exception ex)
            {
                dm.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return oUsuario;
        }

        // Permite recuperar todos los usuarios cargados para un determinado rango de fechas y/o perfil recibidos como 
        // parámetrosr
        public List<Usuario> getByFilters(List<object> parametros)
        {
            DataManager dm = new DataManager();
            List<Usuario> oUsuario = null;
            try
            {
                dm.Open();
                oUsuario = new List<Usuario>();
                string sql = "  SELECT u.*, p.n_perfil, p.id_perfil as perfil_usuario, estado" +
                        "         FROM Users u " +
                        "         INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                        "        WHERE estado = 'S'";

                if (parametros[0] != null)
                    sql += " AND u.id_perfil=@param1 ";
                if (parametros[1] != null)
                    sql += " AND u.n_usuario LIKE '%' + @param2 + '%' ";

                foreach (DataRow row in dm.ConsultaSQLConParametros(sql, parametros).Rows)
                    oUsuario.Add(map_user(row));


            }
            catch (Exception ex)
            {
                dm.Rollback();
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return oUsuario;
        }

        // Funciones CRUD
        public bool create(Usuario oUsuario)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                string str_sql = "INSERT INTO users (n_usuario, password, email, id_perfil, estado)" +
                          "     VALUES(@n_usuario, @password, @email, @id_perfil, 'S')";

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("n_usuario", oUsuario.nombre));
                parametros.Add(new SqlParameter("password", oUsuario.password));
                parametros.Add(new SqlParameter("email", oUsuario.email));
                parametros.Add(new SqlParameter("id_perfil", oUsuario.id_perfil));

                // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
                dm.EjecutarSQL(str_sql, parametros);

            }
            catch (Exception ex)
            {
                dm.Rollback();
                return false;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return true;
        }
        // Funciones CRUD

        public bool update(Usuario oUsuario)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();

                string str_sql = "UPDATE users" +
                        "     SET n_usuario = @n_usuario," +
                        "         password = @password, " +
                        "         email = @email, " +
                        "         estado = @estado, " +
                        "         id_perfil = @id_perfil" +
                        "   WHERE id_usuario = @id_usuario";

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("id_usuario", oUsuario.id_usuario));
                parametros.Add(new SqlParameter("n_usuario", oUsuario.nombre));
                parametros.Add(new SqlParameter("password", oUsuario.password));
                parametros.Add(new SqlParameter("email", oUsuario.email));
                parametros.Add(new SqlParameter("estado", oUsuario.estado));
                parametros.Add(new SqlParameter("id_perfil", oUsuario.id_perfil));

                // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
                dm.EjecutarSQL(str_sql, parametros);

            }
            catch (Exception ex)
            {
                dm.Rollback();
                return false;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return true;
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
