using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_Mod
{
    public partial class frm_ej2mod : Form
    {
        public frm_ej2mod()
        {
            InitializeComponent();
        }

        private void txt_no_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void txt_no_KeyPress_1(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    listbx_arreglo.Items.Add(txt_no.Text);
                    txt_no.Clear();
                    txt_no.Focus();
                }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                //Evento calcular al mayor de los pares negativos
                int mayorneg = 0;
                for (int i = 0; i < listbx_arreglo.Items.Count; i++)
                {
                    string valor = listbx_arreglo.Items[i].ToString();
                    int numero = int.Parse(valor);
                    if ((numero < 0) && (numero % 2 == 0))
                    {
                        if (numero < mayorneg)
                        {
                            mayorneg = numero;
                        }
                        txt_n1.Text = mayorneg.ToString();
                    }
                    else
                    {
                        txt_n1.Text = "No hay números negativos pares";
                    }
                }

                //Evento Calcular el porcentaje de ceros
                double cantidadnumeros = listbx_arreglo.Items.Count;
                double cantidadceros = 0;
                double porcentaje = 0;
                for (int i = 0; i < listbx_arreglo.Items.Count; i++)
                {
                    string valor = listbx_arreglo.Items[i].ToString();
                    int numero = int.Parse(valor);
                    if (numero == 0)
                    {
                        cantidadceros = cantidadceros + 1;
                    }
                }
                porcentaje = (cantidadceros / cantidadnumeros) * 100;
                txt_n2.Text = porcentaje.ToString() + "%";

                //Evento para obtener el número promedio de impares negativos
                double prom;
                double cantidadimpares = 0;
                double suma = 0;
                for (int i = 0; i < listbx_arreglo.Items.Count; i++)
                {
                    string valor = listbx_arreglo.Items[i].ToString();
                    int numero = int.Parse(valor);
                    if (numero > 0 && numero % 2 != 0)
                    {
                        suma = suma + numero;
                        cantidadimpares = cantidadimpares + 1;
                    }
                }
                prom = suma / cantidadimpares;
                txt_n3.Text = prom.ToString();

                //Evento para mayor de pares positivos
                int mayor = 0;
                for (int i = 0; i < listbx_arreglo.Items.Count; i++)
                {
                    string valor = listbx_arreglo.Items[i].ToString();
                    int numero = int.Parse(valor);
                    if (numero > 0 && numero % 2 == 0)
                    {
                        if (numero > mayor)
                            mayor = numero;
                    }
                }
                txt_n4.Text = mayor.ToString();
            }catch(FormatException error)
            {
                    MessageBox.Show("Ha ocurrido un error \nLa cadena de entrada no tiene el formato correcto\n" + error);
            }
            }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            listbx_arreglo.Items.Clear();
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            txt_n4.Clear();
        }
    }
}
