using Refracciones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones.Forms
{
    public partial class Devolucion : Form
    {
        int count;//total registros en DEVOLUCION
        int count2;//total registros en Entrega
        int pzas_entregadas;//piezas entregadas en la tabla de pedido
        int pzas_devolucion;//piezas regresadas por el cliente
        string cve_siniestro;
        string cve_pedido;
        string motivo;
        //int cve_factura;
        int cve_venta;
        int cantidad = 0;
        int cantidadD = 0;
        int cve_pieza = 0;
        decimal penalizacion = 0;
        DateTime fecha = DateTime.MinValue;
        DateTime fecha_asignacion = DateTime.MinValue;
       // DateTime fecha_promesa = DateTime.MinValue;
        DialogResult oDlgRes;
        OperBD oper = new OperBD();
        public Devolucion()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            //Colocar ICONO
            this.Icon = Resources.iconJeic;

            cve_pedido = dato2.Text.Substring(8, (dato2.Text.Length - 8));
            cve_siniestro = dato1.Text.Substring(11, dato1.Text.Length - 11);
            dgvDevolucion.DataSource = oper.Devolucion(cve_siniestro, cve_pedido);
            menu.ForeColor = Color.White;
            /*count = oper.Total_Registros() +1 ;
            count2 = oper.Total_Registros2() + 1;*/
            
            //MessageBox.Show(count.ToString());
        }

        private void refresh()
        {
            dgvDevolucion.DataSource = oper.Devolucion(cve_siniestro,cve_pedido);
        }
        private void dgvDevolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            { }
            else if (e.ColumnIndex == -1)
            { }
            else
            {
                int fila = Int32.Parse(e.RowIndex.ToString());
                cantidad = Int32.Parse(dgvDevolucion.Rows[fila].Cells[2].Value.ToString());
                cve_pieza = Int32.Parse(dgvDevolucion.Rows[fila].Cells[1].Value.ToString());
                cve_venta = Int32.Parse(dgvDevolucion.Rows[fila].Cells[11].Value.ToString());
                fecha_asignacion = DateTime.Parse(dgvDevolucion.Rows[fila].Cells[7].Value.ToString());//7
               
                MessageBox.Show("Pieza seleccionada: "+ dgvDevolucion.Rows[fila].Cells[0].Value.ToString());
                rbtnEntrega.Enabled = true;
                rbtnDevolucion.Enabled = true;
                rbtnDevolucion.Checked = true;
                dtpFecha.Enabled = true;
                cmbCantidad.Enabled = true;
                cmbCantidad.Visible = true;
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
                lbl2.Visible = true;
                dgvDevolucion.Enabled = false;
                txtPenalizacion.Enabled = false;
                txtPenalizacion.Visible = false;
                pzas_entregadas = oper.Pzas_Entregadas(cve_siniestro, cve_pedido, cve_pieza);
                pzas_devolucion = oper.Pzas_Devolucion(cve_siniestro, cve_pedido, cve_pieza);
                rbtnEntrega.Checked = true;
            }
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            //rbtnDevolucion.Checked = false;
            //cmbCantidad.Enabled = true;
            if (rbtnEntrega.Checked == true)
            {
                lbl1.Text = "Fecha Entrega";
                lbl2.Text = "Cantidad Entregada";
                lbl2.Visible = true;
                btnAceptar.Text = "ENTREGA";
                cmbCantidad.Items.Clear();
                cmbCantidad.Visible = true;
                for (int i = 1; i <= (cantidad - pzas_entregadas); i++)
                {
                    cmbCantidad.Items.Add(i.ToString());
                }
                if (cmbCantidad.Items.Count != 0)
                {
                    cmbCantidad.Enabled = true;
                    cmbCantidad.SelectedIndex = 0;
                }
                else
                {
                    cmbCantidad.Enabled = false;
                }
                lblMotivoDev.Visible = false;
                cmbMotivoDev.Enabled = false;
                cmbMotivoDev.Visible = false;
                chkMotivo.Visible = false;
                chkMotivo.Enabled = false;
                label1.Visible = false;
                lblPenalizacion.Visible = false;
                txtPenalizacion.Enabled = false;
                txtPenalizacion.Visible = false;
                lblporcentaje.Visible = false;
            }
        }

        private void rbtnDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            //rbtnEntrega.Checked = false;
            if (rbtnDevolucion.Checked == true)
            {
                //cmbCantidad.SelectedIndex = 0;
                //cmbPenalizacion.SelectedIndex = 0;
                lbl1.Text = "Fecha Devolucion";
                lbl2.Text = "Cantidad a Devolver";
                btnAceptar.Text = "DEVOLUCIÓN";
                cmbCantidad.Items.Clear();
                for (int i = 1; i <= pzas_entregadas - pzas_devolucion; i++)
                {
                    cmbCantidad.Items.Add(i.ToString());
                }
                if (cmbCantidad.Items.Count != 0)
                {
                    cmbCantidad.Enabled = true;
                    cmbCantidad.SelectedIndex = 0;
                    cmbMotivoDev.Enabled = true;
                    cmbMotivoDev.SelectedIndex = 0;
                }
                else
                {
                    cmbCantidad.Enabled = false;
                    cmbMotivoDev.Enabled = false;
                }
                lblMotivoDev.Visible = true;
                //cmbMotivoDev.Enabled = true;
                cmbMotivoDev.Visible = true;
                chkMotivo.Enabled = true;
                chkMotivo.Visible = true;
                label1.Visible = true;
                lblPenalizacion.Visible = true;
                txtPenalizacion.Enabled = true;
                txtPenalizacion.Visible = true;
                lblporcentaje.Visible = true;
                
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbCantidad.Text.Trim() == "")
            {
                errorP.SetError(cmbCantidad, "Tiene que ingresar este campo");
                cmbCantidad.Focus();
            }
            else
            {
                errorP.Clear();
                if (cmbCantidad.Items.Count == 0)
                {
                    if (rbtnEntrega.Checked == true)
                        MessageBox.Show("Ya se registraron todas las entregas disponibles para esa pieza");
                    else
                        MessageBox.Show("Ya se registraron todas las devoluciones disponibles para esa pieza");
                }
                else
                {
                    fecha = DateTime.Parse(dtpFecha.Value.ToShortDateString());//Fecha entrega o devolución
                    cantidadD = Int32.Parse(cmbCantidad.Text);//Cantidad a entregar o devolver



                    if (rbtnDevolucion.Checked == true)
                    {
                        cantidad = pzas_devolucion + cantidadD;
                        oDlgRes = MessageBox.Show("¿Está seguro que desea Registrar la devolución del registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (oDlgRes == DialogResult.Yes)
                        {
                            rbtnEntrega.Enabled = false;
                            rbtnDevolucion.Enabled = false;
                            dtpFecha.Enabled = false;
                            cmbCantidad.Enabled = false;
                            btnAceptar.Enabled = false;
                            btnCancelar.Enabled = false;
                            dgvDevolucion.Enabled = true;
                            cmbMotivoDev.Text = "";
                            cmbMotivoDev.Enabled = false;
                            if (chkMotivo.Checked != true)
                                motivo = cmbMotivoDev.SelectedItem.ToString();
                            else
                                motivo = txtMotivo.Text.Trim();
                            
                            penalizacion = decimal.Parse(txtPenalizacion.Text.Trim());
                            count = oper.Total_Registros() + 1;//Se calcula el total de registros en la tabla Devolución
                            MessageBox.Show(oper.Registrar_Devolucion(cve_siniestro, cve_pedido, cve_pieza, count, cantidad, fecha, cantidadD, cve_venta, motivo, penalizacion));
                            cmbCantidad.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se realizó ninguna operación");
                        }
                    }
                    else if (rbtnEntrega.Checked == true)
                    {
                        if (btnAceptar.Text == "ENTREGA")
                        {
                            cantidad = pzas_entregadas + cantidadD;
                            oDlgRes = MessageBox.Show("¿Está seguro que desea Registrar la entrega del registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (oDlgRes == DialogResult.Yes)
                            {
                                rbtnEntrega.Enabled = false;
                                rbtnDevolucion.Enabled = false;
                                dtpFecha.Enabled = false;
                                cmbCantidad.Enabled = false;
                                btnAceptar.Enabled = false;
                                btnCancelar.Enabled = false;
                                dgvDevolucion.Enabled = true;
                                count2 = oper.Total_Registros2() + 1;//Se calcula el total de registros en la tabla Entrega
                                MessageBox.Show(oper.Registrar_Entrega(cve_siniestro, cve_pedido, cve_pieza, count2, cantidad, fecha, cantidadD, cve_venta, fecha_asignacion));
                                cmbCantidad.Items.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se realizó ninguna operación");
                            }
                        }
                        
                        
                    }
                    
                }
            }
            if (btnAceptar.Text.Equals("ENTREGAR TODO"))
            {
               if(entregarTodo() == 1)
                {
                    MessageBox.Show("Se registro la entrega de todo el pedido correctamente!");
                }
                else
                {
                    MessageBox.Show("No se realizó ninguna operación");
                }
                errorP.Clear();
            }
            else if (btnAceptar.Text.Equals("DEVOLVER TODO"))
            {
                if(devolverTodo() == 1)
                {
                    MessageBox.Show("Se registro la devolución de todo el pedido correctamente!");
                }
                else
                {
                    MessageBox.Show("No se realizó ninguna operación");
                }
                errorP.Clear();
            }
            refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbCantidad.Items.Clear();
            rbtnEntrega.Enabled = false;
            rbtnEntrega.Checked = true;
            rbtnDevolucion.Enabled = false;
            dtpFecha.Enabled = false;
            cmbCantidad.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            dgvDevolucion.Enabled = true;
            cmbMotivoDev.Text = "";
            cmbMotivoDev.Enabled = false;
            txtPenalizacion.Enabled = false;
            errorP.Clear();
        }

        private void chkMotivo_OnChange(object sender, EventArgs e)
        {
            if(chkMotivo.Checked == true)
            {
                txtMotivo.Enabled = true;
                txtMotivo.Visible = true;
                cmbMotivoDev.Enabled = false;
                cmbMotivoDev.Visible = false;
            }
            else
            {
                txtMotivo.Enabled = false;
                txtMotivo.Visible = false;
                cmbMotivoDev.Enabled = true;
                cmbMotivoDev.Visible = true;
                cmbMotivoDev.SelectedIndex = 0;
            }
        }

        private void registrarEntregaDeTodoElPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            rbtnEntrega.Enabled = true;
            rbtnDevolucion.Enabled = true;
            dtpFecha.Enabled = true;
            cmbCantidad.Enabled = false;
            cmbCantidad.Visible = false;
            lbl2.Visible = false;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            dgvDevolucion.Enabled = false;
            txtPenalizacion.Enabled = false;
            txtPenalizacion.Visible = false;
            rbtnEntrega.Checked = true;
            rbtnDevolucion.Enabled = false;
            btnAceptar.Text = "ENTREGAR TODO";
        }
        private int entregarTodo()
        {
            int x = 0;
            oDlgRes = MessageBox.Show("¿Está seguro que desea Registrar la entrega de todo el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (oDlgRes == DialogResult.Yes)
            {
                int filas = dgvDevolucion.RowCount;
                fecha = DateTime.Parse(dtpFecha.Value.ToShortDateString());//Fecha entrega

                for (int i = 0; i < filas; i++)
                {
                    fecha_asignacion = DateTime.Parse(dgvDevolucion.Rows[i].Cells[7].Value.ToString());// fecha asiganción de la venta
                    cve_venta = Int32.Parse(dgvDevolucion.Rows[i].Cells[11].Value.ToString());//clave de venta en el pedido
                    cantidad = Int32.Parse(dgvDevolucion.Rows[i].Cells[2].Value.ToString());//cantidad vendida en el pedido
                    cve_pieza = Int32.Parse(dgvDevolucion.Rows[i].Cells[1].Value.ToString());//clave de la pieza
                    pzas_entregadas = oper.Pzas_Entregadas(cve_siniestro, cve_pedido, cve_pieza);
                    count2 = oper.Total_Registros2() + 1;//Se calcula el total de registros en la tabla Entrega
                    if (pzas_entregadas != cantidad)
                    {
                        oper.Registrar_Entrega(cve_siniestro, cve_pedido, cve_pieza, count2, cantidad, fecha, (cantidad - pzas_entregadas), cve_venta, fecha_asignacion);
                        x = 1;
                    }
                    else
                    {
                        //MessageBox.Show("NADA! QUE HACER");
                        x = 0;
                    }
                }
                //MessageBox.Show("Se registro la entrega de todo el pedido correctamente!");
                btnAceptar.Text = "ENTREGA";
                btnAceptar.Enabled = false;
                dtpFecha.Enabled = false;
                dgvDevolucion.Enabled = true;
                btnCancelar.Enabled = false;
                
            }
            return x;
        }
        private int devolverTodo()
        {
            int x = 0;
            oDlgRes = MessageBox.Show("¿Está seguro que desea Registrar la devolución de las piezas entregadas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (oDlgRes == DialogResult.Yes)
            {
                int filas = dgvDevolucion.RowCount;
                fecha = DateTime.Parse(dtpFecha.Value.ToShortDateString());//Fecha devolución
                if (chkMotivo.Checked != true)
                    motivo = cmbMotivoDev.SelectedItem.ToString();
                else
                    motivo = txtMotivo.Text.Trim();
                /*if (cmbPenalizacion.Text.Equals("20%"))
                    penalizacion = 2;
                else if (cmbPenalizacion.Text.Equals("100%"))
                    penalizacion = 3;*/
                penalizacion = decimal.Parse(txtPenalizacion.Text.Trim());
                for (int i = 0; i < filas; i++)
                {
                    cve_venta = Int32.Parse(dgvDevolucion.Rows[i].Cells[11].Value.ToString());//clave de venta en el pedido
                    cantidad = Int32.Parse(dgvDevolucion.Rows[i].Cells[2].Value.ToString());//cantidad vendida en el pedido
                    cve_pieza = Int32.Parse(dgvDevolucion.Rows[i].Cells[1].Value.ToString());//clave de la pieza
                    pzas_devolucion = oper.Pzas_Devolucion(cve_siniestro, cve_pedido, cve_pieza);
                    pzas_entregadas = oper.Pzas_Entregadas(cve_siniestro, cve_pedido, cve_pieza);
                    count = oper.Total_Registros() + 1;//Se calcula el total de registros en la tabla Devolución
                    if (pzas_devolucion != pzas_entregadas)
                    {
                        oper.Registrar_Devolucion(cve_siniestro, cve_pedido, cve_pieza, count, pzas_entregadas, fecha, pzas_entregadas, cve_venta, motivo, penalizacion);
                        x = 1;
                    }
                    else
                    {
                        //MessageBox.Show("NADA! QUE HACER");
                        x = 0;
                    }
                }
                //MessageBox.Show("Se registro la devolución de todo el pedido correctamente!");
                btnAceptar.Text = "ENTREGA";
                btnAceptar.Enabled = false;
                dtpFecha.Enabled = false;
                dgvDevolucion.Enabled = true;
                btnCancelar.Enabled = false;
                txtPenalizacion.Visible = false;
                
            }
            return x;
        }

        private void registrarDevoluciónDeTodoElPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbtnEntrega.Enabled = false;
            rbtnDevolucion.Checked = true;
            lbl2.Visible = false;
            cmbCantidad.Enabled = false;
            cmbCantidad.Visible = false;
            dtpFecha.Enabled = true;
            btnCancelar.Enabled = true;
            cmbMotivoDev.Enabled = true;
            cmbMotivoDev.SelectedIndex = 0;
            chkMotivo.Enabled = true;
            btnAceptar.Enabled = true;
            txtPenalizacion.Visible = true;
            btnAceptar.Text = "DEVOLVER TODO";
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void chkPenalizacion_OnChange(object sender, EventArgs e)
        {
            /*if (chkPenalizacion.Checked == true)
            {
                txtPenalizacion.Enabled = true;
                txtPenalizacion.Visible = true;
                cmbPenalizacion.Enabled = false;
                cmbPenalizacion.Visible = false;
            }
            else
            {
                txtPenalizacion.Enabled = false;
                txtPenalizacion.Visible = false;
                cmbPenalizacion.Enabled = true;
                cmbPenalizacion.Visible = true;
                cmbPenalizacion.SelectedIndex = 0;
            }*/
        }
    }
}
