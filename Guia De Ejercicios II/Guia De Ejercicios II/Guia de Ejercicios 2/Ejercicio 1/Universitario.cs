using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Universitario:Estudiante
    {
        //ATRIBUTOS PROPIOS
        protected string nombreuniversidad;
        protected string carrera;
        protected string materia;
        protected double n1;
        protected double n2;
        protected double promedio;

        public string Nombreuniversidad
        {
            get => nombreuniversidad;
            set => nombreuniversidad = value;
        }
        public string Carrera
        {
            get => carrera;
            set => carrera = value;
        }
        public string Materia
        {
            get => materia;
            set => materia = value;
        }
        public double Promedio
        {
            get => promedio;
            set => promedio = value;
        }
        public double N1
        {
            get => n1;
            set => n1 = value;
        }
        public double N2
        {
            get => n2;
            set => n2 = value;
        }

        //METODOS PROPIOS
        public double CalcularProm(double no1, double no2)
        {
            promedio = (no1 + no2) / 2;
            return promedio;
        }

        //CONTRUCTOR CON PARAMETROS
        public Universitario(string nomb, string apell, string id, int ed, string carn, 
            string nivel,string nombrU,string carr,string mater,double cu)
        {
            Nombre = nomb;
            Apellido = apell;
            Dui = id;
            Edad = ed;
            Carnet = carn;
            Nivelacademico = nivel;
            Nombreuniversidad = nombrU;
            Carrera = carr;
            Materia = mater;
            Promedio = cu;
        }

        //CONTRUCTOR VACIO
        public Universitario() { }

    }
}
