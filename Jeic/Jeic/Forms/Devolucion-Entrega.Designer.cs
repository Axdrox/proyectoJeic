﻿namespace Refracciones.Forms
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblPenalizacion = new System.Windows.Forms.Label();
            this.cmbPenalizacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMotivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbMotivoDev = new System.Windows.Forms.ComboBox();
            this.lblMotivoDev = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtnDevolucion = new System.Windows.Forms.RadioButton();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPenalizacion);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPenalizacion);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chkMotivo);
            this.splitContainer1.Panel1.Controls.Add(this.txtMotivo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMotivoDev);
            this.splitContainer1.Panel1.Controls.Add(this.lblMotivoDev);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnDevolucion);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnEntrega);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCantidad);
            this.splitContainer1.Panel1.Controls.Add(this.lbl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFecha);
            this.splitContainer1.Panel1.Controls.Add(this.lbl1);
            this.splitContainer1.Panel1.Controls.Add(this.dato2);
            this.splitContainer1.Panel1.Controls.Add(this.dato1);
            this.splitContainer1.Panel1.Controls.Add(this.menu);
            this.splitContainer1.Panel1.Controls.Add(this.bunifuGradientPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDevolucion);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuGradientPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 450);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblPenalizacion
            // 
            this.lblPenalizacion.AutoSize = true;
            this.lblPenalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(97)))));
            this.lblPenalizacion.ForeColor = System.Drawing.Color.White;
            this.lblPenalizacion.Location = new System.Drawing.Point(18, 282);
            this.lblPenalizacion.Name = "lblPenalizacion";
            this.lblPenalizacion.Size = new System.Drawing.Size(136, 13);
            this.lblPenalizacion.TabIndex = 16;
            this.lblPenalizacion.Text = "Porcentaje de Penalización";
            this.lblPenalizacion.Visible = false;
            // 
            // cmbPenalizacion
            // 
            this.cmbPenalizacion.Enabled = false;
            this.cmbPenalizacion.FormattingEnabled = true;
            this.cmbPenalizacion.Items.AddRange(new object[] {
            "0%",
            "20%",
            "100%"});
            this.cmbPenalizacion.Location = new System.Drawing.Point(18, 301);
            this.cmbPenalizacion.Name = "cmbPenalizacion";
            this.cmbPenalizacion.Size = new System.Drawing.Size(121, 21);
            this.cmbPenalizacion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(88)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Otro";
            this.label1.Visible = false;
            // 
            // chkMotivo
            // 
            this.chkMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMotivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMotivo.Checked = false;
            this.chkMotivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkMotivo.ForeColor = System.Drawing.Color.White;
            this.chkMotivo.Location = new System.Drawing.Point(145, 243);
            this.chkMotivo.Name = "chkMotivo";
            this.chkMotivo.Size = new System.Drawing.Size(20, 20);
            this.chkMotivo.TabIndex = 13;
            this.chkMotivo.Visible = false;
            this.chkMotivo.OnChange += new System.EventHandler(this.chkMotivo_OnChange);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(18, 242);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(121, 20);
            this.txtMotivo.TabIndex = 12;
            this.txtMotivo.Visible = false;
            // 
            // cmbMotivoDev
            // 
            this.cmbMotivoDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoDev.Enabled = false;
            this.cmbMotivoDev.FormattingEnabled = true;
            this.cmbMotivoDev.Items.AddRange(new object[] {
            "Cancelada",
            "Pago Daños",
            "Asegurado Transito",
            "Pieza con daño",
            "Cambio Origen",
            "Perdida Total",
            "Pieza Incorrecta"});
            this.cmbMotivoDev.Location = new System.Drawing.Point(18, 242);
            this.cmbMotivoDev.Name = "cmbMotivoDev";
            this.cmbMotivoDev.Size = new System.Drawing.Size(121, 21);
            this.cmbMotivoDev.TabIndex = 11;
            this.cmbMotivoDev.Visible = false;
            // 
            // lblMotivoDev
            // 
            this.lblMotivoDev.AutoSize = true;
            this.lblMotivoDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblMotivoDev.ForeColor = System.Drawing.Color.White;
            this.lblMotivoDev.Location = new System.Drawing.Point(15, 215);
            this.lblMotivoDev.Name = "lblMotivoDev";
            this.lblMotivoDev.Size = new System.Drawing.Size(99, 13);
            this.lblMotivoDev.TabIndex = 10;
            this.lblMotivoDev.Text = "Motivo Devolución:";
            this.lblMotivoDev.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(15, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(91, 370);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ENTREGA";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnDevolucion
            // 
            this.rbtnDevolucion.AutoSize = true;
            this.rbtnDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rbtnDevolucion.Enabled = false;
            this.rbtnDevolucion.ForeColor = System.Drawing.Color.White;
            this.rbtnDevolucion.Location = new System.Drawing.Point(136, 55);
            this.rbtnDevolucion.Name = "rbtnDevolucion";
            this.rbtnDevolucion.Size = new System.Drawing.Size(79, 17);
            this.rbtnDevolucion.TabIndex = 7;
            this.rbtnDevolucion.Text = "Devolución";
            this.rbtnDevolucion.UseVisualStyleBackColor = false;
            this.rbtnDevolucion.CheckedChanged += new System.EventHandler(this.rbtnDevolucion_CheckedChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rbtnEntrega.Checked = true;
            this.rbtnEntrega.Enabled = false;
            this.rbtnEntrega.ForeColor = System.Drawing.Color.White;
            this.rbtnEntrega.Location = new System.Drawing.Point(21, 55);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(62, 17);
            this.rbtnEntrega.TabIndex = 6;
            this.rbtnEntrega.TabStop = true;
            this.rbtnEntrega.Text = "Entrega";
            this.rbtnEntrega.UseVisualStyleBackColor = false;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnEntrega_CheckedChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.Enabled = false;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(15, 179);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCantidad.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(12, 159);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(104, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Cantidad Entregada ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(15, 115);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(12, 87);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(77, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Fecha Entrega";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.dato2.ForeColor = System.Drawing.Color.White;
            this.dato2.Location = new System.Drawing.Point(155, 28);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(51, 13);
            this.dato2.TabIndex = 1;
            this.dato2.Text = "PEDIDO:";
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.dato1.ForeColor = System.Drawing.Color.White;
            this.dato1.Location = new System.Drawing.Point(12, 28);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(68, 13);
            this.dato1.TabIndex = 0;
            this.dato1.Text = "SINIESTRO:";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(353, 24);
            this.menu.TabIndex = 17;
            this.menu.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem,
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarEntregaDeTodoElPedidoToolStripMenuItem
            // 
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Name = "registrarEntregaDeTodoElPedidoToolStripMenuItem";
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Text = "Registrar entrega de todo el pedido ";
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarEntregaDeTodoElPedidoToolStripMenuItem_Click);
            // 
            // registrarDevoluciónDeTodoElPedidoToolStripMenuItem
            // 
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Name = "registrarDevoluciónDeTodoElPedidoToolStripMenuItem";
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Text = "Registrar devolución de todo el pedido";
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1370, 450);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.AllowUserToAddRows = false;
            this.dgvDevolucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevolucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDevolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucion.EnableHeadersVisualStyles = false;
            this.dgvDevolucion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dgvDevolucion.Location = new System.Drawing.Point(3, 28);
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            this.dgvDevolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevolucion.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDevolucion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion.Size = new System.Drawing.Size(1007, 422);
            this.dgvDevolucion.TabIndex = 0;
            this.dgvDevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucion_CellContentClick);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.pbMinimize);
            this.bunifuGradientPanel2.Controls.Add(this.pbClose);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(3, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1188, 450);
            this.bunifuGradientPanel2.TabIndex = 19;
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
            // pbMinimize
            // 
            this.pbMinimize.Image = global::Refracciones.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(973, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(15, 16);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 73;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Refracciones.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(992, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(15, 16);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 72;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private System.Windows.Forms.RadioButton rbtnDevolucion;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label dato2;
        public System.Windows.Forms.Label dato1;
        private System.Windows.Forms.ComboBox cmbMotivoDev;
        private System.Windows.Forms.Label lblMotivoDev;
        private Bunifu.Framework.UI.BunifuCheckbox chkMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPenalizacion;
        private System.Windows.Forms.ComboBox cmbPenalizacion;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntregaDeTodoElPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDevoluciónDeTodoElPedidoToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
    }
}