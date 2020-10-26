using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Menú
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "MENÚ DE OPCIONES MATEMATICAS";
            Console.Clear();
            {
                ConsoleKeyInfo op;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t\tMenú\n");
                    Console.WriteLine("\t\t[A]DIVIDIR DOS NÚMEROS");
                    Console.WriteLine("\t\t[B]EL CUBO DE UN NÚMERO");
                    Console.WriteLine("\t\t[C]CALCULO DE IMC");
                    Console.WriteLine("\t\t[D]Salir");
                    Console.WriteLine("\n");
                    Console.WriteLine("\tSeleccione la opcion deseada...");
                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        case ConsoleKey.A:
                            Division();
                            break;
                        case ConsoleKey.B:
                            Cubo();
                            break;
                        case ConsoleKey.C:
                            IMC();
                            break;
                        case ConsoleKey.D:
                            break;
                        default:
                            Console.WriteLine("Codigo invalido...");
                            Console.ReadKey();
                            break;
                    }
                } while (op.Key != ConsoleKey.D);
            }
        }

        static void Division()
        {
            Console.Clear();
            double a, b, c;
            Console.Write("\n\t\tEscriba el número que dividira: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\t\tEscriba el número por el cual dividira: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if(b==0)
            {
                Console.WriteLine("\tEl resultado es infinito, o indefinido");
            }
            else
            {
                c = a / b;
                Console.WriteLine("\tEl resultado de la division es {0}", c);
            }
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        static void Cubo()
        {
            Console.Clear();
            double a,b;
            Console.Write("\n\t\tEscriba el número que se elevara al cubo: ");
            a = double.Parse(Console.ReadLine());
            b = Math.Pow(a, 3);
            Console.WriteLine("\n\tEl número elevado al cubo es {0}", b);
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }

        static void IMC()
        {
            Console.Clear();
            double a, b,c;
            Console.Write("\n\t\tEscriba su peso en Kilogramos: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("\n\t\tEscriba su altura en Metros: ");
            b = double.Parse(Console.ReadLine());
            c = a / Math.Pow(b, 2);
            Console.WriteLine("\n\tSu IMC es de {0}", c);
            Console.WriteLine("\nPulse cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}
