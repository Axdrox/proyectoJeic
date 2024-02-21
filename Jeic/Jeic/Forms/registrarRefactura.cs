using Jeic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class registrarRefactura : Form
    {
        int x = 0;
        OperBD factura = new OperBD();
        CultureInfo culture = new CultureInfo("en-US");
        string cve_siniestro;
        string cve_pedido;
        public string[] dat;
        public registrarRefactura()
        {
            InitializeComponent();
        }

        private void btnBuscarFact_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = " (*.*)|*.pdf*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaFactura.Text = openFileDialog1.FileName;
            }
        }

        private void btnBuscarXml_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 2
            openFileDialog2.InitialDirectory = "C:\\";
            openFileDialog2.Filter = " (*.*)|*.xml*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtRutaXml.Text = openFileDialog2.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCve_Factura.Text.Trim() == "")
            {
                errorP.SetError(txtCve_Factura, "Introduce un número de factura");
                txtCve_Factura.Focus();
                btnGuardar.Enabled = false;
            }
            else if (txtFacturasinIVA.Text.Trim() == "")
            {
                errorP.SetError(txtFacturasinIVA, "No se puede dejar este campo vacío");
                txtFacturasinIVA.Focus();
                btnGuardar.Enabled = false;
            }
            else if (txtCostoRefactura.Text.Trim() == "")
            {
                errorP.SetError(txtCostoRefactura, "No se puede dejar este campo vacío");
                txtCostoRefactura.Focus();
                btnGuardar.Enabled = false;
            }
            else
            {
                /*string cve_siniestro = dato1.Text;
                int cve_pedido = Int32.Parse(dato2.Text);*/
                CultureInfo culture = new CultureInfo("en-US");
                //Variables
                string cve_factura = txtCve_Factura.Text;
                string cve_refactura = txtRefactura.Text;
                int cve_estado = 1;
                decimal fact_sinIVA = decimal.Parse(txtFacturasinIVA.Text, culture);
                decimal descuento = decimal.Parse(txtDescuento.Text,culture);
                decimal fact_neto = decimal.Parse(txtFacturaconIVA.Text, culture);
                decimal costo_refactura = decimal.Parse(txtCostoRefactura.Text, culture);
                DateTime fecha_ingreso = DateTime.MinValue;
                DateTime fecha_revision = DateTime.MinValue;
                DateTime fecha_pago = DateTime.MinValue;
                DateTime fecha_refactura = DateTime.MinValue;
                string nombre_factura = string.Empty;
                byte[] file = null;
                string nombre_xml = string.Empty;
                byte[] xml_file = null;
                string comentario = txtComentario.Text;


                if (cmbEstadoFactura.Text.Trim().Equals("PAGADA"))
                    cve_estado = 2;
                else if (cmbEstadoFactura.Text.Trim().Equals("CANCELADA"))
                    cve_estado = 3;

                //if (chkFechaIngreso.Checked)
                fecha_ingreso = DateTime.Parse(dtpFechaIngreso.Value.ToShortDateString());
                // if (chkFechaRevision.Checked)
                fecha_revision = DateTime.Parse(dtpFechaRevision.Value.ToShortDateString());
                //if (chkFechaPago.Checked)
                //fecha_pago = DateTime.Parse(dtpFechaPago.Value.ToShortDateString());//Working 08/11/2020
                // if (chkFechaRefacturacion.Checked)
                
                if (dato3.Text == "1")//1 significa que es la primera vez
                {
                    if (chkFP.Checked == true)
                        fecha_pago = dtpFechaPago.Value.Date;
                    else
                        fecha_pago = DateTime.MinValue;
                }
                else
                {
                    if (chkFP.Checked == true)
                        fecha_pago = dtpFechaPago.Value.Date;
                    else
                        fecha_pago = DateTime.Parse(dataGridView1.Rows[0].Cells[10].Value.ToString());
                }


                fecha_refactura = DateTime.Parse(dtpFechaRefacturacion.Value.ToShortDateString());
                if (txtRutaFactura.Text == string.Empty && txtRutaXml.Text == string.Empty)
                { }
                else
                {
                    //obtenemos el arreglo de bytes de factura
                    Stream myStream = openFileDialog1.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        myStream.CopyTo(ms);
                        file = ms.ToArray();
                    }
                    nombre_factura = openFileDialog1.SafeFileName;
                    //obtenemos el arreglo de bytes del xml
                    Stream myStream2 = openFileDialog1.OpenFile();
                    using (MemoryStream ms2 = new MemoryStream())
                    {
                        myStream2.CopyTo(ms2);
                        xml_file = ms2.ToArray();
                    }
                    nombre_xml = openFileDialog2.SafeFileName;
                }
                if (btnGuardar.Text == "Guardar")
                {
                    factura.Registrar_Refactura(cve_factura, cve_estado, cve_refactura, fact_sinIVA, descuento, fact_neto, costo_refactura, fecha_refactura, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario, lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9), dat);
                    string usuario = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
                    string idPedido = cve_pedido;
                    string descripcionLog = "El usuario: " + usuario + " generó la factura para el pedido: " + idPedido + " el día: " + DateTime.Now.ToString();
                    factura.Log(usuario, idPedido, descripcionLog, "10");
                    this.DialogResult = DialogResult.OK;
                }
                else if (btnGuardar.Text == "Actualizar")
                {
                    factura.Actualizar_Refactura(cve_factura, cve_estado, cve_refactura, fact_sinIVA, descuento, fact_neto, costo_refactura, fecha_refactura, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario, lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9));
                    string usuario = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
                    string idPedido = cve_pedido;
                    string descripcionLog = "El usuario: " + usuario + " actualizó la factura para el pedido: " + idPedido + " el día: " + DateTime.Now.ToString();
                    factura.Log(usuario, idPedido, descripcionLog, "10");
                    this.DialogResult = DialogResult.OK;
                }
            }
            lblPieza.Text = "PIEZA:";//PARA EVITAR ERROR EN BUSCAR FACTURA
            dato1.Text = "SINIESTRO:";
            dato2.Text = "PEDIDO:";
        }

        private void registrarRefactura_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            cve_pedido = dato2.Text.Substring(8, (dato2.Text.Length - 8)); 
            cve_siniestro = dato1.Text.Substring(11, dato1.Text.Length - 11);
            //txtFacturasinIVA.Text = (factura.venta_total(dat)).ToString();
            dtpFechaPago.Value = dtpFechaIngreso.Value.AddDays(factura.Dias_Espera(cve_siniestro, cve_pedido));
            cmbEstadoFactura.SelectedIndex = 0;
            if (dato3.Text == "0")// entra en modo actualizar
            {
                try
                {
                    dataGridView1.DataSource = factura.Actualizar_Factura(factura.Clave_Fact(cve_siniestro,cve_pedido, lblPieza.Text.Substring(7, lblPieza.Text.Length - 7), int.Parse(lblcvePedidoidentity.Text)));
                    if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "1") { cmbEstadoFactura.SelectedIndex = 0; }
                    else if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "2") { cmbEstadoFactura.SelectedIndex = 1; }
                    else if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "3") { cmbEstadoFactura.SelectedIndex = 2; }
                    txtCve_Factura.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txtRefactura.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txtFacturasinIVA.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtDescuento.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtFacturaconIVA.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    txtCostoRefactura.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    dtpFechaRefacturacion.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[7].Value.ToString());
                    dtpFechaIngreso.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[8].Value.ToString());
                    dtpFechaRevision.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[9].Value.ToString());
                    //dtpFechaPago.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[10].Value.ToString());//Working 08/11/2020
                    if (dataGridView1.Rows[0].Cells[10].Value.ToString() == string.Empty || dataGridView1.Rows[0].Cells[10].Value.ToString() == DateTime.MinValue.ToString())
                    {
                        dtpFechaPago.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpFechaPago.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[10].Value.ToString());
                    }
                    txtComentario.Text = dataGridView1.Rows[0].Cells[11].Value.ToString();
                    txtCve_Factura.ReadOnly = true;
                    btnGuardar.Text = "Actualizar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }

        }

        private void txtRefactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFacturasinIVA_KeyPress(object sender, KeyPressEventArgs e)
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                double calculo = double.Parse(txtFacturasinIVA.Text, culture);
                calculo = calculo * 1.16;
                txtFacturaconIVA.Text = calculo.ToString();
            }
        }

        private void txtCostoRefactura_KeyPress(object sender, KeyPressEventArgs e)
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
        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            
            dtpFechaPago.Value = dtpFechaIngreso.Value.AddDays(factura.Dias_Espera(cve_siniestro, cve_pedido));
            //chkFechaIngreso.Checked = false;
        }

        private void txtFacturasinIVA_Leave(object sender, EventArgs e)
        {
            if (txtFacturasinIVA.Text != string.Empty)
            {
                double calculo = double.Parse(txtFacturasinIVA.Text, culture);
                calculo = calculo * 1.16;
                txtFacturaconIVA.Text = calculo.ToString();
            }
        }

        private void txtFacturasinIVA_TextChanged(object sender, EventArgs e)
        {
            if (txtFacturasinIVA.Text != string.Empty)
            {
                double calculo = double.Parse(txtFacturasinIVA.Text, culture);
                double porcentajeDescuento = 1 - (double.Parse(txtDescuento.Text, culture) / 100);
                calculo = (calculo * porcentajeDescuento) * 1.16;
                txtFacturaconIVA.Text = calculo.ToString();
            }
            if (txtFacturasinIVA.Text.Trim() == "")
            {
                errorP.SetError(txtFacturasinIVA, "No se puede dejar este campo vacío");
                txtFacturasinIVA.Focus();
                btnGuardar.Enabled = false;
            }
            else
            {
                errorP.Clear();

            }
            //btnGuardar.Enabled = true;
        }

        private void txtCve_Factura_TextChanged(object sender, EventArgs e)
        {
            //btnGuardar.Enabled = true;
            if (txtCve_Factura.Text.Trim() == "")
            {
                errorP.SetError(txtCve_Factura, "Introduce un número de factura");
                txtCve_Factura.Focus();
                btnGuardar.Enabled = false;
            }
            else if (factura.factExistente(txtCve_Factura.Text.Trim()) != "0")
            {
                errorP.SetError(txtCve_Factura, "Esa factura ya existe");
                txtCve_Factura.Focus();
                btnGuardar.Enabled = false;
            }
            else
            {
                errorP.Clear();

            }
        }

        private void txtCostoRefactura_TextChanged(object sender, EventArgs e)
        {
            //btnGuardar.Enabled = true;
            if (txtCostoRefactura.Text.Trim() == "")
            {
                errorP.SetError(txtCostoRefactura, "No se puede dejar este campo vacío");
                txtCostoRefactura.Focus();
                btnGuardar.Enabled = false;
            }
            else
            {
                errorP.Clear();
                btnGuardar.Enabled = true;
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            lblPieza.Text = "PIEZA:";
            dato1.Text = "SINIESTRO:";
            dato2.Text = "PEDIDO:";
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (txtDescuento.Text.Trim() == "")
            {
                txtDescuento.Text = "0";
            }
            if (txtFacturasinIVA.Text != string.Empty)
            {
                double calculo = double.Parse(txtFacturasinIVA.Text, culture);
                double porcentajeDescuento = 1 - (double.Parse(txtDescuento.Text, culture) / 100);
                calculo = (calculo * porcentajeDescuento) * 1.16;
                txtFacturaconIVA.Text = calculo.ToString();
            }
        }

        private void txtRutaFactura_TextChanged(object sender, EventArgs e)
        {
            if (txtRutaFactura.Text.Trim() != "")
            {
                if (txtRutaXml.Text.Trim() == "")
                {
                    errorP.SetError(txtRutaXml, "Introduce un archivo XML");
                    btnGuardar.Enabled = false;
                }
                else
                {
                    errorP.Clear();
                    btnGuardar.Enabled = true;
                }
            }
            else
            {
                errorP.Clear();
                btnGuardar.Enabled = true;
            }
        }

        private void txtRutaXml_TextChanged(object sender, EventArgs e)
        {
            if (txtRutaFactura.Text.Trim() != "")
            {
                if (txtRutaXml.Text.Trim() == "")
                {
                    errorP.SetError(txtRutaXml, "Introduce un archivo XML");
                    btnGuardar.Enabled = false;
                }
                else
                {
                    errorP.Clear();
                    btnGuardar.Enabled = true;
                }
            }
            else
            {
                errorP.Clear();
                btnGuardar.Enabled = true;
            }
        }

        private void chkFP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFP.Checked == true)
            {
                dtpFechaPago.Enabled = true;
            }
            else
            {
                dtpFechaPago.Enabled = false;
            }
        }
    }
}
