using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class frm_ejemplo3 : Form
    {
        public frm_ejemplo3()
        {
            InitializeComponent();
            txt_resultado.ReadOnly = true;
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //tratará de realizar la acción solicitada             
            try
            {
                float numera = float.Parse(txt_n1.Text);
                float denomina = float.Parse(txt_n2.Text);
                float resultado = numera / denomina;
                txt_resultado.Text = Convert.ToString(resultado);
                //si no pudiera hacerlo entonces verificará cual es el error y nos los mostrará  
            }                  
            catch (Exception error)
            {
                MessageBox.Show("El problema es: " + error.Message);
            }   
    }

        private void lbl_try_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n1.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
