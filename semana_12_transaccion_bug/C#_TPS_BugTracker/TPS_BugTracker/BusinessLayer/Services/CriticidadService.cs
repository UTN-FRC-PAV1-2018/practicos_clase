using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.DataLayer.DAOs;

namespace TPS_BugTracker.BusinessLayer.Services
{
    class CriticidadService
    {
        private CriticidadDao oCriticidadDao;
        public CriticidadService()
        {
            oCriticidadDao = new CriticidadDao();
        }

        public List<Criticidad> consultarCriticidades()
        {
            return oCriticidadDao.getAll();
        }
    }
}
