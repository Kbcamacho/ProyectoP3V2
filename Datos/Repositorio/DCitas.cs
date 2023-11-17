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
    public class DCitas
    {
        int IdCi;

        public DataTable Mostrar(string cTexto)
        {
            OracleDataReader Resultado;
            DataTable tabla = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                cTexto = "%" + cTexto + "%";
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("select * from VISTA_CITA where Paciente_id like '" + cTexto + "' ", SqlCon);
                Comando.CommandType = CommandType.Text;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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

        public DataTable listado_IdDo()
        {

            OracleDataReader Resultado;
            DataTable tabla = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("SELECT ID_DOCTOR AS Cedula FROM DOCTOR", SqlCon);
                Comando.CommandType = CommandType.Text;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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

        public DataTable listado_Do()
        {

            OracleDataReader Resultado;
            DataTable tabla = new DataTable();
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("SELECT Nombre AS Nombres FROM DOCTOR", SqlCon);
                Comando.CommandType = CommandType.Text;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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

        public string Guardar(Cita oCi)
        {
            string Rpta = "";
            string recibe;
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_GUARDAR_CI", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Comando.Parameters.Add("pId_Cita", OracleDbType.Int32).Value = oCi.Id_Cita;
                Comando.Parameters.Add("pId_Cita", OracleDbType.Int32).Value =oCi.IdCita; // Parámetro de salida para el ID de la cita
                Comando.Parameters.Add("pPaciente_id", OracleDbType.Varchar2).Value = oCi.IdPaciente;
                Comando.Parameters.Add("pDoctor_id", OracleDbType.Varchar2).Value = oCi.IdDoctor;
                Comando.Parameters.Add("pFecha_cita", OracleDbType.Date).Value = oCi.FechaCita;
                Comando.Parameters.Add("pHora_cita", OracleDbType.Varchar2).Value = oCi.HoraCita;
                Comando.Parameters.Add("pMedico_asignado", OracleDbType.Varchar2).Value = oCi.MedicoAsignado;
                


                SqlCon.Open();
                Comando.ExecuteNonQuery();

                //Obtener el valor del ID de la cita generado
                recibe = Convert.ToString(Comando.Parameters["pId_Cita"].Value);
                IdCi = Convert.ToInt32(recibe);
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

        public string Actualizar(Cita oCi)
        {
            string Rpta = "";
            string IdCi;
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_ACTUALIZAR_CI", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pCita_id", OracleDbType.Int32).Value = oCi.IdCita;
                Comando.Parameters.Add("pPaciente_id", OracleDbType.Varchar2).Value = oCi.IdPaciente;
                Comando.Parameters.Add("pDoctor_id", OracleDbType.Varchar2).Value = oCi.IdDoctor;
                Comando.Parameters.Add("pFecha_cita", OracleDbType.Date).Value = oCi.FechaCita;
                Comando.Parameters.Add("pHora_cita", OracleDbType.Date).Value = oCi.HoraCita;
                Comando.Parameters.Add("pMedico_asignado", OracleDbType.Varchar2).Value = oCi.MedicoAsignado;



                SqlCon.Open();
                Comando.ExecuteNonQuery();
                IdCi = Convert.ToString(oCi.IdCita);
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
        public string Eliminar(int idCi)
        {
            string Rpta = "";
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                SqlCon.Open();
                OracleCommand Comando = new OracleCommand("USP_ELIMINAR_CI", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_Cita", OracleDbType.Int32).Value = idCi;
                //SqlCon.Open();
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
}
