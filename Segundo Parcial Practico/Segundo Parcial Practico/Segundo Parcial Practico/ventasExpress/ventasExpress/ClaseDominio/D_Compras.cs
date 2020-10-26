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
    public class D_Compras
    {
        CD_Compras objetoD = new CD_Compras();

        public void Insert(string codigofact, string codProduct, string cantidad)
        {
            objetoD.Insertar(int.Parse(codigofact), int.Parse(codProduct), int.Parse(cantidad));
        }

        public DataTable Mostrar(string codigofact)
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.mostrar(int.Parse(codigofact));
            return tabla;
        }
    }
}
