using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Moto:Vehiculo
    {
        //Atributos propios
        int cilindraje;

        public int Cilindraje { get => cilindraje; set => cilindraje = value; }

        //Metodos propios
        //CONSTRUCTOR
        public Moto(string codm, string codch, string tipg, int cantr, string tip, int cil)
        {
            CodigoMotor = codm;
            CodigoChasis = codch;
            TipoGasolina = tipg;
            CantidadRuedas = cantr;
            Tipo = tip;
            Cilindraje = cil;
        }

    }
}
