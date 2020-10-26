using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class frm_ejercicio2 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public frm_ejercicio2()
        {
            InitializeComponent();
            cmb_Vehiculo.SelectedIndex = -1;
            MostrarDGV();
        }

        private void MostrarDGV()
        {
            dgv_vehiculos.DataSource=vehiculos;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cmb_Vehiculo.SelectedIndex == 0)
            {
                bool Llanta;
                double M = double.Parse(nud_cc.Value.ToString());
                int CA = int.Parse(nud_asientos.Value.ToString());
                int CR = int.Parse(nud_ruedas.Value.ToString());
                if (rbtn_sicarrito.Checked == true)
                {
                    Llanta = true;
                }
                else
                {
                    Llanta = false;
                }
                int PU = int.Parse(nud_puertas.Value.ToString());
                Auto auto = new Auto(M, CR, CA, Llanta, PU);
                vehiculos.Add(auto);
                MostrarDGV();
            }

            if (cmb_Vehiculo.SelectedIndex == 1)
            {
                bool carrito;
                double M = double.Parse(nud_cc.Value.ToString());
                int CA = int.Parse(nud_asientos.Value.ToString());
                int CR = int.Parse(nud_ruedas.Value.ToString());
                if (rbtn_sicarrito.Checked == true)
                {
                    carrito = true;
                }
                else
                {
                    carrito = false;
                }
                Moto moto = new Moto(M, CR, CA, carrito);
                vehiculos.Add(moto);
                MostrarDGV();
            }

            if (cmb_Vehiculo.SelectedIndex == 2)
            {
                if (cmb_Vehiculo.SelectedIndex == 0)
                {
                    bool Maletero;
                    double M = double.Parse(nud_cc.Value.ToString());
                    int CA = int.Parse(nud_asientos.Value.ToString());
                    int CR = int.Parse(nud_ruedas.Value.ToString());
                    if (rbtn_sicarrito.Checked == true)
                    {
                        Maletero = true;
                    }
                    else
                    {
                        Maletero = false;
                    }
                    int PU = int.Parse(nud_puertas.Value.ToString());
                    Bus bus = new Bus(M, CR, CA, Maletero, PU);
                    vehiculos.Add(bus);
                    MostrarDGV();
                }
            }
        }
    }
}
