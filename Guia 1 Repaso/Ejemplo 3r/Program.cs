﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "CONVERSOR DE TEMPERATURAS RELATIVAS";
            Console.Clear();
            {
                ConsoleKeyInfo op;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tMenú\n");
                    Console.WriteLine("\t\t[F]De Celcius a Fahrenheit");
                    Console.WriteLine("\t\t[C]De Fahrenheit a Celcius");
                    Console.WriteLine("\t\t[Esc]Salir");
                    Console.WriteLine("\n");
                    Console.WriteLine("\tSeleccione la opcion deseada...");
                    op = Console.ReadKey(true);
                    switch (op.Key)
                    {
                        case ConsoleKey.F:
                            Faren();
                            break;
                        case ConsoleKey.C:
                            Celcius();
                            break;
                        case ConsoleKey.Escape:
                            break;
                        default:
                            Console.WriteLine("Codigo invalido...");
                            Console.ReadKey();
                            break;
                    }
                } while (op.Key != ConsoleKey.Escape);
            }
        }

        static void Faren()
        {
            Console.Clear();
            double cel, faren;
            Console.WriteLine("\n");
            Console.WriteLine("\tEscribe los grados Celcius: ");
            cel = double.Parse(Console.ReadLine());
            faren = cel * 9 / 5 + 32;
            Console.WriteLine("\n\t{0}° Grados Celcius son {1}° grados Fahrenheit", cel, faren);
            Console.ReadKey();
        }

        static void Celcius()
        {
            Console.Clear();
            double cel, faren;
            Console.WriteLine("\n");
            Console.WriteLine("\tEscribe los grados Fahrenheit: ");
            faren = double.Parse(Console.ReadLine());
            cel = (faren - 32) * 5 / 9;
            Console.WriteLine("\n\t{0}° Grados Fahrenheit son {1}° grados Celcius", faren, cel);
            Console.ReadKey();
        }
    }
}
