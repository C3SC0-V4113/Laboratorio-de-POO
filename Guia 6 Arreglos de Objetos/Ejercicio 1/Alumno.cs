using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Alumno
    {
        //ATRIBUTOS
        string carnet;
        string nombre;
        string materia;
        string apellido;
        decimal n1;
        decimal n2;
        decimal prom;

        //METODOS
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

        public decimal Nota1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public decimal Nota2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public decimal Promedio
        {
            get
            {
                prom = ((n1 + n2) / 2);
                return prom;
            }
            set { prom = value; }
        }
    }
}
