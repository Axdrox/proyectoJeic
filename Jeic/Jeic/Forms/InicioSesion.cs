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
         
        }


        //CODIGO
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            OperBD Operacion = new OperBD();
            if (Operacion.logeo(txtUsuario.Text.ToUpper(), txtContra.Text) == 1)
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

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                OperBD Operacion = new OperBD();
                if (Operacion.logeo(txtUsuario.Text.ToUpper(), txtContra.Text) == 1)
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
                }
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
