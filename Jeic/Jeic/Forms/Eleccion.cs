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
                registroFactura factura = new registroFactura();
                factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;
                factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;
                factura.dato3.Text = "1";
                //LBLUSUARIO
                factura.lblUsuario.Text = lblUsuario.Text;
                DialogResult  =  factura.ShowDialog();
            }
            else if (cve_factura != "0" && cve_refactura == "0")
            {
                registroFactura factura = new registroFactura();
                factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;
                factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;
                factura.dato3.Text = "0";
                //LBLUSUARIO
                factura.lblUsuario.Text = lblUsuario.Text;
                DialogResult = factura.ShowDialog();
            }
            else if (cve_factura != "0" && cve_refactura != "0")
            {
                registrarRefactura refactura = new registrarRefactura();
                refactura.dato1.Text = refactura.dato1.Text + " " + dato_1.Text;
                refactura.dato2.Text = refactura.dato2.Text + " " + dato_2.Text;
                refactura.dato3.Text = "0";
                //LBLUSUARIO
                refactura.lblUsuario.Text = lblUsuario.Text;
                DialogResult = DialogResult = refactura.ShowDialog();
            }
        }

        private void btnRefactura_Click(object sender, EventArgs e)
        {
            //ABRIR FORMULARIO DE REFACTURA
            registrarRefactura refactura = new registrarRefactura();
            refactura.dato1.Text = refactura.dato1.Text + " " + dato_1.Text;
            refactura.dato2.Text = refactura.dato2.Text + " " + dato_2.Text;
            refactura.txtRefactura.Text = dato_3.Text;
            //LBLUSUARIO
            refactura.lblUsuario.Text = lblUsuario.Text;
            DialogResult = DialogResult = refactura.ShowDialog();
        }

        private void btnDevolucionEntrega_Click(object sender, EventArgs e)
        {
            //ABRIR FORMULARIO DE DEVOLUCION/ENTREGA
            Devolucion dev = new Devolucion();
            dev.dato1.Text = dev.dato1.Text + " " + dato_1.Text;
            dev.dato2.Text = dev.dato2.Text + " " + dato_2.Text;
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
            cve_factura = oper.Clave_Fact(dato_1.Text, dato_2.Text);
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
                    btnDevolucionEntrega.Enabled = false;
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

        private void btnModificarDatosPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(1);
            pedido.lblUsuario.Text = lblUsuario.Text;
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
               saveFileDialog1.FileName = "Ped_" + dato_2.Text;
               if (saveFileDialog1.ShowDialog() == DialogResult.OK)
               {
                   if (File.Exists(saveFileDialog1.FileName))
                   {
                         PdfWriter pdfWriter = new PdfWriter(saveFileDialog1.FileName);
                         PdfReader pdfReader = new PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");

                    PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);

                    OperBD pdfnuevo = new OperBD();
                    pdfnuevo.Llenartabla(dgvDatosPDF, dato_2.Text);

                    int NumeroFila = pdfnuevo.NumeroFilas(dato_2.Text);

                    for (int i = 0; i < 3; i++)
                    {
                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                        PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);

                        int y = 659;
                        int x = 109;
                        int Items = 0;



                        //PEDIDO
                        canvas.BeginText().SetFontAndSize(font, 18)
                                 .MoveText(x, y)
                                 .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                 .EndText();
                        //CLIENTE
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 245, y - 2.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                                .EndText();
                        //TALLER
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 243, y - 14.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                .EndText();

                        if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Rodrigo"))
                            canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Andrea"))
                            canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.GREEN).Fill();
                        else if(dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Daniel"))
                            canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.YELLOW).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Julio"))
                            canvas.Rectangle(x + 288, y - 28, 38, 9).SetFillColor(ColorConstants.BLUE).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Alberto"))
                            canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.RED).Fill();
                        else
                            canvas.Rectangle(x + 288, y - 28, 50, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();


                        //COTIZADOR
                        canvas.BeginText().SetFontAndSize(font, 9)
                            .MoveText(x + 292, y - 27)
                            .SetFillColor(ColorConstants.BLACK)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString().ToUpper())
                            .EndText();
                        //VEHICULO
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 252, y - 39.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[11].Value.ToString() + "  -  " + dgvDatosPDF.Rows[0].Cells[4].Value.ToString()+" - "+dgvDatosPDF.Rows[0].Cells[12].Value.ToString())
                                .EndText();
                        //FECHA_ASIGNACION
                        canvas.BeginText().SetFontAndSize(font, 14)
                                .MoveText(x - 77, y - 50)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString().Substring(0, 10))
                                .EndText();             
                        //FECHA_PROMESA
                        canvas.BeginText().SetFontAndSize(font, 14)
                                .MoveText(x + 50, y - 50)
                                .SetFillColor(ColorConstants.RED)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString().Substring(0, 10))
                                .EndText();
                
                        for (int count = 0; count < NumeroFila; count++)
                        {
                            //NUMERO
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x - 49.5, y - 106.5)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText((count + 1).ToString())
                                    .EndText();
                            //PIEZAS
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x - 5, y - 106.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[7].Value.ToString())
                                    .EndText();
                            //CANTIDAD
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 239, y - 106.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[8].Value.ToString())
                                    .EndText();

                            if (dgvDatosPDF.Rows[count].Cells[9].Value.ToString() != "0.00" && i == 0)
                            {
                                //COSTO
                                canvas.BeginText().SetFontAndSize(font, 10)
                                  .MoveText(x + 300, y - 106.5)
                                  .ShowText(dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                  .EndText();          
                            }
                            if (dgvDatosPDF.Rows[count].Cells[10].Value.ToString() != "PENDIENTE" && i == 0)
                            {
                                //PROVEEDOR
                                canvas.BeginText().SetFontAndSize(font, 10)
                                   .MoveText(x + 370, y - 106.5)
                                   .ShowText(dgvDatosPDF.Rows[count].Cells[10].Value.ToString())
                                   .EndText();
                            }

                            Items = count;      
                            //Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[8].Value.ToString());
                            y -= 20;
                        }
                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x - 16, 56.5)
                                    .ShowText((Items+1).ToString())
                                    .EndText();
                    }
                    pdfdoc.Close();
                    MessageBOX.SHowDialog(1, "PDF creado exitosamente");
                    this.Close();
                   }
                else
                {
                    PdfWriter pdfWriter = new PdfWriter(saveFileDialog1.FileName);
                    PdfReader pdfReader = new PdfReader(Application.StartupPath + "\\VALE JEIC.pdf");

                    PdfDocument pdfdoc = new PdfDocument(pdfReader, pdfWriter);

                    OperBD pdfnuevo = new OperBD();
                    pdfnuevo.Llenartabla(dgvDatosPDF, dato_2.Text);

                    int NumeroFila = pdfnuevo.NumeroFilas(dato_2.Text);

                    for (int i = 0; i < 3; i++)
                    {
                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                        PdfFont font = PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD);

                        int y = 659;
                        int x = 109;
                        int Items = 0;



                        //PEDIDO
                        canvas.BeginText().SetFontAndSize(font, 18)
                                 .MoveText(x, y)
                                 .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                 .EndText();
                        //CLIENTE
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 245, y - 2.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                                .EndText();
                        //TALLER
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 243, y - 14.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                .EndText();

                        if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Rodrigo"))
                            canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Andrea"))
                            canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.GREEN).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Daniel"))
                            canvas.Rectangle(x + 288, y - 28, 43, 9).SetFillColor(ColorConstants.YELLOW).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Julio"))
                            canvas.Rectangle(x + 288, y - 28, 38, 9).SetFillColor(ColorConstants.BLUE).Fill();
                        else if (dgvDatosPDF.Rows[0].Cells[3].Value.ToString().Contains("Alberto"))
                            canvas.Rectangle(x + 288, y - 28, 53, 9).SetFillColor(ColorConstants.RED).Fill();
                        else
                            canvas.Rectangle(x + 288, y - 28, 50, 9).SetFillColor(ColorConstants.LIGHT_GRAY).Fill();


                        //COTIZADOR
                        canvas.BeginText().SetFontAndSize(font, 9)
                            .MoveText(x + 292, y - 27)
                            .SetFillColor(ColorConstants.BLACK)
                            .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString().ToUpper())
                            .EndText();
                        //VEHICULO
                        canvas.BeginText().SetFontAndSize(font, 9)
                                .MoveText(x + 252, y - 39.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[11].Value.ToString() + "  -  " + dgvDatosPDF.Rows[0].Cells[4].Value.ToString() + " - " + dgvDatosPDF.Rows[0].Cells[12].Value.ToString())
                                .EndText();
                        //FECHA_ASIGNACION
                        canvas.BeginText().SetFontAndSize(font, 14)
                                .MoveText(x - 77, y - 50)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString().Substring(0, 10))
                                .EndText();
                        //FECHA_PROMESA
                        canvas.BeginText().SetFontAndSize(font, 14)
                                .MoveText(x + 50, y - 50)
                                .SetFillColor(ColorConstants.RED)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString().Substring(0, 10))
                                .EndText();

                        for (int count = 0; count < NumeroFila; count++)
                        {
                            //NUMERO
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x - 49.5, y - 106.5)
                                    .SetFillColor(ColorConstants.BLACK)
                                    .ShowText((count + 1).ToString())
                                    .EndText();
                            //PIEZAS
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x - 5, y - 106.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[7].Value.ToString())
                                    .EndText();
                            //CANTIDAD
                            canvas.BeginText().SetFontAndSize(font, 10)
                                    .MoveText(x + 239, y - 106.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[8].Value.ToString())
                                    .EndText();

                            if (dgvDatosPDF.Rows[count].Cells[9].Value.ToString() != "0.00" && i == 0)
                            {
                                //COSTO
                                canvas.BeginText().SetFontAndSize(font, 10)
                                  .MoveText(x + 300, y - 106.5)
                                  .ShowText(dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                  .EndText();
                            }
                            if (dgvDatosPDF.Rows[count].Cells[10].Value.ToString() != "PENDIENTE" && i == 0)
                            {
                                //PROVEEDOR
                                canvas.BeginText().SetFontAndSize(font, 10)
                                   .MoveText(x + 370, y - 106.5)
                                   .ShowText(dgvDatosPDF.Rows[count].Cells[10].Value.ToString())
                                   .EndText();
                            }


                            Items = count;
                            //Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[8].Value.ToString());
                            y -= 20;
                        }
                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(font, 9)
                                    .MoveText(x - 16, 56.5)
                                    .ShowText((Items+1).ToString())
                                    .EndText();
                    }
                    pdfdoc.Close();
                    MessageBOX.SHowDialog(1, "PDF creado exitosamente");
                    this.Close();
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

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Eleccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}