using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;

namespace Parcial2
{
    public partial class frm_parcial2 : Form
    {
        D_Peliculas objetoD = new D_Peliculas();
        private string idPelicula = null;
        private bool Editor = false;
        public frm_parcial2()
        {
            InitializeComponent();
            listbx_genero.Items.Add("GE00");
            listbx_genero.Items.Add("GE01");
            listbx_genero.Items.Add("GE02");
        }

        private void limpiar()
        {
            txt_director.Clear();
            txt_name.Clear();
            nud_año.Value = 1800;
        }

        private void frm_parcial2_Load(object sender, EventArgs e)
        {
            MostrarPelis();
        }

        private void MostrarPelis()
        {
            D_Peliculas objeto12 = new D_Peliculas();
            dgv_Proyector.DataSource = objeto12.MostrarEst();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(Editor==false)
            {
                try
                {
                    objetoD.Insert(txt_name.Text, txt_director.Text, nud_año.Value.ToString(), listbx_genero.SelectedItem.ToString());
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPelis();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se insertaron los datos" + ex);
                }
            }
            else
            {
                try
                {
                    objetoD.edit(txt_name.Text, txt_director.Text, nud_año.Value.ToString(), listbx_genero.SelectedItem.ToString(),idPelicula);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarPelis();
                    Editor = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se insertaron los datos" + ex);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_Proyector.SelectedRows.Count > 0)
            {
                Editor = true;
                txt_name.Text = dgv_Proyector.CurrentRow.Cells["NombrePelicula"].Value.ToString();
                txt_director.Text = dgv_Proyector.CurrentRow.Cells["Director"].Value.ToString();
                nud_año.Value = decimal.Parse(dgv_Proyector.CurrentRow.Cells["Año"].Value.ToString());
                idPelicula = dgv_Proyector.CurrentRow.Cells["IDPelicula"].Value.ToString();
                //listbx_genero.SelectedItem = dgv_Proyector.CurrentRow.Cells["IDGenero"].ToString();
                if (dgv_Proyector.CurrentRow.Cells["IDGenero"].ToString() == "GE00")
                {
                    listbx_genero.SelectedItem = "GE00";
                }
                if (dgv_Proyector.CurrentRow.Cells["IDGenero"].ToString() == "GE01")
                {
                    listbx_genero.SelectedItem = "GE01";
                }
                if (dgv_Proyector.CurrentRow.Cells["IDGenero"].ToString() == "GE02")
                {
                    listbx_genero.SelectedItem = "GE02";
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fla porfavor");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Proyector.SelectedRows.Count > 0)
            {
                idPelicula = dgv_Proyector.CurrentRow.Cells["IDPelicula"].Value.ToString();
                objetoD.dele(idPelicula);
                MessageBox.Show("Se elimino correctamente");
                MostrarPelis();
            }
            else
            {
                MessageBox.Show("Seleccione una fla porfavor");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
