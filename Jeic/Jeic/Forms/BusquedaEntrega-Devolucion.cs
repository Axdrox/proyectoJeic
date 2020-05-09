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
        int cve_factura = 0;
        public BusquedaEntrega_Devolucion()
        {
            InitializeComponent();
        }

        private void BusquedaEntrega_Devolucion_Load(object sender, EventArgs e)
        {
            //cve_factura =Int32.Parse(dato3.Text);
            int cve_pedido = Int32.Parse(dato2.Text.Substring(8, (dato2.Text.Length - 8)));
            string cve_siniestro = dato1.Text.Substring(11, dato1.Text.Length - 11);
            cve_factura = oper.Clave_Fact(cve_siniestro,cve_pedido);
            dataGridView1.DataSource = oper.Tabla_Entrega(cve_factura);
            dato3.Text =dato3.Text + " " + cve_factura.ToString();
        }

        private void rbtnEntregas_CheckedChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = oper.Tabla_Entrega(cve_factura);
        }

        private void rbtnDev_CheckedChanged(object sender, EventArgs e)
        {
            /*cve_factura = oper.Clave_Fact(dato1.Text, Int32.Parse(dato2.Text));
            dato3.Text = cve_factura.ToString();*/
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = oper.Tabla_Devolucion(cve_factura);
        }
    }
}
