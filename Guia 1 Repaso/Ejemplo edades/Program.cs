using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_edades
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Title = "Calculo de edad";
                Console.Clear();
                Dias();
                Console.ReadKey();
        }

        static void Dias()
        {
            DateTime fechan, fechah;
            TimeSpan intervalo;
            int dias, años;
            //Escribir la primera fecha
            Console.WriteLine("\n");
            Console.Write("\tEscriba su fecha de nacimiento en formato (dd/mm/aa): ");
            fechan = DateTime.Parse(Console.ReadLine());
            //Leer de la propia computadora la fecha actual
            fechah = DateTime.Now;
            //Restar ambas fechas y convertirlas en entero, pero en formato de dias
            intervalo = fechah - fechan;
            dias = intervalo.Days;
            //Dividir el entero en 365(La cantidad de dias en un año)
            años = dias / 365;
            Console.WriteLine("\n");
            Console.WriteLine("\tTienes {0} años de vida",años);
        }
    }
}
