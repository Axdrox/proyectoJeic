using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2013.Excel;
using Refracciones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class Pedido : Form
    {
        private OperBD operacion = new OperBD();
        private Busqueda busdev = new Busqueda();
        private DataTable dt;
        //int totalCantidadPiezas = 0;

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

        private void Pedido_Load(object sender, EventArgs e)
        {
            chbModificarEstado.Location = new Point(330, 186);
            if (actualizar == 1)
            {
                var penaltyButton = new DataGridViewButtonColumn();
                penaltyButton.Name = "dataGridViewPenaltyButton";
                penaltyButton.HeaderText = "Penalizar";
                penaltyButton.Text = "Penalizar";
                penaltyButton.FlatStyle = FlatStyle.Popup;
                penaltyButton.CellTemplate.Style.BackColor = Color.DarkViolet;
                penaltyButton.UseColumnTextForButtonValue = true;
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
            dt.Columns.Add("Costo neto");
            dt.Columns.Add("Costo de envío");
            dt.Columns.Add("Precio de venta");
            dt.Columns.Add("Precio de reparación");
            dgvPedido.DataSource = dt;

            //Impedir que se ordenen de otra forma (podría alterar) comprobar si se necesita
            foreach (DataGridViewColumn column in dgvPedido.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Carga los datos registros de vendedores en el combobox
            cbVendedor.DataSource = operacion.VendedoresRegistrados().Tables[0].DefaultView;
            cbVendedor.ValueMember = "nombre";

            //Carga los datos registros de clientes/aseguradoras en el combobox
            cbAseguradora.DataSource = operacion.AseguradorasRegistradas().Tables[0].DefaultView;
            cbAseguradora.ValueMember = "cve_nombre";

            //Carga los datos registros de talleres en el combobox
            cbTaller.DataSource = operacion.TalleresRegistrados().Tables[0].DefaultView;
            cbTaller.ValueMember = "nombre";

            //Carga los datos registros de destinos en el combobox
            cbDestino.DataSource = operacion.DestinosRegistrados().Tables[0].DefaultView;
            cbDestino.ValueMember = "destino";

            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            Eleccion eleccion = new Eleccion();
            if (actualizar == 1)
            {
                label1.Hide();
                rdbSi.Hide();
                rdbNo.Hide();
                /*
                if (lblClaveSiniestro.Text.Length > 6)
                {
                    if (lblClaveSiniestro.Text.Substring(0, 5) == "JEIC-")//funciona
                    {
                        lblClaveSiniestroPedido.Show();
                        lblClaveSiniestro.Show();
                        lblAnioPedido.Hide();
                        lblAnio.Hide();
                        lblVehiculoPedido.Hide();
                        lblVehiculo.Hide();
                    }
                }
                */

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

                chbModificarEstado.Show();
                cbEstadoSiniestro.Enabled = false;
                cbEstadoSiniestro.Visible = false;
                lblEstadoSiniestro.Visible = true;
                lblEstadoSiniestro.Text = operacion.estadoSiniestroClaves(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                lblComentarioSiniestro.Visible = true;
                txtComentarioSiniestro.Visible = true;
                txtComentarioSiniestro.Text = operacion.Comentario(lblClaveSiniestro.Text.Trim());

                txtClavePedido.Enabled = false;
                btnFinalizarPedido.Text = "Actualizar pedido";

                chbModificarVendedor.Visible = true;
                txtVendedor.Show();
                cbVendedor.Hide();
                txtVendedor.Text = operacion.Vendedor(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                chbModificarVendedor.Text = "Modificar";

                chbOtraAseguradora.Enabled = true;
                chbOtraAseguradora.Text = "Modificar";
                cbAseguradora.Hide();
                txtAseguradora.Text = operacion.Cliente(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                txtAseguradora.Enabled = false;

                //Carga los datos registros de valuadores en el combobox
                cbValuador.DataSource = operacion.ValuadoresRegistrados(txtAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";

                chbOtroValuador.Enabled = true;
                chbOtroValuador.Text = "Modificar";
                cbValuador.Hide();
                txtValuador.Text = operacion.Valuador(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                txtValuador.Enabled = false;

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

                chbModificarFechaBaja.Visible = true;
                //dtpFechaBaja.Text = operacion.fechaBaja(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                dgvPedido.DataSource = operacion.piezasPedidoActualizar(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                double precioTotal = 0; int piezasTotal = 0; nombrePieza = new string[Convert.ToInt32(dgvPedido.Rows.Count)]; int i = 0; filasIniciales = dgvPedido.Rows.Count;
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    precioTotal += Convert.ToDouble(row.Cells["Precio de venta"].Value);
                    piezasTotal += Convert.ToInt32(row.Cells["Cantidad"].Value);
                    nombrePieza[i] = Convert.ToString(row.Cells["Pieza"].Value);
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

                lblEstado.Hide();
                cbEstadoSiniestro.Hide();

                lblComentarioSiniestro.Hide();
                txtComentarioSiniestro.Hide();

                lblEstadoSiniestro.Hide();
                cbEstadoSiniestro.Hide();
                chbModificarEstado.Hide();
                lblEstado.Hide();

                dtpFechaBaja.Hide();
                chbModificarFechaBaja.Hide();
                lblFechaBaja.Hide();

                //Carga los datos registros de valuadores en el combobox
                cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";
            }
        }

        //Parámetros que sirven al momento de actualizar formulario
        private string[] nombrePieza;

        private int filasIniciales;

        //Saber si se va a registrar un nuevo modelo de vehículo o marca
        private bool nuevoVehiculo;

        private bool nuevoMarca;

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSi.Checked == true)
            {
                btnLimpiarSiniestro.Visible = false;
                chbModificarEstado.Location = new Point(330, 186);
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
                lblEstadoSiniestro.Visible = false;
                cbEstadoSiniestro.Visible = false;
                chbModificarEstado.Visible = false;
                lblEstado.Visible = false;
                lblComentarioSiniestro.Visible = false;
                txtComentarioSiniestro.Visible = false;

                Siniestro siniestro = new Siniestro();
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

                    lblEstado.Show();
                    lblEstadoSiniestro.Show();
                    lblEstadoSiniestro.Text = siniestro.estadoSiniestro;
                    chbModificarEstado.Show();

                    lblComentarioSiniestro.Show();
                    txtComentarioSiniestro.Show();
                    if (siniestro.comentario == "Agregue un comentario")
                        txtComentarioSiniestro.Text = "Sin comentario por el momento";
                    else
                        txtComentarioSiniestro.Text = siniestro.comentario;
                }
                else
                    rdbSi.Checked = false;
            }
        }

        //Genera la clave aleatoria
        /*
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }*/

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNo.Checked == true)
            {
                btnLimpiarSiniestro.Visible = false;
                chbModificarEstado.Location = new Point(330, 186);
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
                lblEstadoSiniestro.Visible = false;
                cbEstadoSiniestro.Visible = false;
                chbModificarEstado.Visible = false;
                lblEstado.Visible = false;
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

                    lblEstado.Show();
                    lblEstadoSiniestro.Show();
                    lblEstadoSiniestro.Text = siniestro.estadoSiniestro;
                    chbModificarEstado.Show();

                    lblComentarioSiniestro.Show();
                    txtComentarioSiniestro.Show();
                    if (siniestro.comentario == "Agregue un comentario")
                        txtComentarioSiniestro.Text = "Sin comentario por el momento";
                    else
                        txtComentarioSiniestro.Text = siniestro.comentario;
                }
                else
                    rdbNo.Checked = false;
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
            /*
            if (actualizar == 1)
            {
                if (chbOtraAseguradora.Checked == true)
                {
                    cbAseguradora.SelectedIndex = -1;
                    cbValuador.SelectedIndex = -1;
                    chbOtroValuador.Enabled = false;

                    chbOtroValuador.Checked = true;
                    txtAseguradora.Hide();
                    cbAseguradora.Show();
                    cbAseguradora.Enabled = true;
                    cbValuador.Show();
                    cbValuador.Enabled = true;
                }
                else
                {
                    cbAseguradora.SelectedIndex = -1;
                    cbValuador.SelectedIndex = -1;
                    chbOtroValuador.Enabled = true;

                    chbOtroValuador.Checked = false;
                    txtAseguradora.Show();
                    cbAseguradora.Hide();
                    txtValuador.Show();
                    cbValuador.Hide();
                }
            }
            else
            {
                if (chbOtraAseguradora.Checked == true)
                {
                    txtAseguradora.Show();
                    cbAseguradora.Hide();
                    //cbAseguradora.SelectedIndex = -1;

                    chbOtroValuador.Checked = true;
                    chbOtroValuador.Enabled = false;

                    lblDiasEspera.Visible = true;
                    txtDiasEspera.Visible = true;
                }
                else
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
            }*/
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
            /*
            if (actualizar == 1)
            {
                if (chbOtroValuador.Checked == true)
                {
                    txtValuador.Hide();
                    cbValuador.Show();
                    cbValuador.Enabled = true;
                }
                else
                {
                    txtValuador.Show();
                    cbValuador.Hide();
                    cbValuador.SelectedIndex = -1;
                }
            }
            else
            {
                if (chbOtroValuador.Checked == true)
                {
                    txtValuador.Show();
                    cbValuador.Hide();
                    //cbValuador.SelectedIndex = -1;
                }
                else
                {
                    txtValuador.Hide();
                    txtValuador.Text = "Escriba nombre del valuador";
                    txtValuador.ForeColor = Color.FromArgb(160, 160, 140);
                    cbValuador.Show();
                }
            }*/
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
                chbOtroTaller.Text = "Otro";
                chbOtroTaller.Checked = false;
            }

            if (chbOtroTaller.Text == "Otro" && chbOtroTaller.Checked == true)
            {
                txtTaller.Show();
                cbTaller.Hide();
                //cbTaller.SelectedIndex = -1;
            }
            else if (chbOtroTaller.Text == "Otro" && chbOtroTaller.Checked == false)
            {
                txtTaller.Hide();
                txtTaller.Text = "Escriba nombre de taller";
                txtTaller.ForeColor = Color.FromArgb(160, 160, 140);
                cbTaller.Show();
            }
            /*
            if (actualizar == 1)
            {
                if (chbOtroTaller.Checked == true)
                {
                    txtTaller.Hide();
                    cbTaller.Show();
                    cbTaller.Enabled = true;
                }
                else
                {
                    txtTaller.Show();
                    cbTaller.Hide();
                    cbTaller.SelectedIndex = -1;
                }
            }
            else
            {
                if (chbOtroTaller.Checked == true)
                {
                    txtTaller.Show();
                    cbTaller.Hide();
                    //cbTaller.SelectedIndex = -1;
                }
                else
                {
                    txtTaller.Hide();
                    txtTaller.Text = "Escriba nombre de taller";
                    txtTaller.ForeColor = Color.FromArgb(160, 160, 140);
                    cbTaller.Show();
                }
            }*/
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
                txtDestino.Text = "Escriba nombre del valuador";
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
            }
            /*
            if (actualizar == 1)
            {
                if (chbOtroDestino.Checked == true)
                {
                    txtDestino.Hide();
                    cbDestino.Show();
                    cbDestino.Enabled = true;
                }
                else
                {
                    txtDestino.Show();
                    cbDestino.Hide();
                    cbDestino.SelectedIndex = -1;
                }
            }
            else
            {
                if (chbOtroDestino.Checked == true)
                {
                    txtDestino.Show();
                    cbDestino.Hide();
                    //cbDestino.SelectedIndex = -1;
                }
                else
                {
                    txtDestino.Hide();
                    txtDestino.Text = "Escriba el destino";
                    txtDestino.ForeColor = Color.FromArgb(160, 160, 140);
                    cbDestino.Show();
                }
            }*/
        }

        private void txtClavePedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/
            cbVendedor.Enabled = true;

            //CAMBIAR PARA VALIDACION
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
            dtpFechaBaja.Enabled = true;
            btnFinalizarPedido.Enabled = true;
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
                    MessageBox.Show("No es posible elegir esa fecha.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaPromesa.Text = operacion.fechaPromesa(txtClavePedido.Text, lblClaveSiniestro.Text);
                }
            }
            else
            {
                if (resta > 0)
                {
                    MessageBox.Show("No es posible elegir esa fecha.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (chbModificarVendedor.Checked == true)
            {
                vendedor = txtVendedor.Text.Trim().ToUpper();
                operacion.registrarVendedor(Convert.ToInt32(txtNumeroEmpleado.Text.Trim()), vendedor);
            }
            else
                vendedor = cbVendedor.Text.Trim();

            if (chbOtroValuador.Checked == true)
            {
                valuador = txtValuador.Text.Trim().ToUpper();
                operacion.registrarValuador(valuador);
            }
            else
                valuador = cbValuador.Text.Trim();

            if (chbOtraAseguradora.Checked == true)
            {
                aseguradora = txtAseguradora.Text.Trim().ToUpper();
                operacion.registrarCliente(aseguradora, valuador, Convert.ToInt32(txtDiasEspera.Text.Trim()));
            }
            else
                aseguradora = cbAseguradora.Text.Trim();

            if (chbOtroTaller.Checked == true)
            {
                taller = txtTaller.Text.Trim().ToUpper();
                operacion.registrarTaller(taller);
            }
            else
                taller = cbTaller.Text.Trim();

            if (chbOtroDestino.Checked == true)
            {
                destino = txtDestino.Text.Trim().ToUpper();
                operacion.registrarDestino(destino);
            }
            else
                destino = cbDestino.Text.Trim();
        }

        //Variables
        private double totalCosto = 0;

        private double subtotalPrecio = 0;
        private double totalPrecio = 0;
        private double utilidad = 0;

        private void calcularDGV()
        {
            //si numero de guia se encuentra no ese array se añade a ese array y va a ir guardando en otra variable la suma del costo de envio
            string[] guia = new string[dgvPedido.Rows.Count];
            int i = 0;

            //double totalCostoEnvio = 0; Ya no es tan necesaria puesto que se le tiene que sumar a la variable subtotalPrecio
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                totalCosto += /*Convert.ToInt32(row.Cells["Cantidad"].Value) **/ Convert.ToDouble(row.Cells["Costo neto"].Value);
                subtotalPrecio += /*(Convert.ToInt32(row.Cells["Cantidad"].Value) **/ Convert.ToDouble(row.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(row.Cells["Precio de reparación"].Value)*/;
                /*if (!guia.Contains(Convert.ToString(row.Cells["Número de guía"].Value)))
                 {
                     guia[i] = Convert.ToString(row.Cells["Número de guía"].Value);
                     //totalCostoEnvio += Convert.ToDouble(row.Cells["Costo de envío"].Value);
                     subtotalPrecio += Convert.ToDouble(row.Cells["Costo de envío"].Value);
                     i++;
                 }*/
            }
            //totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;
            totalPrecio = Convert.ToDouble(lblPrecioTotal.Text.Substring(1, lblPrecioTotal.Text.Length - 1));
            utilidad = totalPrecio - totalCosto;
        }

        private void registrarPedido()
        {
            //AGREGANDO DATOS A PEDIDO
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                DateTime dtFechaCosto = new DateTime();
                //if(row.Cells["Fecha costo"].Value != null || row.Cells["Fecha costo"].Value != DBNull.Value || row.Cells["Fecha costo"].Value.ToString() != string.Empty)
                dtFechaCosto = DateTime.Parse(row.Cells["Fecha costo"].Value.ToString());

                operacion = new OperBD();
                operacion.registrarPedido(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(),
                    Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                    Convert.ToString(row.Cells["Origen"].Value).Trim(), Convert.ToString(row.Cells["Proveedor"].Value),
                    dtFechaCosto/*, Convert.ToString(row.Cells["Costo sin IVA"].Value)*/, Convert.ToString(row.Cells["Costo neto"].Value),
                    Convert.ToString(row.Cells["Costo de envío"].Value), Convert.ToString(row.Cells["Precio de venta"].Value),
                    Convert.ToString(row.Cells["Precio de reparación"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),
                    Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value));
            }
        }

        private void actualizarPedido()
        {
            if (filasIniciales > 0)
            {
                int i = 1;
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    DateTime dtFechaCosto = new DateTime();
                    //if(row.Cells["Fecha costo"].Value != null || row.Cells["Fecha costo"].Value != DBNull.Value || row.Cells["Fecha costo"].Value.ToString() != string.Empty)
                    dtFechaCosto = DateTime.Parse(row.Cells["Fecha costo"].Value.ToString());

                    operacion = new OperBD();
                    operacion.actualizarPedido(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(),
                        Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                        Convert.ToString(row.Cells["Origen"].Value).Trim(), Convert.ToString(row.Cells["Proveedor"].Value),
                        dtFechaCosto/*, Convert.ToString(row.Cells["Costo sin IVA"].Value)*/, Convert.ToString(row.Cells["Costo neto"].Value),
                        Convert.ToString(row.Cells["Costo de envío"].Value), Convert.ToString(row.Cells["Precio de venta"].Value),
                        Convert.ToString(row.Cells["Precio de reparación"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),
                        Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value), nombrePieza[i]);
                    i++;
                    if (i == filasIniciales)
                        break;
                }
                if((dgvPedido.Rows.Count - filasIniciales) > 0)
                {
                    if (filasIniciales == 0)
                    {
                        //cuando se eliminaron todas las piezas que se tenían registradas
                        for (int j = 0; j < dgvPedido.Rows.Count; j++)
                        {/*
                            operacion.registrarPedido(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(),
                            Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                            Convert.ToString(row.Cells["Origen"].Value).Trim(), Convert.ToString(row.Cells["Proveedor"].Value),
                            dtFechaCosto, Convert.ToString(row.Cells["Costo neto"].Value),
                            Convert.ToString(row.Cells["Costo de envío"].Value), Convert.ToString(row.Cells["Precio de venta"].Value),
                            Convert.ToString(row.Cells["Precio de reparación"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),
                            Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value));*/
                        }
                    }
                    else
                    {
                        //cuando hay filas ya registradas y que se registren las nuevas
                        for (int j = filasIniciales + 1; j < dgvPedido.Rows.Count - filasIniciales; j++)
                        {/*
                            operacion.registrarPedido(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(),
                            Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                            Convert.ToString(row.Cells["Origen"].Value).Trim(), Convert.ToString(row.Cells["Proveedor"].Value),
                            dtFechaCosto, Convert.ToString(row.Cells["Costo neto"].Value),
                            Convert.ToString(row.Cells["Costo de envío"].Value), Convert.ToString(row.Cells["Precio de venta"].Value),
                            Convert.ToString(row.Cells["Precio de reparación"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),
                            Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value));*/
                        }
                    }
                }
            }
            else
                registrarPedido();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    aniadirNuevosRegistros();

                    DateTime dtFechaBaja;
                    DateTime dtFechaAsignacion = dtpFechaAsignacion.Value.Date;
                    DateTime dtFechaPromesa = dtpFechaPromesa.Value.Date;
                    if (btnFinalizarPedido.Text != "Actualizar pedido")
                    {
                        dtFechaBaja = DateTime.Parse("1753/01/01");
                        //operacion.registrarFechasVentas(dtFechaAsignacion, dtFechaPromesa);

                        //Registrar lo correspondiente a siniestro
                        string estadoSiniestro = "";
                        if (nuevoMarca == true)
                            operacion.registroMarca(lblMarca.Text.Trim());
                        if (nuevoVehiculo == true)
                            operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim(), lblMarca.Text.Trim());

                        if (chbModificarEstado.Checked == true)
                            estadoSiniestro = cbEstadoSiniestro.Text;
                        else
                            estadoSiniestro = lblEstadoSiniestro.Text;

                        operacion.registrarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), estadoSiniestro);

                        calcularDGV();

                        //AGREGANDO DATOS A VENTA
                        operacion.registrarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, vendedor, dtFechaBaja, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa, utilidad);//, utilidad

                        //REGISTRANDO PEDIDO
                        registrarPedido();
                        this.DialogResult = DialogResult.OK;
                    }
                    else // ACTUALIZAR PEDIDO
                    {
                        if (chbModificarFechaBaja.Checked == true)
                            dtFechaBaja = dtpFechaBaja.Value.Date;
                        else
                            dtFechaBaja = DateTime.Parse("1753/01/01");

                        string estadoSiniestro = "";
                        if (chbModificarEstado.Checked == true)
                            estadoSiniestro = cbEstadoSiniestro.Text;
                        else
                            estadoSiniestro = lblEstadoSiniestro.Text;

                        operacion.actualizarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), estadoSiniestro);

                        calcularDGV();

                        //AGREGANDO DATOS A VENTA
                        operacion.actualizarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, vendedor, dtFechaBaja, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa, utilidad);//, utilidad

                        actualizarPedido();
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        private void btnAgregarPieza_Click(object sender, EventArgs e)
        {
            if (txtClavePedido.Text != "Escriba clave del pedido" && !string.IsNullOrEmpty(lblClaveSiniestro.Text))
            {
                Pieza pieza = new Pieza();
                string[] guia = new string[dgvPedido.Rows.Count];
                int j = 0;
                if (chbOtroDestino.Checked == true)
                    pieza.destino = txtDestino.Text.Trim();
                else
                    pieza.destino = cbDestino.Text.Trim();
                if (dgvPedido.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPedido.Rows)
                    {
                        if (!guia.Contains(Convert.ToString(row.Cells["Número de guía"].Value)))
                        {
                            pieza.cbNumeroGuia.Items.Add(Convert.ToString(row.Cells["Número de guía"].Value));
                            guia[j] = Convert.ToString(row.Cells["Número de guía"].Value);
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

                    foreach (DataGridViewRow dgvRow in dgvPedido.Rows)
                    {
                        cantidad += Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                        //subtotalPrecio += (Convert.ToInt32(dgvRow.Cells["Cantidad"].Value) * Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(dgvRow.Cells["Precio de reparación"].Value)*/);
                        totalPrecio += Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value);
                    }
                    //totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;

                    lblCantidadTotal.Text = cantidad.ToString();
                    lblPrecioTotal.Text = "$" + totalPrecio.ToString();
                }
            }
            else
            {
                MessageBox.Show("Favor de proporcionar claves de pedido y siniestro", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //this.Hide();
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

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    lblPrecioTotal.Text = "$" + ((Convert.ToDouble(lblPrecioTotal.Text.Substring(1, lblPrecioTotal.Text.Length - 1)) - Convert.ToDouble(row.Cells["Precio de venta"].Value)).ToString());
                    pieza = row.Cells["Pieza"].Value.ToString();
                }
                if(actualizar == 1)
                {
                    if(filasIniciales != 0)
                    {
                        if (string.IsNullOrEmpty(operacion.existePiezaEntrega(pieza)) == true)
                        {
                            if (!string.IsNullOrEmpty(operacion.existePiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, pieza)))
                            {
                                if (MessageBox.Show("¿Está seguro de eliminar este registro de la base?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    operacion.eliminarPiezaRegistradaPedido(txtClavePedido.Text, lblClaveSiniestro.Text, pieza);
                                    filasIniciales -= 1;
                                    dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                                }
                            }
                        }
                        else
                            MessageBox.Show("No es posible eliminar pieza debido a que existen entregas");
                    }
                    else
                        dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                }
                else
                    dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);


                //Put some logic here, for example to remove row from your binding list.
                //yourBindingList.RemoveAt(e.RowIndex);

                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something
            }
            if (actualizar == 1)
            {
                if (e.ColumnIndex == dgvPedido.Columns["dataGridViewPenaltyButton"].Index)
                {
                    Penalizaciones penalizaciones = new Penalizaciones();
                    foreach (DataGridViewRow row in dgvPedido.SelectedRows)
                    {
                        penalizaciones.cvePieza = operacion.clavePieza(Convert.ToString(row.Cells["Pieza"].Value));
                        penalizaciones.cveVenta = operacion.claveVenta(txtClavePedido.Text, lblClaveSiniestro.Text);
                        penalizaciones.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    }
                    DialogResult respuesta = penalizaciones.ShowDialog();
                    //Para que se actualice la cantidad que se penalizó
                    if (respuesta == DialogResult.OK)
                        dgvPedido.DataSource = operacion.piezasPedidoActualizar(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
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
                    datosPieza[8] = Convert.ToString(row.Cells["Costo neto"].Value);
                    datosPieza[9] = Convert.ToString(row.Cells["Costo de envío"].Value);
                    datosPieza[10] = Convert.ToString(row.Cells["Precio de reparación"].Value);
                    datosPieza[11] = Convert.ToString(row.Cells["Precio de venta"].Value);
                }
                pieza.datosEditar = datosPieza;
                pieza.editarPieza = 1;
                pieza.marca = lblMarca.Text;
                pieza.modelo = lblVehiculo.Text;
                pieza.anio = lblAnio.Text;
                string[] guia = new string[dgvPedido.Rows.Count];
                int i = 0;
                pieza.destino = cbDestino.Text.Trim();
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
                    //probar llenando dgv de otra forma con arreglo (datasource?)
                    int k = 0;
                    for (int j = 0; j < pieza.datosMandar.Length; j++)
                    {
                        dgvPedido[j + 2, index].Value = pieza.datosMandar[k];
                        k++;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            busdev.Show();
            this.DialogResult = DialogResult.Cancel;
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

        private void chbModificarFechaBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModificarFechaBaja.Checked == true)
                dtpFechaBaja.Enabled = true;
            else
            {
                //dtpFechaBaja.Text = operacion.fechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text);
                dtpFechaBaja.Enabled = false;
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

            /*
            if (actualizar == 1)
            {
                if (chbModificarVendedor.Checked == true)
                {
                    txtVendedor.Hide();
                    cbVendedor.Show();
                    cbVendedor.Enabled = true;
                }
                else
                {
                    txtVendedor.Show();
                    cbVendedor.Enabled = false;
                    cbVendedor.Hide();
                    cbVendedor.SelectedIndex = -1;
                }
            }
            else
            {
                if (chbModificarVendedor.Checked == true)
                {
                    txtVendedor.Show();
                    txtVendedor.Enabled = true;
                    lblNumeroEmpleado.Visible = true;
                    txtNumeroEmpleado.Visible = true;
                    cbVendedor.Hide();
                }
                else
                {
                    lblNumeroEmpleado.Hide();
                    txtNumeroEmpleado.Hide();
                    txtNumeroEmpleado.Clear();
                    txtVendedor.Hide();
                    txtVendedor.Text = "Escriba nombre del nuevo vendedor";
                    txtVendedor.ForeColor = Color.FromArgb(160, 160, 140);
                    cbVendedor.Show();

                    chbOtroValuador.Checked = false;
                    chbOtroValuador.Enabled = true;

                    lblDiasEspera.Visible = false;
                    txtDiasEspera.Visible = false;
                }
            }*/
        }

        private void cbEstadoSiniestro_Click(object sender, EventArgs e)
        {
            cbEstadoSiniestro.DataSource = operacion.EstadoSiniestro().Tables[0].DefaultView;
            cbEstadoSiniestro.ValueMember = "estado";
        }

        private void chbModificarEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModificarEstado.Checked == true)
            {
                chbModificarEstado.Location = new Point(360, 186);
                lblEstadoSiniestro.Hide();
                cbEstadoSiniestro.Enabled = true;
                cbEstadoSiniestro.Show();
            }
            else
            {
                chbModificarEstado.Location = new Point(330, 186);
                lblEstadoSiniestro.Show();
                cbEstadoSiniestro.Enabled = false;
                //cbEstadoSiniestro.SelectedIndex = -1;
                cbEstadoSiniestro.Hide();
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
            /*if (txtComentarioSiniestro.Text == "Agregue un comentario")
            {
                txtComentarioSiniestro.Clear();
                txtComentarioSiniestro.ForeColor = Color.White;
            }*/
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
            busdev.Show();
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLimpiarSiniestro_Click(object sender, EventArgs e)
        {
            btnLimpiarSiniestro.Visible = false;
            chbModificarEstado.Location = new Point(330, 186);
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
            lblEstadoSiniestro.Visible = false;
            cbEstadoSiniestro.Visible = false;
            chbModificarEstado.Visible = false;
            lblEstado.Visible = false;
            lblComentarioSiniestro.Visible = false;
            txtComentarioSiniestro.Visible = false;
        }

        private void txtClavePedido_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(operacion.existeClavePedido(txtClavePedido.Text.Trim().ToUpper())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtClavePedido, "Ya existe un pedido con la misma clave");
            }
            else if (txtClavePedido.Text.Trim() == "Escriba clave del pedido")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtClavePedido, "Favor de llenar este campo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtClavePedido, null);
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
            int cantidad = 0;
            double subtotalPrecio = 0;
            double totalPrecio = 0;
            foreach (DataGridViewRow dgvRow in dgvPedido.Rows)
            {
                cantidad += Convert.ToInt32(dgvRow.Cells["Cantidad"].Value);
                //subtotalPrecio += (Convert.ToInt32(dgvRow.Cells["Cantidad"].Value) * Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(dgvRow.Cells["Precio de reparación"].Value)*/);
                totalPrecio += Convert.ToDouble(dgvRow.Cells["Precio de venta"].Value);
            }
            //totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;

            lblCantidadTotal.Text = cantidad.ToString();
            lblPrecioTotal.Text = "$" + totalPrecio.ToString();
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
            if (chbModificarVendedor.Checked == true && string.IsNullOrEmpty(txtNumeroEmpleado.Text.Trim()))
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
                if (!string.IsNullOrEmpty(operacion.existeValuador(txtValuador.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtValuador, "Cliente ya existente");
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
    }
}