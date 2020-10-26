using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "SUCECIÓN MATÉMATICA";
            Console.Clear();
            double a, b=0;
            int i,x;
            Console.WriteLine("Seleccione el ultimo 'n' de la suceción");
            x = int.Parse(Console.ReadLine());
            for (i = 1; i <= x; i=i+2)
            {
                a = (i / Math.Pow(2, i)) - ((i + 1) / Math.Pow(2, (i + 1)));
                b+=a;
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
