using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6_ad_tek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo tenis = new Articulo(1, "Tenis Nike", 700);
            Articulo gorra = new Articulo(2, "Gorra", 200);
            
            Registro r1 = new Registro(1, tenis, 1);
            Registro r2 = new Registro(2, gorra, 1);

            Registro[] registros = { r1, r2 };
            
            Factura f = new Factura(1, registros);

            Console.WriteLine(f.EmitirFactura());
        }
    }
}
