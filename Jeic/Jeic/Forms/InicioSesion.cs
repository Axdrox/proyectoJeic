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
                MessageBox.Show("Bienvenido");
                //Forms.Busqueda_Devolver bus = new Forms.Busqueda_Devolver();
               // bus.ShowDialog();
                //bus.lblUsuario.Text = "Usuario : " + txtUsuario.Text;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }




        }

    }
}
