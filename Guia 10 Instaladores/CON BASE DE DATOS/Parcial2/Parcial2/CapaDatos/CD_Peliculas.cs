using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Peliculas
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM PELICULAS";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string director, int año, string genero)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Peliculas VALUES('" + nombre + "','" + director + "'," + año + ",'" + genero + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string director, int año, string genero,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPeliculas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Director", director);
            comando.Parameters.AddWithValue("@año", año);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPelicula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpeli", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
