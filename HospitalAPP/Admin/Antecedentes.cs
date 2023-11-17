using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAPP.Admin
{
    public class Antecedentes 
    {
        public int IdAntecedente { get; set; }
        public String Cirugia { get; set; }
        public String Alergia { get; set; }
        public String Enfermedad { get; set; }
        public  int IdHistorial { get; set; }

        public Antecedentes()
        {

        }
        public Antecedentes(int idAntecedente, string cirugia, string alergia, string enfermedad, int idHistorial)
        {
            IdAntecedente = idAntecedente;
            Cirugia = cirugia;
            Alergia = alergia;
            Enfermedad = enfermedad;
            IdHistorial = idHistorial;
        }
    }
}
