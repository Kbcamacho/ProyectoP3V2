using HospitalAPP;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class DUsuarios
    {
        int Idpaciente;

        public DataTable Mostrar(string cTexto)
        {
            OracleDataReader Resultado;
            DataTable Tabla = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                cTexto = "%" + cTexto + "%";
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("select * from VISTA_PACIENTES where ID_PACIENTE like '" + cTexto + "' ", SqlCon);
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

        public string Guardar(Paciente oPa)
        {
            string Rpta = "";
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_GUARDAR_PA", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_paciente", OracleDbType.Varchar2).Value = oPa.Cedula;
                Comando.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = oPa.Nombre;
                Comando.Parameters.Add("pApellido", OracleDbType.Varchar2).Value = oPa.Apellido;
                Comando.Parameters.Add("pSexo", OracleDbType.Varchar2).Value = oPa.Sexo;
                Comando.Parameters.Add("pFnacimiento", OracleDbType.Date).Value = oPa.FechaNacimiento;
                Comando.Parameters.Add("pCorreo", OracleDbType.Varchar2).Value = oPa.CorreoElectronico;
                Comando.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = oPa.Telefono;
                Comando.Parameters.Add("pPASSWORD", OracleDbType.Varchar2).Value = oPa.Password;
                Comando.Parameters.Add("pTipoSangre", OracleDbType.Varchar2).Value = oPa.TipoSangre;
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

        public string Actualizar(Paciente oPa, string Cedula)
        {
            string Rpta = "";
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_ACTUALIZAR_PA", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_paciente", OracleDbType.Varchar2).Value = Cedula;
                Comando.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = oPa.Nombre;
                Comando.Parameters.Add("pApellido", OracleDbType.Varchar2).Value = oPa.Apellido;
                Comando.Parameters.Add("pSexo", OracleDbType.Varchar2).Value = oPa.Sexo;
                Comando.Parameters.Add("pFnacimiento", OracleDbType.Date).Value = oPa.FechaNacimiento;
                Comando.Parameters.Add("pCorreo", OracleDbType.Varchar2).Value = oPa.CorreoElectronico;
                Comando.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = oPa.Telefono;
                Comando.Parameters.Add("pPASSWORD", OracleDbType.Varchar2).Value = oPa.Password;
                Comando.Parameters.Add("pTipoSangre", OracleDbType.Varchar2).Value = oPa.TipoSangre;
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
                OracleCommand Comando = new OracleCommand("USP_ELIMINAR_PA", SqlCon);
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

    }
    public class DataAccessLayer
    {
        string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=KliverGod)" +
                                      "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xepdb1)))" +
                                      ";User Id=CLINICA;Password=1234;";


        public bool AuthenticateUser(string username, string password)
        {

            OracleConnection SqlCon = ConexionBD.GetInstancia().CrearConexion();

            using (SqlCon)
            {
                SqlCon.Open();

                string query = "SELECT COUNT(*) FROM PACIENTES WHERE Id_paciente = :username AND Password = :password";

                using (OracleCommand command = new OracleCommand(query, SqlCon))
                {
                    command.Parameters.Add(new OracleParameter(":username", username));
                    command.Parameters.Add(new OracleParameter(":password", password));

                    int count = Convert.ToInt32(command.ExecuteScalar());


                    return count > 0;
                }
            }
        }
    }
  }

    

