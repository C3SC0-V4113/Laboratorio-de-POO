using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Bus:Vehiculo
    {
        //Atributos propios
        int cantidadpuertas;
        double precio;

        public int CantidadPuertas { get => cantidadpuertas; set => cantidadpuertas = value; }
        public double Precio { get => precio; set => precio = value; }

        //Metodos propios
        //CONSTRUCTOR
        public Bus(string codm, string codch, string tipg, int cantr, string tip, int cantp,double money)
        {
            CodigoMotor = codm;
            CodigoChasis = codch;
            TipoGasolina = tipg;
            CantidadRuedas = cantr;
            Tipo = tip;
            CantidadPuertas = cantp;
            Precio = money;
        }


    }
}
