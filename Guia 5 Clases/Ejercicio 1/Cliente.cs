using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Cliente
    {
        //atributos
        private string nombre;
        private string apellido;
        private string dui;
        private string nit;
        private string tipo;
        private string cuenta;
        private string sucursal;
        private double dinero;

        //métodos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string DUI
        {
            get { return dui; }
            set { dui = value; }
        }
        public string NIT
        {
            get { return nit; }
            set { nit = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
        public double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }
    }
}
