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
            lblVehiculoPedido.Hide();
            lblVehiculo.Hide();
            lblAnioPedido.Hide();
            lblAnio.Hide();
        }

        private void btnSiniestro_Click(object sender, EventArgs e)
        {
            Siniestro siniestro = new Siniestro();
            siniestro.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Siniestro siniestro = new Siniestro();
            siniestro.Show();
            this.Hide();
        }
    }
}
