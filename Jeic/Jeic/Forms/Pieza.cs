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
    public partial class Pieza : Form
    {

        public Pieza()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }


        /*
        private void obteniendoClaves()
        {
            
        }
        */

        private void cbPiezaNombre_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbPiezaNombre.DataSource = operacion.NombrePiezasRegistrados().Tables[0].DefaultView;
            cbPiezaNombre.ValueMember = "nombre";
        }

        private void chbOtroPieza_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPieza.Checked == true)
            {
                txtPiezaNombre.Visible = true;
            }
            else
            {
                txtPiezaNombre.Visible = false;
            }
        }

        private void cbPortal_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbPortal.DataSource = operacion.PortalesRegistrados().Tables[0].DefaultView;
            cbPortal.ValueMember = "nombre";
        }

        private void chbOtroPortal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPortal.Checked == true)
            {
                txtPortal.Visible = true;
            }
            else
            {
                txtPortal.Visible = false;
            }
        }

        private void cbOrigen_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbOrigen.DataSource = operacion.OrigenPiezasRegistradas().Tables[0].DefaultView;
            cbOrigen.ValueMember = "origen";
        }

        private void chbOtroOrigen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroOrigen.Checked == true)
            {
                txtOrigen.Visible = true;
            }
            else
            {
                txtOrigen.Visible = false;
            }
        }

        private void cbProveedores_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbProveedores.DataSource = operacion.ProveedoresRegistrados().Tables[0].DefaultView;
            cbProveedores.ValueMember = "nombre";
        }

        private void chbOtroProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroProveedor.Checked == true)
            {
                txtProveedor.Visible = true;
            }
            else
            {
                txtProveedor.Visible = false;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //txtCantidad.ForeColor = Color.Black;
        }

        private void txtDiasEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Pieza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("¿Regresar a Pedido?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtPiezaNombre_Click(object sender, EventArgs e)
        {
            if (txtPiezaNombre.Text == "Escribe nombre de pieza")
            {
                txtPiezaNombre.Text = "";
                txtPiezaNombre.ForeColor = Color.Black;
            }

        }

        private void txtPortal_Click(object sender, EventArgs e)
        {
            if (txtPortal.Text == "Escribe nuevo portal")
            {
                txtPortal.Text = "";
                txtPortal.ForeColor = Color.Black;
            }
        }

        private void txtOrigen_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "Escribe un nuevo origen")
            {
                txtOrigen.Text = "";
                txtOrigen.ForeColor = Color.Black;
            }
        }

        private void txtProveedor_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "Escribe un nuevo proveedor")
            {
                txtProveedor.Text = "";
                txtProveedor.ForeColor = Color.Black;
            }
        }

        private void txtCostoSinIVA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCostoNeto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCostoEnvio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioReparacion_KeyPress(object sender, KeyPressEventArgs e)
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

        string[] datosPieza = new string[13];
        private void btnAniadirPieza_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            /*
            if (chbOtroPieza.Checked != true && chbOtroPortal.Checked != true && chbOtroOrigen.Checked != true && chbOtroProveedor.Checked != true)
            {
                datosPieza[0] = cbPiezaNombre.Text.Trim().ToUpper();
                datosPieza[1] = cbPortal.Text.Trim().ToUpper();
                datosPieza[2] = cbOrigen.Text.Trim().ToUpper();
                datosPieza[3] = cbProveedores.Text.Trim().ToUpper();
            }
            else
            {
                datosPieza[0] = txtPiezaNombre.Text.Trim().ToUpper();
                datosPieza[1] = txtPortal.Text.Trim().ToUpper();
                datosPieza[2] = txtOrigen.Text.Trim().ToUpper();
                datosPieza[3] = txtProveedor.Text.Trim().ToUpper();
            }*/
            datosPieza[4] = dtpFechaCosto.Text.Trim();
            datosPieza[5] = txtCostoSinIVA.Text.Trim();
            datosPieza[6] = txtCostoNeto.Text.Trim();
            datosPieza[7] = cbCostoEnvio.Text.Trim();
            datosPieza[8] = txtPrecioVenta.Text.Trim();

            if (txtPrecioReparacion.Text.Trim() == string.Empty)
            {
                txtPrecioReparacion.Text = "0";
                datosPieza[9] = txtPrecioReparacion.Text.Trim();
            }
            else
                datosPieza[9] = txtPrecioReparacion.Text.Trim();

            datosPieza[10] = txtClaveProducto.Text.Trim().ToUpper();
            datosPieza[11] = txtNumeroGuia.Text.Trim().ToUpper();
            datosPieza[12] = txtCantidad.Text.Trim();

            int modificacion = 0; int j = 0; //validar
            //contar con el # de chb marcados y con la inserción correcta
            if (chbOtroPieza.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarPieza(txtPiezaNombre.Text.Trim().ToUpper()); PONER EN PEDIDO
                if (operacion.existePieza(txtPiezaNombre.Text.Trim().ToUpper()) == string.Empty)
                {
                    datosPieza[0] = txtPiezaNombre.Text.Trim().ToUpper();
                    modificacion += 1;
                }
                else
                {
                    MessageBox.Show("Ya existe una pieza con el mismo nombre", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPiezaNombre.Clear();
                    txtPiezaNombre.Hide();
                    chbOtroPieza.Checked = false;
                }
            }
            else
                datosPieza[0] = cbPiezaNombre.Text.Trim().ToUpper();


            if (chbOtroPortal.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarPortal(txtPortal.Text.Trim());
                if (operacion.existePortal(txtPortal.Text.Trim()) == string.Empty)
                {
                    datosPieza[1] = txtPortal.Text.Trim().ToUpper();
                    modificacion += 1;
                }
                else
                {
                    MessageBox.Show("Ya existe un portal con el mismo nombre", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPortal.Clear();
                    txtPortal.Hide();
                    chbOtroPortal.Checked = false;
                }
            }
            else
                datosPieza[1] = cbPortal.Text.Trim().ToUpper();

            if (chbOtroOrigen.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarOrigen(txtOrigen.Text.Trim().ToUpper());
                if (operacion.existeOrigen(txtOrigen.Text.Trim().ToUpper()) == string.Empty)
                {
                    datosPieza[2] = txtOrigen.Text.Trim().ToUpper();
                    modificacion += 1;
                }
                else
                {
                    MessageBox.Show("Ya existe un origen con el mismo nombre", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOrigen.Clear();
                    txtOrigen.Hide();
                    chbOtroOrigen.Checked = false;
                }
            }
            else
                datosPieza[2] = cbOrigen.Text.Trim().ToUpper();

            if (chbOtroProveedor.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarProveedor(txtProveedor.Text.Trim().ToUpper());
                if (operacion.existeProveedor(txtProveedor.Text.Trim().ToUpper()) == string.Empty)
                {
                    datosPieza[3] = txtProveedor.Text.Trim().ToUpper();
                    modificacion += 1;
                }
                else
                {
                    MessageBox.Show("Ya existe un proveedor con el mismo nombre", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProveedor.Clear();
                    txtProveedor.Hide();
                    chbOtroProveedor.Checked = false;
                }
            }
            else
                datosPieza[3] = cbProveedores.Text.Trim().ToUpper();

            if (modificacion == j)
            {
                this.Close();
            }
        }

        public string[] datosMandar
        {
            get
            {
                return datosPieza;
            }
        }

        private void cbCostoEnvio_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbCostoEnvio.DataSource = operacion.CostoEnvioRegistrados().Tables[0].DefaultView;
            cbCostoEnvio.ValueMember = "costo";
        }

        private void txtCostoSinIVA_Leave(object sender, EventArgs e)
        {
            if (txtCostoSinIVA.Text != string.Empty)
                txtCostoNeto.Text = ((Convert.ToDouble(txtCostoSinIVA.Text.Trim()) * .16) + Convert.ToDouble(txtCostoSinIVA.Text.Trim())).ToString();
        }
    }
}
