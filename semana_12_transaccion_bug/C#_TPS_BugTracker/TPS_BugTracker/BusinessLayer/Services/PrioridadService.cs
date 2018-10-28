using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.DataLayer.DAOs;

namespace TPS_BugTracker.BusinessLayer.Services
{
    class PrioridadService
    {
        private PrioridadDao oPrioridadDao;
        public PrioridadService()
        {
            oPrioridadDao = new PrioridadDao();
        }

        public List<Prioridad> consultarPrioridades()
        {
            return oPrioridadDao.getAll();
        }
    }
}
