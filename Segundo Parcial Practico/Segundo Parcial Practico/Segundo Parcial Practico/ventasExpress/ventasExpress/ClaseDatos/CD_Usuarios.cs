using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClaseComun.CacheUsuario;

namespace ClaseDatos
{
    public class CD_Usuarios
    {
        private ConexionSQL Conexion = new ConexionSQL();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        
        public bool Login(string usuario, string contraseña)
        {
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = " exec BuscarUsuario @usuario,@contraseña";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            leer = comando.ExecuteReader();      
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    CacheUsuario.codigo_Usuario = leer.GetString(0);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
