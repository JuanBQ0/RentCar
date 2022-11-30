using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using Oracle.ManagedDataAccess.Client;
//using Oracle.DataAccess.Client;
//using System.Data.OracleClient;

namespace Datos
{
    public class ConexionBD 
    {
        private static ConexionBD Con = null;
        protected OracleConnection conexion;
        protected string cadenaConexion;
        
        public ConexionBD()
        {
            string cadenaConexion = String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=juan;Password=juan;");


            conexion = new OracleConnection(cadenaConexion);

        }

        public string AbrirConnexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                CerrarConnexion();
            }
            conexion.Open();
            return conexion.State.ToString();
        }
        public void CerrarConnexion()
        {
            conexion.Close();
        }

        public static ConexionBD GetInstancia()
        {
            if (Con == null)
            {
                Con = new ConexionBD();
            }
            return Con;
        }

        

    }
}
