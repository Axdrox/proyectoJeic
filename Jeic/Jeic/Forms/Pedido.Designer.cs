namespace Refracciones.Forms
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
            this.components = new System.ComponentModel.Container();
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
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.chbModificarFechaAsignacion = new System.Windows.Forms.CheckBox();
            this.chbModificarFechaPromesa = new System.Windows.Forms.CheckBox();
            this.chbModificarFechaBaja = new System.Windows.Forms.CheckBox();
            this.chbModificarVendedor = new System.Windows.Forms.CheckBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.lblComentarioSiniestro = new System.Windows.Forms.Label();
            this.txtComentarioSiniestro = new System.Windows.Forms.TextBox();
            this.cbEstadoSiniestro = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.chbModificarEstado = new System.Windows.Forms.CheckBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiasEspera = new System.Windows.Forms.TextBox();
            this.lblDiasEspera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Agregar siniestro?";
            // 
            // lblVehiculoPedido
            // 
            this.lblVehiculoPedido.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoPedido.Location = new System.Drawing.Point(66, 120);
            this.lblVehiculoPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehiculoPedido.Name = "lblVehiculoPedido";
            this.lblVehiculoPedido.Size = new System.Drawing.Size(56, 14);
            this.lblVehiculoPedido.TabIndex = 0;
            this.lblVehiculoPedido.Text = "Vehículo:";
            // 
            // lblAnioPedido
            // 
            this.lblAnioPedido.Location = new System.Drawing.Point(90, 134);
            this.lblAnioPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnioPedido.Name = "lblAnioPedido";
            this.lblAnioPedido.Size = new System.Drawing.Size(34, 14);
            this.lblAnioPedido.TabIndex = 0;
            this.lblAnioPedido.Text = "Año:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(118, 120);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(0, 13);
            this.lblVehiculo.TabIndex = 2;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(118, 134);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(0, 13);
            this.lblAnio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(435, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valuador:";
            // 
            // cbAseguradora
            // 
            this.cbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAseguradora.Enabled = false;
            this.cbAseguradora.FormattingEnabled = true;
            this.cbAseguradora.Location = new System.Drawing.Point(495, 91);
            this.cbAseguradora.Margin = new System.Windows.Forms.Padding(2);
            this.cbAseguradora.Name = "cbAseguradora";
            this.cbAseguradora.Size = new System.Drawing.Size(295, 21);
            this.cbAseguradora.TabIndex = 5;
            this.cbAseguradora.SelectedIndexChanged += new System.EventHandler(this.cbAseguradora_SelectedIndexChanged);
            this.cbAseguradora.Click += new System.EventHandler(this.cbAseguradora_Click);
            // 
            // lblClientePedido
            // 
            this.lblClientePedido.AutoSize = true;
            this.lblClientePedido.ForeColor = System.Drawing.Color.White;
            this.lblClientePedido.Location = new System.Drawing.Point(435, 92);
            this.lblClientePedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientePedido.Name = "lblClientePedido";
            this.lblClientePedido.Size = new System.Drawing.Size(42, 13);
            this.lblClientePedido.TabIndex = 6;
            this.lblClientePedido.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(435, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vendedor:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendedor.Enabled = false;
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(495, 52);
            this.cbVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(295, 21);
            this.cbVendedor.TabIndex = 9;
            this.cbVendedor.SelectedIndexChanged += new System.EventHandler(this.cbVendedor_SelectedIndexChanged);
            this.cbVendedor.Click += new System.EventHandler(this.cbVendedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(910, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de asignación";
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.Enabled = false;
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(1028, 71);
            this.dtpFechaAsignacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaAsignacion.TabIndex = 11;
            this.dtpFechaAsignacion.ValueChanged += new System.EventHandler(this.dtpFechaAsignacion_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(910, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha promesa:";
            // 
            // dtpFechaPromesa
            // 
            this.dtpFechaPromesa.Enabled = false;
            this.dtpFechaPromesa.Location = new System.Drawing.Point(1028, 101);
            this.dtpFechaPromesa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaPromesa.Name = "dtpFechaPromesa";
            this.dtpFechaPromesa.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaPromesa.TabIndex = 13;
            this.dtpFechaPromesa.ValueChanged += new System.EventHandler(this.dtpFechaPromesa_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(435, 195);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Taller:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(435, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Destino:";
            // 
            // cbTaller
            // 
            this.cbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaller.Enabled = false;
            this.cbTaller.FormattingEnabled = true;
            this.cbTaller.Location = new System.Drawing.Point(495, 195);
            this.cbTaller.Margin = new System.Windows.Forms.Padding(2);
            this.cbTaller.Name = "cbTaller";
            this.cbTaller.Size = new System.Drawing.Size(295, 21);
            this.cbTaller.TabIndex = 16;
            this.cbTaller.Click += new System.EventHandler(this.cbTaller_Click);
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.Enabled = false;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(495, 234);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(295, 21);
            this.cbDestino.TabIndex = 17;
            this.cbDestino.Click += new System.EventHandler(this.cbDestino_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(14, 270);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(1310, 167);
            this.dgvPedido.TabIndex = 18;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinalizarPedido.Enabled = false;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(1217, 491);
            this.btnFinalizarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(107, 25);
            this.btnFinalizarPedido.TabIndex = 19;
            this.btnFinalizarPedido.Text = "Finalizar pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Location = new System.Drawing.Point(1140, 491);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 25);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Enabled = false;
            this.rdbNo.ForeColor = System.Drawing.Color.White;
            this.rdbNo.Location = new System.Drawing.Point(167, 82);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 22;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Enabled = false;
            this.rdbSi.ForeColor = System.Drawing.Color.White;
            this.rdbSi.Location = new System.Drawing.Point(121, 82);
            this.rdbSi.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(36, 17);
            this.rdbSi.TabIndex = 23;
            this.rdbSi.Text = "Sí";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // chbSi
            // 
            this.chbSi.AutoSize = true;
            this.chbSi.ForeColor = System.Drawing.Color.White;
            this.chbSi.Location = new System.Drawing.Point(121, 83);
            this.chbSi.Margin = new System.Windows.Forms.Padding(2);
            this.chbSi.Name = "chbSi";
            this.chbSi.Size = new System.Drawing.Size(37, 17);
            this.chbSi.TabIndex = 24;
            this.chbSi.Text = "Sí";
            this.chbSi.UseVisualStyleBackColor = true;
            // 
            // chbOtroValuador
            // 
            this.chbOtroValuador.AutoSize = true;
            this.chbOtroValuador.Enabled = false;
            this.chbOtroValuador.ForeColor = System.Drawing.Color.White;
            this.chbOtroValuador.Location = new System.Drawing.Point(795, 157);
            this.chbOtroValuador.Margin = new System.Windows.Forms.Padding(2);
            this.chbOtroValuador.Name = "chbOtroValuador";
            this.chbOtroValuador.Size = new System.Drawing.Size(46, 17);
            this.chbOtroValuador.TabIndex = 25;
            this.chbOtroValuador.Text = "Otro";
            this.chbOtroValuador.UseVisualStyleBackColor = true;
            this.chbOtroValuador.CheckedChanged += new System.EventHandler(this.chbOtroValuador_CheckedChanged);
            // 
            // txtValuador
            // 
            this.txtValuador.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtValuador.Location = new System.Drawing.Point(494, 155);
            this.txtValuador.Margin = new System.Windows.Forms.Padding(2);
            this.txtValuador.Name = "txtValuador";
            this.txtValuador.Size = new System.Drawing.Size(297, 20);
            this.txtValuador.TabIndex = 26;
            this.txtValuador.Text = "Escriba nombre del valuador";
            this.txtValuador.Click += new System.EventHandler(this.txtValuador_Click);
            // 
            // cbValuador
            // 
            this.cbValuador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValuador.Enabled = false;
            this.cbValuador.FormattingEnabled = true;
            this.cbValuador.Location = new System.Drawing.Point(494, 155);
            this.cbValuador.Margin = new System.Windows.Forms.Padding(2);
            this.cbValuador.Name = "cbValuador";
            this.cbValuador.Size = new System.Drawing.Size(296, 21);
            this.cbValuador.TabIndex = 27;
            this.cbValuador.Click += new System.EventHandler(this.cbValuador_Click);
            // 
            // txtAseguradora
            // 
            this.txtAseguradora.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAseguradora.Location = new System.Drawing.Point(495, 91);
            this.txtAseguradora.Margin = new System.Windows.Forms.Padding(2);
            this.txtAseguradora.Name = "txtAseguradora";
            this.txtAseguradora.Size = new System.Drawing.Size(295, 20);
            this.txtAseguradora.TabIndex = 28;
            this.txtAseguradora.Text = "Escriba el nombre del cliente";
            this.txtAseguradora.Click += new System.EventHandler(this.txtAseguradora_Click);
            // 
            // chbOtraAseguradora
            // 
            this.chbOtraAseguradora.AutoSize = true;
            this.chbOtraAseguradora.Enabled = false;
            this.chbOtraAseguradora.ForeColor = System.Drawing.Color.White;
            this.chbOtraAseguradora.Location = new System.Drawing.Point(795, 94);
            this.chbOtraAseguradora.Margin = new System.Windows.Forms.Padding(2);
            this.chbOtraAseguradora.Name = "chbOtraAseguradora";
            this.chbOtraAseguradora.Size = new System.Drawing.Size(46, 17);
            this.chbOtraAseguradora.TabIndex = 29;
            this.chbOtraAseguradora.Text = "Otro";
            this.chbOtraAseguradora.UseVisualStyleBackColor = true;
            this.chbOtraAseguradora.CheckedChanged += new System.EventHandler(this.chbOtraAseguradora_CheckedChanged);
            // 
            // lblClaveSiniestroPedido
            // 
            this.lblClaveSiniestroPedido.AutoSize = true;
            this.lblClaveSiniestroPedido.ForeColor = System.Drawing.Color.White;
            this.lblClaveSiniestroPedido.Location = new System.Drawing.Point(40, 107);
            this.lblClaveSiniestroPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveSiniestroPedido.Name = "lblClaveSiniestroPedido";
            this.lblClaveSiniestroPedido.Size = new System.Drawing.Size(78, 13);
            this.lblClaveSiniestroPedido.TabIndex = 30;
            this.lblClaveSiniestroPedido.Text = "Clave siniestro:";
            // 
            // lblClaveSiniestro
            // 
            this.lblClaveSiniestro.AutoSize = true;
            this.lblClaveSiniestro.Location = new System.Drawing.Point(120, 107);
            this.lblClaveSiniestro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveSiniestro.Name = "lblClaveSiniestro";
            this.lblClaveSiniestro.Size = new System.Drawing.Size(0, 13);
            this.lblClaveSiniestro.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Clave pedido:";
            // 
            // txtClavePedido
            // 
            this.txtClavePedido.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtClavePedido.Location = new System.Drawing.Point(119, 48);
            this.txtClavePedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtClavePedido.Name = "txtClavePedido";
            this.txtClavePedido.Size = new System.Drawing.Size(232, 20);
            this.txtClavePedido.TabIndex = 33;
            this.txtClavePedido.Text = "Escriba una clave";
            this.txtClavePedido.Click += new System.EventHandler(this.txtClavePedido_Click);
            this.txtClavePedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClavePedido_KeyPress);
            // 
            // chbOtroTaller
            // 
            this.chbOtroTaller.AutoSize = true;
            this.chbOtroTaller.Enabled = false;
            this.chbOtroTaller.ForeColor = System.Drawing.Color.White;
            this.chbOtroTaller.Location = new System.Drawing.Point(795, 197);
            this.chbOtroTaller.Margin = new System.Windows.Forms.Padding(2);
            this.chbOtroTaller.Name = "chbOtroTaller";
            this.chbOtroTaller.Size = new System.Drawing.Size(46, 17);
            this.chbOtroTaller.TabIndex = 34;
            this.chbOtroTaller.Text = "Otro";
            this.chbOtroTaller.UseVisualStyleBackColor = true;
            this.chbOtroTaller.CheckedChanged += new System.EventHandler(this.chbOtroTaller_CheckedChanged);
            // 
            // chbOtroDestino
            // 
            this.chbOtroDestino.AutoSize = true;
            this.chbOtroDestino.Enabled = false;
            this.chbOtroDestino.ForeColor = System.Drawing.Color.White;
            this.chbOtroDestino.Location = new System.Drawing.Point(795, 236);
            this.chbOtroDestino.Margin = new System.Windows.Forms.Padding(2);
            this.chbOtroDestino.Name = "chbOtroDestino";
            this.chbOtroDestino.Size = new System.Drawing.Size(46, 17);
            this.chbOtroDestino.TabIndex = 35;
            this.chbOtroDestino.Text = "Otro";
            this.chbOtroDestino.UseVisualStyleBackColor = true;
            this.chbOtroDestino.CheckedChanged += new System.EventHandler(this.chbOtroDestino_CheckedChanged);
            // 
            // txtTaller
            // 
            this.txtTaller.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTaller.Location = new System.Drawing.Point(494, 195);
            this.txtTaller.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaller.Name = "txtTaller";
            this.txtTaller.Size = new System.Drawing.Size(297, 20);
            this.txtTaller.TabIndex = 36;
            this.txtTaller.Text = "Escriba nombre de taller";
            this.txtTaller.Click += new System.EventHandler(this.txtTaller_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDestino.Location = new System.Drawing.Point(494, 234);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(297, 20);
            this.txtDestino.TabIndex = 37;
            this.txtDestino.Text = "Escriba el destino";
            this.txtDestino.Click += new System.EventHandler(this.txtDestino_Click);
            // 
            // btnAgregarPieza
            // 
            this.btnAgregarPieza.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarPieza.Location = new System.Drawing.Point(14, 445);
            this.btnAgregarPieza.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPieza.Name = "btnAgregarPieza";
            this.btnAgregarPieza.Size = new System.Drawing.Size(100, 25);
            this.btnAgregarPieza.TabIndex = 38;
            this.btnAgregarPieza.Text = "Agregar pieza";
            this.btnAgregarPieza.UseVisualStyleBackColor = false;
            this.btnAgregarPieza.Click += new System.EventHandler(this.btnAgregarPieza_Click);
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.ForeColor = System.Drawing.Color.White;
            this.lblFechaBaja.Location = new System.Drawing.Point(910, 141);
            this.lblFechaBaja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(78, 13);
            this.lblFechaBaja.TabIndex = 39;
            this.lblFechaBaja.Text = "Fecha de baja:";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Enabled = false;
            this.dtpFechaBaja.Location = new System.Drawing.Point(1028, 135);
            this.dtpFechaBaja.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaBaja.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1188, 451);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1233, 439);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Piezas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1275, 439);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Precio";
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(1233, 451);
            this.lblCantidadTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadTotal.TabIndex = 44;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(1275, 451);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioTotal.TabIndex = 45;
            // 
            // chbModificarFechaAsignacion
            // 
            this.chbModificarFechaAsignacion.AutoSize = true;
            this.chbModificarFechaAsignacion.ForeColor = System.Drawing.Color.White;
            this.chbModificarFechaAsignacion.Location = new System.Drawing.Point(1255, 73);
            this.chbModificarFechaAsignacion.Margin = new System.Windows.Forms.Padding(2);
            this.chbModificarFechaAsignacion.Name = "chbModificarFechaAsignacion";
            this.chbModificarFechaAsignacion.Size = new System.Drawing.Size(69, 17);
            this.chbModificarFechaAsignacion.TabIndex = 46;
            this.chbModificarFechaAsignacion.Text = "Modificar";
            this.chbModificarFechaAsignacion.UseVisualStyleBackColor = true;
            this.chbModificarFechaAsignacion.Visible = false;
            this.chbModificarFechaAsignacion.CheckedChanged += new System.EventHandler(this.chbModificarFechaAsignacion_CheckedChanged);
            // 
            // chbModificarFechaPromesa
            // 
            this.chbModificarFechaPromesa.AutoSize = true;
            this.chbModificarFechaPromesa.ForeColor = System.Drawing.Color.White;
            this.chbModificarFechaPromesa.Location = new System.Drawing.Point(1255, 103);
            this.chbModificarFechaPromesa.Margin = new System.Windows.Forms.Padding(2);
            this.chbModificarFechaPromesa.Name = "chbModificarFechaPromesa";
            this.chbModificarFechaPromesa.Size = new System.Drawing.Size(69, 17);
            this.chbModificarFechaPromesa.TabIndex = 47;
            this.chbModificarFechaPromesa.Text = "Modificar";
            this.chbModificarFechaPromesa.UseVisualStyleBackColor = true;
            this.chbModificarFechaPromesa.Visible = false;
            this.chbModificarFechaPromesa.CheckedChanged += new System.EventHandler(this.chbModificarFechaPromesa_CheckedChanged);
            // 
            // chbModificarFechaBaja
            // 
            this.chbModificarFechaBaja.AutoSize = true;
            this.chbModificarFechaBaja.ForeColor = System.Drawing.Color.White;
            this.chbModificarFechaBaja.Location = new System.Drawing.Point(1255, 137);
            this.chbModificarFechaBaja.Margin = new System.Windows.Forms.Padding(2);
            this.chbModificarFechaBaja.Name = "chbModificarFechaBaja";
            this.chbModificarFechaBaja.Size = new System.Drawing.Size(69, 17);
            this.chbModificarFechaBaja.TabIndex = 48;
            this.chbModificarFechaBaja.Text = "Modificar";
            this.chbModificarFechaBaja.UseVisualStyleBackColor = true;
            this.chbModificarFechaBaja.Visible = false;
            // 
            // chbModificarVendedor
            // 
            this.chbModificarVendedor.AutoSize = true;
            this.chbModificarVendedor.ForeColor = System.Drawing.Color.White;
            this.chbModificarVendedor.Location = new System.Drawing.Point(795, 54);
            this.chbModificarVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.chbModificarVendedor.Name = "chbModificarVendedor";
            this.chbModificarVendedor.Size = new System.Drawing.Size(69, 17);
            this.chbModificarVendedor.TabIndex = 49;
            this.chbModificarVendedor.Text = "Modificar";
            this.chbModificarVendedor.UseVisualStyleBackColor = true;
            this.chbModificarVendedor.Visible = false;
            this.chbModificarVendedor.CheckedChanged += new System.EventHandler(this.chbModificarVendedor_CheckedChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(495, 52);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(296, 20);
            this.txtVendedor.TabIndex = 50;
            this.txtVendedor.Visible = false;
            // 
            // lblComentarioSiniestro
            // 
            this.lblComentarioSiniestro.AutoSize = true;
            this.lblComentarioSiniestro.ForeColor = System.Drawing.Color.White;
            this.lblComentarioSiniestro.Location = new System.Drawing.Point(47, 197);
            this.lblComentarioSiniestro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComentarioSiniestro.Name = "lblComentarioSiniestro";
            this.lblComentarioSiniestro.Size = new System.Drawing.Size(63, 13);
            this.lblComentarioSiniestro.TabIndex = 51;
            this.lblComentarioSiniestro.Text = "Comentario:";
            this.lblComentarioSiniestro.Visible = false;
            // 
            // txtComentarioSiniestro
            // 
            this.txtComentarioSiniestro.Location = new System.Drawing.Point(120, 194);
            this.txtComentarioSiniestro.Margin = new System.Windows.Forms.Padding(2);
            this.txtComentarioSiniestro.Multiline = true;
            this.txtComentarioSiniestro.Name = "txtComentarioSiniestro";
            this.txtComentarioSiniestro.Size = new System.Drawing.Size(231, 48);
            this.txtComentarioSiniestro.TabIndex = 52;
            this.txtComentarioSiniestro.Visible = false;
            // 
            // cbEstadoSiniestro
            // 
            this.cbEstadoSiniestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoSiniestro.FormattingEnabled = true;
            this.cbEstadoSiniestro.Location = new System.Drawing.Point(121, 164);
            this.cbEstadoSiniestro.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstadoSiniestro.Name = "cbEstadoSiniestro";
            this.cbEstadoSiniestro.Size = new System.Drawing.Size(230, 21);
            this.cbEstadoSiniestro.TabIndex = 53;
            this.cbEstadoSiniestro.Click += new System.EventHandler(this.cbEstadoSiniestro_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(48, 167);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 54;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(121, 164);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(230, 20);
            this.txtEstado.TabIndex = 55;
            // 
            // chbModificarEstado
            // 
            this.chbModificarEstado.AutoSize = true;
            this.chbModificarEstado.ForeColor = System.Drawing.Color.White;
            this.chbModificarEstado.Location = new System.Drawing.Point(355, 166);
            this.chbModificarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.chbModificarEstado.Name = "chbModificarEstado";
            this.chbModificarEstado.Size = new System.Drawing.Size(69, 17);
            this.chbModificarEstado.TabIndex = 56;
            this.chbModificarEstado.Text = "Modificar";
            this.chbModificarEstado.UseVisualStyleBackColor = true;
            this.chbModificarEstado.CheckedChanged += new System.EventHandler(this.chbModificarEstado_CheckedChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 43);
            this.panel1.TabIndex = 57;
            // 
            // txtDiasEspera
            // 
            this.txtDiasEspera.Location = new System.Drawing.Point(726, 117);
            this.txtDiasEspera.Name = "txtDiasEspera";
            this.txtDiasEspera.Size = new System.Drawing.Size(64, 20);
            this.txtDiasEspera.TabIndex = 58;
            this.txtDiasEspera.Visible = false;
            // 
            // lblDiasEspera
            // 
            this.lblDiasEspera.AutoSize = true;
            this.lblDiasEspera.ForeColor = System.Drawing.Color.White;
            this.lblDiasEspera.Location = new System.Drawing.Point(653, 120);
            this.lblDiasEspera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiasEspera.Name = "lblDiasEspera";
            this.lblDiasEspera.Size = new System.Drawing.Size(68, 13);
            this.lblDiasEspera.TabIndex = 59;
            this.lblDiasEspera.Text = "Días espera:";
            this.lblDiasEspera.Visible = false;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1346, 527);
            this.Controls.Add(this.lblDiasEspera);
            this.Controls.Add(this.txtDiasEspera);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtValuador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chbModificarEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstadoSiniestro);
            this.Controls.Add(this.txtComentarioSiniestro);
            this.Controls.Add(this.lblComentarioSiniestro);
            this.Controls.Add(this.chbModificarVendedor);
            this.Controls.Add(this.chbModificarFechaBaja);
            this.Controls.Add(this.chbModificarFechaPromesa);
            this.Controls.Add(this.chbModificarFechaAsignacion);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.lblFechaBaja);
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
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblFechaBaja;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.CheckBox chbModificarFechaAsignacion;
        private System.Windows.Forms.CheckBox chbModificarFechaPromesa;
        private System.Windows.Forms.CheckBox chbModificarFechaBaja;
        private System.Windows.Forms.CheckBox chbModificarVendedor;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label lblComentarioSiniestro;
        private System.Windows.Forms.TextBox txtComentarioSiniestro;
        private System.Windows.Forms.ComboBox cbEstadoSiniestro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.CheckBox chbModificarEstado;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDiasEspera;
        private System.Windows.Forms.TextBox txtDiasEspera;
    }
}