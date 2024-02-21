using Refracciones.Forms;
using Jeic.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//

namespace Refracciones
{
    public partial class InicioSesion : Form
    {
        //CONSTRUCTOR DEL FORM
        OperBD Operacion = new OperBD();
        OperBD ObtenerRol = new OperBD();

        public InicioSesion()
        {
            InitializeComponent();
            btnEntrar.BackColor = Color.Transparent;
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.iconJeic;
            btnEntrar.BackColor = Color.Transparent;
            this.ActiveControl = pictureBox1;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Nombre de usuario")
                txtUsuario.Text = "";
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtUsuario.ForeColor = Color.White;
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            PicOJO.Visible = true;
            if (txtContrasenia.Text == "Default" || txtContrasenia.Text == string.Empty)
            {
                txtContrasenia.Text = "";
                txtContrasenia.isPassword = true;
            }
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContrasenia.ForeColor = Color.White;
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {             
                if (Operacion.logeo(txtUsuario.Text, txtContrasenia.Text) == 1)
                {
                    //MessageBOX.SHowDialog(1, "Bienvenido " + txtUsuario.Text);
                    Forms.Busqueda bus = new Forms.Busqueda();
                    bus.lblcvePe.Text = Operacion.obtenerCvePedido(txtUsuario.Text.Trim());
                    bus.Usuario.Text = "Usuario: " + txtUsuario.Text;
                    bus.Show();

                    /*int rol = ObtenerRol.Rol(txtUsuario.Text);
                    if (rol == 1 || rol == 2 || rol == 0)
                    {
                        Alertas alerta = new Alertas();
                        alerta.Show();
                    }*/

                    /*txtUsuario.Text = "";
                    txtContrasenia.Text = "";
                    this.Hide();*/
                }
                else
                {
                    MessageBOX.SHowDialog(2,"Usuario y/o contraseña incorrectos");
                    txtUsuario.Text = "Nombre de usuario";
                    txtContrasenia.Text = "Default";
                    bunifuCustomLabel1.Focus();
                    txtUsuario.ForeColor = Color.White;
                    txtContrasenia.ForeColor = Color.White;
                }
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            if (Operacion.logeo(txtUsuario.Text, txtContrasenia.Text) == 1)
            {
                //MessageBOX.SHowDialog(1,"Bienvenido "+ txtUsuario.Text);
                Forms.Busqueda bus = new Forms.Busqueda();
                bus.lblcvePe.Text = Operacion.obtenerCvePedido(txtUsuario.Text.Trim());
                bus.Usuario.Text = "Usuario: " + txtUsuario.Text;
                bus.Show();

                /*int rol = ObtenerRol.Rol(txtUsuario.Text);
                if ( rol== 1 || rol==2 || rol == 0 )
                {
                    Alertas alerta = new Alertas();
                    alerta.Show();
                }*/

                string descripcionLog = "El usuario " + txtUsuario.Text + " Inicio sesión al sistema el día: " + DateTime.Now.ToString();
                Operacion.Log(txtUsuario.Text, "", descripcionLog, "1");
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                
                this.Hide();
                
            }
            else
            {
                MessageBOX.SHowDialog(2, "Usuario y/o contraseña incorrectos");
                txtUsuario.Text = "Nombre de usuario";
                txtContrasenia.Text = "Default";
                bunifuCustomLabel1.Focus();
                txtUsuario.ForeColor = Color.White;
                txtContrasenia.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
                txtUsuario.Text = "Nombre de usuario";
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == string.Empty)
                txtContrasenia.Text = "Default";

            txtContrasenia.isPassword = true;
            PicOJO.Visible = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicOJO_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PicOJO.Image.Height.ToString() == "128")
            {
                txtContrasenia.isPassword = false;
                PicOJO.Image = Resources.OjoCerrado;
            }
            else {
                txtContrasenia.isPassword = true;
                PicOJO.Image = Resources.ojo;
            }
        }

        private void PicOJO_MouseHover(object sender, EventArgs e)
        {
            if (PicOJO.Image.Height.ToString() == "128")
                this.ToolTrip.SetToolTip(PicOJO, "Mostrar contraseña");
            else
                this.ToolTrip.SetToolTip(PicOJO, "Ocultar contraseña");

        }


    }
}