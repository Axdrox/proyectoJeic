using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using Refracciones;
using Refracciones.Forms;

namespace Jeic.Forms
{
    public partial class cambioEstatus : Form
    {
        public cambioEstatus()
        {
            InitializeComponent();
        }
        private OperBD operacion = new OperBD();
        private string[] datos = new string[7];
        private void cambioEstatus_Load(object sender, EventArgs e)
        {
            
            cmbEstado.FlatStyle = FlatStyle.Popup;
            //cmbEstado.Name = "dataGridViewStatusCombobox";
            cmbEstado.DataSource = operacion.EstadoSiniestro().Tables[0].DefaultView;
            cmbEstado.ValueMember = "cve_estado";
            cmbEstado.DisplayMember = "estado";
            dgvEstatus.Columns["ColumnCvePedido"].Visible = false;
            dgvEstatus.Columns["ColumnCveVenta"].Visible = false;
            DateTime maximaFechaInicio = DateTime.Now;
            int anio = maximaFechaInicio.Year;
            int mes = maximaFechaInicio.Month;
            int dia = maximaFechaInicio.Day;
            if (dia <= 5)
            {
                int diasMesAnt;
                if (mes != 1)
                {
                    diasMesAnt = DateTime.DaysInMonth(anio, mes - 1);

                }
                else
                {
                    diasMesAnt = DateTime.DaysInMonth(anio, 12);
                }

                Fecha_in.MinDate = new DateTime(anio, mes - 1, diasMesAnt - 5);
                Fecha_in.MaxDate = DateTime.Now;
            }
            else
            {
                Fecha_in.MinDate = new DateTime(anio, mes, dia - 5);
                Fecha_in.MaxDate = maximaFechaInicio;
            }

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstado.SelectedIndex == 5)
            {
                lblFecha.Visible = true;
                Fecha_in.Visible = true;
                Fecha_in.Enabled = true;
            }
            else
            {
                lblFecha.Visible = false;
                Fecha_in.Visible = false;
                Fecha_in.Enabled = false;
            }
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
                            datos = operacion.llenarCodigoBarras(claves[1]);
                            if (datos[0] != null)
                            {
                                dgvEstatus.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);
                                dgvEstatus.Columns["ColumnCvePedido"].Visible = false;
                                dgvEstatus.Columns["ColumnCveVenta"].Visible = false;
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
                            
                            datos = operacion.llenarCodigoBarras(claves[1]);
                            if (datos[0] != null)
                            {
                                dgvEstatus.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);
                                dgvEstatus.Columns["ColumnCvePedido"].Visible = false;
                                dgvEstatus.Columns["ColumnCveVenta"].Visible = false;
                            }
                        }
                        existe = false;
                    }
                    txtCodigo.Text = "";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(rbtnPorPieza.Checked)
            {
                
                foreach (DataGridViewRow row in dgvEstatus.Rows)
                {
                    operacion.registrarEstadoCodigoBarras(row.Cells["ColumnCvePedido"].Value.ToString(),cmbEstado.Text.Trim(), Fecha_in.Value);
                }
                dgvEstatus.DataSource = null;
                dgvEstatus.Rows.Clear();
                MessageBOX.SHowDialog(3, "Datos actualizados correctamente!");
            }
            else if(rbtnPorPedido.Checked)
            {
                foreach (DataGridViewRow row in dgvEstatus.Rows)
                {
                    operacion.registrarEstadoCodigoBarras(int.Parse(row.Cells["ColumnCveVenta"].Value.ToString()), cmbEstado.Text.Trim(), Fecha_in.Value);
                }
                dgvEstatus.DataSource = null;
                dgvEstatus.Rows.Clear();
                MessageBOX.SHowDialog(3, "Datos actualizados correctamente!");
            }

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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(',') && e.KeyChar != Convert.ToChar(Keys.Enter);
        }
    }
}
