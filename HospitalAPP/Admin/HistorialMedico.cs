using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAPP.Admin
{
    public class HistorialMedico
    {
       public int IdHistorial { get; set; }
       public string Id_usuario { get; set; }
       public String Recomendacion { get; set; }
       public String Observacion { get; set; }
       public String Indicacion { get; set; }
       public String Clasificacion { get; set; }
       public String Motivo { get; set; }
       public String Hallazgo { get; set; }
       public DateTime FechaCreacion { get; set; }
       public String Diagnostico { get; set; }

        public HistorialMedico()
        {

        }

        public HistorialMedico(int idHistorial, string id_usuario, string recomendacion, string observacion, string indicacion, string clasificacion, string motivo, string hallazgo, DateTime fechaCreacion, string diagnostico)
        {
            IdHistorial = idHistorial;
            Id_usuario = id_usuario;
            Recomendacion = recomendacion;
            Observacion = observacion;
            Indicacion = indicacion;
            Clasificacion = clasificacion;
            Motivo = motivo;
            Hallazgo = hallazgo;
            FechaCreacion = fechaCreacion;
            Diagnostico = diagnostico;
        }
            
       
    }
    
}
