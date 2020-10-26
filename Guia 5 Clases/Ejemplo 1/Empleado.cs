using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    //publica para que pueda ser usada en cualquier instancia del proyecto
    class Empleado
    {
        //primer atributo
        private string nombre; 
        //propiedad asociada al atributo nombre
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        //segundo atributo
        private string identificacion; 
        //propiedad asociada al atributo identificacion
        public string Identificacion 
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        //tercer atributo
        private decimal salarioDiario; 
        //propiedad asociada al atributo salarioDiario
        public decimal SalarioDiario 
        {
            get { return salarioDiario; }
            set { salarioDiario = value; }
        }
    }
}
