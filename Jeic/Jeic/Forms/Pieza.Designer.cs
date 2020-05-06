namespace Refracciones.Forms
{
    partial class Pieza
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
            this.cbPiezaNombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPortal = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.dtpFechaCosto = new System.Windows.Forms.DateTimePicker();
            this.txtCostoSinIVA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCostoNeto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrecioReparacion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.txtNumeroGuia = new System.Windows.Forms.TextBox();
            this.btnAniadirPieza = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbOtroPieza = new System.Windows.Forms.CheckBox();
            this.chbOtroPortal = new System.Windows.Forms.CheckBox();
            this.chbOtroOrigen = new System.Windows.Forms.CheckBox();
            this.chbOtroProveedor = new System.Windows.Forms.CheckBox();
            this.txtPiezaNombre = new System.Windows.Forms.TextBox();
            this.txtPortal = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.cbCostoEnvio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una pieza:";
            // 
            // cbPiezaNombre
            // 
            this.cbPiezaNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiezaNombre.FormattingEnabled = true;
            this.cbPiezaNombre.Location = new System.Drawing.Point(145, 6);
            this.cbPiezaNombre.Name = "cbPiezaNombre";
            this.cbPiezaNombre.Size = new System.Drawing.Size(196, 24);
            this.cbPiezaNombre.TabIndex = 1;
            this.cbPiezaNombre.Click += new System.EventHandler(this.cbPiezaNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Costo sin IVA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Costo neto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Costo de envío:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha costo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Precio de reparación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Clave de producto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Número de guía:";
            // 
            // cbPortal
            // 
            this.cbPortal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortal.FormattingEnabled = true;
            this.cbPortal.Location = new System.Drawing.Point(145, 127);
            this.cbPortal.Name = "cbPortal";
            this.cbPortal.Size = new System.Drawing.Size(196, 24);
            this.cbPortal.TabIndex = 16;
            this.cbPortal.Click += new System.EventHandler(this.cbPortal_Click);
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(145, 166);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(196, 24);
            this.cbOrigen.TabIndex = 17;
            this.cbOrigen.Click += new System.EventHandler(this.cbOrigen_Click);
            // 
            // cbProveedores
            // 
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(145, 205);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(196, 24);
            this.cbProveedores.TabIndex = 18;
            this.cbProveedores.Click += new System.EventHandler(this.cbProveedores_Click);
            // 
            // dtpFechaCosto
            // 
            this.dtpFechaCosto.Location = new System.Drawing.Point(147, 250);
            this.dtpFechaCosto.Name = "dtpFechaCosto";
            this.dtpFechaCosto.Size = new System.Drawing.Size(260, 22);
            this.dtpFechaCosto.TabIndex = 19;
            // 
            // txtCostoSinIVA
            // 
            this.txtCostoSinIVA.Location = new System.Drawing.Point(201, 281);
            this.txtCostoSinIVA.Name = "txtCostoSinIVA";
            this.txtCostoSinIVA.Size = new System.Drawing.Size(121, 22);
            this.txtCostoSinIVA.TabIndex = 20;
            this.txtCostoSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoSinIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoSinIVA_KeyPress);
            this.txtCostoSinIVA.Leave += new System.EventHandler(this.txtCostoSinIVA_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(207, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "$";
            // 
            // txtCostoNeto
            // 
            this.txtCostoNeto.Enabled = false;
            this.txtCostoNeto.Location = new System.Drawing.Point(201, 306);
            this.txtCostoNeto.Name = "txtCostoNeto";
            this.txtCostoNeto.Size = new System.Drawing.Size(121, 22);
            this.txtCostoNeto.TabIndex = 22;
            this.txtCostoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoNeto_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(207, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "$";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(201, 382);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(121, 22);
            this.txtPrecioVenta.TabIndex = 26;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(207, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 16);
            this.label19.TabIndex = 27;
            this.label19.Text = "$";
            // 
            // txtPrecioReparacion
            // 
            this.txtPrecioReparacion.Location = new System.Drawing.Point(201, 403);
            this.txtPrecioReparacion.Name = "txtPrecioReparacion";
            this.txtPrecioReparacion.Size = new System.Drawing.Size(121, 22);
            this.txtPrecioReparacion.TabIndex = 28;
            this.txtPrecioReparacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioReparacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioReparacion_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(207, 406);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 16);
            this.label20.TabIndex = 29;
            this.label20.Text = "$";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(145, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 22);
            this.txtCantidad.TabIndex = 30;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Location = new System.Drawing.Point(145, 62);
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(244, 22);
            this.txtClaveProducto.TabIndex = 31;
            // 
            // txtNumeroGuia
            // 
            this.txtNumeroGuia.Location = new System.Drawing.Point(145, 90);
            this.txtNumeroGuia.Name = "txtNumeroGuia";
            this.txtNumeroGuia.Size = new System.Drawing.Size(244, 22);
            this.txtNumeroGuia.TabIndex = 32;
            // 
            // btnAniadirPieza
            // 
            this.btnAniadirPieza.Location = new System.Drawing.Point(314, 448);
            this.btnAniadirPieza.Name = "btnAniadirPieza";
            this.btnAniadirPieza.Size = new System.Drawing.Size(98, 28);
            this.btnAniadirPieza.TabIndex = 36;
            this.btnAniadirPieza.Text = "Añadir pieza";
            this.btnAniadirPieza.UseVisualStyleBackColor = true;
            this.btnAniadirPieza.Click += new System.EventHandler(this.btnAniadirPieza_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 448);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 28);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbOtroPieza
            // 
            this.chbOtroPieza.AutoSize = true;
            this.chbOtroPieza.Location = new System.Drawing.Point(347, 8);
            this.chbOtroPieza.Name = "chbOtroPieza";
            this.chbOtroPieza.Size = new System.Drawing.Size(52, 20);
            this.chbOtroPieza.TabIndex = 38;
            this.chbOtroPieza.Text = "Otro";
            this.chbOtroPieza.UseVisualStyleBackColor = true;
            this.chbOtroPieza.CheckedChanged += new System.EventHandler(this.chbOtroPieza_CheckedChanged);
            // 
            // chbOtroPortal
            // 
            this.chbOtroPortal.AutoSize = true;
            this.chbOtroPortal.Location = new System.Drawing.Point(347, 128);
            this.chbOtroPortal.Name = "chbOtroPortal";
            this.chbOtroPortal.Size = new System.Drawing.Size(52, 20);
            this.chbOtroPortal.TabIndex = 39;
            this.chbOtroPortal.Text = "Otro";
            this.chbOtroPortal.UseVisualStyleBackColor = true;
            this.chbOtroPortal.CheckedChanged += new System.EventHandler(this.chbOtroPortal_CheckedChanged);
            // 
            // chbOtroOrigen
            // 
            this.chbOtroOrigen.AutoSize = true;
            this.chbOtroOrigen.Location = new System.Drawing.Point(347, 167);
            this.chbOtroOrigen.Name = "chbOtroOrigen";
            this.chbOtroOrigen.Size = new System.Drawing.Size(52, 20);
            this.chbOtroOrigen.TabIndex = 40;
            this.chbOtroOrigen.Text = "Otro";
            this.chbOtroOrigen.UseVisualStyleBackColor = true;
            this.chbOtroOrigen.CheckedChanged += new System.EventHandler(this.chbOtroOrigen_CheckedChanged);
            // 
            // chbOtroProveedor
            // 
            this.chbOtroProveedor.AutoSize = true;
            this.chbOtroProveedor.Location = new System.Drawing.Point(347, 206);
            this.chbOtroProveedor.Name = "chbOtroProveedor";
            this.chbOtroProveedor.Size = new System.Drawing.Size(52, 20);
            this.chbOtroProveedor.TabIndex = 41;
            this.chbOtroProveedor.Text = "Otro";
            this.chbOtroProveedor.UseVisualStyleBackColor = true;
            this.chbOtroProveedor.CheckedChanged += new System.EventHandler(this.chbOtroProveedor_CheckedChanged);
            // 
            // txtPiezaNombre
            // 
            this.txtPiezaNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPiezaNombre.Location = new System.Drawing.Point(145, 6);
            this.txtPiezaNombre.Name = "txtPiezaNombre";
            this.txtPiezaNombre.Size = new System.Drawing.Size(196, 22);
            this.txtPiezaNombre.TabIndex = 42;
            this.txtPiezaNombre.Text = "Escribe nombre de pieza";
            this.txtPiezaNombre.Visible = false;
            this.txtPiezaNombre.Click += new System.EventHandler(this.txtPiezaNombre_Click);
            // 
            // txtPortal
            // 
            this.txtPortal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPortal.Location = new System.Drawing.Point(145, 127);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(196, 22);
            this.txtPortal.TabIndex = 43;
            this.txtPortal.Text = "Escribe nuevo portal";
            this.txtPortal.Visible = false;
            this.txtPortal.Click += new System.EventHandler(this.txtPortal_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtOrigen.Location = new System.Drawing.Point(145, 166);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(196, 22);
            this.txtOrigen.TabIndex = 44;
            this.txtOrigen.Text = "Escribe un nuevo origen";
            this.txtOrigen.Visible = false;
            this.txtOrigen.Click += new System.EventHandler(this.txtOrigen_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtProveedor.Location = new System.Drawing.Point(145, 205);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(196, 22);
            this.txtProveedor.TabIndex = 45;
            this.txtProveedor.Text = "Escribe un nuevo proveedor";
            this.txtProveedor.Visible = false;
            this.txtProveedor.Click += new System.EventHandler(this.txtProveedor_Click);
            // 
            // cbCostoEnvio
            // 
            this.cbCostoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostoEnvio.FormattingEnabled = true;
            this.cbCostoEnvio.Location = new System.Drawing.Point(201, 329);
            this.cbCostoEnvio.Name = "cbCostoEnvio";
            this.cbCostoEnvio.Size = new System.Drawing.Size(121, 24);
            this.cbCostoEnvio.TabIndex = 46;
            this.cbCostoEnvio.Click += new System.EventHandler(this.cbCostoEnvio_Click);
            // 
            // Pieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 488);
            this.ControlBox = false;
            this.Controls.Add(this.cbCostoEnvio);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtPortal);
            this.Controls.Add(this.txtPiezaNombre);
            this.Controls.Add(this.chbOtroProveedor);
            this.Controls.Add(this.chbOtroOrigen);
            this.Controls.Add(this.chbOtroPortal);
            this.Controls.Add(this.chbOtroPieza);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAniadirPieza);
            this.Controls.Add(this.txtNumeroGuia);
            this.Controls.Add(this.txtClaveProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtPrecioReparacion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCostoNeto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCostoSinIVA);
            this.Controls.Add(this.dtpFechaCosto);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.cbPortal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPiezaNombre);
            this.Controls.Add(this.label1);
            this.Name = "Pieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pieza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pieza_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPiezaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPortal;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.DateTimePicker dtpFechaCosto;
        private System.Windows.Forms.TextBox txtCostoSinIVA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCostoNeto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecioReparacion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.TextBox txtNumeroGuia;
        private System.Windows.Forms.Button btnAniadirPieza;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbOtroPieza;
        private System.Windows.Forms.CheckBox chbOtroPortal;
        private System.Windows.Forms.CheckBox chbOtroOrigen;
        private System.Windows.Forms.CheckBox chbOtroProveedor;
        private System.Windows.Forms.TextBox txtPiezaNombre;
        private System.Windows.Forms.TextBox txtPortal;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.ComboBox cbCostoEnvio;
    }
}