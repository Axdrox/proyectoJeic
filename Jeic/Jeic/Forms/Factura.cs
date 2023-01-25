using Refracciones;
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

namespace Jeic.Forms
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            
            OperBD fact = new OperBD();
            if (lblFoRF.Text == "0")
            {
                fact.productosFacturar(dgvFactura, dato1.Text.Substring(11, dato1.Text.Length - 11));
            }
            else if (lblFoRF.Text == "1")
                fact.productosRefacturar(dgvFactura, dato1.Text.Substring(11, dato1.Text.Length - 11));

            dgvFactura.Columns[0].Width = 20;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            OperBD fact = new OperBD();
            int filas = int.Parse(dgvFactura.Rows.Count.ToString());
            int i;
            int j;
            int x = 0;//para validar que al menos se seleccione una pieza tiene que ser != 0
            string[] dat = new string[filas];
            //string message = string.Empty;
            for (i = 0; i < filas; i++)
            {
                bool isSelected = Convert.ToBoolean(dgvFactura.Rows[i].Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    for (j = 0; j < 3; j++)
                    {
                        dat[i] = dgvFactura.Rows[i].Cells[3].Value.ToString();
                    }
                    x++;
                }
            }
            if (x != 0)
            {
                if (lblFoRF.Text == "0")
                {
                    //Abrir formulario factura
                    registroFactura factura = new registroFactura();
                    factura.dato1.Text = dato1.Text;//SINIESTRO
                    factura.dato2.Text = dato2.Text;//PEDIDO
                    factura.lblPieza.Text = lblPieza.Text;
                    factura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                    factura.dato3.Text = "1";// te abre el formulario en modo registrar
                    factura.dat = dat;// Mando las cve_pedidoIdentity al formulario 
                                      //LBLUSUARIO
                    factura.lblUsuario.Text = lblUsuario.Text;
                    factura.txtFacturasinIVA.Text = fact.venta_total(dat).ToString();
                    DialogResult = factura.ShowDialog();
                }
                else if (lblFoRF.Text == "1")
                {
                    //ABRIR FORMULARIO DE REFACTURA
                    registrarRefactura refactura = new registrarRefactura();
                    refactura.dato1.Text = dato1.Text;
                    refactura.dato2.Text = dato2.Text;
                    refactura.dato3.Text = "1";//te abre el formulario en modo registrar Testing 09/11/2020
                    refactura.txtRefactura.Text = dato3.Text;
                    refactura.lblPieza.Text = lblPieza.Text;
                    refactura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                    refactura.dat = dat;// Mando las cve_pedidoIdentity al formulario 
                                        //LBLUSUARIO
                    refactura.lblUsuario.Text = lblUsuario.Text;
                    refactura.txtFacturasinIVA.Text = fact.venta_total(dat).ToString();
                    DialogResult = DialogResult = refactura.ShowDialog();
                }
            }
            else
                MessageBOX.SHowDialog(2, "Selecciona al menos una pieza!");


        }


        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
