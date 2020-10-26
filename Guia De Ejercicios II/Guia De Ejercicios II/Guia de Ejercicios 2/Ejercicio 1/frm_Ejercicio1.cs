using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class frm_Ejercicio1 : Form
    {

        List<Empleado> emple = new List<Empleado>();
        List<Estudiante> estud = new List<Estudiante>();
        List<Universitario> unive = new List<Universitario>();
        List<Ingenieria> inge = new List<Ingenieria>();
        Ingenieria ing = new Ingenieria();
        Empleado emp = new Empleado();

        public frm_Ejercicio1()
        {
            InitializeComponent();
            cmbx_carrera.Items.Add("Ingenieria en Ciencias de la Computación");
            cmbx_carrera.Items.Add("Licenciatura en Diseño Grafico");
            cmbx_carrera.Items.Add("Ingenieria Aeronautica");
            cmbx_carrera.Items.Add("Licenciatura en Comunicaciones");
            cmbx_nivel.Items.Add("Bachiller");
            cmbx_nivel.Items.Add("Tecnico");
            cmbx_nivel.Items.Add("Licenciado");
            cmbx_nivel.Items.Add("Ingeniero");
            cmbx_nivel.Items.Add("Doctorado");
            cmbx_nivel.Items.Add("Master");
            cmbx_Uni.Items.Add("Universidad de El Salvador");
            cmbx_Uni.Items.Add("Universidad Centroamericana ''José Simeón Cañas''");
            cmbx_Uni.Items.Add("Universidad Don Bosco");
            cmbx_materias.Items.Add("Antropologia Filosofica");
            cmbx_materias.Items.Add("Pensamiento Social Cristiano");
            cmbx_materias.Items.Add("Comunicacion Oral y Escrita");
            this.WindowState= FormWindowState.Maximized;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ing.Nombre=txt_name.Text;
                ing.Apellido=txt_apellido.Text;
                ing.Dui=txt_dui.Text;
                ing.Edad=int.Parse(nud_edad.Value.ToString()) ;
                ing.Carnet=txt_carnetE.Text;
                ing.Nivelacademico=cmbx_nivel.Text;
                ing.Nombreuniversidad=cmbx_Uni.Text;
                ing.Carrera=cmbx_carrera.Text;
                ing.Materia=cmbx_materias.Text;
                ing.N1= double.Parse(nud_n1.Value.ToString());
                ing.N2 = double.Parse(nud_n2.Value.ToString());
                ing.Promedio = ing.CalcularProm(double.Parse(nud_n1.Value.ToString()), double.Parse(nud_n2.Value.ToString()));
                ing.Proyecto=txt_proyecto.Text;
                ing.Horaspasantia=int.Parse(nud_horasp.Value.ToString());
                ing.Horascompletas=int.Parse(nud_horasC.Value.ToString());
                emp.CarnetEmp = txt_carnetEmp.Text;
                emp.Salario = double.Parse(numericUpDown1.Value.ToString());
                if (rbt_Estudiante.Checked == true)
                {
                    estud.Add(ing);
                }
                if (rbtn_empleado.Checked == true)
                {
                    emple.Add(emp);
                }
                if (rbtn_Universitario.Checked == true)
                {
                    unive.Add(ing);
                }
                if (rbtn_ing.Checked == true)
                {
                    inge.Add(ing);
                }
                MostrarenGrid();
                leerGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void leerGrid()
        {
            int contadorbos = 0;
            int contadorNacio = 0;
            int contadoruca = 0;
            foreach (DataGridViewRow filadgv in dgv_Mostrar.Rows)
            {
                if (rbtn_Universitario.Checked == true)
                {
                    if ((filadgv.Cells[0].Value.ToString() == "Universidad de El Salvador") && (filadgv.Cells[1].Value.ToString() == (("Ingenieria en Ciencias de la Computación"))))
                    {
                        contadorNacio++;
                    }
                    if ((filadgv.Cells[0].Value.ToString() == "Universidad de El Salvador") && (filadgv.Cells[1].Value.ToString() == (("Ingenieria Aeronautica"))))
                    {
                        contadorNacio++;
                    }
                    if ((filadgv.Cells[0].Value.ToString() == "Universidad Centroamericana ''José Simeón Cañas''") && (filadgv.Cells[1].Value.ToString() == (("Ingenieria en Ciencias de la Computación"))))
                    {
                        contadoruca++;
                    }
                    if ((filadgv.Cells[0].Value.ToString() == "Universidad Centroamericana ''José Simeón Cañas''") && (filadgv.Cells[1].Value.ToString() == (("Ingenieria Aeronautica"))))
                    {
                        contadoruca++;
                    }
                    if ((filadgv.Cells[0].Value.ToString() == "Universidad Don Bosco") && (filadgv.Cells[1].Value.ToString() == (("Ingenieria en Ciencias de la Computación"))))
                    {
                        contadorbos++;
                    }
                    if ((filadgv.Cells[0].Value.ToString() == "Universidad Don Bosco") && (filadgv.Cells[1].Value.ToString() == (("Ingenieria Aeronautica"))))
                    {
                        contadorbos++;
                    }
                }
                if (rbtn_ing.Checked == true)
                {
                    if ((filadgv.Cells[3].Value.ToString() == "Universidad de El Salvador") && (filadgv.Cells[4].Value.ToString() == (("Ingenieria en Ciencias de la Computación"))))
                    {
                        contadorNacio++;
                    }
                    if ((filadgv.Cells[3].Value.ToString() == "Universidad de El Salvador") && (filadgv.Cells[4].Value.ToString() == (("Ingenieria Aeronautica"))))
                    {
                        contadorNacio++;
                    }
                    if ((filadgv.Cells[3].Value.ToString() == "Universidad Centroamericana ''José Simeón Cañas''") && (filadgv.Cells[4].Value.ToString() == (("Ingenieria en Ciencias de la Computación"))))
                    {
                        contadoruca++;
                    }
                    if ((filadgv.Cells[3].Value.ToString() == "Universidad Centroamericana ''José Simeón Cañas''") && (filadgv.Cells[4].Value.ToString() == (("Ingenieria Aeronautica"))))
                    {
                        contadoruca++;
                    }
                    if ((filadgv.Cells[3].Value.ToString() == "Universidad Don Bosco") && (filadgv.Cells[4].Value.ToString() == (("Ingenieria en Ciencias de la Computación"))))
                    {
                        contadorbos++;
                    }
                    if ((filadgv.Cells[3].Value.ToString() == "Universidad Don Bosco") && (filadgv.Cells[4].Value.ToString() == (("Ingenieria Aeronautica"))))
                    {
                        contadorbos++;
                    }

                }
                lbl_respond.Text = "Los ingenieros en La Don Boco: " + contadorbos + " Los ingenieros  en la Universidad Nacional: " + contadorNacio + " Los ingenieros en la UCA: " + contadoruca;
            }
        }

        public void MostrarenGrid()
        {

            dgv_Mostrar.DataSource = null;

            if (rbt_Estudiante.Checked == true)
            {
                dgv_Mostrar.DataSource =estud;
            }
            if (rbtn_empleado.Checked == true)
            {
                dgv_Mostrar.DataSource =emple;
            }
            if (rbtn_Universitario.Checked == true)
            {
                dgv_Mostrar.DataSource =unive;
            }
            if (rbtn_ing.Checked == true)
            {
                dgv_Mostrar.DataSource =inge;
            }
        }

        public void Evaluaringeniero()
        {
            Limpiar();
            txt_carnetEmp.Enabled = false;
            numericUpDown1.Enabled = false;
        }
        public void EvaluarUniversitario()
        {
            Limpiar();
            txt_carnetEmp.Enabled = false;
            numericUpDown1.Enabled = false;
            txt_proyecto.Enabled = false;
            nud_horasC.Enabled = false;
            nud_horasp.Enabled = false;
        }
        public void EvaluarEstudiante()
        {
            Limpiar();
            EvaluarUniversitario();
            cmbx_carrera.Enabled = false;
            cmbx_materias.Enabled = false;
            cmbx_Uni.Enabled = false;
            nud_n1.Enabled = false;
            nud_n2.Enabled = false;
        }
        public void Limpiar()
        {
            txt_carnetE.Enabled = true;
            cmbx_nivel.Enabled = true;
            cmbx_carrera.Enabled = true;
            cmbx_materias.Enabled = true;
            cmbx_Uni.Enabled = true;
            nud_n1.Enabled = true;
            nud_n2.Enabled = true;
            txt_carnetEmp.Enabled = true;
            numericUpDown1.Enabled = true;
            txt_proyecto.Enabled = true;
            nud_horasC.Enabled = true;
            nud_horasp.Enabled = true;
            txt_apellido.Text = null;
            txt_carnetE.Text = null;
            txt_carnetEmp.Text = null;
            txt_dui.Text = null;
            txt_name.Text = null;
            txt_proyecto.Text = null;
            cmbx_carrera.SelectedIndex = 0;
            cmbx_materias.SelectedIndex = 0;
            cmbx_nivel.SelectedIndex = 0;
            cmbx_Uni.SelectedIndex = 0;
            numericUpDown1.Value = 300;
            nud_edad.Value = 18;
            nud_horasC.Value = 0;
            nud_horasp.Value = 0;
            nud_n1.Value = 0;
            nud_n2.Value = 0;
        }

        public void EvaluarEmpleado()
        {
            txt_carnetE.Enabled = false;
            cmbx_nivel.Enabled = false;
            cmbx_carrera.Enabled = false;
            cmbx_materias.Enabled = false;
            cmbx_Uni.Enabled = false;
            nud_n1.Enabled = false;
            nud_n2.Enabled = false;
            txt_carnetEmp.Enabled = true;
            numericUpDown1.Enabled = true;
            txt_proyecto.Enabled = false;
            nud_horasC.Enabled = false;
            nud_horasp.Enabled = false;
        }

        private void nud_horasC_ValueChanged(object sender, EventArgs e)
        {
            nud_horasC.Maximum = nud_horasp.Value;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbt_Estudiante_CheckedChanged(object sender, EventArgs e)
        {
            EvaluarEstudiante();
        }

        private void rbtn_empleado_CheckedChanged(object sender, EventArgs e)
        {
            EvaluarEmpleado();
        }

        private void rbtn_Universitario_CheckedChanged(object sender, EventArgs e)
        {
            EvaluarUniversitario();
        }

        private void rbtn_ing_CheckedChanged(object sender, EventArgs e)
        {
            Evaluaringeniero();
        }

        private void btn_ingues_Click(object sender, EventArgs e)
        {
        }
    }
}
