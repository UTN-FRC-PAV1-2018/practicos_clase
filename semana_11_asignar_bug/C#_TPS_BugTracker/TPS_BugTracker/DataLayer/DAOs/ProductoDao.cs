using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPS_BugTracker.BusinessLayer.Entities;

namespace TPS_BugTracker.DataLayer.DAOs
{
    class ProductoDao
    {
        public List<Producto> getAll()
        {
            List<Producto> lst = new List<Producto>();
            Producto oProducto = null/* TODO Change to default(_) if this is not a reference type */;

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQL("Select * from Productos").Rows)
                lst.Add(map(row));

            return lst;
        }

        private Producto map(DataRow row)
        {
            Producto oProducto = new Producto();
            oProducto.id_Producto = Convert.ToInt32(row["id_producto"].ToString());
            oProducto.nombre = row["nombre"].ToString();
            return oProducto;
        }
    }
}
