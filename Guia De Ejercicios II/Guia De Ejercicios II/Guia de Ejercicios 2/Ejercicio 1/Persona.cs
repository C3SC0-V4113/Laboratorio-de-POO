using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    abstract public class Persona
    {
        //ATRIBUTOS
        protected string nombre;
        protected string apellido;
        protected string dui;
        protected int edad;

        //MODIFICADORES DE ACCESO
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido {
            get => apellido;
            set => apellido = value;
        }
        public string Dui
        {
            get => dui;
            set => dui = value;
        }
        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        //METODOS PROPIOS

        //CONSTRUCTOR CON PARAMETROS
        public Persona(string nomb, string apell, string id, int ed)
        {
            Nombre = nomb;
            Apellido = apell;
            Dui = id;
            Edad = ed;
        }

        //CONSTRUCTOR VACIO
        public Persona() { }
    }
}
