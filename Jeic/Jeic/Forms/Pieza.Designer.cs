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
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPortal = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtDiasEntrega = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una pieza:";
            // 
            // cbPiezaNombre
            // 
            this.cbPiezaNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiezaNombre.FormattingEnabled = true;
            this.cbPiezaNombre.Location = new System.Drawing.Point(145, 6);
            this.cbPiezaNombre.Name = "cbPiezaNombre";
            this.cbPiezaNombre.Size = new System.Drawing.Size(175, 24);
            this.cbPiezaNombre.TabIndex = 1;
            this.cbPiezaNombre.Click += new System.EventHandler(this.cbPiezaNombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Costo sin IVA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Costo neto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Costo de envío:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha costo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Precio venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Precio de reparación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Clave de producto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Número de guía:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 466);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Días entrega";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Entrega en tiempo:";
            // 
            // cbPortal
            // 
            this.cbPortal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortal.FormattingEnabled = true;
            this.cbPortal.Location = new System.Drawing.Point(145, 47);
            this.cbPortal.Name = "cbPortal";
            this.cbPortal.Size = new System.Drawing.Size(175, 24);
            this.cbPortal.TabIndex = 16;
            this.cbPortal.Click += new System.EventHandler(this.cbPortal_Click);
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(145, 86);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(175, 24);
            this.cbOrigen.TabIndex = 17;
            this.cbOrigen.Click += new System.EventHandler(this.cbOrigen_Click);
            // 
            // cbProveedores
            // 
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(145, 125);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(175, 24);
            this.cbProveedores.TabIndex = 18;
            this.cbProveedores.Click += new System.EventHandler(this.cbProveedores_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(205, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "$";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(205, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "$";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(205, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "$";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 305);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 26;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(205, 308);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "$";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(199, 326);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 22);
            this.textBox5.TabIndex = 28;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(205, 329);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 17);
            this.label20.TabIndex = 29;
            this.label20.Text = "$";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(107, 463);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 22);
            this.txtCantidad.TabIndex = 30;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(145, 373);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(244, 22);
            this.textBox7.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(145, 414);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(244, 22);
            this.textBox8.TabIndex = 32;
            // 
            // txtDiasEntrega
            // 
            this.txtDiasEntrega.Location = new System.Drawing.Point(271, 463);
            this.txtDiasEntrega.Name = "txtDiasEntrega";
            this.txtDiasEntrega.Size = new System.Drawing.Size(49, 22);
            this.txtDiasEntrega.TabIndex = 33;
            this.txtDiasEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasEntrega_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(162, 514);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 21);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sí";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(209, 514);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 21);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnAniadirPieza
            // 
            this.btnAniadirPieza.Location = new System.Drawing.Point(291, 549);
            this.btnAniadirPieza.Name = "btnAniadirPieza";
            this.btnAniadirPieza.Size = new System.Drawing.Size(98, 28);
            this.btnAniadirPieza.TabIndex = 36;
            this.btnAniadirPieza.Text = "Añadir pieza";
            this.btnAniadirPieza.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 549);
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
            this.chbOtroPieza.Location = new System.Drawing.Point(331, 9);
            this.chbOtroPieza.Name = "chbOtroPieza";
            this.chbOtroPieza.Size = new System.Drawing.Size(58, 21);
            this.chbOtroPieza.TabIndex = 38;
            this.chbOtroPieza.Text = "Otro";
            this.chbOtroPieza.UseVisualStyleBackColor = true;
            this.chbOtroPieza.CheckedChanged += new System.EventHandler(this.chbOtroPieza_CheckedChanged);
            // 
            // chbOtroPortal
            // 
            this.chbOtroPortal.AutoSize = true;
            this.chbOtroPortal.Location = new System.Drawing.Point(331, 49);
            this.chbOtroPortal.Name = "chbOtroPortal";
            this.chbOtroPortal.Size = new System.Drawing.Size(58, 21);
            this.chbOtroPortal.TabIndex = 39;
            this.chbOtroPortal.Text = "Otro";
            this.chbOtroPortal.UseVisualStyleBackColor = true;
            this.chbOtroPortal.CheckedChanged += new System.EventHandler(this.chbOtroPortal_CheckedChanged);
            // 
            // chbOtroOrigen
            // 
            this.chbOtroOrigen.AutoSize = true;
            this.chbOtroOrigen.Location = new System.Drawing.Point(331, 88);
            this.chbOtroOrigen.Name = "chbOtroOrigen";
            this.chbOtroOrigen.Size = new System.Drawing.Size(58, 21);
            this.chbOtroOrigen.TabIndex = 40;
            this.chbOtroOrigen.Text = "Otro";
            this.chbOtroOrigen.UseVisualStyleBackColor = true;
            this.chbOtroOrigen.CheckedChanged += new System.EventHandler(this.chbOtroOrigen_CheckedChanged);
            // 
            // chbOtroProveedor
            // 
            this.chbOtroProveedor.AutoSize = true;
            this.chbOtroProveedor.Location = new System.Drawing.Point(331, 127);
            this.chbOtroProveedor.Name = "chbOtroProveedor";
            this.chbOtroProveedor.Size = new System.Drawing.Size(58, 21);
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
            this.txtPiezaNombre.Size = new System.Drawing.Size(175, 22);
            this.txtPiezaNombre.TabIndex = 42;
            this.txtPiezaNombre.Text = "Escribe nombre de pieza";
            this.txtPiezaNombre.Visible = false;
            // 
            // txtPortal
            // 
            this.txtPortal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPortal.Location = new System.Drawing.Point(145, 47);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(175, 22);
            this.txtPortal.TabIndex = 43;
            this.txtPortal.Text = "Escribe nuevo portal";
            this.txtPortal.Visible = false;
            // 
            // txtOrigen
            // 
            this.txtOrigen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtOrigen.Location = new System.Drawing.Point(145, 86);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(175, 22);
            this.txtOrigen.TabIndex = 44;
            this.txtOrigen.Text = "Escribe un nuevo origen";
            this.txtOrigen.Visible = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtProveedor.Location = new System.Drawing.Point(145, 125);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(175, 22);
            this.txtProveedor.TabIndex = 45;
            this.txtProveedor.Text = "Escribe un nuevo proveedor";
            this.txtProveedor.Visible = false;
            // 
            // Pieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 589);
            this.ControlBox = false;
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
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtDiasEntrega);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.cbPortal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPortal;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtDiasEntrega;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
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
    }
}