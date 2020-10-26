using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Metodos       

        private bool obtenerRacices()
        {
            bool r = true;
            Double a, b, c, x1 = 0, x2 = 0, d1 = 0, a1, a2;

            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);

            d1 = Math.Pow(b, 2) - (4 * a * c);
            a1 = ((-1 * b) + Math.Sqrt(d1));
            a2 = ((-1 * b) - Math.Sqrt(d1));

            x1 = a1 / (2 * a);
            x2 = a2 / (2 * a);

            txtx1.Text = "" + x1;
            txtx2.Text = "" + x2;


            if (d1 < 0)
            {
                labelinfo2.Text = "La ecuación no tiene soluciones reales";
                labelinfo.Text = "";
                labelnota.Text = "Nota: Limpiar campos antes de ingresar nuevos coeficientes";
                labeldis.Text = "" + d1;
            }
            else
            {
                if (x1 > 0 || x2 > 0)
                {
                    labelinfo.Text = "La ecuación tiene 2 soluciones reales";
                    labelnota.Text = "Nota: Limpiar campos antes de ingresar nuevos coeficientes";
                    labelinfo2.Text = "";
                    labeldis.Text = "" + d1;
                }

            }

            if (d1 == 0)
            {
                labelinfo.Text = "La ecuación tiene una unica solución";
                labelnota.Text = "Nota: Limpiar campos antes de ingresar nuevos coeficientes";
                txtx2.Text = "";
                labeldis.Text = "" + d1;

            }

      
            return r;
        
        }


        #endregion

        #region Validar

        private bool Validar()
        {
            bool validado = true;

            if (txta.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txta, "Escriba Coeficiente a");
            }

            if (txtb.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtb, "Escriba Coeficiente b");
            }

            if (txtc.Text == "")
            {
                validado = false;
                errorProvider1.SetError(txtc, "Escriba Coeficiente c");
            }





            return validado;
        }

        private void BorrarMesaje()
        {
            errorProvider1.SetError(txta, "");
            errorProvider1.SetError(txtb, "");
            errorProvider1.SetError(txtc, "");
            

        }
       

        #endregion

        private void btncal_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                obtenerRacices();
                BorrarMesaje();
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BorrarMesaje();
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtx1.Clear();
            txtx2.Clear();
            labelinfo.Text = "";
            labelinfo2.Text = "";
            labelnota.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BorrarMesaje();
            txta.Text = "3";
            txtb.Text = "1";
            txtc.Text = "-5";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BorrarMesaje();
            txta.Text = "1";
            txtb.Text = "2";
            txtc.Text = "1";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BorrarMesaje();
            txta.Text = "3";
            txtb.Text = "2";
            txtc.Text = "1";
        }
    }
}
