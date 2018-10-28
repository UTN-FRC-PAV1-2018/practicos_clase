using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.DataLayer.DAOs;

namespace TPS_BugTracker.BusinessLayer.Services
{
    class EstadoService
    {
        private EstadoDao oEstadoDao;
        public EstadoService()
        {
            oEstadoDao = new EstadoDao();
        }

        public List<Estado> consultarEstados()
        {
            return oEstadoDao.getAll();
        }
    }
}
