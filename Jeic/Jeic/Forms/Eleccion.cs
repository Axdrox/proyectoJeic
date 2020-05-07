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
            cve_factura = oper.Clave_Fact(dato_1.Text, Int32.Parse(dato_2.Text));
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
    }
}
