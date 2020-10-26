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
        public List<Persona> PersonaRecibe = null;

        private void actualizarGrid() //función que llena el DGV del formulario 2         
        {
            dgv_contacts.DataSource = null;
            dgv_contacts.DataSource = PersonaRecibe;
        }

        public frm_EnvioContactos()
        {
            InitializeComponent();
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            //actualiza DGV cada vez que se presione
            actualizarGrid();
        }  
    }
}
