using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Ejercicio de raiz de los primeros 10 números enteros";
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\t\tRaices cuadradas de los primeros 10 números enteros");
            Raiz();
            Console.WriteLine("\n");
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();
        }

        static void Raiz()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\tCalculando raices...");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("\tLa raíz cuadrada del número {0} es {1} ",i,Math.Sqrt(i));
            }

        }
    }
}
