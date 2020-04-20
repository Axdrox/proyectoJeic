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
            lblClaveSiniestro.Hide();
            lblClaveSiniestroPedido.Hide();
            txtAseguradora.Hide();
            txtValuador.Hide();
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
            lblVehiculo.Text = "";
            lblAnio.Text = "";
            lblVehiculoPedido.Hide();
            lblVehiculo.Hide();
            lblAnioPedido.Hide();
            lblAnio.Hide();
            lblClaveSiniestro.Text = "";
            lblClaveSiniestro.Hide();
            lblClaveSiniestroPedido.Hide();
        }

        private void chbOtraAseguradora_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtraAseguradora.Checked == true)
            {
                txtAseguradora.Show();
                cbAseguradora.Hide();
            }
            else
            {
                txtAseguradora.Hide();
                cbAseguradora.Show();
            }
                
        }

        private void chbOtroValuador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroValuador.Checked == true)
            {
                txtValuador.Show();
                cbValuador.Hide();
            }
            else
            {
                txtValuador.Hide();
                cbValuador.Show();
            }
                
        }

        private void txtClavePedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            txtClavePedido.ForeColor = Color.Black;
        }

        private void txtClavePedido_Click(object sender, EventArgs e)
        {
            txtClavePedido.Text = "";
        }

        private void txtAseguradora_Click(object sender, EventArgs e)
        {
            txtAseguradora.Text = "";
        }

        private void txtValuador_Click(object sender, EventArgs e)
        {
            txtValuador.Text = "";
        }

        private void chbOtroTaller_CheckedChanged(object sender, EventArgs e)
        {
            //CHECAR
            if (chbOtroValuador.Checked == true)
            {
                txtValuador.Show();
                cbValuador.Hide();
            }
            else
            {
                txtValuador.Hide();
                cbValuador.Show();
            }
        }
    }
}
