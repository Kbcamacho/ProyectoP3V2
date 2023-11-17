using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Repositorio;
using HospitalAPP;

namespace Logica.LCitas
{
    public class L_Citas
    {
        public static DataTable Mostrar(string cTexto)
        {
            DCitas Datos = new DCitas();
            return Datos.Mostrar(cTexto);
        }

        public static string Guardar(Cita oCi)
        {
            DCitas Datos = new DCitas();
            return Datos.Guardar(oCi);
        }

        public static string Actualizar(Cita oCi)
        {
            DCitas Datos = new DCitas();
            return Datos.Actualizar(oCi);
        }
        public static string Eliminar(int IdCi)
        {
            DCitas Datos = new DCitas();
            return Datos.Eliminar(IdCi);
        }
        public static DataTable listado_IdDo()
        {
            DCitas Datos = new DCitas();
            return Datos.listado_IdDo();
        }

        public static DataTable listado_Do()
        {
            DCitas Datos = new DCitas();
            return Datos.listado_Do();
        }
    }
}
