using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_de_un_cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<primary>
            ///Abraham Rodriguez
            /// 20230129
            /// </primary>

            double lado, perimetro;
            Console.WriteLine("Ingresa el valor del lado");
            lado = double.Parse(Console.ReadLine());
            perimetro = lado * 4;
            Console.WriteLine("El perimetro de tu cuadrado es: {0}\n", perimetro);
            Console.ReadKey();
        }
    }
}
