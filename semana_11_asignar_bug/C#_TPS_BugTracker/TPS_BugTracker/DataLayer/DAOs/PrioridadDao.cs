using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;

namespace TPS_BugTracker.DataLayer.DAOs
{
    class PrioridadDao
    {
        public List<Prioridad> getAll()
        {
            List<Prioridad> lst = new List<Prioridad>();
            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL("Select * from Prioridades").Rows)
                lst.Add(map(row));
            return lst;
        }

        private Prioridad map(DataRow row)
        {
            Prioridad oPrioridad = new Prioridad();
            oPrioridad.id_prioridad = Convert.ToInt32(row["id_prioridad"].ToString());
            oPrioridad.nombre = row["n_prioridad"].ToString();
            return oPrioridad;
        }
    }
}
