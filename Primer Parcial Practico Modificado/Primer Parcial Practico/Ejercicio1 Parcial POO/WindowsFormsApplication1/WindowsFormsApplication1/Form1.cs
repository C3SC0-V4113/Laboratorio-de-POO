using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
                  
       private List<Empleado> Empleados = new List<Empleado>(); 
       private int edit_indice = -1;

       private void actualizarGrid()
       {
           dgvempleado.DataSource = null;
           dgvempleado.DataSource = Empleados;  
       }

       private void limpiar()
       {
           txtcod1.Clear();
           txthora1.Clear();

       } 

        public Form1()
        {
            InitializeComponent();
        }

        private void dgvempleado_DoubleClick(object sender, EventArgs e)
        {
             DataGridViewRow seleccion = dgvempleado.SelectedRows[0]; 
             int pos = dgvempleado.Rows.IndexOf(seleccion);            
             edit_indice = pos; 
             Empleado emp = Empleados[pos];
 
           txtcod1.Text = emp.Codigo; 
           txthora1.Text = emp.Hora;

}

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Codigo = txtcod1.Text;           
            emp.Hora = txthora1.Text;
            

            if (edit_indice > -1) 
            {
                Empleados[edit_indice] = emp;
                edit_indice = -1;
            }
            else
            {
                Empleados.Add(emp);
            }

            actualizarGrid();
            limpiar();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horas, sueldo = 0;

            horas = Convert.ToDouble(txthora1.Text);

            if (horas <= 160)
            {
                sueldo = horas * 9.75;
            }
            else if (horas > 160 && 200 >= horas)
            {
                sueldo = 160 * 9.75 + (horas - 160) * 11.50;
            }
            else if (horas > 200 && 250 >= horas)
            {
                sueldo = 160 * 9.75 + 40 * 11.50 + (horas - 200) * 12.50;
            }
          

             MessageBox.Show(Convert.ToString(sueldo));

            Double sueldo1, sueldo2, sueldo3, sueldototal;

            sueldo1 = sueldo - 0.052;
            Convert.ToString(sueldo1);

            sueldo2 = sueldo1 - 0.068;
           Convert.ToString(sueldo2);

            sueldo3 = sueldo2 - 0.10;
           Convert.ToString(sueldo3);

            sueldototal = sueldo3;
            Convert.ToString(sueldototal);

            MessageBox.Show("El sueldo base es:" + sueldo + ", Descuentos: ISSS: "+ sueldo1 + "AFP: " + sueldo2 + "Renta : " + sueldo3);




        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }



    
}

