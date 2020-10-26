using Ejercicio_1;
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
    public partial class frm_ejercicio1 : Form
    {
        public frm_ejercicio1()
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

        private void btn_calculorombo_Click(object sender, EventArgs e)
        {
            double M = double.Parse(txt_d1.Text);
            double N = double.Parse(txt_d2.Text);
            double A = 0;
            Rombo rombo = new Rombo(A, M, N);
            rombo.CalcularArea(lbl_resultadoR);
        }
    }
}
