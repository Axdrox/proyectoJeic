﻿namespace Refracciones
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
            this.btnModificarDatosPedido = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnDevolucionEntrega = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRefactura = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dato_1 = new System.Windows.Forms.Label();
            this.dato_2 = new System.Windows.Forms.Label();
            this.dato_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarDatosPedido
            // 
            this.btnModificarDatosPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatosPedido.Location = new System.Drawing.Point(12, 48);
            this.btnModificarDatosPedido.Name = "btnModificarDatosPedido";
            this.btnModificarDatosPedido.Size = new System.Drawing.Size(155, 40);
            this.btnModificarDatosPedido.TabIndex = 0;
            this.btnModificarDatosPedido.Text = "Modificar datos de pedido";
            this.btnModificarDatosPedido.UseVisualStyleBackColor = true;
            this.btnModificarDatosPedido.Click += new System.EventHandler(this.btnModificarDatosPedido_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(12, 94);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(155, 35);
            this.btnFactura.TabIndex = 1;
            this.btnFactura.Text = "Agregar factura ";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnDevolucionEntrega
            // 
            this.btnDevolucionEntrega.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucionEntrega.Location = new System.Drawing.Point(12, 179);
            this.btnDevolucionEntrega.Name = "btnDevolucionEntrega";
            this.btnDevolucionEntrega.Size = new System.Drawing.Size(155, 44);
            this.btnDevolucionEntrega.TabIndex = 2;
            this.btnDevolucionEntrega.Text = "Registrar Devolucion/Entrega";
            this.btnDevolucionEntrega.UseVisualStyleBackColor = true;
            this.btnDevolucionEntrega.Click += new System.EventHandler(this.btnDevolucionEntrega_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "usuario";
            // 
            // btnRefactura
            // 
            this.btnRefactura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefactura.Location = new System.Drawing.Point(12, 135);
            this.btnRefactura.Name = "btnRefactura";
            this.btnRefactura.Size = new System.Drawing.Size(155, 38);
            this.btnRefactura.TabIndex = 4;
            this.btnRefactura.Text = "Refacturar";
            this.btnRefactura.UseVisualStyleBackColor = true;
            this.btnRefactura.Click += new System.EventHandler(this.btnRefactura_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Checar pedidos Devueltos/Entregados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dato_1
            // 
            this.dato_1.AutoSize = true;
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
            this.dato_3.Location = new System.Drawing.Point(41, 29);
            this.dato_3.Name = "dato_3";
            this.dato_3.Size = new System.Drawing.Size(64, 13);
            this.dato_3.TabIndex = 8;
            this.dato_3.Text = "cve_factura";
            this.dato_3.Visible = false;
            // 
            // Eleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 287);
            this.Controls.Add(this.dato_3);
            this.Controls.Add(this.dato_2);
            this.Controls.Add(this.dato_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefactura);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnDevolucionEntrega);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnModificarDatosPedido);
            this.Name = "Eleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleccion";
            this.Load += new System.EventHandler(this.Eleccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarDatosPedido;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnDevolucionEntrega;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRefactura;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label dato_1;
        public System.Windows.Forms.Label dato_2;
        public System.Windows.Forms.Label dato_3;
    }
}