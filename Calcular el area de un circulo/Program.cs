using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_el_area_de_un_circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<primary>
            ///Programa que calcula el area de un cirulo
            /// utilizando el metodo Math() de la libreria System
            /// </primary>

            double area, radio;
            const double PI = 3.1416;
                Console.WriteLine("Este programa calcula el area de un circulo");
            Console.Write("Presiona una tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine("Ingresa el valor del radio en centimetros");
            radio = double.Parse(Console.ReadLine());
            area = (Math.Pow(radio, 2) * PI);
            Console.WriteLine("El resultado del area es: {0} centimetros cuadrados",area);
            Console.Write("Presiona una tecla para cerrar el programa");
            Console.ReadKey();
        }
    }
}
