using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6_ad_tek
{
    public class Registro
    {
        public int id { get; set; }
        public Articulo articulo { get; set; }
        public int cantidad { get; set; }

        public Registro(int id, Articulo articulo, int cantidad)
        {
            this.id = id;
            this.articulo = articulo;
            this.cantidad = cantidad;
        }

        public double Total()
        {
            return cantidad * articulo.precio;
        }
    }
}
