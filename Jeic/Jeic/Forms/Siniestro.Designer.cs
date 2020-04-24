namespace Refracciones.Forms
{
    partial class Siniestro
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
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.lblVehiculoText = new System.Windows.Forms.Label();
            this.lblAnioRegistro = new System.Windows.Forms.Label();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.txtClaveSiniestro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.txtNombreVehiculoNuevo = new System.Windows.Forms.TextBox();
            this.chbOtroVehiculo = new System.Windows.Forms.CheckBox();
            this.lblAnioTexto = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del siniestro:";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(146, 51);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(168, 24);
            this.cbVehiculo.TabIndex = 2;
            this.cbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbVehiculo_SelectedIndexChanged);
            // 
            // lblVehiculoText
            // 
            this.lblVehiculoText.AutoSize = true;
            this.lblVehiculoText.Location = new System.Drawing.Point(12, 54);
            this.lblVehiculoText.Name = "lblVehiculoText";
            this.lblVehiculoText.Size = new System.Drawing.Size(66, 17);
            this.lblVehiculoText.TabIndex = 3;
            this.lblVehiculoText.Text = "Vehículo:";
            // 
            // lblAnioRegistro
            // 
            this.lblAnioRegistro.AutoSize = true;
            this.lblAnioRegistro.Location = new System.Drawing.Point(14, 79);
            this.lblAnioRegistro.Name = "lblAnioRegistro";
            this.lblAnioRegistro.Size = new System.Drawing.Size(109, 17);
            this.lblAnioRegistro.TabIndex = 4;
            this.lblAnioRegistro.Text = "Seleccione año:";
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(146, 74);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(83, 22);
            this.dtpYear.TabIndex = 5;
            // 
            // txtClaveSiniestro
            // 
            this.txtClaveSiniestro.Location = new System.Drawing.Point(146, 10);
            this.txtClaveSiniestro.Name = "txtClaveSiniestro";
            this.txtClaveSiniestro.Size = new System.Drawing.Size(229, 22);
            this.txtClaveSiniestro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(15, 130);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(360, 148);
            this.txtComentario.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(291, 292);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 27);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Location = new System.Drawing.Point(14, 54);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(111, 17);
            this.lblIngreseNombre.TabIndex = 11;
            this.lblIngreseNombre.Text = "Ingrese nombre:";
            // 
            // txtNombreVehiculoNuevo
            // 
            this.txtNombreVehiculoNuevo.Location = new System.Drawing.Point(146, 51);
            this.txtNombreVehiculoNuevo.Name = "txtNombreVehiculoNuevo";
            this.txtNombreVehiculoNuevo.Size = new System.Drawing.Size(168, 22);
            this.txtNombreVehiculoNuevo.TabIndex = 12;
            // 
            // chbOtroVehiculo
            // 
            this.chbOtroVehiculo.AutoSize = true;
            this.chbOtroVehiculo.Location = new System.Drawing.Point(320, 53);
            this.chbOtroVehiculo.Name = "chbOtroVehiculo";
            this.chbOtroVehiculo.Size = new System.Drawing.Size(58, 21);
            this.chbOtroVehiculo.TabIndex = 13;
            this.chbOtroVehiculo.Text = "Otro";
            this.chbOtroVehiculo.UseVisualStyleBackColor = true;
            this.chbOtroVehiculo.CheckedChanged += new System.EventHandler(this.chbOtroVehiculo_CheckedChanged);
            // 
            // lblAnioTexto
            // 
            this.lblAnioTexto.AutoSize = true;
            this.lblAnioTexto.Location = new System.Drawing.Point(12, 79);
            this.lblAnioTexto.Name = "lblAnioTexto";
            this.lblAnioTexto.Size = new System.Drawing.Size(37, 17);
            this.lblAnioTexto.TabIndex = 14;
            this.lblAnioTexto.Text = "Año:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(143, 79);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(0, 17);
            this.lblAnio.TabIndex = 15;
            // 
            // Siniestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 331);
            this.ControlBox = false;
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblAnioTexto);
            this.Controls.Add(this.chbOtroVehiculo);
            this.Controls.Add(this.txtNombreVehiculoNuevo);
            this.Controls.Add(this.lblIngreseNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClaveSiniestro);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.lblAnioRegistro);
            this.Controls.Add(this.lblVehiculoText);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label1);
            this.Name = "Siniestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siniestro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Siniestro_FormClosing);
            this.Load += new System.EventHandler(this.Siniestro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Label lblVehiculoText;
        private System.Windows.Forms.Label lblAnioRegistro;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.TextBox txtClaveSiniestro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIngreseNombre;
        private System.Windows.Forms.TextBox txtNombreVehiculoNuevo;
        private System.Windows.Forms.CheckBox chbOtroVehiculo;
        private System.Windows.Forms.Label lblAnioTexto;
        private System.Windows.Forms.Label lblAnio;
    }
}