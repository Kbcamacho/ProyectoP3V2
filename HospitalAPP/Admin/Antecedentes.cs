using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAPP.Admin
{
    public class Antecedentes 
    {
        public String IdAntecedente { get; set; }
        public String Cirugia { get; set; }
        public String Alergia { get; set; }
        public String Enfermedad { get; set; }
        public HistorialMedico HistorialMedico { get; set; }

        public Antecedentes()
        {

        }
        public Antecedentes(String idAntecedente, String cirugia, String alergia, String enfermedad, HistorialMedico historialMedico)
        {
            IdAntecedente = idAntecedente;
            Cirugia = cirugia;
            Alergia = alergia;
            Enfermedad = enfermedad;
            this.HistorialMedico = historialMedico;
        }
    }
}
