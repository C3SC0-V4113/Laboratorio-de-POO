using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Notas:Estudiante
    {
        //ATRIBUTOS
        private string materia;
        private double n1;
        private double n2;
        private double n3;
        private double prom;

        //METODOS
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public double Nota1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public double Nota2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public double Nota3
        {
            get { return n3; }
            set { n3 = value; }
        }

        public double Promedio
        {
            get
            {
                prom = (n1 + n2 + n3) / 3;
                return prom;
            }
            set {prom = value;}
        }
    }
}
