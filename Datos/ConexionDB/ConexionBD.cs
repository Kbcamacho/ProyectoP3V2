using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionBD
    {
        private static ConexionBD Con = null;

        public ConexionBD()
        {

        }

        // CREAR CONEXION A LA BASE DE DATOS 
        public OracleConnection CrearConexion()
        {
            OracleConnection conexion = new OracleConnection();
            try
            {
                conexion.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=KliverGod)" +
                                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)))" +
                                          ";User Id=CLINICA;Password=1234;";  // CAMBIAR    POR LA CONTRASEÑA DE LA BASE DE DATOS

            }
            catch (Exception ex) 
            {
                conexion = null;
                throw ex;
            }
            return conexion;
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
