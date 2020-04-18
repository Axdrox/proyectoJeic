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
                    Comando = new SqlCommand(string.Format("select Usuario,Contraseña from Administradores where Usuario= '{0}' AND dbo.fnDescifraClave(Contraseña)= '{1}';", user, password), nuevaConexion);
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

        //---------------- VEHICULOS-REGISTRADOS
        public DataSet VehiculosRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT modelo FROM VEHICULO", nuevaConexion);
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

        //-------------OBTENER  AÑO A PARTIR DEL VEHÍCULO
        public string anioVehiculo(string modelo){
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion()){
                    nuevaConexion.Open();
                    //cambiar por anio
                    Comando = new SqlCommand("SELECT año FROM VEHICULO WHERE modelo = @modelo", nuevaConexion);
                    Comando.Parameters.AddWithValue("@modelo", modelo.Trim());
                    Lector = Comando.ExecuteReader();
                    if (Lector.Read())
                    {
                        anio = Lector["año"].ToString().Trim();
                    }
                    Lector.Close();
                    nuevaConexion.Close();
                }
            }
            catch (Exception EX){
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }



    }
}
