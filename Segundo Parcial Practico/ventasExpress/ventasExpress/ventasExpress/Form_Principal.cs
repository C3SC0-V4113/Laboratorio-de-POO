using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventasExpress
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        //Abrir regiones en "+" para ver cada una

        #region Abrir Forms

        private void AbrirVentana(object FormVentana)
        {
            if (this.Panelcontenedor.Controls.Count > 0)
                this.Panelcontenedor.Controls.RemoveAt(0);

            Form fv = FormVentana as Form;
            fv.TopLevel = false;
            fv.Dock = DockStyle.Fill;
            this.Panelcontenedor.Controls.Add(fv);
            this.Panelcontenedor.Tag = fv;
            fv.Show();
        }

        private void AbrirConsulta(object FormConsulta)
        {
            if (this.Panelcontenedor.Controls.Count > 0)
                this.Panelcontenedor.Controls.RemoveAt(0);

            Form fc = FormConsulta as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.Panelcontenedor.Controls.Add(fc);
            this.Panelcontenedor.Tag = fc;
            fc.Show();
        }
                

        private void Form_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirVentana(new Nuevo());
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirConsulta(new Consulta());
        }


        #endregion

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas cerrar sesión?", "ALTO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
    }
}
