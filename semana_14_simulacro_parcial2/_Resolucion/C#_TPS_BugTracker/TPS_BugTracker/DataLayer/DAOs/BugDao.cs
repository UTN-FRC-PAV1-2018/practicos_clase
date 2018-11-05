

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using TPS_BugTracker.BusinessLayer.Entities;
using System.Data;
using System.Data.SqlClient;
// para usar el msgbox como depurador
using System.Windows.Forms;

namespace TPS_BugTracker.DataLayer.DAOs
{
    public class BugDao
    {
        public Bug getBugById(int id)
        {
            DataManager dm = new DataManager();
            Bug bug = null;
            try
            {
                dm.Open();

                string sql = "SELECT " +
                " b.id_bug," +
                " b.titulo," +
                " b.descripcion," +
                " b.id_producto," +
                " b.id_prioridad," +
                " b.fecha_alta," +
                " b.id_criticidad," +
                " b.id_asignado_a, " +
                " pro.nombre," +
                " pri.n_prioridad," +
                " cri.n_criticidad," +
                " e.n_estado FROM bugs b, Productos pro, Prioridades pri, Criticidades cri, Estados e " +
                " WHERE b.id_producto = pro.id_producto" +
                " AND b.id_prioridad = pri.id_prioridad" +
                " AND b.id_criticidad = cri.id_criticidad" +
                " AND b.id_estado = e.id_estado" +
                   "         AND b.id_bug = " + id.ToString();


                bug = mapBug(dm.ConsultaSQL(sql).Rows[0]);


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


            return bug;
        }

        public IList<Bug> getBugByFilters(List<object> parametros)
        {
            DataManager dm = new DataManager();
            List<Bug> lst = new List<Bug>();
            try
            {
                dm.Open();
                string sql = "SELECT " +
               " b.id_bug," +
               " b.titulo," +
               " b.descripcion," +
               " b.id_producto," +
               " b.id_prioridad," +
               " b.fecha_alta," +
               " b.id_criticidad," +
               " b.id_asignado_a, " +
               " pro.nombre," +
               " pri.n_prioridad," +
               " cri.n_criticidad," +
               " e.n_estado FROM bugs b, Productos pro, Prioridades pri, Criticidades cri, Estados e " +
               " WHERE b.id_producto = pro.id_producto" +
               " AND b.id_prioridad = pri.id_prioridad" +
               " AND b.id_criticidad = cri.id_criticidad" +
               " AND b.id_estado = e.id_estado";

                // Validamos filtro de fechas
                if (parametros[0] != null && parametros[1] != null)
                    sql += " AND (b.fecha_alta>=@param1 AND b.fecha_alta<=@param2) ";
                // Validamos filtro prioridad
                if (parametros[2] != null)
                    sql += " AND b.id_prioridad=@param3 ";
                // Validamos filtro criticidad
                if (parametros[3] != null)
                    sql += " AND b.id_criticidad=@param4 ";
                // Validamos filtro producto
                if (parametros[4] != null)
                    sql += " AND b.id_producto=@param5 ";

                if (parametros[5] != null)
                    sql += " AND b.id_estado=@param6 ";
                // Con el mismo criterio validamos filtro asignado_a
                if (parametros[6] != null)
                    sql += " AND b.id_asignado_a=@param7 ";
                sql += " ORDER BY b.fecha_alta DESC ";

                foreach (DataRow row in dm.ConsultaSQLConParametros(sql, parametros).Rows)
                    lst.Add(mapSmallBug(row));
                return lst;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }

            return lst;
        }

        private Bug mapSmallBug(DataRow row)
        {
            Bug oBug = new Bug();
            oBug.id_bug = Convert.ToInt32(row["id_bug"].ToString());
            oBug.titulo = row["titulo"].ToString();
            oBug.descripcion = row["descripcion"].ToString();
            oBug.fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString());
            oBug.n_producto = row["nombre"].ToString();
            oBug.n_estado = row["n_estado"].ToString();
            oBug.n_prioridad = row["n_prioridad"].ToString();
            oBug.n_criticidad = row["n_criticidad"].ToString();
            return oBug;
        }

        private Bug mapBug(DataRow row)
        {
            Bug oBug = new Bug();

            oBug.id_bug = Convert.ToInt32(row["id_bug"].ToString());
            oBug.titulo = row["titulo"].ToString();
            oBug.descripcion = row["descripcion"].ToString();
            oBug.fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString());
            oBug.id_producto = Convert.ToInt32(row["id_producto"].ToString());
            oBug.id_prioridad = Convert.ToInt32(row["id_prioridad"].ToString());
            oBug.id_criticidad = Convert.ToInt32(row["id_criticidad"].ToString());
            oBug.n_producto = row["nombre"].ToString();
            oBug.n_criticidad = row["n_criticidad"].ToString();
            oBug.n_prioridad = row["n_prioridad"].ToString();
            oBug.n_estado = row["n_estado"].ToString();

            return oBug;
        }

        public bool crearBug(Bug bug)
        {
            DataManager dm = new DataManager();
            try
            {
                //Abrimos una Conexión
                dm.Open();

                //INICIAMOS LA TRANSACCION
                dm.BeginTransaction();

                string insertBug = "INSERT INTO Bugs (titulo, descripcion, id_producto, id_prioridad, id_criticidad, id_estado, fecha_alta)" +
                            " VALUES (@titulo, @descripcion, @id_producto, @id_prioridad, @id_criticidad, @id_estado, GETDATE()) ;";

                List<SqlParameter> paramBug = new List<SqlParameter>();
                paramBug.Add(new SqlParameter("id_bug", bug.id_bug));
                paramBug.Add(new SqlParameter("titulo", bug.titulo));
                paramBug.Add(new SqlParameter("descripcion", bug.descripcion));
                paramBug.Add(new SqlParameter("id_producto", bug.id_producto));
                paramBug.Add(new SqlParameter("id_prioridad", bug.id_prioridad));
                paramBug.Add(new SqlParameter("id_criticidad", bug.id_criticidad));
                paramBug.Add(new SqlParameter("id_estado", bug.id_estado));

                dm.EjecutarSQL(insertBug, paramBug);

                string insertHistorico = " INSERT INTO BugsHistorico (id_bug, titulo, descripcion, id_producto, id_prioridad, id_criticidad, id_responsable, id_estado, fecha_historico) " +
                       " VALUES(@@IDENTITY, @titulo, @descripcion, @id_producto, @id_prioridad, @id_criticidad, @id_responsable, @id_estado, GETDATE()) ;";

                //Obtenemos el primer registro del historial para insertar en la tabla de historial
                HistorialBug historial = bug.historial.First();
                List<SqlParameter> paramHistorico = new List<SqlParameter>();
                paramHistorico.Add(new SqlParameter("titulo", bug.titulo));
                paramHistorico.Add(new SqlParameter("descripcion", bug.descripcion));
                paramHistorico.Add(new SqlParameter("id_producto", bug.id_producto));
                paramHistorico.Add(new SqlParameter("id_prioridad", bug.id_prioridad));
                paramHistorico.Add(new SqlParameter("id_criticidad", bug.id_criticidad));
                paramHistorico.Add(new SqlParameter("id_responsable", historial.responsable));
                paramHistorico.Add(new SqlParameter("id_estado", bug.id_estado));

                dm.EjecutarSQL(insertHistorico, paramHistorico);

                dm.Commit();
                return true;
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
        }

    }
}



