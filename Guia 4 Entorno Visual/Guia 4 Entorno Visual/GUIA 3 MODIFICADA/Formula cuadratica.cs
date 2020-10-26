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
    public partial class frm_Formula_cuadratica : Form
    {
        public frm_Formula_cuadratica()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, r1, r2;
            n1 = Convert.ToDouble(txt_n1.Text);
            n2 = Convert.ToDouble(txt_n2.Text);
            n3 = Convert.ToDouble(txt_n3.Text);

            r1 = (-n2 + Math.Sqrt(Math.Pow(n2, 2) - (4 * (n1) * (n3)))) / (2 * (n1));
            r2 = (-n2 - Math.Sqrt(Math.Pow(n2, 2) - (4 * (n1) * (n3)))) / (2 * (n1));
            txt_r1.Text = r1.ToString();
            txt_r2.Text = r2.ToString();
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
