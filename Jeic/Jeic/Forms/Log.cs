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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
        OperBD Consulta = new OperBD();
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Log_Load(object sender, EventArgs e)
        {
            //Carga los datos de los nombres de los tipos de cambios registrados
            cmbTipo.DataSource = Consulta.cLogTipo().Tables[0].DefaultView;
            cmbTipo.ValueMember = "tipo";
            Consulta.LogLoad(dgvLog);
        }

        private void txtCvePedido_KeyUp(object sender, KeyEventArgs e)
        {
            string pedido = txtCvePedido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();
             
            Consulta.LogBuscar(dgvLog,pedido, usuario, tipo, fechaInicial, fechaFinal);
            
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            string pedido = txtCvePedido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, pedido, usuario, tipo, fechaInicial, fechaFinal);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pedido = txtCvePedido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, pedido, usuario, tipo, fechaInicial, fechaFinal);
        }

        private void Fecha_Fin_ValueChanged(object sender, EventArgs e)
        {
            string pedido = txtCvePedido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, pedido, usuario, tipo, fechaInicial, fechaFinal);
        }

        private void Fecha_in_ValueChanged(object sender, EventArgs e)
        {
            string pedido = txtCvePedido.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string fechaInicial = Fecha_in.Value.Year.ToString() + "-" + Fecha_in.Value.Month.ToString() + "-" + Fecha_in.Value.Day.ToString();
            string fechaFinal = Fecha_Fin.Value.Year.ToString() + "-" + Fecha_Fin.Value.Month.ToString() + "-" + Fecha_Fin.Value.Day.ToString();

            Consulta.LogBuscar(dgvLog, pedido, usuario, tipo, fechaInicial, fechaFinal);
        }
    }
}
