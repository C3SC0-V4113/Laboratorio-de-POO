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
    public partial class Consulta : Form
    {
        D_Productos productosD = new D_Productos();

        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            while (dgv_consultas.RowCount > 1)
            {
                dgv_consultas.Rows.Remove(dgv_consultas.CurrentRow);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            limpiar();
            int codi = 0;
            if(int.TryParse(txt_filtro.Text,out codi))
            {
                MessageBox.Show("Ha ingresado el codigo: "+codi);
                dgv_consultas.DataSource = productosD.MostrarCodi(codi);
            }
            else
            {
                if(txt_filtro.Text=="TODOS")
                {
                    dgv_consultas.DataSource = productosD.MostrarProd();
                }
                else
                {
                    MessageBox.Show("Ha ingresado el producto: " + txt_filtro.Text);
                    dgv_consultas.DataSource = productosD.MostrarNom(txt_filtro.Text);
                }
            }
        }
    }
}
