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
using System.Diagnostics;
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
        string cve_factura;
        string cve_refactura;
        OperBD oper = new OperBD();

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
                    factura.ShowDialog();
                }
                else if (cve_factura != "0" && cve_refactura == "0")
                {
                    registroFactura factura = new registroFactura();
                    factura.dato1.Text = factura.dato1.Text + " " + dato_1.Text;
                    factura.dato2.Text = factura.dato2.Text + " " + dato_2.Text;
                    factura.dato3.Text = "0";
                    factura.ShowDialog();
                }
                else if (cve_factura != "0" && cve_refactura != "0")
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
            bdev.dato3.Text = bdev.dato3.Text + " " + dato_3.Text;
            bdev.ShowDialog();
            
        }

        private void Eleccion_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            cve_factura = oper.Clave_Fact(dato_1.Text, dato_2.Text);
            if(cve_factura != "0")
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
            }

            //PERMISOS
            int rol = oper.Rol(lblUsuario.Text.Substring(9, lblUsuario.Text.Length - 9));

            switch (rol) {
                case 1:
                    btnModificarDatosPedido.Enabled = false;
                    btnDevolucionEntrega.Enabled = false;
                    btnChecarPedDev.Enabled = false;
                    break;
                case 2:
                    btnFactura.Enabled = false;
                    btnRefactura.Enabled = false;
                    btnModificarDatosPedido.Enabled = false;
                    break;
                case 3:
                    btnFactura.Enabled = false;
                    btnRefactura.Enabled = false;
                    btnDevolucionEntrega.Enabled = false;
                    btnChecarPedDev.Enabled = false;
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
      

                    for (int i = 0; i < 3; i++){
                PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i+1));
                int y = 661;
                int x = 103;
                int Items = 0;


                //PEDIDO
                        canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 18)
                        .MoveText(x, y)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                        .EndText();
                //CLIENTE
                canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                        .MoveText(x+242, y-4.5)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                        .EndText();
                //TALLER
                canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                        .MoveText(x + 240, y - 16.5)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                        .EndText();
                //COTIZADOR
                canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                        .MoveText(x + 254, y - 29)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString())
                        .EndText();
                //VEHICULO
                canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                        .MoveText(x + 249, y - 41.5)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[11].Value.ToString()+"  -  "+dgvDatosPDF.Rows[0].Cells[4].Value.ToString())
                        .EndText();
                //FECHA_ASIGNACION
                canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 12)
                        .MoveText(x-79, y -50)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString().Substring(0, 10))
                        .EndText();
                //FECHA_PROMESA
                canvas.BeginText().SetFontAndSize(
                        PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 12)
                        .MoveText(x +50, y - 50)
                        .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString().Substring(0, 10))
                        .EndText();

                for (int count = 0; count < NumeroFila; count++)
                {
                    //NUMERO
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                            .MoveText(x - 50.5, y - 110.5)
                            .ShowText((count+1).ToString())
                            .EndText();
                    //PIEZAS
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                            .MoveText(x-5, y - 110.5)
                            .ShowText( dgvDatosPDF.Rows[count].Cells[7].Value.ToString())
                            .EndText();
                    //CANTIDAD
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                            .MoveText(x +237, y - 110.5)
                            .ShowText(dgvDatosPDF.Rows[count].Cells[8].Value.ToString())
                            .EndText();
                    //COSTO
                    /*canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                            .MoveText(x + 295, y - 110.5)
                            .ShowText( dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                            .EndText();
                    //PROVEEDOR
                    canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                            .MoveText(x + 380, y - 110.5)
                            .ShowText(dgvDatosPDF.Rows[count].Cells[10].Value.ToString())
                            .EndText();*/

                            Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[8].Value.ToString());
                    y -= 20;
                }
                //NUMERO DE ITEMS
                canvas.BeginText().SetFontAndSize(
                            PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                            .MoveText(x-19, 47.5)
                            .ShowText(Items.ToString())
                            .EndText();
                    }
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

                    for (int i = 0; i < 3; i++)
                    {
                        PdfCanvas canvas = new PdfCanvas(pdfdoc.GetPage(i + 1));
                        int y = 661;
                        int x = 103;
                        int Items = 0;


                        //PEDIDO
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 18)
                                .MoveText(x, y)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[0].Value.ToString())
                                .EndText();
                        //CLIENTE
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                                .MoveText(x + 242, y - 4.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[1].Value.ToString())
                                .EndText();
                        //TALLER
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                                .MoveText(x + 240, y - 16.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[2].Value.ToString())
                                .EndText();
                        //COTIZADOR
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                                .MoveText(x + 254, y - 29)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[3].Value.ToString())
                                .EndText();
                        //VEHICULO
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                                .MoveText(x + 249, y - 41.5)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[11].Value.ToString() + "  -  " + dgvDatosPDF.Rows[0].Cells[4].Value.ToString())
                                .EndText();
                        //FECHA_ASIGNACION
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 12)
                                .MoveText(x - 79, y - 50)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[5].Value.ToString().Substring(0, 10))
                                .EndText();
                        //FECHA_PROMESA
                        canvas.BeginText().SetFontAndSize(
                                PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 12)
                                .MoveText(x + 50, y - 50)
                                .ShowText(dgvDatosPDF.Rows[0].Cells[6].Value.ToString().Substring(0, 10))
                                .EndText();

                        for (int count = 0; count < NumeroFila; count++)
                        {
                            //NUMERO
                            canvas.BeginText().SetFontAndSize(
                                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                                    .MoveText(x - 50.5, y - 110.5)
                                    .ShowText((count + 1).ToString())
                                    .EndText();
                            //PIEZAS
                            canvas.BeginText().SetFontAndSize(
                                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                                    .MoveText(x-5 , y - 110.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[7].Value.ToString())
                                    .EndText();
                            //CANTIDAD
                            canvas.BeginText().SetFontAndSize(
                                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                                    .MoveText(x + 237, y - 110.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[8].Value.ToString())
                                    .EndText();
                            //COSTO
                           /* canvas.BeginText().SetFontAndSize(
                                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                                    .MoveText(x + 295, y - 110.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[9].Value.ToString())
                                    .EndText();
                            //PROVEEDOR
                            canvas.BeginText().SetFontAndSize(
                                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 10)
                                    .MoveText(x + 380, y - 110.5)
                                    .ShowText(dgvDatosPDF.Rows[count].Cells[10].Value.ToString())
                                    .EndText();*/

                            Items += Int32.Parse(dgvDatosPDF.Rows[count].Cells[8].Value.ToString());
                            y -= 20;
                        }
                        //NUMERO DE ITEMS
                        canvas.BeginText().SetFontAndSize(
                                    PdfFontFactory.CreateFont(FontConstants.HELVETICA_BOLD), 9)
                                    .MoveText(x - 19, 47.5)
                                    .ShowText(Items.ToString())
                                    .EndText();
                    }
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

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
