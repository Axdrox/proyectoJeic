namespace Refracciones.Forms
{
    partial class Pieza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pieza));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPiezaNombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPortal = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.dtpFechaCosto = new System.Windows.Forms.DateTimePicker();
            this.txtCostoSinIVA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCostoNeto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrecioReparacion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.txtNumeroGuia = new System.Windows.Forms.TextBox();
            this.btnAniadirPieza = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbOtroPieza = new System.Windows.Forms.CheckBox();
            this.chbOtroPortal = new System.Windows.Forms.CheckBox();
            this.chbOtroOrigen = new System.Windows.Forms.CheckBox();
            this.chbOtroProveedor = new System.Windows.Forms.CheckBox();
            this.txtPiezaNombre = new System.Windows.Forms.TextBox();
            this.txtPortal = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.cbCostoEnvio = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cbNumeroGuia = new System.Windows.Forms.ComboBox();
            this.chbOtroNumeroGuia = new System.Windows.Forms.CheckBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una pieza:";
            // 
            // cbPiezaNombre
            // 
            this.cbPiezaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbPiezaNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiezaNombre.ForeColor = System.Drawing.Color.White;
            this.cbPiezaNombre.FormattingEnabled = true;
            this.cbPiezaNombre.Location = new System.Drawing.Point(146, 5);
            this.cbPiezaNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPiezaNombre.Name = "cbPiezaNombre";
            this.cbPiezaNombre.Size = new System.Drawing.Size(196, 24);
            this.cbPiezaNombre.TabIndex = 1;
            this.cbPiezaNombre.Click += new System.EventHandler(this.cbPiezaNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(92)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Costo sin IVA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(96)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Costo neto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Costo de envío:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha costo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(114)))));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(37, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Precio de reparación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(42)))));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Clave de producto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Número de guía:";
            // 
            // cbPortal
            // 
            this.cbPortal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbPortal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortal.ForeColor = System.Drawing.Color.White;
            this.cbPortal.FormattingEnabled = true;
            this.cbPortal.Location = new System.Drawing.Point(145, 126);
            this.cbPortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPortal.Name = "cbPortal";
            this.cbPortal.Size = new System.Drawing.Size(196, 24);
            this.cbPortal.TabIndex = 16;
            this.cbPortal.Click += new System.EventHandler(this.cbPortal_Click);
            // 
            // cbOrigen
            // 
            this.cbOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.ForeColor = System.Drawing.Color.White;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(145, 166);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(196, 24);
            this.cbOrigen.TabIndex = 17;
            this.cbOrigen.Click += new System.EventHandler(this.cbOrigen_Click);
            // 
            // cbProveedores
            // 
            this.cbProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.ForeColor = System.Drawing.Color.White;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(145, 205);
            this.cbProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(196, 24);
            this.cbProveedores.TabIndex = 18;
            this.cbProveedores.Click += new System.EventHandler(this.cbProveedores_Click);
            // 
            // dtpFechaCosto
            // 
            this.dtpFechaCosto.Location = new System.Drawing.Point(147, 250);
            this.dtpFechaCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaCosto.Name = "dtpFechaCosto";
            this.dtpFechaCosto.Size = new System.Drawing.Size(260, 22);
            this.dtpFechaCosto.TabIndex = 19;
            // 
            // txtCostoSinIVA
            // 
            this.txtCostoSinIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCostoSinIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostoSinIVA.ForeColor = System.Drawing.Color.White;
            this.txtCostoSinIVA.Location = new System.Drawing.Point(201, 281);
            this.txtCostoSinIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoSinIVA.Name = "txtCostoSinIVA";
            this.txtCostoSinIVA.Size = new System.Drawing.Size(122, 22);
            this.txtCostoSinIVA.TabIndex = 20;
            this.txtCostoSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoSinIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoSinIVA_KeyPress);
            this.txtCostoSinIVA.Leave += new System.EventHandler(this.txtCostoSinIVA_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label16.Location = new System.Drawing.Point(207, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "$";
            // 
            // txtCostoNeto
            // 
            this.txtCostoNeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCostoNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostoNeto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCostoNeto.ForeColor = System.Drawing.Color.White;
            this.txtCostoNeto.Location = new System.Drawing.Point(201, 306);
            this.txtCostoNeto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoNeto.Name = "txtCostoNeto";
            this.txtCostoNeto.ReadOnly = true;
            this.txtCostoNeto.Size = new System.Drawing.Size(122, 22);
            this.txtCostoNeto.TabIndex = 22;
            this.txtCostoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoNeto_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label17.Location = new System.Drawing.Point(207, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "$";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.txtPrecioVenta.Location = new System.Drawing.Point(201, 382);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(122, 22);
            this.txtPrecioVenta.TabIndex = 26;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label19.Location = new System.Drawing.Point(207, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "$";
            // 
            // txtPrecioReparacion
            // 
            this.txtPrecioReparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPrecioReparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioReparacion.ForeColor = System.Drawing.Color.White;
            this.txtPrecioReparacion.Location = new System.Drawing.Point(201, 402);
            this.txtPrecioReparacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioReparacion.Name = "txtPrecioReparacion";
            this.txtPrecioReparacion.Size = new System.Drawing.Size(122, 22);
            this.txtPrecioReparacion.TabIndex = 28;
            this.txtPrecioReparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioReparacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioReparacion_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label20.Location = new System.Drawing.Point(207, 406);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 17);
            this.label20.TabIndex = 29;
            this.label20.Text = "$";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(145, 34);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 22);
            this.txtCantidad.TabIndex = 30;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtClaveProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveProducto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtClaveProducto.Location = new System.Drawing.Point(145, 62);
            this.txtClaveProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(195, 22);
            this.txtClaveProducto.TabIndex = 31;
            this.txtClaveProducto.Text = "Escriba clave del producto";
            this.txtClaveProducto.Click += new System.EventHandler(this.txtClaveProducto_Click);
            this.txtClaveProducto.Leave += new System.EventHandler(this.txtClaveProducto_Leave);
            // 
            // txtNumeroGuia
            // 
            this.txtNumeroGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtNumeroGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroGuia.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNumeroGuia.Location = new System.Drawing.Point(145, 92);
            this.txtNumeroGuia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroGuia.Name = "txtNumeroGuia";
            this.txtNumeroGuia.Size = new System.Drawing.Size(196, 22);
            this.txtNumeroGuia.TabIndex = 32;
            this.txtNumeroGuia.Text = "Escriba el número de guía";
            this.txtNumeroGuia.Click += new System.EventHandler(this.txtNumeroGuia_Click);
            this.txtNumeroGuia.Leave += new System.EventHandler(this.txtNumeroGuia_Leave);
            // 
            // btnAniadirPieza
            // 
            this.btnAniadirPieza.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAniadirPieza.Location = new System.Drawing.Point(315, 448);
            this.btnAniadirPieza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAniadirPieza.Name = "btnAniadirPieza";
            this.btnAniadirPieza.Size = new System.Drawing.Size(99, 28);
            this.btnAniadirPieza.TabIndex = 36;
            this.btnAniadirPieza.Text = "Añadir pieza";
            this.btnAniadirPieza.UseVisualStyleBackColor = false;
            this.btnAniadirPieza.Click += new System.EventHandler(this.btnAniadirPieza_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.Location = new System.Drawing.Point(221, 448);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 28);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbOtroPieza
            // 
            this.chbOtroPieza.AutoSize = true;
            this.chbOtroPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.chbOtroPieza.ForeColor = System.Drawing.Color.White;
            this.chbOtroPieza.Location = new System.Drawing.Point(347, 7);
            this.chbOtroPieza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroPieza.Name = "chbOtroPieza";
            this.chbOtroPieza.Size = new System.Drawing.Size(58, 21);
            this.chbOtroPieza.TabIndex = 38;
            this.chbOtroPieza.Text = "Otro";
            this.chbOtroPieza.UseVisualStyleBackColor = false;
            this.chbOtroPieza.CheckedChanged += new System.EventHandler(this.chbOtroPieza_CheckedChanged);
            // 
            // chbOtroPortal
            // 
            this.chbOtroPortal.AutoSize = true;
            this.chbOtroPortal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.chbOtroPortal.ForeColor = System.Drawing.Color.White;
            this.chbOtroPortal.Location = new System.Drawing.Point(347, 128);
            this.chbOtroPortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroPortal.Name = "chbOtroPortal";
            this.chbOtroPortal.Size = new System.Drawing.Size(58, 21);
            this.chbOtroPortal.TabIndex = 39;
            this.chbOtroPortal.Text = "Otro";
            this.chbOtroPortal.UseVisualStyleBackColor = false;
            this.chbOtroPortal.CheckedChanged += new System.EventHandler(this.chbOtroPortal_CheckedChanged);
            // 
            // chbOtroOrigen
            // 
            this.chbOtroOrigen.AutoSize = true;
            this.chbOtroOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.chbOtroOrigen.ForeColor = System.Drawing.Color.White;
            this.chbOtroOrigen.Location = new System.Drawing.Point(347, 167);
            this.chbOtroOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroOrigen.Name = "chbOtroOrigen";
            this.chbOtroOrigen.Size = new System.Drawing.Size(58, 21);
            this.chbOtroOrigen.TabIndex = 40;
            this.chbOtroOrigen.Text = "Otro";
            this.chbOtroOrigen.UseVisualStyleBackColor = false;
            this.chbOtroOrigen.CheckedChanged += new System.EventHandler(this.chbOtroOrigen_CheckedChanged);
            // 
            // chbOtroProveedor
            // 
            this.chbOtroProveedor.AutoSize = true;
            this.chbOtroProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(74)))));
            this.chbOtroProveedor.ForeColor = System.Drawing.Color.White;
            this.chbOtroProveedor.Location = new System.Drawing.Point(347, 208);
            this.chbOtroProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroProveedor.Name = "chbOtroProveedor";
            this.chbOtroProveedor.Size = new System.Drawing.Size(58, 21);
            this.chbOtroProveedor.TabIndex = 41;
            this.chbOtroProveedor.Text = "Otro";
            this.chbOtroProveedor.UseVisualStyleBackColor = false;
            this.chbOtroProveedor.CheckedChanged += new System.EventHandler(this.chbOtroProveedor_CheckedChanged);
            // 
            // txtPiezaNombre
            // 
            this.txtPiezaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPiezaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPiezaNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPiezaNombre.Location = new System.Drawing.Point(145, 7);
            this.txtPiezaNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPiezaNombre.Name = "txtPiezaNombre";
            this.txtPiezaNombre.Size = new System.Drawing.Size(197, 22);
            this.txtPiezaNombre.TabIndex = 42;
            this.txtPiezaNombre.Text = "Escriba nombre de pieza";
            this.txtPiezaNombre.Visible = false;
            this.txtPiezaNombre.Click += new System.EventHandler(this.txtPiezaNombre_Click);
            this.txtPiezaNombre.Leave += new System.EventHandler(this.txtPiezaNombre_Leave);
            // 
            // txtPortal
            // 
            this.txtPortal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPortal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPortal.Location = new System.Drawing.Point(145, 128);
            this.txtPortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(197, 22);
            this.txtPortal.TabIndex = 43;
            this.txtPortal.Text = "Escriba un nuevo portal";
            this.txtPortal.Visible = false;
            this.txtPortal.Click += new System.EventHandler(this.txtPortal_Click);
            this.txtPortal.Leave += new System.EventHandler(this.txtPortal_Leave);
            // 
            // txtOrigen
            // 
            this.txtOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtOrigen.Location = new System.Drawing.Point(145, 167);
            this.txtOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(197, 22);
            this.txtOrigen.TabIndex = 44;
            this.txtOrigen.Text = "Escriba un nuevo origen";
            this.txtOrigen.Visible = false;
            this.txtOrigen.Click += new System.EventHandler(this.txtOrigen_Click);
            this.txtOrigen.Leave += new System.EventHandler(this.txtOrigen_Leave);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtProveedor.Location = new System.Drawing.Point(145, 206);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(197, 22);
            this.txtProveedor.TabIndex = 45;
            this.txtProveedor.Text = "Escriba un nuevo proveedor";
            this.txtProveedor.Visible = false;
            this.txtProveedor.Click += new System.EventHandler(this.txtProveedor_Click);
            this.txtProveedor.Leave += new System.EventHandler(this.txtProveedor_Leave);
            // 
            // cbCostoEnvio
            // 
            this.cbCostoEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbCostoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostoEnvio.ForeColor = System.Drawing.Color.White;
            this.cbCostoEnvio.FormattingEnabled = true;
            this.cbCostoEnvio.Location = new System.Drawing.Point(201, 329);
            this.cbCostoEnvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCostoEnvio.Name = "cbCostoEnvio";
            this.cbCostoEnvio.Size = new System.Drawing.Size(121, 24);
            this.cbCostoEnvio.TabIndex = 46;
            this.cbCostoEnvio.Click += new System.EventHandler(this.cbCostoEnvio_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtNumeroGuia);
            this.bunifuGradientPanel1.Controls.Add(this.chbOtroNumeroGuia);
            this.bunifuGradientPanel1.Controls.Add(this.cbNumeroGuia);
            this.bunifuGradientPanel1.Controls.Add(this.txtPiezaNombre);
            this.bunifuGradientPanel1.Controls.Add(this.txtProveedor);
            this.bunifuGradientPanel1.Controls.Add(this.cbPiezaNombre);
            this.bunifuGradientPanel1.Controls.Add(this.txtOrigen);
            this.bunifuGradientPanel1.Controls.Add(this.txtPortal);
            this.bunifuGradientPanel1.Controls.Add(this.cbPortal);
            this.bunifuGradientPanel1.Controls.Add(this.cbOrigen);
            this.bunifuGradientPanel1.Controls.Add(this.cbProveedores);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(425, 487);
            this.bunifuGradientPanel1.TabIndex = 47;
            // 
            // cbNumeroGuia
            // 
            this.cbNumeroGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbNumeroGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroGuia.ForeColor = System.Drawing.Color.White;
            this.cbNumeroGuia.Location = new System.Drawing.Point(144, 91);
            this.cbNumeroGuia.Name = "cbNumeroGuia";
            this.cbNumeroGuia.Size = new System.Drawing.Size(197, 24);
            this.cbNumeroGuia.TabIndex = 0;
            // 
            // chbOtroNumeroGuia
            // 
            this.chbOtroNumeroGuia.AutoSize = true;
            this.chbOtroNumeroGuia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.chbOtroNumeroGuia.ForeColor = System.Drawing.Color.White;
            this.chbOtroNumeroGuia.Location = new System.Drawing.Point(348, 91);
            this.chbOtroNumeroGuia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroNumeroGuia.Name = "chbOtroNumeroGuia";
            this.chbOtroNumeroGuia.Size = new System.Drawing.Size(58, 21);
            this.chbOtroNumeroGuia.TabIndex = 48;
            this.chbOtroNumeroGuia.Text = "Otro";
            this.chbOtroNumeroGuia.UseVisualStyleBackColor = false;
            this.chbOtroNumeroGuia.CheckedChanged += new System.EventHandler(this.chbOtroNumeroGuia_CheckedChanged);
            // 
            // Pieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 487);
            this.ControlBox = false;
            this.Controls.Add(this.cbCostoEnvio);
            this.Controls.Add(this.chbOtroProveedor);
            this.Controls.Add(this.chbOtroOrigen);
            this.Controls.Add(this.chbOtroPortal);
            this.Controls.Add(this.chbOtroPieza);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAniadirPieza);
            this.Controls.Add(this.txtClaveProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPrecioReparacion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCostoNeto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCostoSinIVA);
            this.Controls.Add(this.dtpFechaCosto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pieza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pieza_FormClosing);
            this.Load += new System.EventHandler(this.Pieza_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPiezaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPortal;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.DateTimePicker dtpFechaCosto;
        private System.Windows.Forms.TextBox txtCostoSinIVA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCostoNeto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecioReparacion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.TextBox txtNumeroGuia;
        private System.Windows.Forms.Button btnAniadirPieza;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbOtroPieza;
        private System.Windows.Forms.CheckBox chbOtroPortal;
        private System.Windows.Forms.CheckBox chbOtroOrigen;
        private System.Windows.Forms.CheckBox chbOtroProveedor;
        private System.Windows.Forms.TextBox txtPiezaNombre;
        private System.Windows.Forms.TextBox txtPortal;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.ComboBox cbCostoEnvio;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.CheckBox chbOtroNumeroGuia;
        private System.Windows.Forms.ComboBox cbNumeroGuia;
    }
}