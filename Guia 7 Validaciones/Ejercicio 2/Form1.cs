using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio_2
{
    public partial class frm_ejercicio21 : Form
    {
        private List<Estudiante> est = new List<Estudiante>();
        public frm_ejercicio21()
        {
            InitializeComponent();
            dtp_bday.MaxDate = DateTime.Now;
             
        }

        public static bool validaremail(string email)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            //string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a - z]{ 2,4})$";
            string expresion = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(email, expresion))
            {
                //verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarCarnet(string id)
        {
            string exp = "[a-z]{2}[0-9]{6}";
            MatchCollection encontrado = Regex.Matches(id, exp);
            if (Regex.IsMatch(id, exp))
            {
                //verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(id, exp, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



        private void btn_next_Click(object sender, EventArgs e)
        {
            Estudiante miEst = new Estudiante();
            try
            {
                miEst.Carnet = txt_id.Text;
                miEst.Nombre = txt_name.Text;
                miEst.Fecha = dtp_bday.Value;
                miEst.Correo = txt_mail.Text;
                miEst.Responsable = txt_responsable.Text;
                est.Add(miEst);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txt_id.Text = "";
                txt_name.Text = "";
                txt_mail.Text = "";
                txt_responsable.Text = "";
                txt_name.Focus(); return;
            }

            frm_ejercicio22 frm2 = new frm_ejercicio22();
            this.Hide();
            frm2.EstudianteRecibe = est;
            frm2.Show();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if (ValidarCarnet(txt_id.Text))
            {
                //si es correcto no debe hacer nada
            }
            else
            {
                //sino es correcto que envíe este mensaje y se posicione para
                //verificar recuerde que se activará la validación al dar click en otro textbox o
                //simplemente dejar o salir de esa casilla de email
                MessageBox.Show("Carnet no válido");
                //selecciona todo lo de la casilla
                txt_id.SelectAll();
                //se posiciona ahí de nuevo
                txt_id.Focus();
            }
        }

        private void txt_mail_Leave(object sender, EventArgs e)
        {
            if (validaremail(txt_mail.Text))
            {
                //si es correcto no debe hacer nada
            }
            else
            {
                //sino es correcto que envíe este mensaje y se posicione para
                //verificar recuerde que se activará la validación al dar click en otro textbox o
                //simplemente dejar o salir de esa casilla de email
                MessageBox.Show("Dirección de correo no válida");
                //selecciona todo lo de la casilla
                txt_mail.SelectAll();
                //se posiciona ahí de nuevo
                txt_mail.Focus();
            }
        }
    }
}
