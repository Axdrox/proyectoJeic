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

namespace Refracciones.Forms
{
    public partial class registroFactura : Form
    {
        public registroFactura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Todos los Archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Variables
            string cve_factura =txtNombre.Text;
            int cve_estado = 2 ; 
            //int cve_refactura = 102 ; 
            decimal fact_sinIVA = 20; 
            decimal fact_neto = 10; 
            DateTime fecha_ingreso = DateTime.Today; 
            DateTime fecha_revision = DateTime.Today; 
            DateTime fecha_pago = DateTime.Today;
            string nombre_factura = string.Empty;
            byte[] file = null;
            string nombre_xml = string.Empty;
            byte[] xml_file = new byte[64];
            Array.Clear(xml_file, 0, xml_file.Length);
            string comentario = "";
            OperBD factura = new OperBD();
            if (txtNombre.Text.Trim().Equals("") || txtRuta.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }
            nombre_factura = openFileDialog1.SafeFileName;
            MessageBox.Show(file.Length.ToString());
            
            MessageBox.Show(factura.Registrar_factura(cve_factura, cve_estado,fact_sinIVA, fact_neto, fecha_ingreso, fecha_revision, fecha_pago,nombre_factura, file,nombre_xml,xml_file,comentario));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OperBD factura = new OperBD();

            string path = AppDomain.CurrentDomain.BaseDirectory;
            string folder = path + "/temp/";
            string fullFilePath = folder + factura.Nombre_Factura(Int32.Parse(txtCveFactura.Text));

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //if (File.Exists(fullFilePath))
              //  Directory.Delete(fullFilePath);

            File.WriteAllBytes(fullFilePath,factura.Buscar_factura(Int32.Parse(txtCveFactura.Text)));
           // MessageBox.Show(factura.Buscar_factura(Int32.Parse(txtCveFactura.Text)).Length.ToString());
            Process.Start(fullFilePath);
        }
    }
}
