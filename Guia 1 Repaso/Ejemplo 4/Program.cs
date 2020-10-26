using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "SUELDO DE 5 SECRETARIAS";
            Console.Clear();
            double[] sueldos;
            sueldos = new double[5];
            for(int i=0;i<5;i++)
            {
                Console.Write("\n\t\t\tEl sueldo de la secretaria {0}: $", (i + 1));
                string Valor;
                Valor = Console.ReadLine();
                sueldos[i] = double.Parse(Valor);
            }
            Mostrar(sueldos);
            Console.ReadKey();
        }

        static void Mostrar(double[] sueldos)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n\t\tLos sueldos ingresados son: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\t$"+sueldos[i]);
            }
        }
    }
}
