using Jeic.Properties;
using Refracciones;
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
    public partial class Talleres : Form
    {
        OperBD taller = new OperBD();
        public Talleres()
        {
            InitializeComponent();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Talleres_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.iconJeic;
            dgvTalleres.DataSource = taller.buscarTalleres();
        }

        private void txtTaller_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTaller.Text != "")
                dgvTalleres.DataSource = taller.buscarTalleres(txtTaller.Text);
            else
                dgvTalleres.DataSource = taller.buscarTalleres();
        }
    }
}
