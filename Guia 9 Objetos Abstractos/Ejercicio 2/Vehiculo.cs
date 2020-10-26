using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Uso de Libreria

namespace Ejercicio_2
{
    public abstract class Vehiculo
    {
        private double motor;
        private int cantidadruedas;
        private int cantidadasientos;
        private double precio;

        public Vehiculo(double M,int CR,int CA)
        {
            motor = M;
            cantidadruedas = CR;
            cantidadasientos = CA;
        }

        public double Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        public int CantidadRuedas
        {
            get { return cantidadruedas; }
            set { cantidadruedas = value; }
        }

        public int CantidadAsientos
        {
            get { return cantidadasientos; }
            set { cantidadasientos = value; }
        }
    }
}
