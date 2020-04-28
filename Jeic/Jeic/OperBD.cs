using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BASE DE DATOS
//Librerias
using System.Data;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Refracciones
{
    class OperBD
    {
        //VARIABLES  
        SqlCommand Comando;
        SqlDataReader Lector;
        string usuario = "Hector";
        string contra = "123";


        //METODOS

        public int logeo(string us,string pass) {
            int contador = 0;
            try
            {
                using (SqlConnection nuevacon = Conexion.conexion())
                {

                    this.Comando = new SqlCommand(string.Format("SELECT usuario,contrasenia FROM administrador WHERE usuario='{0}' AND dbo.fnDescifraClave(contrasenia)='{1}';", us, pass), nuevacon);
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
        //--------------------VALIDACION-MASTER----------------------------------------------

        public int Master_registrado(string user, string password)
        {
            int contador = 0;
            try
            {

                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("select USUARIO,CONTRASEÑA from ADMINISTRADOR where USUARIO= '{0}' AND dbo.fnDescifraClave(CONTRASEÑA)= '{1}';", user, password), nuevaConexion);
                    Lector = Comando.ExecuteReader();
                    //SOLO ENTRA A ESTA PARTE SI HAY ID REPETIDOS POR LO QUE SE INCREMENTA EL CONTADOR
                    while (Lector.Read())
                    {
                        contador++;
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("No se pudo conectar bien: " + EX.Message);
            }
            return contador;
        }

        //--------------------INGRESAR FACTURA--------------------
        public string Registrar_factura(string cve_siniestro, int cve_pedido, int cve_factura, int cve_estado, decimal fact_sinIVA, decimal fact_neto, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
        {
            string mensaje = "Se inserto la factura";
            try
            {
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
                    comm = new SqlCommand(string.Format("UPDATE PEDIDO SET cve_factura = {0} WHERE cve_siniestro = '{1}' AND cve_pedido = {2}", cve_factura, cve_siniestro, cve_pedido), nuevaConexion);
                    comm.ExecuteNonQuery();
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la factura: " + ex.ToString();
            }
            return mensaje;
        }
        //----------------------------------------------------------------------------------

        //--------------------RECUPERAR FACTURA--------------------

        public byte[] Buscar_factura(int cve_factura)
        {
            byte[] factura;
            
            
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    
                    nuevaConexion.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("select archivo from FACTURA where cve_factura= @cve_factura", nuevaConexion);
                    cmd.Parameters.AddWithValue("@cve_factura",cve_factura);
                    factura = cmd.ExecuteScalar() as byte[];   
                    nuevaConexion.Close();
                }
            
            return factura;
        }

        //---------------------------------------------------------------------
        //--------------------RECUPERAR NOMBRE FACTURA--------------------

        public string Nombre_Factura(int cve_factura)
        {
            string factura;


            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("select nombre_factura from FACTURA where cve_factura= @cve_factura", nuevaConexion);
                cmd.Parameters.AddWithValue("@cve_factura", cve_factura);
                factura = cmd.ExecuteScalar() as string;
                nuevaConexion.Close();
            }

            return factura;
        }

        //---------------------------------------------------------------------
        //--------------------INGRESAR FACTURA--------------------
        public string Registrar_Refactura(string cve_siniestro, int cve_pedido, int cve_factura, int cve_estado, int cve_refactura, decimal fact_sinIVA, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
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


                    comm = new SqlCommand(string.Format("UPDATE PEDIDO SET cve_factura = {0} WHERE cve_siniestro = '{1}' AND cve_pedido = {2}", cve_factura, cve_siniestro, cve_pedido), nuevaConexion);
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
        //--------------------RECUPERAR NOMBRE FACTURA--------------------

        public DataTable Devolucion(string cve_siniestro, int cve_pedido)
        {
            
            DataTable dt = new DataTable();

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT pie.cve_nombre AS NOMBRE,pie.cve_pieza AS CLAVE_PIEZA, ped.cantidad AS CANTIDAD, prov.cve_nombre AS PROVEEDOR, ped.cve_vendedor AS VENDEDOR, val.cve_nombre AS VALUADOR, c.cve_nombre AS CLIENTE, ent.fecha_asignacion AS FECHA_ASIGNACION, ped.fecha_entrega AS FECHA_ENTREGA, ent.fecha_promesa  AS FECHA_PROMESA, fac.cve_factura AS FACTURA FROM PEDIDO ped JOIN PROVEEDOR prov ON prov.cve_proveedor = ped.cve_proveedor JOIN PIEZA pie ON pie.cve_pieza = ped.cve_pieza JOIN VALUADOR val ON val.cve_valuador = ped.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN ENTREGA ent ON ent.cve_entrega = ped.cve_entrega JOIN FACTURA fac ON fac.cve_factura = ped.cve_factura WHERE ped.cve_siniestro = '{0}' AND ped.cve_pedido = {1}", cve_siniestro,cve_pedido), nuevaConexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                
                nuevaConexion.Close();
            }

            return dt;
        }

        //---------------------------------------------------------------------
        //--------------------OBTENER NUMERO DE REGISTROS EN DEVOLUCION--------------------

        public int Total_Registros()
        {

            Int32 count;

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DEVOLUCION", nuevaConexion);
                 count = (Int32)cmd.ExecuteScalar();



                 nuevaConexion.Close();
            }

            return count;
        }

        //---------------------------------------------------------------------
        //--------------------OBTENER NUMERO DE REGISTROS EN ENTREGA--------------------

        public int Total_Registros2()
        {

            Int32 count;

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ENTREGA", nuevaConexion);
                count = (Int32)cmd.ExecuteScalar();



                nuevaConexion.Close();
            }

            return count;
        }

        //---------------------------------------------------------------------
        //--------------------REGISTRAR DEVOLUCION ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE DEVOLUCION CON FECHA--------------------

        public string Registrar_Devolucion(string cve_siniestro, int cve_pedido, int cve_pieza, int cve_devolucion, int cantidad, DateTime fecha,int cantidadD,int cve_factura)
        {
            string mensaje = "ERROR AL HACER LA DEVOLUCIÓN";
            

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO DEVOLUCION (fecha,cantidad,cve_pieza,cve_factura) VALUES(@fecha,@cantidadD,@cve_pieza,@cve_factura)", nuevaConexion);
                comm.Parameters.Add("@fecha",SqlDbType.Date);
                comm.Parameters.Add("@cantidadD",SqlDbType.Int);
                comm.Parameters.Add("@cve_pieza",SqlDbType.Int);
                comm.Parameters.Add("@cve_factura",SqlDbType.Int);
                comm.Parameters["@fecha"].Value = fecha;
                comm.Parameters["@cantidadD"].Value = cantidadD;
                comm.Parameters["@cve_pieza"].Value = cve_pieza;
                comm.Parameters["@cve_factura"].Value = cve_factura;
                comm.ExecuteNonQuery();
                //SqlCommand cmd = new SqlCommand(string.Format("UPDATE PEDIDO SET cantidad = {0}, cve_devolucion = {1}  WHERE cve_siniestro = '{2}' AND cve_pedido = {3} AND cve_pieza = {4}",/*cantidad,*/cve_devolucion, cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE PEDIDO SET  cve_devolucion = {0}, pzas_devolucion = {1}  WHERE cve_siniestro = '{2}' AND cve_pedido = {3} AND cve_pieza = {4}",/*cantidad,*/cve_devolucion,cantidad,cve_siniestro,cve_pedido,cve_pieza ),nuevaConexion);
                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "DEVOLUCIÓN EXITOSA";
            }

            return mensaje;
        }

        //---------------------------------------------------------------------
        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA--------------------

        public int Pzas_Devolucion(string cve_siniestro, int cve_pedido, int cve_pieza)
        {

            int pzas;

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand comm = new SqlCommand(string.Format("SELECT pzas_devolucion FROM PEDIDO WHERE cve_siniestro = '{0}' AND cve_pedido = {1} AND cve_pieza = {2}", cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                if (comm.ExecuteScalar().ToString() == string.Empty)
                { pzas = 0; }
                else { pzas = (Int32)comm.ExecuteScalar(); }

                nuevaConexion.Close();

            }

            return pzas;
        }

        //---------------------------------------------------------------------
        //--------------------REGISTRAR ENTREGA ACTUALIZAR COLUMNA CANTIDAD Y ASIGNAR CVE DE ENTREGA CON FECHA--------------------

        public string Registrar_Entrega(string cve_siniestro, int cve_pedido, int cve_pieza, int cve_entrega, int cantidad, DateTime fecha, int cantidadE, int cve_factura, DateTime fecha_asignacion, DateTime fecha_promesa)
        {
            string mensaje = "ERROR AL HACER LA ENTREGA";


            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO ENTREGA (fecha_asignacion,fecha_promesa,fecha,cantidad,cve_pieza,cve_factura) VALUES (@fecha_asignacion,@fecha_promesa,@fecha,@cantidadE,@cve_pieza,@cve_factura)", nuevaConexion);
                comm.Parameters.Add("@fecha_asignacion", SqlDbType.Date);
                comm.Parameters.Add("@fecha_promesa",SqlDbType.Date);
                comm.Parameters.Add("@fecha", SqlDbType.Date);
                comm.Parameters.Add("@cantidadE", SqlDbType.Int);
                comm.Parameters.Add("@cve_pieza", SqlDbType.Int);
                comm.Parameters.Add("@cve_factura", SqlDbType.Int);
                comm.Parameters["@fecha_asignacion"].Value = fecha_asignacion;
                comm.Parameters["@fecha_promesa"].Value = fecha_promesa;
                comm.Parameters["@fecha"].Value = fecha;
                comm.Parameters["@cantidadE"].Value = cantidadE;
                comm.Parameters["@cve_pieza"].Value = cve_pieza;
                comm.Parameters["@cve_factura"].Value = cve_factura;
                comm.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand(string.Format("UPDATE PEDIDO SET cve_entrega = {0}, pzas_entregadas = {1}, fecha_entrega = '{2}' WHERE cve_siniestro = '{3}' AND cve_pedido = {4} AND cve_pieza = {5}",cve_entrega, cantidad,fecha, cve_siniestro, cve_pedido, cve_pieza), nuevaConexion);
                cmd.ExecuteNonQuery();
                nuevaConexion.Close();
                mensaje = "ENTREGA EXITOSA";
            }

            return mensaje;
        }

        //---------------------------------------------------------------------
        //--------------------OBTENGO LAS PIEZAS ENTREGADAS DE ESE SINIESTRO, PEDIDO CON WHERE EN PIEZA--------------------

        public int Pzas_Entregadas(string cve_siniestro, int cve_pedido, int cve_pieza)
        {

            int pzas;

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand comm = new SqlCommand(string.Format("SELECT pzas_entregadas FROM PEDIDO WHERE cve_siniestro = '{0}' AND cve_pedido = {1} AND cve_pieza = {2}",cve_siniestro,cve_pedido,cve_pieza), nuevaConexion);
                if (comm.ExecuteScalar().ToString() == string.Empty)
                { pzas = 0; }
                else { pzas = (Int32)comm.ExecuteScalar(); }

                nuevaConexion.Close();
                
            }

            return pzas;
        }

        //---------------------------------------------------------------------
        //--------------------OBTENER DATOS DE LA TABLA ENTREGA--------------------

        public DataTable Tabla_Entrega(int cve_factura)
        {

            DataTable dt = new DataTable();

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT ped.cve_siniestro AS SINIESTRO,ped.cve_vendedor AS VENDEDOR, ped.cve_pedido AS PEDIDO,val.cve_nombre AS VALUADOR,c.cve_nombre AS CLIENTE, pie.cve_nombre AS PIEZA, ent.cantidad AS CANTIDAD, ent.fecha AS FECHA, ent.cve_factura AS FACTURA FROM ENTREGA ent JOIN PEDIDO ped ON ped.cve_factura = ent.cve_factura JOIN VALUADOR val ON val.cve_valuador = ped.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = ped.cve_pieza WHERE ent.cve_factura = {0}",cve_factura), nuevaConexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                nuevaConexion.Close();
            }

            return dt;
        }

        //---------------------------------------------------------------------
        //--------------------OBTENER DATOS DE LA TABLA ENTREGA--------------------

        public DataTable Tabla_Devolucion(int cve_factura)
        {

            DataTable dt = new DataTable();

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT ped.cve_siniestro AS SINIESTRO, ped.cve_vendedor AS VENDEDOR, ped.cve_pedido AS PEDIDO, val.cve_nombre AS VALUADOR, c.cve_nombre AS CLIENTE, pie.cve_nombre AS PIEZA, dev.cantidad AS CANTIDAD, dev.fecha AS FECHA, dev.cve_factura AS FACTURA FROM DEVOLUCION dev JOIN PEDIDO ped ON ped.cve_factura = dev.cve_factura JOIN VALUADOR val ON val.cve_valuador = ped.cve_valuador JOIN CLIENTE c ON c.cve_valuador = val.cve_valuador JOIN PIEZA  pie ON pie.cve_pieza = ped.cve_pieza WHERE dev.cve_factura = {0}", cve_factura), nuevaConexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                nuevaConexion.Close();
            }

            return dt;
        }

        //---------------------------------------------------------------------
        //--------------------ACTUALIZAR FACTURA (OBTENER DATOS.)--------------------

        public DataTable Actualizar_Factura(int cve_factura)
        {

            DataTable dt = new DataTable();

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {

                nuevaConexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM FACTURA WHERE cve_factura = {0}", cve_factura), nuevaConexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                nuevaConexion.Close();
            }

            return dt;
        }

        //---------------------------------------------------------------------
        //--------------------ACTUALIZAR FACTURA (UPDATE)--------------------

        public string Actualizar_Factura(int cve_factura, int cve_estado, decimal fact_sinIVA, decimal fact_neto, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
        {
            string mensaje = "Se Actualizo Correctamente";
            

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                SqlCommand cmd;
                nuevaConexion.Open();
                if (archivo == null && archivo_xml == null)
                {
                    cmd = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
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
                    cmd = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,nombre_factura = @nombre_factura,archivo = @archivo,nombre_xml = @nombre_xml,archivo_xml = @archivo_xml,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
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
             
                nuevaConexion.Close();
            }

            return mensaje;
        }
        //--------------------ACTUALIZAR REFACTURA (UPDATE)--------------------

        public string Actualizar_Refactura(int cve_factura, int cve_estado, int cve_refactura, decimal fact_sinIVA, decimal fact_neto, decimal costo_refactura, DateTime fecha_refactura, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura, byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
        {
            string mensaje = "Se Actualizo Correctamente";
            

            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                SqlCommand cmd;
                nuevaConexion.Open();

                if(archivo == null && archivo_xml == null)
                {
                    cmd = new SqlCommand("UPDATE FACTURA SET cve_refactura = @cve_refactura,cve_estado = @cve_estado,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,costo_refactura = @costo_refactura,fecha_refactura = @fecha_refactura,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_refactura", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_refactura", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                    cmd.Parameters["@cve_factura"].Value = cve_factura;
                    cmd.Parameters["@cve_estado"].Value = cve_estado;
                    cmd.Parameters["@cve_refactura"].Value = cve_refactura;
                    cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    cmd.Parameters["@fact_neto"].Value = fact_neto;
                    cmd.Parameters["@costo_refactura"].Value = costo_refactura;
                    cmd.Parameters["@fecha_refactura"].Value = fecha_refactura;
                    cmd.Parameters["@fecha_ingreso"].Value = fecha_ingreso;
                    cmd.Parameters["@fecha_revision"].Value = fecha_revision;
                    cmd.Parameters["@fecha_pago"].Value = fecha_pago;
                    cmd.Parameters["@comentario"].Value = comentario;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("UPDATE FACTURA SET cve_estado = @cve_estado,cve_refactura = @cve_refactura,fact_sinIVA = @fact_sinIVA,fact_neto = @fact_neto,costo_refactura = @costo_refactura,fecha_refactura = @fecha_refactura,fecha_ingreso = @fecha_ingreso,fecha_revision = @fecha_revision,fecha_pago = @fecha_pago,nombre_factura = @nombre_factura,archivo = @archivo,nombre_xml = @nombre_xml,archivo_xml = @archivo_xml,comentario = @comentario WHERE cve_factura = @cve_factura", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    cmd.Parameters.Add("@cve_refactura", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@costo_refactura", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_refactura", SqlDbType.Date);
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
                    cmd.Parameters["@cve_refactura"].Value = cve_refactura;
                    cmd.Parameters["@fact_sinIVA"].Value = fact_sinIVA;
                    cmd.Parameters["@fact_neto"].Value = fact_neto;
                    cmd.Parameters["@costo_refactura"].Value = costo_refactura;
                    cmd.Parameters["@fecha_refactura"].Value = fecha_refactura;
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
               
                nuevaConexion.Close();
            }

            return mensaje;
        }

        //---------------------------------------------------------------------
        //---------------------------OBTENER CLAVE DE FACTURA-------------------
        public int Clave_Fact(string siniestro, int cve_pedido)
        {
            int cve_factura = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand(string.Format("SELECT cve_factura FROM PEDIDO WHERE cve_siniestro = '{0}' AND cve_pedido = {1}", siniestro, cve_pedido), nuevaConexion);
                    cve_factura = (Int32)Comando.ExecuteScalar();
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cve_factura;
        }
    }
}
//TEST TEAM EXPLORER 