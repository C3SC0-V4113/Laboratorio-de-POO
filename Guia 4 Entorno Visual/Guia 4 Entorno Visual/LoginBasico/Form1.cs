using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginBasico
{
    public partial class frm_logeo : Form
    {
        public frm_logeo()
        {
            InitializeComponent();
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int validator = 0;
            string usuario = txt_nombre.Text;
            string contraseña = txt_password.Text;
            //usted elige ubicación de carpeta, la que hizo en el paso 3, pero esta debe existir
            string url = "C:\\Users\\usuario\\Desktop\\Guia 4 Entorno Visual\\Archivo de LoginBasico\\" + usuario + ".txt";
            //verifica que el archive exista
            if ((txt_password.Text) == "")
            {
                MessageBox.Show("Ingresar contraseña válida");
                validator = 1;

            }
            if ((txt_nombre.Text) == "")
            {
                MessageBox.Show("Ingresar usuario válido");
                validator = 1;
            }
            if (validator == 0)
            {
                if (File.Exists(url))
                {
                    //usuario registrado limpiamos todos los textbox
                    MessageBox.Show("ERROR. ¡Usuario ya existe!");
                    txt_nombre.Clear();
                    txt_password.Clear();
                }
                else
                /*Si no existe Crea un Nuevo archivo con ese nombre y guarda dentro del archivo el valor del segundo parámetro*/
                {
                    File.WriteAllText(url, contraseña);
                    MessageBox.Show("Usuario Registrado con éxito");
                    txt_nombre.Clear();
                    txt_password.Clear();
                }
            }
        }

        private void btn_logeo_Click(object sender, EventArgs e)
        {
            //capturamos los valores de usuario y contraseña
            string usuario = txt_nombre.Text;
            string password;
            string contraseña = txt_password.Text;
            string url = "C:\\Users\\usuario\\Desktop\\Guia 4 Entorno Visual\\Archivo de LoginBasico\\" + usuario + ".txt";
            if (File.Exists(url)) //verifica si existe
            {
                password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
                if (contraseña.Equals(password)) //verifica si contraseña es igual al archivo
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!"); //login exitoso
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");//login fallido
                }
            }
            else
            {
                MessageBox.Show("¡Usuario incorrecto! "); //usuario incorrecto
            }

        }

        private void rbtn_mostrar_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (chb_mostrar.Checked)
            {
                txt_password.PasswordChar = char.Parse("\0");
            }
            else
            {
                txt_password.PasswordChar = char.Parse("*");
            }
        }
    }
}
