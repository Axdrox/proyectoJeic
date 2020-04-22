using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class Pieza : Form
    {
        
        public Pieza()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }

        private void cbPiezaNombre_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbPiezaNombre.DataSource = operacion.NombrePiezasRegistrados().Tables[0].DefaultView;
            cbPiezaNombre.ValueMember = "cve_nombre";
        }

        private void chbOtroPieza_CheckedChanged(object sender, EventArgs e)
        {
            if(chbOtroPieza.Checked == true)
            {
                txtPiezaNombre.Visible = true;
            }
            else
            {
                txtPiezaNombre.Visible = false;
            }
        }

        private void cbPortal_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbPortal.DataSource = operacion.PortalesRegistrados().Tables[0].DefaultView;
            cbPortal.ValueMember = "nombre";
        }

        private void chbOtroPortal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroPortal.Checked == true)
            {
                txtPortal.Visible = true;
            }
            else
            {
                txtPortal.Visible = false;
            }
        }

        private void cbOrigen_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbOrigen.DataSource = operacion.OrigenPiezasRegistradas().Tables[0].DefaultView;
            cbOrigen.ValueMember = "origen";
        }

        private void chbOtroOrigen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroOrigen.Checked == true)
            {
                txtOrigen.Visible = true;
            }
            else
            {
                txtOrigen.Visible = false;
            }
        }

        private void cbProveedores_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            cbProveedores.DataSource = operacion.ProveedoresRegistrados().Tables[0].DefaultView;
            cbProveedores.ValueMember = "cve_nombre";
        }

        private void chbOtroProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroProveedor.Checked == true)
            {
                txtProveedor.Visible = true;
            }
            else
            {
                txtProveedor.Visible = false;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //txtCantidad.ForeColor = Color.Black;
        }

        private void txtDiasEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
