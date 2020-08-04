using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LIBRERIAS
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace Refracciones
{
    public class Conexion
    {
        public static SqlConnection conexion()
        {

            string strConexion = Jeic.Properties.Settings.Default.SecretMessage;//ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection nuevaConexion = new SqlConnection(strConexion);
            return nuevaConexion;
        }
    }
}
