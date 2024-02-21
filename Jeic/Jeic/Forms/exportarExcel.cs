using Jeic;
using Jeic.Forms;
using Jeic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class exportarExcel : Form
    {
        OperBD Consulta = new OperBD();
        ReporteVentas reporteVentas = new ReporteVentas();

        public exportarExcel()
        {
            InitializeComponent();
        }

        private void exportarExcel_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            string ruta = Application.StartupPath + "\\Plantilla.xlsx";
            if (ruta != "")
            {
                bool valesLiberados = chkvalesLiberados.Checked;

                if (rbtnOpcion1.Checked)
                    Consulta.generarExcel(ruta, Fecha_inicio, Fecha_Final, decimal.Parse(txtcostoOperativo.Text, new CultureInfo("en-US")), lblcvePe.Text, valesLiberados);
                else if (rbtnOpcion2.Checked)
                    reporteVentas.generarExcelTest(ruta, Fecha_inicio, Fecha_Final, decimal.Parse(txtcostoOperativo.Text, new CultureInfo("en-US")), lblcvePe.Text, valesLiberados);
                else { }

                string usuario = lblUsuario.Text;
                string idPedido = "";
                string descripcionLog = "El usuario: " + usuario + " generó el reporte de ventas de la fecha: " + Fecha_inicio +  " hasta: "+ Fecha_Final +" el día: " + DateTime.Now.ToString();
                Consulta.Log(usuario, idPedido, descripcionLog, "14");
                this.Close();
            }
            
        }

        private void exportarExcel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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

        private void txtcostoOperativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcostoOperativo_TextChanged(object sender, EventArgs e)
        {
            if (txtcostoOperativo.Text.Trim() == "")
            {
                errorP.SetError(txtcostoOperativo, "No se puede dejar este campo vacio");
                txtcostoOperativo.Focus();
                btnGenerar.Enabled = false;
            }
            else
            {
                errorP.Clear();
                btnGenerar.Enabled = true;
            }
        }

        private void exportarExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
