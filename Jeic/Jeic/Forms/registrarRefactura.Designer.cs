﻿namespace Refracciones.Forms
{
    partial class registrarRefactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarRefactura));
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnBuscarXml = new System.Windows.Forms.Button();
            this.txtRutaXml = new System.Windows.Forms.TextBox();
            this.lblXml = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblFechaRevision = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFacturaConIVA = new System.Windows.Forms.Label();
            this.txtFacturasinIVA = new System.Windows.Forms.TextBox();
            this.txtRefactura = new System.Windows.Forms.TextBox();
            this.lblClave_FacturaAnterior = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarFact = new System.Windows.Forms.Button();
            this.txtRutaFactura = new System.Windows.Forms.TextBox();
            this.txtCve_Factura = new System.Windows.Forms.TextBox();
            this.lblFacturaSinIVA = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblRefactura = new System.Windows.Forms.Label();
            this.txtFacturaconIVA = new System.Windows.Forms.TextBox();
            this.lblCostoRefactura = new System.Windows.Forms.Label();
            this.txtCostoRefactura = new System.Windows.Forms.TextBox();
            this.lblFechaRefacturacion = new System.Windows.Forms.Label();
            this.dtpFechaRefacturacion = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dato1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADA",
            "CANCELADA"});
            this.cmbEstadoFactura.Location = new System.Drawing.Point(124, 318);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFactura.TabIndex = 52;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.White;
            this.lblEstadoFactura.Location = new System.Drawing.Point(14, 321);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(105, 13);
            this.lblEstadoFactura.TabIndex = 51;
            this.lblEstadoFactura.Text = "Estado de la Factura";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(88)))));
            this.lblComentarios.ForeColor = System.Drawing.Color.White;
            this.lblComentarios.Location = new System.Drawing.Point(318, 209);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(65, 13);
            this.lblComentarios.TabIndex = 50;
            this.lblComentarios.Text = "Comentarios";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtComentario.Location = new System.Drawing.Point(321, 234);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(227, 105);
            this.txtComentario.TabIndex = 49;
            // 
            // btnBuscarXml
            // 
            this.btnBuscarXml.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarXml.ForeColor = System.Drawing.Color.White;
            this.btnBuscarXml.Location = new System.Drawing.Point(251, 289);
            this.btnBuscarXml.Name = "btnBuscarXml";
            this.btnBuscarXml.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarXml.TabIndex = 45;
            this.btnBuscarXml.Text = "...";
            this.btnBuscarXml.UseVisualStyleBackColor = false;
            this.btnBuscarXml.Click += new System.EventHandler(this.btnBuscarXml_Click);
            // 
            // txtRutaXml
            // 
            this.txtRutaXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtRutaXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaXml.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtRutaXml.Location = new System.Drawing.Point(17, 289);
            this.txtRutaXml.Name = "txtRutaXml";
            this.txtRutaXml.ReadOnly = true;
            this.txtRutaXml.Size = new System.Drawing.Size(228, 20);
            this.txtRutaXml.TabIndex = 44;
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(64)))), ((int)(((byte)(108)))));
            this.lblXml.ForeColor = System.Drawing.Color.White;
            this.lblXml.Location = new System.Drawing.Point(14, 273);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(24, 13);
            this.lblXml.TabIndex = 43;
            this.lblXml.Text = "Xml";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.lblFechaPago.ForeColor = System.Drawing.Color.White;
            this.lblFechaPago.Location = new System.Drawing.Point(222, 166);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 42;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblFechaRevision
            // 
            this.lblFechaRevision.AutoSize = true;
            this.lblFechaRevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.lblFechaRevision.ForeColor = System.Drawing.Color.White;
            this.lblFechaRevision.Location = new System.Drawing.Point(222, 129);
            this.lblFechaRevision.Name = "lblFechaRevision";
            this.lblFechaRevision.Size = new System.Drawing.Size(96, 13);
            this.lblFechaRevision.TabIndex = 41;
            this.lblFechaRevision.Text = "Fecha de Revisión";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Enabled = false;
            this.dtpFechaPago.Location = new System.Drawing.Point(350, 163);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 40;
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(350, 126);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRevision.TabIndex = 39;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Location = new System.Drawing.Point(222, 91);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 38;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(350, 88);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 37;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // lblFacturaConIVA
            // 
            this.lblFacturaConIVA.AutoSize = true;
            this.lblFacturaConIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.lblFacturaConIVA.ForeColor = System.Drawing.Color.White;
            this.lblFacturaConIVA.Location = new System.Drawing.Point(14, 166);
            this.lblFacturaConIVA.Name = "lblFacturaConIVA";
            this.lblFacturaConIVA.Size = new System.Drawing.Size(84, 13);
            this.lblFacturaConIVA.TabIndex = 36;
            this.lblFacturaConIVA.Text = "Factura con IVA";
            // 
            // txtFacturasinIVA
            // 
            this.txtFacturasinIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacturasinIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacturasinIVA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtFacturasinIVA.Location = new System.Drawing.Point(109, 126);
            this.txtFacturasinIVA.Name = "txtFacturasinIVA";
            this.txtFacturasinIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFacturasinIVA.Size = new System.Drawing.Size(100, 20);
            this.txtFacturasinIVA.TabIndex = 35;
            this.txtFacturasinIVA.TextChanged += new System.EventHandler(this.txtFacturasinIVA_TextChanged);
            this.txtFacturasinIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturasinIVA_KeyPress);
            this.txtFacturasinIVA.Leave += new System.EventHandler(this.txtFacturasinIVA_Leave);
            this.txtFacturasinIVA.Validated += new System.EventHandler(this.txtFacturasinIVA_Validated);
            // 
            // txtRefactura
            // 
            this.txtRefactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtRefactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefactura.Enabled = false;
            this.txtRefactura.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtRefactura.Location = new System.Drawing.Point(109, 88);
            this.txtRefactura.Name = "txtRefactura";
            this.txtRefactura.Size = new System.Drawing.Size(100, 20);
            this.txtRefactura.TabIndex = 34;
            this.txtRefactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefactura_KeyPress);
            // 
            // lblClave_FacturaAnterior
            // 
            this.lblClave_FacturaAnterior.AutoSize = true;
            this.lblClave_FacturaAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.lblClave_FacturaAnterior.ForeColor = System.Drawing.Color.White;
            this.lblClave_FacturaAnterior.Location = new System.Drawing.Point(14, 55);
            this.lblClave_FacturaAnterior.Name = "lblClave_FacturaAnterior";
            this.lblClave_FacturaAnterior.Size = new System.Drawing.Size(65, 13);
            this.lblClave_FacturaAnterior.TabIndex = 33;
            this.lblClave_FacturaAnterior.Text = "Cve Factura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(473, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFact.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFact.Location = new System.Drawing.Point(251, 250);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarFact.TabIndex = 31;
            this.btnBuscarFact.Text = "...";
            this.btnBuscarFact.UseVisualStyleBackColor = false;
            this.btnBuscarFact.Click += new System.EventHandler(this.btnBuscarFact_Click);
            // 
            // txtRutaFactura
            // 
            this.txtRutaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtRutaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaFactura.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtRutaFactura.Location = new System.Drawing.Point(17, 250);
            this.txtRutaFactura.Name = "txtRutaFactura";
            this.txtRutaFactura.ReadOnly = true;
            this.txtRutaFactura.Size = new System.Drawing.Size(228, 20);
            this.txtRutaFactura.TabIndex = 30;
            // 
            // txtCve_Factura
            // 
            this.txtCve_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCve_Factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCve_Factura.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCve_Factura.Location = new System.Drawing.Point(109, 52);
            this.txtCve_Factura.Name = "txtCve_Factura";
            this.txtCve_Factura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCve_Factura.Size = new System.Drawing.Size(100, 20);
            this.txtCve_Factura.TabIndex = 29;
            this.txtCve_Factura.TextChanged += new System.EventHandler(this.txtCve_Factura_TextChanged);
            this.txtCve_Factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCve_Factura_KeyPress);
            this.txtCve_Factura.Validated += new System.EventHandler(this.txtCve_Factura_Validated);
            // 
            // lblFacturaSinIVA
            // 
            this.lblFacturaSinIVA.AutoSize = true;
            this.lblFacturaSinIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.lblFacturaSinIVA.ForeColor = System.Drawing.Color.White;
            this.lblFacturaSinIVA.Location = new System.Drawing.Point(13, 129);
            this.lblFacturaSinIVA.Name = "lblFacturaSinIVA";
            this.lblFacturaSinIVA.Size = new System.Drawing.Size(79, 13);
            this.lblFacturaSinIVA.TabIndex = 28;
            this.lblFacturaSinIVA.Text = "Factura sin IVA";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblFactura.ForeColor = System.Drawing.Color.White;
            this.lblFactura.Location = new System.Drawing.Point(14, 234);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(43, 13);
            this.lblFactura.TabIndex = 27;
            this.lblFactura.Text = "Factura";
            // 
            // lblRefactura
            // 
            this.lblRefactura.AutoSize = true;
            this.lblRefactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.lblRefactura.ForeColor = System.Drawing.Color.White;
            this.lblRefactura.Location = new System.Drawing.Point(14, 91);
            this.lblRefactura.Name = "lblRefactura";
            this.lblRefactura.Size = new System.Drawing.Size(88, 13);
            this.lblRefactura.TabIndex = 53;
            this.lblRefactura.Text = "Cve a Refacturar";
            // 
            // txtFacturaconIVA
            // 
            this.txtFacturaconIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacturaconIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacturaconIVA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtFacturaconIVA.Location = new System.Drawing.Point(109, 163);
            this.txtFacturaconIVA.Name = "txtFacturaconIVA";
            this.txtFacturaconIVA.ReadOnly = true;
            this.txtFacturaconIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFacturaconIVA.Size = new System.Drawing.Size(100, 20);
            this.txtFacturaconIVA.TabIndex = 54;
            // 
            // lblCostoRefactura
            // 
            this.lblCostoRefactura.AutoSize = true;
            this.lblCostoRefactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(87)))));
            this.lblCostoRefactura.ForeColor = System.Drawing.Color.White;
            this.lblCostoRefactura.Location = new System.Drawing.Point(14, 205);
            this.lblCostoRefactura.Name = "lblCostoRefactura";
            this.lblCostoRefactura.Size = new System.Drawing.Size(84, 13);
            this.lblCostoRefactura.TabIndex = 55;
            this.lblCostoRefactura.Text = "Costo Refactura";
            // 
            // txtCostoRefactura
            // 
            this.txtCostoRefactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCostoRefactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostoRefactura.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCostoRefactura.Location = new System.Drawing.Point(109, 202);
            this.txtCostoRefactura.Name = "txtCostoRefactura";
            this.txtCostoRefactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCostoRefactura.Size = new System.Drawing.Size(100, 20);
            this.txtCostoRefactura.TabIndex = 56;
            this.txtCostoRefactura.TextChanged += new System.EventHandler(this.txtCostoRefactura_TextChanged);
            this.txtCostoRefactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoRefactura_KeyPress);
            this.txtCostoRefactura.Validated += new System.EventHandler(this.txtCostoRefactura_Validated);
            // 
            // lblFechaRefacturacion
            // 
            this.lblFechaRefacturacion.AutoSize = true;
            this.lblFechaRefacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.lblFechaRefacturacion.ForeColor = System.Drawing.Color.White;
            this.lblFechaRefacturacion.Location = new System.Drawing.Point(222, 55);
            this.lblFechaRefacturacion.Name = "lblFechaRefacturacion";
            this.lblFechaRefacturacion.Size = new System.Drawing.Size(122, 13);
            this.lblFechaRefacturacion.TabIndex = 57;
            this.lblFechaRefacturacion.Text = "Fecha de Refacturación";
            // 
            // dtpFechaRefacturacion
            // 
            this.dtpFechaRefacturacion.Location = new System.Drawing.Point(350, 52);
            this.dtpFechaRefacturacion.Name = "dtpFechaRefacturacion";
            this.dtpFechaRefacturacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRefacturacion.TabIndex = 58;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(61, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Visible = false;
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dato1.ForeColor = System.Drawing.Color.White;
            this.dato1.Location = new System.Drawing.Point(141, 9);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(68, 13);
            this.dato1.TabIndex = 61;
            this.dato1.Text = "SINIESTRO:";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dato2.ForeColor = System.Drawing.Color.White;
            this.dato2.Location = new System.Drawing.Point(13, 9);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(51, 13);
            this.dato2.TabIndex = 62;
            this.dato2.Text = "PEDIDO:";
            // 
            // dato3
            // 
            this.dato3.AutoSize = true;
            this.dato3.Location = new System.Drawing.Point(594, 0);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(35, 13);
            this.dato3.TabIndex = 63;
            this.dato3.Text = "label1";
            this.dato3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "$";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pbMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.pbClose);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(561, 381);
            this.bunifuGradientPanel1.TabIndex = 67;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::Refracciones.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(521, 6);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(15, 16);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 69;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Refracciones.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(540, 6);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(15, 16);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 68;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // registrarRefactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFechaRefacturacion);
            this.Controls.Add(this.lblFechaRefacturacion);
            this.Controls.Add(this.txtCostoRefactura);
            this.Controls.Add(this.lblCostoRefactura);
            this.Controls.Add(this.txtFacturaconIVA);
            this.Controls.Add(this.lblRefactura);
            this.Controls.Add(this.cmbEstadoFactura);
            this.Controls.Add(this.lblEstadoFactura);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnBuscarXml);
            this.Controls.Add(this.txtRutaXml);
            this.Controls.Add(this.lblXml);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblFechaRevision);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dtpFechaRevision);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFacturaConIVA);
            this.Controls.Add(this.txtFacturasinIVA);
            this.Controls.Add(this.txtRefactura);
            this.Controls.Add(this.lblClave_FacturaAnterior);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarFact);
            this.Controls.Add(this.txtRutaFactura);
            this.Controls.Add(this.txtCve_Factura);
            this.Controls.Add(this.lblFacturaSinIVA);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarRefactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrarRefactura";
            this.Load += new System.EventHandler(this.registrarRefactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnBuscarXml;
        private System.Windows.Forms.TextBox txtRutaXml;
        private System.Windows.Forms.Label lblXml;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblFechaRevision;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFacturaConIVA;
        private System.Windows.Forms.TextBox txtFacturasinIVA;
        private System.Windows.Forms.Label lblClave_FacturaAnterior;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarFact;
        private System.Windows.Forms.TextBox txtRutaFactura;
        private System.Windows.Forms.TextBox txtCve_Factura;
        private System.Windows.Forms.Label lblFacturaSinIVA;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblRefactura;
        private System.Windows.Forms.TextBox txtFacturaconIVA;
        private System.Windows.Forms.Label lblCostoRefactura;
        private System.Windows.Forms.TextBox txtCostoRefactura;
        private System.Windows.Forms.Label lblFechaRefacturacion;
        private System.Windows.Forms.DateTimePicker dtpFechaRefacturacion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label dato1;
        public System.Windows.Forms.Label dato2;
        public System.Windows.Forms.Label dato3;
        public System.Windows.Forms.TextBox txtRefactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorP;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
    }
}