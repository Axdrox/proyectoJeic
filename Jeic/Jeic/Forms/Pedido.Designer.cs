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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
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
            this.txtDiasEspera = new System.Windows.Forms.TextBox();
            this.lblDiasEspera = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaPedido = new System.Windows.Forms.Label();
            this.moverTop = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Agregar siniestro?";
            // 
            // lblVehiculoPedido
            // 
            this.lblVehiculoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lblVehiculoPedido.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoPedido.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoPedido.Location = new System.Drawing.Point(79, 166);
            this.lblVehiculoPedido.Name = "lblVehiculoPedido";
            this.lblVehiculoPedido.Size = new System.Drawing.Size(68, 20);
            this.lblVehiculoPedido.TabIndex = 0;
            this.lblVehiculoPedido.Text = "Modelo:";
            // 
            // lblAnioPedido
            // 
            this.lblAnioPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.lblAnioPedido.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioPedido.Location = new System.Drawing.Point(102, 197);
            this.lblAnioPedido.Name = "lblAnioPedido";
            this.lblAnioPedido.Size = new System.Drawing.Size(45, 17);
            this.lblAnioPedido.TabIndex = 0;
            this.lblAnioPedido.Text = "Año:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lblVehiculo.Location = new System.Drawing.Point(167, 169);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(0, 17);
            this.lblVehiculo.TabIndex = 2;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.lblAnio.Location = new System.Drawing.Point(167, 200);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(0, 17);
            this.lblAnio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label4.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(580, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valuador:";
            // 
            // cbAseguradora
            // 
            this.cbAseguradora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbAseguradora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAseguradora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAseguradora.Enabled = false;
            this.cbAseguradora.ForeColor = System.Drawing.Color.White;
            this.cbAseguradora.FormattingEnabled = true;
            this.cbAseguradora.Location = new System.Drawing.Point(663, 81);
            this.cbAseguradora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAseguradora.Name = "cbAseguradora";
            this.cbAseguradora.Size = new System.Drawing.Size(392, 24);
            this.cbAseguradora.TabIndex = 5;
            this.cbAseguradora.SelectedIndexChanged += new System.EventHandler(this.cbAseguradora_SelectedIndexChanged);
            this.cbAseguradora.Click += new System.EventHandler(this.cbAseguradora_Click);
            // 
            // lblClientePedido
            // 
            this.lblClientePedido.AutoSize = true;
            this.lblClientePedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.lblClientePedido.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientePedido.ForeColor = System.Drawing.Color.White;
            this.lblClientePedido.Location = new System.Drawing.Point(580, 113);
            this.lblClientePedido.Name = "lblClientePedido";
            this.lblClientePedido.Size = new System.Drawing.Size(61, 23);
            this.lblClientePedido.TabIndex = 6;
            this.lblClientePedido.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.label6.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(580, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vendedor:";
            // 
            // cbVendedor
            // 
            this.cbVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendedor.Enabled = false;
            this.cbVendedor.ForeColor = System.Drawing.Color.White;
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(663, 36);
            this.cbVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(392, 24);
            this.cbVendedor.TabIndex = 9;
            this.cbVendedor.SelectedIndexChanged += new System.EventHandler(this.cbVendedor_SelectedIndexChanged);
            this.cbVendedor.Click += new System.EventHandler(this.cbVendedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.label7.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1213, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de asignación";
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaAsignacion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dtpFechaAsignacion.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFechaAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaAsignacion.Enabled = false;
            this.dtpFechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(1371, 87);
            this.dtpFechaAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaAsignacion.TabIndex = 11;
            this.dtpFechaAsignacion.ValueChanged += new System.EventHandler(this.dtpFechaAsignacion_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.label8.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1213, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha promesa:";
            // 
            // dtpFechaPromesa
            // 
            this.dtpFechaPromesa.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaPromesa.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dtpFechaPromesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaPromesa.Enabled = false;
            this.dtpFechaPromesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPromesa.Location = new System.Drawing.Point(1371, 124);
            this.dtpFechaPromesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaPromesa.Name = "dtpFechaPromesa";
            this.dtpFechaPromesa.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaPromesa.TabIndex = 13;
            this.dtpFechaPromesa.ValueChanged += new System.EventHandler(this.dtpFechaPromesa_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.label9.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(580, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Taller:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.label10.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(580, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Destino:";
            // 
            // cbTaller
            // 
            this.cbTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaller.Enabled = false;
            this.cbTaller.ForeColor = System.Drawing.Color.White;
            this.cbTaller.FormattingEnabled = true;
            this.cbTaller.Location = new System.Drawing.Point(663, 208);
            this.cbTaller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTaller.Name = "cbTaller";
            this.cbTaller.Size = new System.Drawing.Size(392, 24);
            this.cbTaller.TabIndex = 16;
            this.cbTaller.Click += new System.EventHandler(this.cbTaller_Click);
            // 
            // cbDestino
            // 
            this.cbDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.Enabled = false;
            this.cbDestino.ForeColor = System.Drawing.Color.White;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(663, 256);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(392, 24);
            this.cbDestino.TabIndex = 17;
            this.cbDestino.Click += new System.EventHandler(this.cbDestino_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido.ColumnHeadersHeight = 30;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dgvPedido.Location = new System.Drawing.Point(159, 327);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(1424, 206);
            this.dgvPedido.TabIndex = 18;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedido_CellClick);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinalizarPedido.Enabled = false;
            this.btnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Location = new System.Drawing.Point(1623, 604);
            this.btnFinalizarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(143, 31);
            this.btnFinalizarPedido.TabIndex = 19;
            this.btnFinalizarPedido.Text = "Finalizar pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1520, 604);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.rdbNo.Enabled = false;
            this.rdbNo.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.ForeColor = System.Drawing.Color.White;
            this.rdbNo.Location = new System.Drawing.Point(242, 101);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(49, 27);
            this.rdbNo.TabIndex = 22;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = false;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.rdbSi.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSi.Enabled = false;
            this.rdbSi.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSi.ForeColor = System.Drawing.Color.White;
            this.rdbSi.Location = new System.Drawing.Point(178, 101);
            this.rdbSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(42, 27);
            this.rdbSi.TabIndex = 23;
            this.rdbSi.Text = "Sí";
            this.rdbSi.UseVisualStyleBackColor = false;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // chbSi
            // 
            this.chbSi.AutoSize = true;
            this.chbSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.chbSi.ForeColor = System.Drawing.Color.White;
            this.chbSi.Location = new System.Drawing.Point(180, 74);
            this.chbSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSi.Name = "chbSi";
            this.chbSi.Size = new System.Drawing.Size(42, 21);
            this.chbSi.TabIndex = 24;
            this.chbSi.Text = "Sí";
            this.chbSi.UseVisualStyleBackColor = false;
            // 
            // chbOtroValuador
            // 
            this.chbOtroValuador.AutoSize = true;
            this.chbOtroValuador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.chbOtroValuador.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbOtroValuador.Enabled = false;
            this.chbOtroValuador.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOtroValuador.ForeColor = System.Drawing.Color.White;
            this.chbOtroValuador.Location = new System.Drawing.Point(1060, 193);
            this.chbOtroValuador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroValuador.Name = "chbOtroValuador";
            this.chbOtroValuador.Size = new System.Drawing.Size(62, 27);
            this.chbOtroValuador.TabIndex = 25;
            this.chbOtroValuador.Text = "Otro";
            this.chbOtroValuador.UseVisualStyleBackColor = false;
            this.chbOtroValuador.CheckedChanged += new System.EventHandler(this.chbOtroValuador_CheckedChanged);
            // 
            // txtValuador
            // 
            this.txtValuador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtValuador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValuador.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtValuador.Location = new System.Drawing.Point(661, 164);
            this.txtValuador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValuador.Name = "txtValuador";
            this.txtValuador.Size = new System.Drawing.Size(395, 22);
            this.txtValuador.TabIndex = 26;
            this.txtValuador.Text = "Escriba nombre del valuador";
            this.txtValuador.Click += new System.EventHandler(this.txtValuador_Click);
            this.txtValuador.Leave += new System.EventHandler(this.txtValuador_Leave);
            // 
            // cbValuador
            // 
            this.cbValuador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbValuador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbValuador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValuador.Enabled = false;
            this.cbValuador.ForeColor = System.Drawing.Color.White;
            this.cbValuador.FormattingEnabled = true;
            this.cbValuador.Location = new System.Drawing.Point(663, 162);
            this.cbValuador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbValuador.Name = "cbValuador";
            this.cbValuador.Size = new System.Drawing.Size(392, 24);
            this.cbValuador.TabIndex = 27;
            this.cbValuador.Click += new System.EventHandler(this.cbValuador_Click);
            // 
            // txtAseguradora
            // 
            this.txtAseguradora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtAseguradora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAseguradora.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAseguradora.Location = new System.Drawing.Point(663, 82);
            this.txtAseguradora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAseguradora.Name = "txtAseguradora";
            this.txtAseguradora.Size = new System.Drawing.Size(394, 22);
            this.txtAseguradora.TabIndex = 28;
            this.txtAseguradora.Text = "Escriba el nombre del cliente";
            this.txtAseguradora.Click += new System.EventHandler(this.txtAseguradora_Click);
            this.txtAseguradora.Leave += new System.EventHandler(this.txtAseguradora_Leave);
            // 
            // chbOtraAseguradora
            // 
            this.chbOtraAseguradora.AutoSize = true;
            this.chbOtraAseguradora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.chbOtraAseguradora.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbOtraAseguradora.Enabled = false;
            this.chbOtraAseguradora.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOtraAseguradora.ForeColor = System.Drawing.Color.White;
            this.chbOtraAseguradora.Location = new System.Drawing.Point(1060, 111);
            this.chbOtraAseguradora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtraAseguradora.Name = "chbOtraAseguradora";
            this.chbOtraAseguradora.Size = new System.Drawing.Size(62, 27);
            this.chbOtraAseguradora.TabIndex = 29;
            this.chbOtraAseguradora.Text = "Otro";
            this.chbOtraAseguradora.UseVisualStyleBackColor = false;
            this.chbOtraAseguradora.CheckedChanged += new System.EventHandler(this.chbOtraAseguradora_CheckedChanged);
            // 
            // lblClaveSiniestroPedido
            // 
            this.lblClaveSiniestroPedido.AutoSize = true;
            this.lblClaveSiniestroPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.lblClaveSiniestroPedido.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveSiniestroPedido.ForeColor = System.Drawing.Color.White;
            this.lblClaveSiniestroPedido.Location = new System.Drawing.Point(39, 132);
            this.lblClaveSiniestroPedido.Name = "lblClaveSiniestroPedido";
            this.lblClaveSiniestroPedido.Size = new System.Drawing.Size(113, 23);
            this.lblClaveSiniestroPedido.TabIndex = 30;
            this.lblClaveSiniestroPedido.Text = "Clave siniestro:";
            // 
            // lblClaveSiniestro
            // 
            this.lblClaveSiniestro.AutoSize = true;
            this.lblClaveSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.lblClaveSiniestro.Location = new System.Drawing.Point(167, 107);
            this.lblClaveSiniestro.Name = "lblClaveSiniestro";
            this.lblClaveSiniestro.Size = new System.Drawing.Size(0, 17);
            this.lblClaveSiniestro.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Clave pedido:";
            // 
            // txtClavePedido
            // 
            this.txtClavePedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtClavePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClavePedido.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtClavePedido.Location = new System.Drawing.Point(159, 59);
            this.txtClavePedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClavePedido.Name = "txtClavePedido";
            this.txtClavePedido.Size = new System.Drawing.Size(309, 22);
            this.txtClavePedido.TabIndex = 33;
            this.txtClavePedido.Text = "Escriba una clave";
            this.txtClavePedido.Click += new System.EventHandler(this.txtClavePedido_Click);
            this.txtClavePedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClavePedido_KeyPress);
            this.txtClavePedido.Leave += new System.EventHandler(this.txtClavePedido_Leave);
            // 
            // chbOtroTaller
            // 
            this.chbOtroTaller.AutoSize = true;
            this.chbOtroTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.chbOtroTaller.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbOtroTaller.Enabled = false;
            this.chbOtroTaller.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOtroTaller.ForeColor = System.Drawing.Color.White;
            this.chbOtroTaller.Location = new System.Drawing.Point(1060, 239);
            this.chbOtroTaller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroTaller.Name = "chbOtroTaller";
            this.chbOtroTaller.Size = new System.Drawing.Size(62, 27);
            this.chbOtroTaller.TabIndex = 34;
            this.chbOtroTaller.Text = "Otro";
            this.chbOtroTaller.UseVisualStyleBackColor = false;
            this.chbOtroTaller.CheckedChanged += new System.EventHandler(this.chbOtroTaller_CheckedChanged);
            // 
            // chbOtroDestino
            // 
            this.chbOtroDestino.AutoSize = true;
            this.chbOtroDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(76)))));
            this.chbOtroDestino.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbOtroDestino.Enabled = false;
            this.chbOtroDestino.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOtroDestino.ForeColor = System.Drawing.Color.White;
            this.chbOtroDestino.Location = new System.Drawing.Point(1060, 287);
            this.chbOtroDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroDestino.Name = "chbOtroDestino";
            this.chbOtroDestino.Size = new System.Drawing.Size(62, 27);
            this.chbOtroDestino.TabIndex = 35;
            this.chbOtroDestino.Text = "Otro";
            this.chbOtroDestino.UseVisualStyleBackColor = false;
            this.chbOtroDestino.CheckedChanged += new System.EventHandler(this.chbOtroDestino_CheckedChanged);
            // 
            // txtTaller
            // 
            this.txtTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtTaller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaller.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTaller.Location = new System.Drawing.Point(663, 209);
            this.txtTaller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaller.Name = "txtTaller";
            this.txtTaller.Size = new System.Drawing.Size(393, 22);
            this.txtTaller.TabIndex = 36;
            this.txtTaller.Text = "Escriba nombre de taller";
            this.txtTaller.Click += new System.EventHandler(this.txtTaller_Click);
            this.txtTaller.Leave += new System.EventHandler(this.txtTaller_Leave);
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestino.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDestino.Location = new System.Drawing.Point(663, 257);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(394, 22);
            this.txtDestino.TabIndex = 37;
            this.txtDestino.Text = "Escriba el destino";
            this.txtDestino.Click += new System.EventHandler(this.txtDestino_Click);
            this.txtDestino.Leave += new System.EventHandler(this.txtDestino_Leave);
            // 
            // btnAgregarPieza
            // 
            this.btnAgregarPieza.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarPieza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPieza.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPieza.Location = new System.Drawing.Point(165, 545);
            this.btnAgregarPieza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarPieza.Name = "btnAgregarPieza";
            this.btnAgregarPieza.Size = new System.Drawing.Size(133, 31);
            this.btnAgregarPieza.TabIndex = 38;
            this.btnAgregarPieza.Text = "Agregar pieza";
            this.btnAgregarPieza.UseVisualStyleBackColor = false;
            this.btnAgregarPieza.Click += new System.EventHandler(this.btnAgregarPieza_Click);
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.lblFechaBaja.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaBaja.ForeColor = System.Drawing.Color.White;
            this.lblFechaBaja.Location = new System.Drawing.Point(1213, 174);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(110, 23);
            this.lblFechaBaja.TabIndex = 39;
            this.lblFechaBaja.Text = "Fecha de baja:";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaBaja.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dtpFechaBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaBaja.Enabled = false;
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaBaja.Location = new System.Drawing.Point(1371, 166);
            this.dtpFechaBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaBaja.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1371, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1431, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Piezas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1487, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Precio";
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(1644, 555);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(0, 17);
            this.lblCantidadTotal.TabIndex = 44;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(1700, 555);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 17);
            this.lblPrecioTotal.TabIndex = 45;
            // 
            // chbModificarFechaAsignacion
            // 
            this.chbModificarFechaAsignacion.AutoSize = true;
            this.chbModificarFechaAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.chbModificarFechaAsignacion.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbModificarFechaAsignacion.ForeColor = System.Drawing.Color.White;
            this.chbModificarFechaAsignacion.Location = new System.Drawing.Point(1533, 62);
            this.chbModificarFechaAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbModificarFechaAsignacion.Name = "chbModificarFechaAsignacion";
            this.chbModificarFechaAsignacion.Size = new System.Drawing.Size(95, 27);
            this.chbModificarFechaAsignacion.TabIndex = 46;
            this.chbModificarFechaAsignacion.Text = "Modificar";
            this.chbModificarFechaAsignacion.UseVisualStyleBackColor = false;
            this.chbModificarFechaAsignacion.Visible = false;
            this.chbModificarFechaAsignacion.CheckedChanged += new System.EventHandler(this.chbModificarFechaAsignacion_CheckedChanged);
            // 
            // chbModificarFechaPromesa
            // 
            this.chbModificarFechaPromesa.AutoSize = true;
            this.chbModificarFechaPromesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.chbModificarFechaPromesa.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbModificarFechaPromesa.ForeColor = System.Drawing.Color.White;
            this.chbModificarFechaPromesa.Location = new System.Drawing.Point(1533, 98);
            this.chbModificarFechaPromesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbModificarFechaPromesa.Name = "chbModificarFechaPromesa";
            this.chbModificarFechaPromesa.Size = new System.Drawing.Size(95, 27);
            this.chbModificarFechaPromesa.TabIndex = 47;
            this.chbModificarFechaPromesa.Text = "Modificar";
            this.chbModificarFechaPromesa.UseVisualStyleBackColor = false;
            this.chbModificarFechaPromesa.Visible = false;
            this.chbModificarFechaPromesa.CheckedChanged += new System.EventHandler(this.chbModificarFechaPromesa_CheckedChanged);
            // 
            // chbModificarFechaBaja
            // 
            this.chbModificarFechaBaja.AutoSize = true;
            this.chbModificarFechaBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.chbModificarFechaBaja.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbModificarFechaBaja.ForeColor = System.Drawing.Color.White;
            this.chbModificarFechaBaja.Location = new System.Drawing.Point(1533, 140);
            this.chbModificarFechaBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbModificarFechaBaja.Name = "chbModificarFechaBaja";
            this.chbModificarFechaBaja.Size = new System.Drawing.Size(95, 27);
            this.chbModificarFechaBaja.TabIndex = 48;
            this.chbModificarFechaBaja.Text = "Modificar";
            this.chbModificarFechaBaja.UseVisualStyleBackColor = false;
            this.chbModificarFechaBaja.Visible = false;
            // 
            // chbModificarVendedor
            // 
            this.chbModificarVendedor.AutoSize = true;
            this.chbModificarVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.chbModificarVendedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbModificarVendedor.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbModificarVendedor.ForeColor = System.Drawing.Color.White;
            this.chbModificarVendedor.Location = new System.Drawing.Point(1060, 66);
            this.chbModificarVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbModificarVendedor.Name = "chbModificarVendedor";
            this.chbModificarVendedor.Size = new System.Drawing.Size(95, 27);
            this.chbModificarVendedor.TabIndex = 49;
            this.chbModificarVendedor.Text = "Modificar";
            this.chbModificarVendedor.UseVisualStyleBackColor = false;
            this.chbModificarVendedor.Visible = false;
            this.chbModificarVendedor.CheckedChanged += new System.EventHandler(this.chbModificarVendedor_CheckedChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendedor.Enabled = false;
            this.txtVendedor.ForeColor = System.Drawing.Color.White;
            this.txtVendedor.Location = new System.Drawing.Point(663, 37);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(394, 22);
            this.txtVendedor.TabIndex = 50;
            this.txtVendedor.Visible = false;
            // 
            // lblComentarioSiniestro
            // 
            this.lblComentarioSiniestro.AutoSize = true;
            this.lblComentarioSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.lblComentarioSiniestro.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarioSiniestro.ForeColor = System.Drawing.Color.White;
            this.lblComentarioSiniestro.Location = new System.Drawing.Point(69, 268);
            this.lblComentarioSiniestro.Name = "lblComentarioSiniestro";
            this.lblComentarioSiniestro.Size = new System.Drawing.Size(96, 23);
            this.lblComentarioSiniestro.TabIndex = 51;
            this.lblComentarioSiniestro.Text = "Comentario:";
            this.lblComentarioSiniestro.Visible = false;
            // 
            // txtComentarioSiniestro
            // 
            this.txtComentarioSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtComentarioSiniestro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentarioSiniestro.ForeColor = System.Drawing.Color.DarkGray;
            this.txtComentarioSiniestro.Location = new System.Drawing.Point(166, 265);
            this.txtComentarioSiniestro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentarioSiniestro.Multiline = true;
            this.txtComentarioSiniestro.Name = "txtComentarioSiniestro";
            this.txtComentarioSiniestro.Size = new System.Drawing.Size(307, 59);
            this.txtComentarioSiniestro.TabIndex = 52;
            this.txtComentarioSiniestro.Text = "Agregue un comentario";
            this.txtComentarioSiniestro.Visible = false;
            this.txtComentarioSiniestro.Click += new System.EventHandler(this.txtComentarioSiniestro_Click);
            this.txtComentarioSiniestro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComentarioSiniestro_KeyPress);
            this.txtComentarioSiniestro.Leave += new System.EventHandler(this.txtComentarioSiniestro_Leave);
            // 
            // cbEstadoSiniestro
            // 
            this.cbEstadoSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbEstadoSiniestro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstadoSiniestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoSiniestro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEstadoSiniestro.ForeColor = System.Drawing.Color.White;
            this.cbEstadoSiniestro.FormattingEnabled = true;
            this.cbEstadoSiniestro.Location = new System.Drawing.Point(166, 227);
            this.cbEstadoSiniestro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoSiniestro.Name = "cbEstadoSiniestro";
            this.cbEstadoSiniestro.Size = new System.Drawing.Size(308, 24);
            this.cbEstadoSiniestro.TabIndex = 53;
            this.cbEstadoSiniestro.Click += new System.EventHandler(this.cbEstadoSiniestro_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.lblEstado.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(70, 232);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 23);
            this.lblEstado.TabIndex = 54;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Enabled = false;
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(164, 229);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(309, 22);
            this.txtEstado.TabIndex = 55;
            // 
            // chbModificarEstado
            // 
            this.chbModificarEstado.AutoSize = true;
            this.chbModificarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chbModificarEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.chbModificarEstado.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbModificarEstado.ForeColor = System.Drawing.Color.White;
            this.chbModificarEstado.Location = new System.Drawing.Point(479, 227);
            this.chbModificarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbModificarEstado.Name = "chbModificarEstado";
            this.chbModificarEstado.Size = new System.Drawing.Size(95, 27);
            this.chbModificarEstado.TabIndex = 56;
            this.chbModificarEstado.Text = "Modificar";
            this.chbModificarEstado.UseVisualStyleBackColor = false;
            this.chbModificarEstado.CheckedChanged += new System.EventHandler(this.chbModificarEstado_CheckedChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtDiasEspera
            // 
            this.txtDiasEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtDiasEspera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiasEspera.ForeColor = System.Drawing.Color.White;
            this.txtDiasEspera.Location = new System.Drawing.Point(968, 144);
            this.txtDiasEspera.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiasEspera.Name = "txtDiasEspera";
            this.txtDiasEspera.Size = new System.Drawing.Size(85, 22);
            this.txtDiasEspera.TabIndex = 58;
            this.txtDiasEspera.Visible = false;
            // 
            // lblDiasEspera
            // 
            this.lblDiasEspera.AutoSize = true;
            this.lblDiasEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.lblDiasEspera.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasEspera.ForeColor = System.Drawing.Color.White;
            this.lblDiasEspera.Location = new System.Drawing.Point(871, 148);
            this.lblDiasEspera.Name = "lblDiasEspera";
            this.lblDiasEspera.Size = new System.Drawing.Size(93, 23);
            this.lblDiasEspera.TabIndex = 59;
            this.lblDiasEspera.Text = "Días espera:";
            this.lblDiasEspera.Visible = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblMarca);
            this.bunifuGradientPanel1.Controls.Add(this.lblMarcaPedido);
            this.bunifuGradientPanel1.Controls.Add(this.txtVendedor);
            this.bunifuGradientPanel1.Controls.Add(this.dgvPedido);
            this.bunifuGradientPanel1.Controls.Add(this.txtValuador);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarPieza);
            this.bunifuGradientPanel1.Controls.Add(this.chbModificarEstado);
            this.bunifuGradientPanel1.Controls.Add(this.lblEstado);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.txtComentarioSiniestro);
            this.bunifuGradientPanel1.Controls.Add(this.label11);
            this.bunifuGradientPanel1.Controls.Add(this.lblComentarioSiniestro);
            this.bunifuGradientPanel1.Controls.Add(this.label12);
            this.bunifuGradientPanel1.Controls.Add(this.chbModificarFechaBaja);
            this.bunifuGradientPanel1.Controls.Add(this.lblClaveSiniestro);
            this.bunifuGradientPanel1.Controls.Add(this.txtEstado);
            this.bunifuGradientPanel1.Controls.Add(this.chbModificarFechaPromesa);
            this.bunifuGradientPanel1.Controls.Add(this.cbEstadoSiniestro);
            this.bunifuGradientPanel1.Controls.Add(this.chbModificarFechaAsignacion);
            this.bunifuGradientPanel1.Controls.Add(this.chbSi);
            this.bunifuGradientPanel1.Controls.Add(this.cbVendedor);
            this.bunifuGradientPanel1.Controls.Add(this.txtAseguradora);
            this.bunifuGradientPanel1.Controls.Add(this.cbValuador);
            this.bunifuGradientPanel1.Controls.Add(this.cbAseguradora);
            this.bunifuGradientPanel1.Controls.Add(this.txtDestino);
            this.bunifuGradientPanel1.Controls.Add(this.txtTaller);
            this.bunifuGradientPanel1.Controls.Add(this.cbDestino);
            this.bunifuGradientPanel1.Controls.Add(this.cbTaller);
            this.bunifuGradientPanel1.Controls.Add(this.lblVehiculoPedido);
            this.bunifuGradientPanel1.Controls.Add(this.lblAnio);
            this.bunifuGradientPanel1.Controls.Add(this.lblAnioPedido);
            this.bunifuGradientPanel1.Controls.Add(this.lblVehiculo);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 28);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(2035, 625);
            this.bunifuGradientPanel1.TabIndex = 60;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.lblMarca.Location = new System.Drawing.Point(167, 141);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 17);
            this.lblMarca.TabIndex = 58;
            // 
            // lblMarcaPedido
            // 
            this.lblMarcaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.lblMarcaPedido.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaPedido.Location = new System.Drawing.Point(87, 138);
            this.lblMarcaPedido.Name = "lblMarcaPedido";
            this.lblMarcaPedido.Size = new System.Drawing.Size(60, 19);
            this.lblMarcaPedido.TabIndex = 57;
            this.lblMarcaPedido.Text = "Marca:";
            this.lblMarcaPedido.Visible = false;
            // 
            // moverTop
            // 
            this.moverTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.moverTop.Location = new System.Drawing.Point(0, 0);
            this.moverTop.Margin = new System.Windows.Forms.Padding(4);
            this.moverTop.Name = "moverTop";
            this.moverTop.Size = new System.Drawing.Size(1788, 23);
            this.moverTop.TabIndex = 56;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.moverTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::Refracciones.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(1733, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(20, 20);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 79;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Refracciones.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(1759, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 78;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1788, 649);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.lblDiasEspera);
            this.Controls.Add(this.txtDiasEspera);
            this.Controls.Add(this.chbModificarVendedor);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.lblFechaBaja);
            this.Controls.Add(this.chbOtroDestino);
            this.Controls.Add(this.chbOtroTaller);
            this.Controls.Add(this.txtClavePedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClaveSiniestroPedido);
            this.Controls.Add(this.chbOtraAseguradora);
            this.Controls.Add(this.chbOtroValuador);
            this.Controls.Add(this.rdbSi);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaPromesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaAsignacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblClientePedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.moverTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
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
        private System.Windows.Forms.Label lblDiasEspera;
        private System.Windows.Forms.TextBox txtDiasEspera;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel moverTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        public System.Windows.Forms.Label lblMarcaPedido;
        private System.Windows.Forms.Label lblMarca;
    }
}