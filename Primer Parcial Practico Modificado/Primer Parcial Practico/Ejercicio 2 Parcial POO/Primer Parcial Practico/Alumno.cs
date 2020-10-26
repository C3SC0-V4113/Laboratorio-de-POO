using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Practico
{
    class Alumno
    {
        //ATRIBUTOS
        private string nombre;
        private double n1;
        private double n2;
        private double promin;
        private string estado;

        //METODOS
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double N1
        {
            get
            {
                    return n1;
            }
            set { n1 = value; }
        }
        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }
        public double Promin
        {
            get
            {
                promin = ((n1 + n2) / 2);
                return promin;
            }
            set { promin = value; }
        }

        public string Estado
        {
            get
            {
                if(promin>=7)
                {
                    estado = "Aprobado";
                }
                if((promin<7)&&(promin>=4))
                {
                    estado = "Regular";
                }
                if(promin<4)
                {
                    estado = "Reprobado";
                }
                return estado;
            }
            set { estado = value; }
        }

    }
}
