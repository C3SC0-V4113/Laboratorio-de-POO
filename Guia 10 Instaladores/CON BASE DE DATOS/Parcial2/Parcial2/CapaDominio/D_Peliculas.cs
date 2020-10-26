using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaDominio
{
    public class D_Peliculas
    {
        private CD_Peliculas objetoD = new CD_Peliculas();

        public DataTable MostrarEst()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.mostrar();
            return tabla;
        }

        public void Insert(string nombre, string director, string año, string genero)
        {
            objetoD.Insertar(nombre,director,int.Parse(año),genero);
        }

        public void edit(string nombre, string director, string año, string genero,string id)
        {
            objetoD.Editar(nombre, director, int.Parse(año), genero,int.Parse(id));
        }

        public void dele(string id)
        {
            objetoD.Eliminar(int.Parse(id));
        }
    }
}
