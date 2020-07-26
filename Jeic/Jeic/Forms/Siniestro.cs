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
    public partial class Siniestro : Form
    {
        private OperBD operacion = new OperBD();

        public Siniestro()
        {
            InitializeComponent();
        }

        private void Siniestro_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;

            //Carga los datos de las marcas de vehículos en el combobox
            cbMarca.DataSource = operacion.MarcasRegistradas(1).Tables[0].DefaultView;
            cbMarca.ValueMember = "marca";

            //Carga los datos de las marcas de vehículos en el combobox
            cbEstadoSiniestro.DataSource = operacion.EstadoSiniestro().Tables[0].DefaultView;
            cbEstadoSiniestro.ValueMember = "estado";

            //dtpYear.Hide();
            lblIngreseNombre.Hide();
            txtNombreVehiculoNuevo.Hide();

            //Hace que el DateTimePicker sea un tipo de selección en forma de lista
            //dtpYear.Format = DateTimePickerFormat.Custom;
            //dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;

            if (txtClaveSiniestro.Text != "Escriba clave del siniestro")
                txtClaveSiniestro.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chbOtroVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOtroVehiculo.Checked == true)
            {
                lblIngreseNombre.Show();
                txtNombreVehiculoNuevo.Show();
                dtpYear.Show();
                lblVehiculoText.Hide();
                cbVehiculo.Hide();
            }
            else
            {
                lblIngreseNombre.Hide();
                txtNombreVehiculoNuevo.Hide();
                lblVehiculoText.Show();
                cbVehiculo.Show();
                txtNombreVehiculoNuevo.Text = "Escriba un nuevo modelo";
                txtNombreVehiculoNuevo.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private string modelo = "";
        private string marca = "";

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(0);
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (txtClaveSiniestro.Text.Trim() == "" || (chbOtroVehiculo.Checked == true && txtNombreVehiculoNuevo.Text.Trim() == "") || (chbMarca.Checked == true && txtMarca.Text.Trim() == ""))
                    {
                        MessageBOX.SHowDialog(2, "Favor de llenar todos los campos");
                    }
                    else
                    {
                        int i = 0;
                        MessageBOX mes = new MessageBOX(4, "¿Los datos son correctos?");
                        if (mes.ShowDialog() == DialogResult.OK)
                        {
                            if (chbOtroVehiculo.Checked == true)
                                modelo = txtNombreVehiculoNuevo.Text.Trim().ToUpper();
                            else
                                modelo = cbVehiculo.Text.Trim();

                            if (chbMarca.Checked == true)
                                marca = txtMarca.Text.Trim().ToUpper();
                            else
                                marca = cbMarca.Text.Trim();

                            this.DialogResult = DialogResult.OK;
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

        public string claveNOSiniestro
        {
            set { txtClaveSiniestro.Text = value; }
        }

        public string claveSiniestro
        {
            get { return txtClaveSiniestro.Text.Trim().ToUpper(); }
        }

        public string vehiculoSiniestro
        {
            get { return modelo; }
        }

        public string anioSiniestro
        {
            get { return dtpYear.Text.Trim(); }
        }

        public string marcaSiniestro
        {
            get { return marca; }
        }

        public string comentario
        {
            get { return txtComentario.Text.Trim(); }
        }

        public bool otroVehiculo
        {
            get { return chbOtroVehiculo.Checked; }
        }

        public bool otroMarca
        {
            get { return chbMarca.Checked; }
        }

        public string estadoSiniestro
        {
            get { return cbEstadoSiniestro.Text.Trim(); }
        }


        private void chbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMarca.Checked == true)
            {
                cbMarca.Visible = false;

                lblMarca.Location = new Point(26, 41);
                lblMarca.Text = "Ingrese marca:";
                txtMarca.Visible = true;
                chbOtroVehiculo.Checked = true;
                chbOtroVehiculo.Enabled = false;
            }
            else
            {
                cbMarca.Visible = true;
                lblMarca.Location = new Point(70, 41);
                lblMarca.Text = "Marca:";
                txtMarca.Visible = false;
                txtMarca.Text = "Escriba una nueva marca";
                txtMarca.ForeColor = Color.FromArgb(160, 160, 140);
                chbOtroVehiculo.Checked = false;
                chbOtroVehiculo.Enabled = true;
            }
        }

        private void txtClaveSiniestro_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(operacion.existeClaveSiniestro(txtClaveSiniestro.Text.Trim().ToUpper())))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtClaveSiniestro, "Ya existe un siniestro con la misma clave");
            }
            else if (txtClaveSiniestro.Text.Trim() == "Escriba clave del siniestro")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtClaveSiniestro, "Favor de llenar este campo");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtClaveSiniestro, null);
            }
        }

        private void txtMarca_Validating(object sender, CancelEventArgs e)
        {
            if (chbMarca.Checked == true)
            {
                if (!string.IsNullOrEmpty(operacion.existeMarca(txtMarca.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtMarca, "Marca existente");
                }
                else if (string.IsNullOrEmpty(txtMarca.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtMarca, "Favor de llenar este campo");
                }
                else if (txtMarca.Text.Trim() == "Escriba una nueva marca")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtMarca, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtMarca, null);
                }
            }
        }

        private void txtNombreVehiculoNuevo_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroVehiculo.Checked == true)
            {
                if (!string.IsNullOrEmpty(operacion.existeVehiculo(txtNombreVehiculoNuevo.Text.Trim().ToUpper())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNombreVehiculoNuevo, "Modelo existente");
                }
                else if (string.IsNullOrEmpty(txtNombreVehiculoNuevo.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNombreVehiculoNuevo, "Favor de llenar este campo");
                }
                else if(txtNombreVehiculoNuevo.Text.Trim() == "Escriba un nuevo modelo")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNombreVehiculoNuevo, "Favor de llenar este campo");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtNombreVehiculoNuevo, null);
                }
            }
        }

        private void txtClaveSiniestro_Enter(object sender, EventArgs e)
        {
            if (txtClaveSiniestro.Text.Trim() == "Escriba clave del siniestro")
            {
                txtClaveSiniestro.Clear();
                txtClaveSiniestro.ForeColor = Color.White;
            }
        }

        private void txtClaveSiniestro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSiniestro.Text.Trim()))
            {
                txtClaveSiniestro.Text = "Escriba clave del siniestro";
                txtClaveSiniestro.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text.Trim() == "Escriba una nueva marca")
            {
                txtMarca.Clear();
                txtMarca.ForeColor = Color.White;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text.Trim()))
            {
                txtMarca.Text = "Escriba una nueva marca";
                txtMarca.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtComentario_Enter(object sender, EventArgs e)
        {
            if (txtComentario.Text.Trim() == "Agregue un comentario")
            {
                txtComentario.Clear();
                txtComentario.ForeColor = Color.White;
            }
        }

        private void txtComentario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComentario.Text.Trim()))
            {
                txtComentario.Text = "Agregue un comentario";
                txtComentario.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void txtNombreVehiculoNuevo_Enter(object sender, EventArgs e)
        {
            if (txtNombreVehiculoNuevo.Text.Trim() == "Escriba un nuevo modelo")
            {
                txtNombreVehiculoNuevo.Clear();
                txtNombreVehiculoNuevo.ForeColor = Color.White;
            }
        }

        private void txtNombreVehiculoNuevo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreVehiculoNuevo.Text.Trim()))
            {
                txtNombreVehiculoNuevo.Text = "Escriba un nuevo modelo";
                txtNombreVehiculoNuevo.ForeColor = Color.FromArgb(160, 160, 140);
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carga los datos de los modelos de vehículos en el combobox
            cbVehiculo.DataSource = operacion.VehiculosRegistrados(cbMarca.Text.Trim()).Tables[0].DefaultView;
            cbVehiculo.ValueMember = "modelo";
        }

        private void cbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbMarca.DroppedDown = false;
        }

        private void cbVehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbVehiculo.DroppedDown = false;
        }

        private void cbMarca_Validating(object sender, CancelEventArgs e)
        {
            if(chbMarca.Checked == false)
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbMarca.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbMarca, "Favor de seleccionar una marca");
                }
                else if (string.IsNullOrEmpty(operacion.existeMarca(cbMarca.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbMarca, "Favor de seleccionar una marca existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbMarca, null);
                }
            }
        }

        private void cbVehiculo_Validating(object sender, CancelEventArgs e)
        {
            if (chbOtroVehiculo.Checked == false)
            {
                OperBD operacion = new OperBD();
                if (string.IsNullOrEmpty(cbVehiculo.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbVehiculo, "Favor de seleccionar un modelo");
                }
                else if (string.IsNullOrEmpty(operacion.existeVehiculo(cbVehiculo.Text.Trim())))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbVehiculo, "Favor de seleccionar un modelo existente");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbVehiculo, null);
                }
            }
        }
    }
}