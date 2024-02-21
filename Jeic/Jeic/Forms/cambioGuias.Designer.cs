namespace Jeic.Forms
{
    partial class cambioGuias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambioGuias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblScan = new System.Windows.Forms.Label();
            this.txtCveGuia = new System.Windows.Forms.TextBox();
            this.lblCveGuia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvEstatus = new System.Windows.Forms.DataGridView();
            this.ColumnPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCvePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCveVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbtnPorPedido = new System.Windows.Forms.RadioButton();
            this.rbtnPorPieza = new System.Windows.Forms.RadioButton();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).BeginInit();
            this.SuspendLayout();
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
            this.pbClose.TabIndex = 21;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblUsuario);
            this.bunifuGradientPanel1.Controls.Add(this.lblScan);
            this.bunifuGradientPanel1.Controls.Add(this.txtCveGuia);
            this.bunifuGradientPanel1.Controls.Add(this.lblCveGuia);
            this.bunifuGradientPanel1.Controls.Add(this.dgvEstatus);
            this.bunifuGradientPanel1.Controls.Add(this.txtCodigo);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuardar);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnPorPedido);
            this.bunifuGradientPanel1.Controls.Add(this.rbtnPorPieza);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.CornflowerBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 28);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(997, 422);
            this.bunifuGradientPanel1.TabIndex = 22;
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblScan.Location = new System.Drawing.Point(738, 136);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(120, 18);
            this.lblScan.TabIndex = 22;
            this.lblScan.Text = "Código barras:";
            // 
            // txtCveGuia
            // 
            this.txtCveGuia.Location = new System.Drawing.Point(741, 280);
            this.txtCveGuia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCveGuia.MaxLength = 50;
            this.txtCveGuia.Name = "txtCveGuia";
            this.txtCveGuia.Size = new System.Drawing.Size(245, 22);
            this.txtCveGuia.TabIndex = 20;
            // 
            // lblCveGuia
            // 
            this.lblCveGuia.AutoSize = true;
            this.lblCveGuia.BackColor = System.Drawing.Color.Transparent;
            this.lblCveGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCveGuia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCveGuia.Location = new System.Drawing.Point(737, 256);
            this.lblCveGuia.Name = "lblCveGuia";
            this.lblCveGuia.Size = new System.Drawing.Size(112, 20);
            this.lblCveGuia.TabIndex = 19;
            this.lblCveGuia.Text = "Nueva Guia:";
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
            this.ColumnGuia,
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
            this.dgvEstatus.Location = new System.Drawing.Point(13, 126);
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
            this.dgvEstatus.TabIndex = 17;
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
            // ColumnGuia
            // 
            this.ColumnGuia.HeaderText = "CLAVE DE GUIA";
            this.ColumnGuia.MinimumWidth = 6;
            this.ColumnGuia.Name = "ColumnGuia";
            this.ColumnGuia.ReadOnly = true;
            this.ColumnGuia.Width = 139;
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
            this.lblTitle.Location = new System.Drawing.Point(274, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(459, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "CAMBIAR NUMERO DE GUÍA POR PIEZA O PEDIDO";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(4, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Visible = false;
            // 
            // cambioGuias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cambioGuias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cambioGuias";
            this.Load += new System.EventHandler(this.cambioGuias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rbtnPorPedido;
        private System.Windows.Forms.RadioButton rbtnPorPieza;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.DataGridView dgvEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCvePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCveVenta;
        private System.Windows.Forms.TextBox txtCveGuia;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCveGuia;
        private System.Windows.Forms.Label lblScan;
        public System.Windows.Forms.Label lblUsuario;
    }
}