using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClaseDatos
{
    public class CD_Facturas
    {
        private ConexionSQL conexion = new ConexionSQL();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UltimaFactura";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodUsuario", usuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
