using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class frm_menu : Form
    {
        //listado que permite tener varios elementos de la clase Alumno
        private List<Alumno> Alumno = new List<Alumno>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado
        //esto servirá para el DataGridView.

        //Metodo para actualizar EL DataGridView
        private void actualizarGrid()
        {
            dgv_data.DataSource = null;
            dgv_data.DataSource = Alumno;
            //los nombres de columna que veremos son los de las propiedades
        }

        //Metodo para Eliminar una fila del DataGridView
        private void limpiar()
        {
            txt_name.Clear();
            txt_lname.Clear();
            txt_id.Clear();
            cmbx_signature.SelectedIndex = -1;
            nud_n1.Value = 0;
            nud_n2.Value = 0;
        }
        public frm_menu()
        {
            InitializeComponent();
            cmbx_signature.Items.Add("Matematicas");
            cmbx_signature.Items.Add("Estudios Sociales");
            cmbx_signature.Items.Add("Ciencias Naturales");
            cmbx_signature.Items.Add("Lenguaje y Literatura");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Crear un objeto de Alumno
            Alumno alumno = new Alumno();
            alumno.Nombre = txt_name.Text;
            alumno.Apellido = txt_lname.Text;
            alumno.Carnet = txt_id.Text;
            alumno.Materia = cmbx_signature.Text;
            alumno.Nota1 = nud_n1.Value;
            alumno.Nota2 = nud_n2.Value;
            //verifica si hay un índice seleccionado 0
            if (edit_indice > -1)
            {
                Alumno[edit_indice] = alumno;
                edit_indice = -1;
            }
            else
            {
                //Al arreglo de Personas le agrego el objeto creado 
                //con todos los datos que recolecté*/
                Alumno.Add(alumno);
            }
            //llamamos al procedimiento que guarda en datagrid
            actualizarGrid();
            //mandamos a llamar la función que limpia
            limpiar();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //verifica si hay un índice seleccionado
            if (edit_indice > -1)
            {
                Alumno.RemoveAt(edit_indice);
                //resetea variable a -1
                edit_indice = -1;
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
        }

        private void dgv_data_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgv_data.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_data.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            //esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            Alumno alumno = Alumno[pos];
            //lo que tiene el atributo se lo doy al textbox
            txt_name.Text = alumno.Nombre;
            txt_name.Text=alumno.Nombre;
            txt_lname.Text=alumno.Apellido;
            txt_id.Text=alumno.Carnet;
            cmbx_signature.Text=alumno.Materia;
            nud_n1.Value=alumno.Nota1;
            nud_n2.Value=alumno.Nota2;
        }
    }
}
