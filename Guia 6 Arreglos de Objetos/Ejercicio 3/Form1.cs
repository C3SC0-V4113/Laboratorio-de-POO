using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class frm_contactos : Form
    {
        //listado que permite tener varios elementos de la clase Persona
        private List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado
        //esto servirá para el DataGridView.

        private void actualizarGrid()
        {
            dgv_contacts.DataSource = null;
            dgv_contacts.DataSource = Personas;
            //los nombres de columna que veremos son los de las propiedades
        }

        private void limpiar()
        {
            txt_name.Clear();
            txt_lname.Clear();
            txt_phone.Clear();
            txt_mail.Clear();
        }

        public frm_contactos()
        {
            InitializeComponent();
            
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Persona per = new Persona();
            per.Nombre = txt_name.Text;
            per.Apellido = txt_lname.Text;
            per.Telefono = txt_phone.Text;
            per.Correo = txt_mail.Text;
            //verifica si hay un índice seleccionado 0
            if (edit_indice > -1)
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {
                //Al arreglo de Personas le agrego el objeto creado 
                //con todos los datos que recolecté*/
                Personas.Add(per);
            }
            //llamamos al procedimiento que guarda en datagrid
            actualizarGrid();
            //mandamos a llamar la función que limpia
            limpiar();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            //verifica si hay un índice seleccionado
            if (edit_indice > -1)
            {
                Personas.RemoveAt(edit_indice);
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

        private void dgv_contacts_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgv_contacts.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_contacts.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            //esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            Persona per = Personas[pos];
            //lo que tiene el atributo se lo doy al textbox
            txt_name.Text = per.Nombre;
            txt_lname.Text = per.Apellido;
            txt_phone.Text = per.Telefono;
            txt_mail.Text = per.Correo;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //instancia de otro formulario 
            frm_EnvioContactos formulario = new frm_EnvioContactos();
            //lista original Personas es enviada  a la lista PersonaRecibe que está en el formulario 2 
            //y que puede  ser invocada por medio de la instancia del segundo formulario
            formulario.PersonaRecibe = Personas;
            formulario.Show(); //mostar el segundo formulario
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
