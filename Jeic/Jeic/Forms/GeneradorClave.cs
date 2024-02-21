using Refracciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeic.Forms
{
    public partial class GeneradorClave : Form
    {
        public GeneradorClave()
        {
            InitializeComponent();
        }
        OperBD generador = new OperBD();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            string ruta = Application.StartupPath + "\\generadorClave.xlsx";
            if (ruta != "")
            {
                generador.generarExcelClaves(ruta, Fecha_inicio, Fecha_Final, lblcvePe.Text);

                string usuario = lblUsuario.Text;
                string idPedido = "";
                string descripcionLog = "El usuario: " + usuario + " generó el reporte de claves de la fecha: " + Fecha_inicio + " hasta: " + Fecha_Final + " el día: " + DateTime.Now.ToString();
                generador.Log(usuario, idPedido, descripcionLog, "15");
                this.Close();
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
