using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseDominio;

namespace ventasExpress
{
    public partial class Login : Form
    {
        D_Usuarios usuarioD = new D_Usuarios();

        public Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        #region Ver/Ocultar Contraseña

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx1.Checked == true)
            {
                if(txtcontra.PasswordChar == '*')
                {
                    txtcontra.PasswordChar = '\0';
                }
            }
            else
            {
                txtcontra.PasswordChar = '*';
            }
        }

        #endregion
      
        #region Validación de campos

        private bool validarCampos()
        {
            bool validado=true;
            if (txtusuario.Text == "")
            {

                validado = false;

                errorProvider1.SetError(txtusuario, "Ingresar usuario valido");
                limpiar();
            }
            else
            {
                if (txtcontra.Text == "")
                {

                    validado = false;
                    errorProvider1.SetError(txtcontra, "Ingresar contraseña valida");
                    limpiar();
                }
                else
                {
                    D_Usuarios usuario = new D_Usuarios();
                    var LoginValido = usuario.Login(txtusuario.Text, encriptar(txtcontra.Text));
                    if (LoginValido==true)
                    {
                        
                    }
                    else
                    {
                        errorProvider1.SetError(txtusuario,"Contraseña o Usuario no validos");
                        errorProvider1.SetError(txtcontra, "Contraseña o Usuario no validos");
                        validado = false;
                    }
                }
            }

            return validado;
        }

        string encriptar(string cadena)
        {
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptar);
            return resultado;
        }

        private void BorrarMesaje()
        {
            errorProvider1.SetError(txtusuario, "");
            errorProvider1.SetError(txtcontra, "");
        }

        #endregion

        //Funciones de los botones

        private void btningresar_Click(object sender, EventArgs e)
        {

            BorrarMesaje(); //Para Borrar ErrorProvider de los campos

            //Si se cumple que todos los campos estan llenos
            if (validarCampos()==true)
            {
                MessageBox.Show("Bienvenido " + txtusuario.Text);
                Form_Principal abrir = new Form_Principal();
                abrir.Show();
                abrir.FormClosed += LogOut;
                this.Hide();
            }
            else
            {
                limpiar();
            }
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiar()
        {
            txtusuario.Text = null;
            txtcontra.Text = null;
        }

    }
}
