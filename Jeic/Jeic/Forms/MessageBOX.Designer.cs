namespace Refracciones.Forms
{
    partial class MessageBOX
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GifHecho = new System.Windows.Forms.PictureBox();
            this.Retraso_icono = new System.Windows.Forms.Timer(this.components);
            this.btnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnNO = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Timer_Close = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GifHecho)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GifHecho
            // 
            this.GifHecho.Image = global::Refracciones.Properties.Resources.GiftHECHO;
            this.GifHecho.InitialImage = null;
            this.GifHecho.Location = new System.Drawing.Point(45, 12);
            this.GifHecho.Name = "GifHecho";
            this.GifHecho.Size = new System.Drawing.Size(140, 95);
            this.GifHecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifHecho.TabIndex = 0;
            this.GifHecho.TabStop = false;
            // 
            // Retraso_icono
            // 
            this.Retraso_icono.Enabled = true;
            this.Retraso_icono.Interval = 4000;
            this.Retraso_icono.Tag = "";
            this.Retraso_icono.Tick += new System.EventHandler(this.Retraso_icono_Tick);
            // 
            // btnOK
            // 
            this.btnOK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderRadius = 5;
            this.btnOK.ButtonText = "Aceptar";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.DisabledColor = System.Drawing.Color.Gray;
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOK.Iconimage = null;
            this.btnOK.Iconimage_right = null;
            this.btnOK.Iconimage_right_Selected = null;
            this.btnOK.Iconimage_Selected = null;
            this.btnOK.IconMarginLeft = 0;
            this.btnOK.IconMarginRight = 0;
            this.btnOK.IconRightVisible = true;
            this.btnOK.IconRightZoom = 0D;
            this.btnOK.IconVisible = true;
            this.btnOK.IconZoom = 90D;
            this.btnOK.IsTab = false;
            this.btnOK.Location = new System.Drawing.Point(57, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(120)))), ((int)(((byte)(42)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnOK.selected = false;
            this.btnOK.Size = new System.Drawing.Size(116, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Aceptar";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnOK.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Gray;
            this.lblTexto.Location = new System.Drawing.Point(0, 110);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(231, 37);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Bienvenido";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNO
            // 
            this.btnNO.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNO.BackColor = System.Drawing.Color.Transparent;
            this.btnNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNO.BorderRadius = 5;
            this.btnNO.ButtonText = "NO";
            this.btnNO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNO.DisabledColor = System.Drawing.Color.Gray;
            this.btnNO.Enabled = false;
            this.btnNO.ForeColor = System.Drawing.Color.Transparent;
            this.btnNO.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNO.Iconimage = null;
            this.btnNO.Iconimage_right = null;
            this.btnNO.Iconimage_right_Selected = null;
            this.btnNO.Iconimage_Selected = null;
            this.btnNO.IconMarginLeft = 0;
            this.btnNO.IconMarginRight = 0;
            this.btnNO.IconRightVisible = true;
            this.btnNO.IconRightZoom = 0D;
            this.btnNO.IconVisible = true;
            this.btnNO.IconZoom = 90D;
            this.btnNO.IsTab = false;
            this.btnNO.Location = new System.Drawing.Point(201, 79);
            this.btnNO.Name = "btnNO";
            this.btnNO.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNO.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.btnNO.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnNO.selected = false;
            this.btnNO.Size = new System.Drawing.Size(87, 27);
            this.btnNO.TabIndex = 3;
            this.btnNO.Text = "NO";
            this.btnNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNO.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(75)))));
            this.btnNO.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Visible = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // Timer_Close
            // 
            this.Timer_Close.Interval = 4500;
            this.Timer_Close.Tick += new System.EventHandler(this.Timer_Close_Tick);
            // 
            // MessageBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(231, 193);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GifHecho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBOX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.MessageBOX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GifHecho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox GifHecho;
        private System.Windows.Forms.Timer Retraso_icono;
        private Bunifu.Framework.UI.BunifuFlatButton btnOK;
        private System.Windows.Forms.Label lblTexto;
        private Bunifu.Framework.UI.BunifuFlatButton btnNO;
        private System.Windows.Forms.Timer Timer_Close;
    }
}