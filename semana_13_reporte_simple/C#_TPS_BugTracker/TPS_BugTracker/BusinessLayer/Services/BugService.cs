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

        public bool crearBug(Bug oBug)
        {
            return oBugDao.create(oBug);
        }

        public bool pasarATesting(Bug oBug)
        {
            HistorialBug historial = new HistorialBug();
            historial.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario;
            historial.estado = 4;
            historial.fecha = DateTime.Now;

            oBug.addHistorial(historial);
            return oBugDao.update(oBug);
        }


        public bool cerrar(Bug oBug)
        {
            HistorialBug historial = new HistorialBug();
            historial.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario;
            historial.estado = 3;
            historial.fecha = DateTime.Now;

            oBug.addHistorial(historial);
            return oBugDao.update(oBug);
        }

    }
}
