using Jeic.Properties;
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
    public partial class bajasMultiples : Form
    {
        public bajasMultiples()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private OperBD operacion = new OperBD();
        private string[] datos = new string[10];
        private void bajasMultiples_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.iconJeic;
            dgvEstatus.Columns["ColumnCvePedido"].Visible = false;
            dgvEstatus.Columns["ColumnCveVenta"].Visible = false;
            dgvEstatus.Columns["ColumnCvePieza"].Visible = false;
            dgvEstatus.Columns["ColumnCantidad"].Visible = false;
            dgvEstatus.Columns["ColumnFechaAsig"].Visible = false;
            DateTime maximaFechaInicio = DateTime.Now;
            Fecha_in.MinDate = new DateTime(maximaFechaInicio.Year, maximaFechaInicio.Month, maximaFechaInicio.Day - 5);
            Fecha_in.MaxDate = DateTime.Now;
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
                            datos = operacion.llenarBajaCodigoBarras(claves[1]);
                            if (datos[0] != null)
                            {
                                dgvEstatus.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9]);
                                dgvEstatus.Columns["ColumnCvePedido"].Visible = false;
                                dgvEstatus.Columns["ColumnCveVenta"].Visible = false;
                                dgvEstatus.Columns["ColumnCvePieza"].Visible = false;
                                dgvEstatus.Columns["ColumnCantidad"].Visible = false;
                                dgvEstatus.Columns["ColumnFechaAsig"].Visible = false;
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
                            
                            operacion.llenarBajaCodigoBarrasPedido(dgvEstatus,claves[0]);
                            
                        }
                        existe = false;
                    }
                    txtCodigo.Text = "";
                }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string realizo = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
            DateTime fecha = Fecha_in.Value; //fecha en la cual se registra la baja
            //if (rbtnPorPieza.Checked)
            //{

                foreach (DataGridViewRow row in dgvEstatus.Rows)
                {
                    string cvePedido = row.Cells["ColumnPed"].Value.ToString(); //Valor de pedido de la tabla ventas
                    string cveSiniestro = row.Cells["ColumnSin"].Value.ToString();//valor de siniestro en la tabla ventas
                    int cvePedidoIdentity = int.Parse(row.Cells["ColumnCvePedido"].Value.ToString());//ID de la tabla Pedido
                    int cvePieza = int.Parse(row.Cells["ColumnCvePieza"].Value.ToString());//Valor de la columna cve_pieza en tabla Pedido
                    int cantidad = int.Parse(row.Cells["ColumnCantidad"].Value.ToString());//Cantidad a dar de baja
                    int cveVenta = int.Parse(row.Cells["ColumnCveVenta"].Value.ToString()); //valor de la cveVenta de la tabla ventas
                    DateTime fecha_asigancion = DateTime.Parse(row.Cells["ColumnFechaAsig"].Value.ToString()); //fecha de asignacion de la tabla ventas
                    
                    operacion.registrarBajaCodigoBarras(cveSiniestro,cvePedido,cvePieza,cantidad,fecha,cveVenta,fecha_asigancion,realizo,cvePedidoIdentity);
                }
                dgvEstatus.DataSource = null;
                dgvEstatus.Rows.Clear();
                MessageBOX.SHowDialog(3, "Datos registrados correctamente!");
            //}
        }
    }
}
