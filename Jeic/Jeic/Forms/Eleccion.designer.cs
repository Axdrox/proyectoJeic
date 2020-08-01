namespace Refracciones
{
    partial class Eleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eleccion));
            this.btnModificarDatosPedido = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnDevolucionEntrega = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRefactura = new System.Windows.Forms.Button();
            this.btnChecarPedDev = new System.Windows.Forms.Button();
            this.dato_1 = new System.Windows.Forms.Label();
            this.dato_2 = new System.Windows.Forms.Label();
            this.dato_3 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.dgvDatosPDF = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblCve_venta = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPDF)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarDatosPedido
            // 
            this.btnModificarDatosPedido.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarDatosPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarDatosPedido.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatosPedido.ForeColor = System.Drawing.Color.White;
            this.btnModificarDatosPedido.Location = new System.Drawing.Point(12, 48);
            this.btnModificarDatosPedido.Name = "btnModificarDatosPedido";
            this.btnModificarDatosPedido.Size = new System.Drawing.Size(155, 40);
            this.btnModificarDatosPedido.TabIndex = 0;
            this.btnModificarDatosPedido.Text = "Modificar Datos de Pedido";
            this.btnModificarDatosPedido.UseVisualStyleBackColor = false;
            this.btnModificarDatosPedido.Click += new System.EventHandler(this.btnModificarDatosPedido_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Location = new System.Drawing.Point(12, 94);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(155, 35);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Elaboración de Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnDevolucionEntrega
            // 
            this.btnDevolucionEntrega.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDevolucionEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolucionEntrega.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucionEntrega.ForeColor = System.Drawing.Color.White;
            this.btnDevolucionEntrega.Location = new System.Drawing.Point(12, 179);
            this.btnDevolucionEntrega.Name = "btnDevolucionEntrega";
            this.btnDevolucionEntrega.Size = new System.Drawing.Size(155, 44);
            this.btnDevolucionEntrega.TabIndex = 2;
            this.btnDevolucionEntrega.Text = "Registrar Entregas/Devoluciones";
            this.btnDevolucionEntrega.UseVisualStyleBackColor = false;
            this.btnDevolucionEntrega.Click += new System.EventHandler(this.btnDevolucionEntrega_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 14);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "usuario";
            // 
            // btnRefactura
            // 
            this.btnRefactura.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefactura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefactura.ForeColor = System.Drawing.Color.White;
            this.btnRefactura.Location = new System.Drawing.Point(12, 135);
            this.btnRefactura.Name = "btnRefactura";
            this.btnRefactura.Size = new System.Drawing.Size(155, 38);
            this.btnRefactura.TabIndex = 4;
            this.btnRefactura.Text = "Refacturar";
            this.btnRefactura.UseVisualStyleBackColor = false;
            this.btnRefactura.Click += new System.EventHandler(this.btnRefactura_Click);
            // 
            // btnChecarPedDev
            // 
            this.btnChecarPedDev.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChecarPedDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChecarPedDev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecarPedDev.ForeColor = System.Drawing.Color.White;
            this.btnChecarPedDev.Location = new System.Drawing.Point(12, 231);
            this.btnChecarPedDev.Name = "btnChecarPedDev";
            this.btnChecarPedDev.Size = new System.Drawing.Size(155, 44);
            this.btnChecarPedDev.TabIndex = 5;
            this.btnChecarPedDev.Text = "Revisar Pedidos Entregados/Devueltos";
            this.btnChecarPedDev.UseVisualStyleBackColor = false;
            this.btnChecarPedDev.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dato_1
            // 
            this.dato_1.AutoSize = true;
            this.dato_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dato_1.ForeColor = System.Drawing.Color.White;
            this.dato_1.Location = new System.Drawing.Point(102, 9);
            this.dato_1.Name = "dato_1";
            this.dato_1.Size = new System.Drawing.Size(69, 13);
            this.dato_1.TabIndex = 6;
            this.dato_1.Text = "cve_siniestro";
            this.dato_1.Visible = false;
            // 
            // dato_2
            // 
            this.dato_2.AutoSize = true;
            this.dato_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dato_2.ForeColor = System.Drawing.Color.White;
            this.dato_2.Location = new System.Drawing.Point(105, 29);
            this.dato_2.Name = "dato_2";
            this.dato_2.Size = new System.Drawing.Size(63, 13);
            this.dato_2.TabIndex = 7;
            this.dato_2.Text = "cve_pedido";
            this.dato_2.Visible = false;
            // 
            // dato_3
            // 
            this.dato_3.AutoSize = true;
            this.dato_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dato_3.ForeColor = System.Drawing.Color.White;
            this.dato_3.Location = new System.Drawing.Point(41, 29);
            this.dato_3.Name = "dato_3";
            this.dato_3.Size = new System.Drawing.Size(64, 13);
            this.dato_3.TabIndex = 8;
            this.dato_3.Text = "cve_factura";
            this.dato_3.Visible = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Linen;
            this.btnPDF.Location = new System.Drawing.Point(12, 281);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(155, 44);
            this.btnPDF.TabIndex = 9;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // dgvDatosPDF
            // 
            this.dgvDatosPDF.AllowUserToAddRows = false;
            this.dgvDatosPDF.AllowUserToDeleteRows = false;
            this.dgvDatosPDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPDF.Enabled = false;
            this.dgvDatosPDF.Location = new System.Drawing.Point(68, 335);
            this.dgvDatosPDF.Name = "dgvDatosPDF";
            this.dgvDatosPDF.ReadOnly = true;
            this.dgvDatosPDF.RowHeadersWidth = 51;
            this.dgvDatosPDF.Size = new System.Drawing.Size(40, 8);
            this.dgvDatosPDF.TabIndex = 10;
            this.dgvDatosPDF.Visible = false;
            // 
            // lblCve_venta
            // 
            this.lblCve_venta.AutoSize = true;
            this.lblCve_venta.Location = new System.Drawing.Point(15, 332);
            this.lblCve_venta.Name = "lblCve_venta";
            this.lblCve_venta.Size = new System.Drawing.Size(58, 13);
            this.lblCve_venta.TabIndex = 11;
            this.lblCve_venta.Text = "cve_venta";
            this.lblCve_venta.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblUsuario);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(181, 346);
            this.bunifuGradientPanel1.TabIndex = 12;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::Jeic.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(137, 3);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(17, 17);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 81;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(156, 3);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(17, 17);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 80;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.bunifuGradientPanel1;
            this.moverFormulario.Vertical = true;
            // 
            // Eleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 346);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblCve_venta);
            this.Controls.Add(this.dgvDatosPDF);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dato_3);
            this.Controls.Add(this.dato_2);
            this.Controls.Add(this.dato_1);
            this.Controls.Add(this.btnChecarPedDev);
            this.Controls.Add(this.btnRefactura);
            this.Controls.Add(this.btnDevolucionEntrega);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnModificarDatosPedido);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Eleccion_FormClosing);
            this.Load += new System.EventHandler(this.Eleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPDF)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarDatosPedido;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnDevolucionEntrega;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRefactura;
        private System.Windows.Forms.Button btnChecarPedDev;
        public System.Windows.Forms.Label dato_1;
        public System.Windows.Forms.Label dato_2;
        public System.Windows.Forms.Label dato_3;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.DataGridView dgvDatosPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Label lblCve_venta;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
    }
}