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
    public class D_Facturas
    {
        private CD_Facturas objetoD = new CD_Facturas();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.mostrar();
            return tabla;
        }

        public void Insert(string usuario)
        {
            objetoD.Insertar(usuario);
        }
    }
}
