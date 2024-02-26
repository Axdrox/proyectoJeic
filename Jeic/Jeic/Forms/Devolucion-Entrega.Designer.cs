namespace Refracciones.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblPenalizacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMotivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.cmbMotivoDev = new System.Windows.Forms.ComboBox();
            this.lblMotivoDev = new System.Windows.Forms.Label();
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.txtPenalizacion = new System.Windows.Forms.TextBox();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menu.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPenalizacion);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chkMotivo);
            this.splitContainer1.Panel1.Controls.Add(this.txtMotivo);
            this.splitContainer1.Panel1.Controls.Add(this.cmbMotivoDev);
            this.splitContainer1.Panel1.Controls.Add(this.lblMotivoDev);
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
            this.splitContainer1.Panel1.Controls.Add(this.menu);
            this.splitContainer1.Panel1.Controls.Add(this.bunifuGradientPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDevolucion);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuGradientPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1827, 554);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblPenalizacion
            // 
            this.lblPenalizacion.AutoSize = true;
            this.lblPenalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(97)))));
            this.lblPenalizacion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalizacion.ForeColor = System.Drawing.Color.White;
            this.lblPenalizacion.Location = new System.Drawing.Point(24, 347);
            this.lblPenalizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenalizacion.Name = "lblPenalizacion";
            this.lblPenalizacion.Size = new System.Drawing.Size(175, 18);
            this.lblPenalizacion.TabIndex = 16;
            this.lblPenalizacion.Text = "Porcentaje de Penalización";
            this.lblPenalizacion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(88)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Otro";
            this.label1.Visible = false;
            // 
            // chkMotivo
            // 
            this.chkMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMotivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMotivo.Checked = false;
            this.chkMotivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkMotivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMotivo.ForeColor = System.Drawing.Color.White;
            this.chkMotivo.Location = new System.Drawing.Point(193, 299);
            this.chkMotivo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkMotivo.Name = "chkMotivo";
            this.chkMotivo.Size = new System.Drawing.Size(20, 20);
            this.chkMotivo.TabIndex = 13;
            this.chkMotivo.Visible = false;
            this.chkMotivo.OnChange += new System.EventHandler(this.chkMotivo_OnChange);
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Enabled = false;
            this.txtMotivo.ForeColor = System.Drawing.Color.White;
            this.txtMotivo.Location = new System.Drawing.Point(24, 298);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(161, 22);
            this.txtMotivo.TabIndex = 12;
            this.txtMotivo.Visible = false;
            // 
            // cmbMotivoDev
            // 
            this.cmbMotivoDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoDev.Enabled = false;
            this.cmbMotivoDev.FormattingEnabled = true;
            this.cmbMotivoDev.Items.AddRange(new object[] {
            "Cancelada",
            "Pago Daños",
            "Asegurado Transito",
            "Pieza con daño",
            "Cambio Origen",
            "Perdida Total",
            "Pieza Incorrecta"});
            this.cmbMotivoDev.Location = new System.Drawing.Point(24, 298);
            this.cmbMotivoDev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMotivoDev.Name = "cmbMotivoDev";
            this.cmbMotivoDev.Size = new System.Drawing.Size(160, 24);
            this.cmbMotivoDev.TabIndex = 11;
            this.cmbMotivoDev.Visible = false;
            // 
            // lblMotivoDev
            // 
            this.lblMotivoDev.AutoSize = true;
            this.lblMotivoDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lblMotivoDev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoDev.ForeColor = System.Drawing.Color.White;
            this.lblMotivoDev.Location = new System.Drawing.Point(20, 265);
            this.lblMotivoDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivoDev.Name = "lblMotivoDev";
            this.lblMotivoDev.Size = new System.Drawing.Size(128, 18);
            this.lblMotivoDev.TabIndex = 10;
            this.lblMotivoDev.Text = "Motivo Devolución:";
            this.lblMotivoDev.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(20, 511);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(121, 455);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(165, 28);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ENTREGA";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtnDevolucion
            // 
            this.rbtnDevolucion.AutoSize = true;
            this.rbtnDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rbtnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnDevolucion.Enabled = false;
            this.rbtnDevolucion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDevolucion.ForeColor = System.Drawing.Color.White;
            this.rbtnDevolucion.Location = new System.Drawing.Point(181, 68);
            this.rbtnDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnDevolucion.Name = "rbtnDevolucion";
            this.rbtnDevolucion.Size = new System.Drawing.Size(99, 22);
            this.rbtnDevolucion.TabIndex = 7;
            this.rbtnDevolucion.Text = "Devolución";
            this.rbtnDevolucion.UseVisualStyleBackColor = false;
            this.rbtnDevolucion.CheckedChanged += new System.EventHandler(this.rbtnDevolucion_CheckedChanged);
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rbtnEntrega.Checked = true;
            this.rbtnEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnEntrega.Enabled = false;
            this.rbtnEntrega.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEntrega.ForeColor = System.Drawing.Color.White;
            this.rbtnEntrega.Location = new System.Drawing.Point(28, 68);
            this.rbtnEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(55, 22);
            this.rbtnEntrega.TabIndex = 6;
            this.rbtnEntrega.TabStop = true;
            this.rbtnEntrega.Text = "Baja";
            this.rbtnEntrega.UseVisualStyleBackColor = false;
            this.rbtnEntrega.CheckedChanged += new System.EventHandler(this.rbtnEntrega_CheckedChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.Enabled = false;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(20, 220);
            this.cmbCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(160, 24);
            this.cmbCantidad.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.lbl2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(16, 196);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 18);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Cantidad Bajas ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(20, 142);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.lbl1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(16, 107);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(73, 18);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Fecha Baja";
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.dato2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.ForeColor = System.Drawing.Color.White;
            this.dato2.Location = new System.Drawing.Point(207, 34);
            this.dato2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(59, 18);
            this.dato2.TabIndex = 1;
            this.dato2.Text = "PEDIDO:";
            // 
            // dato1
            // 
            this.dato1.AutoSize = true;
            this.dato1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.dato1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.ForeColor = System.Drawing.Color.White;
            this.dato1.Location = new System.Drawing.Point(16, 34);
            this.dato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(76, 18);
            this.dato1.TabIndex = 0;
            this.dato1.Text = "SINIESTRO:";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(470, 26);
            this.menu.TabIndex = 17;
            this.menu.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem,
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarEntregaDeTodoElPedidoToolStripMenuItem
            // 
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Name = "registrarEntregaDeTodoElPedidoToolStripMenuItem";
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Size = new System.Drawing.Size(420, 26);
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Text = "Registrar baja de piezas faltantes de todo el pedido";
            this.registrarEntregaDeTodoElPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarEntregaDeTodoElPedidoToolStripMenuItem_Click);
            // 
            // registrarDevoluciónDeTodoElPedidoToolStripMenuItem
            // 
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Name = "registrarDevoluciónDeTodoElPedidoToolStripMenuItem";
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Size = new System.Drawing.Size(420, 26);
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Text = "Registrar devolución de piezas entregadas del pedido";
            this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem.Click += new System.EventHandler(this.registrarDevoluciónDeTodoElPedidoToolStripMenuItem_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblUsuario);
            this.bunifuGradientPanel1.Controls.Add(this.lblporcentaje);
            this.bunifuGradientPanel1.Controls.Add(this.txtPenalizacion);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1827, 554);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(72)))), ((int)(((byte)(126)))));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(289, 527);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 73;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblporcentaje.ForeColor = System.Drawing.Color.White;
            this.lblporcentaje.Location = new System.Drawing.Point(28, 375);
            this.lblporcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(19, 16);
            this.lblporcentaje.TabIndex = 35;
            this.lblporcentaje.Text = "%";
            this.lblporcentaje.Visible = false;
            // 
            // txtPenalizacion
            // 
            this.txtPenalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtPenalizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPenalizacion.ForeColor = System.Drawing.Color.White;
            this.txtPenalizacion.Location = new System.Drawing.Point(24, 370);
            this.txtPenalizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPenalizacion.Name = "txtPenalizacion";
            this.txtPenalizacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPenalizacion.Size = new System.Drawing.Size(161, 22);
            this.txtPenalizacion.TabIndex = 19;
            this.txtPenalizacion.Text = "0";
            this.txtPenalizacion.Visible = false;
            this.txtPenalizacion.TextChanged += new System.EventHandler(this.txtPenalizacion_TextChanged);
            this.txtPenalizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPenalizacion_KeyPress);
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.AllowUserToAddRows = false;
            this.dgvDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDevolucion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDevolucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDevolucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDevolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucion.EnableHeadersVisualStyles = false;
            this.dgvDevolucion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.dgvDevolucion.Location = new System.Drawing.Point(4, 34);
            this.dgvDevolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            this.dgvDevolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevolucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDevolucion.RowHeadersVisible = false;
            this.dgvDevolucion.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDevolucion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion.Size = new System.Drawing.Size(1343, 519);
            this.dgvDevolucion.TabIndex = 0;
            this.dgvDevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucion_CellContentClick);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.pbMinimize);
            this.bunifuGradientPanel2.Controls.Add(this.pbClose);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(4, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1584, 554);
            this.bunifuGradientPanel2.TabIndex = 19;
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = global::Jeic.Properties.Resources.Minimize_Window_2_48px;
            this.pbMinimize.Location = new System.Drawing.Point(1293, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(23, 21);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 73;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Jeic.Properties.Resources.Close_Window__2_48px;
            this.pbClose.Location = new System.Drawing.Point(1320, 2);
            this.pbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(23, 21);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 72;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.bunifuGradientPanel1;
            this.moverFormulario.Vertical = true;
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 554);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Devolución y Entrega";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private System.Windows.Forms.RadioButton rbtnDevolucion;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label dato2;
        public System.Windows.Forms.Label dato1;
        private System.Windows.Forms.ComboBox cmbMotivoDev;
        private System.Windows.Forms.Label lblMotivoDev;
        private Bunifu.Framework.UI.BunifuCheckbox chkMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPenalizacion;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntregaDeTodoElPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDevoluciónDeTodoElPedidoToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.TextBox txtPenalizacion;
        private System.Windows.Forms.Label lblporcentaje;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        public System.Windows.Forms.Label lblUsuario;
    }
}