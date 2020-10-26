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
    public partial class frm_CalculoSalario : Form

    {
            //instancia de la clase Empleado
            Empleado miEmpleado = new Empleado(); 
            //objeto de la clase Salario
            Salario miSalario = new Salario(); 
        public frm_CalculoSalario()
        {
            InitializeComponent();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //los valores obtenidos en los textbox son pasados a los atributos por medio de sus
            //propiedades, note que mandamos a llamar a través de los objetos creados
            miEmpleado.Nombre = txt_name.Text;
            miEmpleado.Identificacion = txt_id.Text;
            miEmpleado.SalarioDiario = Convert.ToDecimal(txt_diary.Text);
            miSalario.DiasLaborados = int.Parse(txt_days.Text);
            MessageBox.Show("Datos ingresados con éxito");
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //Enviaremos el valor de salario calculado al textbox respectivo, como es un dato
            //numérico debemos convertirlo a texto, el cálculo lo hace el método de la clase salario*/
            txt_totalvalue.Text = Convert.ToString(miSalario.CalcularSalario(miSalario.DiasLaborados, miEmpleado.SalarioDiario));

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //limpiando todo para ingresar nuevos datos
            txt_name.Clear();
            txt_id.Clear();
            txt_days.Clear();
            txt_diary.Clear();
            txt_totalvalue.Clear();
            txt_name.Focus(); //regresa el cursor al textbox del nombre
        }
    }
}
