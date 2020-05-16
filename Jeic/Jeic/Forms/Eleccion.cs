using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
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

namespace Refracciones
{
    public partial class Eleccion : Form
    {
        int cve_factura;
        int cve_refactura;
        OperBD oper = new OperBD();
        public Eleccion()
        {
            InitializeComponent();
        }


        private void btnFactura_Click(object sender, EventArgs e)
        {
            //ABRIR FORMULARIO DE FACTURA
            
            
            if (cve_factura == 0)
            {
                registroFactura factura = new registroFactura();
                factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;
                factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;
                factura.dato3.Text = "1";
                factura.ShowDialog();

            }
            else if(cve_factura != 0 && cve_refactura == 0)
            {
                registroFactura factura = new registroFactura();
                factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;
                factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;
                factura.dato3.Text = "0";
                factura.ShowDialog();
            }
            else if(cve_factura != 0 && cve_refactura != 0)
            {
                registrarRefactura refactura = new registrarRefactura();
                refactura.dato1.Text = refactura.dato1.Text + " " + dato_1.Text;
                refactura.dato2.Text = refactura.dato2.Text + " " + dato_2.Text;
                refactura.dato3.Text = "0";
                refactura.ShowDialog();
                /*if (cve_refactura == 0)
                {
                    refactura.dato1.Text = dato_1.Text;
                    refactura.dato2.Text = dato_2.Text;
                    refactura.dato3.Text = "1";
                    refactura.ShowDialog();
                }
                else
                {
                    refactura.dato1.Text = dato_1.Text;
                    refactura.dato2.Text = dato_2.Text;
                    refactura.dato3.Text = "0";
                    refactura.ShowDialog();
                }*/


            }
           /* if(dato_3.Text == "0")
            {
                factura.dato3.Text = "1";
            }
            else
            {
                factura.dato3.Text = "0";
            }*/
           
            
        }

        private void btnRefactura_Click(object sender, EventArgs e)
        {
            //ABRIR FORMULARIO DE REFACTURA
            registrarRefactura refactura = new registrarRefactura();
            refactura.dato1.Text = refactura.dato1.Text +" "+ dato_1.Text;
            refactura.dato2.Text = refactura.dato2.Text +" "+ dato_2.Text;
            refactura.txtRefactura.Text = dato_3.Text;
            /*if (dato_3.Text == "0")
            {
                refactura.dato3.Text = "1";
            }
            else
            {
                refactura.dato3.Text = "0";
            }*/
            refactura.ShowDialog();
            
        }

        private void btnDevolucionEntrega_Click(object sender, EventArgs e)
        {
            
            //ABRIR FORMULARIO DE DEVOLUCION/ENTREGA
            Devolucion dev = new Devolucion();
            dev.dato1.Text = dev.dato1.Text + " " + dato_1.Text;
            dev.dato2.Text = dev.dato2.Text + " " + dato_2.Text;
            dev.ShowDialog();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BusquedaEntrega_Devolucion bdev = new BusquedaEntrega_Devolucion();
            bdev.dato1.Text = bdev.dato1.Text + " " + dato_1.Text;
            bdev.dato2.Text = bdev.dato2.Text + " " + dato_2.Text;
            bdev.ShowDialog();
            
        }

        private void Eleccion_Load(object sender, EventArgs e)
        {
            cve_factura = oper.Clave_Fact(dato_1.Text, dato_2.Text);
            if(cve_factura != 0)
                cve_refactura = oper.Clave_Refact(cve_factura);
            
            dato_3.Text = cve_factura.ToString();
            if(dato_3.Text != "0")
            {
                btnFactura.Text = "Modificar Factura";
            }
            else
            {
                btnFactura.Text = "Agregar factura";
                btnRefactura.Enabled = false;
                btnDevolucionEntrega.Enabled = false;
                
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

        private void btnModificarDatosPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(1);
            pedido.textBoxPedido = clavePedido;
            pedido.labelSiniestro = claveSiniestro;
            pedido.ShowDialog();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PdfWriter pdfWriter = new PdfWriter(@"D:\VALE.pdf");
            PdfReader pdfReader = new PdfReader(@"D:\VALE JEIC.pdf");

            PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);
            int i = 692;
            int x = 76;
            //CLIENTE
            PdfCanvas canvasC = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasC.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                    .MoveText(x + 2, i)
                    .ShowText("Bancomer")
                    .EndText();
            //FECHA SOLICITUD
            PdfCanvas canvasFS = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasFS.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                    .MoveText(235, i)
                    .ShowText("14/05/2020")
                    .EndText();
            //FECHA PROMESA
            PdfCanvas canvasFP = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasFP.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                    .MoveText(355, i)
                    .ShowText("24/05/2020")
                    .EndText();
            //TALLER
            PdfCanvas canvasT = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasT.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                    .MoveText(460, i)
                    .ShowText("Tecnocar")
                    .EndText();
            //PEDIDO
            PdfCanvas canvasP = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasP.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5)
                    .MoveText(x + 2, i - 9)
                    .ShowText("ABCTW56")
                    .EndText();
            //SINIESTRO
            PdfCanvas canvasS = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasS.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5)
                    .MoveText(x + 2, i - 16)
                    .ShowText("BBN9T7A")
                    .EndText();
            //MARCA
            PdfCanvas canvasMa = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasMa.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                    .MoveText(x + 270, i - 13)
                    .ShowText("Toledo")
                    .EndText();
            //MODELO
            PdfCanvas canvasMo = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasMo.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                    .MoveText(x + 295, i - 13)
                    .ShowText("2020")
                    .EndText();
            //AÑO
            PdfCanvas canvasAn = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasAn.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                    .MoveText(x + 295, i - 13)
                    .ShowText("2020")
                    .EndText();
            //VENDEDOR
            PdfCanvas canvasR = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasR.BeginText().SetFontAndSize(
                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5)
                    .MoveText(450, i + 11)
                    .ShowText("Bryan Ramírez")
                    .EndText();

            PdfCanvas canvasPi = new PdfCanvas(pdfdoc.GetFirstPage());
            PdfCanvas canvasCa = new PdfCanvas(pdfdoc.GetFirstPage());
            PdfCanvas canvasPt = new PdfCanvas(pdfdoc.GetFirstPage());
            string[] piezas = new string[3];
            piezas[0] = "Engranaje";
            piezas[1] = "Calaberas";
            piezas[2] = "Bateria";
            string[] cantidad = new string[3];
            cantidad[0] = "1";
            cantidad[1] = "2";
            cantidad[2] = "1";
            string[] precio = new string[3];
            precio[0] = "$ " + (Int32.Parse(cantidad[0]) * 75.375).ToString();
            precio[1] = "$ " + (Int32.Parse(cantidad[1]) * 84.50).ToString();
            precio[2] = "$ " + (Int32.Parse(cantidad[2]) * 250).ToString();
            for (int count = 0; count < 3; count++)
            {
                canvasCa.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x - 12, i - 35)
                        .ShowText(cantidad[count])
                        .EndText();
                canvasPi.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x + 20, i - 35)
                        .ShowText(piezas[count])
                        .EndText();
                canvasPt.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x + 410, i - 35)
                        .ShowText(precio[count])
                        .EndText();
                i -= 10;
            }

            double subTotal = 0;
            int numItems = 0;
            for (int c = 0; c < precio.Length; c++)
            {
                subTotal += double.Parse(precio[c].Substring(1, precio[c].Length - 1));
            }
            for (int c = 0; c < cantidad.Length; c++)
            {
                numItems += Int32.Parse(cantidad[c]);
            }
            PdfCanvas canvasnumItems = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasnumItems.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x + 50, i - 210)
                        .ShowText(numItems.ToString())
                        .EndText();
            double Iva = subTotal * .16;
            double Total = subTotal + Iva;
            PdfCanvas canvasStotal = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasStotal.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x + 410, i - 217)
                        .ShowText("$" + subTotal.ToString())
                        .EndText();
            PdfCanvas canvasIva = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasIva.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x + 410, i - 226)
                        .ShowText("$" + (Iva).ToString())
                        .EndText();
            PdfCanvas canvasTotal = new PdfCanvas(pdfdoc.GetFirstPage());
            canvasTotal.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                        .MoveText(x + 410, i - 234)
                        .ShowText("$" + (Total).ToString())
                        .EndText();
            pdfdoc.Close();
        }
    }
}
