using Refracciones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class BusquedaEntrega_Devolucion : Form
    {
        OperBD oper = new OperBD();
        DataTable dt = new DataTable();
        //string cve_factura = "";
        int cve_venta = 0;
        public BusquedaEntrega_Devolucion()
        {
            InitializeComponent();
        }

        private void BusquedaEntrega_Devolucion_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            //cve_factura =Int32.Parse(dato3.Text);
           /* string cve_pedido = dato2.Text.Substring(8, (dato2.Text.Length - 8));
            string cve_siniestro = dato1.Text.Substring(11, dato1.Text.Length - 11);*/
            //cve_factura = oper.Clave_Fact(cve_siniestro,cve_pedido);
            cve_venta = Int32.Parse(lblcve_venta.Text);
            dataGridView1.DataSource = oper.Tabla_Entrega(cve_venta);
            //dato3.Text =dato3.Text + " " + cve_factura;
        }

        private void rbtnEntregas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEntregas.Checked == true)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DataSource = oper.Tabla_Entrega(cve_venta);
                rbtnPenalizacion.Checked = false;
            }
        }

        private void rbtnDev_CheckedChanged(object sender, EventArgs e)
        {
            /*cve_factura = oper.Clave_Fact(dato1.Text, Int32.Parse(dato2.Text));
            dato3.Text = cve_factura.ToString();*/
            if (rbtnDev.Checked == true)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DataSource = oper.Tabla_Devolucion(cve_venta);
                rbtnPenalizacion.Checked = false;
            }
        }
        private void rbtnPenalizacion_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnPenalizacion.Checked == true)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.DataSource = oper.Tabla_Penalizacion(cve_venta);
                rbtnDev.Checked = false; rbtnEntregas.Checked = false;
            }
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
