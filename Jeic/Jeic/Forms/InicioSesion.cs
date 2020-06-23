using Refracciones.Forms;
using Refracciones.Properties;
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
        public InicioSesion()
        {
            InitializeComponent();
            btnEntrar.BackColor = Color.Transparent;
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.iconJeic;
            btnEntrar.BackColor = Color.Transparent;
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
            if (txtContrasenia.Text == "Default" || txtContrasenia.Text == string.Empty)
            {
                txtContrasenia.Text = "";
                txtContrasenia.isPassword = true;
            }
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContrasenia.ForeColor = Color.White;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                OperBD Operacion = new OperBD();
                if (Operacion.logeo(txtUsuario.Text, txtContrasenia.Text) == 1)
                {
                    Alertas alert = new Alertas();
                    MessageBox.Show("Bienvenido");
                    Forms.Busqueda bus = new Forms.Busqueda();
                    bus.Show();
                    alert.Show();

                   bus.Usuario.Text = "Usuario: " + txtUsuario.Text;
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtUsuario.Text = "Nombre de usuario";
                    txtContrasenia.Text = "Default";
                    txtUsuario.ForeColor = Color.White;
                    txtContrasenia.ForeColor = Color.White;
                }
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            OperBD Operacion = new OperBD();
            OperBD ObtenerRol = new OperBD();

            if (Operacion.logeo(txtUsuario.Text, txtContrasenia.Text) == 1)
            {
                MessageBox.Show("Bienvenido");
                Forms.Busqueda bus = new Forms.Busqueda();
                bus.Usuario.Text= "Usuario: " + txtUsuario.Text;
                bus.Show();

                int rol = ObtenerRol.Rol(txtUsuario.Text);
                if ( rol== 1 || rol==2 || rol == 0 )
                {
                    Alertas alerta = new Alertas();
                    alerta.Show();
                }

                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
                txtUsuario.Text = "Nombre de usuario";
                txtContrasenia.Text = "Default";
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
        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                OperBD Operacion = new OperBD();
                if (Operacion.logeo(txtUsuario.Text, txtContrasenia.Text) == 1)
                {
                    
                    Alertas alert = new Alertas();
                    MessageBox.Show("Bienvenido");
                    Forms.Busqueda bus = new Forms.Busqueda();
                    bus.Show();
                    alert.Show();

                    bus.Usuario.Text = "Usuario : " + txtUsuario.Text;
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtUsuario.Text = "Nombre de usuario";
                    txtContrasenia.Text = "Default";
                    txtUsuario.ForeColor = Color.White;
                    txtContrasenia.ForeColor = Color.White;
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}