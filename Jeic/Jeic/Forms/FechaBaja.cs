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
    public partial class FechaBaja : Form
    {
        public FechaBaja()
        {
            InitializeComponent();
        }

        private void FechaBaja_Load(object sender, EventArgs e)
        {
            if (identificador == 1)
            {
                OperBD operacion = new OperBD();
                dtpFechaBaja.Value = Convert.ToDateTime(operacion.existeFechaBaja(cvePedido, cveSiniestro, nombrePieza, index));
                btnRegistrarFechaBaja.Text = "Modificar";
            }
        }

        private void btnRegistrarFechaBaja_Click(object sender, EventArgs e)
        {
            OperBD operacion = new OperBD();
            if (this.DialogResult != DialogResult.Cancel)
            {
                if (identificador != 1)
                {
                    MessageBOX result = new MessageBOX(4, "¿Registrar fecha de baja?");
                    if (result.ShowDialog() == DialogResult.OK)
                    {
                        operacion.registrarFechaBaja(cvePedido, cveSiniestro, nombrePieza, index, dtpFechaBaja.Value);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBOX result = new MessageBOX(4, "¿Actualizar fecha de baja?");
                    if (result.ShowDialog() == DialogResult.OK)
                    {
                        operacion.registrarFechaBaja(cvePedido, cveSiniestro, nombrePieza, index, dtpFechaBaja.Value);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        public string cvePedido = "";
        public string cveSiniestro = "";
        public string nombrePieza = "";
        public int index = 0;
        public DateTime dt1;

        //Para saber si se modificará una fecha que ya se tenía registrada
        public int identificador = 0;

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FechaBaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void dtpFechaBaja_ValueChanged(object sender, EventArgs e)
        {
            int resta = DateTime.Compare(dt1, dtpFechaBaja.Value);

            if(identificador != 1)
            {
                if (resta > 0)
                {
                    MessageBOX.SHowDialog(2, "No es posible elegir esta fecha");
                    dtpFechaBaja.Value = dt1;
                }
            }
            else
            {
                if (resta > 0)
                {
                    OperBD operacion = new OperBD();
                    MessageBOX.SHowDialog(2, "No es posible elegir esta fecha");
                    dtpFechaBaja.Value = Convert.ToDateTime(operacion.existeFechaBaja(cvePedido, cveSiniestro, nombrePieza, index));
                }
            }
            
        }

        
    }
}
