

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

namespace TPS_BugTracker.DataLayer.DAOs
{
    public class BugDao
    {
        private HistorialBugDao oHistorialBug = new HistorialBugDao();

        public Bug getBugById(int id)
        {
            string sql = "   SELECT TOP 20 bug.id_bug, bug.titulo, bug.descripcion, pro.nombre, bug.fecha_alta, n_estado as estado, usr.n_usuario as asignado_a, n_prioridad, cri.n_criticidad, pro.id_producto, pri.id_prioridad, cri.id_criticidad" +
                "   FROM  bugs bug" +
                "   INNER JOIN Historiales_Bug his ON bug.id_bug = his.id_bug" +
                "   INNER JOIN Estados est ON his.id_estado = est.id_estado" +
                "   LEFT JOIN Users usr ON his.asignado_a = usr.id_usuario" +
                "   INNER JOIN Productos pro ON bug.id_producto = pro.id_producto" +
                "   INNER JOIN Prioridades pri ON bug.id_prioridad = pri.id_prioridad" +
                "   INNER JOIN Criticidades cri ON bug.id_criticidad = cri.id_criticidad" +
                "   WHERE his.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug his2 WHERE bug.id_bug = his2.id_bug)" +
                "         AND bug.id_bug = " + id.ToString();

            Bug bug = mapBug(BDHelper.getBDHelper().ConsultaSQL(sql).Rows[0]);
            bug.historial.AddRange(oHistorialBug.getById(bug.id_bug));
            return bug;
        }

        public IList<Bug> getBugByFilters(List<object> parametros)
        {
            List<Bug> lst = new List<Bug>();
            string sql = "   SELECT TOP 20 bug.id_bug, bug.titulo, bug.descripcion, pro.nombre, bug.fecha_alta, n_estado as estado, usr.n_usuario as asignado_a, n_prioridad, cri.n_criticidad" +
                "   FROM  bugs bug" +
                "   INNER JOIN Historiales_Bug his ON bug.id_bug = his.id_bug" +
                "   INNER JOIN Estados est ON his.id_estado = est.id_estado" +
                "   LEFT JOIN Users usr ON his.asignado_a = usr.id_usuario" +
                "   INNER JOIN Productos pro ON bug.id_producto = pro.id_producto" +
                "   INNER JOIN Prioridades pri ON bug.id_prioridad = pri.id_prioridad" +
                "   INNER JOIN Criticidades cri ON bug.id_criticidad = cri.id_criticidad" +
                "   WHERE his.id_detalle = (SELECT MAX(id_detalle) FROM Historiales_Bug his2 WHERE bug.id_bug = his2.id_bug)";

            if (parametros[0] != null && parametros[1] != null)
                sql += " AND (bug.fecha_alta>=@param1 AND bug.fecha_alta<=@param2) ";
            if (parametros[2] != null)
                sql += "AND bug.id_prioridad=@param3 ";
            if (parametros[3] != null)
                sql += "AND bug.id_criticidad=@param4 ";
            if (parametros[4] != null)
                sql += "AND bug.id_producto=@param5 ";
            if (parametros[5] != null)
                sql += " AND his.id_estado=@param6 ";
            if (parametros[6] != null)
                sql += " AND his.asignado_a=@param7 ";
            sql += "ORDER BY bug.fecha_alta DESC";

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQLConParametros(sql, parametros).Rows)
            {
                Bug bug = mapSmallBug(row);
                bug.historial.AddRange(oHistorialBug.getById(bug.id_bug));
                lst.Add(bug);
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
            oBug.estado = row["estado"].ToString();
            oBug.asignado_a = row["asignado_a"].ToString();
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
            oBug.estado = row["estado"].ToString();

            return oBug;
        }

        public bool update(Bug oBugSelected)
        {
            string sql = " UPDATE bugs" +
                        "     SET titulo = @titulo," +
                        "         descripcion = @descripcion, " +
                        "         id_producto = @id_producto," +
                        "         id_prioridad = @id_prioridad," +
                        "         id_criticidad = @id_criticidad" +
                        "   WHERE id_bug = @id_bug;";

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_bug", oBugSelected.id_bug));
            parametros.Add(new SqlParameter("titulo", oBugSelected.titulo));
            parametros.Add(new SqlParameter("descripcion", oBugSelected.descripcion));
            parametros.Add(new SqlParameter("id_producto", oBugSelected.id_producto));
            parametros.Add(new SqlParameter("id_prioridad", oBugSelected.id_prioridad));
            parametros.Add(new SqlParameter("id_criticidad", oBugSelected.id_criticidad));
            
            BDHelper.getBDHelper().EjecutarSQL(sql, parametros);

            foreach (var item in oBugSelected.historial)
            {
                if (item.id_detalle == 0)
                {
                    item.id_detalle = oBugSelected.historial.Max(p=> p.id_detalle) ;
                    item.id_detalle++;
                    oHistorialBug.create(oBugSelected.id_bug, item);
                }
            }

            return true;
        }
    }

}