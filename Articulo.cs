using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6_ad_tek
{
    public class Articulo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }

        public Articulo(int id, string nombre, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
