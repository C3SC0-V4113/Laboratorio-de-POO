using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class frm_1 : Form
    {
        //listado que permite tener varios elementos de la clase Persona
        private List<Producto> Productos = new List<Producto>();
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv_principal.DataSource = null;
            dgv_principal.DataSource = Productos;
            //los nombres de columna que veremos son los de las propiedades
        }

        private void reseteo()
        {
            txt_name.Clear();
            txt_description.Clear();
            txt_brand.Clear();
            txt_price.Clear();
            txt_stock.Clear();
        }

        public frm_1()
        {
            InitializeComponent();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv_principal.SelectedRows[0];
            //almacena en cual fila estoy
            int posicion = dgv_principal.Rows.IndexOf(selected);
            //copio esa variable en índice editado
            edit_indice = posicion;
            /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            Producto product = Productos[posicion];
            //lo que tiene el atributo se lo doy al textbox
            txt_name.Text = product.Nombre;
            txt_description.Text = product.Descripcion;
            txt_brand.Text = product.Marca;
            txt_price.Text = Convert.ToString(product.Precio);
            txt_stock.Text = Convert.ToString(product.Cantidad);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Producto product = new Producto();
            product.Nombre = txt_name.Text;
            product.Descripcion = txt_description.Text;
            product.Marca = txt_brand.Text;
            product.Precio = float.Parse(txt_price.Text);
            product.Cantidad= int.Parse(txt_stock.Text);
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                //al arreglo de Productos le agrego el objeto creado con todos los datos que recolecté
                Productos.Add(product); 
            }
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llamamos al método que resetea
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; //resetea variable a -1
                reseteo();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }
        }
    }
}
