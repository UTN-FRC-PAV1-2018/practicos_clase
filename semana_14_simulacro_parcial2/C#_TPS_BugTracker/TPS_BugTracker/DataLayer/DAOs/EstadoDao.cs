using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;

namespace TPS_BugTracker.DataLayer.DAOs
{
    class EstadoDao
    {
        public List<Estado> getAll()
        {
            List<Estado> lst = new List<Estado>();
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                foreach (DataRow row in dm.ConsultaSQL("Select * from Estados").Rows)
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

        private Estado map(DataRow row)
        {
            Estado oEstado = new Estado();
            oEstado.id_estado = Convert.ToInt32(row["id_Estado"].ToString());
            oEstado.nombre = row["n_estado"].ToString();
            return oEstado;
        }
    }
}
