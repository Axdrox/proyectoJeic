namespace Jeic.Forms
{
    partial class FechaBaja
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarFechaBaja = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Location = new System.Drawing.Point(30, 48);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(268, 22);
            this.dtpFechaBaja.TabIndex = 0;
            this.dtpFechaBaja.ValueChanged += new System.EventHandler(this.dtpFechaBaja_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Fecha de Baja";
            // 
            // btnRegistrarFechaBaja
            // 
            this.btnRegistrarFechaBaja.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarFechaBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarFechaBaja.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarFechaBaja.Location = new System.Drawing.Point(130, 89);
            this.btnRegistrarFechaBaja.Name = "btnRegistrarFechaBaja";
            this.btnRegistrarFechaBaja.Size = new System.Drawing.Size(81, 32);
            this.btnRegistrarFechaBaja.TabIndex = 2;
            this.btnRegistrarFechaBaja.Text = "Aceptar";
            this.btnRegistrarFechaBaja.UseVisualStyleBackColor = false;
            this.btnRegistrarFechaBaja.Click += new System.EventHandler(this.btnRegistrarFechaBaja_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(315, 4);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(23, 21);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 81;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this;
            this.moverFormulario.Vertical = true;
            // 
            // FechaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(72)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(343, 133);
            this.ControlBox = false;
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnRegistrarFechaBaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaBaja);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FechaBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FechaBaja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FechaBaja_FormClosing);
            this.Load += new System.EventHandler(this.FechaBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.Button btnRegistrarFechaBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
    }
}