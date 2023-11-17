using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Cita
    {
        public int IdCita { get; set; }
        public string IdPaciente { get; set; }
        public string IdDoctor { get; set; }
        public DateTime FechaCita { get; set; }

        public string HoraCita { get; set; }
        public string MedicoAsignado { get; set; }

        public Cita()
        {

        }

        public Cita(int idCita, string idPaciente, string idDoctor, DateTime fechaCita, string horaCita, string medicoAsignado)
        {
            IdCita = idCita;
            IdPaciente = idPaciente;
            IdDoctor = idDoctor;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            MedicoAsignado = medicoAsignado;
        }
    
    }
}
