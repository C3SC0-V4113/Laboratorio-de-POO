using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Ingenieria:Universitario
    {
        //ATRIBUTOS PROPIOS
        private string proyecto;
        private int horaspasantia;
        private int horascompletas;

        public string Proyecto
        {
            get => proyecto;
            set => proyecto = value;
        }
        public int Horaspasantia
        {
            get => horaspasantia;
            set => horaspasantia = value;
        }
        public int Horascompletas
        {
            get => horascompletas;
            set => horascompletas = value;
        }

        //METODOS PROPIOS

        //CONSTRUCTOR VACIO
        public Ingenieria() { }

        //CONSTRUCTOR CON PARAMETROS
        public Ingenieria(string nomb, string apell, string id, int ed, string carn,
            string nivel, string nombrU, string carr, string mater, double cu, 
            string proy,int horap,int horacomp)
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
            Proyecto = proy;
            Horaspasantia = horap;
            Horascompletas = horacomp;
        }
    }
}
