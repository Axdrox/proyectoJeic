﻿using DocumentFormat.OpenXml.Office.CoverPageProps;
using Refracciones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class Pedido : Form
    {
        private OperBD operacion = new OperBD();
        private Busqueda_Devolver busdev = new Busqueda_Devolver();
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
            if (actualizar != 1)
            {
                chbModificarEstado.Location = new Point(330, 186);
                var editButton = new DataGridViewButtonColumn();
                editButton.Name = "dataGridViewEditButton";
                editButton.HeaderText = "Editar";
                editButton.Text = "Editar";
                editButton.FlatStyle = FlatStyle.Popup;
                editButton.CellTemplate.Style.BackColor = Color.Aquamarine;
                editButton.UseColumnTextForButtonValue = true;
                this.dgvPedido.Columns.Add(editButton);
            }
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

            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            Eleccion eleccion = new Eleccion();
            if (actualizar == 1)
            {
                label1.Hide();
                rdbSi.Hide();
                rdbNo.Hide();
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
                lblVehiculo.Text = operacion.Vehiculo(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                chbModificarEstado.Show();
                cbEstadoSiniestro.Enabled = false;
                cbEstadoSiniestro.Hide();
                lblEstadoSiniestro.Text = operacion.estadoSiniestroClaves(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                txtClavePedido.Enabled = false;
                btnFinalizarPedido.Text = "Actualizar pedido";

                chbModificarVendedor.Visible = true;
                txtVendedor.Show();
                cbVendedor.Hide();
                txtVendedor.Text = operacion.Vendedor(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                chbOtraAseguradora.Enabled = true;
                chbOtraAseguradora.Text = "Modificar";
                cbAseguradora.Hide();
                txtAseguradora.Text = operacion.Cliente(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
                txtAseguradora.Enabled = false;

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
                dtpFechaBaja.Text = operacion.fechaBaja(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());
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
            }
        }

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
                    //else: que el texto se vuelva a escribir y se cambie el color al gris
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
                    cbAseguradora.SelectedIndex = -1;

                    lblDiasEspera.Visible = true;
                    txtDiasEspera.Visible = true;
                }
                else
                {
                    //else: que el texto se vuelva a escribir y se cambie el color al gris
                    txtAseguradora.Hide();
                    txtAseguradora.Text = "Escriba el nombre del cliente";
                    txtAseguradora.ForeColor = Color.FromArgb(160, 160, 140);
                    cbAseguradora.Show();

                    lblDiasEspera.Visible = false;
                    txtDiasEspera.Visible = false;
                }
            }
        }

        private void chbOtroValuador_CheckedChanged(object sender, EventArgs e)
        {
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
                    cbValuador.SelectedIndex = -1;
                }
                else
                {
                    txtValuador.Hide();
                    txtValuador.Text = "Escriba nombre del valuador";
                    txtValuador.ForeColor = Color.FromArgb(160, 160, 140);
                    cbValuador.Show();
                }
            }
        }

        private void chbOtroTaller_CheckedChanged(object sender, EventArgs e)
        {
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
                    cbTaller.SelectedIndex = -1;
                }
                else
                {
                    txtTaller.Hide();
                    txtTaller.Text = "Escriba nombre de taller";
                    txtTaller.ForeColor = Color.FromArgb(160, 160, 140);
                    cbTaller.Show();
                }
            }
        }

        private void chbOtroDestino_CheckedChanged(object sender, EventArgs e)
        {
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
                    cbDestino.SelectedIndex = -1;
                }
                else
                {
                    txtDestino.Hide();
                    txtDestino.Text = "Escriba el destino";
                    txtDestino.ForeColor = Color.FromArgb(160, 160, 140);
                    cbDestino.Show();
                }
            }
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

        private void txtClavePedido_Click(object sender, EventArgs e)
        {
            if (txtClavePedido.Text == "Escriba una clave")
            {
                txtClavePedido.Text = "";
                txtClavePedido.ForeColor = Color.White;
            }
        }

        private void txtAseguradora_Click(object sender, EventArgs e)
        {
            if (txtAseguradora.Text == "Escriba el nombre del cliente")
            {
                txtAseguradora.Text = "";
                txtAseguradora.ForeColor = Color.White;
            }
        }

        private void txtValuador_Click(object sender, EventArgs e)
        {
            if (txtValuador.Text == "Escriba nombre del valuador")
            {
                txtValuador.Text = "";
                txtValuador.ForeColor = Color.White;
            }
        }

        private void txtTaller_Click(object sender, EventArgs e)
        {
            if (txtTaller.Text == "Escriba nombre de taller")
            {
                txtTaller.Text = "";
                txtTaller.ForeColor = Color.White;
            }
        }

        private void txtDestino_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Escriba el destino")
            {
                txtDestino.Text = "";
                txtDestino.ForeColor = Color.White;
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

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables
                string aseguradora = "";
                string valuador = "";
                string taller = "";
                string destino = "";

                int modificacion = 0; int j = 0; //validar
                if (chbOtraAseguradora.Checked == true)
                {
                    j += 1;
                    if (operacion.existeCliente(txtAseguradora.Text.Trim().ToUpper()) == string.Empty)
                    {
                        aseguradora = txtAseguradora.Text.Trim().ToUpper();
                        modificacion += 1;
                    }
                    else
                    {
                        MessageBox.Show("Cliente ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAseguradora.Clear();
                        txtAseguradora.Hide();
                        chbOtraAseguradora.Checked = false;
                    }
                }
                else
                    aseguradora = cbAseguradora.Text.Trim();

                if (chbOtroValuador.Checked == true)
                {
                    j += 1;
                    if (operacion.existeValuador(txtValuador.Text.Trim().ToUpper()) == string.Empty)
                    {
                        valuador = txtValuador.Text.Trim().ToUpper();
                        modificacion += 1;
                    }
                    else
                    {
                        MessageBox.Show("Valuador ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAseguradora.Clear();
                        txtAseguradora.Hide();
                        chbOtraAseguradora.Checked = false;
                    }
                }
                else
                    valuador = cbValuador.Text.Trim();

                if (chbOtroTaller.Checked == true)
                {
                    j += 1;
                    if (operacion.existeTaller(txtTaller.Text.Trim().ToUpper()) == string.Empty)
                    {
                        taller = txtTaller.Text.Trim().ToUpper();
                        modificacion += 1;
                    }
                    else
                    {
                        MessageBox.Show("Taller ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAseguradora.Clear();
                        txtAseguradora.Hide();
                        chbOtraAseguradora.Checked = false;
                    }
                }
                else
                    taller = cbTaller.Text.Trim();

                if (chbOtroDestino.Checked == true)
                {
                    j += 1;
                    if (operacion.existeDestino(txtDestino.Text.Trim().ToUpper()) == string.Empty)
                    {
                        destino = txtDestino.Text.Trim().ToUpper();
                        modificacion += 1;
                    }
                    else
                    {
                        MessageBox.Show("Destino ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAseguradora.Clear();
                        txtAseguradora.Hide();
                        chbOtraAseguradora.Checked = false;
                    }
                }
                else
                    destino = cbDestino.Text.Trim();

                if (modificacion == j)
                {
                    //CHECAR INSERCIÓN DE CLIENTE
                    if (chbOtroValuador.Checked == true)
                        operacion.registrarValuador(valuador);
                    if (chbOtraAseguradora.Checked == true)
                        operacion.registrarCliente(txtAseguradora.Text.Trim().ToUpper(), cbValuador.Text.Trim(), Convert.ToInt32(txtDiasEspera.Text.Trim()));
                    if (chbOtroTaller.Checked == true)
                        operacion.registrarTaller(taller);
                    if (chbOtroDestino.Checked == true)
                        operacion.registrarDestino(destino);

                    if (txtClavePedido.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Añada clave del pedido", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        OperBD operacion = new OperBD();
                        int cantidadTotal = 0;

                        //VALIDAR CUANDO SEA ACTUALIZACIÓN ANTES, POR LO MIENTRAS LO DEJARÉ ASÍ
                        DateTime dtFechaBaja;
                        if (actualizar == 1)
                            dtFechaBaja = dtpFechaBaja.Value.Date;
                        else
                            dtFechaBaja = DateTime.Parse("1753/01/01");

                        DateTime dtFechaAsignacion = dtpFechaAsignacion.Value.Date;
                        DateTime dtFechaPromesa = dtpFechaPromesa.Value.Date;
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

                        //si numero de guia se encuentra no ese array se añade a ese array y va a ir guardando en otra variable la suma del costo de envio
                        string[] guia = new string[dgvPedido.Rows.Count];
                        int i = 0;
                        double totalCosto = 0;
                        double subtotalPrecio = 0;
                        double totalPrecio = 0;
                        //double utilidad;
                        //double totalCostoEnvio = 0; Ya no es tan necesaria puesto que se le tiene que sumar a la variable subtotalPrecio
                        foreach (DataGridViewRow row in dgvPedido.Rows)
                        {
                            totalCosto += Convert.ToInt32(row.Cells["Cantidad"].Value) * Convert.ToDouble(row.Cells["Costo neto"].Value);
                            subtotalPrecio += (Convert.ToInt32(row.Cells["Cantidad"].Value) * Convert.ToDouble(row.Cells["Precio de venta"].Value) /*+ Convert.ToDouble(row.Cells["Precio de reparación"].Value)*/);
                            /*if (!guia.Contains(Convert.ToString(row.Cells["Número de guía"].Value)))
                             {
                                 guia[i] = Convert.ToString(row.Cells["Número de guía"].Value);
                                 //totalCostoEnvio += Convert.ToDouble(row.Cells["Costo de envío"].Value);
                                 subtotalPrecio += Convert.ToDouble(row.Cells["Costo de envío"].Value);
                                 i++;
                             }*/
                        }
                        totalPrecio = (subtotalPrecio * .16) + subtotalPrecio;
                        //utilidad = totalPrecio - totalCosto;

                        //AGREGANDO DATOS A VENTA
                        operacion.registrarVenta(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim(), taller, Convert.ToInt32(cbVendedor.Text.Trim()), dtFechaBaja, valuador, destino, totalCosto, subtotalPrecio, totalPrecio, dtFechaAsignacion, dtFechaPromesa);//, utilidad

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
                            this.DialogResult = DialogResult.OK;
                        }
                        //AGREGA LOS TOTALES DE COSTO Y PRECIO A LA TABLA VENTAS
                        //operacion.totales(txtClavePedido.Text.Trim().ToUpper(), lblClaveSiniestro.Text.Trim());
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
            Pieza pieza = new Pieza();
            string[] guia = new string[dgvPedido.Rows.Count];
            int j = 0;
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
                /*
                totalCantidadPiezas += Convert.ToInt32(pieza.datosMandar[12]);
                lblCantidadTotal.Text = totalCantidadPiezas.ToString();*/
            }
            //this.Hide();
        }

        private void cbVendedor_Click(object sender, EventArgs e)
        {
            if (txtClavePedido.Text.Trim() != string.Empty)
            {
                //Carga los datos registros de vendedores en el combobox
                cbVendedor.DataSource = operacion.VendedoresRegistrados().Tables[0].DefaultView;
                cbVendedor.ValueMember = "cve_vendedor";
            }
            else
                MessageBox.Show("Favor de añadir la clave del pedido.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Cargar los datos de la aseguradora/cliente en el combobox
        private void cbAseguradora_Click(object sender, EventArgs e)
        {
            //Carga los datos registros de clientes/aseguradoras en el combobox
            cbAseguradora.DataSource = operacion.AseguradorasRegistradas().Tables[0].DefaultView;
            cbAseguradora.ValueMember = "cve_nombre";
        }

        //Hace que el combobox de los valuadores cambie de acuerdo al cliente/aseguradora que se elija
        private void cbAseguradora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga los datos registros de valuadores en el combobox
            cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
            cbValuador.ValueMember = "nombre";
            if (actualizar == 1 && chbOtroValuador.Checked == true && chbOtroValuador.Text == "Modificar")
            {
            }
        }

        private void cbValuador_Click(object sender, EventArgs e)
        {
            //Carga los datos registros de valuadores en el combobox

            if (actualizar == 1 && chbOtroValuador.Checked == true && chbOtroValuador.Text == "Modificar" && chbOtraAseguradora.Checked == false)
            {
                cbValuador.DataSource = operacion.ValuadoresRegistrados(txtAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";
            }
            else
            {
                cbValuador.DataSource = operacion.ValuadoresRegistrados(cbAseguradora.Text.Trim()).Tables[0].DefaultView;
                cbValuador.ValueMember = "nombre";
            }
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

        private void cbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbSi.Enabled = true;
            rdbNo.Enabled = true;
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
                dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                //Put some logic here, for example to remove row from your binding list.
                //yourBindingList.RemoveAt(e.RowIndex);

                // Or
                // var data = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                // do something
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
                    for (int j = 2; j < pieza.datosMandar.Length; j++)
                    {
                        dgvPedido[j, index].Value = pieza.datosMandar[j - 2];
                        //MessageBox.Show(pieza.datosMandar[j - 2]);
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
            //CHECAR
            /*
            if (chbModificarFechaBaja.Checked == true)
                dtpFechaBaja.Enabled = true;
            else
            {
                dtpFechaBaja.Text = operacion.fechaBaja(txtClavePedido.Text, lblClaveSiniestro.Text);
                dtpFechaBaja.Enabled = false;
            }
            */
        }

        private void chbModificarVendedor_CheckedChanged(object sender, EventArgs e)
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
                cbEstadoSiniestro.SelectedIndex = -1;
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
                txtClavePedido.Text = "Escriba una clave";
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
    }
}