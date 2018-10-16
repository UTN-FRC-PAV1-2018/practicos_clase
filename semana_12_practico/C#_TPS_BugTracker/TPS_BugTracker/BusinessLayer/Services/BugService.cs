using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.DataLayer.DAOs;

namespace TPS_BugTracker.BusinessLayer.Services
{
    public class BugService
    {
        private BugDao oBugDao;
        private HistorialBugDao oHistorialBugDao;
        public BugService()
        {
            oBugDao = new BugDao();
            oHistorialBugDao = new HistorialBugDao();
        }
        public IList<Bug> consultarBugsConFiltros(List<object> @params)
        {
            return oBugDao.getBugByFilters(@params);
        }

        public Bug consultarBugsPorId(int id)
        {
            return oBugDao.getBugById(id);
        }

        public bool actualizarBug(Bug oBug)
        {
            return oBugDao.update(oBug);
        }
    }
}
