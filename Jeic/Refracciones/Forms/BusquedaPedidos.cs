using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones
{
    public partial class BusquedaPedidos : Form
    {
        public BusquedaPedidos()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblCambio.Text = "Ingrese la clave: ";
            txtCambio.Text = "";
            PanelBusqueda.Visible = true;
            PanelCal.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblCambio.Text = "Ingrese el numero: ";
            txtCambio.Text = "";
            PanelBusqueda.Visible = true;
            PanelCal.Visible = false;           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PanelCal.Visible = true;
            PanelBusqueda.Visible = false;
        }

        private void btnBuscaFecha_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = Calendario.SelectionStart;
            DateTime FechaFinal = Calendario.SelectionEnd;
            lblPruebas.Text = "Del dia "+(FechaInicio.ToString()).Substring(0, 2)+" al dia "+(FechaFinal.ToString()).Substring(0, 2);
            PanelCal.Visible = false;
            dataGridView1.Visible = true;
            rdCalendario.Enabled = false;
            rdFactura.Enabled = false;
            RdCve.Enabled = false;
        }

        private void btnBuscarCve_Click(object sender, EventArgs e)
        {
            lblPruebas.Text = txtCambio.Text;
            PanelBusqueda.Visible = false;
            dataGridView1.Visible = true;
            rdCalendario.Enabled = false;
            rdFactura.Enabled = false;
            RdCve.Enabled = false;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            rdCalendario.Enabled = true;
            rdFactura.Enabled = true;
            RdCve.Enabled = true;
            dataGridView1.Visible = false;
            lblPruebas.Text = "";

        }
    }
}
