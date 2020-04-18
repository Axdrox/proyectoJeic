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
    public partial class Siniestro : Form
    {
        Pedido pedido = new Pedido();
        OperBD operacion = new OperBD();

        public Siniestro()
        {
            InitializeComponent();
            //dtpYear.Format = DateTimePickerFormat.Custom;
            //dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
            lblIngreseNombre.Hide();
            txtNombreVehiculoNuevo.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pedido.Show();
            this.Hide();
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnio.Text = operacion.anioVehiculo(cbVehiculo.Text.Trim());;
        }

        private void Siniestro_Load(object sender, EventArgs e)
        {
            cbVehiculo.DataSource = operacion.VehiculosRegistrados().Tables[0].DefaultView;
            cbVehiculo.ValueMember = "modelo";
            dtpYear.Hide();
            lblAnioRegistro.Hide();
        }

        private void chbOtroVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroVehiculo.Checked)
            {
                lblIngreseNombre.Show();
                txtNombreVehiculoNuevo.Show();
                dtpYear.Show();
                lblAnioRegistro.Show();
                lblAnio.Hide();
                lblAnioTexto.Hide();
                lblVehiculoText.Hide();
                cbVehiculo.Hide();
            }
            else
            {
                lblIngreseNombre.Hide();
                txtNombreVehiculoNuevo.Hide();
                dtpYear.Hide();
                lblAnioRegistro.Hide();
                lblAnio.Show();
                lblAnioTexto.Show();
                lblVehiculoText.Show();
                cbVehiculo.Show();
                txtNombreVehiculoNuevo.Clear();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try{
                if(txtClaveSiniestro.Text.Trim() == "" || (chbOtroVehiculo.Checked && txtNombreVehiculoNuevo.Text.Trim() == "")){
                    MessageBox.Show("Favor de llenar todos los campos.", "Cuidado");
                }
                else{
                    if(MessageBox.Show("¿Los datos son correctos?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes){
                        pedido.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception EX){
                MessageBox.Show("Error: " + EX.Message);
            }
        }
    }
}
