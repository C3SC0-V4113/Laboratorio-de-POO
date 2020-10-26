using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public class Auto:Vehiculo
    {
        private bool llantarepuesto;
        private int puertas;

        public Auto(double M, int CR, int CA, bool LL,int PU) : base(M, CR, CA)
        {
            llantarepuesto = LL;
            puertas = PU;
        }

        public bool LlantaRepuesto
        {
            get { return llantarepuesto; }
            set { llantarepuesto = value; }
        }

        public int Puertas
        {
            get { return puertas; }
            set { puertas = value; }
        }

    }
}
