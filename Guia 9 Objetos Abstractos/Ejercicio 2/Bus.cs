using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public class Bus:Vehiculo
    {
        private int puertas;
        private bool maleteros;

        public Bus(double M, int CR, int CA, bool ML, int PU) : base(M, CR, CA)
        {
            puertas = PU;
            maleteros = ML;
        }

        public bool Maleteros
        {
            get { return maleteros; }
            set { maleteros = value; }
        }

        public int Puertas
        {
            get { return puertas; }
            set { puertas = value; }
        }
    }
}
