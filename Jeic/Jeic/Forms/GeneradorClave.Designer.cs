namespace Jeic.Forms
{
    partial class GeneradorClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorClave));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblcvePe = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.Fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.Fecha_in = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Fecha_Fin);
            this.bunifuGradientPanel1.Controls.Add(this.Fecha_in);
            this.bunifuGradientPanel1.Controls.Add(this.lblTitle);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.lblcvePe);
            this.bunifuGradientPanel1.Controls.Add(this.btnGenerar);
            this.bunifuGradientPanel1.Controls.Add(this.pbMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.pbClose);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-2, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(298, 212);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // lblcvePe
            // 
            this.lblcvePe.AutoSize = true;
            this.lblcvePe.Location = new System.Drawing.Point(13, 183);
            this.lblcvePe.Name = "lblcvePe";
            this.lblcvePe.Size = new System.Drawing.Size(73, 13);
            this.lblcvePe.TabIndex = 82;
            this.lblcvePe.Text = "Clave Pedido:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(109, 156);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::Jeic.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(250, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(17, 17);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 79;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(271, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(17, 17);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 78;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Location = new System.Drawing.Point(67, 87);
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.Fecha_Fin.TabIndex = 87;
            // 
            // Fecha_in
            // 
            this.Fecha_in.Location = new System.Drawing.Point(67, 56);
            this.Fecha_in.Name = "Fecha_in";
            this.Fecha_in.Size = new System.Drawing.Size(200, 20);
            this.Fecha_in.TabIndex = 86;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(76, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 14);
            this.lblTitle.TabIndex = 85;
            this.lblTitle.Text = "REPORTE FACTURAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 84;
            this.label2.Text = "HASTA: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 83;
            this.label1.Text = "DESDE: ";
            // 
            // GeneradorClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 207);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneradorClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneradorClave";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public System.Windows.Forms.Label lblcvePe;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.DateTimePicker Fecha_Fin;
        private System.Windows.Forms.DateTimePicker Fecha_in;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}