using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class frm_EnvioContactos : Form
    {
        //creación de una lista que reciba 
        public List<Persona> PersonaRecibe= new List<Persona>();

        public frm_EnvioContactos()
        {
            InitializeComponent();
            for (int i = 0; i < checklistbx_restricciones.Items.Count; i++)
            {
                checklistbx_restricciones.SetItemChecked(i, true);
                checklistbx_restricciones.SelectedIndex = -1;
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            //actualiza DGV cada vez que se presione
                //dgv_contacts.DataSource = null;
                dgv_contacts.DataSource = PersonaRecibe;
            dgv_contacts.Columns["Nombre"].Visible = false;
            dgv_contacts.Columns["Apellido"].Visible = false;
            dgv_contacts.Columns["Telefono"].Visible = false;
            dgv_contacts.Columns["Correo"].Visible = false;
            if (checklistbx_restricciones.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                string s = "";
                for (int x = 0; x < checklistbx_restricciones.CheckedItems.Count; x++)
                {
                    dgv_contacts.Columns[checklistbx_restricciones.CheckedItems[x].ToString()].Visible = true;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
