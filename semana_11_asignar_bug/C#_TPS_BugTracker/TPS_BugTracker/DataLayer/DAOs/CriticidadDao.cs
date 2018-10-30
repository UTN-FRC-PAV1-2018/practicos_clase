using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;

namespace TPS_BugTracker.DataLayer.DAOs
{
    class CriticidadDao
    {
        public List<Criticidad> getAll()
        {
            List<Criticidad> lst = new List<Criticidad>();
            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL("Select * from Criticidades").Rows)
                lst.Add(map(row));
            return lst;
        }

        private Criticidad map(DataRow row)
        {
            Criticidad oCriticidad = new Criticidad();
            oCriticidad.id_criticidad = Convert.ToInt32(row["id_criticidad"].ToString());
            oCriticidad.nombre = row["n_criticidad"].ToString();
            return oCriticidad;
        }
    }
}
