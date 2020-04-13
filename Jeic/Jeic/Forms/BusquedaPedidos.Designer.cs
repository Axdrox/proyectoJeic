namespace Refracciones
{
    partial class BusquedaPedidos
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
            this.RdCve = new System.Windows.Forms.RadioButton();
            this.rdFactura = new System.Windows.Forms.RadioButton();
            this.rdCalendario = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.PanelBusqueda = new System.Windows.Forms.Panel();
            this.btnBuscarCve = new System.Windows.Forms.Button();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCal = new System.Windows.Forms.Panel();
            this.btnBuscaFecha = new System.Windows.Forms.Button();
            this.lblPruebas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgain = new System.Windows.Forms.Button();
            this.PanelBusqueda.SuspendLayout();
            this.PanelCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RdCve
            // 
            this.RdCve.AutoSize = true;
            this.RdCve.Location = new System.Drawing.Point(39, 63);
            this.RdCve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdCve.Name = "RdCve";
            this.RdCve.Size = new System.Drawing.Size(123, 21);
            this.RdCve.TabIndex = 0;
            this.RdCve.TabStop = true;
            this.RdCve.Text = "Clave Siniestro";
            this.RdCve.UseVisualStyleBackColor = true;
            this.RdCve.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdFactura
            // 
            this.rdFactura.AutoSize = true;
            this.rdFactura.Location = new System.Drawing.Point(303, 63);
            this.rdFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdFactura.Name = "rdFactura";
            this.rdFactura.Size = new System.Drawing.Size(89, 21);
            this.rdFactura.TabIndex = 1;
            this.rdFactura.TabStop = true;
            this.rdFactura.Text = "# Factura";
            this.rdFactura.UseVisualStyleBackColor = true;
            this.rdFactura.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdCalendario
            // 
            this.rdCalendario.AutoSize = true;
            this.rdCalendario.Location = new System.Drawing.Point(573, 63);
            this.rdCalendario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdCalendario.Name = "rdCalendario";
            this.rdCalendario.Size = new System.Drawing.Size(68, 21);
            this.rdCalendario.TabIndex = 2;
            this.rdCalendario.TabStop = true;
            this.rdCalendario.Text = "Fecha";
            this.rdCalendario.UseVisualStyleBackColor = true;
            this.rdCalendario.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(152, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la forma de búsqueda";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(23, 23);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(46, 17);
            this.lblCambio.TabIndex = 4;
            this.lblCambio.Text = "label2";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(159, 20);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(132, 22);
            this.txtCambio.TabIndex = 5;
            // 
            // PanelBusqueda
            // 
            this.PanelBusqueda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelBusqueda.Controls.Add(this.btnBuscarCve);
            this.PanelBusqueda.Controls.Add(this.lblCambio);
            this.PanelBusqueda.Controls.Add(this.txtCambio);
            this.PanelBusqueda.Location = new System.Drawing.Point(39, 110);
            this.PanelBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelBusqueda.Name = "PanelBusqueda";
            this.PanelBusqueda.Size = new System.Drawing.Size(321, 94);
            this.PanelBusqueda.TabIndex = 6;
            // 
            // btnBuscarCve
            // 
            this.btnBuscarCve.Location = new System.Drawing.Point(100, 58);
            this.btnBuscarCve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCve.Name = "btnBuscarCve";
            this.btnBuscarCve.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarCve.TabIndex = 6;
            this.btnBuscarCve.Text = "Buscar";
            this.btnBuscarCve.UseVisualStyleBackColor = true;
            this.btnBuscarCve.Click += new System.EventHandler(this.btnBuscarCve_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(37, 74);
            this.Calendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Calendario.MaxDate = new System.DateTime(2709, 11, 30, 0, 0, 0, 0);
            this.Calendario.MaxSelectionCount = 30;
            this.Calendario.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione un día o en su defecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "arrastre para un rango de tiempo";
            // 
            // PanelCal
            // 
            this.PanelCal.Controls.Add(this.btnBuscaFecha);
            this.PanelCal.Controls.Add(this.label2);
            this.PanelCal.Controls.Add(this.Calendario);
            this.PanelCal.Controls.Add(this.label3);
            this.PanelCal.Location = new System.Drawing.Point(25, 133);
            this.PanelCal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelCal.Name = "PanelCal";
            this.PanelCal.Size = new System.Drawing.Size(372, 338);
            this.PanelCal.TabIndex = 10;
            this.PanelCal.Visible = false;
            // 
            // btnBuscaFecha
            // 
            this.btnBuscaFecha.Location = new System.Drawing.Point(141, 288);
            this.btnBuscaFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscaFecha.Name = "btnBuscaFecha";
            this.btnBuscaFecha.Size = new System.Drawing.Size(100, 28);
            this.btnBuscaFecha.TabIndex = 10;
            this.btnBuscaFecha.Text = "Buscar";
            this.btnBuscaFecha.UseVisualStyleBackColor = true;
            this.btnBuscaFecha.Click += new System.EventHandler(this.btnBuscaFecha_Click);
            // 
            // lblPruebas
            // 
            this.lblPruebas.AutoSize = true;
            this.lblPruebas.Location = new System.Drawing.Point(483, 110);
            this.lblPruebas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPruebas.Name = "lblPruebas";
            this.lblPruebas.Size = new System.Drawing.Size(61, 17);
            this.lblPruebas.TabIndex = 11;
            this.lblPruebas.Text = "Pruebas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(496, 295);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(785, 463);
            this.btnAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(156, 28);
            this.btnAgain.TabIndex = 13;
            this.btnAgain.Text = "Volver a consultar";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // BusquedaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 506);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPruebas);
            this.Controls.Add(this.PanelCal);
            this.Controls.Add(this.PanelBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdCalendario);
            this.Controls.Add(this.rdFactura);
            this.Controls.Add(this.RdCve);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BusquedaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de pedidos";
            this.PanelBusqueda.ResumeLayout(false);
            this.PanelBusqueda.PerformLayout();
            this.PanelCal.ResumeLayout(false);
            this.PanelCal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdCve;
        private System.Windows.Forms.RadioButton rdFactura;
        private System.Windows.Forms.RadioButton rdCalendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Panel PanelBusqueda;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelCal;
        private System.Windows.Forms.Button btnBuscarCve;
        private System.Windows.Forms.Button btnBuscaFecha;
        private System.Windows.Forms.Label lblPruebas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgain;
    }
}