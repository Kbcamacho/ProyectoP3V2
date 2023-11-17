using Datos.Repositorio;
using HospitalAPP;
using HospitalAPP.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.LAntecedente
{
    public class L_Antecedente
    {
        public static DataTable Mostrar(string cTexto)
        {
            DAntecedente Datos = new DAntecedente();
            return Datos.Mostrar(cTexto);
        }
        public static string Guardar(Antecedentes oAn)
        {
            DAntecedente Datos = new DAntecedente();
            return Datos.Guardar(oAn);
        }

        public static string Actualizar(Antecedentes oAn)
        {
            DAntecedente Datos = new DAntecedente();
            return Datos.Actualizar(oAn);
        }

        public static string Eliminar(int IdCi)
        {
            DAntecedente Datos = new DAntecedente();
            return Datos.Eliminar(IdCi);
        }
    }
}
