using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAPP;

namespace HospitalAPP
{
    public class Doctor : Persona
    {

        public Doctor()
        {

        }

        public Doctor(String cedula, String password, String nombre, String apellido, String telefono, DateTime fechaNacimiento, String sexo, String correoElectronico) : base(cedula,password,nombre,apellido,telefono,
          fechaNacimiento,sexo,correoElectronico)
        {
            
        }
    }
}
