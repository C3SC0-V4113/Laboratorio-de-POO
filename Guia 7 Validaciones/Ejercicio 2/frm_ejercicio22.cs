using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class frm_ejercicio22 : Form
    {
        public List<Estudiante> EstudianteRecibe = new List<Estudiante>();

        public frm_ejercicio22()
        {
            InitializeComponent();

            cmbbx_signature.Items.Add("Calculo Integral");
            cmbbx_signature.Items.Add("Algebra Lineal y Matrices");
            cmbbx_signature.Items.Add("Gestión Ambiental");
            cmbbx_signature.Items.Add("Programación Orientada a Objetos");
            cmbbx_signature.Items.Add("Modelamiento y Diseño de Bases de Datos");
            nud_n2.Maximum=10;
            nud_n2.Increment = decimal.Parse(0.1.ToString());
            nud_n2.DecimalPlaces = 1;
            nud_n3.Maximum = 10;
            nud_n3.Increment = decimal.Parse(0.1.ToString());
            nud_n3.DecimalPlaces = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notas quali = new Notas();
            quali.Nota1 = double.Parse(nud_n1.Value.ToString());
            quali.Nota2 = double.Parse(nud_n2.Value.ToString());
            quali.Nota3 = double.Parse(nud_n3.Value.ToString());
            quali.Materia = cmbbx_signature.Text;
            MessageBox.Show("El estudiante tiene un promedio de "+quali.Promedio+" En la materia de "+quali.Materia);
        }
    }
}
