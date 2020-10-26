using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial_Practico
{
    public partial class frm_Ejercicio_2 : Form
    {
        //listado que permite tener varios elementos de la clase Alumno
        private List<Alumno> Alumno = new List<Alumno>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado
        //esto servirá para el DataGridView.

        //Metodo para actualizar EL DataGridView
        private void actualizarGrid()
        {
            dgv_notas.DataSource = null;
            dgv_notas.DataSource = Alumno;
            //los nombres de columna que veremos son los de las propiedades
        }

        //Metodo para Eliminar una fila del DataGridView
        private void limpiar()
        {
            txt_name.Clear();
            txt_n1.Clear();
            txt_n2.Clear();
        }
        public frm_Ejercicio_2()
        {
            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Alumno per = new Alumno();
            try
            {
                if ((Double.Parse(txt_n1.Text) >= 0 && Double.Parse(txt_n1.Text) <= 10) && (Double.Parse(txt_n2.Text) >= 0 && Double.Parse(txt_n2.Text) <= 10))
                {
                    per.Nombre = txt_name.Text;
                    per.N1 = Double.Parse(txt_n1.Text);
                    per.N2 = Double.Parse(txt_n2.Text);
                    //verifica si hay un índice seleccionado 0
                    if (edit_indice > -1)
                    {
                        Alumno[edit_indice] = per;
                        edit_indice = -1;
                    }
                    else
                    {
                        //Al arreglo de Alumno le agrego el objeto creado 
                        //con todos los datos que recolecté
                        Alumno.Add(per);
                    }

                    //Activar el boton finalizar
                    if (dgv_notas.Rows.Count < 3)
                    {
                        btn_finish.Enabled = false;
                        //llamamos al procedimiento que guarda en datagrid
                        actualizarGrid();
                        //mandamos a llamar la función que limpia
                        limpiar();
                    }
                    if (dgv_notas.Rows.Count == 3)
                    {
                        MessageBox.Show("Ha llegado al limite de Alumnos registrables");
                        btn_finish.Enabled = true;
                        //mandamos a llamar la función que limpia
                        limpiar();
                    }
                }

                else
                {
                    MessageBox.Show("Número no válido, solo usar números del cero al diez");
                }

            } catch (FormatException error)
            {
                MessageBox.Show("Ha ocurrido un error \nLa cadena de entrada no tiene el formato correcto\n" + error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_notas_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dgv_notas.SelectedRows[0];
            //almacena en cual fila estoy
            int pos = dgv_notas.Rows.IndexOf(seleccion);
            //copio esa variable en índice editado
            edit_indice = pos;
            //esta variable de tipo persona, se carga con los valores que le pasa el listado*/
            Alumno per = Alumno[pos];
            //lo que tiene el atributo se lo doy al textbox
            txt_name.Text = per.Nombre;
            txt_n1.Text = per.N1.ToString();
            txt_n2.Text = per.N2.ToString();
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

        private void dgv_notas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Se que esto debia hacerlo en la clase, pero sinceramente no sabia como hacerlo en la Clase alumno
        private void btn_finish_Click(object sender, EventArgs e)
        {
            int posicionM = 0, posicionm = 0;
            string alumno = null, alumnomal = null;
            double mayor = 0, menor = 10;
            for (int i = 0; i < dgv_notas.RowCount; i++)
            {
                if (mayor < Double.Parse(dgv_notas.Rows[i].Cells[3].Value.ToString()))
                {
                    mayor = Double.Parse(dgv_notas.Rows[i].Cells[3].Value.ToString());
                    posicionM = i;
                    alumno = dgv_notas.Rows[i].Cells[0].Value.ToString();
                }
                if (menor > Double.Parse(dgv_notas.Rows[i].Cells[3].Value.ToString()))
                {
                    menor = Double.Parse(dgv_notas.Rows[i].Cells[3].Value.ToString());
                    posicionm = i;
                    alumnomal = dgv_notas.Rows[i].Cells[0].Value.ToString();
                }
            }
            MessageBox.Show("El mayor promedio es de " + alumno + " con un promedio de: " + mayor.ToString()
            + "\n" + "El menor promedio es de " + alumnomal + " con un promedio de: " + menor.ToString());
        }
    }
}
