using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Uso de Libreria

namespace Ejemplo_1
{
    public abstract class Figura //Clase publica y abstracta
    {
        private double area;
        //Constructor
        public Figura(double A)
        {
            area = A;
        }

        //Propiedad
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        //Metodo
        public virtual void CalcularArea(Label LR)
        {

        }
    }
}
