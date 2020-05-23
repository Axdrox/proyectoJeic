namespace Refracciones.Forms
{
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

    /// <summary>
    /// Defines the <see cref="Pieza" />.
    /// </summary>
    public partial class Pieza : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pieza"/> class.
        /// </summary>
        public Pieza()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The btnCancelar_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /*
        private void obteniendoClaves()
        {
        }
        */

        /// <summary>
        /// The cbPiezaNombre_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cbPiezaNombre_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbPiezaNombre.DataSource = operacion.NombrePiezasRegistrados().Tables[0].DefaultView;
            cbPiezaNombre.ValueMember = "nombre";
        }

        /// <summary>
        /// The chbOtroPieza_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroPieza_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPieza.Checked == true)
            {
                txtPiezaNombre.Visible = true;
                cbPiezaNombre.Hide();
                cbPiezaNombre.SelectedIndex = -1;
            }
            else
            {
                cbPiezaNombre.Show();
                txtPiezaNombre.Clear();
                txtPiezaNombre.Visible = false;
                txtPiezaNombre.Text = "Escriba nombre de pieza";
                txtPiezaNombre.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        /// <summary>
        /// The cbPortal_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cbPortal_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbPortal.DataSource = operacion.PortalesRegistrados().Tables[0].DefaultView;
            cbPortal.ValueMember = "nombre";
        }

        /// <summary>
        /// The chbOtroPortal_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroPortal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPortal.Checked == true)
            {
                txtPortal.Visible = true;
                cbPortal.Hide();
                cbPortal.SelectedIndex = -1;
            }
            else
            {
                cbPortal.Show();
                txtPortal.Clear();
                txtPortal.Visible = false;
                txtPortal.Text = "Escriba un nuevo portal";
                txtPortal.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        /// <summary>
        /// The cbOrigen_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cbOrigen_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbOrigen.DataSource = operacion.OrigenPiezasRegistradas().Tables[0].DefaultView;
            cbOrigen.ValueMember = "origen";
        }

        /// <summary>
        /// The chbOtroOrigen_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroOrigen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroOrigen.Checked == true)
            {
                txtOrigen.Visible = true;
                cbOrigen.Hide();
                cbOrigen.SelectedIndex = -1;
            }
            else
            {
                cbOrigen.Show();
                txtOrigen.Visible = false;
                txtOrigen.Clear();
                txtOrigen.Text = "Escriba un nuevo origen";
                txtOrigen.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        /// <summary>
        /// The cbProveedores_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cbProveedores_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbProveedores.DataSource = operacion.ProveedoresRegistrados().Tables[0].DefaultView;
            cbProveedores.ValueMember = "nombre";
        }

        /// <summary>
        /// The chbOtroProveedor_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroProveedor.Checked == true)
            {
                txtProveedor.Visible = true;
                cbProveedores.Hide();
                cbProveedores.SelectedIndex = -1;
            }
            else
            {
                cbProveedores.Show();
                txtProveedor.Visible = false;
                txtProveedor.Clear();
                txtProveedor.Text = "Escriba un nuevo proveedor";
                txtProveedor.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        /// <summary>
        /// The txtCantidad_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// The txtDiasEntrega_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void txtDiasEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// The Pieza_FormClosing.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="FormClosingEventArgs"/>.</param>
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

        /// <summary>
        /// The txtPiezaNombre_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtPiezaNombre_Click(object sender, EventArgs e)
        {
            if (txtPiezaNombre.Text == "Escriba nombre de pieza")
            {
                txtPiezaNombre.Text = "";
                txtPiezaNombre.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// The txtPortal_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtPortal_Click(object sender, EventArgs e)
        {
            if (txtPortal.Text == "Escriba un nuevo portal")
            {
                txtPortal.Text = "";
                txtPortal.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// The txtOrigen_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtOrigen_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "Escriba un nuevo origen")
            {
                txtOrigen.Text = "";
                txtOrigen.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// The txtProveedor_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtProveedor_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "Escriba un nuevo proveedor")
            {
                txtProveedor.Text = "";
                txtProveedor.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// The txtCostoSinIVA_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
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

        /// <summary>
        /// The txtCostoNeto_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
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

        /// <summary>
        /// The txtCostoEnvio_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
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

        /// <summary>
        /// The txtPrecioVenta_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
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

        /// <summary>
        /// The txtPrecioReparacion_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
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

        /// <summary>
        /// Defines the datosPieza.
        /// </summary>
        internal string[] datosPieza = new string[13];

        /// <summary>
        /// The btnAniadirPieza_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
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
            datosPieza[7] = dtpFechaCosto.Text.Trim();
            datosPieza[8] = txtCostoSinIVA.Text.Trim();
            datosPieza[9] = txtCostoNeto.Text.Trim();
            datosPieza[10] = cbCostoEnvio.Text.Trim();
            datosPieza[11] = txtPrecioVenta.Text.Trim();

            if (txtPrecioReparacion.Text.Trim() == string.Empty)
            {
                txtPrecioReparacion.Text = "0";
                datosPieza[12] = txtPrecioReparacion.Text.Trim();
            }
            else
                datosPieza[12] = txtPrecioReparacion.Text.Trim();

            datosPieza[2] = txtClaveProducto.Text.Trim().ToUpper();
            datosPieza[3] = txtNumeroGuia.Text.Trim().ToUpper();
            datosPieza[1] = txtCantidad.Text.Trim();

            int modificacion = 0; int j = 0; //validar
            //contar con el # de chb marcados y con la inserción correcta
            if (chbOtroPieza.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarPieza(txtPiezaNombre.Text.Trim().ToUpper()); PONER EN PEDIDO
                if ((operacion.existePieza(txtPiezaNombre.Text.Trim().ToUpper()) == string.Empty) && txtPiezaNombre.Text != "Escriba nombre de pieza")
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
                if ((operacion.existePortal(txtPortal.Text.Trim()) == string.Empty) && txtPortal.Text != "Escriba un nuevo portal")
                {
                    datosPieza[4] = txtPortal.Text.Trim().ToUpper();
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
                datosPieza[4] = cbPortal.Text.Trim().ToUpper();

            if (chbOtroOrigen.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarOrigen(txtOrigen.Text.Trim().ToUpper());
                if ((operacion.existeOrigen(txtOrigen.Text.Trim().ToUpper()) == string.Empty) && txtOrigen.Text != "Escriba un nuevo origen")
                {
                    datosPieza[5] = txtOrigen.Text.Trim().ToUpper();
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
                datosPieza[5] = cbOrigen.Text.Trim().ToUpper();

            if (chbOtroProveedor.Checked == true)
            {
                j += 1;
                //int i = operacion.registrarProveedor(txtProveedor.Text.Trim().ToUpper());
                if ((operacion.existeProveedor(txtProveedor.Text.Trim().ToUpper()) == string.Empty) && txtProveedor.Text != "Escriba un nuevo proveedor")
                {
                    datosPieza[6] = txtProveedor.Text.Trim().ToUpper();
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
                datosPieza[6] = cbProveedores.Text.Trim().ToUpper();

            if (modificacion == j)
            {
                if (chbOtroPieza.Checked == true)
                    operacion.registrarPieza(txtPiezaNombre.Text.Trim().ToUpper());

                if (chbOtroPortal.Checked == true)
                    operacion.registrarPortal(txtPortal.Text.Trim());

                if (chbOtroOrigen.Checked == true)
                    operacion.registrarOrigen(txtOrigen.Text.Trim().ToUpper());

                if (chbOtroProveedor.Checked == true)
                    operacion.registrarProveedor(txtProveedor.Text.Trim().ToUpper());

                this.Close();
            }
        }

        /// <summary>
        /// Gets the datosMandar.
        /// </summary>
        public string[] datosMandar
        {
            get
            {
                return datosPieza;
            }
        }

        /// <summary>
        /// The cbCostoEnvio_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cbCostoEnvio_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbCostoEnvio.DataSource = operacion.CostoEnvioRegistrados().Tables[0].DefaultView;
            cbCostoEnvio.ValueMember = "costo";
        }

        /// <summary>
        /// The txtCostoSinIVA_Leave.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void txtCostoSinIVA_Leave(object sender, EventArgs e)
        {
            if (txtCostoSinIVA.Text != string.Empty)
                txtCostoNeto.Text = ((Convert.ToDouble(txtCostoSinIVA.Text.Trim()) * .16) + Convert.ToDouble(txtCostoSinIVA.Text.Trim())).ToString();
        }

        private void Pieza_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
        }

        private void txtPiezaNombre_Leave(object sender, EventArgs e)
        {
            if (txtPiezaNombre.Text == "")
            {
                txtPiezaNombre.Text = "Escriba nombre de pieza";
                txtPiezaNombre.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtClaveProducto_Click(object sender, EventArgs e)
        {
            if (txtClaveProducto.Text == "Escriba clave del producto")
            {
                txtClaveProducto.Text = "";
                txtClaveProducto.ForeColor = Color.White;
            }
        }

        private void txtClaveProducto_Leave(object sender, EventArgs e)
        {
            if (txtClaveProducto.Text == "")
            {
                txtClaveProducto.Text = "Escriba clave del producto";
                txtClaveProducto.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtNumeroGuia_Click(object sender, EventArgs e)
        {
            if (txtNumeroGuia.Text == "Escriba el número de guía")
            {
                txtNumeroGuia.Text = "";
                txtNumeroGuia.ForeColor = Color.White;
            }
        }

        private void txtNumeroGuia_Leave(object sender, EventArgs e)
        {
            if (txtNumeroGuia.Text == "")
            {
                txtNumeroGuia.Text = "Escriba el número de guía";
                txtNumeroGuia.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtPortal_Leave(object sender, EventArgs e)
        {
            if (txtPortal.Text == "")
            {
                txtPortal.Text = "Escriba un nuevo portal";
                txtPortal.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtOrigen_Leave(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "")
            {
                txtOrigen.Text = "Escriba un nuevo origen";
                txtOrigen.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "")
            {
                txtProveedor.Text = "Escriba un nuevo proveedor";
                txtProveedor.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }
    }
}