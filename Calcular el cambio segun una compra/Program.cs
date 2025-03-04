using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_el_cambio_segun_una_compra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<primary>
            ///Abraham Rodriguez
            /// 20230129
            /// </primary>

            double precio, dinero, vuelto;
            Console.WriteLine("Cual es el precio de los productos en total:");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto es el dinero que se dio:");
            dinero = double.Parse(Console.ReadLine());  
            vuelto = precio - dinero;
            Console.WriteLine("El vuelto en total de la compra es: ${0}\n", vuelto);
            Console.ReadKey();
        }
    }
}
