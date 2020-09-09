using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using Jeic.Properties;

namespace Refracciones.Forms
{
    public partial class registroFactura : Form
    {
        OperBD oper = new OperBD();
        //string estado;
        //int x = 0;
        CultureInfo culture = new CultureInfo("en-US");
        string cve_siniestro;
        string cve_pedido;
        public string[] dat;
        public registroFactura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //configuraciones del openfiledialog 1
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = " (*.*)|*.pdf*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaFactura.Text = openFileDialog1.FileName;
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
            else
            {
                errorP.Clear();
                
                //Variables
                string cve_factura = txtCve_Factura.Text;
                int cve_estado = 1;
                decimal fact_sinIVA = decimal.Parse(txtFacturasinIVA.Text, culture);
                decimal descuento = decimal.Parse(txtDescuento.Text,culture) ;
                decimal fact_neto = decimal.Parse(txtFacturaconIVA.Text, culture);
                DateTime fecha_ingreso;
                DateTime fecha_revision;
                DateTime fecha_pago;
                string nombre_factura = string.Empty;
                byte[] file = null;
                string nombre_xml = string.Empty;
                byte[] xml_file = null;
                string comentario = txtComentario.Text;
                //OperBD factura = new OperBD();

                if (cmbEstadoFactura.Text.Equals("PAGADA"))
                    cve_estado = 2;

                else if (cmbEstadoFactura.Text.Equals("CANCELADA"))
                    cve_estado = 3;


                //fecha_ingreso = dtpFechaIngreso.Value.ToString("dd/MM/yyyy");
                fecha_ingreso = dtpFechaIngreso.Value.Date;
                //fecha_revision = dtpFechaRevision.Value.ToString("dd/MM/yyyy");
                fecha_revision = dtpFechaRevision.Value.Date;
                //fecha_pago = dtpFechaPago.Value.ToString("dd/MM/yyyy");
                fecha_pago = dtpFechaPago.Value.Date;
                //obtenemos el arreglo de bytes de factura
                if (txtRutaFactura.Text == string.Empty && txtRutaXml.Text == string.Empty)
                { }
                else
                {
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
                    //Antes de hacer factura con el dgv para seleccionarMessageBOX.SHowDialog(1, oper.Registrar_factura(cve_siniestro, cve_pedido, cve_factura, cve_estado, fact_sinIVA, descuento, fact_neto, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario,lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9),lblPieza.Text.Substring(7,lblPieza.Text.Length - 7),int.Parse(lblcvePedidoidentity.Text)));
                    oper.Registrar_factura(cve_factura, cve_estado, fact_sinIVA, descuento, fact_neto, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario, lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9), dat);
                    this.Close();
                }
                else if (btnGuardar.Text == "Actualizar")
                {
                    oper.Actualizar_Factura(cve_factura, cve_estado, fact_sinIVA, descuento, fact_neto, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario, lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9));
                    this.Close();
                }
            }
            lblPieza.Text = "PIEZA:";//PARA EVITAR ERROR EN BUSCAR FACTURA
            dato1.Text = "SINIESTRO:";
            dato2.Text = "PEDIDO:";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OperBD factura = new OperBD();

            string path = AppDomain.CurrentDomain.BaseDirectory;
            string folder = path + "/temp/";
            string fullFilePath = folder + factura.Nombre_Factura(txtCve_Factura.Text);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //if (File.Exists(fullFilePath))
              //  Directory.Delete(fullFilePath);

            File.WriteAllBytes(fullFilePath,factura.Buscar_factura(txtCve_Factura.Text));
           // MessageBox.Show(factura.Buscar_factura(Int32.Parse(txtCveFactura.Text)).Length.ToString());
            Process.Start(fullFilePath);
        }

        private void registroFactura_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
                this.Icon = Resources.iconJeic;
                cve_pedido = dato2.Text.Substring(8, (dato2.Text.Length - 8));
                cve_siniestro = dato1.Text.Substring(11, dato1.Text.Length - 11);
                //txtFacturasinIVA.Text = oper.venta_total(dat).ToString();
                cmbEstadoFactura.SelectedIndex = 0;
                dtpFechaPago.Value = dtpFechaIngreso.Value.AddDays(oper.Dias_Espera(cve_siniestro, cve_pedido));
                if (dato3.Text == "0")// significa que se va a modificar una factura existente
                {
                    dataGridView1.DataSource = oper.Actualizar_Factura(oper.Clave_Fact(cve_siniestro, cve_pedido, lblPieza.Text.Substring(7, (lblPieza.Text.Length - 7)), int.Parse(lblcvePedidoidentity.Text)));
                    if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "1") { cmbEstadoFactura.SelectedIndex = 0; }
                    else if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "2") { cmbEstadoFactura.SelectedIndex = 1; }
                    else if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "3") { cmbEstadoFactura.SelectedIndex = 2; }
                    txtCve_Factura.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txtFacturasinIVA.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txtDescuento.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txtFacturaconIVA.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    if (dataGridView1.Rows[0].Cells[8].Value.ToString() != DateTime.MinValue.ToString())
                    { dtpFechaIngreso.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[8].Value.ToString()); }
                    else { dtpFechaIngreso.Value = DateTime.Now; }
                    if (dataGridView1.Rows[0].Cells[9].Value.ToString() != DateTime.MinValue.ToString())
                    { dtpFechaRevision.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[9].Value.ToString()); }
                    else { dtpFechaRevision.Value = DateTime.Now; }
                    if (dataGridView1.Rows[0].Cells[10].Value.ToString() != DateTime.MinValue.ToString())
                    { dtpFechaPago.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[10].Value.ToString()); }
                    else { dtpFechaPago.Value = DateTime.Now; }
                    txtComentario.Text = dataGridView1.Rows[0].Cells[11].Value.ToString();
                    txtCve_Factura.ReadOnly = true;
                    btnGuardar.Text = "Actualizar";
                }
                else
                { }
            
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

        private void txtFacturasinIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;     
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaPago.Value = dtpFechaIngreso.Value.AddDays(oper.Dias_Espera(cve_siniestro, cve_pedido));
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
                errorP.SetError(txtFacturasinIVA, "No se puede dejar este campo vacio");
                txtFacturasinIVA.Focus();
                btnGuardar.Enabled = false;
            }
            else
            {
                errorP.Clear();
                btnGuardar.Enabled = true;
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
            else if (oper.factExistente(txtCve_Factura.Text.Trim()) != "0")
            {
                errorP.SetError(txtCve_Factura, "Esa factura ya existe");
                txtCve_Factura.Focus();
                btnGuardar.Enabled = false;
            }
            else
            {
                errorP.Clear();
                btnGuardar.Enabled = true;
            }
        }

        private void registroFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            lblPieza.Text = "PIEZA:";
            dato1.Text = "SINIESTRO:";
            dato2.Text = "PEDIDO:";
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if(txtDescuento.Text.Trim() == "")
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
    }
}
