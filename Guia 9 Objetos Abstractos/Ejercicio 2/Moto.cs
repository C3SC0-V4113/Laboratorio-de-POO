using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public class Moto : Vehiculo
    {
        private bool carrito;

        public Moto(double M, int CR, int CA,bool C):base(M,CR,CA)
        {
            carrito = C;
        }

        public bool Carrito
        {
            get { return carrito; }
            set { carrito = value; }
        }
    }
}
