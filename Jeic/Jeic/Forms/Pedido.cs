using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.Excel;

//using iText.Kernel.Colors;
using DocumentFormat.OpenXml.Presentation;

//usings para generar PDF
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using Jeic.Forms;
using Jeic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Refracciones.Forms
{
    public partial class Pedido : Form
    {
        private OperBD operacion = new OperBD();
        private DataTable dt;

        private int actualizar = 0;

        public Pedido(int i)
        {
            InitializeComponent();
            //para que toda la clase sepa que está en el modo actualización
            actualizar = i;
        }

        public string textBoxPedido
        {
            set { txtClavePedido.Text = value; }
        }

        public string labelSiniestro
        {
            set { lblClaveSiniestro.Text = value; }
        }

        public string labelAnio
        {
            set { lblAnio.Text = value; }
        }

        private void columnaCombobox()
        {
            //Agregando combobox en DGV
            var comboboxDgv = new DataGridViewComboBoxColumn();
            comboboxDgv.FlatStyle = FlatStyle.Popup;
            comboboxDgv.HeaderText = "Estado";
            comboboxDgv.Name = "dataGridViewStatusCombobox";
            comboboxDgv.DataPropertyName = "Estado";
            comboboxDgv.DataSource = operacion.EstadoSiniestro().Tables[0].DefaultView;
            comboboxDgv.ValueMember = "cve_estado";
            comboboxDgv.DisplayMember = "estado";
            comboboxDgv.AutoComplete = true;
            this.dgvPedido.Columns.Add(comboboxDgv);
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            //Agregar columna estado combobox a DGV
            columnaCombobox();

            if (actualizar == 1)
            {
                //Para que se tenga éxito en desactivar un botón del DGV y se pueda invocar el método "SetDGVButtonColumnEnable"
                //Se debe hacer un objeto de tipo: DataGridViewDisableButtonColumn
                var darBajaButton = new DataGridViewButtonColumn();
                darBajaButton.Name = "dataGridViewDarBajaButton";
                darBajaButton.HeaderText = "Dar de baja";
                darBajaButton.Text = "Dar de baja";
                darBajaButton.FlatStyle = FlatStyle.Popup;
                darBajaButton.CellTemplate.Style.BackColor = Color.DarkGoldenrod;
                ///--------- ATENCIÓN---------
                ///Se comentó esta línea para poder dar nombres diferentes de acuerdo a las condiciones que se evalúen
                //darBajaButton.UseColumnTextForButtonValue = true;
                this.dgvPedido.Columns.Add(darBajaButton);

                var penaltyButton = new DataGridViewButtonColumn();
                penaltyButton.Name = "dataGridViewPenaltyButton";
                penaltyButton.HeaderText = "Penalizar";
                penaltyButton.Text = "Penalizar";
                penaltyButton.FlatStyle = FlatStyle.Popup;
                penaltyButton.CellTemplate.Style.BackColor = Color.DarkViolet;
                ///--------- ATENCIÓN---------
                ///Se comentó esta línea para poder dar nombres diferentes de acuerdo a las condiciones que se evalúen
                //penaltyButton.UseColumnTextForButtonValue = true;;
                this.dgvPedido.Columns.Add(penaltyButton);
            }

            var editButton = new DataGridViewButtonColumn();
            editButton.Name = "dataGridViewEditButton";
            editButton.HeaderText = "Editar";
            editButton.Text = "Editar";
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.CellTemplate.Style.BackColor = Color.DarkCyan;
            editButton.UseColumnTextForButtonValue = true;
            this.dgvPedido.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Eliminar";
            deleteButton.Text = "Eliminar";
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.CellTemplate.Style.BackColor = Color.Red;
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgvPedido.Columns.Add(deleteButton);

            dt = new DataTable();
            dt.Columns.Add("Pieza");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Clave de producto");
            dt.Columns.Add("Número de guía");
            dt.Columns.Add("Portal");
            dt.Columns.Add("Origen");
            dt.Columns.Add("Proveedor");
            dt.Columns.Add("Fecha costo");
            //dt.Columns.Add("Costo sin IVA");
            dt.Columns.Add("Costo neto\n($)");
            dt.Columns.Add("Costo de envío\n($)");
            dt.Columns.Add("Precio de venta\n($)");
            dt.Columns.Add("Precio de reparación\n($)");
            dgvPedido.DataSource = dt;

            //Impedir que se ordenen de otra forma (podría alterar) comprobar si se necesita
            foreach (DataGridViewColumn column in dgvPedido.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Carga los datos registros de vendedores en el combobox
            cbVendedor.DataSource = operacion.VendedoresRegistrados(1).Tables[0].DefaultView;
            cbVendedor.ValueMember = "nombre";

            //Carga los datos registros de clientes/aseguradoras en el combobox
            cbAseguradora.DataSource = operacion.ClientesRegistrados(1).Tables[0].DefaultView;
            cbAseguradora.ValueMember = "cve_nombre";

            //Carga los datos registros de talleres en el combobox
            cbTaller.DataSource = operacion.TalleresRegistrados(1).Tables[0].DefaultView;
            cbTaller.ValueMember = "nombre";

            //Carga los datos registros de destinos en el combobox
            cbDestino.DataSource = operacion.DestinosRegistrados().Tables[0].DefaultView;
            cbDestino.ValueMember = "destino";

            if (actualizar == 0)
            {
                
                btnModificarSiniestro.Hide();
            }

            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            Eleccion eleccion = new Eleccion();
            if (actualizar == 1)
            {
                label1.Hide();
                rdbSi.Hide();
                rdbNo.Hide();

                btnPenalizarPedido.Visible = true;
                btnPenalizarPedido.Enabled = true;

                lblClaveSiniestroPedido.Visible = true;
                lblClaveSiniestro.Visible = true;

                lblMarcaPedido.Visible = true;
                lblMarca.Visible = true;
                lblMarca.Text = operacion.Marca(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                lblVehiculoPedido.Visible = true;
                lblVehiculo.Visible = true;
                lblVehiculo.Text = operacion.Vehiculo(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                lblAnioPedido.Visible = true;
                lblAnio.Visible = true;
                lblAnio.Text = operacion.Anio(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                lblComentarioSiniestro.Visible = true;
                txtComentarioSiniestro.Visible = true;
                txtComentarioSiniestro.Text = operacion.Comentario(lblClaveSiniestro.Text.Trim());

                txtClavePedido.Enabled = false;
                btnFinalizarPedido.Text = "Actualizar pedido";
                btnFinalizarPedido.Enabled = true;

                chbModificarVendedor.Visible = true;
                txtVendedor.Show();
                cbVendedor.Hide();
                txtVendedor.Text = operacion.Vendedor(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                chbModificarVendedor.Text = "Modificar";
                chbModificarVendedor.Enabled = true;

                chbOtroValuador.Enabled = true;
                chbOtroValuador.Text = "Modificar";
                cbValuador.Hide();
                txtValuador.Text = operacion.Valuador(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                txtValuador.Enabled = false;

                chbOtraAseguradora.Enabled = true;
                chbOtraAseguradora.Text = "Modificar";
                cbAseguradora.Hide();
                txtAseguradora.Text = operacion.Cliente(txtValuador.Text);
                txtAseguradora.Enabled = false;

                //Carga los datos registros de valuadores en el combobox
                cbValuador.DataSource = operacion.ValuadoresRegistrados(txtAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";

                chbOtroTaller.Enabled = true;
                chbOtroTaller.Text = "Modificar";
                cbTaller.Hide();
                txtTaller.Text = operacion.Taller(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                txtTaller.Enabled = false;

                chbOtroDestino.Enabled = true;
                chbOtroDestino.Text = "Modificar";
                cbDestino.Hide();
                txtDestino.Text = operacion.Destino(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                txtDestino.Enabled = false;

                chbModificarFechaAsignacion.Visible = true;
                dtpFechaAsignacion.Text = operacion.fechaAsignacion(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                chbModificarFechaPromesa.Visible = true;
                dtpFechaPromesa.Text = operacion.fechaPromesa(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                dt = operacion.piezasPedidoActualizar(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                dgvPedido.DataSource = dt;

                //Agregando combobox en DGV
                //columnaCombobox();

                double precioTotal = 0; int piezasTotal = 0; nombrePieza = new string[Convert.ToInt32(dgvPedido.Rows.Count)]; int i = 0; filasIniciales = dgvPedido.Rows.Count;
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    //Comprobar si existe orden de captura para que no aparezca null
                    if (string.IsNullOrEmpty(operacion.existePiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, Convert.ToString(row.Cells["Pieza"].Value), i)))
                        operacion.actualizarOrdenCaptura(txtClavePedido.Text, lblClaveSiniestro.Text, Convert.ToString(row.Cells["Pieza"].Value), i, 0, 1);

                    //Para poder desactivar los botones en caso de que ya se hayan dado de baja
                    int index = i;
                    if (!string.IsNullOrEmpty(operacion.existeFechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text, Convert.ToString(row.Cells["Pieza"].Value), index)))
                        row.Cells["dataGridViewDarBajaButton"].Value = "Registrado";
                    else
                        row.Cells["dataGridViewDarBajaButton"].Value = "Dar de baja";

                    if (!string.IsNullOrEmpty(operacion.existePenalizacion(Convert.ToString(row.Cells["Pieza"].Value), txtClavePedido.Text, lblClaveSiniestro.Text, index)))
                        row.Cells["dataGridViewPenaltyButton"].Value = "Penalizado";
                    else
                        row.Cells["dataGridViewPenaltyButton"].Value = "Penalizar";

                    //Carga los estados que se tienen de cada pieza
                    row.Cells["dataGridViewStatusCombobox"].Value = operacion.estadoSiniestroClaves(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), i);

                    precioTotal += Convert.ToDouble(row.Cells["Precio de venta\n($)"].Value);
                    piezasTotal += Convert.ToInt32(row.Cells["Cantidad"].Value);
                    nombresPiezas.Add(row.Cells["Pieza"].Value.ToString());
                    ordenCapturaIndice.Add(i);
                    //nombrePieza[i] = Convert.ToString(row.Cells["Pieza"].Value);
                    i += 1;
                }
                lblPrecioTotal.Text = "$" + precioTotal.ToString();
                lblCantidadTotal.Text = piezasTotal.ToString();
            }
            else
            {
                lblVehiculoPedido.Hide();
                lblVehiculo.Hide();
                lblAnioPedido.Hide();
                lblAnio.Hide();
                lblClaveSiniestro.Hide();
                lblClaveSiniestroPedido.Hide();
                txtAseguradora.Hide();
                txtValuador.Hide();
                txtTaller.Hide();
                txtDestino.Hide();

                lblComentarioSiniestro.Hide();
                txtComentarioSiniestro.Hide();

                //Carga los datos registros de valuadores en el combobox
                cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";
            }
        }

        //Parámetros que sirven al momento de actualizar formulario
        private string[] nombrePieza;

        private List<string> nombresPiezas = new List<string>();
        private List<int> ordenCapturaIndice = new List<int>();

        private int filasIniciales;

        //Saber si se va a registrar un nuevo modelo de vehículo o marca
        private bool nuevoVehiculo;

        private bool nuevoMarca;

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (rdbSi.Checked == true)
                    {
                        btnLimpiarSiniestro.Visible = false;
                        rdbNo.Checked = false;
                        lblClaveSiniestroPedido.Visible = false;
                        lblClaveSiniestro.Visible = false;
                        lblClaveSiniestro.Text = "";
                        lblAnioPedido.Visible = false;
                        lblAnio.Visible = false;
                        lblVehiculoPedido.Visible = false;
                        lblVehiculo.Visible = false;
                        lblMarcaPedido.Visible = false;
                        lblMarca.Visible = false;
                        lblComentarioSiniestro.Visible = false;
                        txtComentarioSiniestro.Visible = false;

                        Siniestro siniestro = new Siniestro();
                        DialogResult respuesta = siniestro.ShowDialog();

                        if (respuesta == DialogResult.OK)
                        {
                            rdbNo.Enabled = false;
                            rdbSi.Enabled = false;
                            btnLimpiarSiniestro.Visible = true;
                            nuevoVehiculo = siniestro.otroVehiculo;
                            nuevoMarca = siniestro.otroMarca;

                            lblClaveSiniestroPedido.Show();
                            lblClaveSiniestro.Show();
                            lblClaveSiniestro.Text = siniestro.claveSiniestro;

                            lblVehiculoPedido.Show();
                            lblVehiculo.Show();
                            lblVehiculo.Text = siniestro.vehiculoSiniestro;

                            lblAnioPedido.Show();
                            lblAnio.Show();
                            lblAnio.Text = siniestro.anioSiniestro;

                            lblMarcaPedido.Show();
                            lblMarca.Show();
                            lblMarca.Text = siniestro.marcaSiniestro;

                            lblComentarioSiniestro.Show();
                            txtComentarioSiniestro.Show();
                            this.ActiveControl = txtComentarioSiniestro;
                            if (siniestro.comentario == "Agregue un comentario")
                                txtComentarioSiniestro.Text = "Sin comentario por el momento";
                            else
                                txtComentarioSiniestro.Text = siniestro.comentario;
                        }
                        else
                            rdbSi.Checked = false;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el evento rdbSi_CheckedChanged: " + Ex.Message);
            }
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (rdbNo.Checked == true)
                    {
                        btnLimpiarSiniestro.Visible = false;
                        rdbSi.Checked = false;
                        lblClaveSiniestroPedido.Visible = false;
                        lblClaveSiniestro.Visible = false;
                        lblClaveSiniestro.Text = "";
                        lblAnioPedido.Visible = false;
                        lblAnio.Visible = false;
                        lblVehiculoPedido.Visible = false;
                        lblVehiculo.Visible = false;
                        lblMarcaPedido.Visible = false;
                        lblMarca.Visible = false;
                        lblComentarioSiniestro.Visible = false;
                        txtComentarioSiniestro.Visible = false;

                        Siniestro siniestro = new Siniestro();
                        siniestro.claveNOSiniestro = "JEIC-" + operacion.TotalSiniestro().ToString();
                        DialogResult respuesta = siniestro.ShowDialog();

                        if (respuesta == DialogResult.OK)
                        {
                            btnLimpiarSiniestro.Visible = true;
                            nuevoVehiculo = siniestro.otroVehiculo;
                            nuevoMarca = siniestro.otroMarca;

                            lblClaveSiniestroPedido.Show();
                            lblClaveSiniestro.Show();
                            lblClaveSiniestro.Text = siniestro.claveSiniestro;

                            lblVehiculoPedido.Show();
                            lblVehiculo.Show();
                            lblVehiculo.Text = siniestro.vehiculoSiniestro;

                            lblAnioPedido.Show();
                            lblAnio.Show();
                            lblAnio.Text = siniestro.anioSiniestro;

                            lblMarcaPedido.Show();
                            lblMarca.Show();
                            lblMarca.Text = siniestro.marcaSiniestro;

                            lblComentarioSiniestro.Show();
                            txtComentarioSiniestro.Show();
                            this.ActiveControl = txtComentarioSiniestro;
                            if (siniestro.comentario == "Agregue un comentario")
                                txtComentarioSiniestro.Text = "Sin comentario por el momento";
                            else
                                txtComentarioSiniestro.Text = siniestro.comentario;
                        }
                        else
                            rdbNo.Checked = false;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el evento rdbNo_CheckedChanged: " + Ex.Message);
            }
        }

        private void chbOtraAseguradora_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtraAseguradora.Text == "Modificar" && chbOtraAseguradora.Checked == true)
            {
                cbAseguradora.Visible = true;
                cbAseguradora.Enabled = true;
                txtAseguradora.Enabled = true;
                txtAseguradora.Clear();
                txtAseguradora.Visible = false;
                txtAseguradora.Text = "Escriba el nombre del cliente";
                txtAseguradora.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtraAseguradora.Text = "Otro";
                chbOtraAseguradora.Checked = false;
                chbOtroValuador.Checked = true;
                //Carga los datos registros de valuadores en el combobox
                cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";
            }

            if (chbOtraAseguradora.Text == "Otro" && chbOtraAseguradora.Checked == true)
            {
                txtAseguradora.Show();
                cbAseguradora.Hide();
                //cbAseguradora.SelectedIndex = -1;

                chbOtroValuador.Checked = true;
                chbOtroValuador.Text = "Otro";
                chbOtroValuador.Enabled = false;

                lblDiasEspera.Visible = true;
                txtDiasEspera.Visible = true;
            }
            else if (chbOtraAseguradora.Text == "Otro" && chbOtraAseguradora.Checked == false)
            {
                txtAseguradora.Hide();
                txtAseguradora.Text = "Escriba el nombre del cliente";
                txtAseguradora.ForeColor = Color.FromArgb(160, 160, 140);
                cbAseguradora.Show();

                chbOtroValuador.Checked = false;
                chbOtroValuador.Enabled = true;

                lblDiasEspera.Visible = false;
                txtDiasEspera.Visible = false;
            }
        }

        private void chbOtroValuador_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroValuador.Text == "Modificar" && chbOtroValuador.Checked == true)
            {
                cbValuador.Visible = true;
                cbValuador.Enabled = true;
                txtValuador.Enabled = true;
                txtValuador.Clear();
                txtValuador.Visible = false;
                txtValuador.Text = "Escriba nombre del valuador";
                txtValuador.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroValuador.Text = "Otro";
                chbOtroValuador.Checked = false;
            }

            if (chbOtroValuador.Text == "Otro" && chbOtroValuador.Checked == true)
            {
                txtValuador.Show();
                cbValuador.Hide();
            }
            else if (chbOtroValuador.Text == "Otro" && chbOtroValuador.Checked == false)
            {
                txtValuador.Hide();
                txtValuador.Text = "Escriba nombre del valuador";
                txtValuador.ForeColor = Color.FromArgb(160, 160, 140);
                cbValuador.Show();
            }
        }

        private void chbOtroTaller_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroTaller.Text == "Modificar" && chbOtroTaller.Checked == true)
            {
                cbTaller.Visible = true;
                cbTaller.Enabled = true;
                txtTaller.Enabled = true;
                txtTaller.Clear();
                txtTaller.Visible = false;
                txtTaller.Text = "Escriba nombre de taller";
                txtTaller.ForeColor = Color.FromArgb(160, 160, 140);
                txtDireccion.Text = "Escriba dirección del taller";
                txtDireccion.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroTaller.Text = "Otro";
                chbOtroTaller.Checked = false;
            }

            if (chbOtroTaller.Text == "Otro" && chbOtroTaller.Checked == true)
            {
                txtTaller.Show();
                cbTaller.Hide();
                txtDireccion.Show();
                lblDireccion.Show();
                txtCiudad.Show();
                lblCiudad.Show();
                txtContacto.Show();
                lblContacto.Show();
                lblTelefono.Show();
                txtTelefono.Show();
                lblHorario.Show();
                txtHorario.Show();
                //cbTaller.SelectedIndex = -1;
            }
            else if (chbOtroTaller.Text == "Otro" && chbOtroTaller.Checked == false)
            {
                txtTaller.Hide();
                txtTaller.Text = "Escriba nombre de taller";
                txtTaller.ForeColor = Color.FromArgb(160, 160, 140);
                txtDireccion.Hide();
                txtDireccion.Text = "Escriba dirección del taller";
                txtDireccion.ForeColor = Color.FromArgb(160, 160, 140);
                txtDireccion.Hide();
                lblDireccion.Hide();
                txtCiudad.Hide();
                lblCiudad.Hide();
                txtContacto.Hide();
                lblContacto.Hide();
                lblTelefono.Hide();
                txtTelefono.Hide();
                lblHorario.Hide();
                txtHorario.Hide();
                cbTaller.Show();
            }
        }

        private void chbOtroDestino_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroDestino.Text == "Modificar" && chbOtroDestino.Checked == true)
            {
                cbDestino.Visible = true;
                cbDestino.Enabled = true;
                txtDestino.Enabled = true;
                txtDestino.Clear();
                txtDestino.Visible = false;
                txtDestino.Text = "Escriba el destino";
                txtDestino.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroDestino.Text = "Otro";
                chbOtroDestino.Checked = false;
            }

            if (chbOtroDestino.Text == "Otro" && chbOtroDestino.Checked == true)
            {
                txtDestino.Show();
                cbDestino.Hide();
                //cbDestino.SelectedIndex = -1;
            }
            else if (chbOtroDestino.Text == "Otro" && chbOtroDestino.Checked == false)
            {
                txtDestino.Hide();
                txtDestino.Text = "Escriba el destino";
                txtDestino.ForeColor = Color.FromArgb(160, 160, 140);
                cbDestino.Show();
                lblDireccion.Hide();
            }
        }

        private void dtpFechaPromesa_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dtpFechaAsignacion.Value.Date;
            DateTime dt2 = dtpFechaPromesa.Value.Date;
            int resta = DateTime.Compare(dt1, dt2);
            if (actualizar == 1)
            {
                if (resta > 0)
                {
                    MessageBOX.SHowDialog(2, "No es posible elegir esta fecha");
                    dtpFechaPromesa.Text = operacion.fechaPromesa(txtClavePedido.Text, lblClaveSiniestro.Text);
                }
            }
            else
            {
                if (resta > 0)
                {
                    MessageBOX.SHowDialog(2, "No es posible elegir esta fecha");
                    dtpFechaPromesa.Text = dtpFechaAsignacion.Text;
                }
            }
        }

        //Variables
        private string vendedor = "";

        private string aseguradora = "";
        private string valuador = "";
        private string taller = "";
        private string destino = "";

        private void aniadirNuevosRegistros()
        {
            if (chbModificarVendedor.Checked == true && chbModificarVendedor.Text == "Otro")
            {
                vendedor = txtVendedor.Text.Trim().ToUpper();
                operacion.registrarVendedor(Convert.ToInt32(txtNumeroEmpleado.Text.Trim()), vendedor);
            }
            else if (chbModificarVendedor.Checked == false && chbModificarVendedor.Text == "Otro")
                vendedor = cbVendedor.Text.Trim();
            else if (chbModificarVendedor.Checked == false && chbModificarVendedor.Text == "Modificar")
                vendedor = txtVendedor.Text.Trim().ToUpper();

            if (chbOtraAseguradora.Checked == true && chbOtraAseguradora.Text == "Otro")
            {
                aseguradora = txtAseguradora.Text.Trim().ToUpper();
                operacion.registrarCliente(aseguradora, Convert.ToInt32(txtDiasEspera.Text.Trim()));
            }
            else if (chbOtraAseguradora.Checked == false && chbOtraAseguradora.Text == "Otro")
                aseguradora = cbAseguradora.Text.Trim();
            else if (chbOtraAseguradora.Checked == false && chbOtraAseguradora.Text == "Modificar")
                aseguradora = txtAseguradora.Text.Trim().ToUpper();

            if (chbOtroValuador.Checked == true && chbOtroValuador.Text == "Otro")
            {
                valuador = txtValuador.Text.Trim().ToUpper();
                operacion.registrarValuador(valuador, aseguradora);
            }
            else if (chbOtroValuador.Checked == false && chbOtroValuador.Text == "Otro")
                valuador = cbValuador.Text.Trim();
            else if (chbOtroValuador.Checked == false && chbOtroValuador.Text == "Modificar")
                valuador = txtValuador.Text.Trim().ToUpper();

            if (chbOtroTaller.Checked == true && chbOtroTaller.Text == "Otro")
            {
                taller = txtTaller.Text.Trim().ToUpper();
                operacion.registrarTaller(taller, txtDireccion.Text.Trim(), txtCiudad.Text.Trim(), txtTelefono.Text.Trim(), txtContacto.Text.Trim(), txtHorario.Text.Trim());
            }
            else if (chbOtroTaller.Checked == false && chbOtroTaller.Text == "Otro")
                taller = cbTaller.Text.Trim();
            else if (chbOtroTaller.Checked == false && chbOtroTaller.Text == "Modificar")
                taller = txtTaller.Text.Trim().ToUpper();

            if (chbOtroDestino.Checked == true && chbOtroDestino.Text == "Otro")
            {
                destino = txtDestino.Text.Trim().ToUpper();
                operacion.registrarDestino(destino);
            }
            else if (chbOtroDestino.Checked == false && chbOtroDestino.Text == "Otro")
                destino = cbDestino.Text.Trim();
            else if (chbOtroDestino.Checked == false && chbOtroDestino.Text == "Modificar")
                destino = txtDestino.Text.Trim().ToUpper();
        }

        //Variables
        private double totalCosto = 0;

        private double subtotalPrecio = 0;
        private double totalPrecio = 0;
        private double utilidad = 0;

        private void calcularDGV()
        {
            try
            {
                //si numero de guia se encuentra no ese array se añade a ese array y va a ir guardando en otra variable la suma del costo de envio
                string[] guia = new string[dgvPedido.Rows.Count];
                int i = 0;

                //double totalCostoEnvio = 0; Ya no es tan necesaria puesto que se le tiene que sumar a la variable subtotalPrecio
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    totalCosto += /*Convert.ToInt32(row.Cells["Cantidad"].Value) **/ Convert.ToDouble(row.Cells["Costo neto\n($)"].Value);
                    subtotalPrecio += /*(Convert.ToInt32(row.Cells["Cantidad"].Value) **/ Convert.ToDouble(row.Cells["Precio de venta\n($)"].Value) /*+ Convert.ToDouble(row.Cells["Precio de reparación"].Value)*/;
                    /*if (!guia.Contains(Convert.ToString(row.Cells["Número de guía"].Value)))
                     {
                         guia[i] = Convert.ToString(row.Cells["Número de guía"].Value);
                         //totalCostoEnvio += Convert.ToDouble(row.Cells["Costo de envío"].Value);
                         subtotalPrecio += Convert.ToDouble(row.Cells["Costo de envío"].Value);
                         i++;
                     }*/
                }
                subtotalPrecio = subtotalPrecio / (1 + 0.16);
                totalPrecio = Convert.ToDouble(lblPrecioTotal.Text.Substring(1, lblPrecioTotal.Text.Length - 1));
                utilidad = totalPrecio - totalCosto;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al calcular dgv: " + Ex.Message);
            }
        }

        private int contadorOrdenActualizar = 0;

        private void registrarPedido()
        {
            try
            {
                //Contadores del método
                int ordenCaptura = 0;
                int x = 0;

                if (actualizar == 1)
                    x = 1;

                //AGREGANDO DATOS A PEDIDO
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    if (x <= contadorOrdenActualizar && actualizar == 1)
                    {
                        x++;
                    }
                    else
                    {
                        if (actualizar == 1)
                            x -= 1;

                        DateTime dtFechaCosto = new DateTime();
                        //if(row.Cells["Fecha costo"].Value != null || row.Cells["Fecha costo"].Value != DBNull.Value || row.Cells["Fecha costo"].Value.ToString() != string.Empty)
                        dtFechaCosto = DateTime.Parse(row.Cells["Fecha costo"].Value.ToString());

                        operacion = new OperBD();
                        operacion.registrarPedido(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(),
                            Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                            Convert.ToString(row.Cells["Origen"].Value).Trim(), Convert.ToString(row.Cells["Proveedor"].Value),
                            row.Cells["Fecha costo"].Value.ToString()/*, Convert.ToString(row.Cells["Costo sin IVA"].Value)*/, Convert.ToString(row.Cells["Costo neto\n($)"].Value),
                            Convert.ToString(row.Cells["Costo de envío\n($)"].Value), Convert.ToString(row.Cells["Precio de venta\n($)"].Value),
                            Convert.ToString(row.Cells["Precio de reparación\n($)"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),                                 /*Se captura correctamente el valor del combobox ya que toma el valor del ValueMember*/
                            Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value), lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9), x, Convert.ToInt32(row.Cells["dataGridViewStatusCombobox"].Value));

                        x++;
                    }
                }
                //MessageBOX.SHowDialog(1, "Se registró pedido correctamente");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en método registrar pedido: " + Ex.Message);
            }
        }

        private void actualizarPedido()
        {
            try
            {
                int x = 0;
                if (filasIniciales != 0)
                {
                    int i = 0;
                    //actualizar las piezas que ya se tenían registradas
                    foreach (DataGridViewRow row in dgvPedido.Rows)
                    {
                        DateTime dtFechaCosto = new DateTime();
                        //if(row.Cells["Fecha costo"].Value != null || row.Cells["Fecha costo"].Value != DBNull.Value || row.Cells["Fecha costo"].Value.ToString() != string.Empty)
                        dtFechaCosto = DateTime.Parse(row.Cells["Fecha costo"].Value.ToString());

                        operacion = new OperBD();
                        operacion.actualizarPedido(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(),
                            Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                            Convert.ToString(row.Cells["Origen"].Value).Trim(), Convert.ToString(row.Cells["Proveedor"].Value),
                            dtFechaCosto/*, Convert.ToString(row.Cells["Costo sin IVA"].Value)*/, Convert.ToString(row.Cells["Costo neto\n($)"].Value),
                            Convert.ToString(row.Cells["Costo de envío\n($)"].Value), Convert.ToString(row.Cells["Precio de venta\n($)"].Value),
                            Convert.ToString(row.Cells["Precio de reparación\n($)"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),
                            Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value), nombresPiezas[i], lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9), x, Convert.ToInt32(row.Cells["dataGridViewStatusCombobox"].Value));
                        x += 1;
                        i++;
                        contadorOrdenActualizar++;
                        if (i == filasIniciales)
                        {
                            //MessageBOX.SHowDialog(1, "Se actualizó pedido correctamente");
                            break;
                        }
                    }
                    //Cuando hay filas ya registradas y hay nuevas por registrar
                    if ((dgvPedido.Rows.Count - filasIniciales) != 0)
                        registrarPedido();
                }
                else
                    registrarPedido();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en método actualizar pedido: " + Ex.Message);
            }
        }

        public string clavePedidoTextBox
        {
            get { return txtClavePedido.Text.Trim(); }
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedido.Rows.Count != 0)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        aniadirNuevosRegistros();

                        DateTime dtFechaAsignacion = dtpFechaAsignacion.Value.Date;
                        DateTime dtFechaPromesa = dtpFechaPromesa.Value.Date;
                        if (actualizar != 1)
                        {
                            //Registrar lo correspondiente a VEHICULO
                            if (nuevoMarca == true)
                                operacion.registroMarca(lblMarca.Text.Trim());
                            if (nuevoVehiculo == true)
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            else if (nuevoVehiculo == false && string.IsNullOrEmpty(operacion.existeAnioVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim())))
                            {
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            }

                            //Registrar lo correspondiente a SINIESTRO
                            if (string.IsNullOrEmpty(operacion.existeClaveSiniestro(lblClaveSiniestro.Text)) && lblClaveSiniestro.Text.Substring(0, 5) == "JEIC-")
                                operacion.registrarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), lblAnio.Text);

                            //Calcula cantidad, precio, costos
                            calcularDGV();

                            //AGREGANDO DATOS A VENTA
                            operacion.registrarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, vendedor, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa, utilidad);

                            //REGISTRANDO PEDIDO
                            registrarPedido();
                            this.DialogResult = DialogResult.OK;
                        }
                        else // ACTUALIZAR PEDIDO
                        {
                            //Registrar lo correspondiente a VEHICULO
                            if (nuevoMarca == true)
                                operacion.registroMarca(lblMarca.Text.Trim());
                            if (nuevoVehiculo == true)
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            else if (nuevoVehiculo == false && string.IsNullOrEmpty(operacion.existeAnioVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim())))
                            {
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            }

                            //ACTUALIZAR lo correspondiente a SINIESTRO
                            operacion.actualizarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), Convert.ToInt32(lblAnio.Text));

                            calcularDGV();

                            //AGREGANDO DATOS A VENTA
                            operacion.actualizarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, vendedor, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa, utilidad);//, utilidad

                            actualizarPedido();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                    MessageBOX.SHowDialog(2, "Favor de agregar al menos una pieza");
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error en el evento btnFinalizarPedido_Click: " + EX.Message);
            }
        }

        private void btnAgregarPieza_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClavePedido.Text != "Escriba clave del pedido" && !string.IsNullOrEmpty(lblClaveSiniestro.Text))
                {
                    Pieza pieza = new Pieza();
                    string[] guia = new string[dgvPedido.Rows.Count];
                    int j = 0;
                    if (actualizar == 1)
                    {
                        if (chbOtroDestino.Checked == true && chbOtroDestino.Text == "Otro")
                            pieza.destino = txtDestino.Text.Trim();
                        else if (chbOtroDestino.Checked == false && chbOtroDestino.Text == "Otro")
                            pieza.destino = cbDestino.Text.Trim();
                        else
                            pieza.destino = txtDestino.Text.Trim();
                    }
                    else
                    {
                        if (chbOtroDestino.Checked == true)
                            pieza.destino = txtDestino.Text.Trim();
                        else
                            pieza.destino = cbDestino.Text.Trim();
                    }
                    if (dgvPedido.Rows.Count > 0)
                    {
                        int i = dgvPedido.Rows.Count - 1;
                        foreach (DataGridViewRow row in dgvPedido.Rows)
                        {
                            if (!guia.Contains(Convert.ToString(row.Cells["Número de guía"].Value)))
                            {
                                pieza.cbNumeroGuia.Items.Add(Convert.ToString(row.Cells["Número de guía"].Value));
                                guia[j] = Convert.ToString(row.Cells["Número de guía"].Value);
                                pieza.portal = dgvPedido.Rows[i].Cells["Portal"].Value.ToString();
                                pieza.origen = dgvPedido.Rows[i].Cells["Origen"].Value.ToString().Trim().ToUpper();
                                pieza.proveedor = dgvPedido.Rows[i].Cells["Proveedor"].Value.ToString();
                                pieza.costoEnvio = dgvPedido.Rows[i].Cells["Costo de envío\n($)"].Value.ToString();
                                pieza.indicador = 1;
                                j++;
                            }
                        }
                    }
                    pieza.marca = lblMarca.Text;
                    pieza.modelo = lblVehiculo.Text;
                    pieza.anio = lblAnio.Text;

                    int cantidad = 0;
                    //double subtotalPrecio = 0;
                    double totalPrecio = 0;
                    DialogResult respuesta = pieza.ShowDialog();
                    //MessageBox.Show(respuesta.ToString());
                    if (respuesta == DialogResult.OK)
                    {
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < pieza.datosMandar.Length; i++)
                        {
                            row[i] = pieza.datosMandar[i];
                        }
                        dt.Rows.Add(row);

                        //Es utilizado para que por defecto el combobox del dgv tenga seleccionada una opción
                        dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["dataGridViewStatusCombobox"].Value = 1;
                        ///>>>>>>>>>>>>>>>>>>>>>----IMPORTANTE------:
                        ///El tipo de dato al que se iguala tiene mucho que coincidir con el "ValueMember"
                        ///de la columna combobox del datagridview, en este caso funciona porque se ha
                        ///seleccionado toda la tabla desde la consulta y coincide el tipo con el id
                        
                        if (actualizar == 1)
                        {
                            //Añadir botón con el nombre correcto (de lo contrario se queda en blanco)
                            dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["dataGridViewDarBajaButton"].Value = "Dar de baja";
                            dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["dataGridViewPenaltyButton"].Value = "Penalizar";
                        }

                        foreach (DataGridViewRow dgvRow in dgvPedido.Rows)
                        {
                            cantidad += Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                            //subtotalPrecio += (Convert.ToInt32(dgvRow.Cells["Cantidad"].Value) * Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(dgvRow.Cells["Precio de reparación"].Value)*/);
                            totalPrecio += Convert.ToDouble(dgvRow.Cells["Precio de venta\n($)"].Value);
                        }
                        //totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;

                        lblCantidadTotal.Text = cantidad.ToString();
                        lblPrecioTotal.Text = "$" + totalPrecio.ToString();
                    }
                }
                else
                {
                    MessageBOX.SHowDialog(2, "Favor de proporcionar claves de pedido y siniestro");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error en el evento btnAgregarPieza_Click: " + EX.Message);
            }
        }

        //Hace que el combobox de los valuadores cambie de acuerdo al cliente/aseguradora que se elija
        private void cbAseguradora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga los datos registros de valuadores en el combobox
            cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
            cbValuador.ValueMember = "nombre";
        }

        private string[] datosPieza = new string[12];

        public string[] datosMandar
        {
            get
            {
                return datosPieza;
            }
        }

        public int cantidadPenalizada = 0;
        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if click is on new row or header row
                if (e.RowIndex == dgvPedido.NewRowIndex || e.RowIndex < 0)
                    return;

                //Check if click is on specific column
                if (e.ColumnIndex == dgvPedido.Columns["dataGridViewDeleteButton"].Index)
                {
                    string pieza = "";
                    foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                    {
                        lblCantidadTotal.Text = (Convert.ToInt32(lblCantidadTotal.Text) - Convert.ToInt32(row.Cells["Cantidad"].Value)).ToString();
                        //lblPrecioTotal.Text = "$" + (Convert.ToDouble(lblPrecioTotal.Text.Substring(1, lblPrecioTotal.Text.Length - 1)) - ((Convert.ToDouble(row.Cells["Precio de venta"].Value) * Convert.ToInt32(row.Cells["Cantidad"].Value) * 0.16) + (Convert.ToDouble(row.Cells["Precio de venta"].Value) * Convert.ToInt32(row.Cells["Cantidad"].Value)))).ToString();
                        lblPrecioTotal.Text = "$" + ((Convert.ToDouble(lblPrecioTotal.Text.Substring(1, lblPrecioTotal.Text.Length - 1)) - Convert.ToDouble(row.Cells["Precio de venta\n($)"].Value)).ToString());
                        pieza = row.Cells["Pieza"].Value.ToString();
                    }
                    if (actualizar == 1)
                    {
                        if (filasIniciales != 0)
                        {
                            if (string.IsNullOrEmpty(operacion.existePiezaEntrega(pieza, txtClavePedido.Text, lblClaveSiniestro.Text)))
                            {
                                if (!string.IsNullOrEmpty(operacion.existePiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, pieza, dgvPedido.CurrentRow.Index)))
                                {
                                    MessageBOX mes = new MessageBOX(4, "¿Esta seguro de eliminar esta pieza?");
                                    if (mes.ShowDialog() == DialogResult.OK)
                                    {
                                        operacion.eliminarPiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, pieza, dgvPedido.CurrentRow.Index);
                                        filasIniciales -= 1;
                                        //Remueve la pieza de la fila seleccionada de la lista creada al cargar el formulario
                                        nombresPiezas.Remove(pieza);
                                        //Remueve el índice de la lista que se llenó al cargar el formulario para ser utilizado correctamente al comparar el orden de captura
                                        ordenCapturaIndice.Remove(dgvPedido.CurrentRow.Index);
                                        dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);

                                        //Actualizar orden de captura
                                        int i = 0; int j = 0;
                                        foreach (DataGridViewRow row in dgvPedido.Rows)
                                        { //Lo va a comparar con una lista que ha guardado el orden de captura al ser cargado el formulario para no depender del dgv
                                            if (!string.IsNullOrEmpty(operacion.existePiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), ordenCapturaIndice[j])))
                                            {
                                                //Para reasignar correctamente el orden de captura a las piezas
                                                operacion.actualizarOrdenCaptura(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), i, ordenCapturaIndice[i], 0);
                                                i += 1;
                                            }
                                            j++;
                                        }
                                        //Reiniciar lista para que los índices estén correctos y se asignen bien el orden de captura
                                        ordenCapturaIndice.Clear(); ordenCapturaIndice.TrimExcess(); j = 0;
                                        foreach (DataGridViewRow row in dgvPedido.Rows)
                                        {
                                            if (!string.IsNullOrEmpty(operacion.existePiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), j)))
                                            {
                                                MessageBox.Show(row.Cells["Pieza"].Value.ToString());
                                                ordenCapturaIndice.Add(j);
                                                j++;
                                            }
                                        }
                                    }
                                }
                                else
                                    dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                            }
                            else
                                MessageBOX.SHowDialog(2, "No es posible eliminar pieza debido a que existen entregas");
                        }
                        else
                            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                    }
                    else
                        dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                }
                if (actualizar == 1)
                {
                    string piezaNombre = "";
                    foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                    {
                        piezaNombre = Convert.ToString(row.Cells["Pieza"].Value);
                    }
                    if (e.ColumnIndex != dgvPedido.Columns["dataGridViewDeleteButton"].Index)
                    {
                        //Checar si hay registros de esa pieza (o si es nueva)
                        if (!string.IsNullOrEmpty(operacion.existePiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, piezaNombre, dgvPedido.CurrentRow.Index)))
                        {
                            int indexPenalizacion = dgvPedido.CurrentRow.Index;
                            if (e.ColumnIndex == dgvPedido.Columns["dataGridViewPenaltyButton"].Index)
                            {
                                DialogResult respuesta = DialogResult.Cancel;
                                int piezaPenalizada = 0; int cantidad = 0;
                                Penalizaciones penalizaciones = new Penalizaciones();
                                foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                                {
                                    piezaNombre = Convert.ToString(row.Cells["Pieza"].Value);
                                    penalizaciones.cvePieza = operacion.clavePieza(Convert.ToString(row.Cells["Pieza"].Value));
                                    penalizaciones.cveVenta = operacion.claveVenta(txtClavePedido.Text, lblClaveSiniestro.Text);
                                    penalizaciones.ordenCaptura = dgvPedido.CurrentCell.RowIndex;
                                    penalizaciones.usuario = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
                                    cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                    if (!string.IsNullOrEmpty(operacion.existePenalizacion(Convert.ToString(row.Cells["Pieza"].Value), txtClavePedido.Text, lblClaveSiniestro.Text, dgvPedido.CurrentRow.Index)))
                                        piezaPenalizada += 1;
                                }
                                if (cantidad == 0)
                                    MessageBOX.SHowDialog(2, "No es posible penalizar debido a que no hay cantidad suficiente");
                                else if (piezaPenalizada != 0)
                                    MessageBOX.SHowDialog(2, "La pieza ya se ha penalizado");
                                else
                                {
                                    penalizaciones.cantidad = cantidad;
                                    respuesta = penalizaciones.ShowDialog();
                                }
                                //Para que se actualice la cantidad que se penalizó
                                if (respuesta == DialogResult.OK)
                                {
                                    dt = operacion.piezasPedidoActualizar(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                                    dgvPedido.DataSource = dt;
                                    cantidadPenalizada = penalizaciones.cantidadPenalizada;
                                    lblCantidadTotal.Text = (Convert.ToInt32(lblCantidadTotal.Text) - cantidadPenalizada).ToString();

                                    int indexActualizar = 0;
                                    foreach (DataGridViewRow row in dgvPedido.Rows)
                                    {
                                        if (!string.IsNullOrEmpty(operacion.existeFechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text, Convert.ToString(row.Cells["Pieza"].Value), indexActualizar)))
                                            row.Cells["dataGridViewDarBajaButton"].Value = "Registrado";
                                        else
                                            row.Cells["dataGridViewDarBajaButton"].Value = "Dar de baja";

                                        if (!string.IsNullOrEmpty(operacion.existePenalizacion(Convert.ToString(row.Cells["Pieza"].Value), txtClavePedido.Text, lblClaveSiniestro.Text, indexActualizar)))
                                            row.Cells["dataGridViewPenaltyButton"].Value = "Penalizado";
                                        else
                                            row.Cells["dataGridViewPenaltyButton"].Value = "Penalizar";

                                        //Carga los estados que se tienen de cada pieza
                                        row.Cells["dataGridViewStatusCombobox"].Value = operacion.estadoSiniestroClaves(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), indexActualizar);
                                        indexActualizar++;
                                    }

                                    int i = 0;
                                    foreach (DataGridViewRow row in dgvPedido.Rows)
                                    {
                                        row.Cells["dataGridViewStatusCombobox"].Value = operacion.estadoSiniestroClaves(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), i);
                                        i += 1;
                                    }
                                }
                            }
                            if (e.ColumnIndex == dgvPedido.Columns["dataGridViewDarBajaButton"].Index)
                            {
                                int index = dgvPedido.CurrentCell.RowIndex;
                                //Checar primero si es que esa pieza ya ha sido dada de baja
                                if (!string.IsNullOrEmpty(operacion.existeFechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text, piezaNombre, index)))
                                {
                                    MessageBOX mes = new MessageBOX(4, "¿Modificar fecha?\n" + Convert.ToDateTime(operacion.existeFechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text, piezaNombre, index)).ToShortDateString());
                                    if (mes.ShowDialog() == DialogResult.OK)
                                    {
                                        FechaBaja fechaBaja = new FechaBaja();
                                        fechaBaja.identificador = 1;
                                        fechaBaja.cvePedido = txtClavePedido.Text;
                                        fechaBaja.cveSiniestro = lblClaveSiniestro.Text;
                                        fechaBaja.nombrePieza = piezaNombre;
                                        fechaBaja.index = index;
                                        fechaBaja.dt1 = dtpFechaAsignacion.Value;
                                        if (fechaBaja.ShowDialog() == DialogResult.OK)
                                        {
                                            //Add logic if needed
                                        }
                                    }
                                }
                                else
                                {
                                    FechaBaja fechaBaja = new FechaBaja();
                                    fechaBaja.cvePedido = txtClavePedido.Text;
                                    fechaBaja.cveSiniestro = lblClaveSiniestro.Text;
                                    fechaBaja.nombrePieza = piezaNombre;
                                    fechaBaja.index = index;
                                    fechaBaja.dt1 = dtpFechaAsignacion.Value;
                                    if (fechaBaja.ShowDialog() == DialogResult.OK)
                                    {
                                        //De esta forma se desabilita el botón cuando ya se ha registrado la fecha de baja
                                        //SetDGVButtonColumnEnable(false);

                                        //Cambia el nombre del botón al correcto (de lo contrario no se actualiza)
                                        dgvPedido.Rows[index].Cells["dataGridViewDarBajaButton"].Value = "Registrado";
                                    }
                                }
                            }
                        }
                        else
                            MessageBOX.SHowDialog(2, "Pieza debe ser registrada primero"); //SE PODRÍA PONER LA LÓGICA DE REGISTRAR AUTOMÁTICO
                    }
                }

                if (e.ColumnIndex == dgvPedido.Columns["dataGridViewEditButton"].Index)
                {
                    int index = dgvPedido.CurrentCell.RowIndex;
                    //MessageBox.Show(Convert.ToString(index));
                    Pieza pieza = new Pieza();
                    foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                    {
                        datosPieza[0] = Convert.ToString(row.Cells["Pieza"].Value);
                        datosPieza[1] = Convert.ToString(row.Cells["Cantidad"].Value);
                        datosPieza[2] = Convert.ToString(row.Cells["Clave de producto"].Value);
                        datosPieza[3] = Convert.ToString(row.Cells["Número de guía"].Value);
                        datosPieza[4] = Convert.ToString(row.Cells["Portal"].Value);
                        datosPieza[5] = Convert.ToString(row.Cells["Origen"].Value);
                        datosPieza[6] = Convert.ToString(row.Cells["Proveedor"].Value);
                        datosPieza[7] = Convert.ToString(row.Cells["Fecha costo"].Value);
                        //datosPieza[8] = Convert.ToString(row.Cells["Costo sin IVA"].Value);
                        datosPieza[8] = Convert.ToString(row.Cells["Costo neto\n($)"].Value);
                        datosPieza[9] = Convert.ToString(row.Cells["Costo de envío\n($)"].Value);
                        datosPieza[10] = Convert.ToString(row.Cells["Precio de reparación\n($)"].Value);
                        datosPieza[11] = Convert.ToString(row.Cells["Precio de venta\n($)"].Value);
                    }
                    pieza.datosEditar = datosPieza;
                    pieza.editarPieza = 1;
                    pieza.marca = lblMarca.Text;
                    pieza.modelo = lblVehiculo.Text;
                    pieza.anio = lblAnio.Text;
                    string[] guia = new string[dgvPedido.Rows.Count];
                    int i = 0;
                    if (chbOtroTaller.Checked == false && chbOtroTaller.Text != "Modificar")
                        pieza.destino = cbDestino.Text.Trim();
                    else if (chbOtroTaller.Checked == true && chbOtroTaller.Text != "Modificar")
                        pieza.destino = txtDestino.Text.Trim();
                    else if (chbOtroTaller.Checked == false && chbOtroTaller.Text == "Modificar")
                        pieza.destino = txtDestino.Text.Trim();

                    if (dgvPedido.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvPedido.Rows)
                        {
                            if (!guia.Contains(Convert.ToString(row.Cells["Número de guía"].Value)))
                            {
                                pieza.cbNumeroGuia.Items.Add(Convert.ToString(row.Cells["Número de guía"].Value));
                                guia[i] = Convert.ToString(row.Cells["Número de guía"].Value);
                                i++;
                            }
                        }
                    }
                    DialogResult respuesta = pieza.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {
                        int k = 0;
                        if (actualizar == 1)
                        {
                            for (int j = 0; j < pieza.datosMandar.Length; j++)
                            {
                                dgvPedido[j + 5, index].Value = pieza.datosMandar[k];
                                k++;
                            }
                            //EN caso de que se quiera dejar por default se descomenta la línea de abajo
                            //dgvPedido.Rows[index].Cells["dataGridViewStatusCombobox"].Value = 1;
                        }
                        else
                        {
                            for (int j = 0; j < pieza.datosMandar.Length; j++)
                            {
                                dgvPedido[j + 3, index].Value = pieza.datosMandar[k];
                                k++;
                            }
                        }
                    }
                }
                //Check if click is on specific column
                if (e.ColumnIndex == dgvPedido.Columns["dataGridViewStatusCombobox"].Index)
                {
                    //Some logic here
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error en el evento dgvPedido_CellClick: " + EX.Message);
            }
        }

        private void chbModificarFechaAsignacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModificarFechaAsignacion.Checked == true)
                dtpFechaAsignacion.Enabled = true;
            else
            {
                dtpFechaAsignacion.Text = operacion.fechaAsignacion(txtClavePedido.Text, lblClaveSiniestro.Text);
                dtpFechaAsignacion.Enabled = false;
            }
        }

        private void chbModificarFechaPromesa_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModificarFechaPromesa.Checked == true)
                dtpFechaPromesa.Enabled = true;
            else
            {
                dtpFechaPromesa.Text = operacion.fechaPromesa(txtClavePedido.Text, lblClaveSiniestro.Text);
                dtpFechaPromesa.Enabled = false;
            }
        }

        private void chbModificarVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModificarVendedor.Text == "Modificar" && chbModificarVendedor.Checked == true)
            {
                cbVendedor.Visible = true;
                txtVendedor.ReadOnly = false;
                txtVendedor.Clear();
                txtVendedor.Visible = false;
                txtVendedor.Text = "Escriba nombre del nuevo vendedor";
                txtVendedor.ForeColor = Color.FromArgb(160, 160, 140);
                chbModificarVendedor.Text = "Otro";
                chbModificarVendedor.Checked = false;
            }

            if (chbModificarVendedor.Text == "Otro" && chbModificarVendedor.Checked == true)
            {
                txtVendedor.Show();
                txtVendedor.Enabled = true;
                lblNumeroEmpleado.Visible = true;
                txtNumeroEmpleado.Visible = true;
                cbVendedor.Hide();
                //cbPiezaNombre.SelectedIndex = -1;
            }
            else if (chbModificarVendedor.Text == "Otro" && chbModificarVendedor.Checked == false)
            {
                lblNumeroEmpleado.Hide();
                txtNumeroEmpleado.Hide();
                txtNumeroEmpleado.Clear();
                txtVendedor.Hide();
                txtVendedor.Text = "Escriba nombre del nuevo vendedor";
                txtVendedor.ForeColor = Color.FromArgb(160, 160, 140);
                cbVendedor.Show();
                cbVendedor.Enabled = true;

                chbOtroValuador.Checked = false;
                chbOtroValuador.Enabled = true;

                lblDiasEspera.Visible = false;
                txtDiasEspera.Visible = false;
            }
        }

        private void dtpFechaAsignacion_ValueChanged(object sender, EventArgs e)
        {
            if (actualizar != 1)
                dtpFechaPromesa.Text = dtpFechaAsignacion.Text;
        }

        private void txtComentarioSiniestro_Click(object sender, EventArgs e)
        {
            txtComentarioSiniestro.SelectAll();
            txtComentarioSiniestro.Focus();
        }

        private void txtClavePedido_Leave(object sender, EventArgs e)
        {
            if (txtClavePedido.Text == "")
            {
                txtClavePedido.Text = "Escriba clave del pedido";
                txtClavePedido.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtComentarioSiniestro_Leave(object sender, EventArgs e)
        {
            if (txtComentarioSiniestro.Text == "")
            {
                txtComentarioSiniestro.Text = "Agregue un comentario";
                txtComentarioSiniestro.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtComentarioSiniestro_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtComentarioSiniestro.ForeColor = Color.White;
        }

        private void txtAseguradora_Leave(object sender, EventArgs e)
        {
            if (txtAseguradora.Text == "")
            {
                txtAseguradora.Text = "Escriba el nombre del cliente";
                txtAseguradora.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtValuador_Leave(object sender, EventArgs e)
        {
            if (txtValuador.Text == "")
            {
                txtValuador.Text = "Escriba nombre del valuador";
                txtValuador.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtTaller_Leave(object sender, EventArgs e)
        {
            if (txtTaller.Text == "")
            {
                txtTaller.Text = "Escriba nombre de taller";
                txtTaller.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtDestino_Leave(object sender, EventArgs e)
        {
            if (txtDestino.Text == "")
            {
                txtDestino.Text = "Escriba el destino";
                txtDestino.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLimpiarSiniestro_Click(object sender, EventArgs e)
        {
            rdbSi.Enabled = true;
            rdbNo.Enabled = true;
            btnLimpiarSiniestro.Visible = false;
            rdbSi.Checked = false;
            rdbNo.Checked = false;
            lblClaveSiniestroPedido.Visible = false;
            lblClaveSiniestro.Visible = false;
            lblClaveSiniestro.Text = "";
            lblAnioPedido.Visible = false;
            lblAnio.Visible = false;
            lblVehiculoPedido.Visible = false;
            lblVehiculo.Visible = false;
            lblMarcaPedido.Visible = false;
            lblMarca.Visible = false;
            lblComentarioSiniestro.Visible = false;
            txtComentarioSiniestro.Visible = false;
        }

        private void txtClavePedido_Validating(object sender, CancelEventArgs e)
        {
            if (txtClavePedido.Text == "" || txtClavePedido.Text == "Escriba clave del pedido")
            {
                errorProvider1.SetError(txtClavePedido, "Favor de llenar este campo");
                rdbSi.Checked = false;
                rdbNo.Checked = false;
                e.Cancel = true;
            }
            else
            {
                if (!string.IsNullOrEmpty(operacion.existeClavePedido(txtClavePedido.Text.Trim().ToUpper())))
                {
                    errorProvider1.SetError(txtClavePedido, "Ya existe un pedido con la misma clave");
                    rdbSi.Checked = false;
                    rdbNo.Checked = false;
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(txtClavePedido, null);
                    e.Cancel = false;

                    cbVendedor.Enabled = true;
                    cbAseguradora.Enabled = true;
                    chbOtraAseguradora.Enabled = true;
                    chbModificarVendedor.Enabled = true;
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
        }

        private void txtClavePedido_Enter(object sender, EventArgs e)
        {
            if (txtClavePedido.Text == "Escriba clave del pedido")
            {
                txtClavePedido.Text = "";
                txtClavePedido.ForeColor = Color.White;
            }
        }

        private void dgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int cantidad = 0;
                double subtotalPrecio = 0;
                double totalPrecio = 0;
                foreach (DataGridViewRow dgvRow in dgvPedido.Rows)
                {
                    cantidad += Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                    //subtotalPrecio += (Convert.ToInt32(dgvRow.Cells["Cantidad"].Value) * Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(dgvRow.Cells["Precio de reparación"].Value)*/);
                    totalPrecio += Convert.ToDouble(dgvRow.Cells["Precio de venta\n($)"].Value);
                }
                //totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;

                lblCantidadTotal.Text = cantidad.ToString();
                lblPrecioTotal.Text = "$" + totalPrecio.ToString();
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error en el evento dgvPedido_CellValueChanged: " + EX.Message);
            }
        }

        private void txtDiasEspera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVendedor_Enter(object sender, EventArgs e)
        {
            if (txtVendedor.Text.Trim() == "Escriba nombre del nuevo vendedor")
            {
                txtVendedor.Clear();
                txtVendedor.ForeColor = Color.White;
            }
        }

        private void txtVendedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVendedor.Text.Trim()))
            {
                txtVendedor.Text = "Escriba nombre del nuevo vendedor";
                txtVendedor.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtVendedor_Validating(object sender, CancelEventArgs e)
        {
            if (chbModificarVendedor.Checked == true && chbModificarVendedor.Text != "Modificar")
            {
                if (!string.IsNullOrEmpty(operacion.existeVendedor(txtVendedor.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtVendedor, "Vendedor ya existente");
                }
                else if (txtVendedor.Text.Trim() == "Escriba nombre del nuevo vendedor")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtVendedor, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtVendedor, null);
                }
            }
        }

        private void txtNumeroEmpleado_Validating(object sender, CancelEventArgs e)
        {
            if (chbModificarVendedor.Checked == true && chbModificarVendedor.Text != "Modificar")
            {
                if (!string.IsNullOrEmpty(operacion.existeClaveVendedor(Convert.ToInt32(txtNumeroEmpleado.Text.Trim()))))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNumeroEmpleado, "Número de empleado ya existente");
                }
                else if (string.IsNullOrEmpty(txtNumeroEmpleado.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNumeroEmpleado, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtNumeroEmpleado, null);
                }
            }
        }

        private void txtAseguradora_Enter(object sender, EventArgs e)
        {
            if (txtAseguradora.Text == "Escriba el nombre del cliente")
            {
                txtAseguradora.Text = "";
                txtAseguradora.ForeColor = Color.White;
            }
        }

        private void txtAseguradora_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtraAseguradora.Checked == true && chbOtraAseguradora.Text != "Modificar")
            {
                if (!string.IsNullOrEmpty(operacion.existeCliente(txtAseguradora.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtAseguradora, "Cliente ya existente");
                }
                else if (txtAseguradora.Text.Trim() == "Escriba el nombre del cliente")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtAseguradora, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtAseguradora, null);
                }
            }
        }

        private void txtDiasEspera_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtraAseguradora.Checked == true && string.IsNullOrEmpty(txtDiasEspera.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDiasEspera, "Favor de llenar este campo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDiasEspera, null);
            }
        }

        private void txtValuador_Enter(object sender, EventArgs e)
        {
            if (txtValuador.Text == "Escriba nombre del valuador")
            {
                txtValuador.Text = "";
                txtValuador.ForeColor = Color.White;
            }
        }

        private void txtValuador_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroValuador.Checked == true && chbOtroValuador.Text != "Modificar")
            {
                if (!string.IsNullOrEmpty(operacion.existeValuador(txtValuador.Text.Trim().ToUpper(), cbAseguradora.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtValuador, "Valuador ya existente");
                }
                else if (txtValuador.Text.Trim() == "Escriba nombre del valuador")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtValuador, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtValuador, null);
                }
            }
        }

        private void txtTaller_Enter(object sender, EventArgs e)
        {
            if (txtTaller.Text == "Escriba nombre de taller")
            {
                txtTaller.Text = "";
                txtTaller.ForeColor = Color.White;
            }
        }

        private void txtTaller_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == true && chbOtroTaller.Text != "Modificar")
            {
                if (!string.IsNullOrEmpty(operacion.existeTaller(txtTaller.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtTaller, "Taller ya existente");
                }
                else if (txtTaller.Text.Trim() == "Escriba nombre de taller")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtTaller, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtTaller, null);
                }
            }
        }

        private void txtDestino_Enter(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Escriba el destino")
            {
                txtDestino.Text = "";
                txtDestino.ForeColor = Color.White;
            }
        }

        private void txtDestino_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroDestino.Checked == true && chbOtroDestino.Text != "Modificar")
            {
                if (!string.IsNullOrEmpty(operacion.existeDestino(txtDestino.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtDestino, "Taller ya existente");
                }
                else if (txtDestino.Text.Trim() == "Escriba el destino")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtDestino, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtDestino, null);
                }
            }
        }

        private void btnPenalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                int contadorCantidadPiezas = 0; int k = 0;
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    if (!string.IsNullOrEmpty(operacion.existePenalizacion(Convert.ToString(row.Cells["Pieza"].Value), txtClavePedido.Text, lblClaveSiniestro.Text, k)))
                        contadorCantidadPiezas++;
                    k++;
                }
                if(contadorCantidadPiezas == 0)
                {
                    Penalizaciones penalizar = new Penalizaciones();
                    penalizar.penalizarPedido = 1;
                    DialogResult respuesta = penalizar.ShowDialog();

                    if (filasIniciales > 0)
                    {
                        int i = 0; int clavePedidoPedido = 0;
                        DateTime hoy = DateTime.Today;
                        if (respuesta == DialogResult.OK)
                        {
                            foreach (DataGridViewRow row in dgvPedido.Rows)
                            {
                                clavePedidoPedido = operacion.clavePedidoPedido(operacion.claveVenta(txtClavePedido.Text, lblClaveSiniestro.Text), operacion.clavePieza(Convert.ToString(row.Cells["Pieza"].Value)), i);
                                operacion.registrarPenalizacion(operacion.clavePieza(Convert.ToString(row.Cells["Pieza"].Value)), operacion.claveVenta(txtClavePedido.Text, lblClaveSiniestro.Text), Convert.ToInt32(row.Cells["Cantidad"].Value), penalizar.motivo, penalizar.porcentaje, hoy, lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9), clavePedidoPedido);
                                i++;
                                if (i == filasIniciales)
                                    break;
                            }
                            dt = operacion.piezasPedidoActualizar(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                            dgvPedido.DataSource = dt;
                            int index = 0;
                            foreach (DataGridViewRow row in dgvPedido.Rows)
                            {
                                if (!string.IsNullOrEmpty(operacion.existeFechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text, Convert.ToString(row.Cells["Pieza"].Value), index)))
                                    row.Cells["dataGridViewDarBajaButton"].Value = "Registrado";
                                else
                                    row.Cells["dataGridViewDarBajaButton"].Value = "Dar de baja";

                                if (!string.IsNullOrEmpty(operacion.existePenalizacion(Convert.ToString(row.Cells["Pieza"].Value), txtClavePedido.Text, lblClaveSiniestro.Text, index)))
                                    row.Cells["dataGridViewPenaltyButton"].Value = "Penalizado";
                                else
                                    row.Cells["dataGridViewPenaltyButton"].Value = "Penalizar";

                                //Carga los estados que se tienen de cada pieza
                                row.Cells["dataGridViewStatusCombobox"].Value = operacion.estadoSiniestroClaves(txtClavePedido.Text, lblClaveSiniestro.Text, row.Cells["Pieza"].Value.ToString(), index);
                                index++;
                            }
                        }
                    }
                    else
                        MessageBox.Show("No es posible penalizar el pedido si aún no se ha hecho el registro de piezas correspondiente al pedido actual\nFavor de registrar piezas antes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBOX.SHowDialog(2, "Los registros ya han sido penalizados previamente");

            }
            catch (Exception EX)
            {
                MessageBox.Show("Error en el evento btnPenalizarPedido_Click: " + EX.Message);
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Escriba dirección del taller")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.White;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Escriba dirección del taller";
                txtDireccion.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == true && chbOtroTaller.Text != "Modificar")
            {
                if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtDireccion, "Favor de llenar este campo");
                }
                else if (txtDireccion.Text.Trim() == "Escriba dirección del taller")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtDireccion, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtDireccion, null);
                }
            }
        }

        private void cbVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbVendedor.DroppedDown = false;
        }

        private void cbAseguradora_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbAseguradora.DroppedDown = false;
        }

        private void cbValuador_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbValuador.DroppedDown = false;
        }

        private void cbTaller_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbTaller.DroppedDown = false;
        }

        private void cbDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbDestino.DroppedDown = false;
        }

        private void cbVendedor_Validating(object sender, CancelEventArgs e)
        {
            if (chbModificarVendedor.Checked == false && chbModificarVendedor.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbVendedor.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbVendedor, "Favor de seleccionar un vendedor");
                }
                else if (string.IsNullOrEmpty(operacion.existeVendedor(cbVendedor.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbVendedor, "Favor de seleccionar un vendedor existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbVendedor, null);
                }
            }
        }

        private void cbAseguradora_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtraAseguradora.Checked == false && chbOtraAseguradora.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbAseguradora.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbAseguradora, "Favor de seleccionar un cliente");
                }
                else if (string.IsNullOrEmpty(operacion.existeCliente(cbAseguradora.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbAseguradora, "Favor de seleccionar un cliente existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbAseguradora, null);
                }
            }
        }

        private void cbValuador_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroValuador.Checked == false && chbOtroValuador.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbValuador.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbValuador, "Favor de seleccionar un valuador");
                }
                else if (string.IsNullOrEmpty(operacion.existeValuador(cbValuador.Text.Trim(), cbAseguradora.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbValuador, "Favor de seleccionar un valuador existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbValuador, null);
                }
            }
        }

        private void cbTaller_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == false && chbOtroTaller.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbTaller.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbTaller, "Favor de seleccionar un taller");
                }
                else if (string.IsNullOrEmpty(operacion.existeTaller(cbTaller.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbTaller, "Favor de seleccionar un taller existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbTaller, null);
                }
            }
        }

        private void cbDestino_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroDestino.Checked == false && chbOtroDestino.Text != "Modificar")
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbDestino.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbDestino, "Favor de seleccionar un destino");
                }
                else if (string.IsNullOrEmpty(operacion.existeDestino(cbDestino.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbDestino, "Favor de seleccionar un destino existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbDestino, null);
                }
            }
        }

        private void txtNumeroEmpleado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroEmpleado.Text.Trim()))
            {
                txtNumeroEmpleado.Text = "0";
            }
        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtCiudad_Enter(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "Escriba la cuidad")
            {
                txtCiudad.Text = "";
                txtCiudad.ForeColor = Color.White;
            }
        }

        private void txtCiudad_Leave(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "")
            {
                txtCiudad.Text = "Escriba la cuidad";
                txtCiudad.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtCiudad_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == true && chbOtroTaller.Text != "Modificar")
            {
                if (string.IsNullOrEmpty(txtCiudad.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtCiudad, "Favor de llenar este campo");
                }
                else if (txtCiudad.Text.Trim() == "Escriba la cuidad")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtCiudad, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtCiudad, null);
                }
            }
        }

        private void txtContacto_Enter(object sender, EventArgs e)
        {
            if (txtContacto.Text == "Escriba nombre(s)")
            {
                txtContacto.Text = "";
                txtContacto.ForeColor = Color.White;
            }
        }

        private void txtContacto_Leave(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                txtContacto.Text = "Escriba nombre(s)";
                txtContacto.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtContacto_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == true && chbOtroTaller.Text != "Modificar")
            {
                if (string.IsNullOrEmpty(txtContacto.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtContacto, "Favor de llenar este campo");
                }
                else if (txtContacto.Text.Trim() == "Escriba nombre(s)")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtContacto, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtContacto, null);
                }
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == true && string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTelefono, "Favor de llenar este campo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTelefono, null);
            }
        }

        private void txtHorario_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroTaller.Checked == true && string.IsNullOrEmpty(txtHorario.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHorario, "Favor de llenar este campo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHorario, null);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            //ESTO ES LO MISMO QUE EL BOTON DE FINALIZAR O ACTUALIZAR PARA FINALIZAR EL PEDIDO
            int g = 0;
            try
            {
                if (dgvPedido.Rows.Count != 0)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        aniadirNuevosRegistros();

                        DateTime dtFechaAsignacion = dtpFechaAsignacion.Value.Date;
                        DateTime dtFechaPromesa = dtpFechaPromesa.Value.Date;
                        if (actualizar != 1)
                        {
                            //Registrar lo correspondiente a VEHICULO
                            if (nuevoMarca == true)
                                operacion.registroMarca(lblMarca.Text.Trim());
                            if (nuevoVehiculo == true)
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            else if (nuevoVehiculo == false && string.IsNullOrEmpty(operacion.existeAnioVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim())))
                            {
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            }

                            //Registrar lo correspondiente a SINIESTRO
                            if (string.IsNullOrEmpty(operacion.existeClaveSiniestro(lblClaveSiniestro.Text)) && lblClaveSiniestro.Text.Substring(0, 5) == "JEIC-")
                                operacion.registrarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), lblAnio.Text);

                            //Calcula cantidad, precio, costos
                            calcularDGV();

                            //AGREGANDO DATOS A VENTA
                            operacion.registrarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, vendedor, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa, utilidad);

                            //REGISTRANDO PEDIDO
                            registrarPedido();
                            g = 1;
                            this.DialogResult = DialogResult.OK;
                        }
                        else // ACTUALIZAR PEDIDO
                        {
                            //Registrar lo correspondiente a VEHICULO
                            if (nuevoMarca == true)
                                operacion.registroMarca(lblMarca.Text.Trim());
                            if (nuevoVehiculo == true)
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            else if (nuevoVehiculo == false && string.IsNullOrEmpty(operacion.existeAnioVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim())))
                            {
                                operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());
                            }

                            //ACTUALIZAR lo correspondiente a SINIESTRO
                            operacion.actualizarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), Convert.ToInt32(lblAnio.Text));

                            calcularDGV();

                            //AGREGANDO DATOS A VENTA
                            operacion.actualizarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, vendedor, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa, utilidad);//, utilidad
                            actualizarPedido();
                            g = 1;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                else
                    MessageBOX.SHowDialog(2, "Favor de agregar al menos una pieza");
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error en el evento btnFinalizarPedido_Click: " + EX.Message);
            }
            //GENERAR PDF
            if (g == 1)
            {
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.Title = "PEDIDO";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "Ped_" + txtClavePedido.Text.Trim();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        PdfWriter pdfWriter = new PdfWriter(saveFileDialog1.FileName);
                        PdfReader pdfReader = new PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");

                        PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);

                        OperBD pdfnuevo = new OperBD();
                        pdfnuevo.Llenartabla(dgvDatosPDF, txtClavePedido.Text.Trim());

                        int NumeroFila = pdfnuevo.NumeroFilas(txtClavePedido.Text.Trim());

                        for (int i = 0; i < 3; i++)
                        {
                            PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                            PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);

                            int y = 659;
                            int x = 109;
                            int Items = 0;

                            //PEDIDO
                            canvas.BeginText().SetFontAndSize(font, 18)
                                     .MoveText(x, y)
                                     .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                     .EndText();
                            //CLIENTE
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 245, y - 2.5)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                                    .EndText();
                            //TALLER
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 243, y - 14.5)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                    .EndText();

                            /*if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Rodrigo"))
                                canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Andrea"))
                                canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.GREEN).Fill();
                            else if(dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Daniel"))
                                canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.YELLOW).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Julio"))
                                canvas.Rectangle(x + 288, y - 28, 38, 9).SetFillColor(ColorConstants.BLUE).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Alberto"))
                                canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.RED).Fill();
                            else
                                canvas.Rectangle(x + 288, y - 28, 50, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();
                            */

                            //COTIZADOR
                            canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 292, y - 27)
                                .SetFillColor(iText.Kernel.Colors.ColorConstants.BLACK)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString().ToUpper())
                                .EndText();
                            //VEHICULO
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 252, y - 39.5)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[11].Value.ToString() + "  -  " + dgvDatosPDF.Rows[0].Cells[4].Value.ToString() + " - " + dgvDatosPDF.Rows[0].Cells[12].Value.ToString())
                                    .EndText();
                            //FECHA_ASIGNACION
                            canvas.BeginText().SetFontAndSize(font, 14)
                                    .MoveText(x - 77, y - 50)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString().Substring(0, 10))
                                    .EndText();
                            //HORA DE CREACIÓN DEL VALE
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x - 77, y - 65)
                                    .SetFillColor(iText.Kernel.Colors.ColorConstants.RED)
                                    .ShowText("Creado: " + DateTime.Now.ToString())
                                    .EndText();
                            //FECHA_PROMESA
                            canvas.BeginText().SetFontAndSize(font, 14)
                                    .MoveText(x + 50, y - 50)
                                    .SetFillColor(iText.Kernel.Colors.ColorConstants.RED)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString().Substring(0, 10))
                                    .EndText();

                            for (int count = 0; count < NumeroFila; count++)
                            {
                                //NUMERO
                                canvas.BeginText().SetFontAndSize(font, 10)
                                        .MoveText(x - 49.5, y - 106.5)
                                        .SetFillColor(iText.Kernel.Colors.ColorConstants.BLACK)
                                        .ShowText((count + 1).ToString())
                                        .EndText();
                                //PIEZAS
                                canvas.BeginText().SetFontAndSize(font, 10)
                                        .MoveText(x - 5, y - 106.5)
                                        .ShowText(dgvDatosPDF.Rows[count].Cells[7].Value.ToString())
                                        .EndText();
                                //CANTIDAD
                                canvas.BeginText().SetFontAndSize(font, 10)
                                        .MoveText(x + 239, y - 106.5)
                                        .ShowText(dgvDatosPDF.Rows[count].Cells[8].Value.ToString())
                                        .EndText();

                                if (dgvDatosPDF.Rows[count].Cells[9].Value.ToString() != "0.00" && i == 0)
                                {
                                    //COSTO
                                    canvas.BeginText().SetFontAndSize(font, 10)
                                      .MoveText(x + 300, y - 106.5)
                                      .ShowText(dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                      .EndText();
                                }
                                if (dgvDatosPDF.Rows[count].Cells[10].Value.ToString() != "PENDIENTE" && i == 0)
                                {
                                    //PROVEEDOR
                                    canvas.BeginText().SetFontAndSize(font, 10)
                                       .MoveText(x + 370, y - 106.5)
                                       .ShowText(dgvDatosPDF.Rows[count].Cells[10].Value.ToString())
                                       .EndText();
                                }

                                Items = count;
                                //Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[8].Value.ToString());
                                y -= 20;
                            }
                            //NUMERO DE ITEMS
                            canvas.BeginText().SetFontAndSize(font, 9)
                                        .MoveText(x - 16, 56.5)
                                        .ShowText((Items + 1).ToString())
                                        .EndText();
                        }
                        pdfdoc.Close();
                        MessageBOX.SHowDialog(1, "PDF creado exitosamente");
                        this.Close();
                    }
                    else
                    {
                        PdfWriter pdfWriter = new PdfWriter(saveFileDialog1.FileName);
                        PdfReader pdfReader = new PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");

                        PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);

                        OperBD pdfnuevo = new OperBD();
                        pdfnuevo.Llenartabla(dgvDatosPDF, txtClavePedido.Text.Trim());

                        int NumeroFila = pdfnuevo.NumeroFilas(txtClavePedido.Text.Trim());

                        for (int i = 0; i < 3; i++)
                        {
                            PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                            PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);

                            int y = 659;
                            int x = 109;
                            int Items = 0;

                            //PEDIDO
                            canvas.BeginText().SetFontAndSize(font, 18)
                                     .MoveText(x, y)
                                     .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                     .EndText();
                            //CLIENTE
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 245, y - 2.5)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                                    .EndText();
                            //TALLER
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 243, y - 14.5)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                    .EndText();

                            /*if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Rodrigo"))
                                canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Andrea"))
                                canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.GREEN).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Daniel"))
                                canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.YELLOW).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Julio"))
                                canvas.Rectangle(x + 288, y - 28, 38, 9).SetFillColor(ColorConstants.BLUE).Fill();
                            else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Alberto"))
                                canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.RED).Fill();
                            else
                                canvas.Rectangle(x + 288, y - 28, 50, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();
                            */

                            //COTIZADOR
                            canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 292, y - 27)
                                .SetFillColor(iText.Kernel.Colors.ColorConstants.BLACK)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString().ToUpper())
                                .EndText();
                            //VEHICULO
                            canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x + 252, y - 39.5)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[11].Value.ToString() + "  -  " + dgvDatosPDF.Rows[0].Cells[4].Value.ToString() + " - " + dgvDatosPDF.Rows[0].Cells[12].Value.ToString())
                                    .EndText();
                            //FECHA_ASIGNACION
                            canvas.BeginText().SetFontAndSize(font, 14)
                                    .MoveText(x - 77, y - 50)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString().Substring(0, 10))
                                    .EndText();
                            //HORA DE CREACIÓN DEL VALE
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x - 77, y - 65)
                                    .SetFillColor(iText.Kernel.Colors.ColorConstants.RED)
                                    .ShowText("Creado: " + DateTime.Now.ToString())
                                    .EndText();
                            //FECHA_PROMESA
                            canvas.BeginText().SetFontAndSize(font, 14)
                                    .MoveText(x + 50, y - 50)
                                    .SetFillColor(iText.Kernel.Colors.ColorConstants.RED)
                                    .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString().Substring(0, 10))
                                    .EndText();

                            for (int count = 0; count < NumeroFila; count++)
                            {
                                //NUMERO
                                canvas.BeginText().SetFontAndSize(font, 10)
                                        .MoveText(x - 49.5, y - 106.5)
                                        .SetFillColor(iText.Kernel.Colors.ColorConstants.BLACK)
                                        .ShowText((count + 1).ToString())
                                        .EndText();
                                //PIEZAS
                                canvas.BeginText().SetFontAndSize(font, 10)
                                        .MoveText(x - 5, y - 106.5)
                                        .ShowText(dgvDatosPDF.Rows[count].Cells[7].Value.ToString())
                                        .EndText();
                                //CANTIDAD
                                canvas.BeginText().SetFontAndSize(font, 10)
                                        .MoveText(x + 239, y - 106.5)
                                        .ShowText(dgvDatosPDF.Rows[count].Cells[8].Value.ToString())
                                        .EndText();

                                if (dgvDatosPDF.Rows[count].Cells[9].Value.ToString() != "0.00" && i == 0)
                                {
                                    //COSTO
                                    canvas.BeginText().SetFontAndSize(font, 10)
                                      .MoveText(x + 300, y - 106.5)
                                      .ShowText(dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                      .EndText();
                                }
                                if (dgvDatosPDF.Rows[count].Cells[10].Value.ToString() != "PENDIENTE" && i == 0)
                                {
                                    //PROVEEDOR
                                    canvas.BeginText().SetFontAndSize(font, 10)
                                       .MoveText(x + 370, y - 106.5)
                                       .ShowText(dgvDatosPDF.Rows[count].Cells[10].Value.ToString())
                                       .EndText();
                                }

                                Items = count;
                                //Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[8].Value.ToString());
                                y -= 20;
                            }
                            //NUMERO DE ITEMS
                            canvas.BeginText().SetFontAndSize(font, 9)
                                        .MoveText(x - 16, 56.5)
                                        .ShowText((Items + 1).ToString())
                                        .EndText();
                        }
                        pdfdoc.Close();
                        MessageBOX.SHowDialog(1, "PDF creado exitosamente");
                        this.Close();
                    }
                }
            }
        }//LLAVE FINAL DE BTNGENERARPDF

        private void btnModificarSiniestro_Click(object sender, EventArgs e)
        {
            Siniestro siniestro = new Siniestro();
            siniestro.claveSiniestroPedido = lblClaveSiniestro.Text;
            siniestro.marcaPedido = lblMarca.Text;
            siniestro.vehiculoPedido = lblVehiculo.Text;
            siniestro.anioPedido = lblAnio.Text;
            siniestro.indicadorPedido = 1;

            if (siniestro.ShowDialog() == DialogResult.OK)
            {
                nuevoVehiculo = siniestro.otroVehiculo;
                nuevoMarca = siniestro.otroMarca;
                lblVehiculo.Text = siniestro.vehiculoSiniestro;
                lblAnio.Text = siniestro.anioSiniestro;
                lblMarca.Text = siniestro.marcaSiniestro;
                this.ActiveControl = txtComentarioSiniestro;
                if (siniestro.comentario == "Agregue un comentario")
                    txtComentarioSiniestro.Text = "Sin comentario por el momento";
                else
                    txtComentarioSiniestro.Text = siniestro.comentario;
            }
        }

        //-------------EVENTOS PARA LA COLUMNA COMBOBOX DEL DATAGRIDVIEW----------------
        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)sender).DroppedDown = false;
        }

        private void dgvPedido_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var comboBox = e.Control as DataGridViewComboBoxEditingControl;
            if (comboBox != null)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                // Remove an existing event-handler, if present, to avoid 
                // adding multiple handlers when the editing control is reused.
                comboBox.KeyPress -=
                    new KeyPressEventHandler (comboBox_KeyPress);

                // Add the event handler. 
                comboBox.KeyPress +=
                    new KeyPressEventHandler(comboBox_KeyPress);
            }
        }
    }
}