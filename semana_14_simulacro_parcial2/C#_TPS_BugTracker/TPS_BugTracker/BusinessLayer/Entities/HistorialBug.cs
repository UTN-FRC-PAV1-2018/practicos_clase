using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_BugTracker.BusinessLayer.Entities
{
    public class HistorialBug
    {
        public int id_detalle { get; set; }
        public int responsable { get; set; }
        // Nombre del usuario responsable de generar el historial del bug
        public string n_responsable { get; set; }
        public DateTime fecha { get; set; }
        public int asignado_a { get; set; }
        // Nombre del usuario asignado a resolver el bug en el historial
        public string n_asignado_a { get; set; }
        public int estado { get; set; }
        // Nombre del estado
        public string n_estado { get; set; }
    }

}
