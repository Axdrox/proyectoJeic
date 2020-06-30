using Refracciones.Properties;
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
    public partial class Busqueda : Form
    {
        string cve_factura = "";
        public Busqueda()
        {
            InitializeComponent();
        }


        OperBD llenar = new OperBD();
        OperBD ObtenerRol = new OperBD();
        OperBD llenarDefaultDGV = new OperBD();

        private void Busqueda_Devolver_Load(object sender, EventArgs e)
        {

            this.Icon = Resources.iconJeic;
            llenarDefaultDGV.defaultDGV(dvgPedido);
            menuStrip1.ForeColor = Color.White;
            int rol = ObtenerRol.Rol(Usuario.Text.Substring(9, Usuario.Text.Length - 9));
            switch (rol)
            {
                case 1:
                    btnAgregarPedido.Visible = false;
                    generarReporteVentasToolStripMenuItem.Enabled = false;
                    administrarToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    btnAgregarPedido.Visible = false;
                    administrarToolStripMenuItem.Enabled = false;
                    buscarFacturasToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    generarReporteVentasToolStripMenuItem.Enabled = false;
                    notificacionesToolStripMenuItem.Enabled = false;
                    administrarToolStripMenuItem.Enabled = false;
                    buscarFacturasToolStripMenuItem.Enabled = false;
                    break;
                default:
                    break;
            }

        }

 

        private void BusquedaPedido(object sender, KeyEventArgs e)
        {
            llenar.Llenartabla1(dvgPedido, TxtClaveSin.Text.ToString(), TxtClavePed.Text.ToString(), txtCveVendedor.Text.ToString());
        }
  
        private void dvgPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Int32.Parse(e.RowIndex.ToString());


            if (fila == -1) { }
            else if (e.ColumnIndex == -1) {
                string EstadoFact = "";
                OperBD llenardatos = new OperBD();
                llenardatos.Llenartabla(dgvDatos, dvgPedido.Rows[fila].Cells[1].Value.ToString(),dvgPedido.Rows[fila].Cells[0].Value.ToString(), dvgPedido.Rows[fila].Cells[4].Value.ToString());
                lblcvePedido.Text = lblcvePedido.Text.Substring(0, 9) + " " + dgvDatos.Rows[0].Cells[0].Value.ToString();
                lblcveSiniestro.Text = lblcveSiniestro.Text.Substring(0, 12) + " " + dgvDatos.Rows[0].Cells[1].Value.ToString();
                lblPieza.Text = lblPieza.Text.Substring(0, 6) + " " + dgvDatos.Rows[0].Cells[2].Value.ToString();
                lblCantidad.Text = lblCantidad.Text.Substring(0, 9) + " " + dgvDatos.Rows[0].Cells[3].Value.ToString();
                lblVendedor.Text = lblVendedor.Text.Substring(0, 9) + " " + dgvDatos.Rows[0].Cells[4].Value.ToString();
                lblClaveSeguimiento.Text = lblClaveSeguimiento.Text.Substring(0, 16) + " " + dgvDatos.Rows[0].Cells[5].Value.ToString();
                lblOrigen.Text = lblOrigen.Text.Substring(0, 7) + " " + dgvDatos.Rows[0].Cells[6].Value.ToString();
                lblProveedor.Text = lblProveedor.Text.Substring(0, 10) + " " + dgvDatos.Rows[0].Cells[7].Value.ToString();
                lblValuador.Text = lblValuador.Text.Substring(0, 9) + " " + dgvDatos.Rows[0].Cells[8].Value.ToString();
                lblCliente.Text = lblCliente.Text.Substring(0, 8) + " " + dgvDatos.Rows[0].Cells[9].Value.ToString();
                lblPortal.Text = lblPortal.Text.Substring(0, 7) + " " + dgvDatos.Rows[0].Cells[10].Value.ToString();
                lblTaller.Text = lblTaller.Text.Substring(0, 7) + " " + dgvDatos.Rows[0].Cells[11].Value.ToString();
                lblAsignacion.Text = lblAsignacion.Text.Substring(0, 15) + " " + dgvDatos.Rows[0].Cells[12].Value.ToString();
                lblPromesa.Text = lblPromesa.Text.Substring(0, 14) + " " + dgvDatos.Rows[0].Cells[13].Value.ToString();
                lblFechaEntreg.Text = lblFechaEntreg.Text.Substring(0, 14) + " " + dgvDatos.Rows[0].Cells[14].Value.ToString();
                lblCostoEnvio.Text = lblCostoEnvio.Text.Substring(0, 15) + " " + dgvDatos.Rows[0].Cells[15].Value.ToString();
                lblCostoNeto.Text = lblCostoNeto.Text.Substring(0, 11) + " " + dgvDatos.Rows[0].Cells[16].Value.ToString();
                lblPrecioVenta.Text = lblPrecioVenta.Text.Substring(0, 16) + " " + dgvDatos.Rows[0].Cells[17].Value.ToString();
                lblPrecioReparacion.Text = lblPrecioReparacion.Text.Substring(0, 21) + " " + dgvDatos.Rows[0].Cells[18].Value.ToString();
                lblCveFactura.Text = lblCveFactura.Text.Substring(0, 10) + " " + dgvDatos.Rows[0].Cells[19].Value.ToString();
                if (dgvDatos.Rows[0].Cells[19].Value.ToString() != string.Empty)
                    cve_factura = dgvDatos.Rows[0].Cells[19].Value.ToString();

                lblFacturaSinIva.Text = lblFacturaSinIva.Text.Substring(0, 16) + " " + dgvDatos.Rows[0].Cells[20].Value.ToString();
                lblFacturaConIva.Text = lblFacturaConIva.Text.Substring(0, 16) + " " + dgvDatos.Rows[0].Cells[21].Value.ToString();
                lblEstadoFac.Text = lblEstadoFac.Text.Substring(0, 7) + " " + dgvDatos.Rows[0].Cells[22].Value.ToString();
            }
            else{
                Eleccion elec = new Eleccion();
                elec.lblUsuario.Text = Usuario.Text;
                elec.dato_1.Text = dvgPedido.Rows[fila].Cells[1].Value.ToString();
                elec.dato_2.Text = dvgPedido.Rows[fila].Cells[0].Value.ToString();
                elec.lblCve_venta.Text = dvgPedido.Rows[fila].Cells[8].Value.ToString();
                elec.ShowDialog();
            }

        }
      
        private void BusquedaFecha(object sender, EventArgs e)
        {
            string Fecha_inicio = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string Fecha_Final = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            OperBD llenarFecha = new OperBD();
            llenarFecha.Llenartabla(dvgPedido, Fecha_inicio, Fecha_Final);
            TxtClavePed.Text = "";
            TxtClaveSin.Text = "";

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
                OperBD factura = new OperBD();

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
            else { MessageBox.Show("No hay una factura registrada para este pedido"); }
            if(factura.Buscar_factura_xml(cve_factura) != null)
            {
                File.WriteAllBytes(fullFilePath2, factura.Buscar_factura_xml(cve_factura));
                Process.Start(fullFilePath2);

            }
            else
            { MessageBox.Show("No hay un XML registrada para este pedido"); }
       
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
                Pedido pedido = new Pedido(0);
                DialogResult result = pedido.ShowDialog(); 
        }

        private void generarReporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                exportarExcel reporte = new exportarExcel();
                reporte.Show();  
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Alertas alerta = new Alertas();
                alerta.Show();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InicioSesion sesion = new InicioSesion();
            sesion.Show();
            this.Close();
                
        }

        private void buscarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                buscarFacturas bfact = new buscarFacturas();
                bfact.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Administrar admon = new Administrar();
                DialogResult result = admon.ShowDialog();           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenarDefaultDGV.defaultDGV(dvgPedido);
        }
    }
}
