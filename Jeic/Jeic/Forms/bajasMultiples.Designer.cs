namespace Jeic.Forms
{
    partial class bajasMultiples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bajasMultiples));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.Fecha_in = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvEstatus = new System.Windows.Forms.DataGridView();
            this.ColumnPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCvePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCveVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCvePieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnPorPedido = new System.Windows.Forms.RadioButton();
            this.rbtnPorPieza = new System.Windows.Forms.RadioButton();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
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
            this.bunifuGradientPanel1.Controls.Add(this.lblScan);
            this.bunifuGradientPanel1.Controls.Add(this.lblFecha);
            this.bunifuGradientPanel1.Controls.Add(this.Fecha_in);
            this.bunifuGradientPanel1.Controls.Add(this.txtCodigo);
            this.bunifuGradientPanel1.Controls.Add(this.dgvEstatus);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnPorPedido);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnPorPieza);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 33);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1001, 422);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFecha.Location = new System.Drawing.Point(750, 256);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha:";
            // 
            // Fecha_in
            // 
            this.Fecha_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha_in.Location = new System.Drawing.Point(816, 252);
            this.Fecha_in.Margin = new System.Windows.Forms.Padding(4);
            this.Fecha_in.Name = "Fecha_in";
            this.Fecha_in.Size = new System.Drawing.Size(169, 23);
            this.Fecha_in.TabIndex = 19;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(741, 158);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(245, 22);
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
            this.ColumnCveVenta,
            this.ColumnCvePieza,
            this.ColumnCantidad,
            this.ColumnFechaAsig});
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
            this.dgvEstatus.Location = new System.Drawing.Point(17, 124);
            this.dgvEstatus.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvEstatus.Size = new System.Drawing.Size(716, 288);
            this.dgvEstatus.TabIndex = 15;
            this.dgvEstatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstatus_CellClick);
            // 
            // ColumnPed
            // 
            this.ColumnPed.HeaderText = "PEDIDO";
            this.ColumnPed.MinimumWidth = 6;
            this.ColumnPed.Name = "ColumnPed";
            this.ColumnPed.ReadOnly = true;
            this.ColumnPed.Width = 87;
            // 
            // ColumnSin
            // 
            this.ColumnSin.HeaderText = "SINIESTRO";
            this.ColumnSin.MinimumWidth = 6;
            this.ColumnSin.Name = "ColumnSin";
            this.ColumnSin.ReadOnly = true;
            this.ColumnSin.Width = 108;
            // 
            // ColumnPieza
            // 
            this.ColumnPieza.HeaderText = "PIEZA";
            this.ColumnPieza.MinimumWidth = 6;
            this.ColumnPieza.Name = "ColumnPieza";
            this.ColumnPieza.ReadOnly = true;
            this.ColumnPieza.Width = 74;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "CLIENTE";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 92;
            // 
            // ColumnEstatus
            // 
            this.ColumnEstatus.HeaderText = "ESTATUS ACTUAL";
            this.ColumnEstatus.MinimumWidth = 6;
            this.ColumnEstatus.Name = "ColumnEstatus";
            this.ColumnEstatus.ReadOnly = true;
            this.ColumnEstatus.Width = 157;
            // 
            // ColumnCvePedido
            // 
            this.ColumnCvePedido.HeaderText = "CVE PEDIDO";
            this.ColumnCvePedido.MinimumWidth = 6;
            this.ColumnCvePedido.Name = "ColumnCvePedido";
            this.ColumnCvePedido.ReadOnly = true;
            this.ColumnCvePedido.Width = 118;
            // 
            // ColumnCveVenta
            // 
            this.ColumnCveVenta.HeaderText = "CVE VENTA";
            this.ColumnCveVenta.MinimumWidth = 6;
            this.ColumnCveVenta.Name = "ColumnCveVenta";
            this.ColumnCveVenta.ReadOnly = true;
            this.ColumnCveVenta.Width = 112;
            // 
            // ColumnCvePieza
            // 
            this.ColumnCvePieza.HeaderText = "CVE PIEZA";
            this.ColumnCvePieza.MinimumWidth = 6;
            this.ColumnCvePieza.Name = "ColumnCvePieza";
            this.ColumnCvePieza.ReadOnly = true;
            this.ColumnCvePieza.Width = 105;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "CANTIDAD";
            this.ColumnCantidad.MinimumWidth = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            this.ColumnCantidad.Width = 104;
            // 
            // ColumnFechaAsig
            // 
            this.ColumnFechaAsig.HeaderText = "FECHA ASIGNACION";
            this.ColumnFechaAsig.MinimumWidth = 6;
            this.ColumnFechaAsig.Name = "ColumnFechaAsig";
            this.ColumnFechaAsig.ReadOnly = true;
            this.ColumnFechaAsig.Width = 168;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(49)))), ((int)(((byte)(106)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(799, 367);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 37);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbtnPorPedido
            // 
            this.rbtnPorPedido.AutoSize = true;
            this.rbtnPorPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbtnPorPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnPorPedido.Location = new System.Drawing.Point(221, 80);
            this.rbtnPorPedido.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPorPedido.Name = "rbtnPorPedido";
            this.rbtnPorPedido.Size = new System.Drawing.Size(187, 24);
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
            this.rbtnPorPieza.Location = new System.Drawing.Point(17, 80);
            this.rbtnPorPieza.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPorPieza.Name = "rbtnPorPieza";
            this.rbtnPorPieza.Size = new System.Drawing.Size(177, 24);
            this.rbtnPorPieza.TabIndex = 0;
            this.rbtnPorPieza.TabStop = true;
            this.rbtnPorPieza.Text = "Cambio por pieza";
            this.rbtnPorPieza.UseVisualStyleBackColor = true;
            this.rbtnPorPieza.CheckedChanged += new System.EventHandler(this.rbtnPorPieza_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(330, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(366, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "REGISTRAR BAJA POR PIEZA O PEDIDO";
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(968, 3);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(23, 21);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 20;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(14, 9);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 18);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "usuario";
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblScan.Location = new System.Drawing.Point(740, 136);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(120, 18);
            this.lblScan.TabIndex = 21;
            this.lblScan.Text = "Código barras:";
            // 
            // bajasMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bajasMultiples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Bajas";
            this.Load += new System.EventHandler(this.bajasMultiples_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker Fecha_in;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvEstatus;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnPorPedido;
        private System.Windows.Forms.RadioButton rbtnPorPieza;
        private System.Windows.Forms.PictureBox pbClose;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCvePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCveVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCvePieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaAsig;
        private System.Windows.Forms.Label lblScan;
    }
}