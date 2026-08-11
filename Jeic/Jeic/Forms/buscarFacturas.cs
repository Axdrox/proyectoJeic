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
            var selectChk = new DataGridViewCheckBoxColumn();
            selectChk.Name = "dataGridViewSelectChkBox";
            selectChk.HeaderText = "Seleccionar";
            selectChk.FlatStyle = FlatStyle.Popup;
            this.dgvFacturas.Columns.Add(selectChk);


            this.Icon = Resources.iconJeic;
            dgvFacturas.DataSource =  factura.buscarFacturass();
            dgvFacturas.Columns["CVE"].Visible = false; //INDEX 17 CVE
            //cmbEstadoFactura.SelectedIndex = 0;

            //Carga los datos registros de clientes/aseguradoras en el combobox
            cbAseguradora.DataSource = factura.ClientesRegistrados(1, "Todos").Tables[0].DefaultView;
            cbAseguradora.ValueMember = "cve_nombre";

            cmbEstadoFactura.SelectedIndex = 0;
            cmbfiltroEstadoFactura.SelectedIndex = 0;
            
        }

        private void dgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int fila = Int32.Parse(e.RowIndex.ToString());
            
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
                else 
                { 
                    //MessageBOX.SHowDialog(2, "No se encontro un PDF"); 
                }
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
                    if (dgvFacturas.Rows[fila].Cells[15].Value.ToString() != "")// SE CAMBIO 12 POR 15 YA QUE SE AGREGARON TRES CAMPOS A LA CONSULTA
                    {
                        
                        refactura.dato1.Text = "SINIESTRO:" + " " + dgvFacturas.Rows[fila].Cells[1].Value.ToString();
                        refactura.dato2.Text = "PEDIDO:" + " " + dgvFacturas.Rows[fila].Cells[2].Value.ToString();
                        refactura.lblPieza.Text = refactura.lblPieza.Text + " " + dgvFacturas.Rows[fila].Cells[3].Value.ToString();
                        refactura.lblcvePedidoidentity.Text = dgvFacturas.Rows[fila].Cells[17].Value.ToString();
                        refactura.dato3.Text = "0";
                        refactura.lblUsuario.Text = lblUsuario.Text;
                        refactura.ShowDialog();
                    }
                    else
                    {
                        rfactura.dato1.Text = "SINIESTRO:" + " " + dgvFacturas.Rows[fila].Cells[1].Value.ToString();
                        rfactura.dato2.Text = "PEDIDO:" + " " + dgvFacturas.Rows[fila].Cells[2].Value.ToString();
                        rfactura.lblPieza.Text = rfactura.lblPieza.Text + " " + dgvFacturas.Rows[fila].Cells[3].Value.ToString();
                        rfactura.lblcvePedidoidentity.Text = dgvFacturas.Rows[fila].Cells[17].Value.ToString();
                        rfactura.dato3.Text = "0";
                        rfactura.lblUsuario.Text = lblUsuario.Text;
                        rfactura.ShowDialog();
                    }
                    
                }
                
            }*/
        }

        private void txtFactura_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtFactura.Text != "")
            //    dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text,cmbEstadoFactura.SelectedIndex + 1);
            //else
            //    dgvFacturas.DataSource = factura.buscarFacturass();

            //CAMBIOS SOLICITADOS POR ISRAEL AGOSTO 2026
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbfiltroEstadoFactura.SelectedIndex + 1, cbAseguradora.SelectedValue.ToString().Trim(), Fecha_inicio, Fecha_Final);
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
            //string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            //string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            //dgvFacturas.DataSource = factura.buscarFacturass(Fecha_inicio, Fecha_Final);

            //CAMBIOS SOLICITADOS POR ISRAEL AGOSTO 2026
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbfiltroEstadoFactura.SelectedIndex + 1, cbAseguradora.SelectedValue.ToString().Trim(), Fecha_inicio, Fecha_Final);

        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Int32.Parse(e.RowIndex.ToString());

            if (fila == -1) { }
            else if (e.ColumnIndex == 0)
            {
            }
            else
            {
                string cve_factura = dgvFacturas.Rows[fila].Cells[1].Value.ToString();
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
                else { /*MessageBOX.SHowDialog(2, "No se encontro un PDF");*/ }
                if (factura.Buscar_factura_xml(cve_factura) != null)
                {
                    File.WriteAllBytes(fullFilePath2, factura.Buscar_factura_xml(cve_factura));
                    Process.Start(fullFilePath2);

                }
                else
                { }

                if (dgvFacturas.Rows[fila].Cells[2].Value.ToString() == "")
                {

                }
                else
                {
                    if (dgvFacturas.Rows[fila].Cells[16].Value.ToString() != "")// SE CAMBIO 13 POR 16 YA QUE SE AGREGARON TRES CAMPOS A LA CONSULTA
                    {

                        refactura.dato1.Text = "SINIESTRO:" + " " + dgvFacturas.Rows[fila].Cells[2].Value.ToString();
                        refactura.dato2.Text = "PEDIDO:" + " " + dgvFacturas.Rows[fila].Cells[3].Value.ToString();
                        refactura.lblPieza.Text = refactura.lblPieza.Text + " " + dgvFacturas.Rows[fila].Cells[4].Value.ToString();
                        refactura.lblcvePedidoidentity.Text = dgvFacturas.Rows[fila].Cells[18].Value.ToString();
                        refactura.dato3.Text = "0";
                        refactura.lblUsuario.Text = lblUsuario.Text;
                        DialogResult dialogResult =  refactura.ShowDialog();
                        if(dialogResult == DialogResult.OK)
                        {
                            dgvFacturas.DataSource = factura.buscarFacturass();
                        }
                    }
                    else
                    {
                        rfactura.dato1.Text = "SINIESTRO:" + " " + dgvFacturas.Rows[fila].Cells[2].Value.ToString();
                        rfactura.dato2.Text = "PEDIDO:" + " " + dgvFacturas.Rows[fila].Cells[3].Value.ToString();
                        rfactura.lblPieza.Text = rfactura.lblPieza.Text + " " + dgvFacturas.Rows[fila].Cells[4].Value.ToString();
                        rfactura.lblcvePedidoidentity.Text = dgvFacturas.Rows[fila].Cells[18].Value.ToString();
                        rfactura.dato3.Text = "0";
                        rfactura.lblUsuario.Text = lblUsuario.Text;
                        DialogResult dialogResult = rfactura.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            dgvFacturas.DataSource = factura.buscarFacturass();
                        }
                    }

                }

            }
        }

        private void cmbEstadoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtFactura.Text != "")
            //    dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbEstadoFactura.SelectedIndex + 1);
            //else
            //    dgvFacturas.DataSource = factura.buscarFacturass(cmbEstadoFactura.SelectedIndex + 1);

            ////CAMBIOS SOLICITADOS POR ISRAEL AGOSTO 2026
            //string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            //string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            //dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbEstadoFactura.SelectedIndex + 1, cbAseguradora.SelectedValue.ToString().Trim(), Fecha_inicio, Fecha_Final);
        }

        private void cbAseguradora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAMBIOS SOLICITADOS POR ISRAEL AGOSTO 2026
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbfiltroEstadoFactura.SelectedIndex + 1, cbAseguradora.SelectedValue.ToString().Trim(), Fecha_inicio, Fecha_Final);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                // Ignora la fila nueva si el grid permite agregar filas
                if (row.IsNewRow) continue;

                // Revisa si la celda tiene valor y está marcada
                if (row.Cells["dataGridViewSelectChkBox"].Value != null &&
                    (bool)row.Cells["dataGridViewSelectChkBox"].Value == true)
                {
                    // El checkbox está marcado
                    factura.Actualizar_Factura(row.Cells["FACTURA"].Value.ToString(), cmbEstadoFactura.SelectedIndex + 1, dtpfechaPago.Value.Date);

                    string usuario = lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9);
                    string idPedido = row.Cells["PEDIDO"].Value.ToString();
                    string descripcionLog = "El usuario: " + usuario + " actualizó la factura para el pedido: " + idPedido + " el día: " + DateTime.Now.ToString();
                    factura.Log(usuario, idPedido, descripcionLog, "9");

                }
            }


            //REFRESH
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbfiltroEstadoFactura.SelectedIndex + 1, cbAseguradora.SelectedValue.ToString().Trim(), Fecha_inicio, Fecha_Final);
            MessageBOX.SHowDialog(3, "Datos actualizados correctamente!");
        }

        private void cmbfiltroEstadoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CAMBIOS SOLICITADOS POR ISRAEL AGOSTO 2026
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
            dgvFacturas.DataSource = factura.buscarFacturass(txtFactura.Text, cmbfiltroEstadoFactura.SelectedIndex + 1, cbAseguradora.SelectedValue.ToString().Trim(), Fecha_inicio, Fecha_Final);
        }
    }
}
