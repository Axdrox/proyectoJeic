namespace Refracciones.Forms
{
    using DocumentFormat.OpenXml.EMMA;
    using DocumentFormat.OpenXml.Office2010.PowerPoint;
    using Jeic.Properties;
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

        private void Pieza_Load(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            //Colocar ICONO
            this.Icon = Resources.iconJeic;

            this.ActiveControl = label1;

            //Carga los datos de los nombres de las piezas registrados
            cbPiezaNombre.DataSource = operacion.NombrePiezasRegistrados(1).Tables[0].DefaultView;
            cbPiezaNombre.ValueMember = "nombre";

            if(indicador != 1)
            {
                //Carga los datos de los nombres de los portales registrados
                cbPortal.DataSource = operacion.PortalesRegistrados(1).Tables[0].DefaultView;
                cbPortal.ValueMember = "nombre";

                //Carga los datos de los nombres de los origenes registrados
                cbOrigen.DataSource = operacion.OrigenPiezasRegistradas().Tables[0].DefaultView;
                cbOrigen.ValueMember = "origen";

                //Carga los datos de los nombres de los proveedores registrados
                cbProveedores.DataSource = operacion.ProveedoresRegistrados(1).Tables[0].DefaultView;
                cbProveedores.ValueMember = "nombre";

                //Carga los datos de los costos registrados
                cbCostoEnvio.DataSource = operacion.CostoEnvioRegistrados().Tables[0].DefaultView;
                cbCostoEnvio.ValueMember = "costo";
                cbCostoEnvio.SelectedValue = "0.00";
            }
            else
            {
                //---------- SECCIÓN UTILIZADA PARA CARGAR DATOS RECIENTES

                cbPortal.DataSource = operacion.PortalesRegistrados(1).Tables[0];
                cbPortal.ValueMember = "cve_portal";
                cbPortal.DisplayMember = "nombre";
                cbPortal.SelectedValue = operacion.indexPortalRegistrado(portalDefault);

                cbOrigen.DataSource = operacion.OrigenPiezasRegistradas().Tables[0];
                cbOrigen.ValueMember = "cve_origen";
                cbOrigen.DisplayMember = "origen";
                cbOrigen.SelectedValue = operacion.indexOrigenPiezasRegistradas(origenDefault);

                cbProveedores.DataSource = operacion.ProveedoresRegistrados(1).Tables[0];
                cbProveedores.ValueMember = "cve_proveedor";
                cbProveedores.DisplayMember = "nombre";
                cbProveedores.SelectedValue = operacion.indexProveedoresRegistrados(proveedorDefault);

                cbCostoEnvio.DataSource = operacion.CostoEnvioRegistrados().Tables[0];
                cbCostoEnvio.ValueMember = "cve_costoEnvio";
                cbCostoEnvio.DisplayMember = "costo";
                cbCostoEnvio.SelectedValue = operacion.indexCostoEnvioRegistrados(costoEnvioDefault);

            }

            if (destinoLocal == "LOCAL" || destinoLocal == "CDMX" || destinoLocal == "Ciudad de México")
            {
                txtNumeroGuia.Visible = false;
                cbNumeroGuia.Visible = false;
                chbOtroNumeroGuia.Visible = false;
                label13.Visible = false;
            }
            else
            {
                if (cbNumeroGuia.Items.Count != 0)
                {
                    destinosAgregados = 1;
                    cbNumeroGuia.SelectedIndex = 0;
                    txtNumeroGuia.Hide();
                    cbNumeroGuia.Show();
                    chbOtroNumeroGuia.Visible = true;
                    if (editarPieza == 1)
                    {
                        txtNumeroGuia.Visible = true;
                        txtNumeroGuia.Text = datos[3];
                        txtNumeroGuia.ReadOnly = true;
                        cbNumeroGuia.Visible = false;
                        cbNumeroGuia.Visible = false;
                        chbOtroNumeroGuia.Text = "Modificar";
                    }
                }
            }

            if (editarPieza == 1)
            {
                bunifuGradientPanel1.Size = new Size(385, 396);
                this.Size = new Size(385, 396);
                btnAniadirPieza.Text = "Confirmar";

                txtPiezaNombre.Visible = true;
                txtPiezaNombre.Text = datos[0];
                txtPiezaNombre.ReadOnly = true;
                cbPiezaNombre.Visible = false;
                chbOtroPieza.Text = "Modificar";

                txtCantidad.Text = datos[1];

                txtClaveProducto.Text = datos[2];


                txtNumeroGuia.Text = datos[3];
                txtNumeroGuia.ReadOnly = true;
                chbOtroNumeroGuia.Text = "Modificar";
                /*txtNumeroGuia.Visible = true;
                txtNumeroGuia.Text = datos[3];
                txtNumeroGuia.ReadOnly = true;
                cbNumeroGuia.Visible = false;
                cbNumeroGuia.Visible = false;
                chbOtroNumeroGuia.Text = "Modificar";*/

                txtPortal.Visible = true;
                txtPortal.Text = datos[4];
                txtPortal.ReadOnly = true;
                cbPortal.Visible = false;
                chbOtroPortal.Text = "Modificar";

                txtOrigen.Visible = true;
                txtOrigen.Text = datos[5];
                txtOrigen.ReadOnly = true;
                cbOrigen.Visible = false;
                chbOtroOrigen.Text = "Modificar";

                txtProveedor.Visible = true;
                txtProveedor.Text = datos[6];
                txtProveedor.ReadOnly = true;
                cbProveedores.Visible = false;
                chbOtroProveedor.Text = "Modificar";

                dtpFechaCosto.Text = datos[7];

                //txtCostoSinIVA.Text = datos[8];
                txtCostoNeto.Text = datos[8];
                txtCostoNeto.Enabled = true;

                //cbCostoEnvio.DropDownStyle = ComboBoxStyle.DropDown;
                cbCostoEnvio.Text = datos[9];

                txtPrecioReparacion.Text = datos[10];
                txtPrecioVenta.Text = datos[11];
            }
        }

        public int indicador = 0;
        public string marca;
        public string modelo;
        public string anio;

        private int destinosAgregados = 0;
        private string destinoLocal = "";
        string portalDefault = "";
        string origenDefault = "";
        string proveedorDefault = "";
        string costoEnvioDefault = "";

        public string destino
        {
            set { destinoLocal = value; }
        }

        public string portal
        {
            set { portalDefault = value; }
        }

        public string origen
        {
            set { origenDefault = value; }
        }

        public string proveedor
        {
            set { proveedorDefault = value; }
        }

        public string costoEnvio
        {
            set { costoEnvioDefault = value; }
        }

        private string[] datos;
        public int editarPieza = 0;

        public string[] datosEditar
        {
            set { datos = value; }
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

        /// <summary>
        /// The chbOtroPieza_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroPieza_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPieza.Text == "Modificar" && chbOtroPieza.Checked == true)
            {
                txtPiezaNombre.ReadOnly = false;
                cbPiezaNombre.Visible = true;
                txtPiezaNombre.Clear();
                txtPiezaNombre.Visible = false;
                txtPiezaNombre.Text = "Escriba nombre de pieza";
                txtPiezaNombre.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroPieza.Text = "Otro";
                chbOtroPieza.Checked = false;
            }
            /*
            else if (chbOtroPieza.Text == "Modificar" && chbOtroPieza.Checked == false)
            {
                txtPiezaNombre.Visible = true;
                txtPiezaNombre.ReadOnly = true;
                txtPiezaNombre.Text = datos[0];
                cbPiezaNombre.Visible = false;
                cbPiezaNombre.SelectedIndex = -1;
            }*/

            if (chbOtroPieza.Text == "Otro" && chbOtroPieza.Checked == true)
            {
                txtPiezaNombre.Visible = true;
                cbPiezaNombre.Visible = false;
                //cbPiezaNombre.SelectedIndex = -1;
            }
            else if (chbOtroPieza.Text == "Otro" && chbOtroPieza.Checked == false)
            {
                cbPiezaNombre.Visible = true;
                txtPiezaNombre.Clear();
                txtPiezaNombre.Visible = false;
                txtPiezaNombre.Text = "Escriba nombre de pieza";
                txtPiezaNombre.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        /// <summary>
        /// The chbOtroPortal_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroPortal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPortal.Text == "Modificar" && chbOtroPortal.Checked == true)
            {
                txtPortal.ReadOnly = false;
                cbPortal.Visible = true;
                txtPortal.Visible = false;
                txtPortal.Text = "Escriba nombre de pieza";
                txtPortal.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroPortal.Text = "Otro";
                chbOtroPortal.Checked = false;
            }

            if (chbOtroPortal.Text == "Otro" && chbOtroPortal.Checked == true)
            {
                txtPortal.Visible = true;
                cbPortal.Hide();
                //cbPortal.SelectedIndex = -1;
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
        /// The chbOtroOrigen_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroOrigen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroOrigen.Text == "Modificar" && chbOtroOrigen.Checked == true)
            {
                txtOrigen.ReadOnly = false;
                cbOrigen.Visible = true;
                txtOrigen.Visible = false;
                txtOrigen.Text = "Escriba nombre de pieza";
                txtOrigen.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroOrigen.Text = "Otro";
                chbOtroOrigen.Checked = false;
            }

            if (chbOtroOrigen.Text == "Otro" && chbOtroOrigen.Checked == true)
            {
                txtOrigen.Visible = true;
                cbOrigen.Hide();
                //cbOrigen.SelectedIndex = -1;
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
        /// The chbOtroProveedor_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chbOtroProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroProveedor.Text == "Modificar" && chbOtroProveedor.Checked == true)
            {
                txtProveedor.ReadOnly = false;
                cbProveedores.Visible = true;
                txtProveedor.Visible = false;
                txtProveedor.Text = "Escriba nombre de pieza";
                txtProveedor.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroProveedor.Text = "Otro";
                chbOtroProveedor.Checked = false;
            }

            if (chbOtroProveedor.Text == "Otro" && chbOtroProveedor.Checked == true)
            {
                txtProveedor.Visible = true;
                cbProveedores.Hide();
                //cbProveedores.SelectedIndex = -1;
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
        internal string[] datosPieza = new string[12];

        /// <summary>
        /// The btnAniadirPieza_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnAniadirPieza_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                datosPieza[7] = dtpFechaCosto.Text.Trim();
                //datosPieza[8] = txtCostoSinIVA.Text.Trim();
                datosPieza[8] = txtCostoNeto.Text.Trim();

                if (!string.IsNullOrEmpty(cbCostoEnvio.Text))
                    datosPieza[9] = cbCostoEnvio.Text.Trim();
                else
                    datosPieza[9] = "0";

                datosPieza[10] = txtPrecioVenta.Text.Trim();

                if (string.IsNullOrEmpty(txtPrecioReparacion.Text.Trim()))
                {
                    txtPrecioReparacion.Text = "0";
                    datosPieza[11] = txtPrecioReparacion.Text.Trim();
                }
                else
                    datosPieza[11] = txtPrecioReparacion.Text.Trim();

                datosPieza[2] = txtClaveProducto.Text.Trim().ToUpper();

                if (chbOtroNumeroGuia.Checked == false && txtNumeroGuia.Text != "Escriba el número de guía" && (destinoLocal != "LOCAL" || destinoLocal != "CDMX" || destinoLocal != "Ciudad de México"))
                    datosPieza[3] = txtNumeroGuia.Text.Trim().ToUpper();
                else if (chbOtroNumeroGuia.Checked == true && destinosAgregados > 0 && (destinoLocal != "LOCAL" || destinoLocal != "CDMX" || destinoLocal != "Ciudad de México"))
                    datosPieza[3] = txtNumeroGuia.Text.Trim().ToUpper();
                else if (chbOtroNumeroGuia.Checked == false && destinosAgregados > 0 && (destinoLocal != "LOCAL" || destinoLocal != "CDMX" || destinoLocal != "Ciudad de México"))
                    datosPieza[3] = cbNumeroGuia.Text.Trim();
                else if (chbOtroNumeroGuia.Checked == false && txtNumeroGuia.Text == "Escriba el número de guía" && destinosAgregados == 0 && (destinoLocal != "LOCAL" || destinoLocal != "CDMX" || destinoLocal != "Ciudad de México"))
                    datosPieza[3] = "-";

                datosPieza[1] = txtCantidad.Text.Trim();

                //Referente a pieza
                if (editarPieza == 1 && chbOtroPieza.Checked == false && chbOtroPieza.Text == "Modificar")
                    datosPieza[0] = txtPiezaNombre.Text.Trim().ToUpper();
                else if (chbOtroPieza.Checked == true && chbOtroPieza.Text != "Modificar")
                {
                    datosPieza[0] = txtPiezaNombre.Text.Trim().ToUpper();
                    operacion.registrarPieza(txtPiezaNombre.Text.Trim().ToUpper());
                }
                else if (chbOtroPieza.Checked == false && chbOtroPieza.Text != "Modificar")
                    datosPieza[0] = cbPiezaNombre.Text.Trim().ToUpper();

                //Referente a portal
                if (editarPieza == 1 && chbOtroPortal.Checked == false && chbOtroPortal.Text == "Modificar")
                    datosPieza[4] = txtPortal.Text.Trim();
                else if (chbOtroPortal.Checked == true && chbOtroPortal.Text != "Modificar")
                {
                    datosPieza[4] = txtPortal.Text.Trim();
                    operacion.registrarPortal(txtPortal.Text.Trim());
                }
                else if (chbOtroPortal.Checked == false && chbOtroPortal.Text != "Modificar")
                    datosPieza[4] = cbPortal.Text.Trim();

                //Referente a origen
                if (editarPieza == 1 && chbOtroOrigen.Checked == false && chbOtroOrigen.Text == "Modificar")
                    datosPieza[5] = txtOrigen.Text.Trim().ToUpper();
                else if (chbOtroOrigen.Checked == true && chbOtroOrigen.Text != "Modificar")
                {
                    datosPieza[5] = txtOrigen.Text.Trim().ToUpper();
                    operacion.registrarOrigen(txtOrigen.Text.Trim().ToUpper());
                }
                else if (chbOtroOrigen.Checked == false && chbOtroOrigen.Text != "Modificar")
                    datosPieza[5] = cbOrigen.Text.Trim().ToUpper();

                //Referente a proveedor
                if (editarPieza == 1 && chbOtroProveedor.Checked == false && chbOtroProveedor.Text == "Modificar")
                    datosPieza[6] = txtProveedor.Text.Trim().ToUpper();
                else if (chbOtroProveedor.Checked == true && chbOtroProveedor.Text != "Modificar")
                {
                    datosPieza[6] = txtProveedor.Text.Trim().ToUpper();
                    operacion.registrarProveedor(txtProveedor.Text.Trim().ToUpper());
                }
                else if (chbOtroProveedor.Checked == false && chbOtroProveedor.Text != "Modificar")
                    datosPieza[6] = cbProveedores.Text.Trim().ToUpper();

                MessageBOX mes = new MessageBOX(4, "¿Los datos son correctos?");
                if (mes.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
        /// The txtCostoSinIVA_Leave.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>


        private void txtPiezaNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPiezaNombre.Text.Trim()))
            {
                txtPiezaNombre.Text = "Escriba nombre de pieza";
                txtPiezaNombre.ForeColor = Color.FromArgb(160, 160, 140);
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

        private void chbOtroNumeroGuia_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroNumeroGuia.Text == "Modificar" && chbOtroNumeroGuia.Checked == true)
            {
                txtNumeroGuia.ReadOnly = false;
                cbNumeroGuia.Visible = true;
                txtNumeroGuia.Visible = false;
                txtNumeroGuia.Text = "Escriba el número de guía";
                txtNumeroGuia.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroNumeroGuia.Text = "Otro";
                chbOtroNumeroGuia.Checked = false;
            }

            if (chbOtroNumeroGuia.Text == "Otro" && chbOtroNumeroGuia.Checked == true)
            {
                txtNumeroGuia.Visible = true;
                cbNumeroGuia.Hide();
                //cbNumeroGuia.SelectedIndex = -1;
            }
            else
            {
                cbNumeroGuia.Show();
                txtNumeroGuia.Clear();
                txtNumeroGuia.Visible = false;
                txtNumeroGuia.Text = "Escriba el número de guía";
                txtNumeroGuia.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtPiezaNombre_Enter(object sender, EventArgs e)
        {
            if (txtPiezaNombre.Text == "Escriba nombre de pieza")
            {
                txtPiezaNombre.Text = "";
                txtPiezaNombre.ForeColor = Color.White;
            }
        }

        private void txtNumeroGuia_Enter(object sender, EventArgs e)
        {
            if (txtNumeroGuia.Text == "Escriba el número de guía")
            {
                txtNumeroGuia.Text = "";
                txtNumeroGuia.ForeColor = Color.White;
            }
        }

        private void txtPortal_Enter(object sender, EventArgs e)
        {
            if (txtPortal.Text == "Escriba un nuevo portal")
            {
                txtPortal.Text = "";
                txtPortal.ForeColor = Color.White;
            }
        }

        private void txtOrigen_Enter(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "Escriba un nuevo origen")
            {
                txtOrigen.Text = "";
                txtOrigen.ForeColor = Color.White;
            }
        }

        private void txtProveedor_Enter(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "Escriba un nuevo proveedor")
            {
                txtProveedor.Text = "";
                txtProveedor.ForeColor = Color.White;
            }
        }

        private void txtPiezaNombre_Validating(object sender, CancelEventArgs e)
        {
            OperBD operacion = new OperBD();
            if (chbOtroPieza.Checked == true && chbOtroPieza.Text != "Modificar")
            {
                if (txtPiezaNombre.Text == "Escriba nombre de pieza")// && string.IsNullOrEmpty(txtPiezaNombre.Text)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPiezaNombre, "Favor de escribir un nuevo nombre de pieza");
                }
                else if (!string.IsNullOrEmpty(operacion.existePieza(txtPiezaNombre.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPiezaNombre, "Ya existe una pieza con el mismo nombre");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtPiezaNombre, null);
                }
            }
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                e.Cancel = true;
                //txtCantidad.Focus();
                errorProvider1.SetError(txtCantidad, "Favor de ingresar cantidad");
            }
            else if (txtCantidad.Text.Trim() == "0")
            {
                errorProvider1.SetError(txtCantidad, "No se admite tener cantidad cero");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCantidad, null);
            }
        }

        private void txtClaveProducto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveProducto.Text))// || txtClaveProducto.Text.Trim() == "Escriba clave del producto"
            {
                e.Cancel = true;
                //txtClaveProducto.Focus();
                errorProvider1.SetError(txtClaveProducto, "Favor de escribir clave del producto");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtClaveProducto, null);
            }
        }

        private void txtNumeroGuia_Validating(object sender, CancelEventArgs e)
        {
            if (destinoLocal != "LOCAL" && destinoLocal != "CDMX" && destinoLocal != "Ciudad de México")
            {
                if (chbOtroNumeroGuia.Checked == false && chbOtroNumeroGuia.Text != "Modificar" && destinosAgregados == 0)
                {
                    if (txtNumeroGuia.Text == "Escriba el número de guía")// || string.IsNullOrEmpty(txtNumeroGuia.Text)
                    {
                        e.Cancel = true;
                        //txtNumeroGuia.Focus();
                        errorProvider1.SetError(txtNumeroGuia, "Favor de escribir un nuevo número de guía");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txtNumeroGuia, null);
                    }
                }
                else if (chbOtroNumeroGuia.Checked == true && chbOtroNumeroGuia.Text != "Modificar" && destinosAgregados > 0)
                {
                    if (txtNumeroGuia.Text == "Escriba el número de guía")// || string.IsNullOrEmpty(txtNumeroGuia.Text)
                    {
                        e.Cancel = true;
                        //txtNumeroGuia.Focus();
                        errorProvider1.SetError(txtNumeroGuia, "Favor de escribir un nuevo número de guía");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txtNumeroGuia, null);
                    }
                }
            }
        }

        private void txtPortal_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroPortal.Checked == true && chbOtroPortal.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (txtPortal.Text == "Escriba un nuevo portal")// || string.IsNullOrEmpty(txtPortal.Text)
                {
                    e.Cancel = true;
                    //txtPortal.Focus();
                    errorProvider1.SetError(txtPortal, "Favor de escribir un nuevo portal");
                }
                else if (!string.IsNullOrEmpty(operacion.existePortal(txtPortal.Text.Trim())))
                {
                    e.Cancel = true;
                    //txtPortal.Focus();
                    errorProvider1.SetError(txtPortal, "Ya existe un portal con el mismo nombre");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtPortal, null);
                }
            }
        }

        private void txtOrigen_Validating(object sender, CancelEventArgs e)
        {
            OperBD operacion = new OperBD();
            if (chbOtroOrigen.Checked == true && chbOtroOrigen.Text != "Modificar")
            {
                if (txtOrigen.Text == "Escriba un nuevo origen")// || string.IsNullOrEmpty(txtOrigen.Text)
                {
                    e.Cancel = true;
                    //txtOrigen.Focus();
                    errorProvider1.SetError(txtOrigen, "Favor de escribir un nuevo origen");
                }
                else if (!string.IsNullOrEmpty(operacion.existeOrigen(txtOrigen.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    //txtOrigen.Focus();
                    errorProvider1.SetError(txtOrigen, "Ya existe un origen con el mismo nombre");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtOrigen, null);
                }
            }
        }

        private void txtProveedor_Validating(object sender, CancelEventArgs e)
        {
            OperBD operacion = new OperBD();
            if (chbOtroProveedor.Checked == true && chbOtroProveedor.Text != "Modificar")
            {
                if (txtProveedor.Text == "Escriba un nuevo proveedor")// || string.IsNullOrEmpty(txtProveedor.Text)
                {
                    e.Cancel = true;
                    //txtClaveProducto.Focus();
                    errorProvider1.SetError(txtProveedor, "Favor de escribir un nuevo proveedor");
                }
                else if (!string.IsNullOrEmpty(operacion.existeProveedor(txtProveedor.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    //txtClaveProducto.Focus();
                    errorProvider1.SetError(txtProveedor, "Ya existe un proveedor con el mismo nombre");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtProveedor, null);
                }
            }
        }

        private void txtPrecioReparacion_Validating(object sender, CancelEventArgs e)
        {
            if (cbOrigen.Text.Trim() == "USADA")
            {
                if (string.IsNullOrEmpty(txtPrecioReparacion.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPrecioReparacion, "Proporcionar costo de reparación debido a tipo de origen");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtPrecioReparacion, null);
                }
            }
        }

        private string claveProducto(string modelo, string descripcion, string marca, string anio)
        {
            string clave = "";
            try
            {
                
                if (modelo.Length < 3)
                    modelo = modelo.Substring(0, modelo.Length);
                else
                    modelo = modelo.Substring(0, 3);
                return clave = descripcion.Substring(0, 4) + "-" + modelo + marca.Substring(0, 2) + anio.Substring(2, 2);
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Error al cargar la pieza");
            }
            return clave;
        }

        private void txtPiezaNombre_TextChanged(object sender, EventArgs e)
        {
            txtClaveProducto.Text = claveProducto(modelo, txtPiezaNombre.Text.Trim().ToUpper(), marca, anio);
        }

        private void cbPiezaNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validar con checkbox
            txtClaveProducto.Text = claveProducto(modelo,cbPiezaNombre.Text,marca,anio);
        }

        private void cbCostoEnvio_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            
        }

        private void txtCostoNeto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCostoNeto.Text.Trim()))
            {
                e.Cancel = true;
                //txtCantidad.Focus();
                errorProvider1.SetError(txtCostoNeto, "Favor de ingresar cantidad");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCostoNeto, null);
            }
        }

        private void txtPrecioVenta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()))
            {
                e.Cancel = true;
                //txtCantidad.Focus();
                errorProvider1.SetError(txtPrecioVenta, "Favor de ingresar cantidad");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrecioVenta, null);
            }
        }

        private void cbPiezaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbPiezaNombre.DroppedDown = false;
        }

        private void cbNumeroGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbNumeroGuia.DroppedDown = false;
        }

        private void cbPortal_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbPortal.DroppedDown = false;
        }

        private void cbOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbOrigen.DroppedDown = false;
        }

        private void cbProveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbProveedores.DroppedDown = false;
        }

        private void cbPiezaNombre_Validating(object sender, CancelEventArgs e)
        {
            if(chbOtroPieza.Checked == false && chbOtroPieza.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbPiezaNombre.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbPiezaNombre, "Favor de seleccionar una pieza");
                }
                else if (string.IsNullOrEmpty(operacion.existePieza(cbPiezaNombre.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbPiezaNombre, "Favor de seleccionar una pieza existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbPiezaNombre, null);
                }
            }
        }

        private void cbNumeroGuia_Validating(object sender, CancelEventArgs e)
        {
            if(destinosAgregados == 1 && chbOtroNumeroGuia.Checked == false)
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbNumeroGuia.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbNumeroGuia, "Favor de seleccionar el número de guía");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbNumeroGuia, null);
                }
            }
        }

        private void cbPortal_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroPortal.Checked == false && chbOtroPortal.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbPortal.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbPortal, "Favor de seleccionar un portal");
                }
                else if (string.IsNullOrEmpty(operacion.existePortal(cbPortal.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbPortal, "Favor de seleccionar un portal existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbPortal, null);
                }
            }
        }

        private void cbOrigen_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroOrigen.Checked == false && chbOtroOrigen.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbOrigen.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbOrigen, "Favor de seleccionar un origen");
                }
                else if (string.IsNullOrEmpty(operacion.existeOrigen(cbOrigen.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbOrigen, "Favor de seleccionar un origen existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbOrigen, null);
                }
            }
        }

        private void cbProveedores_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroProveedor.Checked == false && chbOtroProveedor.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbProveedores.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbProveedores, "Favor de seleccionar un proveedor");
                }
                else if (string.IsNullOrEmpty(operacion.existeProveedor(cbProveedores.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbProveedores, "Favor de seleccionar un proveedor existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbProveedores, null);
                }
            }
        }
    }
}