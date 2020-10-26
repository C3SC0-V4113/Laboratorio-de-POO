using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    //publica para que pueda ser usada en cualquier instancia del proyecto
    class Salario
    {
        //atributo
        private int diasLaborados; 
        //propiedad del atributo
        public int DiasLaborados 
        {
            get;
            set;
        }
        //método para calcular salario
        public decimal CalcularSalario(int diaslab, decimal valordia)
        {
            decimal totalsalario = diaslab * valordia;
            return totalsalario;
        }
    }
}
