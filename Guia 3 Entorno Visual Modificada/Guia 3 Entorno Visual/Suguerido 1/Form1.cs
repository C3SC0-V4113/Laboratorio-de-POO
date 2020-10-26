using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suguerido_1
{
    public partial class frm_sugue1 : Form
    {
        public frm_sugue1()
        {
            InitializeComponent();
        }

        private void frm_sugue1_Load(object sender, EventArgs e)
        {
            //agrega item a la lista
            lstbx_seleccion.Items.Clear();
            lstbx_seleccion.Items.Add("Celcius a Farenheit");
            lstbx_seleccion.Items.Add("Metros a Pies");
            lstbx_seleccion.Items.Add("Kilogramos a Libras");
            lstbx_seleccion.TabIndex = 0;
        }

        private void lstbx_seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstbx_seleccion.SelectedItem.ToString() == "Celcius a Farenheit")
            {
                lbl_transform.Text = "Escriba los Celcius a transformar en Farenheit";
            }
            if (lstbx_seleccion.SelectedItem.ToString() == "Metros a Pies")
            {
                lbl_transform.Text = "Escriba los Metros a transformar en Pies";
            }
            if (lstbx_seleccion.SelectedItem.ToString() == "Kilogramos a Libras")
            {
                lbl_transform.Text = "Escriba los Kilogramos a transformar en Libras";
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1, r;
            n1 = Convert.ToDouble(txt_n1.Text);

            if (lstbx_seleccion.SelectedItem.ToString() == "Celcius a Farenheit")
            {
                r = ((n1 * (9 / 5)) + 32);
                MessageBox.Show("El Resultado en Fahrenheit es: " + r);
            }
            if (lstbx_seleccion.SelectedItem.ToString() == "Metros a Pies")
            {
                r = (n1 * 3.28084);
                MessageBox.Show("El Resultado en Pies es: " + r);
            }
            if (lstbx_seleccion.SelectedItem.ToString() == "Kilogramos a Libras")
            {
                r = (n1 * 2.20462);
                MessageBox.Show("El Resultado en Libras es: " + r);
            }

           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
