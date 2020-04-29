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

namespace Refracciones.Forms
{
    public partial class registroFactura : Form
    {
        OperBD oper = new OperBD();
        //string estado;
        int x = 0;
        CultureInfo culture = new CultureInfo("en-US");

        string cve_siniestro;
        int cve_pedido;
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

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRutaFactura.Text = openFileDialog1.FileName;
            }
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Eleccion elec = new Eleccion();
            //Busqueda_Devolver elec = new Busqueda_Devolver();
            //MessageBox.Show(elec.cve_siniestro);
            /*string cve_siniestro = "1F";//dato1.Text;
            int cve_pedido = 1;//Int32.Parse(dato2.Text);*/
            
            //Variables
            int cve_factura = Int32.Parse(txtCve_Factura.Text);
            int cve_estado = 1;
            decimal fact_sinIVA = decimal.Parse(txtFacturasinIVA.Text, culture);
            decimal fact_neto = decimal.Parse(txtFacturaconIVA.Text, culture);
            DateTime fecha_ingreso = DateTime.MinValue;
            DateTime fecha_revision = DateTime.MinValue;
            DateTime fecha_pago = DateTime.MinValue;
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

            if (chkFechaIngreso.Checked)
            {
                fecha_ingreso = DateTime.Parse(dtpFechaIngreso.Value.ToShortDateString());
                
            }
            if (chkFechaRevision.Checked)
                fecha_revision = DateTime.Parse(dtpFechaRevision.Value.ToShortDateString());
            //if (chkFechaPago.Checked)
            fecha_pago = DateTime.Parse(dtpFechaPago.Value.ToShortDateString());
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
                MessageBox.Show(oper.Registrar_factura(cve_siniestro, cve_pedido, cve_factura, cve_estado, fact_sinIVA, fact_neto, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario));
            }
            else if (btnGuardar.Text == "Actualizar")
            {
                MessageBox.Show(oper.Actualizar_Factura(cve_factura, cve_estado, fact_sinIVA, fact_neto, fecha_ingreso, fecha_revision, fecha_pago, nombre_factura, file, nombre_xml, xml_file, comentario));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OperBD factura = new OperBD();

            string path = AppDomain.CurrentDomain.BaseDirectory;
            string folder = path + "/temp/";
            string fullFilePath = folder + factura.Nombre_Factura(Int32.Parse(txtCve_Factura.Text));

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //if (File.Exists(fullFilePath))
            //  Directory.Delete(fullFilePath);

            File.WriteAllBytes(fullFilePath, factura.Buscar_factura(Int32.Parse(txtCve_Factura.Text)));
            // MessageBox.Show(factura.Buscar_factura(Int32.Parse(txtCveFactura.Text)).Length.ToString());
            Process.Start(fullFilePath);
        }

        private void registroFactura_Load(object sender, EventArgs e)
        {
            cve_siniestro = "1G";//dato1.Text
            cve_pedido = 2;//Int32.Parse(dato2.Text)
            cmbEstadoFactura.SelectedIndex = 0;
            if (x == 1)
            {
                dataGridView1.DataSource = oper.Actualizar_Factura(1);
                if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "1") { cmbEstadoFactura.SelectedIndex = 0; }
                else if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "2") { cmbEstadoFactura.SelectedIndex = 1; }
                else if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "3") { cmbEstadoFactura.SelectedIndex = 2; }
                txtCve_Factura.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtFacturasinIVA.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                txtFacturaconIVA.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                dtpFechaIngreso.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[7].Value.ToString());
                dtpFechaRevision.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[8].Value.ToString());
                dtpFechaPago.Value = DateTime.Parse(dataGridView1.Rows[0].Cells[9].Value.ToString());
                txtComentario.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
                txtCve_Factura.ReadOnly = true;
                btnGuardar.Text = "Actualizar";
            }
            else
            { }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
                double calculo = double.Parse(txtFacturasinIVA.Text,culture);
                calculo = calculo * 1.16;
                txtFacturaconIVA.Text = calculo.ToString();
            }
        }

        private void txtCve_Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFechaIngreso.Checked == true)
                dtpFechaPago.Value = dtpFechaIngreso.Value.AddDays(oper.Dias_Espera(cve_siniestro,cve_pedido));

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            chkFechaIngreso.Checked = false;
        }
    }
}
