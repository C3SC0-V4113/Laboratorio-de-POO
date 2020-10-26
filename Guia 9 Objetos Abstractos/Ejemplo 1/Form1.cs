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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txt_lado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A, L);
            cuadrado.CalcularArea(lbl_respuesta);
        }

        private void btn_calcularc_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txt_radio.Text);
            double A = 0;
            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(lbl_Respuestac);
        }
    }
}
