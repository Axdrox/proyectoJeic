﻿using System;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pedido.Show();
            this.Hide();
        }

        private void cbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAnio.Text = operacion.anioVehiculo(cbVehiculo.Text.Trim());
        }

        private void Siniestro_Load(object sender, EventArgs e)
        {
            //Carga los datos de los modelos de vehículos en el combobox
            cbVehiculo.DataSource = operacion.VehiculosRegistrados().Tables[0].DefaultView;
            cbVehiculo.ValueMember = "modelo";

            //Hace que no sea posible escribir en el combobox
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
                    MessageBox.Show("Favor de llenar todos los campos.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else{
                    int i = 0;
                    if(MessageBox.Show("¿Los datos son correctos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                        if (chbOtroVehiculo.Checked){
                            operacion.registroVehiculo(txtNombreVehiculoNuevo.Text.Trim().ToUpper(), dtpYear.Text.Trim());
                            i = operacion.registrarSiniestro(txtNombreVehiculoNuevo.Text.Trim().ToUpper(), txtClaveSiniestro.Text.Trim().ToUpper(), txtComentario.Text.Trim());
                            if (i == 1)
                            {
                                pedido.Show();
                                this.Hide();
                            }
                        }
                        else{
                            i = operacion.registrarSiniestro(cbVehiculo.Text.Trim(), txtClaveSiniestro.Text.Trim().ToUpper(), txtComentario.Text.Trim());
                            if (i == 1){
                                pedido.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            catch (Exception EX){
                MessageBox.Show("Error: " + EX.Message);
            }
        }
    }
}
