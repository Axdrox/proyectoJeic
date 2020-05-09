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
        int cve_pedido;
        int cve_factura;
        int cantidad = 0;
        int cantidadD = 0;
        int cve_pieza = 0;
        DateTime fecha = DateTime.MinValue;
        DateTime fecha_asignacion = DateTime.MinValue;
        DateTime fecha_promesa = DateTime.MinValue;
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
            /*cve_siniestro = dato1.Text;
            cve_pedido = Int32.Parse(dato2.Text);*/
            
            cve_pedido = Int32.Parse(dato2.Text.Substring(8, (dato2.Text.Length - 8)));
            cve_siniestro = dato1.Text.Substring(11, dato1.Text.Length - 11);
            dgvDevolucion.DataSource = oper.Devolucion(cve_siniestro, cve_pedido);
            count = oper.Total_Registros() +1 ;
            count2 = oper.Total_Registros2() + 1;
           
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

                //MessageBox.Show(fila.ToString());
                cantidad = Int32.Parse(dgvDevolucion.Rows[fila].Cells[2].Value.ToString());

                /* for (int i =1; i<=cantidad;i++)
                 {
                     cmbCantidad.Items.Add(i.ToString());
                 }*/

                cve_pieza = Int32.Parse(dgvDevolucion.Rows[fila].Cells[1].Value.ToString());
                cve_factura = Int32.Parse(dgvDevolucion.Rows[fila].Cells[10].Value.ToString());
                fecha_asignacion = DateTime.Parse(dgvDevolucion.Rows[fila].Cells[7].Value.ToString());//7
                fecha_promesa = DateTime.Parse(dgvDevolucion.Rows[fila].Cells[9].Value.ToString());//9
                MessageBox.Show("Ahora seleccione Entrega o Devolución, así como la cantidad");
                rbtnEntrega.Enabled = true;
                rbtnDevolucion.Enabled = true;
                dtpFecha.Enabled = true;
                cmbCantidad.Enabled = true;
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
                dgvDevolucion.Enabled = false;

                pzas_entregadas = oper.Pzas_Entregadas(cve_siniestro, cve_pedido, cve_pieza);
                pzas_devolucion = oper.Pzas_Devolucion(cve_siniestro, cve_pedido, cve_pieza);
                //MessageBox.Show(pzas_entregadas.ToString());
                rbtnEntrega.Checked = true;
            }
        }

        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            //rbtnDevolucion.Checked = false;
            //cmbCantidad.Enabled = true;
            lbl1.Text = "Fecha Entrega";
            lbl2.Text = "Cantidad Entregada";
            btnAceptar.Text = "ENTREGA";
            cmbCantidad.Items.Clear();
            for(int i=1; i<=(cantidad-pzas_entregadas); i++)
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

        }

        private void rbtnDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            //rbtnEntrega.Checked = false;
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
            }
            else
            {
                cmbCantidad.Enabled = false;
                cmbMotivoDev.Enabled = false;
            }
            lblMotivoDev.Visible = true;
            //cmbMotivoDev.Enabled = true;
            cmbMotivoDev.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbCantidad.Items.Count == 0 )
            {
                if (rbtnEntrega.Checked == true)
                    MessageBox.Show("Ya se registraron todas las entregas disponibles para esa pieza");
                else
                    MessageBox.Show("Ya se registraron todas las devoluciones disponibles para esa pieza");
            }
            else
            {
                fecha = DateTime.Parse(dtpFecha.Value.ToShortDateString());
                cantidadD = Int32.Parse(cmbCantidad.Text);



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
                        string motivo = cmbMotivoDev.Text.Trim();
                        MessageBox.Show(oper.Registrar_Devolucion(cve_siniestro, cve_pedido, cve_pieza, count, cantidad, fecha, cantidadD, cve_factura,motivo));
                        cmbCantidad.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se realizó ninguna operación");
                    }
                }
                else if (rbtnEntrega.Checked == true)
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
                        MessageBox.Show(oper.Registrar_Entrega(cve_siniestro, cve_pedido, cve_pieza, count2, cantidad, fecha, cantidadD, cve_factura, fecha_asignacion, fecha_promesa));
                        cmbCantidad.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se realizó ninguna operación");
                    }

                }

                refresh();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbCantidad.Items.Clear();
            rbtnEntrega.Enabled = false;
            rbtnDevolucion.Enabled = false;
            dtpFecha.Enabled = false;
            cmbCantidad.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            dgvDevolucion.Enabled = true;
            cmbMotivoDev.Text = "";
            cmbMotivoDev.Enabled = false;
        }
    }
}
