using DocumentFormat.OpenXml.Drawing.Charts;
using Refracciones;
using Refracciones.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeic.Forms
{
    public partial class cambioCostoEnvio : Form
    {
        public cambioCostoEnvio()
        {
            InitializeComponent();
        }
        private OperBD operacion = new OperBD();
        private string[] datos = new string[8];

        private void cambioCostoEnvio_Load(object sender, EventArgs e)
        {
            dgvEstatus.Columns["ColumnCvePedido"].Visible = false;
            dgvEstatus.Columns["ColumnCveVenta"].Visible = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnPorPieza_CheckedChanged(object sender, EventArgs e)
        {
            dgvEstatus.DataSource = null;
            dgvEstatus.Rows.Clear();
        }

        private void rbtnPorPedido_CheckedChanged(object sender, EventArgs e)
        {
            dgvEstatus.DataSource = null;
            dgvEstatus.Rows.Clear();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (txtCodigo.Text.Contains(','))
                {
                    bool existe = false;
                    string[] claves = txtCodigo.Text.Split(',');

                    if (rbtnPorPieza.Checked)
                    {
                        foreach (DataGridViewRow row in dgvEstatus.Rows)
                        {
                            if (claves[1] == row.Cells["ColumnCvePedido"].Value.ToString())
                            {
                                existe = true;
                            }
                        }

                        if (existe)
                        {
                            MessageBOX.SHowDialog(2, "Pieza duplicada");
                        }
                        else
                        {
                            datos = operacion.llenarCodigoBarrasCostoEnvio(claves[1]);
                            if (datos[0] != null)
                            {
                                dgvEstatus.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7]);

                            }
                        }
                        existe = false;
                    }
                    else if (rbtnPorPedido.Checked)
                    {
                        foreach (DataGridViewRow row in dgvEstatus.Rows)
                        {
                            if (claves[0] == row.Cells["ColumnCveVenta"].Value.ToString())
                            {
                                existe = true;
                            }
                        }

                        if (existe)
                        {
                            MessageBOX.SHowDialog(2, "Venta duplicada");
                        }
                        else
                        {

                            operacion.llenarCostoEnvioCodigoBarrasPedido(dgvEstatus, claves[0]);

                        }
                        existe = false;
                    }
                    txtCodigo.Text = "";
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(',') && e.KeyChar != Convert.ToChar(Keys.Enter);
        }

        private void txtCveCosto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvEstatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Int32.Parse(e.RowIndex.ToString());

            if (fila == -1) { }
            else if (e.ColumnIndex == -1)
            {
                MessageBOX mes = new MessageBOX(4, "¿Seguro que deseas eliminar este elemento?");
                if (mes.ShowDialog() == DialogResult.OK)
                {
                    dgvEstatus.Rows.Remove(dgvEstatus.Rows[fila]);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEstatus.Rows)
            {

                int cvePedidoIdentity = int.Parse(row.Cells["ColumnCvePedido"].Value.ToString());//ID de la tabla Pedido
                operacion.actualizarCostoEnvio(cvePedidoIdentity, txtCveCosto.Text);

                string usuario = lblUsuario.Text;
                string idPedido = row.Cells["ColumnPed"].Value.ToString();
                string nombrePieza = row.Cells["ColumnPieza"].Value.ToString();
                string descripcionLog = "El usuario: " + usuario + " hizo cambios al costo de envío del pedido: " + idPedido + " de la pieza: " + nombrePieza + " el día: " + DateTime.Now.ToString();
                operacion.Log(usuario, idPedido, descripcionLog, "16");
            }
            dgvEstatus.DataSource = null;
            dgvEstatus.Rows.Clear();
            txtCveCosto.Text = string.Empty;
            MessageBOX.SHowDialog(3, "Datos registrados correctamente!");
        }
    }
}
