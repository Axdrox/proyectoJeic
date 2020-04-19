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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            lblVehiculoPedido.Hide();
            lblVehiculo.Hide();
            lblAnioPedido.Hide();
            lblAnio.Hide();
            chbSi.Hide();
        }

        private void btnSiniestro_Click(object sender, EventArgs e)
        {
            Siniestro siniestro = new Siniestro();
            siniestro.Show();
            this.Hide();
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            Siniestro siniestro = new Siniestro();
            siniestro.Show();
            this.Hide();
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            rdbSi.Show();
            rdbSi.Enabled = true;
            chbSi.Hide();
            chbSi.Checked = false;
        }
    }
}
