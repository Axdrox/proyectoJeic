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
            //rbtnModificar.Visible = false;
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
        private void btnPortal_Click(object sender, EventArgs e)
        {
            x = 7;
            errorP.Clear();
            rbtnModificar.Visible = true;
            rbtnRegistrar.Checked = false; rbtnRegistrar.Checked = true;
            lblTitle.Text = "PORTAL";
        }

        private void rbtnRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnRegistrar.Checked == true)
            {
                switch(x)
                {
                    case 0:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        chk1.Enabled = false; chk1.Visible = false;
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
                        txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Días de espera:";
                        lbl3.Text = "Valuador:";
                        break;
                    case 2:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        chk1.Enabled = false; chk1.Visible = false;
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
                        chk1.Enabled = true; chk1.Visible = true;
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = true; txt3.Visible = true;
                        cmb1.Enabled = false; cmb1.Visible = false;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.MarcasRegistradas(0).Tables[0].DefaultView;
                        cmb3.ValueMember = "marca";
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Marca:";
                        lbl2.Text = "Modelo:";
                        lbl3.Text = "Año:";
                        break;
                    case 5:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        lbl2.Text = "Descripción"+"\n"+"SAE:";
                        lbl3.Text = "";
                        break;
                    case 6:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        lbl1.Text = "Vendedor:"+"\n"+"(Clave)";
                        lbl2.Text = "Nombre:";
                        lbl3.Text = "";
                        break;
                    case 7:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        chk1.Enabled = false; chk1.Visible = false;
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
                        chk1.Enabled = false; chk1.Visible = false;
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
                        txt1.Text = ""; 
                        cmb3.DataSource = oper.AseguradorasRegistradas(0).Tables[0].DefaultView;
                        cmb3.ValueMember = "cve_nombre";
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Días de espera:";
                        lbl3.Text = "Valuador:";
                        txt3.Text = oper.NombreValuador(cmb3.Text.Trim());
                        txt2.Text = oper.Dias_Espera(cmb3.Text.Trim());
                        break;
                    case 2:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        cmb3.DataSource = oper.ProveedoresRegistrados(0).Tables[0].DefaultView;
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
                        chk1.Enabled = false; chk1.Visible = false;
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
                        cmb3.DataSource = oper.TalleresRegistrados(0).Tables[0].DefaultView;
                        cmb3.ValueMember = "nombre";
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; txt2.Text = "";
                        txt2.Text = oper.direccionTaller(cmb3.Text.Trim());
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Dirección:";
                        lbl3.Text = "Estado:";
                        break;
                    case 4:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        cmb3.DataSource = oper.MarcasRegistradas(0).Tables[0].DefaultView; 
                        cmb3.ValueMember = "marca";
                        cmb4.Enabled = true; cmb4.Visible = true;
                        /*cmb4.DataSource = null; cmb4.Items.Clear();*/
                        cmb4.DataSource = oper.VehiculosRegistrados(cmb3.Text.Trim()).Tables["VEHICULO"].DefaultView;
                        cmb4.ValueMember = "modelo";
                        txt1.Text = ""; txt2.Text = "";
                        txt3.Text = oper.anioVehiculo(cmb4.Text.Trim());
                        lbl1.Text = "Marca:";
                        lbl2.Text = "Modelo:";
                        lbl3.Text = "Año:";
                        lbl4.Text = "Estado:";
                        break;
                    case 5:
                        chk1.Enabled = false; chk1.Visible = false;
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        txt1.Enabled = false; txt1.Visible = false;
                        txt2.Enabled = true; txt2.Visible = true;
                        txt3.Enabled = false; txt3.Visible = false;
                        cmb1.Enabled = true; cmb1.Visible = true;
                        cmb1.DataSource = null; cmb1.Items.Clear(); cmb1.Items.Add("ACTIVO"); cmb1.Items.Add("SUSPENDIDO"); cmb1.SelectedIndex = 0;
                        cmb2.Enabled = false; cmb2.Visible = false;
                        cmb3.Enabled = true; cmb3.Visible = true;
                        cmb3.DataSource = oper.NombrePiezasRegistrados(0).Tables[0].DefaultView;
                        cmb3.ValueMember = "nombre";
                        cmb4.Enabled = false; cmb4.Visible = false;
                        txt1.Text = ""; 
                        txt2.Text = oper.descSAE(cmb3.Text.Trim());
                        lbl1.Text = "Nombre:";
                        lbl2.Text = "Descripción SAE:";
                        lbl3.Text = "Estado:";
                        break;
                    case 6:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        cmb3.DataSource = oper.VendedoresRegistradosClaves(0).Tables[0].DefaultView;
                        cmb3.ValueMember = "cve_vendedor";
                        cmb4.Enabled = true; cmb4.Visible = true;
                        cmb4.DataSource = null; cmb4.Items.Clear(); cmb4.Items.Add("ACTIVO"); cmb4.Items.Add("SUSPENDIDO"); cmb4.SelectedIndex = 0;
                        txt1.Text = ""; txt2.Text = "";
                        lbl1.Text = "Vendedor:" + "\n" + "(Clave)";
                        lbl2.Text = "Estado:";
                        lbl3.Text = "";
                        lbl5.Text = oper.NombreVendedor(Int32.Parse(cmb3.Text.Trim()));
                        break;
                    case 7:
                        chk1.Enabled = false; chk1.Visible = false;
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
                        cmb3.DataSource = oper.PortalesRegistrados(0).Tables[0].DefaultView;
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
                            if (txt1.Text.Trim() == "" || txt1.Text.Trim() == "System.Data.DataRowView")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();  
                            }
                            else if (txt2.Text.Trim() == "" || txt2.Text.Trim() == "System.Data.DataRowView")
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
                            if(txt1.Text.Trim() == "" )
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
                                oper.registrarValuador(txt3.Text.Trim().ToUpper());
                                oper.registrarCliente(txt1.Text.Trim().ToUpper(), txt3.Text.Trim().ToUpper(), Int32.Parse(txt2.Text.Trim()));
                                txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe ese cliente");
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
                                oper.registrarProveedor(txt1.Text.Trim().ToUpper());
                                txt1.Text = "";
                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe ese proveedor");
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
                                oper.registrarTaller(txt1.Text.Trim().ToUpper(),txt2.Text.Trim().ToUpper());
                                
                                txt1.Text = ""; txt2.Text = "";
                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe ese taller");
                            }
                            
                            break;
                        case 4:
                            if (txt1.Text.Trim() == "" && cmb3.Enabled == false)
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (txt3.Text.Trim() == "")
                            {
                                errorP.SetError(txt3, "No se puede dejar este campo sin llenar");
                                txt2.Focus();
                            }
                            else if (chk1.Checked == true)
                            {
                                if (string.IsNullOrEmpty(oper.existeAnioVehiculo(txt2.Text.Trim(),txt3.Text.Trim())))
                                {
                                    errorP.Clear();
                                    oper.registroMarca(txt1.Text.Trim().ToUpper());
                                    oper.registroVehiculo(txt2.Text.Trim().ToUpper(), txt3.Text.Trim(), txt1.Text.Trim().ToUpper());
                                    txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                                    
                                }
                                else
                                {
                                    txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                                    MessageBOX.SHowDialog(2, "Ya existe ese vehiculo");
                                }
                            }
                            else if (chk1.Checked == false)
                            {
                                if (string.IsNullOrEmpty(oper.existeAnioVehiculo(txt2.Text.Trim(), txt3.Text.Trim())))
                                {
                                    errorP.Clear();
                                    oper.registroVehiculo(txt2.Text.Trim().ToUpper(), txt3.Text.Trim(), cmb3.Text.Trim().ToUpper());
                                    txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                                    
                                }
                                else
                                {
                                    txt1.Text = ""; txt2.Text = ""; txt3.Text = "";
                                    MessageBOX.SHowDialog(2, "Ya existe ese vehículo");
                                }

                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe ese vehículo");
                            }
                            break;
                        case 5:
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
                            else if (oper.existePieza(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarPieza(txt1.Text.Trim().ToUpper(),txt2.Text.Trim().ToUpper());
                                txt1.Text = ""; txt2.Text = "";
                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe esa pieza");
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
                                oper.registrarVendedor(Int32.Parse(txt1.Text.Trim()),txt2.Text.Trim().ToUpper());
                                txt1.Text = ""; txt2.Text = "";
                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe ese vendedor");
                            }
                            break;
                        case 7:
                            if (txt1.Text.Trim() == "")
                            {
                                errorP.SetError(txt1, "No se puede dejar este campo sin llenar");
                                txt1.Focus();
                            }
                            else if (oper.existePortal(txt1.Text.Trim()) == "")
                            {
                                errorP.Clear();
                                oper.registrarPortal(txt1.Text.Trim().ToUpper());
                                txt1.Text = "";
                            }
                            else
                            {
                                MessageBOX.SHowDialog(2, "Ya existe ese portal");
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
                        case 1:
                            if (cmb2.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else 
                                estado = 0;

                            if(txt2.Text.Trim() == "")
                            {
                                errorP.SetError(txt2,"No se puede dejar este campo sin llenar");
                            }
                            else if (txt3.Text.Trim() == "")
                            {
                                errorP.SetError(txt3, "No se puede dejar este campo sin llenar");
                            }
                            else
                            {
                                errorP.Clear();
                                oper.ActualizarDatosCliente(cmb3.Text.Trim(),txt3.Text.Trim().ToUpper(),estado,Int32.Parse(txt2.Text.Trim()));
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
                                oper.ActualizarDatosTaller(cmb3.Text.Trim(), estado,txt2.Text.Trim().ToUpper());
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
                            else if (cmb4.Text.Trim() == "" || cmb4.Text.Trim() == "System.Data.DataRowView")
                            {
                                errorP.SetError(cmb4, "Selecciona una opción valida");
                                cmb4.Focus();
                            }
                            else
                            {
                                errorP.Clear();
                                oper.ActualizarDatosVehiculo(cmb4.Text.Trim(), cmb3.Text.Trim(), txt3.Text.Trim(), estado);
                                txt3.Text = "";
                            }
                            break;
                        case 5:
                            if (cmb1.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;

                            oper.ActualizarDatosPieza(cmb3.Text.Trim(),estado,txt2.Text.Trim().ToUpper());
                            break;
                        case 6:
                            if (cmb4.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            oper.ActualizarDatosVendedor(Int32.Parse(cmb3.Text.Trim()),estado);
                            
                            break;
                        case 7:
                            if (cmb4.Text.Trim() == "ACTIVO")
                                estado = 1;
                            else
                                estado = 0;
                            oper.ActualizarDatosPortal(cmb3.Text.Trim(), estado);
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
            else if(x == 4 && y == 1)
            {
                cmb4.DataSource = oper.VehiculosRegistrados(cmb3.Text.Trim()).Tables[0].DefaultView;
                cmb4.ValueMember = "modelo";
            }
            else if (x == 3 && y == 1)
            {
                txt2.Text = oper.direccionTaller(cmb3.Text.Trim());
            }
            else if (x == 1 && y == 1)
            {
                txt3.Text = oper.NombreValuador(cmb3.Text.Trim());
                txt2.Text = oper.Dias_Espera(cmb3.Text.Trim());
            }
            else if (x == 5 && y == 1)
            {
                txt2.Text = oper.descSAE(cmb3.Text.Trim());
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

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if(chk1.Checked == true)
            {
                cmb3.Enabled = false; cmb3.Visible = false;
                txt1.Enabled = true; txt1.Visible = true;
            }
            else if(chk1.Checked == false)
            {
                cmb3.Enabled = true; cmb3.Visible = true;
                txt1.Enabled = false; txt1.Visible = false;
            }
        }

        private void cmb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (x == 4 && y == 1)
            {
                txt3.Text = oper.anioVehiculo(cmb4.Text.Trim());
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(x == 1 && y == 1 || x == 1 && y ==0)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if(x==1 && y==0 || x==1 && y == 1 || x==2 || x==3)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }*/
            if (x == 6)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (x == 1 && y == 0 || x == 1 && y == 1)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }*/
            if (x == 4)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void cmb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb3.DroppedDown = false;
        }

        private void cmb4_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb4.DroppedDown = false;
        }

        private void cmb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb2.DroppedDown = false;
        }

        private void cmb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmb1.DroppedDown = false;
        }

        private void cmb3_Validating(object sender, CancelEventArgs e)
        {
            OperBD operacion = new OperBD();
            if (x == 5 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar una pieza");
                }
                else if (string.IsNullOrEmpty(operacion.existePieza(cmb3.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar una pieza existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 2 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un proveedor");
                }
                else if (string.IsNullOrEmpty(operacion.existeProveedor(cmb3.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un proveedor existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 7 && y == 1)
            {
                
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un portal");
                }
                else if (string.IsNullOrEmpty(operacion.existePortal(cmb3.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un portal existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 6 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un vendedor");
                }
                else if (string.IsNullOrEmpty(operacion.existeVendedor(lbl5.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un vendedor existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 1 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un cliente");
                }
                else if (string.IsNullOrEmpty(operacion.existeCliente(cmb3.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un cliente existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 3 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un taller");
                }
                else if (string.IsNullOrEmpty(operacion.existeTaller(cmb3.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un taller existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 0 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un usuario");
                }
                else if (string.IsNullOrEmpty(operacion.existeUsuario(cmb3.Text.Trim())))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb3, "Favor de seleccionar un usuario existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb3, null);
                }
            }
            else if (x == 4 && y == 0)
            {
                if(chk1.Checked == false)
                {
                    if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorP.SetError(cmb3, "Favor de seleccionar una marca");
                    }
                    else if (string.IsNullOrEmpty(operacion.existeMarca(cmb3.Text.Trim())))
                    {
                        e.Cancel = true;
                        errorP.SetError(cmb3, "Favor de seleccionar una marca existente");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorP.SetError(cmb3, null);
                    }
                }
            }
            else if (x == 4 && y == 1)
            {
                if (chk1.Checked == false)
                {
                    if (string.IsNullOrEmpty(cmb3.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorP.SetError(cmb3, "Favor de seleccionar una marca");
                    }
                    else if (string.IsNullOrEmpty(operacion.existeMarca(cmb3.Text.Trim())))
                    {
                        e.Cancel = true;
                        errorP.SetError(cmb3, "Favor de seleccionar una marca existente");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorP.SetError(cmb3, null);
                    }
                }
            }
        }

        private void cmb1_Validating(object sender, CancelEventArgs e)
        {
            OperBD operacion = new OperBD();
            if (x == 5 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb1.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un estado");
                }
                else if (cmb1.Text.Trim() != "ACTIVO" && cmb1.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb1, null);
                }
            }
            else if ( x == 3 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb1.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un estado");
                }
                else if (cmb1.Text.Trim() != "ACTIVO" && cmb1.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb1, null);
                }
            }
            else if (x == 0 && y == 0)
            {
                if (string.IsNullOrEmpty(cmb1.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un área");
                }
                else if (cmb1.Text.Trim() != "ADMINISTRADOR" && cmb1.Text.Trim() != "FINANZAS" && cmb1.Text.Trim() != "LOGÍSTICA" && cmb1.Text.Trim() != "VENTAS" && cmb1.Text.Trim() != "CONSULTA")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un área existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb1, null);
                }
            }
            else if (x == 0 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb1.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un área");
                }
                else if (cmb1.Text.Trim() != "ADMINISTRADOR" && cmb1.Text.Trim() != "FINANZAS" && cmb1.Text.Trim() != "LOGÍSTICA" && cmb1.Text.Trim() != "VENTAS" && cmb1.Text.Trim() != "CONSULTA")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb1, "Favor de seleccionar un área existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb1, null);
                }
            }
        }

        private void cmb4_Validating(object sender, CancelEventArgs e)
        {
            OperBD operacion = new OperBD();
            if (x == 7 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb4.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb4, "Favor de seleccionar un estado");
                }
                else if (cmb4.Text.Trim() != "ACTIVO" && cmb4.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb4, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb4, null);
                }

            }
            else if (x == 2 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb4.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb4, "Favor de seleccionar un estado");
                }
                else if (cmb4.Text.Trim() != "ACTIVO" && cmb4.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb4, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb4, null);
                }
            }
            else if (x == 6 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb4.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb4, "Favor de seleccionar un estado");
                }
                else if (cmb4.Text.Trim() != "ACTIVO" && cmb4.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb4, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb4, null);
                }
            }
            else if (x == 4 && y == 1)
            {
                        if (string.IsNullOrEmpty(cmb4.Text.Trim()))
                        {
                            e.Cancel = true;
                            errorP.SetError(cmb4, "Favor de seleccionar un modelo");
                        }
                        else if (string.IsNullOrEmpty(operacion.existeVehiculo(cmb4.Text.Trim())))
                        {
                            e.Cancel = true;
                            errorP.SetError(cmb4, "Favor de seleccionar un modelo existente");
                        }
                        else
                        {
                            e.Cancel = false;
                            errorP.SetError(cmb4, null);
                        }
            }
        }

        private void cmb2_Validating(object sender, CancelEventArgs e)
        {
            
            if (x == 1 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb2.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb2, "Favor de seleccionar un estado");
                }
                else if (cmb2.Text.Trim() != "ACTIVO" && cmb2.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb2, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb2, null);
                }
            }
            else if (x == 0 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb2.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb2, "Favor de seleccionar un estado");
                }
                else if (cmb2.Text.Trim() != "ACTIVO" && cmb2.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb2, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb2, null);
                }
            }
            else if ( x == 4 && y == 1)
            {
                if (string.IsNullOrEmpty(cmb2.Text.Trim()))
                {
                    e.Cancel = true;
                    errorP.SetError(cmb2, "Favor de seleccionar un estado");
                }
                else if (cmb2.Text.Trim() != "ACTIVO" && cmb2.Text.Trim() != "SUSPENDIDO")
                {
                    e.Cancel = true;
                    errorP.SetError(cmb2, "Favor de seleccionar un estado existente");
                }
                else
                {
                    e.Cancel = false;
                    errorP.SetError(cmb2, null);
                }
            }
        }

        private void Administrar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
