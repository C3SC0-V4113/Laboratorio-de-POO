using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClaseDatos
{
    public class CD_Compras
    {
        private ConexionSQL conexion = new ConexionSQL();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public void Insertar(int codigofact, int codProduct,int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCompras";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodFactura", codigofact);
            comando.Parameters.AddWithValue("@CodProducto", codProduct);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable mostrar(int codigofact)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec ImprimirFactura @CodFactura";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@CodFactura", codigofact);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
