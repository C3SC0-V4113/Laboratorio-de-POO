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
    public partial class Menù : Form
    {
        public Menù()
        {
            InitializeComponent();
        }

        private void btn_eje1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ejercicio1 form = new frm_ejercicio1();
            form.ShowDialog();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_eje2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Formula_cuadratica form = new frm_Formula_cuadratica();
            form.ShowDialog();
            this.Close();
        }

        private void btn_eje3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_conversor form = new frm_conversor();
            form.ShowDialog();
            this.Close();
        }
    }
}
