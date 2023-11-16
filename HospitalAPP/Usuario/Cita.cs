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
        public String IdCita { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime FechaCita { get; set; }

        public DateTime HoraCita { get; set; }

        public Cita()
        {

        }

        public Cita(String idCita, Paciente paciente, Doctor doctor, DateTime fechaCita, DateTime horaCita)
        {
            IdCita = idCita;
            Paciente = paciente;
            Doctor = doctor;
            FechaCita = fechaCita;
            HoraCita = horaCita;
        }
    }
}
