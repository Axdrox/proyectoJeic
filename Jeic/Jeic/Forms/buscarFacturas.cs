using Jeic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class buscarFacturas : Form
    {
        OperBD factura = new OperBD();
        registroFactura rfactura = new registroFactura();
        registrarRefactura refactura = new registrarRefactura();
        public buscarFacturas()
        {
            InitializeComponent();
        }

        private void buscarFacturas_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.iconJeic;
            dgvFacturas.DataSource =  factura.buscarFacturas();
        }

        private void dgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Int32.Parse(e.RowIndex.ToString());
            
            if (fila == -1) { }
            else if (e.ColumnIndex == -1)
            { 
            }
            else
            {
                string cve_factura = dgvFacturas.Rows[fila].Cells[0].Value.ToString();
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                string fullFilePath = folder + factura.Nombre_Factura(cve_factura);
                string fullFilePath2 = folder + factura.Nombre_Factura_xml(cve_factura);
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (factura.Buscar_factura(cve_factura) != null)
                {
                    try
                    {
                        File.WriteAllBytes(fullFilePath, factura.Buscar_factura(cve_factura));
                        Process.Start(fullFilePath);
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Ya tienes abierto el archivo"); }
                }
                else { MessageBOX.SHowDialog(2, "No se encontro un PDF"); ; }
                if (factura.Buscar_factura_xml(cve_factura) != null)
                {
                    File.WriteAllBytes(fullFilePath2, factura.Buscar_factura_xml(cve_factura));
                    Process.Start(fullFilePath2);

                }
                else
                {  }

                if(dgvFacturas.Rows[fila].Cells[1].Value.ToString() == "")
                {

                }
                else
                {
                    if (dgvFacturas.Rows[fila].Cells[12].Value.ToString() != "")
                    {
                        
                        refactura.dato1.Text = "SINIESTRO:" + " " + dgvFacturas.Rows[fila].Cells[1].Value.ToString();
                        refactura.dato2.Text = "PEDIDO:" + " " + dgvFacturas.Rows[fila].Cells[2].Value.ToString();
                        refactura.dato3.Text = "0";
                        refactura.ShowDialog();
                    }
                    else
                    {
                        rfactura.dato1.Text = "SINIESTRO:" + " " + dgvFacturas.Rows[fila].Cells[1].Value.ToString();
                        rfactura.dato2.Text = "PEDIDO:" + " " + dgvFacturas.Rows[fila].Cells[2].Value.ToString();
                        rfactura.dato3.Text = "0";
                        rfactura.ShowDialog();
                    }
                    
                }
                
            }
        }

        private void txtFactura_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFactura.Text != "")
                dgvFacturas.DataSource = factura.buscarFacturas(txtFactura.Text);
            else
                dgvFacturas.DataSource = factura.buscarFacturas();
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buscarFacturas_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {

        }
        private void BusquedaFecha(object sender, EventArgs e)
        {
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            dgvFacturas.DataSource = factura.buscarFacturas(Fecha_inicio, Fecha_Final);
           
        }

    }
}
