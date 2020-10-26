using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Empleado:Persona
    {
        //ATRIBUTOS PROPIOS
        private double salario;
        private string carnetEmp;

        public double Salario { get => salario; set => salario = value; }
        public string CarnetEmp { get => carnetEmp; set => carnetEmp = value; }

        //CONSTRUCTOR CON PARAMETROS
        public Empleado(string nomb, string apell, string id, int ed, string carn, double sal)
        {
            Nombre = nomb;
            Apellido = apell;
            Dui = id;
            Edad = ed;
            CarnetEmp = carn;
            Salario = sal;
        }

        public Empleado() { }
    }
}
