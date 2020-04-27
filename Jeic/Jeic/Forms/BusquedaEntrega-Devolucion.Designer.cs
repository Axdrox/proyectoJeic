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
            this.dato1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbtnEntregas = new System.Windows.Forms.RadioButton();
            this.rbtnDev = new System.Windows.Forms.RadioButton();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.Location = new System.Drawing.Point(14, 20);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(69, 13);
            this.dato1.TabIndex = 0;
            this.dato1.Text = "cve_siniestro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 372);
            this.dataGridView1.TabIndex = 1;
            // 
            // rbtnEntregas
            // 
            this.rbtnEntregas.AutoSize = true;
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
            this.rbtnDev.TabStop = true;
            this.rbtnDev.Text = "DEVOLUCIONES";
            this.rbtnDev.UseVisualStyleBackColor = true;
            this.rbtnDev.CheckedChanged += new System.EventHandler(this.rbtnDev_CheckedChanged);
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Location = new System.Drawing.Point(116, 20);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(63, 13);
            this.dato2.TabIndex = 4;
            this.dato2.Text = "cve_pedido";
            // 
            // dato3
            // 
            this.dato3.AutoSize = true;
            this.dato3.Location = new System.Drawing.Point(201, 20);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(64, 13);
            this.dato3.TabIndex = 5;
            this.dato3.Text = "cve_factura";
            // 
            // BusquedaEntrega_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.rbtnDev);
            this.Controls.Add(this.rbtnEntregas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dato1);
            this.Name = "BusquedaEntrega_Devolucion";
            this.Text = "BusquedaEntrega_Devolucion";
            this.Load += new System.EventHandler(this.BusquedaEntrega_Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dato1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtnEntregas;
        private System.Windows.Forms.RadioButton rbtnDev;
        private System.Windows.Forms.Label dato2;
        private System.Windows.Forms.Label dato3;
    }
}