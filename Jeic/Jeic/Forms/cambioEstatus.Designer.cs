namespace Jeic.Forms
{
    partial class cambioEstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambioEstatus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvEstatus = new System.Windows.Forms.DataGridView();
            this.ColumnPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCvePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCveVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.rbtnPorPedido = new System.Windows.Forms.RadioButton();
            this.rbtnPorPieza = new System.Windows.Forms.RadioButton();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblTitle);
            this.bunifuGradientPanel1.Controls.Add(this.txtCodigo);
            this.bunifuGradientPanel1.Controls.Add(this.dgvEstatus);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.cmbEstado);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnPorPedido);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnPorPieza);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, 23);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(751, 343);
            this.bunifuGradientPanel1.TabIndex = 18;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(556, 102);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(185, 20);
            this.txtCodigo.TabIndex = 16;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // dgvEstatus
            // 
            this.dgvEstatus.AllowUserToAddRows = false;
            this.dgvEstatus.AllowUserToDeleteRows = false;
            this.dgvEstatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEstatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstatus.ColumnHeadersHeight = 22;
            this.dgvEstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPed,
            this.ColumnSin,
            this.ColumnPieza,
            this.ColumnCliente,
            this.ColumnEstatus,
            this.ColumnCvePedido,
            this.ColumnCveVenta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstatus.EnableHeadersVisualStyles = false;
            this.dgvEstatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dgvEstatus.Location = new System.Drawing.Point(13, 101);
            this.dgvEstatus.Name = "dgvEstatus";
            this.dgvEstatus.ReadOnly = true;
            this.dgvEstatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstatus.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstatus.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstatus.Size = new System.Drawing.Size(537, 234);
            this.dgvEstatus.TabIndex = 15;
            this.dgvEstatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstatus_CellClick);
            // 
            // ColumnPed
            // 
            this.ColumnPed.HeaderText = "PEDIDO";
            this.ColumnPed.Name = "ColumnPed";
            this.ColumnPed.ReadOnly = true;
            this.ColumnPed.Width = 71;
            // 
            // ColumnSin
            // 
            this.ColumnSin.HeaderText = "SINIESTRO";
            this.ColumnSin.Name = "ColumnSin";
            this.ColumnSin.ReadOnly = true;
            this.ColumnSin.Width = 88;
            // 
            // ColumnPieza
            // 
            this.ColumnPieza.HeaderText = "PIEZA";
            this.ColumnPieza.Name = "ColumnPieza";
            this.ColumnPieza.ReadOnly = true;
            this.ColumnPieza.Width = 61;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "CLIENTE";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 75;
            // 
            // ColumnEstatus
            // 
            this.ColumnEstatus.HeaderText = "ESTATUS ACTUAL";
            this.ColumnEstatus.Name = "ColumnEstatus";
            this.ColumnEstatus.ReadOnly = true;
            this.ColumnEstatus.Width = 125;
            // 
            // ColumnCvePedido
            // 
            this.ColumnCvePedido.HeaderText = "CVE PEDIDO";
            this.ColumnCvePedido.Name = "ColumnCvePedido";
            this.ColumnCvePedido.ReadOnly = true;
            this.ColumnCvePedido.Width = 95;
            // 
            // ColumnCveVenta
            // 
            this.ColumnCveVenta.HeaderText = "CVE VENTA";
            this.ColumnCveVenta.Name = "ColumnCveVenta";
            this.ColumnCveVenta.ReadOnly = true;
            this.ColumnCveVenta.Width = 90;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(599, 298);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 30);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(556, 238);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(185, 21);
            this.cmbEstado.TabIndex = 3;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // rbtnPorPedido
            // 
            this.rbtnPorPedido.AutoSize = true;
            this.rbtnPorPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtnPorPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPorPedido.Location = new System.Drawing.Point(166, 65);
            this.rbtnPorPedido.Name = "rbtnPorPedido";
            this.rbtnPorPedido.Size = new System.Drawing.Size(158, 20);
            this.rbtnPorPedido.TabIndex = 1;
            this.rbtnPorPedido.TabStop = true;
            this.rbtnPorPedido.Text = "Cambio por pedido";
            this.rbtnPorPedido.UseVisualStyleBackColor = true;
            this.rbtnPorPedido.CheckedChanged += new System.EventHandler(this.rbtnPorPedido_CheckedChanged);
            // 
            // rbtnPorPieza
            // 
            this.rbtnPorPieza.AutoSize = true;
            this.rbtnPorPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtnPorPieza.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPorPieza.Location = new System.Drawing.Point(13, 65);
            this.rbtnPorPieza.Name = "rbtnPorPieza";
            this.rbtnPorPieza.Size = new System.Drawing.Size(147, 20);
            this.rbtnPorPieza.TabIndex = 0;
            this.rbtnPorPieza.TabStop = true;
            this.rbtnPorPieza.Text = "Cambio por pieza";
            this.rbtnPorPieza.UseVisualStyleBackColor = true;
            this.rbtnPorPieza.CheckedChanged += new System.EventHandler(this.rbtnPorPieza_CheckedChanged);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(723, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(17, 17);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 19;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(213, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 16);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "ACTUALIZAR ESTATUS POR PIEZA O PEDIDO";
            // 
            // cambioEstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(748, 366);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cambioEstatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cambioEstatus";
            this.Load += new System.EventHandler(this.cambioEstatus_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.RadioButton rbtnPorPedido;
        private System.Windows.Forms.RadioButton rbtnPorPieza;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvEstatus;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCvePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCveVenta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
    }
}