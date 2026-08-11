namespace Refracciones.Forms
{
    partial class buscarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpfechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblfechaPago = new System.Windows.Forms.Label();
            this.cbAseguradora = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblEstadoFact = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.PanelFecha = new System.Windows.Forms.Panel();
            this.Fecha_in = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cmbfiltroEstadoFactura = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstadoFactura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.PanelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bunifuGradientPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvFacturas);
            this.splitContainer1.Size = new System.Drawing.Size(1139, 665);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblTitulo);
            this.bunifuGradientPanel1.Controls.Add(this.cmbfiltroEstadoFactura);
            this.bunifuGradientPanel1.Controls.Add(this.lblFiltroEstadoFactura);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.dtpfechaPago);
            this.bunifuGradientPanel1.Controls.Add(this.lblfechaPago);
            this.bunifuGradientPanel1.Controls.Add(this.cbAseguradora);
            this.bunifuGradientPanel1.Controls.Add(this.lblSeguro);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.cmbEstadoFactura);
            this.bunifuGradientPanel1.Controls.Add(this.txtFactura);
            this.bunifuGradientPanel1.Controls.Add(this.lblEstadoFact);
            this.bunifuGradientPanel1.Controls.Add(this.lblUsuario);
            this.bunifuGradientPanel1.Controls.Add(this.PanelFecha);
            this.bunifuGradientPanel1.Controls.Add(this.pbMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.pbClose);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1139, 675);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1017, 180);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 86;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpfechaPago
            // 
            this.dtpfechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaPago.Location = new System.Drawing.Point(957, 121);
            this.dtpfechaPago.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfechaPago.Name = "dtpfechaPago";
            this.dtpfechaPago.Size = new System.Drawing.Size(160, 23);
            this.dtpfechaPago.TabIndex = 85;
            // 
            // lblfechaPago
            // 
            this.lblfechaPago.AutoSize = true;
            this.lblfechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.lblfechaPago.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaPago.ForeColor = System.Drawing.Color.White;
            this.lblfechaPago.Location = new System.Drawing.Point(788, 121);
            this.lblfechaPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfechaPago.Name = "lblfechaPago";
            this.lblfechaPago.Size = new System.Drawing.Size(100, 18);
            this.lblfechaPago.TabIndex = 84;
            this.lblfechaPago.Text = "Fecha de Pago:";
            // 
            // cbAseguradora
            // 
            this.cbAseguradora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAseguradora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAseguradora.BackColor = System.Drawing.Color.White;
            this.cbAseguradora.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbAseguradora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAseguradora.ForeColor = System.Drawing.Color.Black;
            this.cbAseguradora.FormattingEnabled = true;
            this.cbAseguradora.Location = new System.Drawing.Point(163, 78);
            this.cbAseguradora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAseguradora.Name = "cbAseguradora";
            this.cbAseguradora.Size = new System.Drawing.Size(392, 24);
            this.cbAseguradora.TabIndex = 83;
            this.cbAseguradora.SelectedIndexChanged += new System.EventHandler(this.cbAseguradora_SelectedIndexChanged);
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.lblSeguro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.ForeColor = System.Drawing.Color.White;
            this.lblSeguro.Location = new System.Drawing.Point(4, 86);
            this.lblSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(90, 18);
            this.lblSeguro.TabIndex = 82;
            this.lblSeguro.Text = "Aseguradora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Factura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            "CANCELADA",
            "SIN FACTURAR",
            "REMBOLSO"});
            this.cmbEstadoFactura.Location = new System.Drawing.Point(957, 70);
            this.cmbEstadoFactura.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(160, 24);
            this.cmbEstadoFactura.TabIndex = 80;
            this.cmbEstadoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoFactura_SelectedIndexChanged);
            // 
            // txtFactura
            // 
            this.txtFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFactura.ForeColor = System.Drawing.Color.White;
            this.txtFactura.Location = new System.Drawing.Point(163, 32);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(133, 22);
            this.txtFactura.TabIndex = 0;
            this.txtFactura.TextChanged += new System.EventHandler(this.txtFactura_TextChanged);
            this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactura_KeyPress);
            this.txtFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFactura_KeyUp);
            // 
            // lblEstadoFact
            // 
            this.lblEstadoFact.AutoSize = true;
            this.lblEstadoFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.lblEstadoFact.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFact.ForeColor = System.Drawing.Color.White;
            this.lblEstadoFact.Location = new System.Drawing.Point(788, 76);
            this.lblEstadoFact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoFact.Name = "lblEstadoFact";
            this.lblEstadoFact.Size = new System.Drawing.Size(134, 18);
            this.lblEstadoFact.TabIndex = 2;
            this.lblEstadoFact.Text = "Estado de la Factura:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(4, 6);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 79;
            this.lblUsuario.Text = "Usuario:";
            // 
            // PanelFecha
            // 
            this.PanelFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PanelFecha.Controls.Add(this.Fecha_in);
            this.PanelFecha.Controls.Add(this.label3);
            this.PanelFecha.Controls.Add(this.Fecha_Fin);
            this.PanelFecha.Controls.Add(this.label4);
            this.PanelFecha.ForeColor = System.Drawing.Color.White;
            this.PanelFecha.Location = new System.Drawing.Point(305, 9);
            this.PanelFecha.Margin = new System.Windows.Forms.Padding(4);
            this.PanelFecha.Name = "PanelFecha";
            this.PanelFecha.Size = new System.Drawing.Size(475, 59);
            this.PanelFecha.TabIndex = 78;
            // 
            // Fecha_in
            // 
            this.Fecha_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_in.Location = new System.Drawing.Point(32, 27);
            this.Fecha_in.Margin = new System.Windows.Forms.Padding(4);
            this.Fecha_in.Name = "Fecha_in";
            this.Fecha_in.Size = new System.Drawing.Size(169, 23);
            this.Fecha_in.TabIndex = 5;
            this.Fecha_in.ValueChanged += new System.EventHandler(this.BusquedaFecha);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "De la fecha : ";
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_Fin.Location = new System.Drawing.Point(307, 27);
            this.Fecha_Fin.Margin = new System.Windows.Forms.Padding(4);
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Size = new System.Drawing.Size(148, 23);
            this.Fecha_Fin.TabIndex = 8;
            this.Fecha_Fin.ValueChanged += new System.EventHandler(this.BusquedaFecha);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "a : ";
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::Jeic.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(1082, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(20, 20);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 77;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(1107, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 76;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dgvFacturas.Location = new System.Drawing.Point(0, 0);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1139, 445);
            this.dgvFacturas.TabIndex = 0;
            this.dgvFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellClick);
            this.dgvFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellDoubleClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.bunifuGradientPanel1;
            this.moverFormulario.Vertical = true;
            // 
            // cmbfiltroEstadoFactura
            // 
            this.cmbfiltroEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmbfiltroEstadoFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbfiltroEstadoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltroEstadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbfiltroEstadoFactura.ForeColor = System.Drawing.Color.White;
            this.cmbfiltroEstadoFactura.FormattingEnabled = true;
            this.cmbfiltroEstadoFactura.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADA",
            "CANCELADA",
            "SIN FACTURAR",
            "REMBOLSO"});
            this.cmbfiltroEstadoFactura.Location = new System.Drawing.Point(163, 121);
            this.cmbfiltroEstadoFactura.Margin = new System.Windows.Forms.Padding(4);
            this.cmbfiltroEstadoFactura.Name = "cmbfiltroEstadoFactura";
            this.cmbfiltroEstadoFactura.Size = new System.Drawing.Size(160, 24);
            this.cmbfiltroEstadoFactura.TabIndex = 88;
            this.cmbfiltroEstadoFactura.SelectedIndexChanged += new System.EventHandler(this.cmbfiltroEstadoFactura_SelectedIndexChanged);
            // 
            // lblFiltroEstadoFactura
            // 
            this.lblFiltroEstadoFactura.AutoSize = true;
            this.lblFiltroEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.lblFiltroEstadoFactura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstadoFactura.ForeColor = System.Drawing.Color.White;
            this.lblFiltroEstadoFactura.Location = new System.Drawing.Point(4, 127);
            this.lblFiltroEstadoFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroEstadoFactura.Name = "lblFiltroEstadoFactura";
            this.lblFiltroEstadoFactura.Size = new System.Drawing.Size(134, 18);
            this.lblFiltroEstadoFactura.TabIndex = 87;
            this.lblFiltroEstadoFactura.Text = "Estado de la Factura:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(881, 36);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 18);
            this.lblTitulo.TabIndex = 89;
            this.lblTitulo.Text = "DATOS A ACTUALIZAR";
            // 
            // buscarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 665);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "buscarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Facturas";
            this.Load += new System.EventHandler(this.buscarFacturas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buscarFacturas_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.PanelFecha.ResumeLayout(false);
            this.PanelFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactura;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel PanelFecha;
        private System.Windows.Forms.DateTimePicker Fecha_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Fecha_Fin;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEstadoFact;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.ComboBox cbAseguradora;
        private System.Windows.Forms.DateTimePicker dtpfechaPago;
        private System.Windows.Forms.Label lblfechaPago;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbfiltroEstadoFactura;
        private System.Windows.Forms.Label lblFiltroEstadoFactura;
        private System.Windows.Forms.Label lblTitulo;
    }
}