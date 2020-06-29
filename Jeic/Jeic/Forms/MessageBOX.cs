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
using DocumentFormat.OpenXml.Presentation;
using Refracciones.Properties;

namespace Refracciones.Forms
{
    public partial class MessageBOX : Form
    {
        int funcionamiento = 0;

        public MessageBOX(int funcion, string mensaje)
        {
            InitializeComponent();

            lblTexto.Text = mensaje;

            if (mensaje == "Bienvenido" && funcion == 1 )
            {
                lblTexto.Visible = false;
                GifHecho.Image = Resources.Cargando;
                lblTexto.Location = new Point(0, 90);
                Retraso_icono.Interval = 2000;
                btnOK.Text = "Continuar";
            }
            else if (funcion == 2)
            {
                GifHecho.Image = Resources.Error;
                this.Size = new Size(311, 118);
                GifHecho.Size = new Size(77, 57);
                GifHecho.Location = new Point(12, 12);
                lblTexto.Size = new Size(213, 37);
                lblTexto.Location = new Point(95, 22);
                btnOK.Size = new Size(87, 27);
                btnOK.Location = new Point(135, 79);
                btnOK.Text = "OK";
                btnOK.Textcolor = Color.FromArgb(226, 76, 75);
                btnOK.OnHovercolor = Color.FromArgb(235, 135, 135);
                FadeTransition.Delay = 0;
                Retraso_icono.Interval = 1;
            }
            else if (funcion == 3)
            {
                GifHecho.Image = Resources.Correcto;
                this.Size = new Size(311, 118);
                GifHecho.Size = new Size(77, 57);
                GifHecho.Location = new Point(12, 12);
                lblTexto.Size = new Size(213, 37);
                lblTexto.Location = new Point(95, 22);
                btnOK.Size = new Size(87, 27);
                btnOK.Location = new Point(135, 79);
                btnOK.Text = "OK";
                btnOK.Textcolor = Color.FromArgb(65, 165, 238);
                btnOK.OnHovercolor = Color.FromArgb(128, 195, 243);
                FadeTransition.Delay = 0;
                Retraso_icono.Interval = 1;
            }
            else if(funcion==4)
            {
                GifHecho.Image = Resources.Pregunta1;
                this.Size = new Size(311, 118);
                GifHecho.Size = new Size(77, 57);
                GifHecho.Location = new Point(12, 12);
                lblTexto.Size = new Size(213, 37);
                lblTexto.Location = new Point(95, 22);
                btnOK.Size = new Size(87, 27);
                btnOK.Location = new Point(110, 79);
                btnOK.Text = "SI";
                btnNO.Visible = true;
                FadeTransition.Delay = 0;
                Retraso_icono.Interval = 1;
                btnNO.Enabled = true;
                funcionamiento=funcion;
            }

            
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
            if (funcionamiento == 4) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            this.Close();      
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
        }
        //

        public static void SHowDialog (int funcion, string mensaje)
        {
            MessageBOX mes = new MessageBOX(funcion,mensaje);
            mes.ShowDialog();
        }

        private void GifHecho_Click(object sender, EventArgs e)
        {

        }


    }
}
