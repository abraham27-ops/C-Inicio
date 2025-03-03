using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_primer_programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este es un comentario de una linea
            /*
             Mi nombre es : Abraham Rodriguez
             y este es un comentario de multiples lineas 

             */
            //Declaro variable de la siguiente manera 
            //Tipo de dato: <nombre de la variable>
            string texto;
            //El tipo de dato string me sirve para guardar informacion de tipo caracter 

            Console.WriteLine("Digita un texto");
                // En Pseint es como decir "Escribir"
                texto=Console.ReadLine();
            //Esto es como decir "leer texto"
            Console.WriteLine("El texto que escribiste es:\n" + texto);
            //readkey sirve para hacer una espera y presione una tecla para cerrar el programa, o hacer un br de (HTML)
            Console.ReadKey();
            //El simbolo + sirve para concatenar informacion

            string nombre, apellido;
            Console.WriteLine("Di tu nombre");
            nombre = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Di tu apellido");
            apellido = Console.ReadLine();
            Console.ReadKey();

                Console.WriteLine("Tu nombre es:\n"+nombre+" "+ apellido);
            Console.ReadKey();
        }
    }
}
