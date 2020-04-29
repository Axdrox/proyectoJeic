namespace Refracciones.Forms
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
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.chkFechaPago = new System.Windows.Forms.CheckBox();
            this.chkFechaRevision = new System.Windows.Forms.CheckBox();
            this.chkFechaIngreso = new System.Windows.Forms.CheckBox();
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
            this.chkFechaRefacturacion = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dato1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADA",
            "CANCELADA"});
            this.cmbEstadoFactura.Location = new System.Drawing.Point(348, 184);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFactura.TabIndex = 52;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Location = new System.Drawing.Point(220, 192);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(105, 13);
            this.lblEstadoFactura.TabIndex = 51;
            this.lblEstadoFactura.Text = "Estado de la Factura";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(318, 229);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(65, 13);
            this.lblComentarios.TabIndex = 50;
            this.lblComentarios.Text = "Comentarios";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(321, 245);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(313, 131);
            this.txtComentario.TabIndex = 49;
            // 
            // chkFechaPago
            // 
            this.chkFechaPago.AutoSize = true;
            this.chkFechaPago.Enabled = false;
            this.chkFechaPago.Location = new System.Drawing.Point(554, 157);
            this.chkFechaPago.Name = "chkFechaPago";
            this.chkFechaPago.Size = new System.Drawing.Size(15, 14);
            this.chkFechaPago.TabIndex = 48;
            this.chkFechaPago.UseVisualStyleBackColor = true;
            this.chkFechaPago.Visible = false;
            // 
            // chkFechaRevision
            // 
            this.chkFechaRevision.AutoSize = true;
            this.chkFechaRevision.Location = new System.Drawing.Point(554, 123);
            this.chkFechaRevision.Name = "chkFechaRevision";
            this.chkFechaRevision.Size = new System.Drawing.Size(15, 14);
            this.chkFechaRevision.TabIndex = 47;
            this.chkFechaRevision.UseVisualStyleBackColor = true;
            // 
            // chkFechaIngreso
            // 
            this.chkFechaIngreso.AutoSize = true;
            this.chkFechaIngreso.Location = new System.Drawing.Point(554, 85);
            this.chkFechaIngreso.Name = "chkFechaIngreso";
            this.chkFechaIngreso.Size = new System.Drawing.Size(15, 14);
            this.chkFechaIngreso.TabIndex = 46;
            this.chkFechaIngreso.UseVisualStyleBackColor = true;
            this.chkFechaIngreso.CheckedChanged += new System.EventHandler(this.chkFechaIngreso_CheckedChanged);
            // 
            // btnBuscarXml
            // 
            this.btnBuscarXml.Location = new System.Drawing.Point(256, 328);
            this.btnBuscarXml.Name = "btnBuscarXml";
            this.btnBuscarXml.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarXml.TabIndex = 45;
            this.btnBuscarXml.Text = "...";
            this.btnBuscarXml.UseVisualStyleBackColor = true;
            this.btnBuscarXml.Click += new System.EventHandler(this.btnBuscarXml_Click);
            // 
            // txtRutaXml
            // 
            this.txtRutaXml.Location = new System.Drawing.Point(22, 328);
            this.txtRutaXml.Name = "txtRutaXml";
            this.txtRutaXml.ReadOnly = true;
            this.txtRutaXml.Size = new System.Drawing.Size(228, 20);
            this.txtRutaXml.TabIndex = 44;
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(19, 312);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(24, 13);
            this.lblXml.TabIndex = 43;
            this.lblXml.Text = "Xml";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(220, 154);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 42;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // lblFechaRevision
            // 
            this.lblFechaRevision.AutoSize = true;
            this.lblFechaRevision.Location = new System.Drawing.Point(220, 120);
            this.lblFechaRevision.Name = "lblFechaRevision";
            this.lblFechaRevision.Size = new System.Drawing.Size(96, 13);
            this.lblFechaRevision.TabIndex = 41;
            this.lblFechaRevision.Text = "Fecha de Revisión";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Enabled = false;
            this.dtpFechaPago.Location = new System.Drawing.Point(348, 154);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 40;
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(348, 120);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRevision.TabIndex = 39;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(220, 85);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 38;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(348, 86);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 37;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // lblFacturaConIVA
            // 
            this.lblFacturaConIVA.AutoSize = true;
            this.lblFacturaConIVA.Location = new System.Drawing.Point(18, 161);
            this.lblFacturaConIVA.Name = "lblFacturaConIVA";
            this.lblFacturaConIVA.Size = new System.Drawing.Size(84, 13);
            this.lblFacturaConIVA.TabIndex = 36;
            this.lblFacturaConIVA.Text = "Factura con IVA";
            // 
            // txtFacturasinIVA
            // 
            this.txtFacturasinIVA.Location = new System.Drawing.Point(109, 124);
            this.txtFacturasinIVA.Name = "txtFacturasinIVA";
            this.txtFacturasinIVA.Size = new System.Drawing.Size(100, 20);
            this.txtFacturasinIVA.TabIndex = 35;
            this.txtFacturasinIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacturasinIVA_KeyPress);
            // 
            // txtRefactura
            // 
            this.txtRefactura.Location = new System.Drawing.Point(109, 86);
            this.txtRefactura.Name = "txtRefactura";
            this.txtRefactura.Size = new System.Drawing.Size(100, 20);
            this.txtRefactura.TabIndex = 34;
            this.txtRefactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefactura_KeyPress);
            // 
            // lblClave_FacturaAnterior
            // 
            this.lblClave_FacturaAnterior.AutoSize = true;
            this.lblClave_FacturaAnterior.Location = new System.Drawing.Point(19, 50);
            this.lblClave_FacturaAnterior.Name = "lblClave_FacturaAnterior";
            this.lblClave_FacturaAnterior.Size = new System.Drawing.Size(65, 13);
            this.lblClave_FacturaAnterior.TabIndex = 33;
            this.lblClave_FacturaAnterior.Text = "Cve Factura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(559, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.Location = new System.Drawing.Point(256, 287);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarFact.TabIndex = 31;
            this.btnBuscarFact.Text = "...";
            this.btnBuscarFact.UseVisualStyleBackColor = true;
            this.btnBuscarFact.Click += new System.EventHandler(this.btnBuscarFact_Click);
            // 
            // txtRutaFactura
            // 
            this.txtRutaFactura.Location = new System.Drawing.Point(22, 289);
            this.txtRutaFactura.Name = "txtRutaFactura";
            this.txtRutaFactura.ReadOnly = true;
            this.txtRutaFactura.Size = new System.Drawing.Size(228, 20);
            this.txtRutaFactura.TabIndex = 30;
            // 
            // txtCve_Factura
            // 
            this.txtCve_Factura.Location = new System.Drawing.Point(109, 50);
            this.txtCve_Factura.Name = "txtCve_Factura";
            this.txtCve_Factura.Size = new System.Drawing.Size(100, 20);
            this.txtCve_Factura.TabIndex = 29;
            this.txtCve_Factura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCve_Factura_KeyPress);
            // 
            // lblFacturaSinIVA
            // 
            this.lblFacturaSinIVA.AutoSize = true;
            this.lblFacturaSinIVA.Location = new System.Drawing.Point(18, 124);
            this.lblFacturaSinIVA.Name = "lblFacturaSinIVA";
            this.lblFacturaSinIVA.Size = new System.Drawing.Size(79, 13);
            this.lblFacturaSinIVA.TabIndex = 28;
            this.lblFacturaSinIVA.Text = "Factura sin IVA";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(19, 273);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(43, 13);
            this.lblFactura.TabIndex = 27;
            this.lblFactura.Text = "Factura";
            // 
            // lblRefactura
            // 
            this.lblRefactura.AutoSize = true;
            this.lblRefactura.Location = new System.Drawing.Point(14, 86);
            this.lblRefactura.Name = "lblRefactura";
            this.lblRefactura.Size = new System.Drawing.Size(88, 13);
            this.lblRefactura.TabIndex = 53;
            this.lblRefactura.Text = "Cve a Refacturar";
            // 
            // txtFacturaconIVA
            // 
            this.txtFacturaconIVA.Location = new System.Drawing.Point(109, 161);
            this.txtFacturaconIVA.Name = "txtFacturaconIVA";
            this.txtFacturaconIVA.ReadOnly = true;
            this.txtFacturaconIVA.Size = new System.Drawing.Size(100, 20);
            this.txtFacturaconIVA.TabIndex = 54;
            // 
            // lblCostoRefactura
            // 
            this.lblCostoRefactura.AutoSize = true;
            this.lblCostoRefactura.Location = new System.Drawing.Point(19, 200);
            this.lblCostoRefactura.Name = "lblCostoRefactura";
            this.lblCostoRefactura.Size = new System.Drawing.Size(84, 13);
            this.lblCostoRefactura.TabIndex = 55;
            this.lblCostoRefactura.Text = "Costo Refactura";
            // 
            // txtCostoRefactura
            // 
            this.txtCostoRefactura.Location = new System.Drawing.Point(109, 200);
            this.txtCostoRefactura.Name = "txtCostoRefactura";
            this.txtCostoRefactura.Size = new System.Drawing.Size(100, 20);
            this.txtCostoRefactura.TabIndex = 56;
            this.txtCostoRefactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoRefactura_KeyPress);
            // 
            // lblFechaRefacturacion
            // 
            this.lblFechaRefacturacion.AutoSize = true;
            this.lblFechaRefacturacion.Location = new System.Drawing.Point(220, 47);
            this.lblFechaRefacturacion.Name = "lblFechaRefacturacion";
            this.lblFechaRefacturacion.Size = new System.Drawing.Size(122, 13);
            this.lblFechaRefacturacion.TabIndex = 57;
            this.lblFechaRefacturacion.Text = "Fecha de Refacturacion";
            // 
            // dtpFechaRefacturacion
            // 
            this.dtpFechaRefacturacion.Location = new System.Drawing.Point(348, 47);
            this.dtpFechaRefacturacion.Name = "dtpFechaRefacturacion";
            this.dtpFechaRefacturacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRefacturacion.TabIndex = 58;
            // 
            // chkFechaRefacturacion
            // 
            this.chkFechaRefacturacion.AutoSize = true;
            this.chkFechaRefacturacion.Location = new System.Drawing.Point(554, 47);
            this.chkFechaRefacturacion.Name = "chkFechaRefacturacion";
            this.chkFechaRefacturacion.Size = new System.Drawing.Size(15, 14);
            this.chkFechaRefacturacion.TabIndex = 59;
            this.chkFechaRefacturacion.UseVisualStyleBackColor = true;
            this.chkFechaRefacturacion.CheckedChanged += new System.EventHandler(this.chkFechaRefacturacion_CheckedChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(43, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.Visible = false;
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.Location = new System.Drawing.Point(7, 13);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(69, 13);
            this.dato1.TabIndex = 61;
            this.dato1.Text = "cve_siniestro";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Location = new System.Drawing.Point(10, 34);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(63, 13);
            this.dato2.TabIndex = 62;
            this.dato2.Text = "cve_pedido";
            // 
            // registrarRefactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkFechaRefacturacion);
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
            this.Controls.Add(this.chkFechaPago);
            this.Controls.Add(this.chkFechaRevision);
            this.Controls.Add(this.chkFechaIngreso);
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
            this.Name = "registrarRefactura";
            this.Text = "registrarRefactura";
            this.Load += new System.EventHandler(this.registrarRefactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.CheckBox chkFechaPago;
        private System.Windows.Forms.CheckBox chkFechaRevision;
        private System.Windows.Forms.CheckBox chkFechaIngreso;
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
        private System.Windows.Forms.TextBox txtRefactura;
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
        private System.Windows.Forms.CheckBox chkFechaRefacturacion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dato1;
        private System.Windows.Forms.Label dato2;
    }
}