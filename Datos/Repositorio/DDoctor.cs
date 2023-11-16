using HospitalAPP;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class DDoctor
    {
        public DataTable Mostrar(string cTexto)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                cTexto = "%" + cTexto + "%";
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("select * from VISTA_DOCTOR where Id_doctor like '" + cTexto + "' ", SqlCon);
                Comando.CommandType = CommandType.Text;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public string Guardar(Doctor oDc)
        {
            string Rpta = "";
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_GUARDAR_PA", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_doctor", OracleDbType.Varchar2).Value = oDc.Cedula;
                Comando.Parameters.Add("pSexo", OracleDbType.Varchar2).Value = oDc.Sexo;
                Comando.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = oDc.Nombre;
                Comando.Parameters.Add("pApellido", OracleDbType.Varchar2).Value = oDc.Apellido;
                Comando.Parameters.Add("pCorreo", OracleDbType.Varchar2).Value = oDc.CorreoElectronico;
                Comando.Parameters.Add("pFecha_nacimiento", OracleDbType.Date).Value = oDc.FechaNacimiento;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";


            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(Doctor oDc, string Cedula)
        {
            string Rpta = "";
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_ACTUALIZAR_DOC", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_doctor", OracleDbType.Varchar2).Value = Cedula;
                Comando.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = oDc.Nombre;
                Comando.Parameters.Add("pApellido", OracleDbType.Varchar2).Value = oDc.Apellido;
                Comando.Parameters.Add("pSexo", OracleDbType.Varchar2).Value = oDc.Sexo;
                Comando.Parameters.Add("pFnacimiento", OracleDbType.Date).Value = oDc.FechaNacimiento;
                Comando.Parameters.Add("pCorreo", OracleDbType.Varchar2).Value = oDc.CorreoElectronico;
                Comando.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = oDc.Telefono;
                Comando.Parameters.Add("pPassword", OracleDbType.Varchar2).Value = oDc.Password;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";


            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar(string Cedula)
        {
            string Rpta = "";
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_ELIMINAR_DOC", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_paciente", OracleDbType.Varchar2).Value = Cedula;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public class DataAccessLayerDoctor
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=KliverGod)" +
                                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)))" +
                                          ";User Id=CLINICA;Password=1234;";


            public bool AuthenticateUser(string username1, string password1)
            {

                OracleConnection SqlCon = ConexionBD.GetInstancia().CrearConexion();

                using (SqlCon)
                {
                    SqlCon.Open();

                    string query = "SELECT COUNT(*) FROM DOCTOR WHERE ID_DOCTOR = :username1 AND PASSWORD = :password1";

                    using (OracleCommand command = new OracleCommand(query, SqlCon))
                    {
                        command.Parameters.Add(new OracleParameter(":username1", username1));
                        command.Parameters.Add(new OracleParameter(":password1", password1));

                        int count = Convert.ToInt32(command.ExecuteScalar());


                        return count > 0;
                    }
                }
            }

        }
    }
}

