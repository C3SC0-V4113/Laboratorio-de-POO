using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class frm_ejemplo_1_2 : Form
    {
        public frm_ejemplo_1_2()
        {
            InitializeComponent();
        }
        public frm_ejemplo_1_2(string textx)
        {
            InitializeComponent();
            lbl_ventana2.Text = textx; // Asignamos lo recibido al label
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frm_ejemplo1 frm = new frm_ejemplo1();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
