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
        private OperBD operacion = new OperBD();

        public Siniestro()
        {
            InitializeComponent();
        }

        private void Siniestro_Load(object sender, EventArgs e)
        {
            //Carga los datos de los modelos de vehículos en el combobox
            cbVehiculo.DataSource = operacion.VehiculosRegistrados().Tables[0].DefaultView;
            cbVehiculo.ValueMember = "modelo";

            //Hace que no sea posible escribir en el combobox, también se puede configurar seleccionando el elemento
            this.cbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;

            dtpYear.Hide();
            lblAnioRegistro.Hide();
            lblIngreseNombre.Hide();
            txtNombreVehiculoNuevo.Hide();

            //Hace que el DateTimePicker sea un tipo de selección en forma de lista
            //dtpYear.Format = DateTimePickerFormat.Custom;
            //dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnio.Text = operacion.anioVehiculo(cbVehiculo.Text.Trim());
        }

        private void cbEstadoSiniestro_Click(object sender, EventArgs e)
        {
            cbEstadoSiniestro.DataSource = operacion.EstadoSiniestro().Tables[0].DefaultView;
            cbEstadoSiniestro.ValueMember = "estado";
        }

        private void chbOtroVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroVehiculo.Checked == true)
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

        private string nombreVehiculo = "";
        private string anioVehiculo = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(0);
            try
            {
                if (txtClaveSiniestro.Text.Trim() == "" || (chbOtroVehiculo.Checked && txtNombreVehiculoNuevo.Text.Trim() == ""))
                {
                    MessageBox.Show("Favor de llenar todos los campos.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    if (MessageBox.Show("¿Los datos son correctos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (chbOtroVehiculo.Checked == true)
                        {
                            if (operacion.existeVehiculo(txtNombreVehiculoNuevo.Text.Trim().ToUpper(), anioVehiculo = dtpYear.Text.Trim()) == "")
                            {
                                nombreVehiculo = txtNombreVehiculoNuevo.Text.Trim().ToUpper();
                                anioVehiculo = dtpYear.Text.Trim();
                                this.Close();
                            }
                            else
                            {
                                lblIngreseNombre.Hide();
                                txtNombreVehiculoNuevo.Hide();
                                txtNombreVehiculoNuevo.Clear();
                                dtpYear.Hide();
                                dtpYear.Text = "";
                                lblAnioRegistro.Hide();
                                lblAnio.Show();
                                lblAnioTexto.Show();
                                lblVehiculoText.Show();
                                cbVehiculo.Show();
                                chbOtroVehiculo.Checked = false;
                                MessageBox.Show("Ya existe un vehículo con esas características", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            nombreVehiculo = cbVehiculo.Text.Trim();
                            anioVehiculo = lblAnio.Text.Trim();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        public string claveSiniestro
        {
            get { return txtClaveSiniestro.Text.Trim().ToUpper(); }
        }

        public string vehiculoSiniestro
        {
            get { return nombreVehiculo; }
        }

        public string anioSiniestro
        {
            get { return anioVehiculo; }
        }

        public string comentario
        {
            get { return txtComentario.Text.Trim(); }
        }

        public bool otroVehiculo
        {
            get { return chbOtroVehiculo.Checked; }
        }

        public string estadoSiniestro
        {
            get { return cbEstadoSiniestro.Text.Trim(); }
        }

        private void Siniestro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("¿Regresar a Pedido?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}