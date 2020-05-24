namespace Refracciones.Forms
{
    partial class BusquedaEntrega_Devolucion
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
            this.dato3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtnEntregas = new System.Windows.Forms.RadioButton();
            this.rbtnDev = new System.Windows.Forms.RadioButton();
            this.dato1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.lblcve_venta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dato3
            // 
            this.dato3.AutoSize = true;
            this.dato3.Location = new System.Drawing.Point(341, 20);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(60, 13);
            this.dato3.TabIndex = 0;
            this.dato3.Text = "FACTURA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(440, 372);
            this.dataGridView1.TabIndex = 1;
            // 
            // rbtnEntregas
            // 
            this.rbtnEntregas.AutoSize = true;
            this.rbtnEntregas.Checked = true;
            this.rbtnEntregas.Location = new System.Drawing.Point(33, 43);
            this.rbtnEntregas.Name = "rbtnEntregas";
            this.rbtnEntregas.Size = new System.Drawing.Size(84, 17);
            this.rbtnEntregas.TabIndex = 2;
            this.rbtnEntregas.TabStop = true;
            this.rbtnEntregas.Text = "ENTREGAS";
            this.rbtnEntregas.UseVisualStyleBackColor = true;
            this.rbtnEntregas.CheckedChanged += new System.EventHandler(this.rbtnEntregas_CheckedChanged);
            // 
            // rbtnDev
            // 
            this.rbtnDev.AutoSize = true;
            this.rbtnDev.Location = new System.Drawing.Point(141, 43);
            this.rbtnDev.Name = "rbtnDev";
            this.rbtnDev.Size = new System.Drawing.Size(109, 17);
            this.rbtnDev.TabIndex = 3;
            this.rbtnDev.Text = "DEVOLUCIONES";
            this.rbtnDev.UseVisualStyleBackColor = true;
            this.rbtnDev.CheckedChanged += new System.EventHandler(this.rbtnDev_CheckedChanged);
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.Location = new System.Drawing.Point(30, 20);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(68, 13);
            this.dato1.TabIndex = 4;
            this.dato1.Text = "SINIESTRO:";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Location = new System.Drawing.Point(199, 20);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(51, 13);
            this.dato2.TabIndex = 5;
            this.dato2.Text = "PEDIDO:";
            // 
            // lblcve_venta
            // 
            this.lblcve_venta.AutoSize = true;
            this.lblcve_venta.Location = new System.Drawing.Point(416, 43);
            this.lblcve_venta.Name = "lblcve_venta";
            this.lblcve_venta.Size = new System.Drawing.Size(58, 13);
            this.lblcve_venta.TabIndex = 6;
            this.lblcve_venta.Text = "cve_venta";
            // 
            // BusquedaEntrega_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.lblcve_venta);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.rbtnDev);
            this.Controls.Add(this.rbtnEntregas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dato3);
            this.Name = "BusquedaEntrega_Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaEntrega_Devolucion";
            this.Load += new System.EventHandler(this.BusquedaEntrega_Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtnEntregas;
        private System.Windows.Forms.RadioButton rbtnDev;
        public System.Windows.Forms.Label dato3;
        public System.Windows.Forms.Label dato1;
        public System.Windows.Forms.Label dato2;
        public System.Windows.Forms.Label lblcve_venta;
    }
}