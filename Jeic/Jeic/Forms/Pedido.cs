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
        OperBD operacion = new OperBD();
        DataTable dt;
        //int totalCantidadPiezas = 0;
        
        private int actualizar = 0;
        public Pedido(int i)
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Pieza");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Clave de producto");
            dt.Columns.Add("Número de guía");
            dt.Columns.Add("Portal");
            dt.Columns.Add("Origen");
            dt.Columns.Add("Proveedor");
            dt.Columns.Add("Fecha costo");
            dt.Columns.Add("Costo sin IVA");
            dt.Columns.Add("Costo neto");
            dt.Columns.Add("Costo de envío");
            dt.Columns.Add("Precio de venta");
            dt.Columns.Add("Precio de reparación");
            dgvPedido.DataSource = dt;

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

        private void Pedido_Load(object sender, EventArgs e)
        {
            Eleccion eleccion = new Eleccion();
            if (actualizar == 1)
            {
                label1.Hide();
                chbSi.Hide();
                rdbSi.Hide();
                rdbNo.Hide();
                if (lblClaveSiniestro.Text.Length > 6) { 
                    if(lblClaveSiniestro.Text.Substring(0,6) == "CVE-S-")//funciona
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
                txtEstado.Text = operacion.estadoSiniestroClaves(txtClavePedido.Text.Trim(), lblClaveSiniestro.Text.Trim());

                txtClavePedido.Enabled = false;
                btnFinalizarPedido.Text = "Actualizar pedido";

                chbModificarVendedor.Visible = true;
                txtVendedor.Show();
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
                chbSi.Hide();
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

                txtEstado.Hide();
                cbEstadoSiniestro.Hide();
                chbModificarEstado.Hide();
                lblEstado.Hide();

                dtpFechaBaja.Hide();
                chbModificarFechaBaja.Hide();
                lblFechaBaja.Hide();
            }
        }

        //Comentario de siniestro:
        string comentarioSiniestro = "";
        string estadoSiniestro = "";
        bool nuevoVehiculo;
        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSi.Checked == true)
            {
                lblComentarioSiniestro.Hide();
                txtComentarioSiniestro.Hide();
                lblEstado.Hide();
                cbEstadoSiniestro.Hide();
                Siniestro siniestro = new Siniestro();
                DialogResult respuesta = siniestro.ShowDialog();
                //MessageBox.Show(respuesta.ToString());
                if (respuesta == DialogResult.OK)
                {
                    comentarioSiniestro = siniestro.comentario;
                    estadoSiniestro = siniestro.estadoSiniestro;
                    nuevoVehiculo = siniestro.otroVehiculo;

                    chbSi.Show();
                    chbSi.Checked = true;
                    chbSi.Enabled = false;

                    lblClaveSiniestroPedido.Show();
                    lblClaveSiniestro.Show();
                    lblClaveSiniestro.Text = siniestro.claveSiniestro;

                    //rdbSi.Hide(); //se puede omitir

                    lblVehiculoPedido.Show();
                    lblVehiculo.Show();
                    lblVehiculo.Text = siniestro.vehiculoSiniestro;

                    lblAnioPedido.Show();
                    lblAnio.Show();
                    lblAnio.Text = siniestro.anioSiniestro;
                }
                else
                    rdbNo.Checked = true;
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
            rdbSi.Enabled = true;
            rdbSi.Show();

            chbSi.Checked = false;
            chbSi.Hide();

            lblVehiculoPedido.Hide();
            lblVehiculo.Text = "";
            lblVehiculo.Hide();

            lblAnioPedido.Hide();
            lblAnio.Text = "";
            lblAnio.Hide();

            lblClaveSiniestroPedido.Hide();
            lblClaveSiniestro.Text = "";
            lblClaveSiniestro.Hide();
            if(rdbNo.Checked == true)
            {
                lblClaveSiniestroPedido.Show();
                lblClaveSiniestro.Show();
                lblClaveSiniestro.Text = "CVE-S-" + operacion.TotalSiniestro().ToString();
                lblComentarioSiniestro.Show();
                txtComentarioSiniestro.Show();
                lblEstado.Show();
                cbEstadoSiniestro.Show();
            }
            else
            {
                txtEstado.Hide();
                cbEstadoSiniestro.Hide();
                chbModificarEstado.Hide();
                lblEstado.Hide();
            }
        }

        private void chbOtraAseguradora_CheckedChanged(object sender, EventArgs e)
        {
            if(actualizar == 1)
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
                }
                else
                {
                    //else: que el texto se vuelva a escribir y se cambie el color al gris
                    txtAseguradora.Hide();
                    cbAseguradora.Show();
                }
            }
        }

        private void chbOtroValuador_CheckedChanged(object sender, EventArgs e)
        {
            if(actualizar == 1)
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
                }
                else
                {
                    txtValuador.Hide();
                    cbValuador.Show();
                }
            }
        }

        private void chbOtroTaller_CheckedChanged(object sender, EventArgs e)
        {
            if(actualizar == 1)
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
                }
                else
                {
                    txtTaller.Hide();
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
                }
                else
                {
                    txtDestino.Hide();
                    cbDestino.Show();
                }
            }
        }

        private void txtClavePedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            txtClavePedido.ForeColor = Color.Black;
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
            if (txtClavePedido.Text == "Escribe una clave")
                txtClavePedido.Text = "";
            /*
            // MEJOR CAMBIARLO AL MOMENTO EN QUE QUIERA FINALIZAR EL PEDIDO
            if (txtClavePedido.Text != string.Empty && txtClavePedido.Text != "Escribe una clave")
            {
                //cbVendedor.Enabled = true;
                rdbSi.Enabled = true;
                rdbNo.Enabled = true;
                //cbAseguradora.Enabled = true;
                //chbOtraAseguradora.Enabled = true;
                //cbValuador.Enabled = true;
                //chbOtroValuador.Enabled = true;
                //cbTaller.Enabled = true;
                //chbOtroTaller.Enabled = true;
                //cbDestino.Enabled = true;
                //chbOtroDestino.Enabled = true;
                //dtpFechaAsignacion.Enabled = true;
                //dtpFechaPromesa.Enabled = true;
                //dtpFechaBaja.Enabled = true;
                //btnFinalizarPedido.Enabled = true;
                
            }*/

        }

        private void txtAseguradora_Click(object sender, EventArgs e)
        {
            if (txtAseguradora.Text == "Escriba el nombre del cliente")
            {
                txtAseguradora.Text = "";
                txtAseguradora.ForeColor = Color.Black;
            }

        }

        private void txtValuador_Click(object sender, EventArgs e)
        {
            if (txtValuador.Text == "Escribe nombre del valuador")
            {
                txtValuador.Text = "";
                txtValuador.ForeColor = Color.Black;
            }
        }

        private void txtTaller_Click(object sender, EventArgs e)
        {
            if (txtTaller.Text == "Escriba nombre de taller")
            {
                txtTaller.Text = "";
                txtTaller.ForeColor = Color.Black;
            }

        }

        private void txtDestino_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Escriba el destino")
            {
                txtDestino.Text = "";
                txtDestino.ForeColor = Color.Black;
            }
        }

        private void dtpFechaPromesa_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dtpFechaAsignacion.Value.Date;
            DateTime dt2 = dtpFechaPromesa.Value.Date;
            int resta = DateTime.Compare(dt1, dt2);
            if(actualizar == 1)
            {
                if (resta > 0)
                {
                    MessageBox.Show("No es posible elegir esa fecha.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaPromesa.Text = operacion.fechaAsignacion(txtClavePedido.Text, lblClaveSiniestro.Text);
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

            if(chbOtraAseguradora.Checked == true)
            {
                if(operacion.existeCliente(txtAseguradora.Text.Trim().ToUpper()) == string.Empty){
                    //CONTINUAR
                }
                else
                {
                    MessageBox.Show("Cliente ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAseguradora.Clear();
                    txtAseguradora.Hide();
                    chbOtraAseguradora.Checked = false;
                }
            }
            Siniestro siniestro = new Siniestro();
            try
            {
                if (txtClavePedido.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Favor de añadir la clave del pedido.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    OperBD operacion = new OperBD();
                    int cantidadTotal = 0;
                    DateTime dtFechaBaja = dtpFechaBaja.Value.Date;
                    DateTime dtFechaAsignacion = dtpFechaAsignacion.Value.Date;
                    DateTime dtFechaPromesa = dtpFechaPromesa.Value.Date;

                    operacion.registrarEntrega(dtFechaAsignacion, dtFechaPromesa);

                    if(rdbNo.Checked == false)
                    {
                        if(nuevoVehiculo == true)
                        {
                            operacion.registroVehiculo(lblVehiculo.Text.Trim(), lblAnio.Text.Trim());
                        }
                        operacion.registrarSiniestro(lblVehiculo.Text.Trim(), lblClaveSiniestro.Text.Trim(), comentarioSiniestro, estadoSiniestro);
                    }
                    else
                    {
                        string TotalVehiculo = operacion.TotalVehiculos().ToString();
                        operacion.registroVehiculo("PARTICULAR"+TotalVehiculo, TotalVehiculo);
                        operacion.registrarSiniestro("PARTICULAR" + TotalVehiculo, lblClaveSiniestro.Text.Trim(), txtComentarioSiniestro.Text.Trim(), cbEstadoSiniestro.Text.Trim());
                    }
                    

                    foreach (DataGridViewRow row in dgvPedido.Rows)
                    {
                        //Corregir, es cantidad por pieza
                        //cantidadTotal += Convert.ToInt32(row.Cells["Cantidad"].Value);
                    }
                    //MessageBox.Show(Convert.ToInt32(dgvPedido.Rows).ToString());
                    foreach (DataGridViewRow row in dgvPedido.Rows)
                    {
                        DateTime dtFechaCosto = new DateTime();
                        //if(row.Cells["Fecha costo"].Value != null || row.Cells["Fecha costo"].Value != DBNull.Value || row.Cells["Fecha costo"].Value.ToString() != string.Empty)
                        dtFechaCosto = DateTime.Parse(row.Cells["Fecha costo"].Value.ToString());

                        operacion = new OperBD();
                        operacion.registrarPedido(
                            Int32.Parse(txtClavePedido.Text.Trim()), lblClaveSiniestro.Text.Trim(),
                            Convert.ToString(row.Cells["Pieza"].Value), Convert.ToString(row.Cells["Portal"].Value),
                            cbTaller.Text.Trim().ToUpper(), Convert.ToString(row.Cells["Origen"].Value).Trim(),
                            Convert.ToString(row.Cells["Proveedor"].Value), Convert.ToInt32(cbVendedor.Text), dtFechaCosto,
                            Convert.ToString(row.Cells["Costo sin IVA"].Value), Convert.ToString(row.Cells["Costo neto"].Value),
                            Convert.ToString(row.Cells["Costo de envío"].Value), Convert.ToString(row.Cells["Precio de venta"].Value),
                            Convert.ToString(row.Cells["Precio de reparación"].Value), Convert.ToString(row.Cells["Clave de producto"].Value),
                            Convert.ToString(row.Cells["Número de guía"].Value), Convert.ToInt32(row.Cells["Cantidad"].Value)/*Convert.ToInt32(lblCantidadTotal.Text.Trim())*/,
                            cbValuador.Text.Trim(), cbDestino.Text.Trim().ToUpper(),0);
                        this.DialogResult = DialogResult.OK;
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

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chbModificarFechaAsignacion_CheckedChanged(object sender, EventArgs e)
        {
            if(chbModificarFechaAsignacion.Checked == true)
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
            if (chbModificarVendedor.Checked == true)
            {
                txtVendedor.Hide();
                cbVendedor.Enabled = true;
            }
            else
            {                
                txtVendedor.Show();
                cbVendedor.Enabled = false;
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
                txtEstado.Hide();
                cbEstadoSiniestro.Enabled = true;
            }
            else
            {
                txtEstado.Show();
                cbEstadoSiniestro.Enabled = false;
                cbEstadoSiniestro.SelectedIndex = -1;
            }
        }
    }
}
