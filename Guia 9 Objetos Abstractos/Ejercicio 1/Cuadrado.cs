using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public class Cuadrado:Figura //Clase heredada
    {
        private double lado; //Atributo
        
        public Cuadrado(double A,double L):base(A) //Constructor
        {
            lado = L;
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        //Metodo Sobreescrito
        public override void CalcularArea(Label LR)
        {
            Area=(lado*lado);
            LR.Text=("Area: "+Area);
        }
    }
}
