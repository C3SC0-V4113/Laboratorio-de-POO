using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClaseDatos
{
    class ConexionSQL
    {
        private SqlConnection Conexion = new SqlConnection("server=localhost;database=SegundoParcialPracticoPOO1;integrated security=true");

        public SqlConnection AbrirConexion()
        {
            if(Conexion.State==ConnectionState.Closed)
            Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
