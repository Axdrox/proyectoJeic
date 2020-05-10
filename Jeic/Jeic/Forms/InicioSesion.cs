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
            if (txtContrasenia.Text == "Default")
                txtContrasenia.Text = "";
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContrasenia.ForeColor = Color.White;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                OperBD Operacion = new OperBD();
                if (Operacion.logeo(txtUsuario.Text.ToUpper(), txtContrasenia.Text) == 1)
                {
                    Alertas alert = new Alertas();
                    MessageBox.Show("Bienvenido");
                    Forms.Busqueda_Devolver bus = new Forms.Busqueda_Devolver();
                    bus.Show();
                    alert.Show();

                    bus.lblUsuario.Text = "Usuario : " + txtUsuario.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";
                }
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            OperBD Operacion = new OperBD();
            if (Operacion.logeo(txtUsuario.Text.ToUpper(), txtContrasenia.Text) == 1)
            {
                Alertas alert = new Alertas();
                MessageBox.Show("Bienvenido");
                Forms.Busqueda_Devolver bus = new Forms.Busqueda_Devolver();
                bus.lblUsuario.Text = "Usuario : " + txtUsuario.Text.ToUpper();
                bus.Show();
                alert.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
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
                if (Operacion.logeo(txtUsuario.Text.ToUpper(), txtContrasenia.Text) == 1)
                {
                    Alertas alert = new Alertas();
                    MessageBox.Show("Bienvenido");
                    Forms.Busqueda_Devolver bus = new Forms.Busqueda_Devolver();
                    bus.Show();
                    alert.Show();

                    bus.lblUsuario.Text = "Usuario : " + txtUsuario.Text.ToUpper();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtUsuario.Text = "";
                    txtContrasenia.Text = "";
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