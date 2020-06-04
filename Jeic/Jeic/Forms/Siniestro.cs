using Refracciones.Properties;
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
            //Carga los datos de los modelos de vehículos en el combobox
            cbVehiculo.DataSource = operacion.VehiculosRegistrados().Tables[0].DefaultView;
            cbVehiculo.ValueMember = "modelo";

            //Hace que no sea posible escribir en el combobox, también se puede configurar seleccionando el elemento
            this.cbVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;

            //dtpYear.Hide();
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
                lblVehiculoText.Hide();
                cbVehiculo.Hide();
            }
            else
            {
                lblIngreseNombre.Hide();
                txtNombreVehiculoNuevo.Hide();
                lblVehiculoText.Show();
                cbVehiculo.Show();
                txtNombreVehiculoNuevo.Clear();
            }
        }

        private string modelo = "";
        private string marca = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(0);
            try
            {
                if (txtClaveSiniestro.Text.Trim() == "" || (chbOtroVehiculo.Checked == true && txtNombreVehiculoNuevo.Text.Trim() == "") || (chbMarca.Checked == true && txtMarca.Text.Trim() == ""))
                {
                    MessageBox.Show("Favor de llenar todos los campos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int i = 0;
                    if (MessageBox.Show("¿Los datos son correctos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //anioVehiculo = 
                        if (chbOtroVehiculo.Checked == true)
                        {
                            if (operacion.existeVehiculo(txtNombreVehiculoNuevo.Text.Trim().ToUpper()) == "")
                                modelo = txtNombreVehiculoNuevo.Text.Trim().ToUpper();
                            else
                            {
                                lblIngreseNombre.Hide();
                                txtNombreVehiculoNuevo.Hide();
                                txtNombreVehiculoNuevo.Clear();
                                lblVehiculoText.Show();
                                cbVehiculo.Show();
                                chbOtroVehiculo.Checked = false;
                                MessageBox.Show("Modelo ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        if(chbMarca.Checked == true)
                        {
                            if (operacion.existeMarca(txtMarca.Text.Trim().ToUpper()) == "")
                                marca = txtMarca.Text.Trim().ToUpper();
                            else
                            {
                                lblMarca.Location = new Point(26, 41);
                                lblMarca.Text = "Marca:";
                                txtMarca.Hide();
                                txtMarca.Clear();
                                cbMarca.Show();
                                chbMarca.Checked = false;
                                MessageBox.Show("Marca ya existente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        if(chbMarca.Checked == false)
                            marca = cbMarca.Text.Trim();
                        if(chbOtroVehiculo.Checked == false)
                            modelo = cbVehiculo.Text.Trim();

                        this.Close();
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

        private void cbMarca_Click(object sender, EventArgs e)
        {
            cbMarca.DataSource = operacion.MarcasRegistradas().Tables[0].DefaultView;
            cbMarca.ValueMember = "marca";
        }

        private void cbVehiculo_Click(object sender, EventArgs e)
        {
            cbVehiculo.DataSource = operacion.VehiculosRegistrados().Tables[0].DefaultView;
            cbVehiculo.ValueMember = "modelo";
        }

        private void chbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMarca.Checked == true)
            {
                cbMarca.Visible = false;
                cbMarca.SelectedIndex = -1;

                lblMarca.Location = new Point(26, 41);
                lblMarca.Text = "Ingrese marca:";
                txtMarca.Visible = true;
            }
            else
            {
                cbMarca.Visible = true;
                lblMarca.Location = new Point(70, 41);
                lblMarca.Text = "Marca:";
                txtMarca.Visible = false;
            }
        }
    }
}