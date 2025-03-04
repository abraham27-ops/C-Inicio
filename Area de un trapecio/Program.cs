using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_trapecio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<primary>
            ///Abraham Rodriguez
            /// 20230129
            /// </primary>

            double area, Base, bAse, altura;
            Console.WriteLine("Ingrese la medida de la base mayor:");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la base menor:");
            bAse = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la medida de la altura:");
            altura = double.Parse(Console.ReadLine());
            area = ((Base + bAse) * altura) / 2;
            Console.WriteLine("El area del trapecio es:{0}\n", area);
            Console.ReadKey();
        }
    }
}
