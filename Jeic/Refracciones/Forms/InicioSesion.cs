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
            if (Operacion.logeo("hec", "12") == 0) {
                MessageBox.Show("El Bryan y el Alex me la pelan");
                BusquedaPedidos ped = new BusquedaPedidos();
                ped.Show();
                this.Hide();
            }




        }

    }
}
