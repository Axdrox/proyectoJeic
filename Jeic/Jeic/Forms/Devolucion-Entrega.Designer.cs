﻿namespace Refracciones.Forms
{
    partial class Devolucion
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtnDevolucion = new System.Windows.Forms.RadioButton();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.Label();
            this.dato1 = new System.Windows.Forms.Label();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnDevolucion);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnEntrega);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCantidad);
            this.splitContainer1.Panel1.Controls.Add(this.lbl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFecha);
            this.splitContainer1.Panel1.Controls.Add(this.lbl1);
            this.splitContainer1.Panel1.Controls.Add(this.dato2);
            this.splitContainer1.Panel1.Controls.Add(this.dato1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDevolucion);
            this.splitContainer1.Size = new System.Drawing.Size(1092, 450);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(15, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(61, 295);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ENTREGA";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnDevolucion
            // 
            this.rbtnDevolucion.AutoSize = true;
            this.rbtnDevolucion.Enabled = false;
            this.rbtnDevolucion.Location = new System.Drawing.Point(106, 68);
            this.rbtnDevolucion.Name = "rbtnDevolucion";
            this.rbtnDevolucion.Size = new System.Drawing.Size(79, 17);
            this.rbtnDevolucion.TabIndex = 7;
            this.rbtnDevolucion.Text = "Devolución";
            this.rbtnDevolucion.UseVisualStyleBackColor = true;
            this.rbtnDevolucion.CheckedChanged += new System.EventHandler(this.rbtnDevolucion_CheckedChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Enabled = false;
            this.rbtnEntrega.Location = new System.Drawing.Point(15, 68);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(62, 17);
            this.rbtnEntrega.TabIndex = 6;
            this.rbtnEntrega.Text = "Entrega";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnEntrega_CheckedChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.Enabled = false;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(15, 232);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCantidad.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 206);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(104, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Cantidad Entregada ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(15, 148);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 120);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(77, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Fecha Entrega";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Location = new System.Drawing.Point(12, 37);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(70, 13);
            this.dato2.TabIndex = 1;
            this.dato2.Text = "Clave Pedido";
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.Location = new System.Drawing.Point(12, 9);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(77, 13);
            this.dato1.TabIndex = 0;
            this.dato1.Text = "Clave Siniestro";
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucion.Location = new System.Drawing.Point(3, 3);
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            this.dgvDevolucion.Size = new System.Drawing.Size(829, 426);
            this.dgvDevolucion.TabIndex = 0;
            this.dgvDevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucion_CellContentClick);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label dato2;
        private System.Windows.Forms.Label dato1;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private System.Windows.Forms.RadioButton rbtnDevolucion;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}