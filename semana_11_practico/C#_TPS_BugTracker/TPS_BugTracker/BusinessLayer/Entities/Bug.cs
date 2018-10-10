using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_BugTracker.BusinessLayer.Entities
{
    public class Bug
    {

        public int id_bug { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int id_producto { get; set; }
        // Nombre producto
        public string n_producto { get; set; }
        public int id_prioridad { get; set; }
        // Nombre prioridad
        public string n_prioridad { get; set; }
        public int id_criticidad { get; set; }
        // Nombre criticidad
        public string n_criticidad { get; set; }
        // Nombre del último estado o estado actual del bug
        public string estado { get; set; }
        // Fecha de alta o fecha de creación. 
        public DateTime fecha_alta { get; set; }
        public string asignado_a { get; set; }

        public List<HistorialBug> historial { get; set; }

        public Bug()
        {
            historial = new List<HistorialBug>();
        }

        public void addHistorial(HistorialBug oHistorialBug)
        {
            historial.Add(oHistorialBug);
        }
    }
}
