using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA_3_MODIFICADA
{
    public partial class frm_ejercicio1 : Form
    {
        public frm_ejercicio1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double neto, descuento, salario;
            string nombre = txt_nombre.Text;

            try
            {
                salario = double.Parse(txt_salario.Text);
                if (rbtn_ger.Checked == true)
                {
                    descuento = salario * 0.2;
                    neto = salario - descuento;
                    MessageBox.Show(nombre + " Eres gerente\nTú sueldo base es de: " + salario + "\nTú descuento es de: " + descuento + "\nTu sueldo neto es de: " + neto);
                }

                if (rbtn_sub.Checked == true)
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
            catch (FormatException error)
            {
                MessageBox.Show("Ha ocurrido un error \nLa cadena de entrada no tiene el formato correcto\n" + error);
            }
        }

        private void frm_ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menù form = new Menù();
            form.ShowDialog();
            this.Close();
        }
    }
}
