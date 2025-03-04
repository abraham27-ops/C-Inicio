using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir__dolares_a_pesos_mexicanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<primary>
            ///Abraham Rodriguez
            /// 20230129
            /// </primary>

            double dolares, pesosmx, multiplicacion;
            Console.WriteLine("Pon la cantidad de dolares a convertir");
            dolares=double.Parse(Console.ReadLine());
            multiplicacion = dolares * 18;
                Console.WriteLine("El total de pesos mexicanos es: {0}\n", multiplicacion);
            Console.ReadKey();
        }
    }
}
