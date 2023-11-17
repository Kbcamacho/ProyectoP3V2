using Datos.Repositorio;
using HospitalAPP;
using HospitalAPP.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.LHistorial
{
    public class L_Historial
    {
        public static DataTable Mostrar(string cTexto)
        {
            DHistorial Datos = new DHistorial();
            return Datos.Mostrar(cTexto);
        }
        public static string Guardar(HistorialMedico oHi)
        {
            DHistorial Datos = new DHistorial();
            return Datos.Guardar(oHi);
        }
        public static string Actualizar(HistorialMedico oHi)
        {
            DHistorial Datos = new DHistorial();
            return Datos.Actualizar(oHi);
        }
        public static string Eliminar(int IdCi)
        {
            DCitas Datos = new DCitas();
            return Datos.Eliminar(IdCi);
        }

    }
}
