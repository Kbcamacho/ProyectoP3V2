using Logica.LCitas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using HospitalAPP;
using static Datos.DUsuarios;

namespace Logica.LPacientes
{
    public class L_Paciente
    {
        public static DataTable Mostrar(string cTexto)
        {
            DUsuarios Datos = new DUsuarios();
            return Datos.Mostrar(cTexto);
        }

        public static string Guardar(Paciente oPa)
        {
            DUsuarios Datos = new DUsuarios();
            return Datos.Guardar(oPa);


        }



        public class BusinessLayer
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();

            public bool AuthenticateUser(string username, string password)
            {
                // Lógica de autenticación
                return dataAccessLayer.AuthenticateUser(username, password);
            }
        }
    }
}   
