

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

namespace TPS_BugTracker.DataLayer.DAOs
{
    public class BugDao
    {
        public Bug getBugById(int id)
        {
            string sql = "SELECT * FROM ( SELECT " +
                "t.id_bug," +
                "t.titulo," +
                "t.descripcion," +
                "t.id_producto," +
                "t.id_prioridad," +
                "t.fecha_alta," +
                "t.id_criticidad," +
                "t2.nombre," +
                "t4.n_prioridad," +
                "t5.n_criticidad," +
                "(SELECT n_estado FROM Estados e, Historiales_Bug h WHERE e.id_estado = h.id_estado AND h.id_bug = t.id_bug AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as estado," + "(SELECT n_usuario FROM Historiales_Bug h, users u WHERE h.id_bug = t.id_bug AND h.id_estado = 2 AND h.asignado_a = u.id_usuario AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as asignado_a " + " FROM bugs t, Productos t2, Prioridades t4, Criticidades t5" +
                " WHERE(t.id_producto = t2.id_producto)" +
                " AND t.id_prioridad = t4.id_prioridad" +
                " AND t.id_criticidad = t5.id_criticidad" +
                " AND t.id_bug =" + id.ToString() + " ) as t_bugs";


            return mapBug(BDHelper.getBDHelper().ConsultaSQL(sql).Rows[0]);
        }

        public IList<Bug> getBugByFilters(List<object> parametros)
        {
            List<Bug> lst = new List<Bug>();

            string sql = "SELECT * FROM (" +
                "               SELECT  TOP 20 " +
                "                       t.id_bug," + "t.titulo," + "t2.nombre," +
                "                       t.fecha_alta," + "t4.n_prioridad," +
                "                       t5.n_criticidad," +
                "                       (SELECT n_estado FROM Estados e, Historiales_Bug h WHERE e.id_estado = h.id_estado AND h.id_bug = t.id_bug AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as estado," +
                "(SELECT n_usuario FROM Historiales_Bug h, users u WHERE h.id_bug = t.id_bug AND h.id_estado = 2 AND h.asignado_a = u.id_usuario AND h.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug h1 WHERE h1.id_bug = h.id_bug)) as asignado_a " +
                " FROM bugs t, Productos t2, Prioridades t4, Criticidades t5" +
                " WHERE t.id_producto = t2.id_producto" +
                "   AND t.id_prioridad = t4.id_prioridad" +
                "   AND t.id_criticidad = t5.id_criticidad ";

            // Validamos filtro de fechas
            if (parametros[0] != null && parametros[1] != null)
                sql += " AND (t.fecha_alta>=@param1 AND t.fecha_alta<=@param2) ";
            // Validamos filtro prioridad
            if (parametros[2] != null)
                sql += "AND t.id_prioridad=@param3 ";
            // Validamos filtro criticidad
            if (parametros[3] != null)
                sql += "AND t.id_criticidad=@param4 ";
            // Validamos filtro producto
            if (parametros[4] != null)
                sql += "AND t.id_producto=@param5 ";
            
            // Validamos filtro estado al final del query porque al ser una columna SELECT dentro de la consulta principal
            // La validamos luego de armar consulta completa para hacer un segundo WHERE ahora si por estado.
            if (parametros[5] != null)
                sql += " AND estado=@param6 ";
            // Con el mismo criterio validamos filtro asignado_a
            if (parametros[6] != null)
                sql += " AND asignado_a=@param7 ";

            sql += "ORDER BY t.fecha_alta DESC) as t_bugs WHERE 1=1";
            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQLConParametros(sql, parametros).Rows)
                lst.Add(mapSmallBug(row));

            return lst;
        }





        private Bug mapSmallBug(DataRow row)
        {
            Bug oBug = new Bug();

            oBug.id_bug = Convert.ToInt32(row["id_bug"].ToString());
            oBug.titulo = row["titulo"].ToString();
            oBug.fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString());
            oBug.n_producto = row["nombre"].ToString();
            oBug.estado = row["estado"].ToString();
            oBug.asignado_a = row["asignado_a"].ToString();
            oBug.n_prioridad = row["n_prioridad"].ToString();
            oBug.n_criticidad = row["n_criticidad"].ToString();

            return oBug;
        }

        private Bug mapBug(DataRow row)
        {
            Bug oBug = new Bug();
            string sql;
            HistorialBug oHistorial_bug;

            oBug.id_bug = Convert.ToInt32(row["id_bug"].ToString());
            oBug.titulo = row["titulo"].ToString();
            oBug.descripcion = row["descripcion"].ToString();
            oBug.fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString());
            oBug.id_producto = Convert.ToInt32(row["id_producto"].ToString());
            oBug.id_prioridad = Convert.ToInt32(row["id_prioridad"].ToString());
            oBug.id_criticidad = Convert.ToInt32(row["id_criticidad"].ToString());
            oBug.n_producto = row["nombre"].ToString();
            oBug.n_criticidad = row["n_criticidad"].ToString();
            oBug.estado = row["estado"].ToString();

            sql = "SELECT h.*, e.n_estado, u.n_usuario n_responsable, (SELECT TOP 1 n_usuario FROM Users t1 LEFT JOIN Historiales_Bug t2 ON t1.id_usuario = t2.asignado_a WHERE t2.id_bug = h.id_bug) as n_asignado_a FROM Historiales_Bug h, estados e, users u WHERE(h.id_estado = e.id_estado) AND h.responsable = u.id_usuario AND h.id_bug =" + oBug.id_bug.ToString();


            foreach (DataRow detail in BDHelper.getBDHelper().ConsultaSQL(sql).Rows)
            {
                oHistorial_bug = new HistorialBug();
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
                oBug.addHistorial(oHistorial_bug);
            }

            return oBug;
        }
    }

}