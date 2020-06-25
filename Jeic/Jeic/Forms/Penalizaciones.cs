using DocumentFormat.OpenXml.Office.CoverPageProps;
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
    public partial class Penalizaciones : Form
    {
        public Penalizaciones()
        {
            InitializeComponent();
        }

        private void Penalizaciones_Load(object sender, EventArgs e)
        {
            if(penalizarPedido == 1)
            {
                label1.Visible = false;
                cbCantidad.Visible = false;
            }
            else
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    this.cbCantidad.Items.Add(i);
                }
                cbCantidad.SelectedIndex = 0;
            }
            //MessageBox.Show(cvePieza.ToString() + cveVenta.ToString() + cantidad.ToString());
        }
        public int penalizarPedido;

        public int cvePieza;
        public int cveVenta;
        public int cantidad;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Close();
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMotivo_Enter(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "Escriba motivo de la penalización")
            {
                txtMotivo.Text = "";
                txtMotivo.ForeColor = Color.White;
            }
        }

        private void txtMotivo_Leave(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "")
            {
                txtMotivo.Text = "Escriba motivo de la penalización";
                txtMotivo.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtPorcentaje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPorcentaje.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPorcentaje, "Favor de llenar este campo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPorcentaje, null);
            }
        }

        public double porcentaje
        {
            get { return Convert.ToDouble(txtPorcentaje.Text.Trim()); }
        }

        public string motivo
        {
            get { return txtMotivo.Text.Trim(); }
        }

        private void Penalizaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("¿Los datos son correctos?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    OperBD operacion = new OperBD();
                    Pedido pedido = new Pedido(1);
                    string motivo = "";
                    if (txtMotivo.Text.Trim() == "Escriba motivo de la penalización")
                        motivo = "Sin motivo";
                    else
                        motivo = txtMotivo.Text.Trim();
                    if (penalizarPedido == 1)
                    {
                    }
                    else
                    {
                        DateTime hoy = DateTime.Today;
                        operacion.registrarPenalizacion(cvePieza, cveVenta, Convert.ToInt32(cbCantidad.Text.Trim()), motivo, Convert.ToDouble(txtPorcentaje.Text.Trim()), hoy);
                    }
                    this.DialogResult = DialogResult.OK;
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
