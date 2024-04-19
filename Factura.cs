using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6_ad_tek
{
    internal class Factura
    {
        public int id { get; set; }
        public Registro[] registros { get; set; }

        public Factura(int id, Registro[] registros)
        {
            this.id = id;
            this.registros = registros;
        }

        public string EmitirFactura()
        {
            string detalle = "";
            double total = 0;

            foreach (Registro registro in registros)
            {
                detalle += registro.articulo.nombre + " x " + registro.cantidad + " = " + registro.Total() + "\n";
                total += registro.Total();
            }

            detalle += "----------------------------" + "\n";

            double descuento = retornarDescuento(total);

            if (descuento > 0)
            {
                detalle += "Desc: " + descuento + "\n";
            }

            detalle += "Total: " + (total - descuento);

            return detalle;
        }

        private double retornarDescuento(double total)
        {
            if (total > 1000)
            {
                return total * .15;
            }

            return 0;
        }


    }
}
