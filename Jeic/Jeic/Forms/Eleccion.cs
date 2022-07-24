using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using Refracciones.Forms;
using Jeic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Colors;
using DocumentFormat.OpenXml.Presentation;
using Jeic.Forms;
using System.Drawing;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace Refracciones
{
    public partial class Eleccion : Form
    {
        private string cve_factura;
        private string cve_refactura;
        private OperBD oper = new OperBD();

        public Eleccion()
        {
            InitializeComponent();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            

            //ABRIR FORMULARIO DE FACTURA
            if (cve_factura == "0")
            {
                Factura fact = new Factura();
                fact.lblcveVenta.Text = lblCve_venta.Text;
                fact.dato1.Text = fact.dato1.Text + " " + dato_1.Text;//SINIESTRO
                fact.dato2.Text = fact.dato2.Text + " " + dato_2.Text;//PEDIDO
                fact.lblPieza.Text = fact.lblPieza.Text + " " + lblPieza.Text;
                fact.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                fact.dato3.Text = "1";// te abre el formulario en modo registrar
                fact.lblFoRF.Text = "0";// 0 significa factura y 1 significa refactura
                //LBLUSUARIO
                fact.lblUsuario.Text = lblUsuario.Text;
                DialogResult = fact.ShowDialog();
                
                /*registroFactura factura = new registroFactura();
                factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;//SINIESTRO
                factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;//PEDIDO
                factura.lblPieza.Text = factura.lblPieza.Text + " " + lblPieza.Text;
                factura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                factura.dato3.Text = "1";// te abre el formulario en modo registrar
                //LBLUSUARIO
                factura.lblUsuario.Text = lblUsuario.Text;
                //DialogResult  =  factura.ShowDialog();*/
            }
            else if (cve_factura != "0" && cve_refactura == "0")
            {
                registroFactura factura = new registroFactura();
                factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;
                factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;
                factura.lblPieza.Text = factura.lblPieza.Text + " " + lblPieza.Text;
                factura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                factura.dato3.Text = "0";// te abre el formulario en modo actualizar
                //LBLUSUARIO
                factura.lblUsuario.Text = lblUsuario.Text;
                DialogResult = factura.ShowDialog();
            }
            else if (cve_factura != "0" && cve_refactura != "0")
            {
                registrarRefactura refactura = new registrarRefactura();
                refactura.dato1.Text = refactura.dato1.Text + " " + dato_1.Text;
                refactura.dato2.Text = refactura.dato2.Text + " " + dato_2.Text;
                refactura.lblPieza.Text = refactura.lblPieza.Text + " " + lblPieza.Text;
                refactura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                refactura.dato3.Text = "0";// te abre el formulario en modo actualizar
                //LBLUSUARIO
                refactura.lblUsuario.Text = lblUsuario.Text;
                DialogResult = DialogResult = refactura.ShowDialog();
            }
        }

        private void btnRefactura_Click(object sender, EventArgs e)
        {
            Factura fact = new Factura();
            fact.lblcveVenta.Text = lblCve_venta.Text;
            fact.dato1.Text = fact.dato1.Text + " " + dato_1.Text;//SINIESTRO
            fact.dato2.Text = fact.dato2.Text + " " + dato_2.Text;//PEDIDO
            fact.lblPieza.Text = fact.lblPieza.Text + " " + lblPieza.Text;
            fact.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
            fact.dato3.Text = dato_3.Text;// manda la clave a refacturar
            fact.lblFoRF.Text = "1";// 0 significa factura y 1 significa refactura
            //LBLUSUARIO
            fact.lblUsuario.Text = lblUsuario.Text;
            DialogResult = fact.ShowDialog();
            //ABRIR FORMULARIO DE REFACTURA
            /*registrarRefactura refactura = new registrarRefactura();
            refactura.dato1.Text = refactura.dato1.Text + " " + dato_1.Text;
            refactura.dato2.Text = refactura.dato2.Text + " " + dato_2.Text;
            refactura.txtRefactura.Text = dato_3.Text;
            refactura.lblPieza.Text = refactura.lblPieza.Text + " " + lblPieza.Text;
            refactura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
            //LBLUSUARIO
            refactura.lblUsuario.Text = lblUsuario.Text;
            DialogResult = DialogResult = refactura.ShowDialog();*/
        }

        private void btnDevolucionEntrega_Click(object sender, EventArgs e)
        {
            //ABRIR FORMULARIO DE DEVOLUCION/ENTREGA
            Devolucion dev = new Devolucion();
            dev.dato1.Text = dev.dato1.Text + " " + dato_1.Text;
            dev.dato2.Text = dev.dato2.Text + " " + dato_2.Text;
            //dev.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
            //LBLUSUARIO
            dev.lblUsuario.Text = lblUsuario.Text;
            dev.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BusquedaEntrega_Devolucion bdev = new BusquedaEntrega_Devolucion();
            bdev.dato1.Text = bdev.dato1.Text + " " + dato_1.Text;
            bdev.dato2.Text = bdev.dato2.Text + " " + dato_2.Text;
            bdev.lblcve_venta.Text = lblCve_venta.Text;
            bdev.dato3.Text = bdev.dato3.Text + " " + dato_3.Text;
            //LBLUSUARIO
            bdev.lblUsuario.Text = lblUsuario.Text;
            bdev.ShowDialog();
        }

        private void Eleccion_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            cve_factura = oper.Clave_Fact(dato_1.Text, dato_2.Text,lblPieza.Text, int.Parse(lblcvePedidoidentity.Text));
            if (cve_factura != "0")
                cve_refactura = oper.Clave_Refact(cve_factura);

            dato_3.Text = cve_factura.ToString();
            if (dato_3.Text != "0")
            {
                btnFactura.Text = "Modificar Factura";
            }
            else
            {
                btnFactura.Text = "Elaboración de Factura";
                btnRefactura.Enabled = false;
            }

            //PERMISOS
            int rol = oper.Rol(lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9));

            switch (rol)
            {
                case 1:
                    btnModificarDatosPedido.Enabled = true;
                    btnDevolucionEntrega.Enabled = true;
                    btnChecarPedDev.Enabled = false;
                    break;

                case 2:
                    btnFactura.Enabled = false;
                    btnRefactura.Enabled = false;
                    btnModificarDatosPedido.Enabled = true;
                    break;

                case 3:
                    btnFactura.Enabled = false;
                    btnRefactura.Enabled = false;
                    btnDevolucionEntrega.Enabled = false;
                    btnChecarPedDev.Enabled = false;
                    break;
                case 4:
                    btnModificarDatosPedido.Enabled = false;
                    btnFactura.Enabled = false;
                    btnRefactura.Enabled = false;
                    btnDevolucionEntrega.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        public string clavePedido
        {
            get { return dato_2.Text.Trim(); }
        }

        public string claveSiniestro
        {
            get { return dato_1.Text.Trim(); }
        }

        private string clavePedidoTxt = "";

        public string clavePedidoTextBox
        {
            get { return clavePedidoTxt; }
        }
        private void btnModificarDatosPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(1);
            pedido.lblUsuario.Text = lblUsuario.Text;
            pedido.textBoxPedido = clavePedido;
            pedido.labelSiniestro = claveSiniestro;
            DialogResult result = pedido.ShowDialog();
            //implementar aquí si se desea, pasar el txtClavePedido
            if (result == DialogResult.OK)
            { 
                clavePedidoTxt = pedido.clavePedidoTextBox;
                this.Close();
            }

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            oper.generarVale(saveFileDialog1,dgvDatosPDF,dato_2.Text);
            this.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Eleccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}