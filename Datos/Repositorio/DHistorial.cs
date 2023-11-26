using HospitalAPP;
using HospitalAPP.Admin;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class DHistorial
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
                OracleCommand Comando = new OracleCommand("select * from VISTA_HISTORIALMEDICO where ID_PACIENTE like '" + cTexto + "' ", SqlCon);
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
        public string Guardar(HistorialMedico oHi)
        {
            string Rpta = "";
            string recibe;
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_GUARDAR_HIS", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Comando.Parameters.Add("pId_Cita", OracleDbType.Int32).Value = oCi.Id_Cita;
                Comando.Parameters.Add("pId_historial", OracleDbType.Int32).Value = oHi.IdHistorial; // Parámetro de salida para el ID de la cita
                Comando.Parameters.Add("pId_paciente", OracleDbType.Varchar2).Value = oHi.Id_usuario;
                Comando.Parameters.Add("pRecomendacion", OracleDbType.Varchar2).Value = oHi.Recomendacion;
                Comando.Parameters.Add("pObservacion", OracleDbType.Varchar2).Value = oHi.Observacion;
                Comando.Parameters.Add("pIndicacion", OracleDbType.Varchar2).Value = oHi.Indicacion;
                Comando.Parameters.Add("pClasificacion", OracleDbType.Varchar2).Value = oHi.Clasificacion;
                Comando.Parameters.Add("pMotivo", OracleDbType.Varchar2).Value = oHi.Motivo;
                Comando.Parameters.Add("pHallazgo", OracleDbType.Varchar2).Value = oHi.Hallazgo;
                Comando.Parameters.Add("pFecha_creacion", OracleDbType.Date).Value = oHi.FechaCreacion;
                Comando.Parameters.Add("pDiagnostico", OracleDbType.Varchar2).Value = oHi.Diagnostico;
                SqlCon.Open();
                Comando.ExecuteNonQuery();

                //Obtener el valor del ID de la cita generado
                recibe = Convert.ToString(Comando.Parameters["pId_historial"].Value);
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
        public string Actualizar(HistorialMedico oHi)
        {
            string Rpta = "";
            string IdCi;
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_ACTUALIZAR_HIS", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_historial", OracleDbType.Int32).Value = oHi.IdHistorial;
                Comando.Parameters.Add("pId_paciente", OracleDbType.Varchar2).Value = oHi.Id_usuario;
                Comando.Parameters.Add("pRecomendacion", OracleDbType.Varchar2).Value = oHi.Recomendacion;
                Comando.Parameters.Add("pObservacion", OracleDbType.Varchar2).Value = oHi.Observacion;
                Comando.Parameters.Add("pIndicacion", OracleDbType.Varchar2).Value = oHi.Indicacion;
                Comando.Parameters.Add("pClasificacion", OracleDbType.Varchar2).Value = oHi.Clasificacion;
                Comando.Parameters.Add("pMotivo", OracleDbType.Varchar2).Value = oHi.Motivo;
                Comando.Parameters.Add("pHallazgo", OracleDbType.Varchar2).Value = oHi.Hallazgo;
                Comando.Parameters.Add("pFecha_creacion", OracleDbType.Date).Value = oHi.FechaCreacion;
                Comando.Parameters.Add("pDiagnostico", OracleDbType.Varchar2).Value = oHi.Diagnostico;



                SqlCon.Open();
                Comando.ExecuteNonQuery();
                IdCi = Convert.ToString(oHi.IdHistorial);
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
                OracleCommand Comando = new OracleCommand("USP_ELIMINAR_HIS", SqlCon);
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

