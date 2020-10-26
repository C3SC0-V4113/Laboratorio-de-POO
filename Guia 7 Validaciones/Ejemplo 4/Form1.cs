using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_4
{
    public partial class frm_ejemplo4 : Form
    {
        public frm_ejemplo4()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_catch_Click(object sender, EventArgs e)
        {
            Empleado miEmpleado = new Empleado();

            try
            {
                miEmpleado.Carnet = int.Parse(txt_carnet.Text);
                miEmpleado.Nombre = txt_name.Text;
                miEmpleado.Edad = int.Parse(txt_edad.Text);
                MessageBox.Show("Nombre: "+miEmpleado.Nombre+" \nCarnet: "+miEmpleado.Carnet+"\nEdad: "+miEmpleado.Edad);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txt_carnet.Text = "";
                txt_name.Text = "";
                txt_edad.Text = "";
                txt_carnet.Focus(); return;
            }
        }
    }
}
