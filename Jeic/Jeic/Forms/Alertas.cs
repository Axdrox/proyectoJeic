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

namespace Refracciones.Forms
{
    public partial class Alertas : Form
    {
        OperBD oper = new OperBD();
        public Alertas()
        {
            InitializeComponent();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
            DateTime fecha_sys = DateTime.Parse((DateTime.Now.ToShortDateString()));
            dgvAlertas.DataSource = oper.Alertass(fecha_sys);
        }

        private void Alertas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void RBTNChangeD(object sender, EventArgs e) 
        {
            if (rbtnFacturas.Checked)
            {
                DateTime fecha_sys = DateTime.Parse((DateTime.Now.ToShortDateString()));
                dgvAlertas.DataSource = oper.Alertass(fecha_sys);
            }
            else {
                dgvAlertas.DataSource = oper.Alertas();
            }    
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
