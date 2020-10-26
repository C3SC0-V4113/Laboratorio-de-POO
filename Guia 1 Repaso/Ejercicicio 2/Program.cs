using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "PESO DE LOS ALUMNOS DE LABORATORIO";
            Console.Clear();
            int i=0,count=0,Op;
            double suma=0,a;
            IList<double> intList = new List<double>();
            do
            {
                Console.Clear();
                Console.Write("\n\t\t\tEscriba el peso de un alumno en libras: ");
                a = double.Parse(Console.ReadLine());
                intList.Add(a);
                Console.WriteLine("\n\t\tEscriba 1 si desea dejar de agregar alumnos, y escriba 0 si desea continuar");
                Op = int.Parse(Console.ReadLine());
                suma =suma+a;
                if(Op==1)
                {
                    i = 1;
                }
            } while (i != 1);

            Console.Clear();
            foreach(double element in intList)
            {
                count++;
            }

            double[] peso = new double[count];
            for(int y=0;y<count;y++)
            {
                peso[y] = intList[y];
            }
           
            Console.WriteLine("\n\t\t\tLos pesos son:");
            for (int y = 0; y <count; y++)
            {
                Console.WriteLine("\n\t\tPeso del alumno {0} es de {1} libras", (y+1),peso[y]);
            }
            Console.WriteLine("\n\t\t\tLas libras totales entre todos los alumnos es de {0} libras",suma);
            Console.ReadKey();
        }
    }
}
