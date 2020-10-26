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
    public partial class frm_ejemplo2 : Form
    {
        Figura[] figuras = new Figura[5];

        public frm_ejemplo2()
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

        private void btn_calcularA_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txt_value.Text);
            double A = 0;
            double L= double.Parse(txt_value.Text);
            //Se crean objetos de tipo figura, en el parametro del valor modificamos en una unidad para que no se vea el mismo resultado
            figuras[0] = new Cuadrado(A, L);
            figuras[1] = new Cuadrado(A, L + 1);
            figuras[2] = new Circulo(A, R);
            figuras[3] = new Circulo(A, R + 1);
            figuras[4] = new Circulo(A, R + 2);

            //Se envia la respuesta al respectivo label
            figuras[0].CalcularArea(lbl_n1);
            figuras[1].CalcularArea(lbl_n2);
            figuras[2].CalcularArea(lbl_n3);
            figuras[3].CalcularArea(lbl_n4);
            figuras[4].CalcularArea(lbl_n5);
        }
    }
}
