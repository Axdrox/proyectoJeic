using Microsoft.Win32;
using Refracciones.Forms;
using SpreadsheetLight;
using System;
using System.Collections.Generic;

//Librerias
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refracciones
{
    internal class OperBD
    {
        //VARIABLES
        private SqlCommand Comando;

        private SqlDataReader Lector;
        private DataTable dt;
        private SqlDataAdapter da;

        //METODOS

        public int logeo(string us, string pass)
        {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    this.Comando = new SqlCommand(string.Format("SELECT usuario,contrasenia FROM usuarios WHERE usuario='{0}' AND dbo.fnDescifraClave(contrasenia) COLLATE SQL_Latin1_General_CP1_CS_AS = '{1}' AND estado=1", us, pass), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { contador++; }
                    Lector.Close();
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }

        //----------------------------------REGISTRAR USUARIO----------------------------------------------
        public int singUp(string us, string pass, string rol)
        {
            int contador = 0;
            int x = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();

                    if (logeo(us, pass) == 0)
                    {
                        this.Comando = new SqlCommand(string.Format("SELECT cve_rol FROM ROL WHERE area = '{0}'", rol), nuevacon);
                        Lector = this.Comando.ExecuteReader();
                        while (Lector.Read()) { x = Int32.Parse(Lector["cve_rol"].ToString()); }
                        Lector.Close();
                        this.Comando = new SqlCommand(string.Format("INSERT INTO USUARIOS (usuario,contrasenia,rol) VALUES ('{0}',dbo.fnColocaClave('{1}'),{2});", us, pass, x), nuevacon);
                        this.Comando.ExecuteNonQuery();
                        MessageBOX.SHowDialog(1, "Se registro correctamente!");
                    }
                    else
                    {
                        MessageBOX.SHowDialog(2, "Ya existe ese nombre de usuario");
                    }
                    nuevacon.Close();
                }
                return contador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return contador;
            }
        }

        //----------------------------------ACTUALIZAR DATOS USUARIO----------------------------------------------
        public void ActualizarDatosUsuario(string us, string pass, string rol, int estado)
        {
            int x = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    nuevacon.Open();
                    this.Comando = new SqlCommand(string.Format("SELECT cve_rol FROM ROL WHERE area = '{0}'", rol), nuevacon);
                    Lector = this.Comando.ExecuteReader();
                    while (Lector.Read()) { x = Int32.Parse(Lector["cve_rol"].ToString()); }
                    Lector.Close();
                    this.Comando = new SqlCommand("UPDATE USUARIOS SET contrasenia = dbo.fnColocaClave(@contrasenia), rol = @rol, estado = @estado WHERE usuario = @usuario", nuevacon);
                    this.Comando.Parameters.AddWithValue("@contrasenia", pass);
                    this.Comando.Parameters.AddWithValue("@rol", x);
                    this.Comando.Parameters.AddWithValue("@usuario", us);
                    this.Comando.Parameters.AddWithValue("@estado", estado);
                    this.Comando.ExecuteNonQuery();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //--------------------SE UTILIZA PARA SABER SI YA EXISTE ESA FACTURA----------------
        public string factExistente(string cve_factura)
        {
            string factura;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT cve_factura FROM FACTURA WHERE cve_factura = '{0}'", cve_factura), nuevaConexion);
                if (Comando.ExecuteScalar() == null || Comando.ExecuteScalar().ToString() == string.Empty)
                { factura = "0"; }
                else { factura = Comando.ExecuteScalar().ToString(); }

                nuevaConexion.Close();
            }
            return factura;
        }

        //--------------------INGRESAR FACTURA--------------------
        public string Registrar_factura(string cve_siniestro, string cve_pedido, string cve_factura, int cve_estado, decimal fact_sinIVA, decimal descuento, decimal fact_neto, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario, string realizo)
        {
            string mensaje = "Se inserto la factura";
            // try
            //{
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                SqlCommand cmd;
                SqlCommand comm;
                if (archivo == null && archivo_xml == null)
                {
                    cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,descuento,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,comentario,realizo) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@descuento,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@comentario,@realizo)", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@descuento", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                    cmd.Parameters["@cve_factura"].Value = cve_factura;
                    cmd.Parameters["@cve_estado"].Value = cve_estado;
                    cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    cmd.Parameters["@descuento"].Value = descuento;
                    cmd.Parameters["@fact_neto"].Value = fact_neto;
                    cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                    cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                    cmd.Parameters["@comentario"].Value = comentario;
                    cmd.Parameters["@realizo"].Value = realizo;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario)", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@descuento", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    cmd.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@archivo", SqlDbType.VarBinary);
                    cmd.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                    cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                    cmd.Parameters["@cve_factura"].Value = cve_factura;
                    cmd.Parameters["@cve_estado"].Value = cve_estado;
                    cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    cmd.Parameters["@descuento"].Value = descuento;
                    cmd.Parameters["@fact_neto"].Value = fact_neto;
                    cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                    cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                    cmd.Parameters["@nombre_factura"].Value = nombre_factura;
                    cmd.Parameters["@archivo"].Value = archivo;
                    cmd.Parameters["@nombre_xml"].Value = nombre_xml;
                    cmd.Parameters["@archivo_xml"].Value = archivo_xml;
                    cmd.Parameters["@comentario"].Value = comentario;
                    cmd.Parameters["@realizo"].Value = realizo;
                    cmd.ExecuteNonQuery();
                }
                //MessageBox.Show(cve_siniestro.ToString());
                //MessageBox.Show(cve_pedido.ToString());
                comm = new SqlCommand(string.Format("UPDATE VENTAS SET cve_factura = '{0}' WHERE cve_siniestro = '{1}' AND cve_pedido = '{2}'", cve_factura, cve_siniestro, cve_pedido), nuevaConexion);
                comm.ExecuteNonQuery();
                nuevaConexion.Close();
            }
            // }
            //catch (Exception)
            //{
            //     mensaje = "No se inserto la factura, es posible que exista una con el mismo folio: ";
            // }
            return mensaje;
        }
        //--------------------INGRESAR FACTURA PIEZA POR PIEZA--------------------
        public string Registrar_factura(string cve_siniestro, string cve_pedido, string cve_factura, int cve_estado, decimal fact_sinIVA, decimal descuento, decimal fact_neto, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario, string realizo, string pieza, int cvePedidoIdentity)
        {
            string mensaje = "Se inserto la factura";
            // try
            //{
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                SqlCommand cmd;
                SqlCommand comm;
                if (archivo == null && archivo_xml == null)
                {
                    cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,descuento,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,comentario,realizo) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@descuento,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@comentario,@realizo)", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@descuento", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                    cmd.Parameters["@cve_factura"].Value = cve_factura;
                    cmd.Parameters["@cve_estado"].Value = cve_estado;
                    cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    cmd.Parameters["@descuento"].Value = descuento;
                    cmd.Parameters["@fact_neto"].Value = fact_neto;
                    cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                    cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                    cmd.Parameters["@comentario"].Value = comentario;
                    cmd.Parameters["@realizo"].Value = realizo;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario)", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@descuento", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    cmd.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@archivo", SqlDbType.VarBinary);
                    cmd.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                    cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                    cmd.Parameters["@cve_factura"].Value = cve_factura;
                    cmd.Parameters["@cve_estado"].Value = cve_estado;
                    cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    cmd.Parameters["@descuento"].Value = descuento;
                    cmd.Parameters["@fact_neto"].Value = fact_neto;
                    cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                    cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                    cmd.Parameters["@nombre_factura"].Value = nombre_factura;
                    cmd.Parameters["@archivo"].Value = archivo;
                    cmd.Parameters["@nombre_xml"].Value = nombre_xml;
                    cmd.Parameters["@archivo_xml"].Value = archivo_xml;
                    cmd.Parameters["@comentario"].Value = comentario;
                    cmd.Parameters["@realizo"].Value = realizo;
                    cmd.ExecuteNonQuery();
                }
                //MessageBox.Show(cve_siniestro.ToString());
                //MessageBox.Show(cve_pedido.ToString());
                comm = new SqlCommand(string.Format("UPDATE p SET p.cve_factura = '{0}' FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta INNER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza WHERE ven.cve_siniestro = '{1}' AND ven.cve_pedido = '{2}' AND pie.nombre = '{3}' AND p.cve_pedido = {4}", cve_factura, cve_siniestro, cve_pedido, pieza, cvePedidoIdentity), nuevaConexion);
                comm.ExecuteNonQuery();
                nuevaConexion.Close();
            }
            // }
            //catch (Exception)
            //{
            //     mensaje = "No se inserto la factura, es posible que exista una con el mismo folio: ";
            // }
            return mensaje;
        }
        //----------------------------------------------------------------------------------

        //--------------------RECUPERAR FACTURA (PDF)--------------------
        public byte[] Buscar_factura(string cve_factura)
        {
            byte[] factura;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("select archivo from FACTURA where cve_factura= @cve_factura", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_factura", cve_factura);
                factura = Comando.ExecuteScalar() as byte[];
                nuevaConexion.Close();
            }
            return factura;
        }

        //---------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------

        //--------------------RECUPERAR FACTURA (XML)--------------------
        public byte[] Buscar_factura_xml(string cve_factura)
        {
            byte[] factura;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("select archivo_xml from FACTURA where cve_factura= @cve_factura", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_factura", cve_factura);
                factura = Comando.ExecuteScalar() as byte[];
                nuevaConexion.Close();
            }
            return factura;
        }

        //---------------------------------------------------------------------------------

        //--------------------RECUPERAR NOMBRE FACTURA--------------------
        public string Nombre_Factura(string cve_factura)
        {
            string factura;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("select nombre_factura from FACTURA where cve_factura= @cve_factura", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_factura", cve_factura);
                factura = Comando.ExecuteScalar() as string;
                nuevaConexion.Close();
            }
            return factura;
        }

        //--------------------------------------------------------------------------------
        //--------------------RECUPERAR NOMBRE FACTURA (XML)--------------------
        public string Nombre_Factura_xml(string cve_factura)
        {
            string factura;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("select nombre_xml from FACTURA where cve_factura= @cve_factura", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_factura", cve_factura);
                factura = Comando.ExecuteScalar() as string;
                nuevaConexion.Close();
            }
            return factura;
        }

        //--------------------------------------------------------------------------------

        //--------------------INGRESAR REFACTURA--------------------
        public string Registrar_Refactura(string cve_siniestro, string cve_pedido, string cve_factura, int cve_estado, string cve_refactura, decimal fact_sinIVA, decimal descuento, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario, string realizo)
        {
            string mensaje = "Se inserto la factura";
            SqlCommand comm;
            SqlCommand cmd;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    if (archivo == null && archivo_xml == null)
                    {
                        Comando = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,cve_refactura,fact_sinIVA,descuento,fact_neto,costo_refactura,fecha_refactura,fecha_ingreso,fecha_revision,fecha_pago,comentario,realizo) VALUES (@cve_factura,@cve_estado,@cve_refactura,@fact_sinIVA,@descuento,@fact_neto,@costo_refactura,@fecha_refactura,@fecha_ingreso,@fecha_revision,@fecha_pago,@comentario,@realizo)", nuevaConexion);
                        Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_refactura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                        Comando.Parameters["@cve_factura"].Value = cve_factura;
                        Comando.Parameters["@cve_estado"].Value = cve_estado;
                        Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                        Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        Comando.Parameters["@descuento"].Value = descuento;
                        Comando.Parameters["@fact_neto"].Value = fact_neto;
                        Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                        Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                        Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                        Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                        Comando.Parameters["@comentario"].Value = comentario;
                        Comando.Parameters["@realizo"].Value = realizo;
                        Comando.ExecuteNonQuery();
                    }
                    else
                    {
                        Comando = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,cve_refactura,fact_sinIVA,fact_neto,costo_refactura,fecha_refactura,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario,realizo) VALUES (@cve_factura,@cve_estado,@cve_refactura,@fact_sinIVA,@fact_neto,@costo_refactura,@fecha_refactura,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario,@realizo)", nuevaConexion);
                        Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_refactura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        Comando.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@archivo", SqlDbType.VarBinary);
                        Comando.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                        Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                        Comando.Parameters["@cve_factura"].Value = cve_factura;
                        Comando.Parameters["@cve_estado"].Value = cve_estado;
                        Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                        Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        Comando.Parameters["@descuento"].Value = descuento;
                        Comando.Parameters["@fact_neto"].Value = fact_neto;
                        Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                        Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                        Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                        Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                        Comando.Parameters["@nombre_factura"].Value = nombre_factura;
                        Comando.Parameters["@archivo"].Value = archivo;
                        Comando.Parameters["@nombre_xml"].Value = nombre_xml;
                        Comando.Parameters["@archivo_xml"].Value = archivo_xml;
                        Comando.Parameters["@comentario"].Value = comentario;
                        Comando.Parameters["@realizo"].Value = realizo;
                        Comando.ExecuteNonQuery();
                    }

                    comm = new SqlCommand(string.Format("UPDATE VENTAS SET cve_factura = '{0}' WHERE cve_siniestro = '{1}' AND cve_pedido = '{2}'", cve_factura, cve_siniestro, cve_pedido), nuevaConexion);
                    comm.ExecuteNonQuery();
                    cmd = new SqlCommand(string.Format("UPDATE FACTURA SET cve_refactura = '{0}' WHERE cve_factura = '{1}'", cve_factura, cve_refactura), nuevaConexion);
                    cmd.ExecuteNonQuery();
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la factura: " + ex.ToString();
            }
            return mensaje;
        }

        //----------------------------------------------------------------------------------------
        //--------------------INGRESAR REFACTURA PIEZA POR PIEZA--------------------
        public string Registrar_Refactura(string cve_siniestro, string cve_pedido, string cve_factura, int cve_estado, string cve_refactura, decimal fact_sinIVA, decimal descuento, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario, string realizo, string pieza, int cvePedidoIdentity)
        {
            string mensaje = "Se inserto la factura";
            SqlCommand comm;
            SqlCommand cmd;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    if (archivo == null && archivo_xml == null)
                    {
                        Comando = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,cve_refactura,fact_sinIVA,descuento,fact_neto,costo_refactura,fecha_refactura,fecha_ingreso,fecha_revision,fecha_pago,comentario,realizo) VALUES (@cve_factura,@cve_estado,@cve_refactura,@fact_sinIVA,@descuento,@fact_neto,@costo_refactura,@fecha_refactura,@fecha_ingreso,@fecha_revision,@fecha_pago,@comentario,@realizo)", nuevaConexion);
                        Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_refactura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                        Comando.Parameters["@cve_factura"].Value = cve_factura;
                        Comando.Parameters["@cve_estado"].Value = cve_estado;
                        Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                        Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        Comando.Parameters["@descuento"].Value = descuento;
                        Comando.Parameters["@fact_neto"].Value = fact_neto;
                        Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                        Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                        Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                        Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                        Comando.Parameters["@comentario"].Value = comentario;
                        Comando.Parameters["@realizo"].Value = realizo;
                        Comando.ExecuteNonQuery();
                    }
                    else
                    {
                        Comando = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,cve_refactura,fact_sinIVA,fact_neto,costo_refactura,fecha_refactura,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario,realizo) VALUES (@cve_factura,@cve_estado,@cve_refactura,@fact_sinIVA,@fact_neto,@costo_refactura,@fecha_refactura,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario,@realizo)", nuevaConexion);
                        Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_refactura", SqlDbType.NVarChar, 50);
                        Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        Comando.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@archivo", SqlDbType.VarBinary);
                        Comando.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                        Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                        Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                        Comando.Parameters["@cve_factura"].Value = cve_factura;
                        Comando.Parameters["@cve_estado"].Value = cve_estado;
                        Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                        Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        Comando.Parameters["@descuento"].Value = descuento;
                        Comando.Parameters["@fact_neto"].Value = fact_neto;
                        Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                        Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                        Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                        Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                        Comando.Parameters["@nombre_factura"].Value = nombre_factura;
                        Comando.Parameters["@archivo"].Value = archivo;
                        Comando.Parameters["@nombre_xml"].Value = nombre_xml;
                        Comando.Parameters["@archivo_xml"].Value = archivo_xml;
                        Comando.Parameters["@comentario"].Value = comentario;
                        Comando.Parameters["@realizo"].Value = realizo;
                        Comando.ExecuteNonQuery();
                    }

                    comm = new SqlCommand(string.Format("UPDATE p SET p.cve_factura = '{0}' FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta INNER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza WHERE ven.cve_siniestro = '{1}' AND ven.cve_pedido = '{2}' AND pie.nombre = '{3}' AND p.cve_pedido = {4}", cve_factura, cve_siniestro, cve_pedido, pieza, cvePedidoIdentity), nuevaConexion);
                    comm.ExecuteNonQuery();
                    cmd = new SqlCommand(string.Format("UPDATE FACTURA SET cve_refactura = '{0}' WHERE cve_factura = '{1}'", cve_factura, cve_refactura), nuevaConexion);
                    cmd.ExecuteNonQuery();
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la factura: " + ex.ToString();
            }
            return mensaje;
        }
        //--------------------LLENAR DATAGRID DEVOLUCIÓN-ENTREGA--------------------
        /*public DataTable Devolucion(string cve_siniestro, string cve_pedido)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT DISTINCT pie.nombre AS NOMBRE, pie.cve_pieza AS 'CLAVE PIEZA', ped.cantidad AS CANTIDAD, prov.nombre AS PROVEEDOR, ven.cve_vendedor AS VENDEDOR, val.nombre AS VALUADOR, c.cve_nombre AS CLIENTE, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ped.fecha_entrega AS 'FECHA DE ENTREGA', ven.fecha_promesa  AS 'FECHA PROMESA', fac.cve_factura AS FACTURA,ven.cve_venta AS 'CLAVE VENTA' FROM PEDIDO ped JOIN VENTAS ven ON ven.cve_venta = ped.cve_venta JOIN PROVEEDOR prov ON prov.cve_proveedor = ped.cve_proveedor JOIN PIEZA pie ON pie.cve_pieza = ped.cve_pieza JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador LEFT OUTER JOIN FACTURA fac ON fac.cve_factura = ven.cve_factura WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND ped.pzas_devolucion != ped.cantidad", cve_siniestro, cve_pedido), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }*/

        //---------------------------------------------------------------------------------------------------
        //--------------------LLENAR DATAGRID DEVOLUCIÓN-ENTREGA PIEZA POR PIEZA--------------------
        public DataTable Devolucion(string cve_siniestro, string cve_pedido)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT  pie.nombre AS NOMBRE, pie.cve_pieza AS 'CLAVE PIEZA', ped.cantidad AS CANTIDAD, prov.nombre AS PROVEEDOR, ven.cve_vendedor AS VENDEDOR, val.nombre AS VALUADOR, c.cve_nombre AS CLIENTE, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ped.fecha_entrega AS 'FECHA DE ENTREGA', ven.fecha_promesa  AS 'FECHA PROMESA', fac.cve_factura AS FACTURA,ven.cve_venta AS 'CLAVE VENTA', ped.cve_pedido AS 'CVE' FROM PEDIDO ped JOIN VENTAS ven ON ven.cve_venta = ped.cve_venta JOIN PROVEEDOR prov ON prov.cve_proveedor = ped.cve_proveedor JOIN PIEZA pie ON pie.cve_pieza = ped.cve_pieza JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador LEFT OUTER JOIN FACTURA fac ON fac.cve_factura = ped.cve_factura WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND ped.pzas_devolucion != ped.cantidad", cve_siniestro, cve_pedido), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------OBTENER NUMERO DE REGISTROS EN DEVOLUCION--------------------
        public int Total_Registros()
        {
            Int32 count;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT COUNT(*) FROM DEVOLUCION", nuevaConexion);
                count = (Int32)Comando.ExecuteScalar();
                nuevaConexion.Close();
            }
            return count;
        }

        //----------------------------------------------------------------------------------------------------

        //--------------------OBTENER NUMERO DE REGISTROS EN ENTREGA--------------------
        public int Total_Registros2()
        {
            int count = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT COUNT(*) FROM ENTREGA", nuevaConexion);
                count = (int)Comando.ExecuteScalar();
                nuevaConexion.Close();
            }

            return count;
        }

        //-------------------------------------------------------------------------------------------------------

        //--------------------REGISTRAR DEVOLUCION ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE DEVOLUCION CON FECHA--------------------
       /* public string Registrar_Devolucion(string cve_siniestro, string cve_pedido, int cve_pieza, int cve_devolucion, int cantidad, DateTime fecha, int cantidadD, int cve_venta, string motivo, decimal penalizacion, string realizo)
        {
            string mensaje = "ERROR AL HACER LA DEVOLUCIÓN";

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("INSERT INTO DEVOLUCION (fecha,cantidad,cve_pieza,cve_venta,motivo,penalizacion,realizo) VALUES(@fecha,@cantidadD,@cve_pieza,@cve_venta,@motivo,@cve_penalizacion,@realizo)", nuevaConexion);
                Comando.Parameters.Add("@fecha", SqlDbType.Date);
                Comando.Parameters.Add("@cantidadD", SqlDbType.Int);
                Comando.Parameters.Add("@cve_pieza", SqlDbType.Int);
                Comando.Parameters.Add("@cve_venta", SqlDbType.Int);
                Comando.Parameters.Add("@motivo", SqlDbType.NVarChar, 50);
                Comando.Parameters.Add("@cve_penalizacion", SqlDbType.Decimal);
                Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);
                Comando.Parameters["@fecha"].Value = fecha;
                Comando.Parameters["@cantidadD"].Value = cantidadD;
                Comando.Parameters["@cve_pieza"].Value = cve_pieza;
                Comando.Parameters["@cve_venta"].Value = cve_venta;
                Comando.Parameters["@motivo"].Value = motivo;
                Comando.Parameters["@cve_penalizacion"].Value = penalizacion;
                Comando.Parameters["@realizo"].Value = realizo;
                Comando.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE p  SET  p.cve_devolucion = {0}, p.pzas_devolucion = {1} FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{2}' AND ven.cve_pedido = '{3}' AND p.cve_pieza = {4}",cve_devolucion, cantidad, cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "DEVOLUCIÓN EXITOSA";
            }

            return mensaje;
        }*/

        //---------------------------------------------------------------------------------------------------------------
        //--------------------REGISTRAR DEVOLUCION ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE DEVOLUCION CON FECHA PIEZA POR PIEZA--------------------
        public string Registrar_Devolucion(string cve_siniestro, string cve_pedido, int cve_pieza, int cve_devolucion, int cantidad, DateTime fecha, int cantidadD, int cve_venta, string motivo, decimal penalizacion, string realizo, int cvePedidoIdentity)
        {
            string mensaje = "ERROR AL HACER LA DEVOLUCIÓN";

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("INSERT INTO DEVOLUCION (fecha,cantidad,cve_pieza,cve_venta,motivo,penalizacion,realizo,cve_pedido) VALUES(@fecha,@cantidadD,@cve_pieza,@cve_venta,@motivo,@cve_penalizacion,@realizo,@cve_pedido)", nuevaConexion);
                Comando.Parameters.Add("@fecha", SqlDbType.Date);
                Comando.Parameters.Add("@cantidadD", SqlDbType.Int);
                Comando.Parameters.Add("@cve_pieza", SqlDbType.Int);
                Comando.Parameters.Add("@cve_venta", SqlDbType.Int);
                Comando.Parameters.Add("@motivo", SqlDbType.NVarChar, 50);
                Comando.Parameters.Add("@cve_penalizacion", SqlDbType.Decimal);
                Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);
                Comando.Parameters.Add("@cve_pedido", SqlDbType.Int);
                Comando.Parameters["@fecha"].Value = fecha;
                Comando.Parameters["@cantidadD"].Value = cantidadD;
                Comando.Parameters["@cve_pieza"].Value = cve_pieza;
                Comando.Parameters["@cve_venta"].Value = cve_venta;
                Comando.Parameters["@motivo"].Value = motivo;
                Comando.Parameters["@cve_penalizacion"].Value = penalizacion;
                Comando.Parameters["@realizo"].Value = realizo;
                Comando.Parameters["@cve_pedido"].Value = cvePedidoIdentity;
                Comando.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE p  SET  p.cve_devolucion = {0}, p.pzas_devolucion = {1} FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{2}' AND ven.cve_pedido = '{3}' AND p.cve_pieza = {4} AND p.cve_pedido = {5}",cve_devolucion, cantidad, cve_siniestro, cve_pedido, cve_pieza, cvePedidoIdentity), nuevaConexion);
                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "DEVOLUCIÓN EXITOSA";
            }

            return mensaje;
        }
        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA--------------------
        /*public int Pzas_Devolucion(string cve_siniestro, string cve_pedido, int cve_pieza)
        {
            int pzas;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT p.pzas_devolucion FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND p.cve_pieza = {2}", cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                if (Comando.ExecuteScalar().ToString() == string.Empty)
                { pzas = 0; }
                else { pzas = (Int32)Comando.ExecuteScalar(); }

                nuevaConexion.Close();
            }
            return pzas;
        }*/

        //-------------------------------------------------------------------------------------------------------------------------
        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA POR PIEZA--------------------
        public int Pzas_Devolucion(string cve_siniestro, string cve_pedido, int cve_pieza, int cvePedidoIdentity)
        {
            int pzas;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT p.pzas_devolucion FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND p.cve_pieza = {2} AND p.cve_pedido = {3}", cve_siniestro, cve_pedido, cve_pieza, cvePedidoIdentity), nuevaConexion);
                if (Comando.ExecuteScalar() == null || Comando.ExecuteScalar().ToString() == string.Empty)
                { pzas = 0; }
                else { pzas = (Int32)Comando.ExecuteScalar(); }

                nuevaConexion.Close();
            }
            return pzas;
        }
        //--------------------REGISTRAR ENTREGA ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE ENTREGA CON FECHA--------------------
        /*public string Registrar_Entrega(string cve_siniestro, string cve_pedido, int cve_pieza, int cve_entrega, int cantidad, DateTime fecha, int cantidadE, int cve_venta, DateTime fecha_asigancion, string realizo)
        {
            string mensaje = "ERROR AL HACER LA ENTREGA";
            int dias_entrega = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("INSERT INTO ENTREGA (fecha,cantidad,cve_pieza,cve_venta, realizo) VALUES (@fecha,@cantidadE,@cve_pieza,@cve_venta,@realizo)", nuevaConexion);
                Comando.Parameters.Add("@fecha", SqlDbType.Date);
                Comando.Parameters.Add("@cantidadE", SqlDbType.Int);
                Comando.Parameters.Add("@cve_pieza", SqlDbType.Int);
                Comando.Parameters.Add("@cve_venta", SqlDbType.Int);
                Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                Comando.Parameters["@fecha"].Value = fecha;
                Comando.Parameters["@cantidadE"].Value = cantidadE;
                Comando.Parameters["@cve_pieza"].Value = cve_pieza;
                Comando.Parameters["@cve_venta"].Value = cve_venta;
                Comando.Parameters["@realizo"].Value = realizo;
                Comando.ExecuteNonQuery();

                //VAMOS A OBTENER LA DIFERENCIA DE DIAS ENTRE FECHA_ENTREGA Y FECHA_ASIGNACIÓN
                Comando = new SqlCommand("SELECT DATEDIFF(DAY,@fecha_asignacion, @fecha)", nuevaConexion);
                Comando.Parameters.AddWithValue("@fecha_asignacion", fecha_asigancion);
                Comando.Parameters.AddWithValue("@fecha", fecha);
                dias_entrega = Int32.Parse(Comando.ExecuteScalar().ToString()) + 1;
                //SE ACTUALIZAN LOS DATOS SIGUIENTES
                SqlCommand cmd = new SqlCommand("UPDATE p SET p.cve_entrega = @cve_entrega, p.pzas_entregadas = @pzas_entregadas, p.fecha_entrega = @fecha_entrega, p.dias_entrega = @dias_entrega FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = @cve_siniestro AND ven.cve_pedido = @cve_pedido AND cve_pieza = @cve_pieza", nuevaConexion);
                cmd.Parameters.Add("@cve_entrega", SqlDbType.Int);
                cmd.Parameters.Add("@pzas_entregadas", SqlDbType.Int);
                cmd.Parameters.Add("@fecha_entrega", SqlDbType.Date);
                cmd.Parameters.Add("@cve_siniestro", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@cve_pedido", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                cmd.Parameters.Add("@dias_entrega", SqlDbType.Int);

                cmd.Parameters["@cve_entrega"].Value = cve_entrega;
                cmd.Parameters["@pzas_entregadas"].Value = cantidad;
                cmd.Parameters["@fecha_entrega"].Value = fecha;
                cmd.Parameters["@cve_siniestro"].Value = cve_siniestro;
                cmd.Parameters["@cve_pedido"].Value = cve_pedido;
                cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                cmd.Parameters["@dias_entrega"].Value = dias_entrega;
                cmd.ExecuteNonQuery();
                //SI SE CUMPLE SE SE REGISTRA ENTREGA EN TIEMPO
                cmd = new SqlCommand("SELECT p.fecha_entrega,ven.fecha_promesa FROM PEDIDO p INNER JOIN ENTREGA ent ON p.cve_entrega = ent.cve_entrega INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE p.cve_venta = @cve_venta AND p.cve_pieza = @cve_pieza AND p.pzas_entregadas = p.cantidad AND p.fecha_entrega <= ven.fecha_promesa", nuevaConexion);
                cmd.Parameters.Add("@cve_venta", SqlDbType.Int);
                cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                cmd.Parameters["@cve_venta"].Value = cve_venta;
                cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                if (cmd.ExecuteScalar() != null)
                {
                    cmd = new SqlCommand("UPDATE PEDIDO SET entrega_enTiempo = 1 WHERE cve_venta = @cve_venta  AND cve_pieza = @cve_pieza", nuevaConexion);
                    cmd.Parameters.Add("@cve_venta", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                    cmd.Parameters["@cve_venta"].Value = cve_venta;
                    cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                    MessageBOX.SHowDialog(3, "Entregado a Tiempo!");
                }

                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "ENTREGA EXITOSA";
            }

            return mensaje;
        }*/

        //----------------------------------------------------------------------------------------------------------------------------------
        //--------------------REGISTRAR ENTREGA ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE ENTREGA CON FECHA PIEZA POR PIEZA--------------------
        public string Registrar_Entrega(string cve_siniestro, string cve_pedido, int cve_pieza, int cve_entrega, int cantidad, DateTime fecha, int cantidadE, int cve_venta, DateTime fecha_asigancion, string realizo, int cvePedidoIdentity)
        {
            string mensaje = "ERROR AL HACER LA ENTREGA";
            int dias_entrega = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("INSERT INTO ENTREGA (fecha,cantidad,cve_pieza,cve_venta, realizo, cve_pedido) VALUES (@fecha,@cantidadE,@cve_pieza,@cve_venta,@realizo,@cve_pedido)", nuevaConexion);
                Comando.Parameters.Add("@fecha", SqlDbType.Date);
                Comando.Parameters.Add("@cantidadE", SqlDbType.Int);
                Comando.Parameters.Add("@cve_pieza", SqlDbType.Int);
                Comando.Parameters.Add("@cve_venta", SqlDbType.Int);
                Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);
                Comando.Parameters.Add("@cve_pedido", SqlDbType.Int);

                Comando.Parameters["@fecha"].Value = fecha;
                Comando.Parameters["@cantidadE"].Value = cantidadE;
                Comando.Parameters["@cve_pieza"].Value = cve_pieza;
                Comando.Parameters["@cve_venta"].Value = cve_venta;
                Comando.Parameters["@realizo"].Value = realizo;
                Comando.Parameters["@cve_pedido"].Value = cvePedidoIdentity;
                Comando.ExecuteNonQuery();

                //VAMOS A OBTENER LA DIFERENCIA DE DIAS ENTRE FECHA_ENTREGA Y FECHA_ASIGNACIÓN
                Comando = new SqlCommand("SELECT DATEDIFF(DAY,@fecha_asignacion, @fecha)", nuevaConexion);
                Comando.Parameters.AddWithValue("@fecha_asignacion", fecha_asigancion);
                Comando.Parameters.AddWithValue("@fecha", fecha);
                dias_entrega = Int32.Parse(Comando.ExecuteScalar().ToString()) + 1;
                //SE ACTUALIZAN LOS DATOS SIGUIENTES
                SqlCommand cmd = new SqlCommand("UPDATE p SET p.cve_entrega = @cve_entrega, p.pzas_entregadas = @pzas_entregadas, p.fecha_entrega = @fecha_entrega, p.dias_entrega = @dias_entrega FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = @cve_siniestro AND ven.cve_pedido = @cve_pedido AND p.cve_pieza = @cve_pieza AND p.cve_pedido = @cve_pedidoIdentity", nuevaConexion);
                cmd.Parameters.Add("@cve_entrega", SqlDbType.Int);
                cmd.Parameters.Add("@pzas_entregadas", SqlDbType.Int);
                cmd.Parameters.Add("@fecha_entrega", SqlDbType.Date);
                cmd.Parameters.Add("@cve_siniestro", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@cve_pedido", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                cmd.Parameters.Add("@dias_entrega", SqlDbType.Int);
                cmd.Parameters.Add("@cve_pedidoIdentity", SqlDbType.Int);

                cmd.Parameters["@cve_entrega"].Value = cve_entrega;
                cmd.Parameters["@pzas_entregadas"].Value = cantidad;
                cmd.Parameters["@fecha_entrega"].Value = fecha;
                cmd.Parameters["@cve_siniestro"].Value = cve_siniestro;
                cmd.Parameters["@cve_pedido"].Value = cve_pedido;
                cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                cmd.Parameters["@dias_entrega"].Value = dias_entrega;
                cmd.Parameters["@cve_pedidoIdentity"].Value = cvePedidoIdentity;
                cmd.ExecuteNonQuery();
                //SI SE CUMPLE SE SE REGISTRA ENTREGA EN TIEMPO
                cmd = new SqlCommand("SELECT p.fecha_entrega,ven.fecha_promesa FROM PEDIDO p INNER JOIN ENTREGA ent ON p.cve_entrega = ent.cve_entrega INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE p.cve_venta = @cve_venta AND p.cve_pieza = @cve_pieza AND p.cve_pedido = @cve_pedido AND p.pzas_entregadas = p.cantidad AND p.fecha_entrega <= ven.fecha_promesa", nuevaConexion);
                cmd.Parameters.Add("@cve_venta", SqlDbType.Int);
                cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                cmd.Parameters.Add("@cve_pedido", SqlDbType.Int);
                cmd.Parameters["@cve_venta"].Value = cve_venta;
                cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                cmd.Parameters["@cve_pedido"].Value = cvePedidoIdentity;
                if (cmd.ExecuteScalar() != null)
                {
                    cmd = new SqlCommand("UPDATE PEDIDO SET entrega_enTiempo = 1 WHERE cve_venta = @cve_venta  AND cve_pieza = @cve_pieza AND cve_pedido = @cve_pedido", nuevaConexion);
                    cmd.Parameters.Add("@cve_venta", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_pedido", SqlDbType.Int);
                    cmd.Parameters["@cve_venta"].Value = cve_venta;
                    cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                    cmd.Parameters["@cve_pedido"].Value = cvePedidoIdentity;
                    MessageBOX.SHowDialog(3, "Entregado a Tiempo!");
                }

                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "ENTREGA EXITOSA";
            }

            return mensaje;
        }
        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA--------------------
        /*public int Pzas_Entregadas(string cve_siniestro, string cve_pedido, int cve_pieza)
        {
            int pzas;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT p.pzas_entregadas FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND p.cve_pieza = {2}", cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                if (Comando.ExecuteScalar().ToString() == string.Empty)
                { pzas = 0; }
                else { pzas = (Int32)Comando.ExecuteScalar(); }

                nuevaConexion.Close();
            }
            return pzas;
        }*/

        //----------------------------------------------------------------------------------------------------------------------
        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA POR PIEZA--------------------
        public int Pzas_Entregadas(string cve_siniestro, string cve_pedido, int cve_pieza, int cvePedidoIdentity)
        {
            int pzas;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT p.pzas_entregadas FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND p.cve_pieza = {2} AND p.cve_pedido = {3}", cve_siniestro, cve_pedido, cve_pieza, cvePedidoIdentity), nuevaConexion);
                if (Comando.ExecuteScalar() == null || Comando.ExecuteScalar().ToString() == string.Empty)
                { pzas = 0; }
                else { pzas = (Int32)Comando.ExecuteScalar(); }

                nuevaConexion.Close();
            }
            return pzas;
        }
        //--------------------OBTENER DATOS DE LA TABLA ENTREGA--------------------
        /*public DataTable Tabla_Entrega(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                //Comando = new SqlCommand(string.Format("SELECT DISTINCT  pie.nombre AS PIEZA,  ent.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, ent.fecha AS 'FECHA ENTREGA', ven.fecha_promesa AS 'FECHA PROMESA' FROM ENTREGA ent JOIN VENTAS ven ON ven.cve_venta= ent.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = ent.cve_pieza WHERE ent.cve_venta = {0}", cve_venta), nuevaConexion);
                Comando = new SqlCommand(string.Format("SELECT DISTINCT pie.nombre AS PIEZA,  ent.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, ent.fecha AS 'FECHA ENTREGA', ven.fecha_promesa AS 'FECHA PROMESA',p.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ent.realizo AS 'REALIZADA POR' FROM ENTREGA ent JOIN VENTAS ven ON ven.cve_venta= ent.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador  JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador  JOIN PIEZA  pie ON pie.cve_pieza = ent.cve_pieza  JOIN PEDIDO p ON p.cve_entrega = ent.cve_entrega WHERE ent.cve_venta = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }*/

        //---------------------------------------------------------------------------------------------------------------------
        //--------------------OBTENER DATOS DE LA TABLA ENTREGA PIEZA POR PIEZA--------------------
        public DataTable Tabla_Entrega(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                //Comando = new SqlCommand(string.Format("SELECT DISTINCT  pie.nombre AS PIEZA,  ent.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, ent.fecha AS 'FECHA ENTREGA', ven.fecha_promesa AS 'FECHA PROMESA' FROM ENTREGA ent JOIN VENTAS ven ON ven.cve_venta= ent.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = ent.cve_pieza WHERE ent.cve_venta = {0}", cve_venta), nuevaConexion);
                Comando = new SqlCommand(string.Format("SELECT  pie.nombre AS PIEZA,  ent.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, ent.fecha AS 'FECHA ENTREGA', ven.fecha_promesa AS 'FECHA PROMESA',p.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ent.realizo AS 'REALIZADA POR' FROM ENTREGA ent JOIN VENTAS ven ON ven.cve_venta= ent.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador  JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador  JOIN PIEZA  pie ON pie.cve_pieza = ent.cve_pieza  LEFT OUTER JOIN PEDIDO p ON p.cve_entrega = ent.cve_entrega WHERE ent.cve_venta = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------OBTENER DATOS DE LA TABLA DEVOLUCIÓN--------------------
        /*public DataTable Tabla_Devolucion(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT DISTINCT pie.nombre AS PIEZA,  dev.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, dev.motivo AS MOTIVO,dev.penalizacion AS 'PORCENTAJE PENALIZACIÓN (%)', dev.fecha AS FECHA, dev.realizo AS 'REALIZADA POR' FROM DEVOLUCION dev JOIN VENTAS ven ON ven.cve_venta= dev.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = dev.cve_pieza  WHERE dev.cve_venta  = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }*/
        //--------------------OBTENER DATOS DE LA TABLA DEVOLUCIÓN PIEZA POR PIEZA--------------------
        public DataTable Tabla_Devolucion(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT  pie.nombre AS PIEZA,  dev.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, dev.motivo AS MOTIVO,dev.penalizacion AS 'PORCENTAJE PENALIZACIÓN (%)', dev.fecha AS FECHA, dev.realizo AS 'REALIZADA POR' FROM DEVOLUCION dev JOIN VENTAS ven ON ven.cve_venta= dev.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = dev.cve_pieza  WHERE dev.cve_venta  = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------OBTENER DATOS DE LA TABLA PENALIZACIONES--------------------
        public DataTable Tabla_Penalizacion(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT pie.nombre AS PIEZA, pena.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, pena.motivo AS MOTIVO, pena.porcentaje AS 'PORCENTAJE PENALIZACIÓN (%)', pena.fecha AS FECHA, pena.realizo AS 'REALIZADA POR' FROM PENALIZACION pena INNER JOIN VENTAS ven ON ven.cve_venta = pena.cve_venta INNER JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN PIEZA pie ON pie.cve_pieza = pena.cve_pieza WHERE pena.cve_venta = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }

        //--------------------------------------------------------------------------------------------------

        //--------------------ACTUALIZAR FACTURA (OBTENER DATOS.)--------------------
        public DataTable Actualizar_Factura(string cve_factura)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT * FROM FACTURA WHERE cve_factura = '{0}'", cve_factura), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }

            return dt;
        }

        //-----------------------------------------------------------------------------------------------------

        //--------------------ACTUALIZAR FACTURA (UPDATE)--------------------
        public string Actualizar_Factura(string cve_factura, int cve_estado, decimal fact_sinIVA, decimal descuento, decimal fact_neto, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario, string realizo)
        {
            string mensaje = "Se Actualizo Correctamente";
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                if (archivo == null && archivo_xml == null)
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,descuento = @descuento,fact_neto = @fact_neto,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,comentario = @comentario,realizo = @realizo WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);
                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;
                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    Comando.Parameters["@descuento"].Value = descuento;
                    Comando.Parameters["@fact_neto"].Value = fact_neto;
                    Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                    Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                    Comando.Parameters["@comentario"].Value = comentario;
                    Comando.Parameters["@realizo"].Value = realizo;
                    Comando.ExecuteNonQuery();
                }
                else
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,nombre_factura = @nombre_factura,archivo = @archivo,nombre_xml = @nombre_xml,archivo_xml = @archivo_xml,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    Comando.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@archivo", SqlDbType.VarBinary);
                    Comando.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                    Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;
                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    Comando.Parameters["@descuento"].Value = descuento;
                    Comando.Parameters["@fact_neto"].Value = fact_neto;
                    Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                    Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                    Comando.Parameters["@nombre_factura"].Value = nombre_factura;
                    Comando.Parameters["@archivo"].Value = archivo;
                    Comando.Parameters["@nombre_xml"].Value = nombre_xml;
                    Comando.Parameters["@archivo_xml"].Value = archivo_xml;
                    Comando.Parameters["@comentario"].Value = comentario;
                    Comando.ExecuteNonQuery();
                }
                nuevaConexion.Close();
            }
            return mensaje;
        }

        //----------------------------------------------------------------------------------------------------------

        //--------------------ACTUALIZAR REFACTURA (UPDATE)--------------------
        public string Actualizar_Refactura(string cve_factura, int cve_estado, string cve_refactura, decimal fact_sinIVA, decimal descuento, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario, string realizo)
        {
            string mensaje = "Se Actualizo Correctamente";

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();

                if (archivo == null && archivo_xml == null)
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_refactura = @cve_refactura,cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,descuento = @descuento,fact_neto = @fact_neto,costo_refactura = @costo_refactura,fecha_refactura = @fecha_refactura,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,comentario = @comentario, realizo = @realizo WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_refactura", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;
                    Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    Comando.Parameters["@descuento"].Value = descuento;
                    Comando.Parameters["@fact_neto"].Value = fact_neto;
                    Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                    Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                    Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                    Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                    Comando.Parameters["@comentario"].Value = comentario;
                    Comando.Parameters["@realizo"].Value = realizo;
                    Comando.ExecuteNonQuery();
                }
                else
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,cve_refactura = @cve_refactura,fact_sinIVA = @fact_sinIVA,descuento = @descuento,fact_neto = @fact_neto,costo_refactura = @costo_refactura,fecha_refactura = @fecha_refactura,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,nombre_factura = @nombre_factura,archivo = @archivo,nombre_xml = @nombre_xml,archivo_xml = @archivo_xml,comentario = @comentario, realizo = @realizo WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_refactura", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    Comando.Parameters.Add("@descuento", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    Comando.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@archivo", SqlDbType.VarBinary);
                    Comando.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                    Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    Comando.Parameters.Add("@realizo", SqlDbType.NVarChar, 50);

                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;
                    Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    Comando.Parameters["@descuento"].Value = descuento;
                    Comando.Parameters["@fact_neto"].Value = fact_neto;
                    Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                    Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                    Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                    Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                    Comando.Parameters["@nombre_factura"].Value = nombre_factura;
                    Comando.Parameters["@archivo"].Value = archivo;
                    Comando.Parameters["@nombre_xml"].Value = nombre_xml;
                    Comando.Parameters["@archivo_xml"].Value = archivo_xml;
                    Comando.Parameters["@comentario"].Value = comentario;
                    Comando.Parameters["@realizo"].Value = realizo;
                    Comando.ExecuteNonQuery();
                }

                nuevaConexion.Close();
            }

            return mensaje;
        }

        //-------------------------------------------------------------------------------------------------------------------

        //----------------LLENAR TABLA TXBOX----------------------------------
        /*public void Llenartabla1(DataGridView dtgv, string cve_Siniestro, string cve_Pedido, string cve_vendedor)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 250 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA', p.realizo AS 'REALIZADA POR' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador WHERE k.nombre != '' AND ven.cve_siniestro like '%{0}%' and CAST(ven.cve_pedido AS nvarchar) like '%{1}%' and ven.cve_vendedor like '%{2}%'", cve_Siniestro, cve_Pedido, cve_vendedor), nuevacon);

                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dtgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

        //------------------------------------------------------------------------------------------------------
        //----------------LLENAR TABLA TXBOX PIEZA POR PIEZA----------------------------------
        public void Llenartabla1(DataGridView dtgv, string cve_Siniestro, string cve_Pedido, string cve_vendedor)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 250 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, vend.nombre AS 'VENDEDOR', ven.cve_vendedor AS 'CLAVE VENDEDOR', c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA',p.cve_pedido AS 'CVE', p.realizo AS 'REALIZADA POR' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN VENDEDOR vend ON ven.cve_vendedor = vend.cve_vendedor WHERE k.nombre != '' AND ven.cve_siniestro like '%{0}%' and CAST(ven.cve_pedido AS nvarchar) like '%{1}%' and ven.cve_vendedor like '%{2}%'", cve_Siniestro, cve_Pedido, cve_vendedor), nuevacon);

                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dtgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //-----------------LLENAR TABLA FECHAS-------------------------------
        /*public void Llenartabla(DataGridView dvg, string Fecha_inicio, string fecha_fin)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 250 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA', p.realizo AS 'REALIZADA POR' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON p.cve_venta = ven.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador WHERE k.nombre != '' AND fecha_asignacion between '{0}' and '{1}' order by ven.fecha_asignacion desc", Fecha_inicio, fecha_fin), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dvg.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex) { }
        }*/

        //--------------------------------------------------------------------------------------------------------
        //-----------------LLENAR TABLA FECHAS PIEZA POR PIEZA-------------------------------
        public void Llenartabla(DataGridView dvg, string Fecha_inicio, string fecha_fin)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 250 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA',p.cve_pedido AS 'CVE', p.realizo AS 'REALIZADA POR' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON p.cve_venta = ven.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador WHERE k.nombre != '' AND fecha_asignacion between '{0}' and '{1}' order by ven.fecha_asignacion desc", Fecha_inicio, fecha_fin), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dvg.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex) { }
        }
        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA--------------------
        public void Llenartabla(DataGridView dgv, string cve_Siniestro, string cve_Pedido, string nombre_pieza)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, pi.nombre AS PIEZA,  p.cantidad AS CANTIDAD, ven.cve_vendedor AS VENDEDOR, p.cve_guia 'CLAVE GUIA', o.origen AS ORIGEN, pro.nombre AS PROVEEDOR, v.nombre AS VALUADOR, c.cve_nombre AS CLIENTE, po.nombre AS PORTAL, t.nombre AS TALLER, CONVERT(varchar, ven.fecha_asignacion, 6) AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6) AS 'FECHA PROMESA',CONVERT(varchar,ent.fecha, 6)  AS 'FECHA DE ENTREGA', p.costo_neto AS 'COSTO COMPRA', cos.costo AS 'COSTO DE ENVÍO', p.precio_venta AS 'PRECIO DE VENTA', p.precio_reparacion AS 'PRECIO REPARACIÓN', ven.cve_factura AS 'FACTURA', fa.fact_sinIVA AS 'FACTURA SIN IVA', fa.fact_neto AS 'FACTURA NETO', es.estado AS 'ESTADO FACTURA', ess.estado AS 'ESTADO SINIESTRO', vh.modelo AS 'VEHICULO', vh.anio AS 'VH AÑO',ma.marca AS 'VH MARCA', s.comentario AS 'SCOMMENT' FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN ORIGEN_PIEZA o ON o.cve_origen = p.cve_origen LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza LEFT OUTER JOIN PROVEEDOR pro ON p.cve_proveedor = pro.cve_proveedor LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN PORTAL po ON po.cve_portal = p.cve_portal LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller  LEFT OUTER JOIN FACTURA fa ON fa.cve_factura = ven.cve_factura LEFT OUTER JOIN ESTADO_FACTURA es ON es.cve_estado = fa.cve_estado LEFT OUTER JOIN ENTREGA ent ON ent.cve_entrega = p.cve_entrega LEFT OUTER JOIN COSTO_ENVIO cos ON cos.cve_costoEnvio = p.costo_envio LEFT OUTER JOIN SINIESTRO s ON s.cve_siniestro = ven.cve_siniestro LEFT OUTER JOIN Estado_Siniestro ess ON ess.cve_estado = s.estado LEFT OUTER JOIN VEHICULO vh ON s.cve_vehiculo = vh.cve_vehiculo LEFT OUTER JOIN MARCA ma ON vh.cve_marca = ma.cve_marca WHERE ven.cve_pedido = '{0}' and ven.cve_siniestro = '{1}' and pi.nombre = '{2}'", cve_Pedido, cve_Siniestro, nombre_pieza), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //-----------------------------------------------------------------------------------------------------------------
        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA PIEZA POR PIEZA--------------------
        public void Llenartablaa(DataGridView dgv, string cve_Siniestro, string cve_Pedido, string nombre_pieza, int pedido)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, pi.nombre AS PIEZA,  p.cantidad AS CANTIDAD, vend.nombre AS VENDEDOR, p.cve_guia 'CLAVE GUIA', o.origen AS ORIGEN, pro.nombre AS PROVEEDOR, v.nombre AS VALUADOR, c.cve_nombre AS CLIENTE, po.nombre AS PORTAL, t.nombre AS TALLER, CONVERT(varchar, ven.fecha_asignacion, 6) AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6) AS 'FECHA PROMESA',CONVERT(varchar,ent.fecha, 6)  AS 'FECHA DE ENTREGA', p.costo_neto AS 'COSTO COMPRA', cos.costo AS 'COSTO DE ENVÍO', p.precio_venta AS 'PRECIO DE VENTA', p.precio_reparacion AS 'PRECIO REPARACIÓN', p.cve_factura AS 'FACTURA', fa.fact_sinIVA AS 'FACTURA SIN IVA', fa.fact_neto AS 'FACTURA NETO', es.estado AS 'ESTADO FACTURA', p.estado AS 'ESTADO SINIESTRO', vh.modelo AS 'VEHICULO', vh.anio AS 'VH AÑO',ma.marca AS 'VH MARCA', s.comentario AS 'SCOMMENT' FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN ORIGEN_PIEZA o ON o.cve_origen = p.cve_origen LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza LEFT OUTER JOIN PROVEEDOR pro ON p.cve_proveedor = pro.cve_proveedor LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN PORTAL po ON po.cve_portal = p.cve_portal LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller  LEFT OUTER JOIN FACTURA fa ON fa.cve_factura = p.cve_factura LEFT OUTER JOIN ESTADO_FACTURA es ON es.cve_estado = fa.cve_estado LEFT OUTER JOIN ENTREGA ent ON ent.cve_entrega = p.cve_entrega LEFT OUTER JOIN COSTO_ENVIO cos ON cos.cve_costoEnvio = p.costo_envio LEFT OUTER JOIN SINIESTRO s ON s.cve_siniestro = ven.cve_siniestro LEFT OUTER JOIN Estado_Siniestro ess ON ess.cve_estado = p.estado LEFT OUTER JOIN VEHICULO vh ON s.cve_vehiculo = vh.cve_vehiculo LEFT OUTER JOIN MARCA ma ON vh.cve_marca = ma.cve_marca LEFT OUTER JOIN VENDEDOR vend ON vend.cve_vendedor = ven.cve_vendedor WHERE ven.cve_pedido = '{0}' AND ven.cve_siniestro = '{1}' AND pi.nombre = '{2}' AND p.cve_pedido = {3}", cve_Pedido, cve_Siniestro, nombre_pieza,pedido), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA AL ESCRIBIR EN EL TEXBOX DE PEDIDO EN BUSQUEDA PIEZA POR PIEZA--------------------
        public void Llenartablaa(DataGridView dgv, string cve_Pedido)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, pi.nombre AS PIEZA,  p.cantidad AS CANTIDAD, vend.nombre AS VENDEDOR, p.cve_guia 'CLAVE GUIA', o.origen AS ORIGEN, pro.nombre AS PROVEEDOR, v.nombre AS VALUADOR, c.cve_nombre AS CLIENTE, po.nombre AS PORTAL, t.nombre AS TALLER, CONVERT(varchar, ven.fecha_asignacion, 6) AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6) AS 'FECHA PROMESA',CONVERT(varchar,ent.fecha, 6)  AS 'FECHA DE ENTREGA', p.costo_neto AS 'COSTO COMPRA', cos.costo AS 'COSTO DE ENVÍO', p.precio_venta AS 'PRECIO DE VENTA', p.precio_reparacion AS 'PRECIO REPARACIÓN', p.cve_factura AS 'FACTURA', fa.fact_sinIVA AS 'FACTURA SIN IVA', fa.fact_neto AS 'FACTURA NETO', es.estado AS 'ESTADO FACTURA', p.estado AS 'ESTADO SINIESTRO', vh.modelo AS 'VEHICULO', vh.anio AS 'VH AÑO',ma.marca AS 'VH MARCA', s.comentario AS 'SCOMMENT' FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN ORIGEN_PIEZA o ON o.cve_origen = p.cve_origen LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza LEFT OUTER JOIN PROVEEDOR pro ON p.cve_proveedor = pro.cve_proveedor LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN PORTAL po ON po.cve_portal = p.cve_portal LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller  LEFT OUTER JOIN FACTURA fa ON fa.cve_factura = p.cve_factura LEFT OUTER JOIN ESTADO_FACTURA es ON es.cve_estado = fa.cve_estado LEFT OUTER JOIN ENTREGA ent ON ent.cve_entrega = p.cve_entrega LEFT OUTER JOIN COSTO_ENVIO cos ON cos.cve_costoEnvio = p.costo_envio LEFT OUTER JOIN SINIESTRO s ON s.cve_siniestro = ven.cve_siniestro LEFT OUTER JOIN Estado_Siniestro ess ON ess.cve_estado = s.estado LEFT OUTER JOIN VEHICULO vh ON s.cve_vehiculo = vh.cve_vehiculo LEFT OUTER JOIN MARCA ma ON vh.cve_marca = ma.cve_marca LEFT OUTER JOIN VENDEDOR vend ON vend.cve_vendedor = ven.cve_vendedor WHERE ven.cve_pedido = '{0}'", cve_Pedido), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA PDF--------------------
        public void Llenartabla(DataGridView dgv, string cve_Pedido)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido,cli.cve_nombre,ta.nombre,v.nombre,veh.modelo,ven.fecha_asignacion,ven.fecha_promesa,pi.nombre,p.cantidad,p.costo_neto,pro.nombre, m.marca,veh.anio FROM pedido p LEFT OUTER JOIN ventas ven ON ven.cve_venta=p.cve_venta LEFT OUTER JOIN valuador va ON va.cve_valuador=ven.cve_valuador LEFT OUTER JOIN cliente cli ON cli.cve_valuador=va.cve_valuador  LEFT OUTER JOIN taller ta ON ta.cve_taller=ven.cve_taller LEFT OUTER JOIN vendedor v ON v.cve_vendedor=ven.cve_vendedor LEFT OUTER JOIN siniestro si ON si.cve_siniestro=ven.cve_siniestro LEFT OUTER JOIN vehiculo veh ON veh.cve_vehiculo=si.cve_vehiculo LEFT OUTER JOIN marca m ON veh.cve_marca = m.cve_marca LEFT OUTER JOIN pieza pi ON pi.cve_pieza=p.cve_pieza LEFT OUTER JOIN proveedor pro ON pro.cve_proveedor =p.cve_proveedor where ven.cve_pedido='{0}' ORDER BY p.ordenCaptura ASC", cve_Pedido), nuevacon);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //-------------------------------------------------------------------------------

        public int NumeroFilas(string cve_ped)
        {
            int fila = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    Comando = new SqlCommand(string.Format("SELECT COUNT(p.cve_pieza) FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta  LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller LEFT OUTER JOIN ENTREGA e ON p.cve_entrega = e.cve_entrega LEFT OUTER JOIN SINIESTRO si ON si.cve_siniestro=ven.cve_siniestro LEFT OUTER JOIN VEHICULO veh ON veh.cve_vehiculo=si.cve_vehiculo where ven.cve_pedido='{0}'", cve_ped), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        fila = Lector.GetInt32(0);
                    }
                    Lector.Close();
                    nuevacon.Close();
                    return fila;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return fila;
            }
        }

        //--------------------------ROL----------------------------------------------
        public int Rol(string usuario)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    Comando = new SqlCommand(string.Format("SELECT rol from USUARIOS where usuario='{0}'", usuario), nuevacon);
                    nuevacon.Open();
                    Lector = Comando.ExecuteReader();
                    Lector.Read();
                    return Lector.GetInt32(0);
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //---------------------------------------------------------------------------

        //---------------------------LLENAR DATOS EN DGV POR DEFAULT--------------------
        /*public void defaultDGV(DataGridView dgv)
        {
            //SELECT TOP 10 * FROM PEDIDO
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 250 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS 'SINIESTRO', ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA', p.realizo AS 'REALIZADA POR' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador WHERE k.nombre != '' order by ven.fecha_asignacion desc"), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

        //--------------------------------------------------------------------------------------------------------
        //---------------------------LLENAR DATOS EN DGV POR DEFAULT PIEZA POR PIEZA--------------------
        public void defaultDGV(DataGridView dgv)
        {
            //SELECT TOP 10 * FROM PEDIDO
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 250 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS 'SINIESTRO', vend.nombre AS 'VENDEDOR', ven.cve_vendedor AS 'CLAVE VENDEDOR', c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA',p.cve_pedido AS 'CVE', p.realizo AS 'REALIZADA POR' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN VENDEDOR vend ON vend.cve_vendedor = ven.cve_vendedor WHERE k.nombre != '' order by ven.fecha_asignacion desc"), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //---------------------------OBTENER CLAVE DE FACTURA-------------------
        public string Clave_Fact(string siniestro, string cve_pedido)
        {
            string cve_factura = "0";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_factura FROM VENTAS WHERE cve_siniestro = '{0}' AND cve_pedido = '{1}'", siniestro, cve_pedido), nuevaConexion);
                    if (Comando.ExecuteScalar() == null || Comando.ExecuteScalar().ToString() == string.Empty)
                    {
                        cve_factura = "0";
                    }
                    else
                    {
                        //MessageBox.Show("ENTRO :V");
                        cve_factura = Comando.ExecuteScalar().ToString();
                    }
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cve_factura;
        }

        //---------------------------OBTENER CLAVE DE REFACTURA-------------------
        public string Clave_Refact(string cve_factura)
        {
            string cve_refactura = "0";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_refactura FROM FACTURA WHERE cve_factura = '{0}'", cve_factura), nuevaConexion);
                    if (Comando.ExecuteScalar().ToString() == string.Empty || Comando.ExecuteScalar() == null)
                    {
                        cve_factura = "0";
                    }
                    else
                    {
                        cve_refactura = Comando.ExecuteScalar().ToString();
                    }
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cve_refactura;
        }
        //---------------------------OBTENER CLAVE DE FACTURA POR PIEZA-------------------
        public string Clave_Fact(string siniestro, string cve_pedido, string pieza, int cvePedidoIdentity)
        {
            string cve_factura = "0";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT p.cve_factura FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta INNER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza WHERE ven.cve_siniestro = '{0}' AND ven.cve_pedido = '{1}' AND pie.nombre = '{2}' AND p.cve_pedido = {3}", siniestro, cve_pedido,pieza, cvePedidoIdentity), nuevaConexion);
                    if (Comando.ExecuteScalar() == null || Comando.ExecuteScalar().ToString() == string.Empty)
                    {
                        cve_factura = "0";
                    }
                    else
                    {
                        //MessageBox.Show("ENTRO :V");
                        cve_factura = Comando.ExecuteScalar().ToString();
                    }
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cve_factura;
        }

        //---------------------------OBTENER CLAVE DE REFACTURA POR PIEZA-------------------
        /*public string Clave_Refactt(string cve_factura)
        {
            string cve_refactura = "0";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_refactura FROM FACTURA WHERE cve_factura = '{0}'", cve_factura), nuevaConexion);
                    if (Comando.ExecuteScalar().ToString() == string.Empty || Comando.ExecuteScalar() == null)
                    {
                        cve_factura = "0";
                    }
                    else
                    {
                        cve_refactura = Comando.ExecuteScalar().ToString();
                    }
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cve_refactura;
        }*/
        //---------------------------OBTENER DIAS ESPERA POR CLIENTE-------------------
        public int Dias_Espera(string siniestro, string cve_pedido)
        {
            int dias_espera = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT c.dias_espera FROM VENTAS ven JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador JOIN CLIENTE c ON val.cve_valuador = c.cve_valuador WHERE ven.cve_siniestro = @cve_siniestro AND ven.cve_pedido = @cve_pedido", nuevaConexion);
                    Comando.Parameters.Add("@cve_siniestro", SqlDbType.NVarChar, 50);
                    Comando.Parameters.Add("@cve_pedido", SqlDbType.NVarChar, 50);

                    Comando.Parameters["@cve_siniestro"].Value = siniestro;
                    Comando.Parameters["@cve_pedido"].Value = cve_pedido;
                    if (Comando.ExecuteScalar() == null)
                    {
                        dias_espera = 0;
                    }
                    else
                    {
                        dias_espera = (Int32)Comando.ExecuteScalar();
                    }
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dias_espera;
        }

        //---------------------------TABLA ALERTAS--------------------
        public DataTable Alertas(DateTime fecha_sys)
        {
            dt = new DataTable();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT DISTINCT ven.cve_siniestro AS Siniestro, fact.cve_factura AS Factura, fact.fact_sinIVA AS 'Factura sin IVA ($)', fact.fact_neto AS 'Factura Neto ($)', fact.fecha_pago AS 'Fecha de Pago' FROM VENTAS ven INNER JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura WHERE DATEDIFF(DAY, @fecha_sys, fact.fecha_pago) < 7 AND fact.cve_estado = 1", nuevaConexion);
                    Comando.Parameters.Add("@fecha_sys", SqlDbType.Date);
                    Comando.Parameters["@fecha_sys"].Value = fecha_sys;
                    da = new SqlDataAdapter(Comando);
                    da.Fill(dt);
                    nuevaConexion.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return dt;
        }
        //---------------------------TABLA ALERTAS FACTURAS PENDIENTES PIEZA POR PIEZA--------------------
        public DataTable Alertass(DateTime fecha_sys)
        {
            dt = new DataTable();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT ven.cve_siniestro AS 'Siniestro',ven.cve_pedido AS 'Pedido',pie.nombre AS 'Pieza',p.cantidad AS 'Cantidad', p.cve_factura AS 'Factura', fact.fact_sinIVA AS 'Factura sin IVA ($)', fact.fact_neto AS 'Factura Neto ($)',fact.fecha_ingreso AS 'Fecha de Ingreso',fact.fecha_revision AS 'Fecha de Revisión', fact.fecha_pago AS 'Fecha de Pago', estfact.estado AS 'Estado de la Factura' FROM PEDIDO p INNER JOIN FACTURA fact ON p.cve_factura = fact.cve_factura INNER JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENTAS ven ON p.cve_venta = ven.cve_venta INNER JOIN PIEZA pie ON p.cve_pieza = pie.cve_pieza WHERE fact.cve_estado = 1", nuevaConexion);
                    Comando.Parameters.Add("@fecha_sys", SqlDbType.Date);
                    Comando.Parameters["@fecha_sys"].Value = fecha_sys;
                    da = new SqlDataAdapter(Comando);
                    da.Fill(dt);
                    nuevaConexion.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return dt;
        }
        //---------------------------TABLA ALERTAS POR PIEZA--------------------
        public DataTable Alertas()
        {
            dt = new DataTable();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT ven.cve_pedido AS 'Pedido', ven.cve_siniestro AS 'Siniestro',ven.fecha_promesa AS 'Fecha promesa',pie.nombre AS 'Pieza', p.cantidad AS 'Total de piezas', p.pzas_entregadas AS 'Piezas entregadas', p.fecha_entrega AS 'Ultima Fecha de entrega', p.entrega_enTiempo AS 'Entrega a tiempo' FROM PEDIDO p INNER JOIN VENTAS ven ON p.cve_venta = ven.cve_venta INNER JOIN PIEZA pie ON p.cve_pieza = pie.cve_pieza  WHERE p.pzas_entregadas != p.cantidad ", nuevaConexion);
                    da = new SqlDataAdapter(Comando);
                    da.Fill(dt);
                    nuevaConexion.Close();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return dt;
        }
        //OBTENER PRECIO VENTA PIEZA
        public double venta_total(string pedido, string siniestro)
        {
            double ventaTotal = 0;

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();

                //Obteniendo Total de la Venta de ese pedido con ese siniestro
                Comando = new SqlCommand("SELECT sub_total FROM VENTAS WHERE  cve_pedido = @cve_pedido AND cve_siniestro = @cve_siniestro", nuevaConexion);
                Comando.Parameters.AddWithValue("cve_pedido", pedido);
                Comando.Parameters.AddWithValue("cve_siniestro", siniestro);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    // totalCostoEnvio = double.Parse(Lector["costo"].ToString());
                    if (Lector["sub_total"].ToString() != string.Empty)
                        ventaTotal = Convert.ToDouble(Lector["sub_total"]);
                }
                Lector.Close();

                nuevaConexion.Close();
                return ventaTotal;
            }
        }
        //OBTENER PRECIO VENTA PIEZA
        public double venta_total(string pedido, string siniestro, string pieza)
        {
            double precioVenta = 0;

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();

                //Obteniendo Total de la Venta de ese pedido con ese siniestro
                Comando = new SqlCommand("SELECT p.precio_venta, pie.nombre FROM PEDIDO p INNER JOIN VENTAS ven ON p.cve_venta = ven.cve_venta INNER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro AND pie.nombre = @pieza", nuevaConexion);
                Comando.Parameters.AddWithValue("cve_pedido", pedido);
                Comando.Parameters.AddWithValue("cve_siniestro", siniestro);
                Comando.Parameters.AddWithValue("pieza",pieza);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    // totalCostoEnvio = double.Parse(Lector["costo"].ToString());
                    if (Lector["precio_venta"].ToString() != string.Empty)
                        precioVenta = Convert.ToDouble(Lector["precio_venta"]);
                }
                Lector.Close();

                nuevaConexion.Close();
                return precioVenta;
            }
        }
        //---------------------------OBTENER PIEZAS DEVUELTAS ANTES DE ENTREGA -------------------
        public int PiezasDevueltas(int cve_venta, int cve_pieza)
        {
            int PiezasDevueltas = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT SUM(cantidad) as 'PIEZAS DEVUELTAS ANTES DE ENTREGA' FROM PENALIZACION WHERE cve_venta = @cve_venta AND cve_pieza = @cve_pieza", nuevaConexion);
                    Comando.Parameters.AddWithValue("cve_venta", cve_venta);
                    Comando.Parameters.AddWithValue("cve_pieza", cve_pieza);

                    if (Comando.ExecuteScalar().ToString() == "" || Comando.ExecuteScalar() == null)
                    { }
                    else
                    {
                        PiezasDevueltas = Int32.Parse(Comando.ExecuteScalar().ToString());
                    }
                    nuevaConexion.Close();
                    return PiezasDevueltas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return PiezasDevueltas;
        }
        //---------------------------OBTENER PORCENTAJE DE PENALIZACIÓN DE PIEZAS DEVUELTAS ANTES DE ENTREGA -------------------
        public double PiezasDevueltasPen(int cve_venta, int cve_pieza)
        {
            double PiezasDevueltas = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT TOP 1 porcentaje FROM PENALIZACION WHERE cve_pieza = @cve_pieza AND cve_venta = @cve_venta ORDER BY cve_penalizacion DESC", nuevaConexion);
                    Comando.Parameters.AddWithValue("cve_venta", cve_venta);
                    Comando.Parameters.AddWithValue("cve_pieza", cve_pieza);
                    object pena = Comando.ExecuteScalar();
                    if (pena == null)
                    { }
                    else
                    {
                        PiezasDevueltas = Double.Parse(Comando.ExecuteScalar().ToString())/100;
                    }
                    nuevaConexion.Close();
                    return PiezasDevueltas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return PiezasDevueltas;
        }
        private string DescSAE(string modelo, string descripcion, string marca, string anio)
        {
            string clave;
            if(anio == "")
            {
                if (marca.Length < 3)
                {
                    return clave = modelo + descripcion + "-" + marca + "20";
                }
                else
                {
                    return clave = modelo + descripcion + "-" + marca.Substring(0, 3) + "20";
                }
               
            }
            else
            {
                if(marca.Length < 3)
                {
                    return clave = modelo + descripcion + "-" + marca + anio.Substring(2, 2);
                }
                else
                {
                    return clave = modelo + descripcion + "-" + marca.Substring(0, 3) + anio.Substring(2, 2);
                }
                
            }
        }
        /*public string DescSAE(string modelo, string desc, string marca, string anio)
        {
            string descSAE;

            descSAE = modelo + desc + "-" + marca.Substring(0, 3) + anio.Substring(2, 2);

            return descSAE;
        }*/
        //------------- GENERAR EXCEL
        public void generarExcel(string ruta, string fecha1, string fecha2, decimal costoOperativo)
        {
            try
            {
                int totalRegistrosExportar = 0;
                int temp = 0;
                Double tempd = 0;
                double costoAdq = 0;
                double precioV = 0;
                double utilidadAdq = 0;
                double utilidadFinal = 0;
                double gasto = 0;
                string tempSAE;
                DateTime datevalue;
                SLDocument sl = new SLDocument(ruta);
                DateTime hoy = DateTime.Today;
                sl.SetCellValue("M2", hoy.ToString("dd-MM-yyyy"));//Se agrega la fecha al excel
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    int celdaContenido = 9;
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO',  c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE SEGUIMIENTO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_comprasinIVA AS 'COSTO SIN IVA', ped.costo_neto AS 'COSTO CON IVA', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO', ven.cve_vendedor AS 'VENDEDOR', ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ent.fecha AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ven.fecha_baja AS 'FECHA DE BAJA', dev.fecha AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', dev.cantidad AS 'CANTIDAD DE PIEZAS DEVUELTAS', pen.porcentaje AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago AS 'FECHA DE PAGO FACTURA', fact.fact_sinIVA AS 'FACTURA SIN IVA', fact.fact_neto AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',ven.sub_total AS 'SUB TOTAL', ven.total AS 'TOTAL', ven.utilidad AS 'UTILIDAD BRUTA' FROM VENTAS ven FULL JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador FULL JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador FULL JOIN TALLER t ON ven.cve_taller = t.cve_taller FULL JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro FULL JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo FULL JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta FULL JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor FULL JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza FULL JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen FULL JOIN PORTAL por ON ped.cve_portal = por.cve_portal FULL JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio FULL JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion FULL JOIN PENALIZACION pen ON dev.cve_penalizacion = pen.cve_penalizacion FULL JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado WHERE ven.cve_siniestro != '' AND ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', CONVERT(varchar, ven.fecha_asignacion, 6)  AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6)  AS 'FECHA PROMESA', CONVERT(varchar, ent.fecha, 6)  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', CONVERT(varchar, ven.fecha_baja, 6)  AS 'FECHA DE BAJA', CONVERT(varchar, dev.fecha, 6)  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', CONVERT(varchar, fact.fecha_ingreso, 6)  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', CONVERT(varchar, fact.fecha_revision, 6)  AS 'FECHA DE REVISIÓN FACTURA', CONVERT(varchar, fact.fecha_pago, 6)  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', ((ped.precio_venta)-(cosen.costo + ped.costo_neto)) AS 'UTILIDAD ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',(((ped.precio_venta)-(cosen.costo + ped.costo_neto))-(@costoOperativo)-(ped.gasto)) AS 'UTILIDAD FINAL' FROM VENTAS ven FULL JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador FULL JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador FULL JOIN TALLER t ON ven.cve_taller = t.cve_taller FULL JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro FULL JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo FULL JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta FULL JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor FULL JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza FULL JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen FULL JOIN PORTAL por ON ped.cve_portal = por.cve_portal FULL JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio FULL JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion  FULL JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado FULL JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor FULL JOIN MARCA marca ON vh.cve_marca = marca.cve_marca WHERE ven.cve_siniestro != '' AND ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', CONVERT(varchar, ven.fecha_asignacion, 6)  AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6)  AS 'FECHA PROMESA', CONVERT(varchar, ent.fecha, 6)  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', CONVERT(varchar, ven.fecha_baja, 6)  AS 'FECHA DE BAJA', CONVERT(varchar, dev.fecha, 6)  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', CONVERT(varchar, fact.fecha_ingreso, 6)  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', CONVERT(varchar, fact.fecha_revision, 6)  AS 'FECHA DE REVISIÓN FACTURA', CONVERT(varchar, fact.fecha_pago, 6)  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', ((ped.precio_venta)-(cosen.costo + ped.costo_neto)) AS 'UTILIDAD ADQUISICION', (350) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',(((ped.precio_venta)-(cosen.costo + ped.costo_neto))-(350)-(ped.gasto)) AS 'UTILIDAD FINAL' FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_venta = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ven.cve_factura = fact.cve_refactura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion); ESTE ES EL BUENO ANTES
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', CONVERT(varchar,ven.fecha_asignacion,3)  AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar,ven.fecha_promesa,3)  AS 'FECHA PROMESA', CONVERT(varchar,ent.fecha,3)  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', CONVERT(varchar,ven.fecha_baja,3)  AS 'FECHA DE BAJA', CONVERT(varchar,dev.fecha,3)  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', CONVERT(varchar,fact.fecha_ingreso,3)  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', CONVERT(varchar,fact.fecha_revision,3)  AS 'FECHA DE REVISIÓN FACTURA', CONVERT(varchar,fact.fecha_pago,3)  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', ((ped.precio_venta)-(cosen.costo + ped.costo_neto)) AS 'UTILIDAD ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',(((ped.precio_venta)-(cosen.costo + ped.costo_neto))-(@costoOperativo)-(ped.gasto)) AS 'UTILIDAD FINAL',ven.cve_venta,pie.cve_pieza,pie.descSAE FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_venta = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);//EL CHIDO SIN ERRORES 08/07/2020
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', ven.fecha_asignacion  AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa  AS 'FECHA PROMESA', ent.fecha  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ven.fecha_baja  AS 'FECHA DE BAJA', dev.fecha  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision  AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(ped.costo_neto) AS 'COSTO ADQUISICION', ((ped.precio_venta)-(cosen.costo + ped.costo_neto)) AS 'UTILIDAD ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',(((ped.precio_venta)-(cosen.costo + ped.costo_neto))-(@costoOperativo)-(ped.gasto)) AS 'UTILIDAD FINAL',ven.cve_venta,pie.cve_pieza FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_venta = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);//REVISANDO
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', ven.fecha_asignacion  AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa  AS 'FECHA PROMESA', ent.fecha  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ven.fecha_baja  AS 'FECHA DE BAJA', dev.fecha  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision  AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', ((ped.precio_venta)-(cosen.costo + ped.costo_neto)) AS 'UTILIDAD ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',(((ped.precio_venta)-(cosen.costo + ped.costo_neto))-(@costoOperativo)-(ped.gasto)) AS 'UTILIDAD FINAL',ven.cve_venta,pie.cve_pieza FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_venta = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);//FUNCIONAL 23/07/2020
                    Comando = new SqlCommand("SELECT Count(ven.cve_venta) AS 'TOTAL DE REGISTROS A EXPORTAR' FROM VENTAS ven  INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta  WHERE ven.fecha_asignacion BETWEEN @fecha1 AND @fecha2",nuevaConexion);
                    Comando.Parameters.AddWithValue("@fecha1", fecha1);
                    Comando.Parameters.AddWithValue("@fecha2", fecha2);
                    totalRegistrosExportar = Int32.Parse(Comando.ExecuteScalar().ToString());
                    MessageBox.Show("El número de registros encontrados son: " + totalRegistrosExportar.ToString() +"\n"+ "Antes de dar clic en Aceptar revisa que tu conexión a internet sea estable, para evitar error a la hora de generar", "Generar Reporte",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //ESTE COMANDO FUNCIONA EN LA VERSIÓN 1.1.6 ANTES DE CAMBIAR A PIEZA POR PIEZAComando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', ven.fecha_asignacion  AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa  AS 'FECHA PROMESA', ent.fecha  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ven.fecha_baja  AS 'FECHA DE BAJA', dev.fecha  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision  AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',ven.cve_venta,pie.cve_pieza FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2 ORDER BY ven.fecha_asignacion", nuevaConexion);//REVISANDO
                    Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', ven.fecha_asignacion  AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa  AS 'FECHA PROMESA', ent.fecha  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ven.fecha_baja  AS 'FECHA DE BAJA', dev.fecha  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ped.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision  AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',ven.cve_venta,pie.cve_pieza FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ped.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2 ORDER BY ven.fecha_asignacion", nuevaConexion);//PIEZA POR PIEZA
                    Comando.Parameters.AddWithValue("@fecha1", fecha1);
                    Comando.Parameters.AddWithValue("@fecha2", fecha2);
                    Comando.Parameters.AddWithValue("@costoOperativo", costoOperativo);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        tempSAE = DescSAE(Lector["VHEICULO MODELO"].ToString(), Lector["PIEZA"].ToString(), Lector["MARCA"].ToString(), Lector["AÑO"].ToString());
                        if(int.TryParse(Lector["PEDIDO"].ToString(),out temp))
                        {sl.SetCellValue("A" + celdaContenido,Int32.Parse(Lector["PEDIDO"].ToString()));}
                        else
                        {sl.SetCellValue("A" + celdaContenido, Lector["PEDIDO"].ToString());}
                        if(int.TryParse(Lector["SINIESTRO"].ToString(),out temp))
                        {sl.SetCellValue("B" + celdaContenido,Int32.Parse(Lector["SINIESTRO"].ToString()));}
                        else
                        {sl.SetCellValue("B" + celdaContenido, Lector["SINIESTRO"].ToString());}
                        sl.SetCellValue("C" + celdaContenido, Lector["CLIENTE"].ToString());
                        sl.SetCellValue("D" + celdaContenido, Lector["VALUADOR"].ToString());
                        sl.SetCellValue("E" + celdaContenido, Lector["TALLER"].ToString());
                        if (int.TryParse(Lector["VHEICULO MODELO"].ToString(), out temp))
                        { sl.SetCellValue("F" + celdaContenido,Int32.Parse(Lector["VHEICULO MODELO"].ToString())); }
                        else
                        {sl.SetCellValue("F" + celdaContenido, Lector["VHEICULO MODELO"].ToString());}
                        sl.SetCellValue("G" + celdaContenido, Lector["MARCA"].ToString());
                        if(Lector["AÑO"].ToString() == "")
                        {
                        sl.SetCellValue("H" + celdaContenido, Lector["AÑO"].ToString());
                        }
                        else
                        {
                        sl.SetCellValue("H" + celdaContenido, Int32.Parse(Lector["AÑO"].ToString()));
                        }
                        sl.SetCellValue("I" + celdaContenido, Lector["PROVEEDOR"].ToString());
                        sl.SetCellValue("J" + celdaContenido, Lector["PIEZA"].ToString());
                        sl.SetCellValue("K" + celdaContenido, Lector["CLAVE PRODUCTO"].ToString());
                        sl.SetCellValue("L" + celdaContenido, tempSAE);
                        sl.SetCellValue("M" + celdaContenido, Int32.Parse(Lector["TOTAL DE PIEZAS"].ToString()));
                        if(int.TryParse(Lector["GUÍA DE ENVIO"].ToString(), out temp))
                        {sl.SetCellValue("N" + celdaContenido,Int32.Parse(Lector["GUÍA DE ENVIO"].ToString()));}
                        else
                        {sl.SetCellValue("N" + celdaContenido, Lector["GUÍA DE ENVIO"].ToString());}
                        sl.SetCellValue("O" + celdaContenido, Lector["ORIGEN PIEZA"].ToString());
                        sl.SetCellValue("P" + celdaContenido, Lector["PORTAL"].ToString());
                        sl.SetCellValue("Q" + celdaContenido, Double.Parse(Lector["COSTO ENVÍO"].ToString()));
                        sl.SetCellValue("R" + celdaContenido, Double.Parse(Lector["COSTO"].ToString()));
                        if(Double.TryParse(Lector["PRECIO VENTA"].ToString(), out tempd))
                        {
                            sl.SetCellValue("S" + celdaContenido, Double.Parse(Lector["PRECIO VENTA"].ToString()));
                        }
                        else
                        {
                            sl.SetCellValue("S" + celdaContenido, 0);
                         }
                        sl.SetCellValue("T" + celdaContenido, Lector["DESTINO"].ToString());
                        sl.SetCellValue("U" + celdaContenido, Int32.Parse(Lector["NUMERO DE VENDEDOR"].ToString()));
                        sl.SetCellValue("V" + celdaContenido, Lector["VENDEDOR"].ToString());
                        if (DateTime.TryParse(Lector["FECHA DE ASIGNACIÓN"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("W" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("W" + celdaContenido, Lector["FECHA DE ASIGNACIÓN"].ToString());
                        }
                        if(DateTime.TryParse(Lector["FECHA PROMESA"].ToString(),out datevalue))
                        {
                            sl.SetCellValue("X" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("X" + celdaContenido, Lector["FECHA PROMESA"].ToString());
                        }
                        if (DateTime.TryParse(Lector["FECHA DE ENTREGA"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("Y" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("Y" + celdaContenido, Lector["FECHA DE ENTREGA"].ToString());
                        }
                        
                        sl.SetCellValue("Z" + celdaContenido, Int32.Parse(Lector["PIEZAS ENTREGADAS"].ToString()));
                        if(Lector["ENTREGA EN TIEMPO"].ToString().ToUpper() == "TRUE")
                        {
                            sl.SetCellValue("AA" + celdaContenido, "SI");
                        }
                        else
                        {
                            sl.SetCellValue("AA" + celdaContenido, Lector["ENTREGA EN TIEMPO"].ToString());
                        }
                        if (Lector["DÍAS DE ENTREGA"].ToString() == "")
                        { sl.SetCellValue("AB" + celdaContenido, ""); }
                        else
                        { sl.SetCellValue("AB" + celdaContenido, Int32.Parse(Lector["DÍAS DE ENTREGA"].ToString())); }
                        if (DateTime.TryParse(Lector["FECHA DE BAJA"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("AC" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("AC" + celdaContenido, Lector["FECHA DE BAJA"].ToString());
                        }
                        if (DateTime.TryParse(Lector["FECHA DEVOLUCIÓN"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("AD" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("AD" + celdaContenido, Lector["FECHA DEVOLUCIÓN"].ToString());
                        }
                        sl.SetCellValue("AE" + celdaContenido, Lector["MOTIVO DE DEVOLUCIÓN"].ToString());
                        sl.SetCellValue("AF" + celdaContenido, Int32.Parse(Lector["CANTIDAD DE PIEZAS DEVUELTAS"].ToString()));
                        if (Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString() == "")
                        { sl.SetCellValue("AG" + celdaContenido, ""); }
                        else
                        { sl.SetCellValue("AG" + celdaContenido, Double.Parse(Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString()) / 100); }
                        sl.SetCellValue("AH" + celdaContenido, PiezasDevueltas(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString())));
                        if(PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString())) == 0)
                        {
                            sl.SetCellValue("AI" + celdaContenido, string.Empty);
                        }
                        else
                        {
                            sl.SetCellValue("AI" + celdaContenido, PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString())));
                        }
                        if (int.TryParse(Lector["FACTURA ACTUAL"].ToString(), out temp))
                        { sl.SetCellValue("AJ" + celdaContenido, Int32.Parse(Lector["FACTURA ACTUAL"].ToString())); }
                        else
                        { sl.SetCellValue("AJ" + celdaContenido, Lector["FACTURA ACTUAL"].ToString()); }
                        if (int.TryParse(Lector["FACTURA ANTERIOR"].ToString(), out temp))
                        { sl.SetCellValue("AK" + celdaContenido, Int32.Parse(Lector["FACTURA ANTERIOR"].ToString())); }
                        else
                        { sl.SetCellValue("AK" + celdaContenido, Lector["FACTURA ANTERIOR"].ToString()); }
                        if (DateTime.TryParse(Lector["FECHA INGRESO FACTURA"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("AL" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("AL" + celdaContenido, Lector["FECHA INGRESO FACTURA"].ToString());
                        }
                        sl.SetCellValue("AM" + celdaContenido, Lector["ESTADO DE LA FACTURA"].ToString());
                        if (DateTime.TryParse(Lector["FECHA DE REVISIÓN FACTURA"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("AN" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("AN" + celdaContenido, Lector["FECHA DE REVISIÓN FACTURA"].ToString());
                        }
                        if (DateTime.TryParse(Lector["FECHA DE PAGO FACTURA"].ToString(), out datevalue))
                        {
                            sl.SetCellValue("AO" + celdaContenido, datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sl.SetCellValue("AO" + celdaContenido, Lector["FECHA DE PAGO FACTURA"].ToString());
                        }
                        if(Double.TryParse(Lector["FACTURA SIN IVA"].ToString(), out tempd))
                        {
                            sl.SetCellValue("AP" + celdaContenido, Double.Parse(Lector["FACTURA SIN IVA"].ToString()));
                        }
                        else
                         {
                            sl.SetCellValue("AP" + celdaContenido, 0);
                         }
                        if (Double.TryParse(Lector["FACTURA NETO"].ToString(), out tempd))
                        {
                        sl.SetCellValue("AQ" + celdaContenido, Double.Parse(Lector["FACTURA NETO"].ToString()));
                        }
                        else
                        {
                        sl.SetCellValue("AQ" + celdaContenido, 0);
                        }
                        sl.SetCellValue("AR" + celdaContenido, Lector["COMENTARIOS SINIESTRO"].ToString());
                        sl.SetCellValue("AS" + celdaContenido, Lector["COMENTARIOS FACTURA"].ToString());


                        /*double costoAdq = 0;
                        double precioV = 0;
                        double utilidadAdq = 0;
                        double utilidadFinal = 0;
                        double gasto = 0;*/
                        if (Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString() != "")
                        {
                            
                            double costo = Double.Parse(Lector["COSTO ADQUISICION"].ToString());
                            double penalizacion = Double.Parse(Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString())/100;//Porcentaje de penalización
                            costoAdq = (costo * penalizacion) + costo;
                            sl.SetCellValue("AT" + celdaContenido, costoAdq);
                        }
                        else if (PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString())) != 0)
                        {
                            
                            double costo = Double.Parse(Lector["COSTO ADQUISICION"].ToString());
                            double penalizacion = PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString()));//Porcentaje de penalización
                            costoAdq = (costo * penalizacion) + costo;
                            sl.SetCellValue("AT" + celdaContenido, costoAdq);
                        }
                        else
                        {
                            sl.SetCellValue("AT" + celdaContenido, Double.Parse(Lector["COSTO ADQUISICION"].ToString()));
                            costoAdq = Double.Parse(Lector["COSTO ADQUISICION"].ToString());
                        }
                        if(Double.TryParse(Lector["PRECIO VENTA"].ToString(), out tempd))
                        {
                            precioV = Double.Parse(Lector["PRECIO VENTA"].ToString());
                        }
                        else
                        {
                            precioV = 0;
                        }
                        //precioV = Double.Parse(Lector["PRECIO VENTA"].ToString());
                        utilidadAdq = precioV - costoAdq;
                        sl.SetCellValue("AU" + celdaContenido, utilidadAdq);
                        sl.SetCellValue("AV" + celdaContenido, Double.Parse(Lector["COSTO OPERATIVO"].ToString()));
                        if (Lector["GASTO"].ToString() == "")
                         {
                            sl.SetCellValue("AW" + celdaContenido, 0);
                            gasto = 0;
                         }
                        else
                        {
                            sl.SetCellValue("AW" + celdaContenido, Double.Parse(Lector["GASTO"].ToString()));
                            gasto = Double.Parse(Lector["GASTO"].ToString());
                        }
                        utilidadFinal = precioV - (costoAdq + gasto + double.Parse(costoOperativo.ToString()));
                        sl.SetCellValue("AX" + celdaContenido, utilidadFinal);
                        celdaContenido++;
                    }

                    SLStyle estiloContenido = new SLStyle();
                    /*estiloContenido.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    estiloContenido.Border.LeftBorder.Color = Color.Black;
                    estiloContenido.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    estiloContenido.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    estiloContenido.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;

                    sl.SetCellStyle("A8", "AU" + celdaContenido, estiloContenido);*/
                    //estiloContenido.FormatCode = "#,###.00 $";
                    estiloContenido.FormatCode = "$ #,###.00";
                    sl.SetCellStyle("Q9", "S9" + celdaContenido, estiloContenido);
                    sl.SetCellStyle("AP9", "AQ9" + celdaContenido, estiloContenido);
                    sl.SetCellStyle("AT9", "AX9" + celdaContenido, estiloContenido);
                    estiloContenido.FormatCode = "0.00%";
                    sl.SetCellStyle("AG9", "AG9" + celdaContenido, estiloContenido);
                    sl.SetCellStyle("AI9", "AI9" + celdaContenido, estiloContenido);
                    /*estiloContenido.FormatCode = "d mmm yyyy";
                    sl.SetCellStyle("V9", estiloContenido);*/
                    sl.AutoFitColumn("A", "AX");

                    SaveFileDialog guarda = new SaveFileDialog();
                    guarda.Filter = "Libro de Excel|*.xlsx";
                    guarda.Title = "Guardar Reporte";
                    guarda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (guarda.ShowDialog() == DialogResult.OK)
                    {
                        sl.SaveAs(guarda.FileName);
                        MessageBOX.SHowDialog(1, "Archivo Guardado");
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error al generar el reporte: " + EX.Message);
            }
        }
        //--------------------LLENAR DATAGRID BUSCAR TALLERES--------------------
        public DataTable buscarTalleres(string taller)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT TOP 250 nombre AS 'NOMBRE', direccion AS 'DIRECCIÓN', ciudad AS 'CIUDAD', telefono AS 'TELÉFONO', contacto AS 'CONTACTO', horario AS 'HORARIO', estado AS 'ESTADO' FROM TALLER WHERE nombre like '%{0}%'",taller), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR TALLERES--------------------
        public DataTable buscarTalleres()
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT TOP 250 nombre AS 'NOMBRE', direccion AS 'DIRECCIÓN', ciudad AS 'CIUDAD', telefono AS 'TELÉFONO', contacto AS 'CONTACTO', horario AS 'HORARIO', estado AS 'ESTADO' FROM TALLER", nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS--------------------
        public DataTable buscarFacturas()
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT TOP 250 fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO', fact.fact_sinIVA AS 'FACTURA SIN IVA',fact.descuento AS 'DESCUENTO',fact.fact_neto AS 'FACTURA NETO', fact.costo_refactura AS 'COSTO DE REFACTURA', fact.fecha_refactura AS 'FECHA DE REFACTURA',fact.fecha_ingreso AS 'FECHA DE INGRESO', fact.fecha_revision AS 'FECHA DE REVISIÓN',fact.fecha_pago AS 'FECHA DE PAGO', fact.comentario AS 'COMENTARIO', fact.cve_refactura AS 'FACTURA ASOCIADA', fact.realizo AS 'REALIZADA POR' FROM FACTURA fact LEFT OUTER JOIN VENTAS ven ON fact.cve_factura = ven.cve_factura", nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS PIEZA POR PIEZA--------------------
        public DataTable buscarFacturass()
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT TOP 250 fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO',pie.nombre AS 'PIEZA', p.cantidad AS 'CANTIDAD', fact.fact_sinIVA AS 'FACTURA SIN IVA',fact.descuento AS 'DESCUENTO',fact.fact_neto AS 'FACTURA NETO', fact.costo_refactura AS 'COSTO DE REFACTURA', fact.fecha_refactura AS 'FECHA DE REFACTURA',fact.fecha_ingreso AS 'FECHA DE INGRESO', fact.fecha_revision AS 'FECHA DE REVISIÓN',fact.fecha_pago AS 'FECHA DE PAGO', fact.comentario AS 'COMENTARIO',estfact.estado AS 'ESTADO DE LA FACTURA', fact.cve_refactura AS 'FACTURA ASOCIADA', fact.realizo AS 'REALIZADA POR', p.cve_pedido AS 'CVE' FROM FACTURA fact LEFT OUTER JOIN PEDIDO p ON p.cve_factura = fact.cve_factura LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza LEFT OUTER JOIN ESTADO_FACTURA estfact ON estfact.cve_estado = fact.cve_estado", nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS CON TEXBOX--------------------
        public DataTable buscarFacturas(string cve_factura)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT TOP 250 fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO', fact.fact_sinIVA AS 'FACTURA SIN IVA',fact.descuento AS 'DESCUENTO',fact.fact_neto AS 'FACTURA NETO', fact.costo_refactura AS 'COSTO DE REFACTURA', fact.fecha_refactura AS 'FECHA DE REFACTURA',fact.fecha_ingreso AS 'FECHA DE INGRESO', fact.fecha_revision AS 'FECHA DE REVISIÓN',fact.fecha_pago AS 'FECHA DE PAGO', fact.comentario AS 'COMENTARIO', fact.cve_refactura AS 'FACTURA ASOCIADA', fact.realizo AS 'REALIZADA POR' FROM FACTURA fact LEFT OUTER JOIN VENTAS ven ON fact.cve_factura = ven.cve_factura WHERE fact.cve_factura like '%{0}%'", cve_factura), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS CON TEXBOX PIEZA POR PIEZA--------------------
        public DataTable buscarFacturass(string cve_factura)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT TOP 250 fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO',pie.nombre AS 'PIEZA', p.cantidad AS 'CANTIDAD', fact.fact_sinIVA AS 'FACTURA SIN IVA',fact.descuento AS 'DESCUENTO',fact.fact_neto AS 'FACTURA NETO', fact.costo_refactura AS 'COSTO DE REFACTURA', fact.fecha_refactura AS 'FECHA DE REFACTURA',fact.fecha_ingreso AS 'FECHA DE INGRESO', fact.fecha_revision AS 'FECHA DE REVISIÓN',fact.fecha_pago AS 'FECHA DE PAGO', fact.comentario AS 'COMENTARIO',estfact.estado AS 'ESTADO DE LA FACTURA', fact.cve_refactura AS 'FACTURA ASOCIADA', fact.realizo AS 'REALIZADA POR', p.cve_pedido AS 'CVE' FROM FACTURA fact LEFT OUTER JOIN PEDIDO p ON p.cve_factura = fact.cve_factura LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza LEFT OUTER JOIN ESTADO_FACTURA estfact ON estfact.cve_estado = fact.cve_estado WHERE fact.cve_factura like '%{0}%'", cve_factura), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS CON FECHAS--------------------
        public DataTable buscarFacturas(string Fecha_inicio, string fecha_fin)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT TOP 250 fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO', fact.fact_sinIVA AS 'FACTURA SIN IVA',fact.descuento AS 'DESCUENTO',fact.fact_neto AS 'FACTURA NETO', fact.costo_refactura AS 'COSTO DE REFACTURA', fact.fecha_refactura AS 'FECHA DE REFACTURA',fact.fecha_ingreso AS 'FECHA DE INGRESO', fact.fecha_revision AS 'FECHA DE REVISIÓN',fact.fecha_pago AS 'FECHA DE PAGO', fact.comentario AS 'COMENTARIO', fact.cve_refactura AS 'FACTURA ASOCIADA', fact.realizo AS 'REALIZADA POR' FROM FACTURA fact LEFT OUTER JOIN VENTAS ven ON fact.cve_factura = ven.cve_factura WHERE fact.fecha_ingreso BETWEEN '{0}' AND '{1}' ORDER BY fact.fecha_ingreso DESC", Fecha_inicio, fecha_fin), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS CON FECHAS PIEZA POR PIEZA--------------------
        public DataTable buscarFacturass(string Fecha_inicio, string fecha_fin)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT TOP 250 fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO',pie.nombre AS 'PIEZA', p.cantidad AS 'CANTIDAD', fact.fact_sinIVA AS 'FACTURA SIN IVA',fact.descuento AS 'DESCUENTO',fact.fact_neto AS 'FACTURA NETO', fact.costo_refactura AS 'COSTO DE REFACTURA', fact.fecha_refactura AS 'FECHA DE REFACTURA',fact.fecha_ingreso AS 'FECHA DE INGRESO', fact.fecha_revision AS 'FECHA DE REVISIÓN',fact.fecha_pago AS 'FECHA DE PAGO', fact.comentario AS 'COMENTARIO',estfact.estado AS 'ESTADO DE LA FACTURA', fact.cve_refactura AS 'FACTURA ASOCIADA', fact.realizo AS 'REALIZADA POR', p.cve_pedido AS 'CVE' FROM FACTURA fact LEFT OUTER JOIN PEDIDO p ON p.cve_factura = fact.cve_factura LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA pie ON pie.cve_pieza = p.cve_pieza LEFT OUTER JOIN ESTADO_FACTURA estfact ON estfact.cve_estado = fact.cve_estado WHERE fact.fecha_ingreso BETWEEN '{0}' AND '{1}' ORDER BY fact.fecha_ingreso DESC", Fecha_inicio, fecha_fin), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //---------------- USUARIOS REGISTRADOS
        public DataSet UsuariosRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM USUARIOS", nuevaConexion);
                    dataAdapter.Fill(dataSet);

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- ROLES REGISTRADOS
        public DataSet RolesRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ROL", nuevaConexion);
                    dataAdapter.Fill(dataSet);

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- ACTUALIZAR DATOS DE PROVEEDOR
        public void ActualizarDatosProveedor(string nombre, int estado)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("UPDATE PROVEEDOR SET estado = @estado WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //---------------- ACTUALIZAR DATOS DE TALLER
        public void ActualizarDatosTaller(string nombre, int estado, string direccion)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("UPDATE TALLER SET  estado = @estado, direccion =@direccion WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@direccion", direccion);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }
        //---------------- ACTUALIZAR DATOS DE TALLER
        public void ActualizarDatosTaller(string nombre, int estado, string direccion, string ciudad, string telefono, string contacto, string horario)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("UPDATE TALLER SET  estado = @estado, direccion =@direccion, ciudad =@ciudad,telefono =@telefono, contacto =@contacto, horario =@horario WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@direccion", direccion);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@contacto", contacto);
                    Comando.Parameters.AddWithValue("@horario", horario);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }
        //---------------- VEHICULOS-REGISTRADOS
        public DataSet VehiculosRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT modelo FROM VEHICULO ", nuevaConexion);
                    dataAdapter.Fill(dataSet, "VEHICULO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- ACTUALIZAR DATOS VEHICULO
        public void ActualizarDatosVehiculo(string modelo, string marca, string anio, int estado)
        {
            int ma = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_marca FROM MARCA WHERE marca = '{0}'", marca), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    while (Lector.Read()) { ma = Int32.Parse(Lector["cve_marca"].ToString()); }
                    Lector.Close();
                    Comando = new SqlCommand("UPDATE VEHICULO SET cve_marca = @marca, anio = @anio, estado = @estado WHERE modelo = @modelo ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo);
                    Comando.Parameters.AddWithValue("@marca", ma);
                    Comando.Parameters.AddWithValue("@anio", anio);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //---------------- ACTUALIZAR DATOS PIEZA
        public void ActualizarDatosPieza(string nombre, int estado)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand("UPDATE PIEZA SET nombre = @nombre, estado = @estado WHERE nombre = @nombre ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //---------------- VENDEDORES REGISTRADOS
        public DataSet VendedoresRegistradosClaves(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_vendedor FROM VENDEDOR", nuevaConexion);
                        dataAdapter.Fill(dataSet, "VENDEDOR");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_vendedor FROM VENDEDOR", nuevaConexion);
                        dataAdapter.Fill(dataSet, "VENDEDOR");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- OBTENER NOMBRE VENDEDOR MEDIANTE CLAVE
        public string NombreVendedor(int clave)
        {
            string nombreVal = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT nombre FROM VENDEDOR WHERE cve_vendedor = @cve_vendedor", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_vendedor", clave);
                    nombreVal = Comando.ExecuteScalar() as string;
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return nombreVal;
        }

        
        //---------------- ACTUALIZAR DATOS DEL VENDEDOR MEDIANTE CLAVE
        public void ActualizarDatosVendedor(int clave, int estado)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("UPDATE VENDEDOR SET estado = @estado WHERE cve_vendedor = @cve_vendedor", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_vendedor", clave);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.ExecuteNonQuery();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //-------------OBTENER  DIRECCIÓN A PARTIR DEL NOMBRE TALLER
        public string direccionTaller(string nombre)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT direccion FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["direccion"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }
        //-------------OBTENER  CIUDAD A PARTIR DEL NOMBRE TALLER
        public string ciudadTaller(string nombre)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT ciudad FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["ciudad"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }
        //-------------OBTENER  TELEFONO A PARTIR DEL NOMBRE TALLER
        public string telefonoTaller(string nombre)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT telefono FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["telefono"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }
        //-------------OBTENER  CONTACTO A PARTIR DEL NOMBRE TALLER
        public string contactoTaller(string nombre)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT contacto FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["contacto"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }
        //-------------OBTENER  HORARIO A PARTIR DEL NOMBRE TALLER
        public string horarioTaller(string nombre)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT horario FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["horario"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }
        //---------------- ACTUALIZAR DATOS DEL PORTAL
        public void ActualizarDatosPortal(string nombre, int estado)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("UPDATE PORTAL SET estado = @estado WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.ExecuteNonQuery();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //---------------- OBTENER NOMBRE VALUADOR POR EL NOMBRE DEL CLIENTE
        public string NombreValuador(string nombre)
        {
            string nombreVal = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT val.nombre FROM CLIENTE c RIGHT OUTER JOIN VALUADOR val ON c.cve_valuador = val.cve_valuador WHERE c.cve_nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    nombreVal = Comando.ExecuteScalar() as string;
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return nombreVal;
        }

        //---------------- OBTENER DIAS DE ENTREGA POR EL NOMBRE DEL CLIENTE
        public string Dias_Espera(string nombre)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT c.dias_espera FROM CLIENTE c RIGHT OUTER JOIN VALUADOR val ON c.cve_valuador = val.cve_valuador WHERE c.cve_nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["dias_espera"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }

        //---------------- ACTUALIZAR DATOS DEL VENDEDOR MEDIANTE CLAVE
        public void ActualizarDatosCliente(string cliente, string valuador, int estado, int dias)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("UPDATE val SET val.nombre = @valuador FROM VALUADOR val INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador WHERE c.cve_nombre = @cliente", nuevaConexion);
                    Comando.Parameters.AddWithValue("@valuador", valuador);
                    Comando.Parameters.AddWithValue("@cliente", cliente);
                    Comando.ExecuteNonQuery();
                    Comando = new SqlCommand("UPDATE CLIENTE SET estado = @estado, dias_espera = @dias WHERE cve_nombre = @cliente", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cliente", cliente);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.Parameters.AddWithValue("@dias", dias);
                    Comando.ExecuteNonQuery();
                    Comando = new SqlCommand("UPDATE val SET val.estado = @estado FROM VALUADOR val INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador WHERE c.cve_nombre = @cliente", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cliente", cliente);
                    Comando.Parameters.AddWithValue("@estado", estado);
                    Comando.ExecuteNonQuery();
                    MessageBOX.SHowDialog(3, "Se actualizaron los datos correctamente");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }
        //---------------- OBTENER DESCRIPCIÓN SAE POR MEDIO DEL NOMBRE PIEZA 
        public string descSAE(string nombrePieza)
        {
            string desc = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT descSAE FROM PIEZA WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombrePieza);
                    desc = Comando.ExecuteScalar() as string;
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return desc;
        }
        //VALIDAR SI EXISTE UN MISMO REGISTRO DE USUARIO PARA EVITAR DUPLICADOS, ETC.
        public string existeUsuario(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_Administrador FROM USUARIOS WHERE usuario = @usuario", nuevaConexion);
                    Comando.Parameters.AddWithValue("@usuario", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }
        //---------------------ALEX--------------------------------------------------------------------

        //VALIDAR SI EXISTE CLAVE PEDIDO
        public string existeClavePedido(string cvePedido)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_pedido FROM VENTAS WHERE cve_pedido = @cve_pedido", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", cvePedido);

                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //--------------------OBTENER NUMERO DE VEHICULOS REGISTRADOS--------------------
        //Se ocupará al momento de poner un vehiculo por default en caso de que no haya siniestro
        public int TotalVehiculos()
        {
            int count = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT COUNT(*) FROM VEHICULO", nuevaConexion);
                count = (int)Comando.ExecuteScalar();
                nuevaConexion.Close();
            }
            return count + 1;
        }

        //VALIDAR SI EXISTE CLAVE SINIESTRO
        public string existeClaveSiniestro(string cveSiniestro)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_siniestro FROM SINIESTRO WHERE cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_siniestro", cveSiniestro);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //Se ocupará al momento de generar la clave para cuando no haya un siniestro
        public int TotalSiniestro()
        {
            int count = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT COUNT(*) FROM SINIESTRO", nuevaConexion);
                count = (int)Comando.ExecuteScalar();
                nuevaConexion.Close();
            }
            return count + 1;
        }

        //---------------- ESTADO DE SINIESTRO (llena combobox) CHECAR SI NO ALTERA OTRO FUNCIONAMIENTO!
        public DataSet EstadoSiniestro()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM ESTADO_SINIESTRO", nuevaConexion);
                    dataAdapter.Fill(dataSet, "ESTADO_SINIESTRO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- VEHICULOS-REGISTRADOS
        public DataSet VehiculosRegistrados(string marca)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT  veh.modelo FROM VEHICULO veh INNER JOIN MARCA mar ON veh.cve_marca = mar.cve_marca WHERE mar.marca = @marca", nuevaConexion);// WHERE modelo NOT LIKE 'PARTICULAR%'
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@marca", marca);
                    dataAdapter.Fill(dataSet, "VEHICULO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- MARCAS VEHICULOS REGISTRADAS
        public DataSet MarcasRegistradas(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT marca FROM MARCA", nuevaConexion);//  WHERE marca NOT LIKE 'PARTICULAR%'
                        dataAdapter.Fill(dataSet, "MARCA");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT marca FROM MARCA WHERE estado = 1", nuevaConexion);//  WHERE marca NOT LIKE 'PARTICULAR%'
                        dataAdapter.Fill(dataSet, "MARCA");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //-------------OBTENER LA CLAVE DE LA MARCA DE ACUERDO AL TEXTO
        public int claveMarca(string marca)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int clavePieza = 0;
                //Obteniendo la clave de nombre pieza
                Comando = new SqlCommand("SELECT cve_marca FROM MARCA WHERE marca = @marca", nuevaConexion);
                Comando.Parameters.AddWithValue("@marca", marca);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    clavePieza = (int)Lector["cve_marca"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return clavePieza;
            }
        }

        //------------- OBTENER MARCA EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Marca(string clavePedido, string claveSiniestro)
        {
            string marca = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT DISTINCT mar.marca FROM VENTAS ven INNER JOIN SINIESTRO sin ON ven.cve_siniestro = sin.cve_siniestro INNER JOIN VEHICULO veh ON sin.cve_vehiculo = veh.cve_vehiculo INNER JOIN MARCA mar ON veh.cve_marca = mar.cve_marca WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        marca = Lector["marca"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return marca;
        }

        //------------- OBTENER VEHICULO EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Vehiculo(string clavePedido, string claveSiniestro)
        {
            string vehiculo = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT DISTINCT veh.modelo FROM VENTAS ven INNER JOIN SINIESTRO sin ON ven.cve_siniestro = sin.cve_siniestro INNER JOIN VEHICULO veh ON sin.cve_vehiculo = veh.cve_vehiculo WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        vehiculo = Lector["modelo"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return vehiculo;
        }

        //------------- OBTENER AÑO EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Anio(string clavePedido, string claveSiniestro)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT DISTINCT veh.anio FROM VENTAS ven INNER JOIN SINIESTRO sin ON ven.cve_siniestro = sin.cve_siniestro INNER JOIN VEHICULO veh ON sin.cve_vehiculo = veh.cve_vehiculo WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["anio"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }

        //------------- OBTENER COMENTARIO EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Comentario(string claveSiniestro)
        {
            string comentario = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT comentario FROM SINIESTRO WHERE cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        comentario = Lector["comentario"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return comentario;
        }

        //-------------------- OBTENER NUMERO DE ARTÍCULOS QUE CORRESPONDEN A UN PEDIDO --------------------
        //Se ocupará de manera que se haga un ciclo al momento de actualizar el pedido y llenar el DGV
        public int totalPiezasPedido(string clavePedido, string claveSiniestro)
        {
            int count = 0;
            int cveVenta = claveVenta(clavePedido, claveSiniestro);
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT COUNT(*) FROM PEDIDO WHERE cve_venta = @cve_venta", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_venta", cveVenta);
                count = (int)Comando.ExecuteScalar();

                nuevaConexion.Close();
            }
            return count;
        }

        //---------------- LLENAR DGV CON PIEZAS DE PEDIDO EN PARTICULAR CON CLAVES PEDIDO Y SINIESTRO
        public DataTable piezasPedidoActualizar(string clavePedido, string claveSiniestro)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT pie.nombre AS Pieza, ped.cantidad AS Cantidad, ped.cve_producto AS 'Clave de producto', ped.cve_guia AS 'Número de guía', por.nombre AS Portal, ori.origen AS Origen, pro.nombre AS Proveedor, ped.fecha_costo AS 'Fecha costo', ped.costo_neto AS 'Costo neto\n($)', coen.costo AS 'Costo de envío\n($)', ped.precio_venta AS 'Precio de venta\n($)', ped.precio_reparacion AS 'Precio de reparación\n($)' FROM VENTAS ven INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN ORIGEN_PIEZA ori ON ped.cve_origen = ori.cve_origen INNER JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor INNER JOIN COSTO_ENVIO coen ON ped.costo_envio = coen.cve_costoEnvio WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro ORDER BY ped.ordenCaptura ASC", nuevaConexion);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    dataAdapter.Fill(dt);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dt;
        }

        //---------------- VENDEDORES REGISTRADOS
        public DataSet VendedoresRegistrados(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM VENDEDOR", nuevaConexion);
                        dataAdapter.Fill(dataSet, "VENDEDOR");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM VENDEDOR WHERE estado = 1", nuevaConexion);
                        dataAdapter.Fill(dataSet, "VENDEDOR");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE ASEGURADORA/CLIENTE PARA EVITAR DUPLICADOS, ETC.
        public string existeVendedor(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_vendedor FROM VENDEDOR WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- INSERTAR UN NUEVO VALUADOR
        public int registrarVendedor(int numeroVendedor, string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO VENDEDOR " + "(cve_vendedor , nombre) " + "VALUES (@cve_vendedor , @nombre) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_vendedor", numeroVendedor);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo vendedor correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nuevo vendedor");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrarvendedor: " + EX.Message);
            }
            return i;
        }

        //---------------- ASEGURADORAS/CLIENTES REGISTRADAS
        public DataSet AseguradorasRegistradas(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_nombre FROM CLIENTE", nuevaConexion);
                        dataAdapter.Fill(dataSet, "CLIENTE");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_nombre FROM CLIENTE WHERE estado = 1", nuevaConexion);
                        dataAdapter.Fill(dataSet, "CLIENTE");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO CLIENTE
        public int registrarCliente(string nombreCliente, string nombreValuador, int diasEspera)
        {
            int i = 0; int cve_valuador = 0;
            //try
            //{
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT cve_valuador FROM VALUADOR WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", nombreValuador);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    cve_valuador = (int)Lector["cve_valuador"];
                }
                Lector.Close();

                Comando = new SqlCommand("INSERT INTO CLIENTE " + "(cve_nombre, cve_valuador, dias_espera) " + "VALUES (@cve_nombre, @cve_valuador, @dias_espera) ", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_nombre", nombreCliente);
                Comando.Parameters.AddWithValue("@cve_valuador", cve_valuador);
                Comando.Parameters.AddWithValue("@dias_espera", diasEspera);

                //Para saber si la inserción se hizo correctamente
                i = Comando.ExecuteNonQuery();
                nuevaConexion.Close();
                if (i == 1)
                    MessageBOX.SHowDialog(3, "Se registró nuevo cliente correctamente");
                else
                    MessageBOX.SHowDialog(2, "Problemas al registar nuevo cliente");
                nuevaConexion.Close();
            }
            /*}
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }*/
            return i;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE ASEGURADORA/CLIENTE PARA EVITAR DUPLICADOS, ETC.
        public string existeCliente(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_nombre FROM CLIENTE WHERE cve_nombre = @cve_nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //-------------VALUADORES REGISTRADOS
        public DataSet ValuadoresRegistrados(string nombreAseguradora)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            int cveValuador = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_valuador FROM CLIENTE WHERE cve_nombre = @cve_nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_nombre", nombreAseguradora.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        cveValuador = (int)Lector["cve_valuador"];
                    }
                    Lector.Close();

                    Comando = new SqlCommand("SELECT nombre FROM VALUADOR WHERE cve_valuador = @cve_valuador", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_valuador", cveValuador);
                    dataAdapter.SelectCommand = Comando;
                    dataAdapter.Fill(dataSet, "VALUADOR");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO VALUADOR
        public int registrarValuador(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO VALUADOR " + "(nombre) " + "VALUES (@nombre) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo valuador correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nuevo valuador");

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrarvaluador: " + EX.Message);
            }
            return i;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE VALUADOR PARA EVITAR DUPLICADOS, ETC.
        public string existeValuador(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT nombre FROM VALUADOR WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- TALLERES REGISTRADOS
        public DataSet TalleresRegistrados(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM TALLER", nuevaConexion);
                        dataAdapter.Fill(dataSet, "TALLER");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM TALLER WHERE estado = 1", nuevaConexion);
                        dataAdapter.Fill(dataSet, "TALLER");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO TALLER
        public int registrarTaller(string nombre, string direccion, string ciudad, string telefono, string contacto, string horario )
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO TALLER " + "(nombre, direccion, ciudad, telefono, contacto, horario) " + "VALUES (@nombre, @direccion, @ciudad, @telefono, @contacto, @horario) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@direccion", direccion);
                    Comando.Parameters.AddWithValue("@ciudad", ciudad);
                    Comando.Parameters.AddWithValue("@telefono", telefono);
                    Comando.Parameters.AddWithValue("@contacto", contacto);
                    Comando.Parameters.AddWithValue("@horario", horario);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo taller correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nuevo taller");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrar taller: " + EX.Message);
            }
            return i;
        }
        //VALIDAR SI EXISTE UN MISMO REGISTRO DE TALLERE PARA EVITAR DUPLICADOS, ETC.
        public string existeTaller(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT nombre FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- DESTINOS REGISTRADOS
        public DataSet DestinosRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT destino FROM DESTINO", nuevaConexion);
                    dataAdapter.Fill(dataSet, "DESTINO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO DESTINO
        public int registrarDestino(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO DESTINO " + "(destino) " + "VALUES (@destino) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@destino", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo destino correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nuevo destino");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrardestino: " + EX.Message);
            }
            return i;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE DESTINOS PARA EVITAR DUPLICADOS, ETC.
        public string existeDestino(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT destino FROM DESTINO WHERE destino = @destino", nuevaConexion);
                    Comando.Parameters.AddWithValue("@destino", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- NOMBRES DE PIEZAS REGISTRADOS
        public DataSet NombrePiezasRegistrados(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PIEZA", nuevaConexion);
                        dataAdapter.Fill(dataSet, "PIEZA");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PIEZA WHERE estado = 1", nuevaConexion);
                        dataAdapter.Fill(dataSet, "PIEZA");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO NOMBRE DE PIEZA
        public int registrarPieza(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO PIEZA " + "(nombre) " + "VALUES (@nombre) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nueva pieza correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nueva pieza");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error pieza: " + EX.Message);
            }
            return i;
        }
        //---------------- INSERTAR UN NUEVO NOMBRE DE PIEZA CON DESCRIPCIÓN SAE
        public int registrarPieza(string nombre, string desc)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO PIEZA " + "(nombre,descSAE) " + "VALUES (@nombre,@desc) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);
                    Comando.Parameters.AddWithValue("@desc", desc);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nueva pieza correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nueva pieza");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error pieza: " + EX.Message);
            }
            return i;
        }
        //VALIDAR SI EXISTE UN MISMO REGISTRO DE PIEZA PARA EVITAR DUPLICADOS, ETC.
        public string existePieza(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_pieza FROM PIEZA WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- PORTALES REGISTRADOS
        public DataSet PortalesRegistrados(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PORTAL", nuevaConexion);
                        dataAdapter.Fill(dataSet, "PORTAL");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PORTAL WHERE estado = 1", nuevaConexion);
                        dataAdapter.Fill(dataSet, "PORTAL");
                    }
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO PORTAL PARA PIEZA
        public int registrarPortal(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO PORTAL " + "(nombre) " + "VALUES (@nombre) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo portal correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nueva portal");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return i;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE PORTAL PARA EVITAR DUPLICADOS, ETC.
        public string existePortal(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_portal FROM PORTAL WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- ORIGEN DE PIEZAS REGISTRADAS
        public DataSet OrigenPiezasRegistradas()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT origen FROM ORIGEN_PIEZA", nuevaConexion);
                    dataAdapter.Fill(dataSet, "ORIGEN_PIEZA");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO ORIGEN PARA PIEZA
        public int registrarOrigen(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO ORIGEN_PIEZA " + "(origen) " + "VALUES (@origen) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@origen", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo origen correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nueva origen");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error origen: " + EX.Message);
            }
            return i;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE ORIGEN PARA EVITAR DUPLICADOS, ETC.
        public string existeOrigen(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_origen FROM ORIGEN_PIEZA WHERE origen = @origen", nuevaConexion);
                    Comando.Parameters.AddWithValue("@origen", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- PROVEEDORES REGISTRADOS
        public DataSet ProveedoresRegistrados(int x)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    if (x == 0)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PROVEEDOR", nuevaConexion);
                        dataAdapter.Fill(dataSet, "PROVEEDOR");
                    }
                    else if (x == 1)
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PROVEEDOR WHERE estado = 1", nuevaConexion);
                        dataAdapter.Fill(dataSet, "PROVEEDOR");
                    }

                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- INSERTAR UN NUEVO PROVEEDOR PARA PIEZA
        public int registrarProveedor(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO PROVEEDOR " + "(nombre) " + "VALUES (@nombre) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBOX.SHowDialog(3, "Se registró nuevo proveedor correctamente");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar nueva proveedor");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error proveedor: " + EX.Message);
            }
            return i;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE PROVEEDOR PARA EVITAR DUPLICADOS, ETC.
        public string existeProveedor(string nombre)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_proveedor FROM PROVEEDOR WHERE nombre = @nombre", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //---------------- COSTO DE ENVIO REGISTRADOS
        public DataSet CostoEnvioRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT costo FROM COSTO_ENVIO", nuevaConexion);
                    dataAdapter.Fill(dataSet, "COSTO_ENVIO");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //-------------OBTENER  AÑO A PARTIR DEL VEHÍCULO
        public string anioVehiculo(string modelo)
        {
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT anio FROM VEHICULO WHERE modelo = @modelo", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["anio"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }

        //------------- OBTENER ESTADO SINIESTRO EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public int estadoSiniestroClaves(string clavePedido, string claveSiniestro, string nombrePieza, int ordenCaptrura)
        {
            int estado = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    int cveVenta = claveVenta(clavePedido, claveSiniestro);
                    int cvePieza = clavePieza(nombrePieza);

                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT estado FROM PEDIDO WHERE cve_venta = @cve_venta AND cve_pieza = @cve_pieza AND ordenCaptura = @ordenCaptura", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_venta", cveVenta);
                    Comando.Parameters.AddWithValue("@cve_pieza", cvePieza);
                    Comando.Parameters.AddWithValue("@ordenCaptura", ordenCaptrura);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        estado = Convert.ToInt32(Lector["estado"]);
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return estado;
        }

        //------------- OBTENER ASEGURADORA/CLIENTE EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Cliente(string clavePedido, string claveSiniestro)
        {
            string cliente = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //CORREGIR BUGSOTE, ESTA RARO DICE BRYAN
                    Comando = new SqlCommand("SELECT cli.cve_nombre FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE cli ON val.cve_valuador = cli.cve_valuador WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        cliente = Lector["cve_nombre"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return cliente;
        }

        //------------- OBTENER UN VALUADOR EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Valuador(string clavePedido, string claveSiniestro)
        {
            string valuador = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT val.nombre FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador WHERE ven.cve_siniestro = @cve_siniestro AND ven.cve_pedido = @cve_pedido", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        valuador = Lector["nombre"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return valuador;
        }

        //------------- OBTENER UN TALLER EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Taller(string clavePedido, string claveSiniestro)
        {
            string taller = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT tal.nombre FROM VENTAS ven INNER JOIN TALLER tal ON ven.cve_taller = tal.cve_taller WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        taller = Lector["nombre"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return taller;
        }

        //------------- OBTENER UN DESTINO EN PARTICULAR DE ACUERDO A CLAVES PEDIDO & SINIESTRO
        public string Destino(string clavePedido, string claveSiniestro)
        {
            string destino = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //cambiar a cve_destino
                    Comando = new SqlCommand("SELECT dest.destino FROM VENTAS ven INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        //cambiar a cve_destino
                        destino = Lector["destino"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return destino;
        }

        //-------------OBTENER LA FECHA DE ASIGNACION A PARTIR DE LAS CLAVES PEDIDO Y SINIESTRO
        public string fechaAsignacion(string clavePedido, string claveSiniestro)
        {
            string fechaAsignacion = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT ven.fecha_asignacion FROM PEDIDO ped INNER JOIN VENTAS ven ON ped.cve_venta = ven.cve_venta WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        fechaAsignacion = Lector["fecha_asignacion"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return fechaAsignacion;
        }

        //-------------OBTENER LA FECHA PROMESA A PARTIR DE LAS CLAVES PEDIDO Y SINIESTRO
        public string fechaPromesa(string clavePedido, string claveSiniestro)
        {
            string fechaPromesa = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT ven.fecha_promesa FROM PEDIDO ped INNER JOIN VENTAS ven ON ped.cve_venta = ven.cve_venta WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        fechaPromesa = Lector["fecha_promesa"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return fechaPromesa;
        }

        //-------------OBTENER LA FECHA BAJA A PARTIR DE LAS CLAVES PEDIDO Y SINIESTRO
        public string fechaBaja(string clavePedido, string claveSiniestro)
        {
            string fechaBaja = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT ven.fecha_baja FROM PEDIDO ped INNER JOIN VENTAS ven ON ped.cve_venta = ven.cve_venta WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        fechaBaja = Lector["fecha_baja"].ToString().Trim();
                    }
                    Lector.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return fechaBaja;
        }

        //-------------OBTENER VENDEDOR EN PARTICULAR A PARTIR DE LAS CLAVES PEDIDO Y SINIESTRO
        public string Vendedor(string clavePedido, string claveSiniestro)
        {
            string vendedor = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT vend.nombre FROM VENTAS vent INNER JOIN VENDEDOR vend ON vent.cve_vendedor = vend.cve_vendedor WHERE vent.cve_pedido = @cve_pedido AND vent.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        vendedor = Lector["nombre"].ToString().Trim();
                    }
                    Lector.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return vendedor;
        }

        //-------------INSERTAR DATOS EN VEHICULO
        public void registroVehiculo(string modelo, string anio, string marca)
        {
            int cveMarca = claveMarca(marca);
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO VEHICULO " + "(modelo, anio, cve_marca) " + "VALUES (@modelo, @anio, @cve_marca) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo);
                    Comando.Parameters.AddWithValue("@anio", anio);
                    Comando.Parameters.AddWithValue("@cve_marca", cveMarca);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        MessageBOX.SHowDialog(3, "Se registró vehículo correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error vehiculo: " + EX.Message);
            }
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE VEHÍCULO PARA EVITAR DUPLICADOS, ETC.
        public string existeVehiculo(string modelo)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_vehiculo FROM VEHICULO WHERE modelo = @modelo", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE VEHÍCULO PARA EVITAR DUPLICADOS, ETC.
        public string existeAnioVehiculo(string modelo, string anio)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT anio FROM VEHICULO WHERE modelo = @modelo AND anio = @anio", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo);
                    Comando.Parameters.AddWithValue("@anio", anio);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //-------------INSERTAR DATOS EN MARCA
        public void registroMarca(string marca)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO MARCA " + "(marca) " + "VALUES (@marca) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@marca", marca);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        MessageBOX.SHowDialog(3, "Se registró vehículo correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error marca: " + EX.Message);
            }
        }

        //VALIDAR SI EXISTE UN MISMO REGISTRO DE MARCA PARA EVITAR DUPLICADOS, ETC.
        public string existeMarca(string marca)
        {
            string resultado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_marca FROM MARCA WHERE marca = @marca", nuevaConexion);
                    Comando.Parameters.AddWithValue("@marca", marca);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //-------------INSERTAR DATOS EN ENTREGA (FECHAS)
        public void registrarFechasVentas(DateTime fechaAsignacion, DateTime fechaPromesa)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //Agregando los datos a la tabla ENTREGA
                    Comando = new SqlCommand("INSERT INTO VENTAS " + "(fecha_asignacion, fecha_promesa) " + "VALUES (@fecha_asignacion, @fecha_promesa) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@fecha_asignacion", fechaAsignacion);
                    Comando.Parameters.AddWithValue("@fecha_promesa", fechaPromesa);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //-------------INSERTAR DATOS EN SINIESTRO
        public int registrarSiniestro(string modelo, string claveSiniestro, string comentario, string anio)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    int claveVehiculo = 0;
                    int claveEstado = 0;

                    nuevaConexion.Open();
                    //Obteniendo la clave del vehículo
                    Comando = new SqlCommand("SELECT cve_vehiculo FROM VEHICULO WHERE modelo = @modelo AND anio = @anio", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo);
                    Comando.Parameters.AddWithValue("@anio", anio);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        claveVehiculo = (int)Lector["cve_vehiculo"];
                    }
                    Lector.Close();

                    //Insertando los datos en la tabla SINIESTRO
                    Comando = new SqlCommand("INSERT INTO SINIESTRO " + "(cve_siniestro, cve_vehiculo, comentario, estado) " + "VALUES (@cve_siniestro, @cve_vehiculo, @comentario, @estado) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro.Trim());
                    Comando.Parameters.AddWithValue("@cve_vehiculo", claveVehiculo);
                    Comando.Parameters.AddWithValue("@comentario", comentario.Trim());
                    Comando.Parameters.AddWithValue("@estado", claveEstado);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    { }//MessageBOX.SHowDialog(3, "Se registró siniestro correctamente.");
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar.");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error sinisestro: " + EX.Message);
            }
            return i;
        }

        //--------------- ACTUALIZAR SINIESTRO
        public int actualizarSiniestro(string modelo, string claveSiniestro, string comentario, int anio)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    int claveVehiculo = 0;
                    int claveEstado = 0;

                    nuevaConexion.Open();
                    //Obteniendo la clave del vehículo
                    Comando = new SqlCommand("SELECT cve_vehiculo FROM VEHICULO WHERE modelo = @modelo AND anio = @anio", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo.Trim());
                    Comando.Parameters.AddWithValue("@anio", anio);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        claveVehiculo = (int)Lector["cve_vehiculo"];
                    }
                    Lector.Close();

                    //Insertando los datos en la tabla SINIESTRO
                    Comando = new SqlCommand("UPDATE SINIESTRO SET comentario = @comentario WHERE cve_siniestro = @cve_siniestro AND cve_vehiculo = @cve_vehiculo", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro.Trim());
                    Comando.Parameters.AddWithValue("@cve_vehiculo", claveVehiculo);
                    Comando.Parameters.AddWithValue("@comentario", comentario.Trim());

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        //MessageBOX.SHowDialog(3, "Siniestro actualizado correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al actualizar siniestro");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error actualizando siniestro: " + EX.Message);
            }
            return i;
        }

        //-------------OBTENER LA CLAVE DE LA PIEZA DE ACUERDO AL TEXTO
        public int clavePieza(string pieza)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int clavePieza = 0;
                //Obteniendo la clave de nombre pieza
                Comando = new SqlCommand("SELECT cve_pieza FROM PIEZA WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", pieza);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    clavePieza = (int)Lector["cve_pieza"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return clavePieza;
            }
        }
        /*
        public int claveEstadoPieza(string estado)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                //Obteniendo la clave del estado
                Comando = new SqlCommand("SELECT cve_estado FROM ESTADO_SINIESTRO WHERE estado = @estado", nuevaConexion);
                Comando.Parameters.AddWithValue("@estado", estado.Trim());
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveEstado = (int)Lector["cve_estado"];
                }
                Lector.Close();
            }
        }
        */
        //-------------OBTENER LA CLAVE DEL ORIGEN DE ACUERDO AL TEXTO
        public int claveOrigen(string origen)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                //Obteniendo la clave del origen
                int claveOrigen = 0;
                Comando = new SqlCommand("SELECT cve_origen FROM ORIGEN_PIEZA WHERE origen = @origen", nuevaConexion);
                Comando.Parameters.AddWithValue("@origen", origen);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveOrigen = (int)Lector["cve_origen"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveOrigen;
            }
        }

        //-------------OBTENER LA CLAVE DEL PROVEEDOR DE ACUERDO AL TEXTO
        public int claveProveedor(string proveedor)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveProveedor = 0;
                //Obteniendo la clave del proveedor
                Comando = new SqlCommand("SELECT cve_proveedor FROM PROVEEDOR WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", proveedor);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveProveedor = (int)Lector["cve_proveedor"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveProveedor;
            }
        }

        //-------------OBTENER LA CLAVE DEL PORTAL DE ACUERDO AL TEXTO
        public int clavePortal(string portal)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int clavePortal = 0;
                //Obteniendo la clave del portal
                Comando = new SqlCommand("SELECT cve_portal FROM PORTAL WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", portal);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    clavePortal = (int)Lector["cve_portal"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return clavePortal;
            }
        }

        //-------------OBTENER LA CLAVE DEL TALLER DE ACUERDO AL TEXTO
        public int claveTaller(string taller)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveTaller = 0;
                //Obteniendo la clave del taller
                //Combobox de taller
                Comando = new SqlCommand("SELECT cve_taller FROM TALLER WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", taller);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveTaller = (int)Lector["cve_taller"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveTaller;
            }
        }

        //-------------OBTENER LA CLAVE DEL VALUADOR DE ACUERDO AL TEXTO
        public int claveValuador(string valuador)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveValuador = 0;
                //Obteniendo la clave del valuador
                //Combobox de valuador
                Comando = new SqlCommand("SELECT cve_valuador FROM VALUADOR WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", valuador);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveValuador = (int)Lector["cve_valuador"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveValuador;
            }
        }

        //-------------OBTENER LA CLAVE DEL COSTO DE ENVÍO DE ACUERDO AL TEXTO
        public int claveCostoEnvio(string costoEnvio)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveCostoEnvio = 0;
                //Obteniendo la clave del valuador
                //Combobox de costoEnvio
                Comando = new SqlCommand("SELECT cve_costoEnvio FROM COSTO_ENVIO WHERE costo = @costo", nuevaConexion);
                Comando.Parameters.AddWithValue("@costo", costoEnvio);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveCostoEnvio = (int)Lector["cve_costoEnvio"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveCostoEnvio;
            }
        }

        //-------------OBTENER LA CLAVE DE LA VENTA
        public int claveVenta(string clavePedido, string claveSiniestro)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveVenta = 0;
                //Obteniendo la clave del valuador
                //Combobox de costoEnvio
                Comando = new SqlCommand("SELECT cve_venta FROM VENTAS WHERE cve_pedido = @cve_pedido AND cve_siniestro = @cve_siniestro", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveVenta = (int)Lector["cve_venta"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveVenta;
            }
        }

        //-------------OBTENER LA CLAVE DEL PEDIDO
        public int clavePedidoNum(int cveVenta, int clavePiezaPasada, int indexDgv)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int clavePedido = 0;
                //Obteniendo la clave del valuador
                //Combobox de costoEnvio
                Comando = new SqlCommand("SELECT cve_pedido FROM PEDIDO WHERE cve_venta = @cve_venta AND cve_pieza = @cve_piezaPasada AND ordenCaptura = @indexDgv", nuevaConexion);
                Comando.Parameters.AddWithValue("@cve_venta", cveVenta);
                Comando.Parameters.AddWithValue("@cve_piezaPasada", clavePiezaPasada);
                Comando.Parameters.AddWithValue("@indexDgv", indexDgv);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    clavePedido = (int)Lector["cve_pedido"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return clavePedido;
            }
        }
        /*
        public int claveEntrega(DateTime fechaAsignacion, DateTime fechaPromesa)
        {
            int claveEntrega = Total_Registros2();
            //Devuelve la clave entre las fecha promesa y fecha asignación
            /*
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                //Obteniendo la clave del valuador
                //Combobox de pedido
                Comando = new SqlCommand("SELECT cve_entrega FROM ENTREGA WHERE fecha_asignacion = @fecha_asignacion AND fecha_promesa = @fecha_promesa", nuevaConexion);
                Comando.Parameters.AddWithValue("@fecha_asignacion", fechaAsignacion);
                Comando.Parameters.AddWithValue("@fecha_promesa", fechaPromesa);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveEntrega = (int)Lector["cve_entrega"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveEntrega;
            }
        }*/

        //-------------OBTENER LA CLAVE DEL DESTINO DE ACUERDO AL TEXTO
        public int claveDestino(string destino)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveDestino = 0;
                //Obteniendo la clave del valuador
                //Combobox de destino
                Comando = new SqlCommand("SELECT cve_destino FROM DESTINO WHERE destino = @destino", nuevaConexion);
                Comando.Parameters.AddWithValue("@destino", destino);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveDestino = (int)Lector["cve_destino"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveDestino;
            }
        }

        //-------------OBTENER LA CLAVE DEL VENDEDOR DE ACUERDO AL TEXTO
        public int claveVendedor(string vendedor)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveVendedor = 0;
                //Obteniendo la clave del valuador
                //Combobox de destino
                Comando = new SqlCommand("SELECT cve_vendedor FROM VENDEDOR WHERE nombre = @nombre", nuevaConexion);
                Comando.Parameters.AddWithValue("@nombre", vendedor);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    claveVendedor = (int)Lector["cve_vendedor"];
                }
                Lector.Close();
                nuevaConexion.Close();
                return claveVendedor;
            }
        }

        public string existeClaveVendedor(int cve)
        {
            string claveVendedor = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();

                    Comando = new SqlCommand("SELECT nombre FROM VENDEDOR WHERE cve_vendedor = @cve", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve", cve);
                    Lector = Comando.ExecuteReader();
                    Lector.Read();
                    claveVendedor = Lector.GetString(0);
                    Lector.Close();
                    nuevaConexion.Close();
                    return claveVendedor;
                }
            }
            catch (Exception e)
            {
                return claveVendedor;
            }
        }

        /*
        //Se quitará
        //-------------OBTENER EL PRECIO TOTAL DEL PEDIDO
        public double totalPrecioPedido(string pedido, string siniestro)
        {
            double totalCostoEnvio = 0;
            double precioPedido = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveDestino = 0;
                //Obteniendo Total Costo Envío
                Comando = new SqlCommand("SELECT SUM(costoEnvio.costo) AS costo FROM (SELECT DISTINCT (cve_guia), envio.costo FROM PEDIDO ped INNER JOIN COSTO_ENVIO envio ON envio.cve_costoEnvio= ped.costo_envio WHERE cve_pedido = @cve_pedido AND cve_siniestro = @cve_siniestro) AS costoEnvio", nuevaConexion);
                Comando.Parameters.AddWithValue("cve_pedido", pedido);
                Comando.Parameters.AddWithValue("cve_siniestro", siniestro);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    // totalCostoEnvio = double.Parse(Lector["costo"].ToString());
                    totalCostoEnvio = Convert.ToDouble(Lector["costo"]);
                }
                Lector.Close();
                //Obteniendo el Precio Total del Pedido
                Comando = new SqlCommand("SELECT (SUM(precio_venta * cantidad) + SUM(precio_reparacion)) AS total FROM PEDIDO WHERE cve_pedido = @cve_pedido AND cve_siniestro = @cve_siniestro", nuevaConexion);
                Comando.Parameters.AddWithValue("cve_pedido", pedido);
                Comando.Parameters.AddWithValue("cve_siniestro", siniestro);
                Lector = Comando.ExecuteReader();
                if (Lector.Read())
                {
                    //precioPedido = double.Parse(Lector["total"].ToString());
                    precioPedido = Convert.ToDouble(Lector["total"]);
                }
                Lector.Close();

                nuevaConexion.Close();
                return totalCostoEnvio + precioPedido;
            }
        }*/

        //-------------INSERTAR DATOS DE PEDIDO VENTAS
        public int registrarVenta(string clavePedido, string claveSiniestro, string taller, string vendedor, /*DateTime fechaBaja,*/ string valuador, string destino, double costoTotal, double subtotalPrecio, double totalPrecio, DateTime fechaAsignacion, DateTime fechaPromesa, double utilidad)//, double utilidad
        {
            //Variables
            int i = 0;
            int cve_taller = claveTaller(taller);
            int cve_valuador = claveValuador(valuador);
            int cve_destino = claveDestino(destino);
            int cve_vendedor = claveVendedor(vendedor);
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //Insertando los datos en la relación VENTAS
                    Comando = new SqlCommand("INSERT INTO VENTAS " + "(cve_pedido, cve_siniestro, cve_vendedor, cve_taller, cve_valuador, cve_destino, costo_total, sub_total, total, fecha_asignacion, fecha_promesa, utilidad) " +
                        "VALUES (@cve_pedido, @cve_siniestro, @cve_vendedor, @cve_taller, @cve_valuador, @cve_destino, @costo_total, @sub_total, @total, @fecha_asignacion, @fecha_promesa, @utilidad) ", nuevaConexion);//utilidad    , @utilidad
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Comando.Parameters.AddWithValue("@cve_vendedor", cve_vendedor);
                    Comando.Parameters.AddWithValue("@cve_taller", cve_taller);
                    Comando.Parameters.AddWithValue("@cve_valuador", cve_valuador);
                    //Comando.Parameters.AddWithValue("@fecha_baja", fechaBaja);
                    Comando.Parameters.AddWithValue("@cve_destino", cve_destino);
                    Comando.Parameters.AddWithValue("@costo_total", costoTotal);
                    Comando.Parameters.AddWithValue("@sub_total", subtotalPrecio);
                    Comando.Parameters.AddWithValue("@total", totalPrecio);
                    Comando.Parameters.AddWithValue("@utilidad", utilidad);
                    Comando.Parameters.AddWithValue("@fecha_asignacion", fechaAsignacion);
                    Comando.Parameters.AddWithValue("@fecha_promesa", fechaPromesa);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                       // MessageBOX.SHowDialog(3, "Se registro la venta correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registrar venta");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error venta: " + EX.Message);
            }
            return i;
        }

        //-------------ACTUALIZANDO EL REGISTRO DE VENTA
        public void actualizarVenta(string clavePedido, string claveSiniestro, string taller, string vendedor, DateTime fechaBaja, string valuador, string destino, double costoTotal, double subtotalPrecio, double totalPrecio, DateTime fechaAsignacion, DateTime fechaPromesa, double utilidad)//, double utilidad
        {
            //Variables
            int i = 0;
            int cve_taller = claveTaller(taller);
            int cve_valuador = claveValuador(valuador);
            int cve_destino = claveDestino(destino);
            int cve_vendedor = claveVendedor(vendedor);

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //Insertando los datos en la relación VENTAS
                    Comando = new SqlCommand("UPDATE VENTAS SET " + "cve_vendedor = @cve_vendedor, cve_taller = @cve_taller, cve_valuador = @cve_valuador, fecha_baja = @fecha_baja, cve_destino = @cve_destino, costo_total = @costo_total, sub_total = @sub_total, total = @total, fecha_asignacion = @fecha_asignacion, fecha_promesa = @fecha_promesa, utilidad = @utilidad " +
                        "WHERE cve_pedido = @cve_pedido AND cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Comando.Parameters.AddWithValue("@cve_vendedor", cve_vendedor);
                    Comando.Parameters.AddWithValue("@cve_taller", cve_taller);
                    Comando.Parameters.AddWithValue("@cve_valuador", cve_valuador);
                    Comando.Parameters.AddWithValue("@fecha_baja", fechaBaja);
                    Comando.Parameters.AddWithValue("@cve_destino", cve_destino);
                    Comando.Parameters.AddWithValue("@costo_total", costoTotal);
                    Comando.Parameters.AddWithValue("@sub_total", subtotalPrecio);
                    Comando.Parameters.AddWithValue("@total", totalPrecio);
                    Comando.Parameters.AddWithValue("@utilidad", utilidad);
                    Comando.Parameters.AddWithValue("@fecha_asignacion", fechaAsignacion);
                    Comando.Parameters.AddWithValue("@fecha_promesa", fechaPromesa);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        //MessageBOX.SHowDialog(3, "Venta actualizada correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al actualizar venta");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error actualizarventa: " + EX.Message);
            }
        }

        //-------------EXISTE PIEZA REGISTRADA EN PEDIDO
        public string existePiezaRegistradaPedido(string cvePedido, string cveSiniestro, string pieza)
        {
            string resultado = "";
            int cveVenta = claveVenta(cvePedido, cveSiniestro);
            int cvePieza = clavePieza(pieza);
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_venta  FROM PEDIDO WHERE cve_venta  = @cve_venta AND cve_pieza = @cve_pieza", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_venta", cveVenta);
                    Comando.Parameters.AddWithValue("@cve_pieza", cvePieza);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //------------- ELIMINAR PIEZA REGISTRADA
        public void eliminarPiezaRegistradaPedido(string cvePedido, string cveSiniestro, string pieza)
        {
            int cveVenta = claveVenta(cvePedido, cveSiniestro);
            int cvePieza = clavePieza(pieza);
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("DELETE FROM PEDIDO WHERE cve_venta  = @cve_venta AND cve_pieza = @cve_pieza", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_venta", cveVenta);
                    Comando.Parameters.AddWithValue("@cve_pieza", cvePieza);
                    int i = Comando.ExecuteNonQuery();
                    //Para saber se eliminó correctamente el registro
                    if (i == 1)
                        MessageBox.Show("Pieza eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al eliminar pieza", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //-------------EXISTE ENTREGA DE PIEZA
        public string existePiezaEntrega(string pieza, string clavePedido, string claveSiniestro)
        {
            string resultado = "";
            int cvePieza = clavePieza(pieza);
            int cveVenta = claveVenta(clavePedido, claveSiniestro);
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT cve_entrega FROM ENTREGA WHERE cve_pieza = @cve_pieza AND cve_venta = @cve_venta", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pieza", cvePieza);
                    Comando.Parameters.AddWithValue("@cve_venta", cveVenta);

                    //Para saber si en realidad existe, de lo contrario devuelve un string vacío
                    if (Comando.ExecuteScalar() == null) { }
                    else
                        resultado = Comando.ExecuteScalar().ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return resultado;
        }

        //-------------INSERTAR DATOS DE PEDIDO
        public int registrarPedido(string clavePedido, string claveSiniestro, string nombrePieza, string portal, string origen, string proveedor, string fechaCosto/*, string costoSinIVA*/, string costoNeto, string costoEnvio, string precioVenta, string precioReparacion, string claveProducto, string numeroGuia, int cantidad, string realizo, int ordenCaptura, int cveEstado)
        {
            string destino;
            //Variables
            int i = 0;
            double gasto = 0;

            

            int cve_pieza = clavePieza(nombrePieza);
            int cve_origen = claveOrigen(origen);
            int cve_proveedor = claveProveedor(proveedor);
            int cve_portal = clavePortal(portal);
            int cve_costoEnvio = claveCostoEnvio(costoEnvio);
            int cve_venta = claveVenta(clavePedido, claveSiniestro);

            //Añadir el gasto en caso de que la pieza sea usada
            if (origen == "USADA")
                gasto = 500;
            else
                gasto = 0;

            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    //Obteniendo la clave del vendedor
                    //Obtener del combobox

                    //cve_guia & cve_producto:  obtener del DGV

                    nuevaConexion.Open();
                    //Insertando los datos en la tabla PEDIDO
                    Comando = new SqlCommand("INSERT INTO PEDIDO " + "(cve_venta, cve_pieza, cantidad, cve_origen, cve_proveedor, cve_portal, cve_guia, cve_producto, fecha_costo, costo_envio, costo_neto, precio_venta, precio_reparacion, gasto, realizo, ordenCaptura, estado) " +
                        "VALUES (@cve_venta, @cve_pieza, @cantidad, @cve_origen, @cve_proveedor, @cve_portal, @cve_guia, @cve_producto, @fecha_costo, @costo_envio, @costo_neto, @precio_venta, @precio_reparacion, @gasto, @realizo, @ordenCaptura, @estado) ", nuevaConexion);//, costo_comprasinIVA    , @costo_comprasinIVA
                                                                                                                                                                                                                                              //Añadiendo los parámetros al query
                    Comando.Parameters.AddWithValue("@cve_venta", cve_venta);
                    Comando.Parameters.AddWithValue("@cve_pieza", cve_pieza);
                    Comando.Parameters.AddWithValue("@cantidad", cantidad);
                    Comando.Parameters.AddWithValue("@cve_origen", cve_origen);
                    Comando.Parameters.AddWithValue("@cve_proveedor", cve_proveedor);
                    Comando.Parameters.AddWithValue("@cve_portal", cve_portal);
                    Comando.Parameters.AddWithValue("@cve_guia", numeroGuia);
                    Comando.Parameters.AddWithValue("@cve_producto", claveProducto);
                    Comando.Parameters.AddWithValue("@fecha_costo", Convert.ToDateTime(fechaCosto));
                    //Comando.Parameters.AddWithValue("@costo_comprasinIVA", Convert.ToDecimal(costoSinIVA));
                    Comando.Parameters.AddWithValue("@costo_envio", cve_costoEnvio);//cambiar nombre de columna
                    Comando.Parameters.AddWithValue("@costo_neto", Convert.ToDecimal(costoNeto));
                    Comando.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(precioVenta));
                    Comando.Parameters.AddWithValue("@precio_reparacion", Convert.ToDecimal(precioReparacion));
                    Comando.Parameters.AddWithValue("@gasto", gasto);
                    Comando.Parameters.AddWithValue("@realizo", realizo);
                    Comando.Parameters.AddWithValue("@ordenCaptura", ordenCaptura);
                    Comando.Parameters.AddWithValue("@estado", cveEstado);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        //Se omitió esta parte, para evitar que se notificara por cada pieza
                        //MessageBOX.SHowDialog(1, "Se registró pedido correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar pedido");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error registrar pedido: " + EX.Message);
            }
            return i;
        }

        //-------------ACTUALIZAR DATOS DE PEDIDO
        public int actualizarPedido(string clavePedido, string claveSiniestro, string nombrePiezaActual, string portal, string origen, string proveedor, DateTime fechaCosto/*, string costoSinIVA*/, string costoNeto, string costoEnvio, string precioVenta, string precioReparacion, string claveProducto, string numeroGuia, int cantidad, string nombrePiezaPasada, string realizo, int ordenCaptura, int estado)
        {
            string destino;
            //Variables
            int i = 0;
            double gasto = 0;

            int cve_piezaPasada = clavePieza(nombrePiezaPasada);
            int cve_piezaActual = clavePieza(nombrePiezaActual);
            int cve_origen = claveOrigen(origen);
            int cve_proveedor = claveProveedor(proveedor);
            int cve_portal = clavePortal(portal);
            int cve_costoEnvio = claveCostoEnvio(costoEnvio);
            int cve_venta = claveVenta(clavePedido, claveSiniestro);
            int cve_pedidoNum = clavePedidoNum(cve_venta, cve_piezaPasada, ordenCaptura);

            //Añadir el gasto en caso de que la pieza sea usada
            if (origen == "USADA")
                gasto = 500;
            else
                gasto = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    //Obteniendo la clave del vendedor
                    //Obtener del combobox

                    //cve_guia & cve_producto:  obtener del DGV

                    nuevaConexion.Open();
                    //Insertando los datos en la tabla PEDIDO
                    Comando = new SqlCommand("UPDATE PEDIDO SET " + "cve_pieza = @cve_piezaActual, cantidad = @cantidad, cve_origen = @cve_origen, cve_proveedor = @cve_proveedor, cve_portal = @cve_portal, cve_guia = @cve_guia, cve_producto = @cve_producto, fecha_costo = @fecha_costo, costo_envio = @costo_envio, costo_neto = @costo_neto, precio_venta = @precio_venta, precio_reparacion = @precio_reparacion, gasto = @gasto, realizo = @realizo, ordenCaptura = @ordenCaptura, estado = @estado " +
                        "WHERE cve_venta = @cve_venta AND cve_pieza = @cve_piezaPasada AND cve_pedido = @cvePedido", nuevaConexion);//, costo_comprasinIVA    , @costo_comprasinIVA
                                                                                                        //Añadiendo los parámetros al query
                    Comando.Parameters.AddWithValue("@cve_venta", cve_venta);
                    Comando.Parameters.AddWithValue("@cve_piezaPasada", cve_piezaPasada);
                    Comando.Parameters.AddWithValue("@cve_piezaActual", cve_piezaActual);
                    Comando.Parameters.AddWithValue("@cantidad", cantidad);
                    Comando.Parameters.AddWithValue("@cve_origen", cve_origen);
                    Comando.Parameters.AddWithValue("@cve_proveedor", cve_proveedor);
                    Comando.Parameters.AddWithValue("@cve_portal", cve_portal);
                    Comando.Parameters.AddWithValue("@cve_guia", numeroGuia);
                    Comando.Parameters.AddWithValue("@cve_producto", claveProducto);
                    Comando.Parameters.AddWithValue("@fecha_costo", fechaCosto);
                    //Comando.Parameters.AddWithValue("@costo_comprasinIVA", Convert.ToDecimal(costoSinIVA));
                    Comando.Parameters.AddWithValue("@costo_envio", cve_costoEnvio);//cambiar nombre de columna
                    Comando.Parameters.AddWithValue("@costo_neto", Convert.ToDecimal(costoNeto));
                    Comando.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(precioVenta));
                    Comando.Parameters.AddWithValue("@precio_reparacion", Convert.ToDecimal(precioReparacion));
                    Comando.Parameters.AddWithValue("@gasto", gasto);
                    Comando.Parameters.AddWithValue("@realizo", realizo);
                    Comando.Parameters.AddWithValue("@ordenCaptura", ordenCaptura);
                    Comando.Parameters.AddWithValue("@cvePedido", cve_pedidoNum);
                    Comando.Parameters.AddWithValue("@estado", estado);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        //Se omitió esta parte, para evitar que se notificara por cada pieza
                        // MessageBOX.SHowDialog(1, "Se actualizó pedido correctamente");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al actualizar pedido");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error actualizar pedido: " + EX.Message);
            }
            return i;
        }

        public void registrarPenalizacion(int clavePieza, int claveVenta, int cantidad, string motivo, double porcentaje, DateTime fecha, string realizo)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO PENALIZACION " + "(cve_pieza, cve_venta, cantidad, motivo, porcentaje, fecha, realizo) " + "VALUES (@cve_pieza , @cve_venta, @cantidad, @motivo, @porcentaje, @fecha, @realizo) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pieza", clavePieza);
                    Comando.Parameters.AddWithValue("@cve_venta", claveVenta);
                    Comando.Parameters.AddWithValue("@cantidad", cantidad);
                    Comando.Parameters.AddWithValue("@motivo", motivo);
                    Comando.Parameters.AddWithValue("@porcentaje", porcentaje);
                    Comando.Parameters.AddWithValue("@fecha", fecha);
                    Comando.Parameters.AddWithValue("@realizo", realizo);

                    //Para saber si la inserción se hizo correctamente
                    int i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                    {
                        MessageBOX.SHowDialog(3, "Se registró penalización correctamente");
                        nuevaConexion.Open();
                        Comando = new SqlCommand("UPDATE PEDIDO SET cantidad = cantidad - @cantidad WHERE cve_venta = @cve_venta AND cve_pieza = @cve_pieza", nuevaConexion);
                        Comando.Parameters.AddWithValue("@cve_pieza", clavePieza);
                        Comando.Parameters.AddWithValue("@cve_venta", claveVenta);
                        Comando.Parameters.AddWithValue("@cantidad", cantidad);
                        int j = Comando.ExecuteNonQuery();
                        nuevaConexion.Close();
                        if (j != 1)
                            MessageBOX.SHowDialog(2, "Problemas al actualizar cantidad de pieza");
                    }
                    else
                        MessageBOX.SHowDialog(2, "Problemas al registar penalización");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        /*
        //SE QUITARÁ
        //CALCULAR CANTIDADES PARA AGREGAR A VENTAS
        public void totales(string clavePedido, string claveSiniestro)
        {
            try
            {
                double costoTotal = 0;
                double precioTotal = 0;
                double utilidad;
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //Obteniendo costo total del pedido
                    Comando = new SqlCommand("SELECT (SUM(p.costo_neto * p.cantidad)) AS 'Costo Total' FROM PEDIDO p INNER JOIN VENTAS ven ON p.cve_venta = ven.cve_venta WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        costoTotal = Convert.ToDouble(Lector["Costo Total"]);
                    }
                    Lector.Close();
                    MessageBox.Show(costoTotal.ToString());

                    //Obteniendo precio total del pedido
                    Comando = new SqlCommand("SELECT (SUM(p.precio_venta * p.cantidad)) AS 'Precio Total' FROM PEDIDO p INNER JOIN VENTAS ven ON p.cve_venta = ven.cve_venta WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        precioTotal = Convert.ToDouble(Lector["Precio Total"]);
                    }
                    Lector.Close();
                    MessageBox.Show(precioTotal.ToString());

                    //Obteniendo la utilidad
                    utilidad = precioTotal - costoTotal;
                    MessageBox.Show(utilidad.ToString());

                    //Insertando los datos en venta
                    Comando = new SqlCommand("INSERT INTO VENTAS " + "( costo_total, venta_total, utilidad) " +
                    "VALUES (@costo_total, @venta_total, @utilidad)", nuevaConexion);
                    Comando.Parameters.AddWithValue("@costo_total", costoTotal);
                    Comando.Parameters.AddWithValue("@venta_total", precioTotal);
                    Comando.Parameters.AddWithValue("@utilidad", utilidad);
                    Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex);
            }
        }*/
    }
}

//PROBANDO
//PROBANDO X2
//PROBANDO X3
//PROBANDO X4