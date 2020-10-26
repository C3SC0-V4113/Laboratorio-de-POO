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
    public class D_Usuarios
    {
        private CD_Usuarios usuarioCD = new CD_Usuarios();

        public bool Login(string usuario, string contraseña)
        {
            return usuarioCD.Login(usuario,contraseña);
        }
    }
}
