using Microsoft.Win32;
using SpreadsheetLight;
using System;
using System.Collections.Generic;

//Librerias
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
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
                    this.Comando = new SqlCommand(string.Format("SELECT usuario,contrasenia FROM administrador WHERE usuario='{0}' AND dbo.fnDescifraClave(contrasenia) COLLATE SQL_Latin1_General_CP1_CS_AS = '{1}';", us, pass), nuevacon);
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

        //--------------------------------------------------------------------------------

        //--------------------INGRESAR FACTURA--------------------
        public string Registrar_factura(string cve_siniestro, string cve_pedido, int cve_factura, int cve_estado, decimal fact_sinIVA, decimal fact_neto, string fecha_ingreso, string fecha_revision, string fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
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
                        cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,comentario) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@comentario)", nuevaConexion);
                        cmd.Parameters.Add("@cve_factura", SqlDbType.Int);
                        cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                        cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                        cmd.Parameters["@cve_factura"].Value = cve_factura;
                        cmd.Parameters["@cve_estado"].Value = cve_estado;
                        cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        cmd.Parameters["@fact_neto"].Value = fact_neto;
                        cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                        cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                        cmd.Parameters["@comentario"].Value = comentario;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario)", nuevaConexion);
                        cmd.Parameters.Add("@cve_factura", SqlDbType.Int);
                        cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                        cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        cmd.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar, 100);
                        cmd.Parameters.Add("@archivo", SqlDbType.VarBinary);
                        cmd.Parameters.Add("@nombre_xml", SqlDbType.NVarChar, 100);
                        cmd.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                        cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                        cmd.Parameters["@cve_factura"].Value = cve_factura;
                        cmd.Parameters["@cve_estado"].Value = cve_estado;
                        cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        cmd.Parameters["@fact_neto"].Value = fact_neto;
                        cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                        cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                        cmd.Parameters["@nombre_factura"].Value = nombre_factura;
                        cmd.Parameters["@archivo"].Value = archivo;
                        cmd.Parameters["@nombre_xml"].Value = nombre_xml;
                        cmd.Parameters["@archivo_xml"].Value = archivo_xml;
                        cmd.Parameters["@comentario"].Value = comentario;
                        cmd.ExecuteNonQuery();
                    }
                    //MessageBox.Show(cve_siniestro.ToString());
                    //MessageBox.Show(cve_pedido.ToString());
                    comm = new SqlCommand(string.Format("UPDATE VENTAS SET cve_factura = {0} WHERE cve_siniestro = '{1}' AND cve_pedido = '{2}'", cve_factura, cve_siniestro, cve_pedido), nuevaConexion);
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
        public byte[] Buscar_factura(int cve_factura)
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
        public byte[] Buscar_factura_xml(int cve_factura)
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
        public string Nombre_Factura(int cve_factura)
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
        public string Nombre_Factura_xml(int cve_factura)
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

        //--------------------INGRESAR FACTURA--------------------
        public string Registrar_Refactura(string cve_siniestro, string cve_pedido, int cve_factura, int cve_estado, int cve_refactura, decimal fact_sinIVA, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
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
                        Comando = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,cve_refactura,fact_sinIVA,fact_neto,costo_refactura,fecha_refactura,fecha_ingreso,fecha_revision,fecha_pago,comentario) VALUES (@cve_factura,@cve_estado,@cve_refactura,@fact_sinIVA,@fact_neto,@costo_refactura,@fecha_refactura,@fecha_ingreso,@fecha_revision,@fecha_pago,@comentario)", nuevaConexion);
                        Comando.Parameters.Add("@cve_factura", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_refactura", SqlDbType.Int);
                        Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                        Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                        Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                        Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                        Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                        Comando.Parameters["@cve_factura"].Value = cve_factura;
                        Comando.Parameters["@cve_estado"].Value = cve_estado;
                        Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                        Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                        Comando.Parameters["@fact_neto"].Value = fact_neto;
                        Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                        Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                        Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                        Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                        Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                        Comando.Parameters["@comentario"].Value = comentario;
                        Comando.ExecuteNonQuery();
                    }
                    else
                    {
                        Comando = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,cve_refactura,fact_sinIVA,fact_neto,costo_refactura,fecha_refactura,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario) VALUES (@cve_factura,@cve_estado,@cve_refactura,@fact_sinIVA,@fact_neto,@costo_refactura,@fecha_refactura,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario)", nuevaConexion);
                        Comando.Parameters.Add("@cve_factura", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                        Comando.Parameters.Add("@cve_refactura", SqlDbType.Int);
                        Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
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

                        Comando.Parameters["@cve_factura"].Value = cve_factura;
                        Comando.Parameters["@cve_estado"].Value = cve_estado;
                        Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                        Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
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
                        Comando.ExecuteNonQuery();
                    }

                    comm = new SqlCommand(string.Format("UPDATE VENTAS SET cve_factura = {0} WHERE cve_siniestro = '{1}' AND cve_pedido = '{2}'", cve_factura, cve_siniestro, cve_pedido), nuevaConexion);
                    comm.ExecuteNonQuery();
                    cmd = new SqlCommand(string.Format("UPDATE FACTURA SET cve_refactura = {0} WHERE cve_factura = {1}", cve_factura, cve_refactura), nuevaConexion);
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

        //--------------------LLENAR DATAGRID DEVOLUCIÓN-ENTREGA--------------------
        public DataTable Devolucion(string cve_siniestro, string cve_pedido)
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
        }

        //---------------------------------------------------------------------------------------------------

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
        public string Registrar_Devolucion(string cve_siniestro, string cve_pedido, int cve_pieza, int cve_devolucion, int cantidad, DateTime fecha, int cantidadD, int cve_venta, string motivo, int penalizacion)
        {
            string mensaje = "ERROR AL HACER LA DEVOLUCIÓN";

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("INSERT INTO DEVOLUCION (fecha,cantidad,cve_pieza,cve_venta,motivo,cve_penalizacion) VALUES(@fecha,@cantidadD,@cve_pieza,@cve_venta,@motivo,@cve_penalizacion)", nuevaConexion);
                Comando.Parameters.Add("@fecha", SqlDbType.Date);
                Comando.Parameters.Add("@cantidadD", SqlDbType.Int);
                Comando.Parameters.Add("@cve_pieza", SqlDbType.Int);
                Comando.Parameters.Add("@cve_venta", SqlDbType.Int);
                Comando.Parameters.Add("@motivo", SqlDbType.NVarChar, 50);
                Comando.Parameters.Add("@cve_penalizacion", SqlDbType.Int);
                Comando.Parameters["@fecha"].Value = fecha;
                Comando.Parameters["@cantidadD"].Value = cantidadD;
                Comando.Parameters["@cve_pieza"].Value = cve_pieza;
                Comando.Parameters["@cve_venta"].Value = cve_venta;
                Comando.Parameters["@motivo"].Value = motivo;
                Comando.Parameters["@cve_penalizacion"].Value = penalizacion;
                Comando.ExecuteNonQuery();
                //SqlCommand cmd = new SqlCommand(string.Format("UPDATE PEDIDO SET cantidad = {0}, cve_devolucion = {1}  WHERE cve_siniestro = '{2}' AND cve_pedido = {3} AND cve_pieza = {4}",/*cantidad,*/cve_devolucion, cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE p  SET  p.cve_devolucion = {0}, p.pzas_devolucion = {1} FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = '{2}' AND ven.cve_pedido = '{3}' AND p.cve_pieza = {4}",/*cantidad,*/cve_devolucion, cantidad, cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "DEVOLUCIÓN EXITOSA";
            }

            return mensaje;
        }

        //---------------------------------------------------------------------------------------------------------------

        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA--------------------
        public int Pzas_Devolucion(string cve_siniestro, string cve_pedido, int cve_pieza)
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
        }

        //-------------------------------------------------------------------------------------------------------------------------

        //--------------------REGISTRAR ENTREGA ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE ENTREGA CON FECHA--------------------
        public string Registrar_Entrega(string cve_siniestro, string cve_pedido, int cve_pieza, int cve_entrega, int cantidad, DateTime fecha, int cantidadE, int cve_venta, DateTime fecha_asigancion)
        {
            string mensaje = "ERROR AL HACER LA ENTREGA";
            int dias_entrega = 0;
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("INSERT INTO ENTREGA (fecha,cantidad,cve_pieza,cve_venta) VALUES (@fecha,@cantidadE,@cve_pieza,@cve_venta)", nuevaConexion);
                /*Comando.Parameters.Add("@fecha_asignacion", SqlDbType.Date);
                Comando.Parameters.Add("@fecha_promesa", SqlDbType.Date);*/
                Comando.Parameters.Add("@fecha", SqlDbType.Date);
                Comando.Parameters.Add("@cantidadE", SqlDbType.Int);
                Comando.Parameters.Add("@cve_pieza", SqlDbType.Int);
                Comando.Parameters.Add("@cve_venta", SqlDbType.Int);

                /*Comando.Parameters["@fecha_asignacion"].Value = fecha_asignacion;
                Comando.Parameters["@fecha_promesa"].Value = fecha_promesa;*/
                Comando.Parameters["@fecha"].Value = fecha;
                Comando.Parameters["@cantidadE"].Value = cantidadE;
                Comando.Parameters["@cve_pieza"].Value = cve_pieza;
                Comando.Parameters["@cve_venta"].Value = cve_venta;
                Comando.ExecuteNonQuery();

                //VAMOS A OBTENER LA DIFERENCIA DE DIAS ENTRE FECHA_ENTREGA Y FECHA_ASIGNACIÓN
                Comando = new SqlCommand("SELECT DATEDIFF(DAY,@fecha_asignacion, @fecha)",nuevaConexion);
                Comando.Parameters.AddWithValue("@fecha_asignacion",fecha_asigancion);
                Comando.Parameters.AddWithValue("@fecha",fecha);
                dias_entrega = Int32.Parse(Comando.ExecuteScalar().ToString()) +1;
                //SE ACTUALIZAN LOS DATOS SIGUIENTES 
                SqlCommand cmd = new SqlCommand("UPDATE p SET p.cve_entrega = @cve_entrega, p.pzas_entregadas = @pzas_entregadas, p.fecha_entrega = @fecha_entrega, p.dias_entrega = @dias_entrega FROM PEDIDO p INNER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta WHERE ven.cve_siniestro = @cve_siniestro AND ven.cve_pedido = @cve_pedido AND cve_pieza = @cve_pieza", nuevaConexion);
                cmd.Parameters.Add("@cve_entrega", SqlDbType.Int);
                cmd.Parameters.Add("@pzas_entregadas", SqlDbType.Int);
                cmd.Parameters.Add("@fecha_entrega", SqlDbType.Date);
                cmd.Parameters.Add("@cve_siniestro", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@cve_pedido", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                cmd.Parameters.Add("@dias_entrega",SqlDbType.Int);

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
                if(cmd.ExecuteScalar() != null)
                {
                    cmd = new SqlCommand("UPDATE PEDIDO SET entrega_enTiempo = 1 WHERE cve_venta = @cve_venta  AND cve_pieza = @cve_pieza", nuevaConexion);
                    cmd.Parameters.Add("@cve_venta", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_pieza", SqlDbType.Int);
                    cmd.Parameters["@cve_venta"].Value = cve_venta;
                    cmd.Parameters["@cve_pieza"].Value = cve_pieza;
                    MessageBox.Show("Entregado a Tiempo!");
                }

                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "ENTREGA EXITOSA";
            }

            return mensaje;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA--------------------
        public int Pzas_Entregadas(string cve_siniestro, string cve_pedido, int cve_pieza)
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
        }

        //----------------------------------------------------------------------------------------------------------------------

        //--------------------OBTENER DATOS DE LA TABLA ENTREGA--------------------
        public DataTable Tabla_Entrega(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                //Comando = new SqlCommand(string.Format("SELECT DISTINCT  pie.nombre AS PIEZA,  ent.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, ent.fecha AS 'FECHA ENTREGA', ven.fecha_promesa AS 'FECHA PROMESA' FROM ENTREGA ent JOIN VENTAS ven ON ven.cve_venta= ent.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = ent.cve_pieza WHERE ent.cve_venta = {0}", cve_venta), nuevaConexion);
                Comando = new SqlCommand(string.Format("SELECT   pie.nombre AS PIEZA,  ent.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, ent.fecha AS 'FECHA ENTREGA', ven.fecha_promesa AS 'FECHA PROMESA',p.entrega_enTiempo AS 'ENTREGA EN TIEMPO' FROM ENTREGA ent INNER JOIN VENTAS ven ON ven.cve_venta= ent.cve_venta INNER JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador INNER JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador INNER JOIN PIEZA  pie ON pie.cve_pieza = ent.cve_pieza INNER JOIN PEDIDO p ON p.cve_venta= ent.cve_venta WHERE ent.cve_venta = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }

        //---------------------------------------------------------------------------------------------------------------------

        //--------------------OBTENER DATOS DE LA TABLA ENTREGA--------------------
        public DataTable Tabla_Devolucion(int cve_venta)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT  pie.nombre AS PIEZA,  dev.cantidad AS CANTIDAD, c.cve_nombre AS CLIENTE, dev.motivo AS MOTIVO,pen.porcentaje AS 'PORCENTAJE (%)', dev.fecha AS FECHA FROM DEVOLUCION dev JOIN VENTAS ven ON ven.cve_venta= dev.cve_venta JOIN VALUADOR val ON val.cve_valuador = ven.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = dev.cve_pieza JOIN PENALIZACION pen ON dev.cve_penalizacion = pen.cve_penalizacion WHERE dev.cve_venta  = {0}", cve_venta), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }
            return dt;
        }

        //--------------------------------------------------------------------------------------------------

        //--------------------ACTUALIZAR FACTURA (OBTENER DATOS.)--------------------
        public DataTable Actualizar_Factura(int cve_factura)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT * FROM FACTURA WHERE cve_factura = {0}", cve_factura), nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }

            return dt;
        }

        //-----------------------------------------------------------------------------------------------------

        //--------------------ACTUALIZAR FACTURA (UPDATE)--------------------
        public string Actualizar_Factura(int cve_factura, int cve_estado, decimal fact_sinIVA, decimal fact_neto, string fecha_ingreso, string fecha_revision, string fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
        {
            string mensaje = "Se Actualizo Correctamente";
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                if (archivo == null && archivo_xml == null)
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);

                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);
                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;

                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    Comando.Parameters["@fact_neto"].Value = fact_neto;
                    Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                    Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                    Comando.Parameters["@comentario"].Value = comentario;
                    Comando.ExecuteNonQuery();
                }
                else
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,nombre_factura = @nombre_factura,archivo = @archivo,nombre_xml = @nombre_xml,archivo_xml = @archivo_xml,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);

                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
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
        public string Actualizar_Refactura(int cve_factura, int cve_estado, int cve_refactura, decimal fact_sinIVA, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
        {
            string mensaje = "Se Actualizo Correctamente";

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();

                if (archivo == null && archivo_xml == null)
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_refactura = @cve_refactura,cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,costo_refactura = @costo_refactura,fecha_refactura = @fecha_refactura,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_refactura", SqlDbType.Int);
                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    Comando.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                    Comando.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    Comando.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    Comando.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;
                    Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    Comando.Parameters["@fact_neto"].Value = fact_neto;
                    Comando.Parameters["@costo_refactura"].Value = costo_refactura;
                    Comando.Parameters["@fecha_refactura"].Value = fecha_refactura;
                    Comando.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    Comando.Parameters["@fecha_revision"].Value = fecha_revision;
                    Comando.Parameters["@fecha_pago"].Value = fecha_pago;
                    Comando.Parameters["@comentario"].Value = comentario;
                    Comando.ExecuteNonQuery();
                }
                else
                {
                    Comando = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,cve_refactura = @cve_refactura,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,costo_refactura = @costo_refactura,fecha_refactura = @fecha_refactura,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,nombre_factura = @nombre_factura,archivo = @archivo,nombre_xml = @nombre_xml,archivo_xml = @archivo_xml,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    Comando.Parameters.Add("@cve_factura", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_estado", SqlDbType.Int);
                    Comando.Parameters.Add("@cve_refactura", SqlDbType.Int);
                    Comando.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
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

                    Comando.Parameters["@cve_factura"].Value = cve_factura;
                    Comando.Parameters["@cve_estado"].Value = cve_estado;
                    Comando.Parameters["@cve_refactura"].Value = cve_refactura;
                    Comando.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
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
                    Comando.ExecuteNonQuery();
                }

                nuevaConexion.Close();
            }

            return mensaje;
        }

        //-------------------------------------------------------------------------------------------------------------------

        //----------------LLENAR TABLA TXBOX----------------------------------
        public void Llenartabla1(DataGridView dtgv, string cve_Siniestro, string cve_Pedido,string cve_vendedor)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                   
                        da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador where ven.cve_siniestro like '%{0}%' and CAST(ven.cve_pedido AS nvarchar) like '%{1}%' and ven.cve_vendedor like '%{2}%'", cve_Siniestro, cve_Pedido,cve_vendedor), nuevacon);
                    
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

        //------------------------------------------------------------------------------------------------------

        //-----------------LLENAR TABLA FECHAS-------------------------------
        public void Llenartabla(DataGridView dvg, string Fecha_inicio, string fecha_fin)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON p.cve_venta = ven.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador where fecha_asignacion between '{0}' and '{1}' order by ven.fecha_asignacion desc", Fecha_inicio, fecha_fin), nuevacon);
                    nuevacon.Open();
                    dt = new DataTable();
                    da.Fill(dt);
                    dvg.DataSource = dt;
                    nuevacon.Close();
                }
            }
            catch (Exception ex) { }
        }

        //--------------------------------------------------------------------------------------------------------

        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA--------------------
        public void Llenartabla(DataGridView dgv, string cve_Siniestro, string cve_Pedido, string nombre_pieza)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, pi.nombre AS PIEZA,  p.cantidad AS CANTIDAD, ven.cve_vendedor AS VENDEDOR, p.cve_guia 'CLAVE GUIA', o.origen AS ORIGEN, pro.nombre AS PROVEEDOR, v.nombre AS VALUADOR, c.cve_nombre AS CLIENTE, po.nombre AS PORTAL, t.nombre AS TALLER, CONVERT(varchar, ven.fecha_asignacion, 6) AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6) AS 'FECHA PROMESA',CONVERT(varchar,ent.fecha, 6)  AS 'FECHA DE ENTREGA', p.costo_comprasinIVA AS 'COSTO COMPRA', cos.costo AS 'COSTO DE ENVÍO', p.costo_neto AS 'COSTO NETO', p.precio_venta AS 'PRECIO DE VENTA', p.precio_reparacion AS 'PRECIO REPARACIÓN', ven.cve_factura AS 'FACTURA', fa.fact_sinIVA AS 'FACTURA SIN IVA', fa.fact_neto AS 'FACTURA NETO', es.estado AS 'ESTADO FACTURA' FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN ORIGEN_PIEZA o ON o.cve_origen = p.cve_origen LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza LEFT OUTER JOIN PROVEEDOR pro ON p.cve_proveedor = pro.cve_proveedor LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN PORTAL po ON po.cve_portal = p.cve_portal LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller  LEFT OUTER JOIN FACTURA fa ON fa.cve_factura = ven.cve_factura LEFT OUTER JOIN ESTADO_FACTURA es ON es.cve_estado = fa.cve_estado LEFT OUTER JOIN ENTREGA ent ON ent.cve_entrega = p.cve_entrega LEFT OUTER JOIN COSTO_ENVIO cos ON cos.cve_costoEnvio = p.costo_envio where ven.cve_pedido = '{0}' and ven.cve_siniestro = '{1}' and pi.nombre = '{2}'", cve_Pedido, cve_Siniestro, nombre_pieza), nuevacon);
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

        //---------------------------LLENAR TABLA PARA DATOS DE MUESTRA PDF--------------------
        public void Llenartabla(DataGridView dgv, string cve_Pedido)
        {
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS SINIESTRO, pi.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, t.nombre AS TALLER, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', veh.modelo AS 'MODELO', veh.anio AS 'ANIO' FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta  LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller LEFT OUTER JOIN SINIESTRO si ON si.cve_siniestro=ven.cve_siniestro LEFT OUTER JOIN VEHICULO veh ON veh.cve_vehiculo=si.cve_vehiculo where ven.cve_pedido ='{0}'", cve_Pedido), nuevacon);
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
                    Comando = new SqlCommand(string.Format("SELECT COUNT(p.cve_pieza) FROM PEDIDO p LEFT OUTER JOIN VENTAS ven ON ven.cve_venta = p.cve_venta  LEFT OUTER JOIN PIEZA pi ON p.cve_pieza = pi.cve_pieza  LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador LEFT OUTER JOIN TALLER t ON t.cve_taller = ven.cve_taller LEFT OUTER JOIN ENTREGA e ON p.cve_entrega = e.cve_entrega LEFT OUTER JOIN SINIESTRO si ON si.cve_siniestro=ven.cve_siniestro LEFT OUTER JOIN VEHICULO veh ON veh.cve_vehiculo=si.cve_vehiculo where cve_pedido='{0}'", cve_ped), nuevacon);
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

        //---------------------------LLENAR DATOS EN DGV POR DEFAULT--------------------
        public void defaultDGV(DataGridView dgv)
        {
            //SELECT TOP 10 * FROM PEDIDO
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {
                    da = new SqlDataAdapter(string.Format("SELECT TOP 10 ven.cve_pedido AS PEDIDO, ven.cve_siniestro AS 'SINIESTRO', ven.cve_vendedor AS VENDEDOR, c.cve_nombre AS CLIENTE, k.nombre AS PIEZA, p.cantidad AS CANTIDAD, ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ven.cve_venta AS 'VENTA' FROM VENTAS ven LEFT OUTER JOIN PEDIDO p ON ven.cve_venta = p.cve_venta LEFT OUTER JOIN PIEZA k ON p.cve_pieza = k.cve_pieza LEFT OUTER JOIN VALUADOR v ON v.cve_valuador = ven.cve_valuador LEFT OUTER JOIN CLIENTE c ON c.cve_valuador = v.cve_valuador order by ven.fecha_asignacion desc"), nuevacon);
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

        //--------------------------------------------------------------------------------------------------------

        //---------------------------OBTENER CLAVE DE FACTURA-------------------
        public int Clave_Fact(string siniestro, string cve_pedido)
        {
            int cve_factura = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_factura FROM VENTAS WHERE cve_siniestro = '{0}' AND cve_pedido = '{1}'", siniestro, cve_pedido), nuevaConexion);
                    if (Comando.ExecuteScalar() == null || Comando.ExecuteScalar().ToString() == string.Empty)
                    {
                        cve_factura = 0;
                    }
                    else
                    {
                        //MessageBox.Show("ENTRO :V");
                        cve_factura = (Int32)Comando.ExecuteScalar();
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
        public int Clave_Refact(int cve_factura)
        {
            int cve_refactura = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_refactura FROM FACTURA WHERE cve_factura = {0}", cve_factura), nuevaConexion);
                    if (Comando.ExecuteScalar().ToString() == string.Empty || Comando.ExecuteScalar() == null)
                    {
                        cve_factura = 0;
                    }
                    else
                    {
                        cve_refactura = (Int32)Comando.ExecuteScalar();
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
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT DISTINCT ven.cve_siniestro AS Siniestro, fact.cve_factura AS Factura, fact.fact_sinIVA AS 'Factura sin IVA', fact.fact_neto AS 'Factura Neto', fact.fecha_pago AS 'Fecha de Pago' FROM VENTAS ven INNER JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura WHERE DATEDIFF(DAY, @fecha_sys, fact.fecha_pago) < 7 AND fact.cve_estado = 1", nuevaConexion);
                Comando.Parameters.Add("@fecha_sys", SqlDbType.Date);
                Comando.Parameters["@fecha_sys"].Value = fecha_sys;
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }

            return dt;
        }
        //---------------------------TABLA ALERTAS POR PIEZA--------------------
        public DataTable Alertas()
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO',ven.fecha_promesa AS 'FECHA PROMESA',pie.nombre AS 'PIEZA', p.cantidad AS 'TOTAL DE PIEZAS', p.pzas_entregadas AS 'PIEZAS ENTREGADAS', p.fecha_entrega AS 'ULTIMA FECHA DE ENTREGA', p.entrega_enTiempo AS 'ENTREGA EN TIEMPO' FROM PEDIDO p INNER JOIN VENTAS ven ON p.cve_venta = ven.cve_venta INNER JOIN PIEZA pie ON p.cve_pieza = pie.cve_pieza  WHERE p.pzas_entregadas != p.cantidad ", nuevaConexion);
                da = new SqlDataAdapter(Comando);
                da.Fill(dt);
                nuevaConexion.Close();
            }

            return dt;
        }
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
        //------------- GENERAR EXCEL
        public void generarExcel(string ruta, string fecha1, string fecha2, decimal costoOperativo)
        {

            try
            {
                SLDocument sl = new SLDocument(ruta);
                DateTime hoy = DateTime.Today;
                sl.SetCellValue("L2", hoy.ToString("dd-MM-yyyy"));//Se agrega la fecha al excel
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    int celdaContenido = 9;
                    //Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO',  c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE SEGUIMIENTO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_comprasinIVA AS 'COSTO SIN IVA', ped.costo_neto AS 'COSTO CON IVA', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO', ven.cve_vendedor AS 'VENDEDOR', ven.fecha_asignacion AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa AS 'FECHA PROMESA', ent.fecha AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ven.fecha_baja AS 'FECHA DE BAJA', dev.fecha AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', dev.cantidad AS 'CANTIDAD DE PIEZAS DEVUELTAS', pen.porcentaje AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago AS 'FECHA DE PAGO FACTURA', fact.fact_sinIVA AS 'FACTURA SIN IVA', fact.fact_neto AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',ven.sub_total AS 'SUB TOTAL', ven.total AS 'TOTAL', ven.utilidad AS 'UTILIDAD BRUTA' FROM VENTAS ven FULL JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador FULL JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador FULL JOIN TALLER t ON ven.cve_taller = t.cve_taller FULL JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro FULL JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo FULL JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta FULL JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor FULL JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza FULL JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen FULL JOIN PORTAL por ON ped.cve_portal = por.cve_portal FULL JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio FULL JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion FULL JOIN PENALIZACION pen ON dev.cve_penalizacion = pen.cve_penalizacion FULL JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado WHERE ven.cve_siniestro != '' AND ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);
                    Comando = new SqlCommand("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', cosen.costo AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO', vendedor.nombre AS 'VENDEDOR', CONVERT(varchar, ven.fecha_asignacion, 6)  AS 'FECHA DE ASIGNACIÓN', CONVERT(varchar, ven.fecha_promesa, 6)  AS 'FECHA PROMESA', CONVERT(varchar, ent.fecha, 6)  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', CONVERT(varchar, ven.fecha_baja, 6)  AS 'FECHA DE BAJA', CONVERT(varchar, dev.fecha, 6)  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', dev.cantidad AS 'CANTIDAD DE PIEZAS DEVUELTAS', pen.porcentaje AS 'PENALIZACIÓN POR DEVOLUCIÓN', ven.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', CONVERT(varchar, fact.fecha_ingreso, 6)  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', CONVERT(varchar, fact.fecha_revision, 6)  AS 'FECHA DE REVISIÓN FACTURA', CONVERT(varchar, fact.fecha_pago, 6)  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(cosen.costo + ped.costo_neto) AS 'COSTO ADQUISICION', ((ped.precio_venta)-(cosen.costo + ped.costo_neto)) AS 'UTILIDAD ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',ped.gasto AS 'GASTO',(((ped.precio_venta)-(cosen.costo + ped.costo_neto))-(@costoOperativo)-(ped.gasto)) AS 'UTILIDAD FINAL' FROM VENTAS ven FULL JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador FULL JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador FULL JOIN TALLER t ON ven.cve_taller = t.cve_taller FULL JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro FULL JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo FULL JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta FULL JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor FULL JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza FULL JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen FULL JOIN PORTAL por ON ped.cve_portal = por.cve_portal FULL JOIN COSTO_ENVIO cosen ON ped.costo_envio = cosen.cve_costoEnvio FULL JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion FULL JOIN PENALIZACION pen ON dev.cve_penalizacion = pen.cve_penalizacion FULL JOIN FACTURA fact ON ven.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado FULL JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor FULL JOIN MARCA marca ON vh.cve_marca = marca.cve_marca WHERE ven.cve_siniestro != '' AND ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2", nuevaConexion);
                    Comando.Parameters.AddWithValue("@fecha1", fecha1);
                    Comando.Parameters.AddWithValue("@fecha2", fecha2);
                    Comando.Parameters.AddWithValue("@costoOperativo", costoOperativo);

                    Lector = Comando.ExecuteReader();
                    while (Lector.Read())
                    {
                        //cambiar a cve_destino
                        sl.SetCellValue("A" + celdaContenido, Lector["PEDIDO"].ToString());
                        sl.SetCellValue("B" + celdaContenido, Lector["SINIESTRO"].ToString());
                        sl.SetCellValue("C" + celdaContenido, Lector["CLIENTE"].ToString());
                        sl.SetCellValue("D" + celdaContenido, Lector["VALUADOR"].ToString());
                        sl.SetCellValue("E" + celdaContenido, Lector["TALLER"].ToString());
                        sl.SetCellValue("F" + celdaContenido, Lector["VHEICULO MODELO"].ToString());
                        sl.SetCellValue("G" + celdaContenido, Lector["MARCA"].ToString());
                        sl.SetCellValue("H" + celdaContenido, Lector["AÑO"].ToString());
                        sl.SetCellValue("I" + celdaContenido, Lector["PROVEEDOR"].ToString());
                        sl.SetCellValue("J" + celdaContenido, Lector["PIEZA"].ToString());
                        sl.SetCellValue("K" + celdaContenido, Lector["CLAVE PRODUCTO"].ToString());
                        sl.SetCellValue("L" + celdaContenido, Lector["TOTAL DE PIEZAS"].ToString());
                        sl.SetCellValue("M" + celdaContenido, Lector["GUÍA DE ENVIO"].ToString());
                        sl.SetCellValue("N" + celdaContenido, Lector["ORIGEN PIEZA"].ToString());
                        sl.SetCellValue("O" + celdaContenido, Lector["PORTAL"].ToString());
                        sl.SetCellValue("P" + celdaContenido, Lector["COSTO ENVÍO"].ToString());
                        sl.SetCellValue("Q" + celdaContenido, Lector["COSTO"].ToString());
                        sl.SetCellValue("R" + celdaContenido, Lector["PRECIO VENTA"].ToString());
                        sl.SetCellValue("S" + celdaContenido, Lector["DESTINO"].ToString());
                        sl.SetCellValue("T" + celdaContenido, Lector["VENDEDOR"].ToString());
                        sl.SetCellValue("U" + celdaContenido, Lector["FECHA DE ASIGNACIÓN"].ToString());
                        sl.SetCellValue("V" + celdaContenido, Lector["FECHA PROMESA"].ToString());
                        sl.SetCellValue("W" + celdaContenido, Lector["FECHA DE ENTREGA"].ToString());
                        sl.SetCellValue("X" + celdaContenido, Lector["PIEZAS ENTREGADAS"].ToString());
                        sl.SetCellValue("Y" + celdaContenido, Lector["ENTREGA EN TIEMPO"].ToString());
                        sl.SetCellValue("Z" + celdaContenido, Lector["DÍAS DE ENTREGA"].ToString());
                        sl.SetCellValue("AA" + celdaContenido, Lector["FECHA DE BAJA"].ToString());
                        sl.SetCellValue("AB" + celdaContenido, Lector["FECHA DEVOLUCIÓN"].ToString());
                        sl.SetCellValue("AC" + celdaContenido, Lector["MOTIVO DE DEVOLUCIÓN"].ToString());
                        sl.SetCellValue("AD" + celdaContenido, Lector["CANTIDAD DE PIEZAS DEVUELTAS"].ToString());
                        sl.SetCellValue("AE" + celdaContenido, Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString());
                        sl.SetCellValue("AF" + celdaContenido, Lector["FACTURA ACTUAL"].ToString());
                        sl.SetCellValue("AG" + celdaContenido, Lector["FACTURA ANTERIOR"].ToString());
                        sl.SetCellValue("AH" + celdaContenido, Lector["FECHA INGRESO FACTURA"].ToString());
                        sl.SetCellValue("AI" + celdaContenido, Lector["ESTADO DE LA FACTURA"].ToString());
                        sl.SetCellValue("AJ" + celdaContenido, Lector["FECHA DE REVISIÓN FACTURA"].ToString());
                        sl.SetCellValue("AK" + celdaContenido, Lector["FECHA DE PAGO FACTURA"].ToString());
                        sl.SetCellValue("AL" + celdaContenido, Lector["FACTURA SIN IVA"].ToString());
                        sl.SetCellValue("AM" + celdaContenido, Lector["FACTURA NETO"].ToString());
                        sl.SetCellValue("AN" + celdaContenido, Lector["COMENTARIOS SINIESTRO"].ToString());
                        sl.SetCellValue("AO" + celdaContenido, Lector["COMENTARIOS FACTURA"].ToString());
                        sl.SetCellValue("AP" + celdaContenido, Lector["COSTO ADQUISICION"].ToString());
                        sl.SetCellValue("AQ" + celdaContenido, Lector["UTILIDAD ADQUISICION"].ToString());
                        sl.SetCellValue("AR" + celdaContenido, Lector["COSTO OPERATIVO"].ToString());
                        sl.SetCellValue("AS" + celdaContenido, Lector["GASTO"].ToString());
                        sl.SetCellValue("AT" + celdaContenido, Lector["UTILIDAD FINAL"].ToString());
                        /*sl.SetCellValue("AP" + celdaContenido, Lector["SUB TOTAL"].ToString());
                        sl.SetCellValue("AQ" + celdaContenido, Lector["TOTAL"].ToString());
                        sl.SetCellValue("AR" + celdaContenido, Lector["UTILIDAD BRUTA"].ToString());*/
                        celdaContenido++;
                    }

                    SLStyle estiloContenido = new SLStyle();
                    estiloContenido.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    estiloContenido.Border.LeftBorder.Color = Color.Black;
                    estiloContenido.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    estiloContenido.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                    estiloContenido.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
                   
                    sl.SetCellStyle("A9", "AT" + celdaContenido, estiloContenido);
                    sl.AutoFitColumn("A", "AT");
                    
                    SaveFileDialog guarda = new SaveFileDialog();
                    guarda.Filter = "Libro de Excel|*.xlsx";
                    guarda.Title = "Guardar Reporte";
                    guarda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (guarda.ShowDialog() == DialogResult.OK)
                    {
                        sl.SaveAs(guarda.FileName);
                        MessageBox.Show("Archivo Guardado");
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }

        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS--------------------
        public DataTable buscarFacturas()
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand("SELECT fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO' FROM FACTURA fact LEFT OUTER JOIN VENTAS ven ON fact.cve_factura = ven.cve_factura", nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //--------------------LLENAR DATAGRID BUSCAR FACTURAS CON TEXBOX--------------------
        public DataTable buscarFacturas(int cve_factura)
        {
            dt = new DataTable();
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                Comando = new SqlCommand(string.Format("SELECT fact.cve_factura AS 'FACTURA',ven.cve_siniestro AS 'SINIESTRO', ven.cve_pedido AS 'PEDIDO' FROM FACTURA fact LEFT OUTER JOIN VENTAS ven ON fact.cve_factura = ven.cve_factura WHERE fact.cve_factura like '%{0}%'",cve_factura), nuevaConexion);
                da = new SqlDataAdapter(Comando);

                da.Fill(dt);

                nuevaConexion.Close();
            }
            return dt;
        }
        //---------------------ALEX--------------------------------------------------------------------
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

        //---------------- ESTADO DE SINIESTRO (llena combobox)
        public DataSet EstadoSiniestro()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT estado FROM ESTADO_SINIESTRO", nuevaConexion);
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
        public DataSet VehiculosRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT modelo FROM VEHICULO WHERE modelo NOT LIKE 'PARTICULAR%'", nuevaConexion);
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
        public DataSet MarcasRegistradas()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT marca FROM MARCA WHERE marca NOT LIKE 'PARTICULAR%'", nuevaConexion);
                    dataAdapter.Fill(dataSet, "MARCA");
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

        //---------------- VENDEDORES REGISTRADOS
        public DataSet VendedoresRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_vendedor FROM VENDEDOR", nuevaConexion);
                    dataAdapter.Fill(dataSet, "VENDEDOR");
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
            return dataSet;
        }

        //---------------- ASEGURADORAS/CLIENTES REGISTRADAS
        public DataSet AseguradorasRegistradas()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_nombre FROM CLIENTE", nuevaConexion);
                    dataAdapter.Fill(dataSet, "CLIENTE");
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
            try
            {
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
                        MessageBox.Show("Se registró nueva cliente correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nuevo cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }
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
                        MessageBox.Show("Se registró nuevo valuador correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nuevo valuador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
        public DataSet TalleresRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM TALLER", nuevaConexion);
                    dataAdapter.Fill(dataSet, "TALLER");
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
        public int registrarTaller(string nombre)
        {
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO TALLER " + "(nombre) " + "VALUES (@nombre) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@nombre", nombre);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBox.Show("Se registró nuevo taller correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nuevo taller", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
                        MessageBox.Show("Se registró nuevo destino correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nuevo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
        public DataSet NombrePiezasRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PIEZA", nuevaConexion);
                    dataAdapter.Fill(dataSet, "PIEZA");
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
                        MessageBox.Show("Se registró nueva pieza correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nueva pieza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
        public DataSet PortalesRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PORTAL", nuevaConexion);
                    dataAdapter.Fill(dataSet, "PORTAL");
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
                        MessageBox.Show("Se registró nuevo portal correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nueva portal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Se registró nuevo origen correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nueva origen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
        public DataSet ProveedoresRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT nombre FROM PROVEEDOR", nuevaConexion);
                    dataAdapter.Fill(dataSet, "PROVEEDOR");
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
                        MessageBox.Show("Se registró nuevo proveedor correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar nueva proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
        public string estadoSiniestroClaves(string clavePedido, string claveSiniestro)
        {
            string estado = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("SELECT DISTINCT esin.estado FROM VENTAS ven INNER JOIN SINIESTRO sin ON ven.cve_siniestro = sin.cve_siniestro INNER JOIN ESTADO_SINIESTRO esin ON sin.estado = esin.cve_estado WHERE ven.cve_pedido = @cve_pedido AND ven.cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        estado = Lector["estado"].ToString().Trim();
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
                    Comando = new SqlCommand("SELECT cve_vendedor FROM VENTAS WHERE cve_pedido = @cve_pedido AND cve_siniestro = @cve_siniestro", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        vendedor = Lector["cve_vendedor"].ToString().Trim();
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
                    if (i == 1) { }
                        //MessageBox.Show("Se registró vehículo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
                    if (i == 1) { }
                    //MessageBox.Show("Se registró vehículo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
        public int registrarSiniestro(string modelo, string claveSiniestro, string comentario, string estado)
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
                    Comando = new SqlCommand("SELECT cve_vehiculo FROM VEHICULO WHERE modelo = @modelo", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        claveVehiculo = (int)Lector["cve_vehiculo"];
                    }
                    Lector.Close();

                    //Obteniendo la clave del estado
                    Comando = new SqlCommand("SELECT cve_estado FROM ESTADO_SINIESTRO WHERE estado = @estado", nuevaConexion);
                    Comando.Parameters.AddWithValue("@estado", estado.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        claveEstado = (int)Lector["cve_estado"];
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
                        MessageBox.Show("Se registró siniestro correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
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
                Comando.Parameters.AddWithValue("cve_pedido", clavePedido);
                Comando.Parameters.AddWithValue("cve_siniestro", claveSiniestro);
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
        public int registrarVenta(string clavePedido, string claveSiniestro, string taller, int claveVendedor, DateTime fechaBaja, string valuador, string destino, double costoTotal, double subtotalPrecio, double totalPrecio, DateTime fechaAsignacion, DateTime fechaPromesa)//, double utilidad
        {
            //Variables
            int i = 0;
            int cve_taller = claveTaller(taller);
            int cve_valuador = claveValuador(valuador);
            int cve_destino = claveDestino(destino);

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                //Insertando los datos en la relación VENTAS
                Comando = new SqlCommand("INSERT INTO VENTAS " + "(cve_pedido, cve_siniestro, cve_vendedor, cve_taller, cve_valuador, fecha_baja, cve_destino, costo_total, sub_total, total, fecha_asignacion, fecha_promesa) " +
                    "VALUES (@cve_pedido, @cve_siniestro, @cve_vendedor, @cve_taller, @cve_valuador, @fecha_baja, @cve_destino, @costo_total, @sub_total, @total, @fecha_asignacion, @fecha_promesa) ", nuevaConexion);//utilidad    , @utilidad
                Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                Comando.Parameters.AddWithValue("@cve_vendedor", claveVendedor);
                Comando.Parameters.AddWithValue("@cve_taller", cve_taller);
                Comando.Parameters.AddWithValue("@cve_valuador", cve_valuador);
                Comando.Parameters.AddWithValue("@fecha_baja", fechaBaja);
                Comando.Parameters.AddWithValue("@cve_destino", cve_destino);
                Comando.Parameters.AddWithValue("@costo_total", costoTotal);
                Comando.Parameters.AddWithValue("@sub_total", subtotalPrecio);
                Comando.Parameters.AddWithValue("@total", totalPrecio);
                //Comando.Parameters.AddWithValue("@utilidad", utilidad);
                Comando.Parameters.AddWithValue("@fecha_asignacion", fechaAsignacion);
                Comando.Parameters.AddWithValue("@fecha_promesa", fechaPromesa);

                //Para saber si la inserción se hizo correctamente
                i = Comando.ExecuteNonQuery();
                nuevaConexion.Close();
                if (i == 1)
                {
                }
                else
                    MessageBox.Show("Problemas al registrar venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*}
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }*/
            return i;
        }

        //-------------INSERTAR DATOS DE PEDIDO
        public int registrarPedido(string clavePedido, string claveSiniestro, string nombrePieza, string portal, string origen, string proveedor, DateTime fechaCosto/*, string costoSinIVA*/, string costoNeto, string costoEnvio, string precioVenta, string precioReparacion, string claveProducto, string numeroGuia, int cantidad)
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

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                //Obteniendo la clave del vendedor
                //Obtener del combobox

                //cve_guia & cve_producto:  obtener del DGV

                nuevaConexion.Open();
                //Insertando los datos en la tabla PEDIDO
                Comando = new SqlCommand("INSERT INTO PEDIDO " + "(cve_venta, cve_pieza, cantidad, cve_origen, cve_proveedor, cve_portal, cve_guia, cve_producto, fecha_costo, costo_envio, costo_neto, precio_venta, precio_reparacion, gasto) " +
                    "VALUES (@cve_venta, @cve_pieza, @cantidad, @cve_origen, @cve_proveedor, @cve_portal, @cve_guia, @cve_producto, @fecha_costo, @costo_envio, @costo_neto, @precio_venta, @precio_reparacion, @gasto) ", nuevaConexion);//, costo_comprasinIVA    , @costo_comprasinIVA
                //Añadiendo los parámetros al query
                Comando.Parameters.AddWithValue("@cve_venta", cve_venta);
                Comando.Parameters.AddWithValue("@cve_pieza", cve_pieza);
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

                //Para saber si la inserción se hizo correctamente
                i = Comando.ExecuteNonQuery();
                nuevaConexion.Close();
                if (i == 1)
                    MessageBox.Show("Se registró pedido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Problemas al registar pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*}
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }*/
            return i;
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