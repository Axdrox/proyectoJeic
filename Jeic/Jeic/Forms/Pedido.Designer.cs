﻿namespace Refracciones.Forms
{
    partial class Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehiculoPedido = new System.Windows.Forms.Label();
            this.lblAnioPedido = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAseguradora = new System.Windows.Forms.ComboBox();
            this.lblClientePedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaPromesa = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTaller = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.chbSi = new System.Windows.Forms.CheckBox();
            this.chbOtroValuador = new System.Windows.Forms.CheckBox();
            this.txtValuador = new System.Windows.Forms.TextBox();
            this.cbValuador = new System.Windows.Forms.ComboBox();
            this.txtAseguradora = new System.Windows.Forms.TextBox();
            this.chbOtraAseguradora = new System.Windows.Forms.CheckBox();
            this.lblClaveSiniestroPedido = new System.Windows.Forms.Label();
            this.lblClaveSiniestro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClavePedido = new System.Windows.Forms.TextBox();
            this.chbOtroTaller = new System.Windows.Forms.CheckBox();
            this.chbOtroDestino = new System.Windows.Forms.CheckBox();
            this.txtTaller = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnAgregarPieza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Agregar siniestro?";
            // 
            // lblVehiculoPedido
            // 
            this.lblVehiculoPedido.Location = new System.Drawing.Point(62, 120);
            this.lblVehiculoPedido.Name = "lblVehiculoPedido";
            this.lblVehiculoPedido.Size = new System.Drawing.Size(74, 17);
            this.lblVehiculoPedido.TabIndex = 0;
            this.lblVehiculoPedido.Text = "Vehículo:";
            // 
            // lblAnioPedido
            // 
            this.lblAnioPedido.Location = new System.Drawing.Point(62, 137);
            this.lblAnioPedido.Name = "lblAnioPedido";
            this.lblAnioPedido.Size = new System.Drawing.Size(46, 17);
            this.lblAnioPedido.TabIndex = 0;
            this.lblAnioPedido.Text = "Año:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(163, 120);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(0, 17);
            this.lblVehiculo.TabIndex = 2;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(163, 141);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(0, 17);
            this.lblAnio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valuador:";
            // 
            // cbAseguradora
            // 
            this.cbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAseguradora.Enabled = false;
            this.cbAseguradora.FormattingEnabled = true;
            this.cbAseguradora.Location = new System.Drawing.Point(166, 169);
            this.cbAseguradora.Name = "cbAseguradora";
            this.cbAseguradora.Size = new System.Drawing.Size(185, 24);
            this.cbAseguradora.TabIndex = 5;
            this.cbAseguradora.SelectedIndexChanged += new System.EventHandler(this.cbAseguradora_SelectedIndexChanged);
            this.cbAseguradora.Click += new System.EventHandler(this.cbAseguradora_Click);
            // 
            // lblClientePedido
            // 
            this.lblClientePedido.AutoSize = true;
            this.lblClientePedido.Location = new System.Drawing.Point(25, 172);
            this.lblClientePedido.Name = "lblClientePedido";
            this.lblClientePedido.Size = new System.Drawing.Size(55, 17);
            this.lblClientePedido.TabIndex = 6;
            this.lblClientePedido.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vendedor:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendedor.Enabled = false;
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(165, 37);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(155, 24);
            this.cbVendedor.TabIndex = 9;
            this.cbVendedor.SelectedIndexChanged += new System.EventHandler(this.cbVendedor_SelectedIndexChanged);
            this.cbVendedor.Click += new System.EventHandler(this.cbVendedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de asignación";
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.Enabled = false;
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(179, 317);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(255, 22);
            this.dtpFechaAsignacion.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha promesa:";
            // 
            // dtpFechaPromesa
            // 
            this.dtpFechaPromesa.Enabled = false;
            this.dtpFechaPromesa.Location = new System.Drawing.Point(179, 351);
            this.dtpFechaPromesa.Name = "dtpFechaPromesa";
            this.dtpFechaPromesa.Size = new System.Drawing.Size(255, 22);
            this.dtpFechaPromesa.TabIndex = 13;
            this.dtpFechaPromesa.ValueChanged += new System.EventHandler(this.dtpFechaPromesa_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Taller:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Destino:";
            // 
            // cbTaller
            // 
            this.cbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaller.Enabled = false;
            this.cbTaller.FormattingEnabled = true;
            this.cbTaller.Location = new System.Drawing.Point(165, 239);
            this.cbTaller.Name = "cbTaller";
            this.cbTaller.Size = new System.Drawing.Size(186, 24);
            this.cbTaller.TabIndex = 16;
            this.cbTaller.Click += new System.EventHandler(this.cbTaller_Click);
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.Enabled = false;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(165, 273);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(186, 24);
            this.cbDestino.TabIndex = 17;
            this.cbDestino.Click += new System.EventHandler(this.cbDestino_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(25, 493);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(410, 150);
            this.dgvPedido.TabIndex = 18;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Enabled = false;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(303, 702);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(143, 31);
            this.btnFinalizarPedido.TabIndex = 19;
            this.btnFinalizarPedido.Text = "Finalizar pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(201, 702);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Enabled = false;
            this.rdbNo.Location = new System.Drawing.Point(250, 80);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(47, 21);
            this.rdbNo.TabIndex = 22;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Enabled = false;
            this.rdbSi.Location = new System.Drawing.Point(189, 80);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(41, 21);
            this.rdbSi.TabIndex = 23;
            this.rdbSi.Text = "Sí";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // chbSi
            // 
            this.chbSi.AutoSize = true;
            this.chbSi.Location = new System.Drawing.Point(189, 81);
            this.chbSi.Name = "chbSi";
            this.chbSi.Size = new System.Drawing.Size(42, 21);
            this.chbSi.TabIndex = 24;
            this.chbSi.Text = "Sí";
            this.chbSi.UseVisualStyleBackColor = true;
            // 
            // chbOtroValuador
            // 
            this.chbOtroValuador.AutoSize = true;
            this.chbOtroValuador.Enabled = false;
            this.chbOtroValuador.Location = new System.Drawing.Point(375, 206);
            this.chbOtroValuador.Name = "chbOtroValuador";
            this.chbOtroValuador.Size = new System.Drawing.Size(58, 21);
            this.chbOtroValuador.TabIndex = 25;
            this.chbOtroValuador.Text = "Otro";
            this.chbOtroValuador.UseVisualStyleBackColor = true;
            this.chbOtroValuador.CheckedChanged += new System.EventHandler(this.chbOtroValuador_CheckedChanged);
            // 
            // txtValuador
            // 
            this.txtValuador.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtValuador.Location = new System.Drawing.Point(165, 202);
            this.txtValuador.Name = "txtValuador";
            this.txtValuador.Size = new System.Drawing.Size(186, 22);
            this.txtValuador.TabIndex = 26;
            this.txtValuador.Text = "Escribe nombre del valuador";
            this.txtValuador.Click += new System.EventHandler(this.txtValuador_Click);
            // 
            // cbValuador
            // 
            this.cbValuador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValuador.Enabled = false;
            this.cbValuador.FormattingEnabled = true;
            this.cbValuador.Location = new System.Drawing.Point(166, 202);
            this.cbValuador.Name = "cbValuador";
            this.cbValuador.Size = new System.Drawing.Size(186, 24);
            this.cbValuador.TabIndex = 27;
            this.cbValuador.SelectedIndexChanged += new System.EventHandler(this.cbValuador_SelectedIndexChanged);
            // 
            // txtAseguradora
            // 
            this.txtAseguradora.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAseguradora.Location = new System.Drawing.Point(165, 169);
            this.txtAseguradora.Name = "txtAseguradora";
            this.txtAseguradora.Size = new System.Drawing.Size(186, 22);
            this.txtAseguradora.TabIndex = 28;
            this.txtAseguradora.Text = "Escriba el nombre del cliente";
            this.txtAseguradora.Click += new System.EventHandler(this.txtAseguradora_Click);
            // 
            // chbOtraAseguradora
            // 
            this.chbOtraAseguradora.AutoSize = true;
            this.chbOtraAseguradora.Enabled = false;
            this.chbOtraAseguradora.Location = new System.Drawing.Point(375, 172);
            this.chbOtraAseguradora.Name = "chbOtraAseguradora";
            this.chbOtraAseguradora.Size = new System.Drawing.Size(58, 21);
            this.chbOtraAseguradora.TabIndex = 29;
            this.chbOtraAseguradora.Text = "Otro";
            this.chbOtraAseguradora.UseVisualStyleBackColor = true;
            this.chbOtraAseguradora.CheckedChanged += new System.EventHandler(this.chbOtraAseguradora_CheckedChanged);
            // 
            // lblClaveSiniestroPedido
            // 
            this.lblClaveSiniestroPedido.AutoSize = true;
            this.lblClaveSiniestroPedido.Location = new System.Drawing.Point(59, 103);
            this.lblClaveSiniestroPedido.Name = "lblClaveSiniestroPedido";
            this.lblClaveSiniestroPedido.Size = new System.Drawing.Size(104, 17);
            this.lblClaveSiniestroPedido.TabIndex = 30;
            this.lblClaveSiniestroPedido.Text = "Clave siniestro:";
            // 
            // lblClaveSiniestro
            // 
            this.lblClaveSiniestro.AutoSize = true;
            this.lblClaveSiniestro.Location = new System.Drawing.Point(165, 103);
            this.lblClaveSiniestro.Name = "lblClaveSiniestro";
            this.lblClaveSiniestro.Size = new System.Drawing.Size(0, 17);
            this.lblClaveSiniestro.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Clave pedido:";
            // 
            // txtClavePedido
            // 
            this.txtClavePedido.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtClavePedido.Location = new System.Drawing.Point(165, 4);
            this.txtClavePedido.Name = "txtClavePedido";
            this.txtClavePedido.Size = new System.Drawing.Size(155, 22);
            this.txtClavePedido.TabIndex = 33;
            this.txtClavePedido.Text = "Escribe una clave";
            this.txtClavePedido.Click += new System.EventHandler(this.txtClavePedido_Click);
            this.txtClavePedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClavePedido_KeyPress);
            // 
            // chbOtroTaller
            // 
            this.chbOtroTaller.AutoSize = true;
            this.chbOtroTaller.Enabled = false;
            this.chbOtroTaller.Location = new System.Drawing.Point(376, 243);
            this.chbOtroTaller.Name = "chbOtroTaller";
            this.chbOtroTaller.Size = new System.Drawing.Size(58, 21);
            this.chbOtroTaller.TabIndex = 34;
            this.chbOtroTaller.Text = "Otro";
            this.chbOtroTaller.UseVisualStyleBackColor = true;
            this.chbOtroTaller.CheckedChanged += new System.EventHandler(this.chbOtroTaller_CheckedChanged);
            // 
            // chbOtroDestino
            // 
            this.chbOtroDestino.AutoSize = true;
            this.chbOtroDestino.Enabled = false;
            this.chbOtroDestino.Location = new System.Drawing.Point(375, 276);
            this.chbOtroDestino.Name = "chbOtroDestino";
            this.chbOtroDestino.Size = new System.Drawing.Size(58, 21);
            this.chbOtroDestino.TabIndex = 35;
            this.chbOtroDestino.Text = "Otro";
            this.chbOtroDestino.UseVisualStyleBackColor = true;
            this.chbOtroDestino.CheckedChanged += new System.EventHandler(this.chbOtroDestino_CheckedChanged);
            // 
            // txtTaller
            // 
            this.txtTaller.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTaller.Location = new System.Drawing.Point(165, 239);
            this.txtTaller.Name = "txtTaller";
            this.txtTaller.Size = new System.Drawing.Size(186, 22);
            this.txtTaller.TabIndex = 36;
            this.txtTaller.Text = "Escriba nombre de taller";
            this.txtTaller.Click += new System.EventHandler(this.txtTaller_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDestino.Location = new System.Drawing.Point(165, 273);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(186, 22);
            this.txtDestino.TabIndex = 37;
            this.txtDestino.Text = "Escriba el destino";
            this.txtDestino.Click += new System.EventHandler(this.txtDestino_Click);
            // 
            // btnAgregarPieza
            // 
            this.btnAgregarPieza.Location = new System.Drawing.Point(24, 456);
            this.btnAgregarPieza.Name = "btnAgregarPieza";
            this.btnAgregarPieza.Size = new System.Drawing.Size(133, 31);
            this.btnAgregarPieza.TabIndex = 38;
            this.btnAgregarPieza.Text = "Agregar pieza";
            this.btnAgregarPieza.UseVisualStyleBackColor = true;
            this.btnAgregarPieza.Click += new System.EventHandler(this.btnAgregarPieza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha de baja:";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Enabled = false;
            this.dtpFechaBaja.Location = new System.Drawing.Point(179, 388);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(255, 22);
            this.dtpFechaBaja.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Piezas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 646);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Precio";
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(329, 661);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(0, 17);
            this.lblCantidadTotal.TabIndex = 44;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(385, 661);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 17);
            this.lblPrecioTotal.TabIndex = 45;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 745);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarPieza);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtTaller);
            this.Controls.Add(this.chbOtroDestino);
            this.Controls.Add(this.chbOtroTaller);
            this.Controls.Add(this.txtClavePedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClaveSiniestro);
            this.Controls.Add(this.lblClaveSiniestroPedido);
            this.Controls.Add(this.chbOtraAseguradora);
            this.Controls.Add(this.txtAseguradora);
            this.Controls.Add(this.cbValuador);
            this.Controls.Add(this.txtValuador);
            this.Controls.Add(this.chbOtroValuador);
            this.Controls.Add(this.chbSi);
            this.Controls.Add(this.rdbSi);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbTaller);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaPromesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaAsignacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblClientePedido);
            this.Controls.Add(this.cbAseguradora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblAnioPedido);
            this.Controls.Add(this.lblVehiculoPedido);
            this.Controls.Add(this.label1);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAseguradora;
        private System.Windows.Forms.Label lblClientePedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaPromesa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTaller;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbNo;
        public System.Windows.Forms.RadioButton rdbSi;
        public System.Windows.Forms.CheckBox chbSi;
        public System.Windows.Forms.Label lblVehiculo;
        public System.Windows.Forms.Label lblAnio;
        public System.Windows.Forms.Label lblVehiculoPedido;
        public System.Windows.Forms.Label lblAnioPedido;
        private System.Windows.Forms.CheckBox chbOtroValuador;
        private System.Windows.Forms.TextBox txtValuador;
        private System.Windows.Forms.ComboBox cbValuador;
        private System.Windows.Forms.TextBox txtAseguradora;
        private System.Windows.Forms.CheckBox chbOtraAseguradora;
        public System.Windows.Forms.Label lblClaveSiniestroPedido;
        public System.Windows.Forms.Label lblClaveSiniestro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClavePedido;
        private System.Windows.Forms.CheckBox chbOtroTaller;
        private System.Windows.Forms.CheckBox chbOtroDestino;
        private System.Windows.Forms.TextBox txtTaller;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnAgregarPieza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblPrecioTotal;
    }
}