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
       public String IdHistorial { get; set; }
       public Paciente Cedula { get; set; }
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

        public HistorialMedico(String idHistorial, Paciente cedula, String recomendacion, String observacion, String indicacion, 
            String clasificacion, String motivo, String hallazgo, DateTime fechaCreacion, String diagnostico)
        {
            IdHistorial = idHistorial;
            Cedula = cedula;
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
