using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;

namespace TPS_BugTracker.DataLayer.DAOs
{
    class PerfilDao
    {
        public List<Perfil> getAll()
        {
            List<Perfil> lst = new List<Perfil>();
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                foreach (DataRow row in dm.ConsultaSQL("Select * from Perfiles").Rows)
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

        private Perfil map(DataRow row)
        {
            Perfil Perfil = new Perfil();
            Perfil.id_perfil = Convert.ToInt32(row["id_perfil"].ToString());
            Perfil.nombre = row["n_perfil"].ToString();
            return Perfil;
        }
    }
}
