using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_de_dias_a_segundos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<primary>
            ///Abraham Rodriguez
            /// 20230129
            /// </primary>

            double dias, segundos, conversion;
            Console.WriteLine("Ingrese la cantidad de dias a convertir");
            segundos = double.Parse(Console.ReadLine());
            conversion = segundos * 86400;
                Console.WriteLine("Los segundos totales son: {0}\n", conversion);
            Console.ReadKey();
        }
    }
}
