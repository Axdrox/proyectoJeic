namespace Refracciones.Forms
{
    partial class Busqueda_Devolver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClaveSin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClavePed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha_in = new System.Windows.Forms.DateTimePicker();
            this.Panelinfo = new System.Windows.Forms.Panel();
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
            this.lblFechaEntreg = new System.Windows.Forms.Label();
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.PanelFecha = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.pbAlertas = new System.Windows.Forms.PictureBox();
            this.Panelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPedido)).BeginInit();
            this.PanelFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave siniestro";
            // 
            // TxtClaveSin
            // 
            this.TxtClaveSin.Location = new System.Drawing.Point(12, 66);
            this.TxtClaveSin.MaxLength = 30;
            this.TxtClaveSin.Name = "TxtClaveSin";
            this.TxtClaveSin.Size = new System.Drawing.Size(133, 20);
            this.TxtClaveSin.TabIndex = 1;
            this.TxtClaveSin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaPedido);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave pedido";
            // 
            // TxtClavePed
            // 
            this.TxtClavePed.Location = new System.Drawing.Point(162, 66);
            this.TxtClavePed.MaxLength = 30;
            this.TxtClavePed.Name = "TxtClavePed";
            this.TxtClavePed.Size = new System.Drawing.Size(133, 20);
            this.TxtClavePed.TabIndex = 3;
            this.TxtClavePed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BusquedaPedido);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "De la fecha : ";
            // 
            // Fecha_in
            // 
            this.Fecha_in.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_in.Location = new System.Drawing.Point(24, 28);
            this.Fecha_in.Name = "Fecha_in";
            this.Fecha_in.Size = new System.Drawing.Size(112, 25);
            this.Fecha_in.TabIndex = 5;
            this.Fecha_in.ValueChanged += new System.EventHandler(this.BusquedaFecha);
            // 
            // Panelinfo
            // 
            this.Panelinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.Panelinfo.Controls.Add(this.lblFechaEntreg);
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
            this.Panelinfo.Location = new System.Drawing.Point(12, 136);
            this.Panelinfo.Name = "Panelinfo";
            this.Panelinfo.Size = new System.Drawing.Size(338, 434);
            this.Panelinfo.TabIndex = 6;
            // 
            // pbFactura
            // 
            this.pbFactura.Image = global::Refracciones.Properties.Resources.file;
            this.pbFactura.Location = new System.Drawing.Point(252, 396);
            this.pbFactura.Name = "pbFactura";
            this.pbFactura.Size = new System.Drawing.Size(30, 23);
            this.pbFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFactura.TabIndex = 32;
            this.pbFactura.TabStop = false;
            this.pbFactura.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // lblEstadoFac
            // 
            this.lblEstadoFac.AutoSize = true;
            this.lblEstadoFac.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFac.Location = new System.Drawing.Point(181, 372);
            this.lblEstadoFac.Name = "lblEstadoFac";
            this.lblEstadoFac.Size = new System.Drawing.Size(53, 16);
            this.lblEstadoFac.TabIndex = 31;
            this.lblEstadoFac.Text = "Estado:";
            // 
            // lblFacturaConIva
            // 
            this.lblFacturaConIva.AutoSize = true;
            this.lblFacturaConIva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaConIva.Location = new System.Drawing.Point(10, 403);
            this.lblFacturaConIva.Name = "lblFacturaConIva";
            this.lblFacturaConIva.Size = new System.Drawing.Size(105, 16);
            this.lblFacturaConIva.TabIndex = 30;
            this.lblFacturaConIva.Text = "Factura con IVA:";
            // 
            // lblFacturaSinIva
            // 
            this.lblFacturaSinIva.AutoSize = true;
            this.lblFacturaSinIva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaSinIva.Location = new System.Drawing.Point(10, 385);
            this.lblFacturaSinIva.Name = "lblFacturaSinIva";
            this.lblFacturaSinIva.Size = new System.Drawing.Size(101, 16);
            this.lblFacturaSinIva.TabIndex = 29;
            this.lblFacturaSinIva.Text = "Factura sin IVA:";
            // 
            // lblCveFactura
            // 
            this.lblCveFactura.AutoSize = true;
            this.lblCveFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCveFactura.Location = new System.Drawing.Point(34, 359);
            this.lblCveFactura.Name = "lblCveFactura";
            this.lblCveFactura.Size = new System.Drawing.Size(67, 16);
            this.lblCveFactura.TabIndex = 28;
            this.lblCveFactura.Text = "# Factura:";
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaller.Location = new System.Drawing.Point(6, 146);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(46, 16);
            this.lblTaller.TabIndex = 27;
            this.lblTaller.Text = "Taller: ";
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortal.Location = new System.Drawing.Point(6, 130);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(50, 16);
            this.lblPortal.TabIndex = 26;
            this.lblPortal.Text = "Portal: ";
            // 
            // lblPrecioReparacion
            // 
            this.lblPrecioReparacion.AutoSize = true;
            this.lblPrecioReparacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioReparacion.Location = new System.Drawing.Point(154, 298);
            this.lblPrecioReparacion.Name = "lblPrecioReparacion";
            this.lblPrecioReparacion.Size = new System.Drawing.Size(131, 16);
            this.lblPrecioReparacion.TabIndex = 25;
            this.lblPrecioReparacion.Text = "Precio de reparacion:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(154, 282);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(101, 16);
            this.lblPrecioVenta.TabIndex = 24;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // lblClaveSeguimiento
            // 
            this.lblClaveSeguimiento.AutoSize = true;
            this.lblClaveSeguimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveSeguimiento.Location = new System.Drawing.Point(6, 97);
            this.lblClaveSeguimiento.Name = "lblClaveSeguimiento";
            this.lblClaveSeguimiento.Size = new System.Drawing.Size(107, 16);
            this.lblClaveSeguimiento.TabIndex = 23;
            this.lblClaveSeguimiento.Text = "Cve seguimiento:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(190, 106);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 16);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValuador
            // 
            this.lblValuador.AutoSize = true;
            this.lblValuador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuador.Location = new System.Drawing.Point(190, 90);
            this.lblValuador.Name = "lblValuador";
            this.lblValuador.Size = new System.Drawing.Size(62, 16);
            this.lblValuador.TabIndex = 21;
            this.lblValuador.Text = "Valuador:";
            // 
            // lblCostoNeto
            // 
            this.lblCostoNeto.AutoSize = true;
            this.lblCostoNeto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoNeto.Location = new System.Drawing.Point(10, 323);
            this.lblCostoNeto.Name = "lblCostoNeto";
            this.lblCostoNeto.Size = new System.Drawing.Size(77, 16);
            this.lblCostoNeto.TabIndex = 20;
            this.lblCostoNeto.Text = "Costo Neto:";
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoEnvio.Location = new System.Drawing.Point(10, 298);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(97, 16);
            this.lblCostoEnvio.TabIndex = 19;
            this.lblCostoEnvio.Text = "Costo de envio:";
            // 
            // lblCostoSinIva
            // 
            this.lblCostoSinIva.AutoSize = true;
            this.lblCostoSinIva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoSinIva.Location = new System.Drawing.Point(9, 282);
            this.lblCostoSinIva.Name = "lblCostoSinIva";
            this.lblCostoSinIva.Size = new System.Drawing.Size(91, 16);
            this.lblCostoSinIva.TabIndex = 18;
            this.lblCostoSinIva.Text = "Costo sin IVA:";
            // 
            // lblFechaEntreg
            // 
            this.lblFechaEntreg.AutoSize = true;
            this.lblFechaEntreg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntreg.Location = new System.Drawing.Point(9, 245);
            this.lblFechaEntreg.Name = "lblFechaEntreg";
            this.lblFechaEntreg.Size = new System.Drawing.Size(101, 16);
            this.lblFechaEntreg.TabIndex = 17;
            this.lblFechaEntreg.Text = "Fecha Entrega: ";
            // 
            // lblPromesa
            // 
            this.lblPromesa.AutoSize = true;
            this.lblPromesa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromesa.Location = new System.Drawing.Point(3, 194);
            this.lblPromesa.Name = "lblPromesa";
            this.lblPromesa.Size = new System.Drawing.Size(102, 16);
            this.lblPromesa.TabIndex = 13;
            this.lblPromesa.Text = "Fecha promesa:";
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacion.Location = new System.Drawing.Point(3, 178);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(108, 16);
            this.lblAsignacion.TabIndex = 12;
            this.lblAsignacion.Text = "Fecha asignada: ";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(6, 81);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(50, 16);
            this.lblOrigen.TabIndex = 11;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(159, 65);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(66, 16);
            this.lblVendedor.TabIndex = 10;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(159, 49);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(69, 16);
            this.lblProveedor.TabIndex = 8;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 16);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieza.Location = new System.Drawing.Point(6, 49);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(45, 16);
            this.lblPieza.TabIndex = 4;
            this.lblPieza.Text = "Pieza:";
            // 
            // lblcveSiniestro
            // 
            this.lblcveSiniestro.AutoSize = true;
            this.lblcveSiniestro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcveSiniestro.Location = new System.Drawing.Point(154, 20);
            this.lblcveSiniestro.Name = "lblcveSiniestro";
            this.lblcveSiniestro.Size = new System.Drawing.Size(74, 16);
            this.lblcveSiniestro.TabIndex = 2;
            this.lblcveSiniestro.Text = "# Siniestro:";
            // 
            // lblCvePed
            // 
            this.lblCvePed.AutoSize = true;
            this.lblCvePed.Location = new System.Drawing.Point(75, 20);
            this.lblCvePed.Name = "lblCvePed";
            this.lblCvePed.Size = new System.Drawing.Size(0, 13);
            this.lblCvePed.TabIndex = 1;
            // 
            // lblcvePedido
            // 
            this.lblcvePedido.AutoSize = true;
            this.lblcvePedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcvePedido.Location = new System.Drawing.Point(6, 17);
            this.lblcvePedido.Name = "lblcvePedido";
            this.lblcvePedido.Size = new System.Drawing.Size(63, 16);
            this.lblcvePedido.TabIndex = 0;
            this.lblcvePedido.Text = "# Pedido:";
            // 
            // dvgPedido
            // 
            this.dvgPedido.AllowUserToAddRows = false;
            this.dvgPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgPedido.Location = new System.Drawing.Point(355, 136);
            this.dvgPedido.Name = "dvgPedido";
            this.dvgPedido.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgPedido.RowHeadersWidth = 51;
            this.dvgPedido.Size = new System.Drawing.Size(740, 403);
            this.dvgPedido.TabIndex = 7;
            this.dvgPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPedido_CellContentClick);
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_Fin.Location = new System.Drawing.Point(230, 28);
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Size = new System.Drawing.Size(112, 25);
            this.Fecha_Fin.TabIndex = 8;
            this.Fecha_Fin.ValueChanged += new System.EventHandler(this.BusquedaFecha);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "a : ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(4, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 18);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "label11";
            // 
            // PanelFecha
            // 
            this.PanelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelFecha.Controls.Add(this.Fecha_in);
            this.PanelFecha.Controls.Add(this.label3);
            this.PanelFecha.Controls.Add(this.Fecha_Fin);
            this.PanelFecha.Controls.Add(this.label4);
            this.PanelFecha.Location = new System.Drawing.Point(416, 24);
            this.PanelFecha.Name = "PanelFecha";
            this.PanelFecha.Size = new System.Drawing.Size(356, 65);
            this.PanelFecha.TabIndex = 11;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Enabled = false;
            this.dgvDatos.Location = new System.Drawing.Point(819, 33);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(276, 53);
            this.dgvDatos.TabIndex = 12;
            this.dgvDatos.Visible = false;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(165, 89);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(124, 22);
            this.btnAgregarPedido.TabIndex = 13;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // pbAlertas
            // 
            this.pbAlertas.Image = global::Refracciones.Properties.Resources.notify;
            this.pbAlertas.InitialImage = global::Refracciones.Properties.Resources.notify;
            this.pbAlertas.Location = new System.Drawing.Point(987, 4);
            this.pbAlertas.Name = "pbAlertas";
            this.pbAlertas.Size = new System.Drawing.Size(28, 31);
            this.pbAlertas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlertas.TabIndex = 14;
            this.pbAlertas.TabStop = false;
            this.pbAlertas.Click += new System.EventHandler(this.pbAlertas_Click);
            // 
            // Busqueda_Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 576);
            this.Controls.Add(this.pbAlertas);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.PanelFecha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dvgPedido);
            this.Controls.Add(this.Panelinfo);
            this.Controls.Add(this.TxtClavePed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtClaveSin);
            this.Controls.Add(this.label1);
            this.Name = "Busqueda_Devolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda_Devolver";
            this.Load += new System.EventHandler(this.Busqueda_Devolver_Load);
            this.Panelinfo.ResumeLayout(false);
            this.Panelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPedido)).EndInit();
            this.PanelFecha.ResumeLayout(false);
            this.PanelFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlertas)).EndInit();
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
        public System.Windows.Forms.Label lblUsuario;
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
        private System.Windows.Forms.PictureBox pbAlertas;
    }
}