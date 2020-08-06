namespace Refracciones.Forms
{
    partial class Busqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClaveSin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClavePed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha_in = new System.Windows.Forms.DateTimePicker();
            this.Panelinfo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFechaEntreg = new System.Windows.Forms.Label();
            this.pbFactura = new System.Windows.Forms.PictureBox();
            this.lblEstadoFac = new System.Windows.Forms.Label();
            this.lblFacturaConIva = new System.Windows.Forms.Label();
            this.lblFacturaSinIva = new System.Windows.Forms.Label();
            this.lblCveFactura = new System.Windows.Forms.Label();
            this.lblTaller = new System.Windows.Forms.Label();
            this.lblPortal = new System.Windows.Forms.Label();
            this.lblPrecioReparacion = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblClaveSeguimiento = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValuador = new System.Windows.Forms.Label();
            this.lblCostoNeto = new System.Windows.Forms.Label();
            this.lblCostoEnvio = new System.Windows.Forms.Label();
            this.lblCostoSinIva = new System.Windows.Forms.Label();
            this.lblPromesa = new System.Windows.Forms.Label();
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPieza = new System.Windows.Forms.Label();
            this.lblcveSiniestro = new System.Windows.Forms.Label();
            this.lblCvePed = new System.Windows.Forms.Label();
            this.lblcvePedido = new System.Windows.Forms.Label();
            this.dvgPedido = new System.Windows.Forms.DataGridView();
            this.Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelFecha = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.txtCveVendedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otrasOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talleresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblEstadoSiniestro = new System.Windows.Forms.Label();
            this.Panelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPedido)).BeginInit();
            this.PanelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave siniestro";
            // 
            // TxtClaveSin
            // 
            this.TxtClaveSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TxtClaveSin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtClaveSin.ForeColor = System.Drawing.Color.White;
            this.TxtClaveSin.Location = new System.Drawing.Point(224, 82);
            this.TxtClaveSin.MaxLength = 30;
            this.TxtClaveSin.Name = "TxtClaveSin";
            this.TxtClaveSin.Size = new System.Drawing.Size(133, 20);
            this.TxtClaveSin.TabIndex = 1;
            this.TxtClaveSin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaPedido);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave pedido";
            // 
            // TxtClavePed
            // 
            this.TxtClavePed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TxtClavePed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtClavePed.ForeColor = System.Drawing.Color.White;
            this.TxtClavePed.Location = new System.Drawing.Point(37, 82);
            this.TxtClavePed.MaxLength = 30;
            this.TxtClavePed.Name = "TxtClavePed";
            this.TxtClavePed.Size = new System.Drawing.Size(133, 20);
            this.TxtClavePed.TabIndex = 3;
            this.TxtClavePed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaPedido);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "De la fecha : ";
            // 
            // Fecha_in
            // 
            this.Fecha_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_in.Location = new System.Drawing.Point(24, 28);
            this.Fecha_in.Name = "Fecha_in";
            this.Fecha_in.Size = new System.Drawing.Size(128, 20);
            this.Fecha_in.TabIndex = 5;
            this.Fecha_in.ValueChanged += new System.EventHandler(this.BusquedaFecha);
            // 
            // Panelinfo
            // 
            this.Panelinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Panelinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panelinfo.Controls.Add(this.lblEstadoSiniestro);
            this.Panelinfo.Controls.Add(this.label11);
            this.Panelinfo.Controls.Add(this.label10);
            this.Panelinfo.Controls.Add(this.label9);
            this.Panelinfo.Controls.Add(this.label8);
            this.Panelinfo.Controls.Add(this.label7);
            this.Panelinfo.Controls.Add(this.label6);
            this.Panelinfo.Controls.Add(this.lblFechaEntreg);
            this.Panelinfo.Controls.Add(this.pbFactura);
            this.Panelinfo.Controls.Add(this.lblEstadoFac);
            this.Panelinfo.Controls.Add(this.lblFacturaConIva);
            this.Panelinfo.Controls.Add(this.lblFacturaSinIva);
            this.Panelinfo.Controls.Add(this.lblCveFactura);
            this.Panelinfo.Controls.Add(this.lblTaller);
            this.Panelinfo.Controls.Add(this.lblPortal);
            this.Panelinfo.Controls.Add(this.lblPrecioReparacion);
            this.Panelinfo.Controls.Add(this.lblPrecioVenta);
            this.Panelinfo.Controls.Add(this.lblClaveSeguimiento);
            this.Panelinfo.Controls.Add(this.lblCliente);
            this.Panelinfo.Controls.Add(this.lblValuador);
            this.Panelinfo.Controls.Add(this.lblCostoNeto);
            this.Panelinfo.Controls.Add(this.lblCostoEnvio);
            this.Panelinfo.Controls.Add(this.lblCostoSinIva);
            this.Panelinfo.Controls.Add(this.lblPromesa);
            this.Panelinfo.Controls.Add(this.lblAsignacion);
            this.Panelinfo.Controls.Add(this.lblOrigen);
            this.Panelinfo.Controls.Add(this.lblVendedor);
            this.Panelinfo.Controls.Add(this.lblProveedor);
            this.Panelinfo.Controls.Add(this.lblCantidad);
            this.Panelinfo.Controls.Add(this.lblPieza);
            this.Panelinfo.Controls.Add(this.lblcveSiniestro);
            this.Panelinfo.Controls.Add(this.lblCvePed);
            this.Panelinfo.Controls.Add(this.lblcvePedido);
            this.Panelinfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Panelinfo.Location = new System.Drawing.Point(0, 150);
            this.Panelinfo.Name = "Panelinfo";
            this.Panelinfo.Size = new System.Drawing.Size(320, 479);
            this.Panelinfo.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label11.Location = new System.Drawing.Point(0, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 2);
            this.label11.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label10.Location = new System.Drawing.Point(0, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 2);
            this.label10.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label9.Location = new System.Drawing.Point(0, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 2);
            this.label9.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label8.Location = new System.Drawing.Point(0, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 2);
            this.label8.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label7.Location = new System.Drawing.Point(1, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 2);
            this.label7.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(79)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-3, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "DATOS DEL PEDIDO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaEntreg
            // 
            this.lblFechaEntreg.AutoSize = true;
            this.lblFechaEntreg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntreg.ForeColor = System.Drawing.Color.White;
            this.lblFechaEntreg.Location = new System.Drawing.Point(0, 119);
            this.lblFechaEntreg.Name = "lblFechaEntreg";
            this.lblFechaEntreg.Size = new System.Drawing.Size(89, 14);
            this.lblFechaEntreg.TabIndex = 17;
            this.lblFechaEntreg.Text = "Fecha Entrega: ";
            // 
            // pbFactura
            // 
            this.pbFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFactura.Image = global::Jeic.Properties.Resources.file;
            this.pbFactura.Location = new System.Drawing.Point(277, 439);
            this.pbFactura.Name = "pbFactura";
            this.pbFactura.Size = new System.Drawing.Size(33, 28);
            this.pbFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFactura.TabIndex = 32;
            this.pbFactura.TabStop = false;
            this.pbFactura.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lblEstadoFac
            // 
            this.lblEstadoFac.AutoSize = true;
            this.lblEstadoFac.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFac.ForeColor = System.Drawing.Color.White;
            this.lblEstadoFac.Location = new System.Drawing.Point(184, 412);
            this.lblEstadoFac.Name = "lblEstadoFac";
            this.lblEstadoFac.Size = new System.Drawing.Size(47, 14);
            this.lblEstadoFac.TabIndex = 31;
            this.lblEstadoFac.Text = "Estado:";
            // 
            // lblFacturaConIva
            // 
            this.lblFacturaConIva.AutoSize = true;
            this.lblFacturaConIva.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaConIva.ForeColor = System.Drawing.Color.White;
            this.lblFacturaConIva.Location = new System.Drawing.Point(6, 450);
            this.lblFacturaConIva.Name = "lblFacturaConIva";
            this.lblFacturaConIva.Size = new System.Drawing.Size(92, 14);
            this.lblFacturaConIva.TabIndex = 30;
            this.lblFacturaConIva.Text = "Factura con IVA:";
            // 
            // lblFacturaSinIva
            // 
            this.lblFacturaSinIva.AutoSize = true;
            this.lblFacturaSinIva.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaSinIva.ForeColor = System.Drawing.Color.White;
            this.lblFacturaSinIva.Location = new System.Drawing.Point(6, 431);
            this.lblFacturaSinIva.Name = "lblFacturaSinIva";
            this.lblFacturaSinIva.Size = new System.Drawing.Size(90, 14);
            this.lblFacturaSinIva.TabIndex = 29;
            this.lblFacturaSinIva.Text = "Factura sin IVA:";
            // 
            // lblCveFactura
            // 
            this.lblCveFactura.AutoSize = true;
            this.lblCveFactura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCveFactura.ForeColor = System.Drawing.Color.White;
            this.lblCveFactura.Location = new System.Drawing.Point(5, 412);
            this.lblCveFactura.Name = "lblCveFactura";
            this.lblCveFactura.Size = new System.Drawing.Size(59, 14);
            this.lblCveFactura.TabIndex = 28;
            this.lblCveFactura.Text = "# Factura:";
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaller.ForeColor = System.Drawing.Color.White;
            this.lblTaller.Location = new System.Drawing.Point(0, 229);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(44, 14);
            this.lblTaller.TabIndex = 27;
            this.lblTaller.Text = "Taller: ";
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortal.ForeColor = System.Drawing.Color.White;
            this.lblPortal.Location = new System.Drawing.Point(0, 267);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(45, 14);
            this.lblPortal.TabIndex = 26;
            this.lblPortal.Text = "Portal: ";
            // 
            // lblPrecioReparacion
            // 
            this.lblPrecioReparacion.AutoSize = true;
            this.lblPrecioReparacion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioReparacion.ForeColor = System.Drawing.Color.White;
            this.lblPrecioReparacion.Location = new System.Drawing.Point(140, 356);
            this.lblPrecioReparacion.Name = "lblPrecioReparacion";
            this.lblPrecioReparacion.Size = new System.Drawing.Size(122, 14);
            this.lblPrecioReparacion.TabIndex = 25;
            this.lblPrecioReparacion.Text = "Precio de reparacion:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.lblPrecioVenta.Location = new System.Drawing.Point(141, 337);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(93, 14);
            this.lblPrecioVenta.TabIndex = 24;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // lblClaveSeguimiento
            // 
            this.lblClaveSeguimiento.AutoSize = true;
            this.lblClaveSeguimiento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveSeguimiento.ForeColor = System.Drawing.Color.White;
            this.lblClaveSeguimiento.Location = new System.Drawing.Point(5, 304);
            this.lblClaveSeguimiento.Name = "lblClaveSeguimiento";
            this.lblClaveSeguimiento.Size = new System.Drawing.Size(54, 14);
            this.lblClaveSeguimiento.TabIndex = 23;
            this.lblClaveSeguimiento.Text = "Cve guía:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(0, 153);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 14);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValuador
            // 
            this.lblValuador.AutoSize = true;
            this.lblValuador.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuador.ForeColor = System.Drawing.Color.White;
            this.lblValuador.Location = new System.Drawing.Point(0, 210);
            this.lblValuador.Name = "lblValuador";
            this.lblValuador.Size = new System.Drawing.Size(59, 14);
            this.lblValuador.TabIndex = 21;
            this.lblValuador.Text = "Valuador:";
            // 
            // lblCostoNeto
            // 
            this.lblCostoNeto.AutoSize = true;
            this.lblCostoNeto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoNeto.ForeColor = System.Drawing.Color.White;
            this.lblCostoNeto.Location = new System.Drawing.Point(6, 337);
            this.lblCostoNeto.Name = "lblCostoNeto";
            this.lblCostoNeto.Size = new System.Drawing.Size(69, 14);
            this.lblCostoNeto.TabIndex = 20;
            this.lblCostoNeto.Text = "Costo Neto:";
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoEnvio.ForeColor = System.Drawing.Color.White;
            this.lblCostoEnvio.Location = new System.Drawing.Point(6, 356);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(90, 14);
            this.lblCostoEnvio.TabIndex = 19;
            this.lblCostoEnvio.Text = "Costo de envio:";
            // 
            // lblCostoSinIva
            // 
            this.lblCostoSinIva.AutoSize = true;
            this.lblCostoSinIva.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoSinIva.ForeColor = System.Drawing.Color.White;
            this.lblCostoSinIva.Location = new System.Drawing.Point(5, 337);
            this.lblCostoSinIva.Name = "lblCostoSinIva";
            this.lblCostoSinIva.Size = new System.Drawing.Size(80, 14);
            this.lblCostoSinIva.TabIndex = 18;
            this.lblCostoSinIva.Text = "Costo sin IVA:";
            this.lblCostoSinIva.Visible = false;
            // 
            // lblPromesa
            // 
            this.lblPromesa.AutoSize = true;
            this.lblPromesa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromesa.ForeColor = System.Drawing.Color.White;
            this.lblPromesa.Location = new System.Drawing.Point(0, 98);
            this.lblPromesa.Name = "lblPromesa";
            this.lblPromesa.Size = new System.Drawing.Size(93, 14);
            this.lblPromesa.TabIndex = 13;
            this.lblPromesa.Text = "Fecha promesa:";
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacion.ForeColor = System.Drawing.Color.White;
            this.lblAsignacion.Location = new System.Drawing.Point(0, 77);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(99, 14);
            this.lblAsignacion.TabIndex = 12;
            this.lblAsignacion.Text = "Fecha asignada: ";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(-1, 248);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(46, 14);
            this.lblOrigen.TabIndex = 11;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(0, 191);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(62, 14);
            this.lblVendedor.TabIndex = 10;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(0, 172);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(64, 14);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(184, 43);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 14);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieza.ForeColor = System.Drawing.Color.White;
            this.lblPieza.Location = new System.Drawing.Point(173, 27);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(39, 14);
            this.lblPieza.TabIndex = 4;
            this.lblPieza.Text = "Pieza:";
            // 
            // lblcveSiniestro
            // 
            this.lblcveSiniestro.AutoSize = true;
            this.lblcveSiniestro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcveSiniestro.ForeColor = System.Drawing.Color.White;
            this.lblcveSiniestro.Location = new System.Drawing.Point(1, 43);
            this.lblcveSiniestro.Name = "lblcveSiniestro";
            this.lblcveSiniestro.Size = new System.Drawing.Size(68, 15);
            this.lblcveSiniestro.TabIndex = 2;
            this.lblcveSiniestro.Text = "# Siniestro:";
            // 
            // lblCvePed
            // 
            this.lblCvePed.AutoSize = true;
            this.lblCvePed.Location = new System.Drawing.Point(75, 27);
            this.lblCvePed.Name = "lblCvePed";
            this.lblCvePed.Size = new System.Drawing.Size(0, 13);
            this.lblCvePed.TabIndex = 1;
            // 
            // lblcvePedido
            // 
            this.lblcvePedido.AutoSize = true;
            this.lblcvePedido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcvePedido.ForeColor = System.Drawing.Color.White;
            this.lblcvePedido.Location = new System.Drawing.Point(1, 27);
            this.lblcvePedido.Name = "lblcvePedido";
            this.lblcvePedido.Size = new System.Drawing.Size(58, 15);
            this.lblcvePedido.TabIndex = 0;
            this.lblcvePedido.Text = "# Pedido:";
            // 
            // dvgPedido
            // 
            this.dvgPedido.AllowUserToAddRows = false;
            this.dvgPedido.AllowUserToDeleteRows = false;
            this.dvgPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dvgPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgPedido.ColumnHeadersHeight = 22;
            this.dvgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgPedido.EnableHeadersVisualStyles = false;
            this.dvgPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dvgPedido.Location = new System.Drawing.Point(318, 150);
            this.dvgPedido.Name = "dvgPedido";
            this.dvgPedido.ReadOnly = true;
            this.dvgPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgPedido.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dvgPedido.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPedido.Size = new System.Drawing.Size(897, 480);
            this.dvgPedido.TabIndex = 7;
            this.dvgPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPedido_CellContentClick);
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_Fin.Location = new System.Drawing.Point(230, 28);
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Size = new System.Drawing.Size(112, 20);
            this.Fecha_Fin.TabIndex = 8;
            this.Fecha_Fin.ValueChanged += new System.EventHandler(this.BusquedaFecha);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "a : ";
            // 
            // PanelFecha
            // 
            this.PanelFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PanelFecha.Controls.Add(this.Fecha_in);
            this.PanelFecha.Controls.Add(this.label3);
            this.PanelFecha.Controls.Add(this.Fecha_Fin);
            this.PanelFecha.Controls.Add(this.label4);
            this.PanelFecha.ForeColor = System.Drawing.Color.White;
            this.PanelFecha.Location = new System.Drawing.Point(623, 49);
            this.PanelFecha.Name = "PanelFecha";
            this.PanelFecha.Size = new System.Drawing.Size(356, 65);
            this.PanelFecha.TabIndex = 11;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Enabled = false;
            this.dgvDatos.Location = new System.Drawing.Point(1016, 33);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(79, 53);
            this.dgvDatos.TabIndex = 12;
            this.dgvDatos.Visible = false;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.btnAgregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPedido.Location = new System.Drawing.Point(49, 107);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(111, 30);
            this.btnAgregarPedido.TabIndex = 13;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // txtCveVendedor
            // 
            this.txtCveVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtCveVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCveVendedor.ForeColor = System.Drawing.Color.White;
            this.txtCveVendedor.Location = new System.Drawing.Point(407, 82);
            this.txtCveVendedor.MaxLength = 30;
            this.txtCveVendedor.Name = "txtCveVendedor";
            this.txtCveVendedor.Size = new System.Drawing.Size(133, 20);
            this.txtCveVendedor.TabIndex = 15;
            this.txtCveVendedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaPedido);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(419, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Clave vendedor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otrasOpcionesToolStripMenuItem,
            this.Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1215, 26);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otrasOpcionesToolStripMenuItem
            // 
            this.otrasOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReporteVentasToolStripMenuItem,
            this.notificacionesToolStripMenuItem,
            this.buscarFacturasToolStripMenuItem,
            this.talleresToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem1});
            this.otrasOpcionesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otrasOpcionesToolStripMenuItem.Name = "otrasOpcionesToolStripMenuItem";
            this.otrasOpcionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.otrasOpcionesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.otrasOpcionesToolStripMenuItem.Text = "Otras Opciones";
            // 
            // generarReporteVentasToolStripMenuItem
            // 
            this.generarReporteVentasToolStripMenuItem.Name = "generarReporteVentasToolStripMenuItem";
            this.generarReporteVentasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.generarReporteVentasToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.generarReporteVentasToolStripMenuItem.Text = "Generar Reporte Ventas";
            this.generarReporteVentasToolStripMenuItem.Click += new System.EventHandler(this.generarReporteVentasToolStripMenuItem_Click);
            // 
            // notificacionesToolStripMenuItem
            // 
            this.notificacionesToolStripMenuItem.Name = "notificacionesToolStripMenuItem";
            this.notificacionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.notificacionesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.notificacionesToolStripMenuItem.Text = "Notificaciones";
            this.notificacionesToolStripMenuItem.Click += new System.EventHandler(this.notificacionesToolStripMenuItem_Click);
            // 
            // buscarFacturasToolStripMenuItem
            // 
            this.buscarFacturasToolStripMenuItem.Name = "buscarFacturasToolStripMenuItem";
            this.buscarFacturasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.buscarFacturasToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.buscarFacturasToolStripMenuItem.Text = "Buscar Facturas";
            this.buscarFacturasToolStripMenuItem.Click += new System.EventHandler(this.buscarFacturasToolStripMenuItem_Click);
            // 
            // talleresToolStripMenuItem
            // 
            this.talleresToolStripMenuItem.Name = "talleresToolStripMenuItem";
            this.talleresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.talleresToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.talleresToolStripMenuItem.Text = "Talleres";
            this.talleresToolStripMenuItem.Click += new System.EventHandler(this.talleresToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesión";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // Usuario
            // 
            this.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.Usuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Usuario.Enabled = false;
            this.Usuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.ImageTransparentColor = System.Drawing.Color.White;
            this.Usuario.Name = "Usuario";
            this.Usuario.ShowShortcutKeys = false;
            this.Usuario.Size = new System.Drawing.Size(68, 22);
            this.Usuario.Text = "Usuario";
            this.Usuario.ToolTipText = "Usuario";
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
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.dvgPedido);
            this.bunifuGradientPanel1.Controls.Add(this.txtCveVendedor);
            this.bunifuGradientPanel1.Controls.Add(this.PanelFecha);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarPedido);
            this.bunifuGradientPanel1.Controls.Add(this.Panelinfo);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.TxtClaveSin);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.TxtClavePed);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -16);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1264, 633);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.bunifuGradientPanel1;
            this.moverFormulario.Vertical = true;
            // 
            // lblEstadoSiniestro
            // 
            this.lblEstadoSiniestro.AutoSize = true;
            this.lblEstadoSiniestro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoSiniestro.ForeColor = System.Drawing.Color.White;
            this.lblEstadoSiniestro.Location = new System.Drawing.Point(5, 285);
            this.lblEstadoSiniestro.Name = "lblEstadoSiniestro";
            this.lblEstadoSiniestro.Size = new System.Drawing.Size(99, 14);
            this.lblEstadoSiniestro.TabIndex = 39;
            this.lblEstadoSiniestro.Text = "Estado Siniestro:";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 615);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Busqueda_Devolver_Load);
            this.Panelinfo.ResumeLayout(false);
            this.Panelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPedido)).EndInit();
            this.PanelFecha.ResumeLayout(false);
            this.PanelFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtClaveSin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClavePed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Fecha_in;
        private System.Windows.Forms.Panel Panelinfo;
        private System.Windows.Forms.DataGridView dvgPedido;
        private System.Windows.Forms.DateTimePicker Fecha_Fin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcvePedido;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPieza;
        private System.Windows.Forms.Label lblcveSiniestro;
        private System.Windows.Forms.Label lblCvePed;
        private System.Windows.Forms.Panel PanelFecha;
        private System.Windows.Forms.Label lblPromesa;
        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblFechaEntreg;
        private System.Windows.Forms.Label lblEstadoFac;
        private System.Windows.Forms.Label lblFacturaConIva;
        private System.Windows.Forms.Label lblFacturaSinIva;
        private System.Windows.Forms.Label lblCveFactura;
        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.Label lblPrecioReparacion;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblClaveSeguimiento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValuador;
        private System.Windows.Forms.Label lblCostoNeto;
        private System.Windows.Forms.Label lblCostoEnvio;
        private System.Windows.Forms.Label lblCostoSinIva;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.PictureBox pbFactura;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.TextBox txtCveVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otrasOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarFacturasToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talleresToolStripMenuItem;
        private System.Windows.Forms.Label lblEstadoSiniestro;
    }
}