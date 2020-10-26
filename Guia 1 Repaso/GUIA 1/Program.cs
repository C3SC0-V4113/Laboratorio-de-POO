using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA_1
{
    class Program
    {
        //Prototipo de función
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Ejercicio de potencia con funciones";
            Console.Clear();
            double x;
            for(x=1;x<=10;x++)
            {
                Console.WriteLine("\nEl cuadrado del número {0} es {1}",x,Potencia(x));
            }
            Console.ReadKey();
        }

        static double Potencia(double x)
        {
            return x * x;
        }
    }
}
