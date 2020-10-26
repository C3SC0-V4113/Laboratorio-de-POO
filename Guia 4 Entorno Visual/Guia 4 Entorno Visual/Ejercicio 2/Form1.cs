using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class frm_ejercicio2 : Form
    {
        public frm_ejercicio2()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            listbx_valores.Items.Add(txt_n1.Text);
            txt_n1.Clear();
            txt_n1.Focus();
        }

        //Evento calcular al mayor de los pares negativos
        private void btn_Mneg_Click(object sender, EventArgs e)
        {
            int mayorneg=0;
            for (int i = 0; i < listbx_valores.Items.Count; i++)
            {
                string valor = listbx_valores.Items[i].ToString();
                int numero = int.Parse(valor);
                if ((numero < 0) && (numero % 2 == 0))
                {
                    if (numero < mayorneg)
                    {
                        mayorneg = numero;
                    }
                    txt_Mneg.Text = mayorneg.ToString();
                }
                else
                {
                    txt_Mneg.Text = "No hay números negativos pares";
                }
            }

        }

        //Evento Calcular el porcentaje de ceros
        private void btn_zeros_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = listbx_valores.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i < listbx_valores.Items.Count; i++)
            {
                string valor = listbx_valores.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txt_zeros.Text = porcentaje.ToString() + "%";

        }

        //Evento para obtener el número promedio de impares negativos
        private void btn_proneg_Click(object sender, EventArgs e)
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;
            for (int i = 0; i < listbx_valores.Items.Count; i++)
            {
            string valor = listbx_valores.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares;
            txt_proneg.Text = prom.ToString();
        }

        //Evento para mayor de pares positivos
        private void btn_Mpp_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listbx_valores.Items.Count; i++)
            {
                string valor = listbx_valores.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            txt_Mpp.Text = mayor.ToString();

        }
    }
}
