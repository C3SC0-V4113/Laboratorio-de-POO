using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClaseDatos
{
    public class CD_Productos
    {
        private ConexionSQL Conexion = new ConexionSQL();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "exec MostrarTODOSProductos";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarCod(int codigo)
        {
            comando.Parameters.Clear();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "exec MostrarProductosCodi @Codigo";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@Codigo", codigo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            Conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarNombre(string nombre)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = "exec MostrarProductosNombre @Nombre";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            Conexion.CerrarConexion();
            return tabla;
        }
    }
}
