using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refracciones.Properties;

namespace Refracciones.Forms
{
    public partial class MessageBOX : Form
    {
        public MessageBOX(string mensaje)
        {
            InitializeComponent();

            if (mensaje == "Bienvenido")
            {
                lblTexto.Visible = false;
                GifHecho.Image = Resources.Cargando;
                lblTexto.Location = new Point(0,90);
            }

            lblTexto.Text = mensaje;
        }

        private void MessageBOX_Load(object sender, EventArgs e)
        {
            FadeTransition.ShowAsyc(this);

        }

        private void FadeTransition_TransitionEnd(object sender, EventArgs e)
        {
            Retraso_icono.Start();
            GifHecho.Enabled = true;
        }

        private void Retraso_icono_Tick(object sender, EventArgs e)
        {
            GifHecho.Enabled = false;
            Retraso_icono.Stop();
            btnOK.Visible = true;
            lblTexto.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //

        public static void SHowDialog (string mensaje)
        {
            MessageBOX mes = new MessageBOX(mensaje);
            mes.ShowDialog();
        }
    }
}
