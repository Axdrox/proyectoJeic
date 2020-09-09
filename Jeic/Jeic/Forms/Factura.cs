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
                fact.productosFacturar(dgvFactura, int.Parse(lblcveVenta.Text));
            }
            else if (lblFoRF.Text == "1") 
            fact.productosRefacturar(dgvFactura,int.Parse(lblcveVenta.Text));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int filas = int.Parse(dgvFactura.Rows.Count.ToString());
            int i = 0;
            int j = 0;
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
                    //MessageBox.Show(dat[i]);
                }
            }
                if(lblFoRF.Text == "0")
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
                DialogResult = factura.ShowDialog();
                }
                else if (lblFoRF.Text == "1")
                {
                //ABRIR FORMULARIO DE REFACTURA
                registrarRefactura refactura = new registrarRefactura();
                refactura.dato1.Text = dato1.Text;
                refactura.dato2.Text = dato2.Text;
                refactura.txtRefactura.Text = dato3.Text;
                refactura.lblPieza.Text = lblPieza.Text;
                refactura.lblcvePedidoidentity.Text = lblcvePedidoidentity.Text;
                refactura.dat = dat;// Mando las cve_pedidoIdentity al formulario 
                //LBLUSUARIO
                refactura.lblUsuario.Text = lblUsuario.Text;
                DialogResult = DialogResult = refactura.ShowDialog();
            }



        }
    }
}
