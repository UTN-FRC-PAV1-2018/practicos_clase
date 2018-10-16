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
    class HistorialBugDao
    {
        public List<HistorialBug> getById(int id)
        {
            DataManager dm = new DataManager();
            List<HistorialBug> list = new List<HistorialBug>();
            try
            {
                dm.Open();
                string sql = " SELECT h.*, e.n_estado, resp.n_usuario as n_responsable, asig.n_usuario as n_asignado_a" +
                    "   FROM Historiales_Bug h " + "   INNER JOIN estados e ON h.id_estado = e.id_estado " +
                    "   LEFT JOIN users resp  ON h.responsable = resp.id_usuario" +
                    "   LEFT JOIN users asig  ON h.asignado_a = asig.id_usuario" +
                    "   WHERE h.id_bug =" + id.ToString();

                foreach (DataRow detail in dm.ConsultaSQL(sql).Rows)
                {
                    list.Add(mapBug(detail));
                }
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

            return list;
        }

        private HistorialBug mapBug(DataRow detail)
        {
            HistorialBug oHistorial_bug = new HistorialBug();
            oHistorial_bug.id_detalle = Convert.ToInt32(detail["id_detalle"].ToString());
            oHistorial_bug.responsable = Convert.ToInt32(detail["responsable"].ToString());

            if (!Convert.IsDBNull(detail["asignado_a"]))
            {
                oHistorial_bug.asignado_a = Convert.ToInt32(detail["asignado_a"].ToString());
                oHistorial_bug.n_asignado_a = detail["n_asignado_a"].ToString();
            }

            oHistorial_bug.estado = Convert.ToInt32(detail["id_estado"].ToString());
            oHistorial_bug.fecha = Convert.ToDateTime(detail["fecha"].ToString());
            oHistorial_bug.n_responsable = detail["n_responsable"].ToString();
            oHistorial_bug.n_estado = detail["n_estado"].ToString();


            return oHistorial_bug;
        }


        public bool create(int idBug, HistorialBug historial)
        {
            DataManager dm = new DataManager();

            List<HistorialBug> list = new List<HistorialBug>();
            try
            {
                dm.Open();
                string sql = " INSERT INTO Historiales_Bug(id_bug, id_detalle, fecha, responsable, id_estado, asignado_a) " +
                            "    VALUES(@id_bug,@id_detalle, @fecha ,@responsable,@id_estado,@asignado_a)";

                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("id_bug", idBug));
                parametros.Add(new SqlParameter("id_detalle", historial.id_detalle));
                parametros.Add(new SqlParameter("fecha", historial.fecha));
                parametros.Add(new SqlParameter("responsable", historial.responsable));
                parametros.Add(new SqlParameter("id_estado", historial.estado));
                parametros.Add(new SqlParameter("asignado_a", historial.asignado_a));

                dm.EjecutarSQL(sql, parametros);

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
    }
}
