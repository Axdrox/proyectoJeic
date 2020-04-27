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
            this.chkFechaIngreso = new System.Windows.Forms.CheckBox();
            this.chkFechaRevision = new System.Windows.Forms.CheckBox();
            this.chkFechaPago = new System.Windows.Forms.CheckBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.cmbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dato1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 179);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(43, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Factura";
            // 
            // lblFacturaSinIVA
            // 
            this.lblFacturaSinIVA.AutoSize = true;
            this.lblFacturaSinIVA.Location = new System.Drawing.Point(15, 94);
            this.lblFacturaSinIVA.Name = "lblFacturaSinIVA";
            this.lblFacturaSinIVA.Size = new System.Drawing.Size(79, 13);
            this.lblFacturaSinIVA.TabIndex = 1;
            this.lblFacturaSinIVA.Text = "Factura sin IVA";
            // 
            // txtCve_Factura
            // 
            this.txtCve_Factura.Location = new System.Drawing.Point(106, 58);
            this.txtCve_Factura.Name = "txtCve_Factura";
            this.txtCve_Factura.Size = new System.Drawing.Size(100, 20);
            this.txtCve_Factura.TabIndex = 2;
            // 
            // txtRutaFactura
            // 
            this.txtRutaFactura.Location = new System.Drawing.Point(50, 195);
            this.txtRutaFactura.Name = "txtRutaFactura";
            this.txtRutaFactura.ReadOnly = true;
            this.txtRutaFactura.Size = new System.Drawing.Size(228, 20);
            this.txtRutaFactura.TabIndex = 3;
            // 
            // btnBuscarFact
            // 
            this.btnBuscarFact.Location = new System.Drawing.Point(284, 195);
            this.btnBuscarFact.Name = "btnBuscarFact";
            this.btnBuscarFact.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarFact.TabIndex = 4;
            this.btnBuscarFact.Text = "...";
            this.btnBuscarFact.UseVisualStyleBackColor = true;
            this.btnBuscarFact.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(480, 385);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblClave_Factura
            // 
            this.lblClave_Factura.AutoSize = true;
            this.lblClave_Factura.Location = new System.Drawing.Point(15, 58);
            this.lblClave_Factura.Name = "lblClave_Factura";
            this.lblClave_Factura.Size = new System.Drawing.Size(65, 13);
            this.lblClave_Factura.TabIndex = 6;
            this.lblClave_Factura.Text = "Cve Factura";
            this.lblClave_Factura.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFacturasinIVA
            // 
            this.txtFacturasinIVA.Location = new System.Drawing.Point(106, 94);
            this.txtFacturasinIVA.Name = "txtFacturasinIVA";
            this.txtFacturasinIVA.Size = new System.Drawing.Size(100, 20);
            this.txtFacturasinIVA.TabIndex = 7;
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
            this.txtFacturaconIVA.Location = new System.Drawing.Point(106, 132);
            this.txtFacturaconIVA.Name = "txtFacturaconIVA";
            this.txtFacturaconIVA.Size = new System.Drawing.Size(100, 20);
            this.txtFacturaconIVA.TabIndex = 9;
            // 
            // lblFacturaConIVA
            // 
            this.lblFacturaConIVA.AutoSize = true;
            this.lblFacturaConIVA.Location = new System.Drawing.Point(16, 132);
            this.lblFacturaConIVA.Name = "lblFacturaConIVA";
            this.lblFacturaConIVA.Size = new System.Drawing.Size(84, 13);
            this.lblFacturaConIVA.TabIndex = 10;
            this.lblFacturaConIVA.Text = "Factura con IVA";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(358, 58);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 11;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(256, 58);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaRevision
            // 
            this.dtpFechaRevision.Location = new System.Drawing.Point(358, 94);
            this.dtpFechaRevision.Name = "dtpFechaRevision";
            this.dtpFechaRevision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRevision.TabIndex = 13;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(358, 132);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPago.TabIndex = 14;
            // 
            // lblFechaRevision
            // 
            this.lblFechaRevision.AutoSize = true;
            this.lblFechaRevision.Location = new System.Drawing.Point(256, 94);
            this.lblFechaRevision.Name = "lblFechaRevision";
            this.lblFechaRevision.Size = new System.Drawing.Size(96, 13);
            this.lblFechaRevision.TabIndex = 15;
            this.lblFechaRevision.Text = "Fecha de Revisión";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(256, 132);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(80, 13);
            this.lblFechaPago.TabIndex = 16;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Xml";
            // 
            // txtRutaXml
            // 
            this.txtRutaXml.Location = new System.Drawing.Point(50, 234);
            this.txtRutaXml.Name = "txtRutaXml";
            this.txtRutaXml.ReadOnly = true;
            this.txtRutaXml.Size = new System.Drawing.Size(228, 20);
            this.txtRutaXml.TabIndex = 18;
            // 
            // btnBuscarXml
            // 
            this.btnBuscarXml.Location = new System.Drawing.Point(284, 234);
            this.btnBuscarXml.Name = "btnBuscarXml";
            this.btnBuscarXml.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarXml.TabIndex = 19;
            this.btnBuscarXml.Text = "...";
            this.btnBuscarXml.UseVisualStyleBackColor = true;
            this.btnBuscarXml.Click += new System.EventHandler(this.btnBuscarXml_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // chkFechaIngreso
            // 
            this.chkFechaIngreso.AutoSize = true;
            this.chkFechaIngreso.Location = new System.Drawing.Point(565, 60);
            this.chkFechaIngreso.Name = "chkFechaIngreso";
            this.chkFechaIngreso.Size = new System.Drawing.Size(80, 17);
            this.chkFechaIngreso.TabIndex = 20;
            this.chkFechaIngreso.Text = "checkBox1";
            this.chkFechaIngreso.UseVisualStyleBackColor = true;
            // 
            // chkFechaRevision
            // 
            this.chkFechaRevision.AutoSize = true;
            this.chkFechaRevision.Location = new System.Drawing.Point(565, 96);
            this.chkFechaRevision.Name = "chkFechaRevision";
            this.chkFechaRevision.Size = new System.Drawing.Size(80, 17);
            this.chkFechaRevision.TabIndex = 21;
            this.chkFechaRevision.Text = "checkBox2";
            this.chkFechaRevision.UseVisualStyleBackColor = true;
            // 
            // chkFechaPago
            // 
            this.chkFechaPago.AutoSize = true;
            this.chkFechaPago.Location = new System.Drawing.Point(565, 134);
            this.chkFechaPago.Name = "chkFechaPago";
            this.chkFechaPago.Size = new System.Drawing.Size(80, 17);
            this.chkFechaPago.TabIndex = 22;
            this.chkFechaPago.Text = "checkBox3";
            this.chkFechaPago.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(18, 286);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(313, 131);
            this.txtComentario.TabIndex = 23;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(15, 270);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(65, 13);
            this.lblComentarios.TabIndex = 24;
            this.lblComentarios.Text = "Comentarios";
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Location = new System.Drawing.Point(247, 173);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(105, 13);
            this.lblEstadoFactura.TabIndex = 25;
            this.lblEstadoFactura.Text = "Estado de la Factura";
            this.lblEstadoFactura.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.Items.AddRange(new object[] {
            "PENDIENTE",
            "PAGADA",
            "CANCELADA"});
            this.cmbEstadoFactura.Location = new System.Drawing.Point(358, 170);
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoFactura.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(335, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.Location = new System.Drawing.Point(13, 4);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(69, 13);
            this.dato1.TabIndex = 28;
            this.dato1.Text = "cve_siniestro";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Location = new System.Drawing.Point(15, 26);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(63, 13);
            this.dato2.TabIndex = 29;
            this.dato2.Text = "cve_pedido";
            // 
            // registroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEstadoFactura);
            this.Controls.Add(this.lblEstadoFactura);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.chkFechaPago);
            this.Controls.Add(this.chkFechaRevision);
            this.Controls.Add(this.chkFechaIngreso);
            this.Controls.Add(this.btnBuscarXml);
            this.Controls.Add(this.txtRutaXml);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblFechaRevision);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dtpFechaRevision);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFacturaConIVA);
            this.Controls.Add(this.txtFacturaconIVA);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtFacturasinIVA);
            this.Controls.Add(this.lblClave_Factura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarFact);
            this.Controls.Add(this.txtRutaFactura);
            this.Controls.Add(this.txtCve_Factura);
            this.Controls.Add(this.lblFacturaSinIVA);
            this.Controls.Add(this.lblNombre);
            this.Name = "registroFactura";
            this.Text = "registroFactura";
            this.Load += new System.EventHandler(this.registroFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.CheckBox chkFechaIngreso;
        private System.Windows.Forms.CheckBox chkFechaRevision;
        private System.Windows.Forms.CheckBox chkFechaPago;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.ComboBox cmbEstadoFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dato1;
        private System.Windows.Forms.Label dato2;
    }
}