using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS_BugTracker.BusinessLayer.Entities
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string estado { get; set; }
        public int id_usuario { get; set; }
        // Relación con Perfil
        public string id_perfil { get; set; }
        public string perfil { get; set; }
    }
}
