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
    public partial class fr_bank : Form
    {
        //listado que permite tener varios elementos de la clase Persona
        private List<Cliente> Cliente = new List<Cliente>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado
        //esto servirá para el DataGridView.

        private void actualizarGrid()
        {
            dgv_data.DataSource = null;
            dgv_data.DataSource = Cliente;
            //los nombres de columna que veremos son los de las propiedades
        }

        private void limpiar()
        {
            txt_name.Clear();
            txt_lname.Clear();
            txt_id.Clear();
            txt_nit.Clear();
            txt_count.Clear();
            lisbx_type.TabIndex = 0;
            listbx_sucursal.TabIndex = 0;
            txt_monto.Clear();
        }
        public fr_bank()
        {
            InitializeComponent();


            //agrega item a la lista tipo de cuenta
            lisbx_type.Items.Clear();
            lisbx_type.Items.Add("Cuenta Corriente");
            lisbx_type.Items.Add("Cuenta de Ahorros");
            lisbx_type.Items.Add("Cuenta a Plazos");
            lisbx_type.TabIndex = 0;

            //Agrega Itemas a la lista sucursal
            listbx_sucursal.Items.Clear();
            listbx_sucursal.Items.Add("Sucursal Multiplaza");
            listbx_sucursal.Items.Add("Sucursal Metrocentro");
            listbx_sucursal.Items.Add("Sucursal Metrocentro Santa Ana");
            listbx_sucursal.Items.Add("Sucursal 25 calle poniente");
            listbx_sucursal.Items.Add("Sucursal Galerias");
            listbx_sucursal.TabIndex = 0;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_typecode_TextChanged(object sender, EventArgs e)
        {
        }

        private void lisbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lisbx_type.SelectedItem.ToString() == "Cuenta Corriente")
            {
                lbl_typecode.Text = "CC";
            }
            if (lisbx_type.SelectedItem.ToString() == "Cuenta de Ahorros")
            {
                lbl_typecode.Text = "CA";
            }
            if (lisbx_type.SelectedItem.ToString() == "Cuenta a Plazos")
            {
                lbl_typecode.Text = "CP";
            }
        }

        private void fr_bank_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            Cliente per = new Cliente();
            per.Nombre = txt_name.Text;
            per.Apellido = txt_lname.Text;
            per.DUI = txt_id.Text;
            per.NIT = txt_nit.Text;
            per.Tipo = lisbx_type.Text;
            if (lisbx_type.SelectedItem.ToString() == "Cuenta Corriente")
            {
                per.Cuenta = "CC-"+ txt_count.Text;
            }
            if (lisbx_type.SelectedItem.ToString() == "Cuenta de Ahorros")
            {
                per.Cuenta = "CA-" + txt_count.Text;
            }
            if (lisbx_type.SelectedItem.ToString() == "Cuenta a Plazos")
            {
                per.Cuenta = "CP-" + txt_count.Text;
            }
            per.Sucursal = listbx_sucursal.Text;
            per.Dinero = Double.Parse(txt_monto.Text.ToString());
            
            //verifica si hay un índice seleccionado 0
            if (edit_indice > -1)
            {
                Cliente[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {
                //Al arreglo de Personas le agrego el objeto creado 
                //con todos los datos que recolecté*/
                Cliente.Add(per);
            }
            //llamamos al procedimiento que guarda en datagrid
            actualizarGrid();
            //mandamos a llamar la función que limpia
            limpiar();
            //Reseteando seleccion de listas
            listbx_sucursal.TabIndex = 0;
            lisbx_type.TabIndex = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //verifica si hay un índice seleccionado
            if (edit_indice > -1)
            {
                Cliente.RemoveAt(edit_indice);
                //resetea variable a -1
                edit_indice = -1;
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
            //Reseteando seleccion de listas
            listbx_sucursal.TabIndex = 0;
            lisbx_type.TabIndex = 0;
        }

        private void dgv_data_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgv_data.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_data.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            //esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            Cliente per = Cliente[pos];
            //lo que tiene el atributo se lo doy al textbox
            txt_name.Text=per.Nombre ;
            txt_lname.Text=per.Apellido ;
            txt_id.Text=per.DUI ;
            txt_nit.Text=per.NIT;
            lisbx_type.Text = per.Tipo;
            listbx_sucursal.Text = per.Sucursal;
            txt_count.Text = per.Cuenta;
            txt_monto.Text = per.Dinero.ToString();
        }
    }
}
