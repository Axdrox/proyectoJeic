﻿namespace Refracciones.Forms
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
            this.FadeTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.GifHecho = new System.Windows.Forms.PictureBox();
            this.Retraso_icono = new System.Windows.Forms.Timer(this.components);
            this.btnOK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTexto = new System.Windows.Forms.Label();
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
            // FadeTransition
            // 
            this.FadeTransition.Delay = 1;
            this.FadeTransition.TransitionEnd += new System.EventHandler(this.FadeTransition_TransitionEnd);
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
            // MessageBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(231, 193);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GifHecho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBOX";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.MessageBOX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GifHecho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FadeTransition;
        private System.Windows.Forms.PictureBox GifHecho;
        private System.Windows.Forms.Timer Retraso_icono;
        private Bunifu.Framework.UI.BunifuFlatButton btnOK;
        private System.Windows.Forms.Label lblTexto;
    }
}