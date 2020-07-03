namespace Refracciones.Forms
{
    partial class registroFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroFactura));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFacturaSinIVA = new System.Windows.Forms.Label();
            this.txtCve_Factura = new System.Windows.Forms.TextBox();
            this.txtRutaFactura = new System.Windows.Forms.TextBox();
            this.btnBuscarFact = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblClave_Factura = new System.Windows.Forms.Label();
            this.txtFacturasinIVA = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtFacturaconIVA = new System.Windows.Forms.TextBox();
            this.lblFacturaConIVA = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRevision = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRutaXml = new System.Windows.Forms.TextBox();
            this.btnBuscarXml = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dato1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dato4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(86)))));
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(16, 203);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Factura";
            // 
            // lblFacturaSinIVA
            // 
            this.lblFacturaSinIVA.AutoSize = true;
            this.lblFacturaSinIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.lblFacturaSinIVA.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaSinIVA.ForeColor = System.Drawing.Color.White;
            this.lblFacturaSinIVA.Location = new System.Drawing.Point(11, 98);
            this.lblFacturaSinIVA.Name = "lblFacturaSinIVA";
            this.lblFacturaSinIVA.Size = new System.Drawing.Size(87, 14);
            this.lblFacturaSinIVA.TabIndex = 1;
            this.lblFacturaSinIVA.Text = "Factura sin IVA";
            // 
            // txtCve_Factura
            // 
            this.txtCve_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCve_Factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCve_Factura.ForeColor = System.Drawing.Color.White;
            this.txtCve_Factura.Location = new System.Drawing.Point(106, 58);
            this.txtCve_Factura.Name = "txtCve_Factura";
            this.txtCve_Factura.Size = new System.Drawing.Size(141, 20);
            this.txtCve_Factura.TabIndex = 2;
            this.txtCve_Factura.TextChanged += new System.EventHandler(this.txtCve_Factura_TextChanged);
            // 
            // txtRutaFactura
            // 
            this.txtRutaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtRutaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaFactura.ForeColor = System.Drawing.Color.White;
            this.txtRutaFactura.Location = new System.Drawing.Point(19, 219);
            this.txtRutaFactura.Name = "txtRutaFactura";
            this.txtRutaFactura.ReadOnly = true;
            this.txtRutaFactura.Size = new System.Drawing.Size(228, 20);
            this.txtRutaFactura.TabIndex = 3;
            this.txtRutaFactura.TextChanged += new System.EventHandler(this.txtRutaFactura_TextChanged);
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFact.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFact.Location = new System.Drawing.Point(253, 219);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarFact.TabIndex = 4;
            this.btnBuscarFact.Text = "...";
            this.btnBuscarFact.UseVisualStyleBackColor = false;
            this.btnBuscarFact.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(510, 293);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblClave_Factura
            // 
            this.lblClave_Factura.AutoSize = true;
            this.lblClave_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.lblClave_Factura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave_Factura.ForeColor = System.Drawing.Color.White;
            this.lblClave_Factura.Location = new System.Drawing.Point(11, 59);
            this.lblClave_Factura.Name = "lblClave_Factura";
            this.lblClave_Factura.Size = new System.Drawing.Size(93, 14);
            this.lblClave_Factura.TabIndex = 6;
            this.lblClave_Factura.Text = "Número Factura";
            // 
            // txtFacturasinIVA
            // 
            this.txtFacturasinIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacturasinIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacturasinIVA.ForeColor = System.Drawing.Color.White;
            this.txtFacturasinIVA.Location = new System.Drawing.Point(106, 94);
            this.txtFacturasinIVA.Name = "txtFacturasinIVA";
            this.txtFacturasinIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFacturasinIVA.Size = new System.Drawing.Size(141, 20);
            this.txtFacturasinIVA.TabIndex = 7;
            this.txtFacturasinIVA.TextChanged += new System.EventHandler(this.txtFacturasinIVA_TextChanged);
            this.txtFacturasinIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturasinIVA_KeyPress);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(662, 37);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtFacturaconIVA
            // 
            this.txtFacturaconIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacturaconIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacturaconIVA.ForeColor = System.Drawing.Color.White;
            this.txtFacturaconIVA.Location = new System.Drawing.Point(107, 159);
            this.txtFacturaconIVA.Name = "txtFacturaconIVA";
            this.txtFacturaconIVA.ReadOnly = true;
            this.txtFacturaconIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFacturaconIVA.Size = new System.Drawing.Size(141, 20);
            this.txtFacturaconIVA.TabIndex = 9;
            // 
            // lblFacturaConIVA
            // 
            this.lblFacturaConIVA.AutoSize = true;
            this.lblFacturaConIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(78)))));
            this.lblFacturaConIVA.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaConIVA.ForeColor = System.Drawing.Color.White;
            this.lblFacturaConIVA.Location = new System.Drawing.Point(11, 163);
            this.lblFacturaConIVA.Name = "lblFacturaConIVA";
            this.lblFacturaConIVA.Size = new System.Drawing.Size(89, 14);
            this.lblFacturaConIVA.TabIndex = 10;
            this.lblFacturaConIVA.Text = "Factura con IVA";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(374, 58);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 11;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.lblFechaIngreso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblFechaIngreso.Location = new System.Drawing.Point(267, 60);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(100, 14);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(374, 94);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRevision.TabIndex = 13;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Enabled = false;
            this.dtpFechaPago.Location = new System.Drawing.Point(374, 132);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 14;
            // 
            // lblFechaRevision
            // 
            this.lblFechaRevision.AutoSize = true;
            this.lblFechaRevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.lblFechaRevision.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRevision.ForeColor = System.Drawing.Color.White;
            this.lblFechaRevision.Location = new System.Drawing.Point(267, 97);
            this.lblFechaRevision.Name = "lblFechaRevision";
            this.lblFechaRevision.Size = new System.Drawing.Size(106, 14);
            this.lblFechaRevision.TabIndex = 15;
            this.lblFechaRevision.Text = "Fecha de Revisión";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(78)))));
            this.lblFechaPago.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.ForeColor = System.Drawing.Color.White;
            this.lblFechaPago.Location = new System.Drawing.Point(267, 136);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(85, 14);
            this.lblFechaPago.TabIndex = 16;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(101)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Xml";
            // 
            // txtRutaXml
            // 
            this.txtRutaXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtRutaXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRutaXml.ForeColor = System.Drawing.Color.White;
            this.txtRutaXml.Location = new System.Drawing.Point(19, 258);
            this.txtRutaXml.Name = "txtRutaXml";
            this.txtRutaXml.ReadOnly = true;
            this.txtRutaXml.Size = new System.Drawing.Size(228, 20);
            this.txtRutaXml.TabIndex = 18;
            this.txtRutaXml.TextChanged += new System.EventHandler(this.txtRutaXml_TextChanged);
            // 
            // btnBuscarXml
            // 
            this.btnBuscarXml.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarXml.ForeColor = System.Drawing.Color.White;
            this.btnBuscarXml.Location = new System.Drawing.Point(253, 258);
            this.btnBuscarXml.Name = "btnBuscarXml";
            this.btnBuscarXml.Size = new System.Drawing.Size(45, 20);
            this.btnBuscarXml.TabIndex = 19;
            this.btnBuscarXml.Text = "...";
            this.btnBuscarXml.UseVisualStyleBackColor = false;
            this.btnBuscarXml.Click += new System.EventHandler(this.btnBuscarXml_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.ForeColor = System.Drawing.Color.White;
            this.txtComentario.Location = new System.Drawing.Point(342, 221);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(243, 66);
            this.txtComentario.TabIndex = 23;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(92)))));
            this.lblComentarios.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.ForeColor = System.Drawing.Color.White;
            this.lblComentarios.Location = new System.Drawing.Point(339, 198);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(76, 14);
            this.lblComentarios.TabIndex = 24;
            this.lblComentarios.Text = "Comentarios";
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(69)))), ((int)(((byte)(119)))));
            this.lblEstadoFactura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.White;
            this.lblEstadoFactura.Location = new System.Drawing.Point(15, 290);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(118, 14);
            this.lblEstadoFactura.TabIndex = 25;
            this.lblEstadoFactura.Text = "Estado de la Factura";
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmbEstadoFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstadoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstadoFactura.ForeColor = System.Drawing.Color.White;
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADA",
            "CANCELADA"});
            this.cmbEstadoFactura.Location = new System.Drawing.Point(138, 288);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFactura.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.dato1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.ForeColor = System.Drawing.Color.White;
            this.dato1.Location = new System.Drawing.Point(179, 32);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(65, 14);
            this.dato1.TabIndex = 28;
            this.dato1.Text = "SINIESTRO:";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.dato2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.ForeColor = System.Drawing.Color.White;
            this.dato2.Location = new System.Drawing.Point(16, 32);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(50, 14);
            this.dato2.TabIndex = 29;
            this.dato2.Text = "PEDIDO:";
            // 
            // dato3
            // 
            this.dato3.AutoSize = true;
            this.dato3.Location = new System.Drawing.Point(539, 33);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(35, 13);
            this.dato3.TabIndex = 30;
            this.dato3.Text = "label1";
            this.dato3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "$";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dato4);
            this.bunifuGradientPanel1.Controls.Add(this.txtDescuento);
            this.bunifuGradientPanel1.Controls.Add(this.lblDescuento);
            this.bunifuGradientPanel1.Controls.Add(this.pbMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.pbClose);
            this.bunifuGradientPanel1.Controls.Add(this.dato3);
            this.bunifuGradientPanel1.Controls.Add(this.lblFechaIngreso);
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Controls.Add(this.lblFechaPago);
            this.bunifuGradientPanel1.Controls.Add(this.cmbEstadoFactura);
            this.bunifuGradientPanel1.Controls.Add(this.lblFacturaSinIVA);
            this.bunifuGradientPanel1.Controls.Add(this.lblFacturaConIVA);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(620, 358);
            this.bunifuGradientPanel1.TabIndex = 33;
            // 
            // dato4
            // 
            this.dato4.AutoSize = true;
            this.dato4.Location = new System.Drawing.Point(581, 33);
            this.dato4.Name = "dato4";
            this.dato4.Size = new System.Drawing.Size(0, 13);
            this.dato4.TabIndex = 73;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.ForeColor = System.Drawing.Color.White;
            this.txtDescuento.Location = new System.Drawing.Point(107, 126);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescuento.Size = new System.Drawing.Size(141, 20);
            this.txtDescuento.TabIndex = 34;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.lblDescuento.ForeColor = System.Drawing.Color.White;
            this.lblDescuento.Location = new System.Drawing.Point(11, 133);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 72;
            this.lblDescuento.Text = "Descuento:";
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::Jeic.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(580, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(17, 17);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 71;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(600, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(17, 17);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 70;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "%";
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.bunifuGradientPanel1;
            this.moverFormulario.Vertical = true;
            // 
            // registroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.lblEstadoFactura);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnBuscarXml);
            this.Controls.Add(this.txtRutaXml);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechaRevision);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dtpFechaRevision);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtFacturaconIVA);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtFacturasinIVA);
            this.Controls.Add(this.lblClave_Factura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarFact);
            this.Controls.Add(this.txtRutaFactura);
            this.Controls.Add(this.txtCve_Factura);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registroFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registroFactura";
            this.Load += new System.EventHandler(this.registroFactura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.registroFactura_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFacturaSinIVA;
        private System.Windows.Forms.TextBox txtCve_Factura;
        private System.Windows.Forms.TextBox txtRutaFactura;
        private System.Windows.Forms.Button btnBuscarFact;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblClave_Factura;
        private System.Windows.Forms.TextBox txtFacturasinIVA;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtFacturaconIVA;
        private System.Windows.Forms.Label lblFacturaConIVA;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaRevision;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblFechaRevision;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRutaXml;
        private System.Windows.Forms.Button btnBuscarXml;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label dato1;
        public System.Windows.Forms.Label dato2;
        public System.Windows.Forms.Label dato3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorP;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        private System.Windows.Forms.Label dato4;
    }
}