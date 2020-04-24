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
        DataTable dt;
        //int totalCantidadPiezas = 0;
        public Pedido()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Pieza");
            dt.Columns.Add("Portal");
            dt.Columns.Add("Origen");
            dt.Columns.Add("Proveedor");
            dt.Columns.Add("Fecha costo");
            dt.Columns.Add("Costo sin IVA");
            dt.Columns.Add("Costo neto");
            dt.Columns.Add("Costo de envío");
            dt.Columns.Add("Precio de venta");
            dt.Columns.Add("Precio de reparación");
            dt.Columns.Add("Clave de producto");
            dt.Columns.Add("Número de guía");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Días entrega");
            dt.Columns.Add("Entrega en tiempo");

            dgvPedido.DataSource = dt;

            
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
            if(rdbSi.Checked == true)
            {
                Siniestro siniestro = new Siniestro();
                DialogResult respuesta = siniestro.ShowDialog();
                //MessageBox.Show(respuesta.ToString());
                if (respuesta == DialogResult.OK)
                {
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
                //else: que el texto se vuelva a escribir y se cambie el color al gris
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
            if (txtAseguradora.Text == "Escriba el nombre del cliente"){
                txtAseguradora.Text = "";
                txtAseguradora.ForeColor = Color.Black;
            }
                
        }

        private void txtValuador_Click(object sender, EventArgs e)
        {
            if (txtValuador.Text == "Escribe nombre del valuador"){
                txtValuador.Text = "";
                txtValuador.ForeColor = Color.Black;
            }
        }

        private void txtTaller_Click(object sender, EventArgs e)
        {
            if (txtTaller.Text == "Escriba nombre de taller"){
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
            if(resta > 0)
            {
                MessageBox.Show("No es posible elegir esa fecha.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaPromesa.Text = "";
            }

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try {
                    if (txtClavePedido.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Favor de añadir la clave del pedido.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OperBD operacion = new OperBD();
                int cantidadTotal = 0;
                DateTime dtFechaBaja = dtpFechaBaja.Value.Date;
                
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    cantidadTotal += Convert.ToInt32(row.Cells["Cantidad"].Value);
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
                                Convert.ToString(row.Cells["Número de guía"].Value), cantidadTotal/*Convert.ToInt32(lblCantidadTotal.Text.Trim())*/,
                                Convert.ToInt32(row.Cells["Días entrega"].Value), Convert.ToString(row.Cells["Entrega en tiempo"].Value),
                                dtFechaBaja, cbValuador.Text.Trim(), cbDestino.Text.Trim().ToUpper());


                        /*for (int i = 0; i < row.Cells.Count; i++)
                                {
                                    if (row.Cells[i].Value == null || row.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                                    {
                                        // here is your message box...
                                    }
                                    else
                                    {
                                    }
                                }*/

                        /*
                        foreach(DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value == null || cell.Value.Equals(""))
                            {
                            }
                            else
                            {*/

                        //}
                        //}
                    }

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
            DialogResult respuesta = pieza.ShowDialog();
            //MessageBox.Show(respuesta.ToString());
            if (respuesta == DialogResult.OK)
            {
                DataRow row = dt.NewRow();
                for(int i = 0; i<pieza.datosMandar.Length; i++)
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
            if(txtClavePedido.Text.Trim() != string.Empty)
            {
                //Carga los datos registros de vendedores en el combobox
                cbVendedor.DataSource = operacion.VendedoresRegistrados().Tables[0].DefaultView;
                cbVendedor.ValueMember = "cve_vendedor";
            }
            else
                MessageBox.Show("Favor de añadir la clave del pedido.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            rdbSi.Enabled = true;
            rdbNo.Enabled = true;
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
        }
    }
}
