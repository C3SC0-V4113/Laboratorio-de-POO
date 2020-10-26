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
    public partial class frm_ej1 : Form
    {
        public frm_ej1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double neto, descuento;
            string nombre = txt_nombre.Text;
            double salario = double.Parse(txt_salario.Text);

            if(rbtn_ger.Checked==true)
            {
                descuento = salario * 0.2;
                neto = salario - descuento;
                MessageBox.Show(nombre+" Eres gerente\nTú sueldo base es de: "+salario+"\nTú descuento es de: "+descuento+"\nTu sueldo neto es de: "+neto);
            }

            if(rbtn_sub.Checked==true)
            {
                descuento = salario * 0.15;
                neto = salario - descuento;
                MessageBox.Show(nombre + " Eres sub-gerente\nTú sueldo base es de: " + salario + "\nTú descuento es de: " + descuento + "\nTu sueldo neto es de: " + neto);
            }

            if (rbtn_secre.Checked == true)
            {
                descuento = salario * 0.05;
                neto = salario - descuento;
                MessageBox.Show(nombre + " Eres secretari@\nTú sueldo base es de: " + salario + "\nTú descuento es de: " + descuento + "\nTu sueldo neto es de: " + neto);
            }
        }
    }
}
