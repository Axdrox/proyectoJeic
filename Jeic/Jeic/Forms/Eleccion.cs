using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using Refracciones.Forms;
using Refracciones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
               
            }
          
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
            bdev.lblcve_venta.Text = lblCve_venta.Text;
            bdev.ShowDialog();
            
        }

        private void Eleccion_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
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
                //btnDevolucionEntrega.Enabled = false;
                
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
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "PEDIDO";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Ped_"+dato_2.Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if(File.Exists(saveFileDialog1.FileName))
                {
                PdfWriter pdfWriter = new PdfWriter(saveFileDialog1.FileName);
                    PdfReader pdfReader = new PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");
                    PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);

                    OperBD pdfnuevo = new OperBD();
                    pdfnuevo.Llenartabla(dgvDatosPDF, dato_2.Text);

                    int NumeroFila = pdfnuevo.NumeroFilas(dato_2.Text);
                    int Items = 0;
                    int y = 717;
                    int x = 140;

                    PdfCanvas canvas = new PdfCanvas(pdfdoc.GetFirstPage());

                    //CLIENTE
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x , y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString())
                            .EndText();
                    //CLIENTE2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x , y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString())
                            .EndText();

                    //FECHA SOLICITUD
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x+120, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[7].Value.ToString().Substring(0, 10))
                            .EndText();
                    //FECHA SOLICITUD2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x+120, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[7].Value.ToString().Substring(0, 10))
                            .EndText();

                    //FECHA PROMESA
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x+233, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[8].Value.ToString().Substring(0, 10))
                            .EndText();
                    //FECHA PROMESA2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x+233, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[8].Value.ToString().Substring(0, 10))
                            .EndText();

                    //TALLER
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x+313, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString())
                            .EndText();
                    //TALLER2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x+313, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString())
                            .EndText();

                    //PEDIDO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x+2, y - 10)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                            .EndText();
                    //PEDIDO2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x + 2, y - 381)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                            .EndText();

                    //MODELO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 190, y - 10)
                            .ShowText("/    " + dgvDatosPDF.Rows[0].Cells[9].Value.ToString())
                            .EndText();
                    //MODELO2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 190, y - 381)
                            .ShowText("/    " + dgvDatosPDF.Rows[0].Cells[9].Value.ToString())
                            .EndText();

                    //AÑO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 235, y - 10)
                            .ShowText("/    " + dgvDatosPDF.Rows[0].Cells[10].Value.ToString())
                            .EndText();
                    //AÑO2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 235, y - 381)
                            .ShowText("/ " + dgvDatosPDF.Rows[0].Cells[10].Value.ToString())
                            .EndText();

                    //VENDEDOR
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x+335, y + 9.5)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[4].Value.ToString())
                            .EndText();
                    //VENDEDOR2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x+335, y - 361)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[4].Value.ToString())
                            .EndText();


                    for (int count = 0; count < NumeroFila; count++)
                    {
                        //CANTIDAD
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x+3 , y - 33)
                                .ShowText(dgvDatosPDF.Rows[count].Cells[3].Value.ToString())
                                .EndText();
                        //CANTIDAD2
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x+3 , y - 405)
                                .ShowText(dgvDatosPDF.Rows[count].Cells[3].Value.ToString())
                                .EndText();

                        //PIEZAS
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x + 43, y - 33)
                                .ShowText("- " + dgvDatosPDF.Rows[count].Cells[2].Value.ToString())
                                .EndText();
                        //PIEZAS2
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x + 43, y - 405)
                                .ShowText("- " + dgvDatosPDF.Rows[count].Cells[2].Value.ToString())
                                .EndText();

                        Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[3].Value.ToString());
                        y -= 12;
                    }

                    //NUMERO DE ITEMS
                    canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                                .MoveText(x + 82, 464.5)
                                .ShowText(Items.ToString())
                                .EndText();
                    //NUMERO DE ITEMS2
                    canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                                .MoveText(x + 82, 76)
                                .ShowText(Items.ToString())
                                .EndText();
                     pdfdoc.Close();
                    MessageBox.Show("PDF CREADO");
               }
                else
                {
                    PdfWriter pdfWriter = new PdfWriter(saveFileDialog1.FileName);
                    PdfReader pdfReader = new PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");
                    PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);

                    OperBD pdfnuevo = new OperBD();
                    pdfnuevo.Llenartabla(dgvDatosPDF, dato_2.Text);

                    int NumeroFila = pdfnuevo.NumeroFilas(dato_2.Text);
                    int Items = 0;
                    int y = 717;
                    int x = 140;

                    PdfCanvas canvas = new PdfCanvas(pdfdoc.GetFirstPage());

                    //CLIENTE
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString())
                            .EndText();
                    //CLIENTE2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString())
                            .EndText();

                    //FECHA SOLICITUD
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x + 120, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[7].Value.ToString().Substring(0, 10))
                            .EndText();
                    //FECHA SOLICITUD2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x + 120, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[7].Value.ToString().Substring(0, 10))
                            .EndText();

                    //FECHA PROMESA
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x + 233, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[8].Value.ToString().Substring(0, 10))
                            .EndText();
                    //FECHA PROMESA2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x + 233, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[8].Value.ToString().Substring(0, 10))
                            .EndText();

                    //TALLER
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x + 313, y)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString())
                            .EndText();
                    //TALLER2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 7)
                            .MoveText(x + 313, y - 371)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString())
                            .EndText();

                    //PEDIDO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x + 2, y - 10)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                            .EndText();
                    //PEDIDO2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x + 2, y - 381)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                            .EndText();

                    //MODELO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 190, y - 10)
                            .ShowText("/    " + dgvDatosPDF.Rows[0].Cells[9].Value.ToString())
                            .EndText();
                    //MODELO2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 190, y - 381)
                            .ShowText("/    " + dgvDatosPDF.Rows[0].Cells[9].Value.ToString())
                            .EndText();

                    //AÑO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 239, y - 10)
                            .ShowText("/    " + dgvDatosPDF.Rows[0].Cells[10].Value.ToString())
                            .EndText();
                    //AÑO2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 5.5f)
                            .MoveText(x + 239, y - 381)
                            .ShowText("/ " + dgvDatosPDF.Rows[0].Cells[10].Value.ToString())
                            .EndText();

                    //VENDEDOR
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x + 335, y + 9.5)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[4].Value.ToString())
                            .EndText();
                    //VENDEDOR2
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                            .MoveText(x + 335, y - 361)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[4].Value.ToString())
                            .EndText();


                    for (int count = 0; count < NumeroFila; count++)
                    {
                        //CANTIDAD
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x + 3, y - 33)
                                .ShowText(dgvDatosPDF.Rows[count].Cells[3].Value.ToString())
                                .EndText();
                        //CANTIDAD2
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x + 3, y - 405)
                                .ShowText(dgvDatosPDF.Rows[count].Cells[3].Value.ToString())
                                .EndText();

                        //PIEZAS
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x + 43, y - 33)
                                .ShowText("- " + dgvDatosPDF.Rows[count].Cells[2].Value.ToString())
                                .EndText();
                        //PIEZAS2
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 8)
                                .MoveText(x + 43, y - 405)
                                .ShowText("- " + dgvDatosPDF.Rows[count].Cells[2].Value.ToString())
                                .EndText();

                        Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[3].Value.ToString());
                        y -= 12;
                    }

                    //NUMERO DE ITEMS
                    canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                                .MoveText(x + 82, 464.5)
                                .ShowText(Items.ToString())
                                .EndText();
                    //NUMERO DE ITEMS2
                    canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 6)
                                .MoveText(x + 82, 76)
                                .ShowText(Items.ToString())
                                .EndText();
                    pdfdoc.Close();
                    MessageBox.Show("PDF CREADO");
                }
               
           }
      
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
