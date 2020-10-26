using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using Ejemplo_1;

namespace Ejercicio_1
{
    public class Rombo : Figura
    {
        private double diagonalM;
        private double diagonalmenor;

        public Rombo(double A, double M, double n) : base(A)
        {
            diagonalM = M;
            diagonalmenor = n;
        }

        public double DiagonalMayor
        {
            get { return diagonalM; }
            set { diagonalM = value; }
        }

        public double DiagonalMenor
        {
            get { return diagonalmenor; }
            set { diagonalmenor = value; }
        }

        //Metodo
        public override void CalcularArea(Label LR)
        {
            Area = (diagonalM * diagonalmenor) / 2;
            LR.Text = ("Area: " + Area);
        }
    }
}
