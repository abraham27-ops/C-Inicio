using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Abraham Rodriguez
            /// 20230129
            /// </summary>
            double baase, altura, area;
            Console.WriteLine("Ingrese el valor de la base:");
            baase= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura:");
            altura= double.Parse(Console.ReadLine());   
            area=baase*altura;
            Console.WriteLine("La area es: {0}", area);
            Console.ReadKey();


        }
    }
}
