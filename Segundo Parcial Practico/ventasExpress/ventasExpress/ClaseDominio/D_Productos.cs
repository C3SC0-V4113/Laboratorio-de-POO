using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClaseDatos;

namespace ClaseDominio
{
    public class D_Productos
    {
        private CD_Productos productosCD = new CD_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = productosCD.Mostrar();
            return tabla;
        }

        public DataTable MostrarCodi(int codigo)
        {
            DataTable tabla = new DataTable();
            tabla = productosCD.MostrarCod(codigo);
            return tabla;
        }

        public DataTable MostrarNom(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = productosCD.MostrarNombre(nombre);
            return tabla;
        }
    }
}
