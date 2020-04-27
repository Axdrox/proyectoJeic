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
           
        }

        private void rbtnEntregas_CheckedChanged(object sender, EventArgs e)
        {
            cve_factura = oper.Clave_Fact(dato1.Text, Int32.Parse(dato2.Text));
            dato3.Text = cve_factura.ToString();
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = oper.Tabla_Entrega(cve_factura);
        }

        private void rbtnDev_CheckedChanged(object sender, EventArgs e)
        {
            cve_factura = oper.Clave_Fact(dato1.Text, Int32.Parse(dato2.Text));
            dato3.Text = cve_factura.ToString();
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = oper.Tabla_Devolucion(cve_factura);
        }
    }
}
