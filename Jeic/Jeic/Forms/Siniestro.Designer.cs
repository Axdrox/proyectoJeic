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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siniestro));
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoSiniestro = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.chbMarca = new System.Windows.Forms.CheckBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del siniestro:";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.ForeColor = System.Drawing.Color.White;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(156, 83);
            this.cbVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(168, 24);
            this.cbVehiculo.TabIndex = 2;
            this.cbVehiculo.Click += new System.EventHandler(this.cbVehiculo_Click);
            // 
            // lblVehiculoText
            // 
            this.lblVehiculoText.AutoSize = true;
            this.lblVehiculoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.lblVehiculoText.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoText.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoText.Location = new System.Drawing.Point(86, 84);
            this.lblVehiculoText.Name = "lblVehiculoText";
            this.lblVehiculoText.Size = new System.Drawing.Size(64, 23);
            this.lblVehiculoText.TabIndex = 3;
            this.lblVehiculoText.Text = "Modelo:";
            // 
            // lblAnioRegistro
            // 
            this.lblAnioRegistro.AutoSize = true;
            this.lblAnioRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.lblAnioRegistro.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioRegistro.ForeColor = System.Drawing.Color.White;
            this.lblAnioRegistro.Location = new System.Drawing.Point(94, 121);
            this.lblAnioRegistro.Name = "lblAnioRegistro";
            this.lblAnioRegistro.Size = new System.Drawing.Size(117, 23);
            this.lblAnioRegistro.TabIndex = 4;
            this.lblAnioRegistro.Text = "Seleccione año:";
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(241, 119);
            this.dtpYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(83, 22);
            this.dtpYear.TabIndex = 5;
            // 
            // txtClaveSiniestro
            // 
            this.txtClaveSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtClaveSiniestro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveSiniestro.ForeColor = System.Drawing.Color.White;
            this.txtClaveSiniestro.Location = new System.Drawing.Point(155, 15);
            this.txtClaveSiniestro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClaveSiniestro.Name = "txtClaveSiniestro";
            this.txtClaveSiniestro.Size = new System.Drawing.Size(169, 22);
            this.txtClaveSiniestro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label4.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.ForeColor = System.Drawing.Color.White;
            this.txtComentario.Location = new System.Drawing.Point(13, 239);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(407, 82);
            this.txtComentario.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(337, 335);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 27);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(245, 335);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.lblIngreseNombre.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.ForeColor = System.Drawing.Color.White;
            this.lblIngreseNombre.Location = new System.Drawing.Point(31, 84);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(117, 23);
            this.lblIngreseNombre.TabIndex = 11;
            this.lblIngreseNombre.Text = "Ingrese Modelo:";
            // 
            // txtNombreVehiculoNuevo
            // 
            this.txtNombreVehiculoNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtNombreVehiculoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreVehiculoNuevo.ForeColor = System.Drawing.Color.White;
            this.txtNombreVehiculoNuevo.Location = new System.Drawing.Point(156, 84);
            this.txtNombreVehiculoNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreVehiculoNuevo.Name = "txtNombreVehiculoNuevo";
            this.txtNombreVehiculoNuevo.Size = new System.Drawing.Size(167, 22);
            this.txtNombreVehiculoNuevo.TabIndex = 12;
            // 
            // chbOtroVehiculo
            // 
            this.chbOtroVehiculo.AutoSize = true;
            this.chbOtroVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.chbOtroVehiculo.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOtroVehiculo.ForeColor = System.Drawing.Color.White;
            this.chbOtroVehiculo.Location = new System.Drawing.Point(337, 82);
            this.chbOtroVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOtroVehiculo.Name = "chbOtroVehiculo";
            this.chbOtroVehiculo.Size = new System.Drawing.Size(62, 27);
            this.chbOtroVehiculo.TabIndex = 13;
            this.chbOtroVehiculo.Text = "Otro";
            this.chbOtroVehiculo.UseVisualStyleBackColor = false;
            this.chbOtroVehiculo.CheckedChanged += new System.EventHandler(this.chbOtroVehiculo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(78)))));
            this.label2.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Estado:";
            // 
            // cbEstadoSiniestro
            // 
            this.cbEstadoSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbEstadoSiniestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoSiniestro.ForeColor = System.Drawing.Color.White;
            this.cbEstadoSiniestro.FormattingEnabled = true;
            this.cbEstadoSiniestro.Location = new System.Drawing.Point(78, 167);
            this.cbEstadoSiniestro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoSiniestro.Name = "cbEstadoSiniestro";
            this.cbEstadoSiniestro.Size = new System.Drawing.Size(342, 24);
            this.cbEstadoSiniestro.TabIndex = 17;
            this.cbEstadoSiniestro.Click += new System.EventHandler(this.cbEstadoSiniestro_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.chbOtroVehiculo);
            this.bunifuGradientPanel1.Controls.Add(this.txtMarca);
            this.bunifuGradientPanel1.Controls.Add(this.cbMarca);
            this.bunifuGradientPanel1.Controls.Add(this.dtpYear);
            this.bunifuGradientPanel1.Controls.Add(this.chbMarca);
            this.bunifuGradientPanel1.Controls.Add(this.lblAnioRegistro);
            this.bunifuGradientPanel1.Controls.Add(this.lblMarca);
            this.bunifuGradientPanel1.Controls.Add(this.lblIngreseNombre);
            this.bunifuGradientPanel1.Controls.Add(this.cbEstadoSiniestro);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.lblVehiculoText);
            this.bunifuGradientPanel1.Controls.Add(this.txtNombreVehiculoNuevo);
            this.bunifuGradientPanel1.Controls.Add(this.cbVehiculo);
            this.bunifuGradientPanel1.Controls.Add(this.btnAceptar);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.txtComentario);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, -2);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(432, 375);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(156, 51);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(168, 22);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.Visible = false;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.ForeColor = System.Drawing.Color.White;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(155, 50);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(168, 24);
            this.cbMarca.TabIndex = 22;
            this.cbMarca.Click += new System.EventHandler(this.cbMarca_Click);
            // 
            // chbMarca
            // 
            this.chbMarca.AutoSize = true;
            this.chbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.chbMarca.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMarca.ForeColor = System.Drawing.Color.White;
            this.chbMarca.Location = new System.Drawing.Point(337, 51);
            this.chbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMarca.Name = "chbMarca";
            this.chbMarca.Size = new System.Drawing.Size(62, 27);
            this.chbMarca.TabIndex = 19;
            this.chbMarca.Text = "Otro";
            this.chbMarca.UseVisualStyleBackColor = false;
            this.chbMarca.CheckedChanged += new System.EventHandler(this.chbMarca_CheckedChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.lblMarca.Font = new System.Drawing.Font("Poppins Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(94, 53);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 23);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca:";
            // 
            // Siniestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(432, 371);
            this.ControlBox = false;
            this.Controls.Add(this.txtClaveSiniestro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Siniestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siniestro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Siniestro_FormClosing);
            this.Load += new System.EventHandler(this.Siniestro_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstadoSiniestro;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox chbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
    }
}