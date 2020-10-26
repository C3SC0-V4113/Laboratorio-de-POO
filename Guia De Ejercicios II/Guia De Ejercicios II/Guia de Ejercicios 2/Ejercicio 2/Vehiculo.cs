using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public class Vehiculo
    {
        //ATRIBUTOS
        protected string codigomotor;
        protected string codigochasis;
        protected string tipogasolina;
        protected string marca;
        protected int cantidadruedas;
        protected string tipo;


        public string Tipo { get => tipo; set => tipo = value; }
        public string CodigoMotor { get => codigomotor; set => codigomotor = value; }
        public string CodigoChasis { get => codigochasis; set => codigochasis = value; }
        public string TipoGasolina { get => tipogasolina; set => tipogasolina = value; }
        public int CantidadRuedas { get => cantidadruedas; set => cantidadruedas = value; }
        public string Marca { get => marca; set => marca = value; }

        //METODOS PROPIOS
        public Vehiculo(string codm,string codch, string tipg, int cantr,string tip)
        {
            Tipo = tip;
            CodigoMotor = codm;
            CodigoChasis = codch;
            TipoGasolina = tipg;
            CantidadRuedas = cantr;
        }

        public void Registrar()
        {
            MessageBox.Show("Se ha registrado un Vehiculo con el motor: " + CodigoMotor+" de tipo"+Tipo);
        }

        //CONSTRUCTOR
        public Vehiculo() { }
    }
}
