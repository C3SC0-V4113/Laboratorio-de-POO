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
using ClaseComun.CacheUsuario;

namespace ventasExpress
{
    public partial class Nuevo : Form
    {
        string idFactura = null;
        D_Productos productosD = new D_Productos();
        D_Facturas facturasD = new D_Facturas();
        D_Compras comprasD = new D_Compras();

        public Nuevo()
        {
            InitializeComponent();
            try
            {
                facturasD.Insert(CacheUsuario.codigo_Usuario);
                MessageBox.Show("Se creo la factura");
                dgv_factura.DataSource = facturasD.Mostrar();
            }
            catch (Exception ex)
            {
            }
            dgv1.DataSource = productosD.MostrarProd();
        }

        private void actualizarGrid()
        {

        }

        private void limpiar()
        {
            
        } 


        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            double suma = 0, descuento = 0, total = 0;
                idFactura = dgv_factura.CurrentRow.Cells["CodigoFactura"].Value.ToString();
                try
                {
                D_Compras comprasD = new D_Compras();
                comprasD.Insert(idFactura, txtcodigo.Text, txt_cantidad.Text);
                    MessageBox.Show("Se inserto correctamente");
                    dgv2.DataSource = comprasD.Mostrar(idFactura);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se insertaron los datos" + ex);
                }
            foreach(DataGridViewRow row in dgv2.Rows)
            {
                suma += Convert.ToDouble(row.Cells["total"].Value);
                if(suma>=20)
                {
                    descuento = 0.03*suma;
                    total = suma - descuento;
                }
                else
                {
                    total = suma;
                }
            }
            lbl_resultado.Text = "Tiene un descuento de "+descuento+" su total es de: "+total;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        } 
    }
}
