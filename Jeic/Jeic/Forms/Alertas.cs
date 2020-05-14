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
    public partial class Alertas : Form
    {
        OperBD oper = new OperBD();
        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            DateTime fecha_sys = DateTime.Parse((DateTime.Now.ToShortDateString()));
            dgvAlertas.DataSource = oper.Alertas(fecha_sys);
        }

        private void Alertas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
