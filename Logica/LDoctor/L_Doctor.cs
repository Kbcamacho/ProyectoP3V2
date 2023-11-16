using Datos;
using Datos.Repositorio;
using HospitalAPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Datos.Repositorio.DDoctor;

namespace Logica.LDoctor
{
    public class L_Doctor
    {
        public static DataTable Mostrar(string cTexto)
        {
            DDoctor Datos = new DDoctor();
            return Datos.Mostrar(cTexto);
        }

        public static string Guardar(Doctor oDc)
        {
            if (Exist(oDc))
            {
                return "ID Repetido";
            }
            else
            {
                DDoctor Datos = new DDoctor();
                return Datos.Guardar(oDc);
            }
              
        }

        public static bool Exist(Doctor oPa)
        {
            try
            {
                DataTable dataTable = Mostrar("%");

                foreach (DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);

                    if (id == int.Parse(oPa.Cedula))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string Actualizar(Doctor NewDoctor, string Cedula)
        {
            String DoctorOld;
            DataTable dataTable = Mostrar("%");
            DataRow[] rows = dataTable.Select($"CEDULA = '{Cedula}'");

            if (dataTable.Rows.Count == 0)
            {
                return "Lista vacía";
            }
            else if (rows.Length == 0)
            {
                return "No se encontró el ID";
            }
            else if (Exist(NewDoctor) && NewDoctor.Cedula != (Cedula))
            {
                return "El cliente ingresado ya existe";
            }
            else
            {
                //E_Clientes cliente_old = new E_Clientes;
                //DataRow row = rows[0];
                //row["Id"] = cliente_new.Id;
                //row["Nombre"] = cliente_new.Nombre;
                //row["Apellido"] = cliente_new.Apellido;
                //row["Telefono"] = cliente_new.Telefono;
                //row["Correo"] = cliente_new.Correo;

                DoctorOld = Cedula;
                DDoctor Datos = new DDoctor();
                return Datos.Actualizar(NewDoctor, Cedula);
            }



        }
        //public class BusinessLayer
        //{
        //    DataAccessLayer dataAccessLayer = new DataAccessLayer();

        //    public bool AuthenticateUser(string username, string password)
        //    {
        //        // Lógica de autenticación
        //        return dataAccessLayer.AuthenticateUser(username, password);
        //    }
        //}

        public class BusinessLayerDoctor
        {
            DataAccessLayerDoctor dataAccessLayer = new DataAccessLayerDoctor();

            public bool AuthenticateUser(string username1, string password1)
            {
                // Lógica de autenticación
                return dataAccessLayer.AuthenticateUser(username1, password1);
            }
        }
    }
}
