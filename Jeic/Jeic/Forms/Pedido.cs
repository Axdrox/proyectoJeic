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
        OperBD operacion = new OperBD();
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
            txtTaller.Hide();
            txtDestino.Hide();
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

        private void chbOtroTaller_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroTaller.Checked == true)
            {
                txtTaller.Show();
                cbTaller.Hide();
            }
            else
            {
                txtTaller.Hide();
                cbTaller.Show();
            }
        }

        private void chbOtroDestino_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroDestino.Checked == true)
            {
                txtDestino.Show();
                cbDestino.Hide();
            }
            else
            {
                txtDestino.Hide();
                cbDestino.Show();
            }
        }

        private void txtClavePedido_Click(object sender, EventArgs e)
        {
            if (txtClavePedido.Text == "Escribe una clave")
                txtClavePedido.Text = "";
            // MEJOR CAMBIARLO AL MOMENTO EN QUE QUIERA FINALIZAR EL PEDIDO
            if (txtClavePedido.Text != string.Empty || txtClavePedido.Text != "Escribe una clave")
            {
                cbVendedor.Enabled = true;
                rdbSi.Enabled = true;
                rdbNo.Enabled = true;
                cbAseguradora.Enabled = true;
                chbOtraAseguradora.Enabled = true;
                cbValuador.Enabled = true;
                chbOtroValuador.Enabled = true;
                cbTaller.Enabled = true;
                chbOtroTaller.Enabled = true;
                cbDestino.Enabled = true;
                chbOtroDestino.Enabled = true;
                dtpFechaAsignacion.Enabled = true;
                dtpFechaPromesa.Enabled = true;
                btnFinalizarPedido.Enabled = true;
            }
            
        }

        private void txtAseguradora_Click(object sender, EventArgs e)
        {
            if (txtAseguradora.Text == "Escriba el nombre del cliente")
                txtAseguradora.Text = "";
        }

        private void txtValuador_Click(object sender, EventArgs e)
        {
            if (txtValuador.Text == "Escribe nombre del valuador")
                txtValuador.Text = "";
        }

        private void txtTaller_Click(object sender, EventArgs e)
        {
            if (txtTaller.Text == "Escriba nombre de taller")
                txtTaller.Text = "";
        }

        private void txtDestino_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Escriba el destino")
                txtDestino.Text = "";
        }

        private void dtpFechaPromesa_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dtpFechaAsignacion.Value.Date;
            DateTime dt2 = dtpFechaPromesa.Value.Date;
            int resta = DateTime.Compare(dt1, dt2);
            if(resta > 0)
            {
                MessageBox.Show("No es posible elegir esa fecha.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaPromesa.Text = "";
            }

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if(txtClavePedido.Text == string.Empty)
            {
                MessageBox.Show("Favor de añadir la clave del pedido.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbAseguradora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga los datos registros de valuadores en el combobox
            cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
            cbValuador.ValueMember = "cve_nombre";
        }

        private void btnAgregarPieza_Click(object sender, EventArgs e)
        {
            Pieza pieza = new Pieza();
            pieza.Show();
        }

        private void cbVendedor_Click(object sender, EventArgs e)
        {
            //Carga los datos registros de vendedores en el combobox
            cbVendedor.DataSource = operacion.VendedoresRegistrados().Tables[0].DefaultView;
            cbVendedor.ValueMember = "cve_vendedor";
        }

        private void cbAseguradora_Click(object sender, EventArgs e)
        {
            //Carga los datos registros de clientes/aseguradoras en el combobox
            cbAseguradora.DataSource = operacion.AseguradorasRegistradas().Tables[0].DefaultView;
            cbAseguradora.ValueMember = "cve_nombre";
        }

        private void cbValuador_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga los datos registros de valuadores en el combobox
            cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
            cbValuador.ValueMember = "cve_nombre";
        }

        private void cbTaller_Click(object sender, EventArgs e)
        {
            //Carga los datos registros de talleres en el combobox
            cbTaller.DataSource = operacion.TalleresRegistrados().Tables[0].DefaultView;
            cbTaller.ValueMember = "nombre";
        }

        private void cbDestino_Click(object sender, EventArgs e)
        {
            //Carga los datos registros de destinos en el combobox
            cbDestino.DataSource = operacion.DestinosRegistrados().Tables[0].DefaultView;
            cbDestino.ValueMember = "destino";
        }
    }
}
