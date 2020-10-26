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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_moto_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto(txt_motor.Text, txt_chasis.Text, cmbx_gas.Text, int.Parse(cmbx_gas.ToString()), txt_tipo.Text, int.Parse(nud_cc.ToString()));
        }
    }
}
