using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Nombre de proyecto: Calculadora Operaciones basicas
            /// Nombre:Abraham Rodriguez
            /// Codigo: 20230129
            /// </summary>
            
            // Declaro las variables de tipo doble o real
            double numero_uno, numero_dos, suma, resta, multiplicacion;
            Console.WriteLine("Ingresa el valor del primer numero");
            numero_uno = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del segundo numero");
            numero_dos = double.Parse(Console.ReadLine());
            suma=numero_uno+numero_dos;
            resta=numero_uno-numero_dos;
            multiplicacion = numero_uno * numero_dos;
            Console.WriteLine("La suma es: {0}\n La resta es: {1}\n La multiplicacion es: {2}",suma, resta, multiplicacion);
            Console.ReadKey();
        }
    }
}
