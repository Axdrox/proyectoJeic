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
                    nuevaConexion.Close();
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

        //-------------INSERTAR DATOS EN ENTREGA (FECHAS)
        public void registrarEntrega(DateTime fechaAsignacion, DateTime fechaPromesa)
        {
            try
            {
                using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                    nuevaConexion.Open();
                    //Agregando los datos a la tabla ENTREGA
                    Comando = new SqlCommand("INSERT INTO ENTREGA " + "(fecha_asignacion, fecha_promesa) " + "VALUES (@fecha_asignacion, @fecha_promesa) ", nuevaConexion);
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

        public int claveTaller(string taller)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveTaller = 0;
                //Obteniendo la clave del taller
                //Combobox de pedido
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

        public int claveValuador(string valuador)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveValuador = 0;
                //Obteniendo la clave del valuador
                //Combobox de pedido
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

        public int claveCostoEnvio(string costoEnvio)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveCostoEnvio = 0;
                //Obteniendo la clave del costo de envío
                //Combobox de pedido
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

        public int claveDestino(string destino)
        {
            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int claveDestino = 0;
                //Obteniendo la clave del destino
                //Combobox de pedido
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


        //-------------INSERTAR DATOS DE PEDIDO
        public int registrarPedido(int clavePedido, string claveSiniestro, string nombrePieza, string portal, string taller, string origen, string proveedor, int claveVendedor, DateTime fechaCosto, string costoSinIVA, string costoNeto, string costoEnvio, string precioVenta, string precioReparacion, string claveProducto, string numeroGuia, int cantidad, int diasEntrega, string entregaTiempo, DateTime fechaBaja, string valuador, string destino)
        {
            //Variables
            int i = 0;

            //try
            //{
            int cve_pieza = clavePieza(nombrePieza);
            int cve_origen = claveOrigen(origen);
            int cve_proveedor = claveProveedor(proveedor);
            int cve_portal = clavePortal(portal);
            int cve_taller = claveTaller(taller);
            int cve_valuador = claveValuador(valuador);
            int cve_destino = claveDestino(destino);
            int cve_costoEnvio = claveCostoEnvio(costoEnvio);
            //int cve_entrega = Total_Registros2(); //codigo Bryan

            using (SqlConnection nuevaConexion = Conexion.conexion())
                {
                //Obteniendo la clave del vendedor
                //Obtener del combobox

                //cve_guia & cve_producto:  obtener del DGV
                

                    nuevaConexion.Open();
                    //Insertando los datos en la tabla PEDIDO
                    Comando = new SqlCommand("INSERT INTO PEDIDO " + "(cve_pedido, cve_siniestro, cve_pieza, cantidad, cve_origen, cve_proveedor, cve_vendedor, cve_portal, cve_taller, cve_valuador, cve_guia, cve_producto, fecha_baja, fecha_costo, costo_comprasinIVA, costo_envio, costo_neto, precio_venta, precio_reparacion, destino, dias_entrega, entrega_enTiempo) " +
                        "VALUES (@cve_pedido, @cve_siniestro, @cve_pieza, @cantidad, @cve_origen, @cve_proveedor, @cve_vendedor, @cve_portal, @cve_taller, @cve_valuador, @cve_guia, @cve_producto, @fecha_baja, @fecha_costo, @costo_comprasinIVA, @costo_envio, @costo_neto, @precio_venta, @precio_reparacion, @destino, @dias_entrega, @entrega_enTiempo) ", nuevaConexion);
                    //Añadiendo los parámetros al query
                    Comando.Parameters.AddWithValue("@cve_pedido", clavePedido);
                    Comando.Parameters.AddWithValue("@cve_siniestro", claveSiniestro);
                    Comando.Parameters.AddWithValue("@cve_pieza", cve_pieza);
                    Comando.Parameters.AddWithValue("@cantidad", cantidad);
                    Comando.Parameters.AddWithValue("@cve_origen", cve_origen);
                    Comando.Parameters.AddWithValue("@cve_proveedor", cve_proveedor);
                    Comando.Parameters.AddWithValue("@cve_vendedor", claveVendedor);
                    Comando.Parameters.AddWithValue("@cve_portal", cve_portal);
                    Comando.Parameters.AddWithValue("@cve_taller", cve_taller);
                    Comando.Parameters.AddWithValue("@cve_valuador", cve_valuador);
                    Comando.Parameters.AddWithValue("@cve_guia", numeroGuia);
                    Comando.Parameters.AddWithValue("@cve_producto", claveProducto);
                    Comando.Parameters.AddWithValue("@fecha_baja", fechaBaja);
                    Comando.Parameters.AddWithValue("@fecha_costo", fechaCosto);
                    Comando.Parameters.AddWithValue("@costo_comprasinIVA", Convert.ToDecimal(costoSinIVA));
                    Comando.Parameters.AddWithValue("@costo_envio", cve_costoEnvio);//cambiar nombre de columna
                    Comando.Parameters.AddWithValue("@costo_neto", Convert.ToDecimal(costoNeto));
                    Comando.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(precioVenta));
                    Comando.Parameters.AddWithValue("@precio_reparacion", Convert.ToDecimal(precioReparacion));
                    Comando.Parameters.AddWithValue("@destino", cve_destino);
                    Comando.Parameters.AddWithValue("@dias_entrega", diasEntrega);
                    Comando.Parameters.AddWithValue("@entrega_enTiempo", Convert.ToBoolean(entregaTiempo));
                    
                    //Para saber si la inserción se hizo correctamente
                    i = Comando.ExecuteNonQuery();
                    nuevaConexion.Close();
                    if (i == 1)
                        MessageBox.Show("Se registró siniestro correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Problemas al registar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            /*}
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message);
            }*/
            return i;
        }
    }
}
//TEAM EXPLORER