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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.chbMarca = new System.Windows.Forms.CheckBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave siniestro:";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVehiculo.BackColor = System.Drawing.Color.White;
            this.cbVehiculo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbVehiculo.ForeColor = System.Drawing.Color.Black;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Location = new System.Drawing.Point(117, 67);
            this.cbVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(127, 21);
            this.cbVehiculo.TabIndex = 2;
            this.cbVehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbVehiculo_KeyPress);
            this.cbVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.cbVehiculo_Validating);
            // 
            // lblVehiculoText
            // 
            this.lblVehiculoText.AutoSize = true;
            this.lblVehiculoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.lblVehiculoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoText.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoText.Location = new System.Drawing.Point(64, 68);
            this.lblVehiculoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehiculoText.Name = "lblVehiculoText";
            this.lblVehiculoText.Size = new System.Drawing.Size(45, 13);
            this.lblVehiculoText.TabIndex = 3;
            this.lblVehiculoText.Text = "Modelo:";
            // 
            // lblAnioRegistro
            // 
            this.lblAnioRegistro.AutoSize = true;
            this.lblAnioRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.lblAnioRegistro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioRegistro.ForeColor = System.Drawing.Color.White;
            this.lblAnioRegistro.Location = new System.Drawing.Point(70, 98);
            this.lblAnioRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnioRegistro.Name = "lblAnioRegistro";
            this.lblAnioRegistro.Size = new System.Drawing.Size(93, 14);
            this.lblAnioRegistro.TabIndex = 4;
            this.lblAnioRegistro.Text = "Seleccione año:";
            // 
            // dtpYear
            // 
            this.dtpYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(181, 97);
            this.dtpYear.Margin = new System.Windows.Forms.Padding(2);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(63, 20);
            this.dtpYear.TabIndex = 3;
            // 
            // txtClaveSiniestro
            // 
            this.txtClaveSiniestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtClaveSiniestro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClaveSiniestro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtClaveSiniestro.Location = new System.Drawing.Point(116, 12);
            this.txtClaveSiniestro.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveSiniestro.Name = "txtClaveSiniestro";
            this.txtClaveSiniestro.Size = new System.Drawing.Size(127, 20);
            this.txtClaveSiniestro.TabIndex = 0;
            this.txtClaveSiniestro.Text = "Escriba clave del siniestro";
            this.txtClaveSiniestro.Enter += new System.EventHandler(this.txtClaveSiniestro_Enter);
            this.txtClaveSiniestro.Leave += new System.EventHandler(this.txtClaveSiniestro_Leave);
            this.txtClaveSiniestro.Validating += new System.ComponentModel.CancelEventHandler(this.txtClaveSiniestro_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtComentario.Location = new System.Drawing.Point(17, 149);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(294, 67);
            this.txtComentario.TabIndex = 4;
            this.txtComentario.Text = "Agregue un comentario";
            this.txtComentario.Enter += new System.EventHandler(this.txtComentario_Enter);
            this.txtComentario.Leave += new System.EventHandler(this.txtComentario_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(253, 232);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(63, 22);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(184, 232);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 22);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.lblIngreseNombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.ForeColor = System.Drawing.Color.White;
            this.lblIngreseNombre.Location = new System.Drawing.Point(19, 68);
            this.lblIngreseNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(96, 14);
            this.lblIngreseNombre.TabIndex = 11;
            this.lblIngreseNombre.Text = "Ingrese Modelo:";
            // 
            // txtNombreVehiculoNuevo
            // 
            this.txtNombreVehiculoNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtNombreVehiculoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreVehiculoNuevo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreVehiculoNuevo.Location = new System.Drawing.Point(117, 67);
            this.txtNombreVehiculoNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreVehiculoNuevo.Name = "txtNombreVehiculoNuevo";
            this.txtNombreVehiculoNuevo.Size = new System.Drawing.Size(127, 20);
            this.txtNombreVehiculoNuevo.TabIndex = 2;
            this.txtNombreVehiculoNuevo.Text = "Escriba un nuevo modelo";
            this.txtNombreVehiculoNuevo.Enter += new System.EventHandler(this.txtNombreVehiculoNuevo_Enter);
            this.txtNombreVehiculoNuevo.Leave += new System.EventHandler(this.txtNombreVehiculoNuevo_Leave);
            this.txtNombreVehiculoNuevo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreVehiculoNuevo_Validating);
            // 
            // chbOtroVehiculo
            // 
            this.chbOtroVehiculo.AutoSize = true;
            this.chbOtroVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.chbOtroVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbOtroVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chbOtroVehiculo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOtroVehiculo.ForeColor = System.Drawing.Color.White;
            this.chbOtroVehiculo.Location = new System.Drawing.Point(262, 67);
            this.chbOtroVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.chbOtroVehiculo.Name = "chbOtroVehiculo";
            this.chbOtroVehiculo.Size = new System.Drawing.Size(47, 18);
            this.chbOtroVehiculo.TabIndex = 9;
            this.chbOtroVehiculo.Text = "Otro";
            this.chbOtroVehiculo.UseVisualStyleBackColor = false;
            this.chbOtroVehiculo.CheckedChanged += new System.EventHandler(this.chbOtroVehiculo_CheckedChanged);
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
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtMarca);
            this.bunifuGradientPanel1.Controls.Add(this.cbMarca);
            this.bunifuGradientPanel1.Controls.Add(this.dtpYear);
            this.bunifuGradientPanel1.Controls.Add(this.chbMarca);
            this.bunifuGradientPanel1.Controls.Add(this.lblAnioRegistro);
            this.bunifuGradientPanel1.Controls.Add(this.lblMarca);
            this.bunifuGradientPanel1.Controls.Add(this.lblIngreseNombre);
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
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(325, 268);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMarca.Location = new System.Drawing.Point(116, 41);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(127, 20);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Text = "Escriba una nueva marca";
            this.txtMarca.Visible = false;
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            this.txtMarca.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarca_Validating);
            // 
            // cbMarca
            // 
            this.cbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMarca.BackColor = System.Drawing.Color.White;
            this.cbMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMarca.ForeColor = System.Drawing.Color.Black;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(116, 41);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(127, 21);
            this.cbMarca.TabIndex = 1;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            this.cbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMarca_KeyPress);
            this.cbMarca.Validating += new System.ComponentModel.CancelEventHandler(this.cbMarca_Validating);
            // 
            // chbMarca
            // 
            this.chbMarca.AutoSize = true;
            this.chbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.chbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chbMarca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMarca.ForeColor = System.Drawing.Color.White;
            this.chbMarca.Location = new System.Drawing.Point(262, 41);
            this.chbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.chbMarca.Name = "chbMarca";
            this.chbMarca.Size = new System.Drawing.Size(47, 18);
            this.chbMarca.TabIndex = 8;
            this.chbMarca.Text = "Otro";
            this.chbMarca.UseVisualStyleBackColor = false;
            this.chbMarca.CheckedChanged += new System.EventHandler(this.chbMarca_CheckedChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.lblMarca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(70, 43);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 14);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Siniestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(324, 266);
            this.ControlBox = false;
            this.Controls.Add(this.txtClaveSiniestro);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Siniestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siniestro";
            this.Load += new System.EventHandler(this.Siniestro_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox chbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}