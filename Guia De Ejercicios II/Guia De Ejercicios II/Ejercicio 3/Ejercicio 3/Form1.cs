using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }

        
        

        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            cbxA.Enabled = true;
            cbxB.SelectedIndex = -1;                 
            Clasificación.Text = "Películas para todo público";
            Duracion.Text = "";
            Costo.Text = "";
            Director.Text = "";
            picToy.Visible = false;
            picMonster.Visible = false;
            picRey.Visible = false;
            picinte.Visible = false;
            picince.Visible = false;
            picmid.Visible = false;


            if (rbtnB.Checked == true)
            {
                cbxA.Enabled = false;
                
            }
        }

        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
    
            cbxB.Enabled = true;
            cbxA.SelectedIndex = -1;                    
            Clasificación.Text = "Películas para adolescentes de 12 años en adelante";
            Duracion.Text = "";
            Costo.Text = "";
            Director.Text = "";
            picToy.Visible = false;
            picMonster.Visible = false;
            picRey.Visible = false;



            if (rbtnA.Checked == true)
            {
                cbxB.Enabled = false;
                
            }
        }
      

        private void cbxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxA.SelectedIndex == 0)
            {
                picToy.Visible = true;
                picMonster.Visible = false;
                picRey.Visible = false;
                picinte.Visible = false;
                Costo.Text = "$3";
                Duracion.Text = "1h 21m";
                Director.Text = "John Lasseter";
            }

            if(cbxA.SelectedIndex == 1)
            {
                picMonster.Visible = true;
                picToy.Visible = false;
                picRey.Visible = false;
                picinte.Visible = false;
                Costo.Text = "$3";
                Duracion.Text = "1h 32m";
                Director.Text = "Peter Hans Docter​";

            }

            if (cbxA.SelectedIndex == 2)
            {
                picRey.Visible = true;
                picToy.Visible = false;
                picMonster.Visible = false;
                picinte.Visible = false;
                Costo.Text = "$3";
                Duracion.Text = "1h 29m";
                Director.Text = "Jon Favreau";
            }

        }

        private void cbxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxB.SelectedIndex == 0)
            {
                picinte.Visible = true;
                picMonster.Visible = false;
                picRey.Visible = false;
                picToy.Visible = false;
                picince.Visible = false;
                picmid.Visible = false;
                Costo.Text = "$3.50";
                Duracion.Text = "2h 49m";
                Director.Text = "Christopher Nolan";
            }

            if (cbxB.SelectedIndex == 1)
            {
                picince.Visible = true;
                picToy.Visible = false;
                picRey.Visible = false;
                picMonster.Visible = false;
                picinte.Visible = false;
                picmid.Visible = false;
                Costo.Text = "$3.50";
                Duracion.Text = "2h 28m";
                Director.Text = "Christopher Nolan";

            }

            if (cbxB.SelectedIndex == 2)
            {
                picmid.Visible = true;
                picToy.Visible = false;
                picMonster.Visible = false;
                picRey.Visible = false;
                picinte.Visible = false;
                picince.Visible = false;
                Costo.Text = "$3.50";
                Duracion.Text = "1h 40m";
                Director.Text = "Woody Allen";
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtdinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
