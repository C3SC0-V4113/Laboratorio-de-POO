using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejercicio_2
{
    public class Estudiante
    {
        //ATRIBUTOS
        private string nombre;
        private string id;
        private DateTime fechanacimiento;
        private string correo;
        private string responsable;
        

        //METODOS
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                if (nombre == "")
                {
                    throw new Exception("No debe dejar en blanco el nombre");
                }
            }
        }

        public string Carnet
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Fecha
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Responsable
        {
            get { return responsable; }
            set
            {
                responsable = value;
                if (responsable == "")
                {
                    throw new Exception("No debe dejar en blanco el nombre");
                }
            }
        }
    }
}
