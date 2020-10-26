using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    class Alumno
    {
        string carnet;
        string nombre;
        string materia;
        string apellido;
        float[] calificaciones = new float[3];
        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public float[] Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }

        //Métodos
        public void ingresardatos()
        {
            Console.WriteLine("\n Ingrese el carnet del estudiante");
            carnet = Console.ReadLine();
            Console.WriteLine("\n Ingrese el nombre del estudiante");
            nombre = Console.ReadLine();
            Console.WriteLine("\n Ingrese el apellido del estudiante");
            apellido = Console.ReadLine();
            Console.WriteLine("\n Ingrese la materia del estudiante");
            materia = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nIngrese la nota {0} de la materia {1} del estudiante {2}:", i + 1, materia, nombre);
               
                calificaciones[i] = float.Parse(Console.ReadLine());
            }

        }

        public void mostrar()
        {
            float acumula = 0;
            Console.WriteLine("\nEl alumno: " + Nombre + " " + Apellido + " con carnet " + Carnet);
            Console.WriteLine("\n Está cursando la materia " + Materia);
            Console.WriteLine("\n Sus notas en esta asignatura son:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(calificaciones[i] + " ");
                acumula = calificaciones[i] + acumula;
            }
            float promedio = acumula / calificaciones.Length;
            Console.WriteLine("\n\n Y su promedio es: " + promedio);
            Console.WriteLine("\n\n ---------------------------------");
        }
    }
}
