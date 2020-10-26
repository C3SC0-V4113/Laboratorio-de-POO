using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    class Producto
    {
        string nombre;
        string descripcion;
        string marca;
        float precio;
        int cantidad;
        byte[] imagen;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
    }
}
