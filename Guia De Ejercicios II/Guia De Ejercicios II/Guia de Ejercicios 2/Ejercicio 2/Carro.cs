using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Carro:Vehiculo
    {
        //Atributos propios
        string traccion;
        string palanca;

        public string Traccion { get => traccion; set => traccion = value; }
        public string Palanca { get => palanca; set => palanca = value; }

        //Metodos propios
        //CONSTRUCTOR
        public Carro(string codm, string codch, string tipg, int cantr,string tip,string trac,string palan)
        {
            CodigoMotor = codm;
            CodigoChasis = codch;
            TipoGasolina = tipg;
            CantidadRuedas = cantr;
            Tipo = tip;
            Traccion = trac;
            Palanca = palan;
        }
    }
}
