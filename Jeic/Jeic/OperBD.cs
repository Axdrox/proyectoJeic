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

        //---------------- ASEGURADORAS REGISTRADAS
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

                    Comando = new SqlCommand("SELECT cve_nombre FROM VALUADOR WHERE cve_valuador = @cve_valuador", nuevaConexion);
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

        //---------------- NOMBRES DE PIEZAS REGISTRADOS
        public DataSet NombrePiezasRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_nombre FROM PIEZA", nuevaConexion);
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

        //---------------- PROVEEDORES REGISTRADOS
        public DataSet ProveedoresRegistrados()
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cve_nombre FROM PROVEEDOR", nuevaConexion);
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

        //-------------OBTENER  AÑO A PARTIR DEL VEHÍCULO
        public string anioVehiculo(string modelo){
            string anio = "";
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion()){
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
            catch (Exception EX){
                MessageBox.Show("Error: " + EX.Message);
            }
            return anio;
        }

        //-------------INSERTAR DATOS EN VEHICULO
        public void registroVehiculo(string modelo, string anio){
            int i = 0;
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    Comando = new SqlCommand("INSERT INTO VEHICULO " + "(modelo, anio) " + "VALUES (@modelo, @anio) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("modelo", modelo);
                    Comando.Parameters.AddWithValue("anio", anio);

                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Se registró vehículo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception EX) {
                MessageBox.Show("Error: " + EX.Message);
            }
        }

        //-------------INSERTAR DATOS EN SINIESTRO
        public int registrarSiniestro(string modelo, string claveSiniestro, string comentario){
            int i = 0;
            try {
                using (SqlConnection nuevaConexion = Conexion.conexion()) {
                    int claveVehiculo = 0;

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

                    //Insertando los datos en la tabla SINIESTRO
                    Comando = new SqlCommand("INSERT INTO SINIESTRO " + "(cve_siniestro, cve_vehiculo, comentario) " + "VALUES (@cve_siniestro, @cve_vehiculo, @comentario) ", nuevaConexion);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro.Trim());
                    Comando.Parameters.AddWithValue("@cve_vehiculo", claveVehiculo);
                    Comando.Parameters.AddWithValue("comentario", comentario.Trim());
                    
                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
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

    }
}
