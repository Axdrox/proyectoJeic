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
    public partial class Administrar : Form
    {
        public Administrar()
        {
            InitializeComponent();
        }
        int x = 0;//Se utiliza para saber que botón se selecciona
        int y = 0;//Se utiliza para saber si esta seleccionada la opción de registrar o modificar
        OperBD oper = new OperBD();
        private void Administrar_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            x = 0;
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "USUARIOS";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            x = 1;
            errorP.Clear();
            rbtnModificar.Visible = false;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "CLIENTES";
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            x = 2;
            errorP.Clear();
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "PROVEEDORES";
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            x = 3;
            errorP.Clear();
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "TALLERES";
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            x = 4;
            errorP.Clear();
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "VEHICULOS";
        }

        private void btnPieza_Click(object sender, EventArgs e)
        {
            x = 5;
            errorP.Clear();
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "PIEZA";
        }
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            x = 6;
            errorP.Clear();
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "VENDEDOR";
        }

        private void rbtnRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnRegistrar.Checked == true)
            {
                switch(x)
                {
                    case 0:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = true; cmb1.Visible = true;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        cmb1.DataSource = oper.RolesRegistrados().Tables[0].DefaultView;
                        cmb1.ValueMember = "area";
                        lbl1.Text = "Usuario:";
                        lbl2.Text = "Contraseña:";
                        lbl3.Text = "Tipo de Usuario:";
                        break;
                    case 1:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = true; txt3.Visible = true;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Días de espera:";
                        lbl3.Text = "Valuador:";
                        break;
                    case 2:
                        lbl1.Visible = true;
                        lbl2.Visible = false;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "";
                        lbl3.Text = "";
                        break;
                    case 3:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Dirección:";
                        lbl3.Text = "";
                        break;
                    case 4:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = true; txt3.Visible = true;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = true; cmb4.Visible = true;
                        cmb4.DataSource = oper.MarcasRegistradas().Tables[0].DefaultView;
                        cmb4.ValueMember = "marca";
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Modelo:";
                        lbl2.Text = "Marca:";
                        lbl3.Text = "Año:";
                        break;
                    case 5:
                        lbl1.Visible = true;
                        lbl2.Visible = false;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "";
                        lbl3.Text = "";
                        break;
                    case 6:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = false; cmb3.Visible = false;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Vendedor:";
                        lbl2.Text = "Nombre:";
                        lbl3.Text = "";
                        break;
                }
                y = 0;
            }
        }

        private void rbtnModificar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnModificar.Checked == true)
            {
                switch (x)
                {
                    case 0:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = true; cmb1.Visible = true;
                        cmb2.Enabled = true; cmb2.Visible = true;
                        cmb2.DataSource = null; cmb2.Items.Clear(); cmb2.Items.Add("ACTIVO"); cmb2.Items.Add("SUSPENDIDO");
                        cmb2.SelectedIndex = 0;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        cmb1.DataSource = oper.RolesRegistrados().Tables[0].DefaultView;
                        cmb1.ValueMember = "area";
                        cmb3.DataSource = oper.UsuariosRegistrados().Tables[0].DefaultView;
                        cmb3.ValueMember = "usuario";
                        lbl1.Text = "Usuario:";
                        lbl2.Text = "Contraseña:";
                        lbl3.Text = "Tipo de Usuario:";
                        lbl4.Text = "Estado:";
                        break;
                    case 1:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = false;
                        txt1.Enabled = true; txt1.Visible = true;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = true; txt3.Visible = true;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = true; cmb2.Visible = true;
                        cmb2.SelectedIndex = 0;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        cmb3.DataSource = oper.AseguradorasRegistradas().Tables[0].DefaultView;
                        cmb3.ValueMember = "cve_nombre";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Días de espera:";
                        lbl3.Text = "Valuador:";
                        break;
                    case 2:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.ProveedoresRegistrados().Tables[0].DefaultView;
                        cmb3.ValueMember = "nombre";
                        cmb4.Enabled = true;  cmb4.Visible = true;
                        cmb4.DataSource = null; cmb4.Items.Clear(); cmb4.Items.Add("ACTIVO"); cmb4.Items.Add("SUSPENDIDO");
                        cmb4.SelectedIndex = 0;
                        cmb4.SelectedIndex = 0;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Estado:";
                        lbl3.Text = "";
                        break;
                    case 3:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = true; cmb1.Visible = true;
                        cmb1.DataSource = null;
                        cmb1.Items.Add("ACTIVO"); cmb1.Items.Add("SUSPENDIDO"); cmb1.SelectedIndex = 0;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.TalleresRegistrados().Tables[0].DefaultView;
                        cmb3.ValueMember = "nombre";
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Dirección:";
                        lbl3.Text = "Estado:";
                        break;
                    case 4:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = true; txt3.Visible = true;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = true; cmb2.Visible = true;
                        cmb2.DataSource = null;
                        cmb2.Items.Clear(); cmb2.Items.Add("ACTIVO"); cmb2.Items.Add("SUSPENDIDO"); cmb2.SelectedIndex = 0;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.VehiculosRegistrados().Tables[0].DefaultView;
                        cmb3.ValueMember = "modelo";
                        cmb4.Enabled = true; cmb4.Visible = true;
                        cmb4.DataSource = oper.MarcasRegistradas().Tables[0].DefaultView;
                        cmb4.ValueMember = "marca";
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Modelo:";
                        lbl2.Text = "Marca:";
                        lbl3.Text = "Año:";
                        lbl4.Text = "Estado:";
                        break;
                    case 5:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.NombrePiezasRegistrados().Tables[0].DefaultView;
                        cmb3.ValueMember = "nombre";
                        cmb4.Enabled = true; cmb4.Visible = true;
                        cmb4.DataSource = null; cmb4.Items.Clear(); cmb4.Items.Add("ACTIVO"); cmb4.Items.Add("SUSPENDIDO");
                        cmb4.SelectedIndex = 0;
                        cmb4.SelectedIndex = 0;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Estado:";
                        lbl3.Text = "";
                        break;
                    case 6:
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = false;
                        lbl4.Visible = false;
                        lbl5.Visible = true;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = false; txt2.Visible = false;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.VendedoresRegistradosClaves().Tables[0].DefaultView;
                        cmb3.ValueMember = "cve_vendedor";
                        cmb4.Enabled = true; cmb4.Visible = true;
                        cmb4.DataSource = null; cmb4.Items.Clear(); cmb4.Items.Add("ACTIVO"); cmb4.Items.Add("SUSPENDIDO"); cmb4.SelectedIndex = 0;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Vendedor:";
                        lbl2.Text = "Estado:";
                        lbl3.Text = "";
                        break;
                }
                y = 1;
            }
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int estado;
            
            switch (y)
            {
                case 0:

                    switch (x)
                    {
                        case 0:
                            if (txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();  
                            }
                            else if (txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else
                            {
                                errorP.Clear();
                                oper.singUp(txt1.Text.Trim(), txt2.Text.Trim(), cmb1.Text.Trim());
                                txt1.Text = ""; txt2.Text = "";
                            }

                            
                            break;
                        case 1:
                            if(txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else if (txt3.Text.Trim() == "")
                            {
                                errorP.SetError(txt3, "No se puede dejar este campo sin llenar");
                                txt3.Focus();
                            }
                            else if (oper.existeCliente(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarValuador(txt3.Text.Trim());
                                oper.registrarCliente(txt1.Text.Trim(), txt3.Text.Trim(), Int32.Parse(txt2.Text.Trim()));
                                txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ya existe ese cliente");
                            }
                            
                            break;
                        case 2:
                            if(txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (oper.existeProveedor(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarProveedor(txt1.Text.Trim());
                                txt1.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ya existe ese proveedor");
                            }
                            break;
                        case 3:
                            if (txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else if (oper.existeTaller(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarTaller(txt1.Text.Trim()/*,txt2.text.Trim()*/);
                                txt1.Text = ""; txt2.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ya existe ese taller");
                            }
                            
                            break;
                        case 4:
                            if (txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (txt3.Text.Trim() == "")
                            {
                                errorP.SetError(txt3, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else if (oper.existeVehiculo(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registroMarca(cmb4.Text.Trim());
                                oper.registroVehiculo(txt1.Text.Trim(), txt3.Text.Trim(), cmb4.Text.Trim());
                                txt1.Text = ""; txt3.Text = "";
                                MessageBox.Show("Se registro correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Ya existe ese vehículo");
                            }
                            break;
                        case 5:
                            if (txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (oper.existePieza(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarPieza(txt1.Text.Trim());
                                txt1.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ya existe esa pieza");
                            }
                            break;
                        case 6:
                            if (txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else if (oper.existeVendedor(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarVendedor(Int32.Parse(txt1.Text.Trim()),txt2.Text.Trim());
                                txt1.Text = ""; txt2.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Ya existe ese vendedor");
                            }
                            break;

                    }

                    break;
                case 1:
                    switch (x)
                    {
                        case 0:
                            if (cmb2.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            if (txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else
                            {
                                errorP.Clear();
                                oper.ActualizarDatosUsuario(cmb3.Text.Trim(), txt2.Text.Trim(), cmb1.Text.Trim(), estado);
                                txt2.Text = "";
                            }
                            break;
                        case 2:
                            if (cmb4.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            oper.ActualizarDatosProveedor(cmb3.Text.Trim(), estado);
                            break;
                        case 3:
                            if (cmb1.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            if(txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else 
                            {
                                errorP.Clear();
                                oper.ActualizarDatosTaller(cmb3.Text.Trim(), estado);
                                txt2.Text = "";
                            }
                            
                            break;
                        case 4:
                            if (cmb2.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            if(txt3.Text.Trim() == "")
                            {
                                errorP.SetError(txt3, "No se puede dejar este campo sin llenar");
                                txt3.Focus();
                            }
                            else
                            {
                                errorP.Clear();
                                oper.ActualizarDatosVehiculo(cmb3.Text.Trim(), cmb4.Text.Trim(), txt3.Text.Trim(), estado);
                                txt3.Text = "";
                            }
                            break;
                        case 5:
                            if (cmb4.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            oper.ActualizarDatosPieza(cmb3.Text.Trim(),estado);
                            break;
                        case 6:
                            if (cmb4.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            oper.ActualizarDatosVendedor(Int32.Parse(cmb3.Text.Trim()),estado);
                            break;
                    }
                    break;
            }
        }

        private void cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x == 6 && y == 1)
            {
                lbl5.Text = oper.NombreVendedor(Int32.Parse(cmb3.Text.Trim()));
            }
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
