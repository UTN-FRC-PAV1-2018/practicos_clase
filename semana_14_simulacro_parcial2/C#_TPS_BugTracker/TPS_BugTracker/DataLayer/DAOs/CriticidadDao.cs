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
            DataManager dm = new DataManager();

            try
            {
                dm.Open();

                foreach (DataRow row in dm.ConsultaSQL("Select * from Criticidades").Rows)
                    lst.Add(map(row));
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
