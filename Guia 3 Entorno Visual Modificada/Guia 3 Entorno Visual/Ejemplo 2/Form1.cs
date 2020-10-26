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
    public partial class frm_ejemplo2 : Form
    {
        public frm_ejemplo2()
        {
            InitializeComponent();
        }

        private void frm_ejemplo2_Load(object sender, EventArgs e)
        {
            //agrega item al combo
            cmb_opbasic.Items.Clear();
            cmb_opbasic.Items.Add("Sumar");
            cmb_opbasic.Items.Add("Restar");
            //agrega item a la lista
            listbx_opavanced.Items.Clear();
            listbx_opavanced.Items.Add("Multiplicacion");
            listbx_opavanced.Items.Add("Division");
            listbx_opavanced.TabIndex = 0;
            //inhabilita el combo y la lista
            cmb_opbasic.Enabled = false;
            listbx_opavanced.Enabled = false;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbtn_opbasicas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_opbasicas.Checked == true)
            {
                cmb_opbasic.Enabled = true;
                listbx_opavanced.Enabled = false;
            }
        }

        private void rbtn_opavanzadas_CheckedChanged(object sender, EventArgs e)
        {
            cmb_opbasic.Enabled = false;
            listbx_opavanced.Enabled = true;
            //me permite seleccionar el primer elemento de la lista
            listbx_opavanced.SelectedIndex = 0;

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            n1 = Convert.ToDouble(txt_n1.Text);
            n2 = Convert.ToDouble(txt_n2.Text);
            if (cmb_opbasic.Enabled == true)
            {
                if (cmb_opbasic.SelectedItem.ToString() == "Sumar")
                    r = n1 + n2;
                else
                    r = n1 - n2;

                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
            if (listbx_opavanced.Enabled == true)
            {
                if (listbx_opavanced.SelectedItem.ToString() == "Multiplicacion")
                    r = n1 * n2;
                else
                    r = n1 / n2;
                MessageBox.Show("El Resultado es " + r.ToString(), "Respuesta");
            }
        }
    }
}
