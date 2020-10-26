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
    public partial class frm_ejemplo1 : Form
    {
        public frm_ejemplo1()
        {
            InitializeComponent();
        }

        private void frm_ejemplo1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            MessageBox.Show("Bienvenido a POO " + nombre + " este es tu primer formulario");
        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui no viejo, abajo");
            button1.Visible=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No te pases");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
