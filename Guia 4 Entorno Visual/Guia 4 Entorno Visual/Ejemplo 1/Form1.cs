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
            string texto = txt_nombre.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto);
            frm_ejemplo_1_2 frmrecibe = new frm_ejemplo_1_2(mensaje); 
            /* creo un objeto del segundo formulario,adonde mando información*/
            frmrecibe.Visible = true; // muestra el nuevo formulario
            this.Visible = false; // esconde el formulario actual

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
