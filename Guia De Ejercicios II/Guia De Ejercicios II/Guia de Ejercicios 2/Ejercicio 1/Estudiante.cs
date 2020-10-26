using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Estudiante:Persona
    {
        //ATRIBUTOS PROPIOS
        protected string carnet;
        protected string nivelacademico;

        public string Carnet
        {
            get => carnet;
            set => carnet = value;
        }
        public string Nivelacademico
        {
            get => nivelacademico;
            set => nivelacademico = value;
        }

        //METODOS PROPIOS


        //CONSTRUCTOR CON PARAMETROS
        public Estudiante(string nomb, string apell, string id, int ed, string carn, string nivel)
        {
            Nombre = nomb;
            Apellido = apell;
            Dui = id;
            Edad = ed;
            Carnet = carn;
            Nivelacademico = nivel;
        }

        //CONSTRUCTOR VACIO
        public Estudiante() { }

    }
}
