namespace Jeic.Forms
{
    partial class Factura
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
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblcveVenta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dato3 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblcvePedidoidentity = new System.Windows.Forms.Label();
            this.lblPieza = new System.Windows.Forms.Label();
            this.lblFoRF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 24);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(219, 150);
            this.dgvFactura.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(171, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblcveVenta
            // 
            this.lblcveVenta.AutoSize = true;
            this.lblcveVenta.Location = new System.Drawing.Point(264, 137);
            this.lblcveVenta.Name = "lblcveVenta";
            this.lblcveVenta.Size = new System.Drawing.Size(58, 13);
            this.lblcveVenta.TabIndex = 2;
            this.lblcveVenta.Text = "cve_venta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(46, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Selecciona las Piezas a Facturar";
            // 
            // dato3
            // 
            this.dato3.AutoSize = true;
            this.dato3.Location = new System.Drawing.Point(264, 161);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(73, 13);
            this.dato3.TabIndex = 18;
            this.dato3.Text = "cve_refactura";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.dato2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.ForeColor = System.Drawing.Color.White;
            this.dato2.Location = new System.Drawing.Point(264, 60);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(50, 14);
            this.dato2.TabIndex = 16;
            this.dato2.Text = "PEDIDO:";
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.dato1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.ForeColor = System.Drawing.Color.White;
            this.dato1.Location = new System.Drawing.Point(264, 35);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(65, 14);
            this.dato1.TabIndex = 17;
            this.dato1.Text = "SINIESTRO:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(264, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 73;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblcvePedidoidentity
            // 
            this.lblcvePedidoidentity.AutoSize = true;
            this.lblcvePedidoidentity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.lblcvePedidoidentity.ForeColor = System.Drawing.Color.White;
            this.lblcvePedidoidentity.Location = new System.Drawing.Point(264, 113);
            this.lblcvePedidoidentity.Name = "lblcvePedidoidentity";
            this.lblcvePedidoidentity.Size = new System.Drawing.Size(91, 13);
            this.lblcvePedidoidentity.TabIndex = 86;
            this.lblcvePedidoidentity.Text = "cvePedidoidentity";
            // 
            // lblPieza
            // 
            this.lblPieza.AutoSize = true;
            this.lblPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.lblPieza.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieza.ForeColor = System.Drawing.Color.White;
            this.lblPieza.Location = new System.Drawing.Point(264, 88);
            this.lblPieza.Name = "lblPieza";
            this.lblPieza.Size = new System.Drawing.Size(39, 14);
            this.lblPieza.TabIndex = 85;
            this.lblPieza.Text = "PIEZA:";
            // 
            // lblFoRF
            // 
            this.lblFoRF.AutoSize = true;
            this.lblFoRF.Location = new System.Drawing.Point(264, 180);
            this.lblFoRF.Name = "lblFoRF";
            this.lblFoRF.Size = new System.Drawing.Size(90, 13);
            this.lblFoRF.TabIndex = 87;
            this.lblFoRF.Text = "facturaOrefactura";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 214);
            this.Controls.Add(this.lblFoRF);
            this.Controls.Add(this.lblcvePedidoidentity);
            this.Controls.Add(this.lblPieza);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblcveVenta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvFactura);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label lblcveVenta;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label dato3;
        public System.Windows.Forms.Label dato2;
        public System.Windows.Forms.Label dato1;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblcvePedidoidentity;
        public System.Windows.Forms.Label lblPieza;
        public System.Windows.Forms.Label lblFoRF;
    }
}