using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class frm_ejemplo2 : Form
    {
        public frm_ejemplo2()
        {
            InitializeComponent();
            txt_age.ReadOnly=true;
        }

        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txt_name.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
                errorp1.SetError(txt_name, "Ingresar nombre"); 
                //por lo tanto manda a llamar a errorprovider
                //en los parámetros de setError se identifica a quién estoy validando y el 
                //mensaje que deseo mandar
            }
            //verifico la casilla de apellido
            if (txt_lname.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorp1.SetError(txt_lname, "Ingrese apellido");
            }
            return validado;
        }

        private void BorrarMesaje()
        {
            //borra los mensajes para que no se muestren y pueda limpiar
            errorp1.SetError(txt_name, "");
            errorp1.SetError(txt_lname, "");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //limpia cualquier mensaje de error de alguna corrida previa
            BorrarMesaje();
            //llamamos al método para validar campos, el de nombre y apellido
            if (validarCampos())
            {
                MessageBox.Show("Los datos se ingresaron correctamente");
            }
            //verificamos la fecha de nacimiento que nos den
            //DateTimePicker se llama dtpFechaNacimiento
            DateTime fechaNacimiento = dtp_bdate.Value;
            //verificamos la fecha del sistema (solo calculamos con los años
            int años = System.DateTime.Now.Year - fechaNacimiento.Year;
            /*verificamos aparte del año si ya pasamos la fecha de nacimiento de este año o nos
           faltan días*/
            if (System.DateTime.Now.Subtract(fechaNacimiento.AddYears(años)).TotalDays < 0)
                //si nos faltan días para cumplir años al cálculo le resta uno
                txt_age.Text = Convert.ToString(años - 1);
            else
                //si ya pasó nuestra fecha de nacimiento manda el valor correspondiente
                txt_age.Text = Convert.ToString(años);
        }
    }
}
