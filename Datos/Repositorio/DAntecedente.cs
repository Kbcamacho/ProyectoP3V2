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
    public class DAntecedente
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
                OracleCommand Comando = new OracleCommand("select * from VISTA_ANTECEDENTE where ID_ANTECEDENTE like '" + cTexto + "' ", SqlCon);
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
        public string Actualizar(Antecedentes oAn)
        {
            string Rpta = "";
            string IdCi;
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_ACTUALIZAR_ANT", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_antecedente", OracleDbType.Int32).Value = oAn.IdAntecedente; // Parámetro de salida para el ID de la cita
                Comando.Parameters.Add("pcirugia", OracleDbType.Varchar2).Value = oAn.Cirugia;
                Comando.Parameters.Add("pAlergia", OracleDbType.Varchar2).Value = oAn.Alergia;
                Comando.Parameters.Add("pEnfermedad", OracleDbType.Varchar2).Value = oAn.Enfermedad;
                Comando.Parameters.Add("pId_historial", OracleDbType.Int32).Value = oAn.IdHistorial;



                SqlCon.Open();
                Comando.ExecuteNonQuery();
                IdCi = Convert.ToString(oAn.IdAntecedente);
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
                OracleCommand Comando = new OracleCommand("USP_ELIMINAR_ANT", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pId_antecedente", OracleDbType.Int32).Value = idCi;
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

        public string Guardar(Antecedentes oAn)
        {
            string Rpta = "";
            string recibe;
            OracleConnection SqlCon = new OracleConnection();
            try
            {
                SqlCon = ConexionBD.GetInstancia().CrearConexion();
                OracleCommand Comando = new OracleCommand("USP_GUARDAR_ANT", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Comando.Parameters.Add("pId_Cita", OracleDbType.Int32).Value = oCi.Id_Cita;
                Comando.Parameters.Add("pId_antecedente", OracleDbType.Int32).Value = oAn.IdAntecedente; 
                Comando.Parameters.Add("pcirugia", OracleDbType.Varchar2).Value = oAn.Cirugia;
                Comando.Parameters.Add("pAlergia", OracleDbType.Varchar2).Value = oAn.Alergia;
                Comando.Parameters.Add("pEnfermedad", OracleDbType.Varchar2).Value = oAn.Enfermedad;
                Comando.Parameters.Add("pId_historial", OracleDbType.Int32).Value = oAn.IdHistorial;



                SqlCon.Open();
                Comando.ExecuteNonQuery();

                //Obtener el valor del ID de la cita generado
                recibe = Convert.ToString(Comando.Parameters["pId_antecedente"].Value);
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

    }
}    
 
