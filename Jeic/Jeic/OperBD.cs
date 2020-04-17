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
            if (us==usuario && pass==contra)
            {
                return 1;
            }
            else {
                return 0;
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

        public string Registrar_factura(string cve_factura, int cve_estado, decimal fact_sinIVA, decimal fact_neto, DateTime fecha_ingreso, DateTime fecha_revision, DateTime fecha_pago, string nombre_factura,byte[] archivo, string nombre_xml, byte[] archivo_xml, string comentario)
        {
            string mensaje = "Se inserto la factura";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlCommand cmd;
                    
                    
                    cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,cve_estado,fact_sinIVA,fact_neto,fecha_ingreso,fecha_revision,fecha_pago,nombre_factura,archivo,nombre_xml,archivo_xml,comentario) VALUES (@cve_factura,@cve_estado,@fact_sinIVA,@fact_neto,@fecha_ingreso,@fecha_revision,@fecha_pago,@nombre_factura,@archivo,@nombre_xml,@archivo_xml,@comentario)", nuevaConexion);
                    cmd.Parameters.Add("@cve_factura", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@cve_estado", SqlDbType.Int);
                    //cmd.Parameters.Add("@cve_refactura", SqlDbType.Int);
                    cmd.Parameters.Add("@fact_sinIVA", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fact_neto", SqlDbType.Decimal);
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_revision", SqlDbType.Date);
                    cmd.Parameters.Add("@fecha_pago", SqlDbType.Date);
                    cmd.Parameters.Add("@nombre_Factura", SqlDbType.NVarChar,100);
                    cmd.Parameters.Add("@archivo", SqlDbType.VarBinary);
                    cmd.Parameters.Add("@nombre_xml", SqlDbType.NVarChar,100);
                    cmd.Parameters.Add("@archivo_xml", SqlDbType.VarBinary);
                    cmd.Parameters.Add("@comentario", SqlDbType.NVarChar, 100);

                    cmd.Parameters["@cve_factura"].Value = cve_factura;
                    cmd.Parameters["@cve_estado"].Value = cve_estado;
                    //cmd.Parameters["@cve_refactura"].Value = cve_refactura;
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
                    nuevaConexion.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje = "No se inserto la factura: " + ex.ToString();
            }
            return mensaje;
        }

        //---------------------------------------------------------------------

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
    }
}
