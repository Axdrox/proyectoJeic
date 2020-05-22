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
    public partial class exportarExcel : Form
    {
        OperBD excel = new OperBD();
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
                excel.generarExcel(ruta, Fecha_inicio, Fecha_Final);
            }
        }
    }
}
