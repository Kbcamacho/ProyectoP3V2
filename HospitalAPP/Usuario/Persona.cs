using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAPP
{
    public class Persona
    {
        public Persona()
        {

        }

        public String Cedula { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Sexo { get; set; }
        public String CorreoElectronico { get; set; }


        public Persona(string cedula, string password, string nombre, string apellido, string telefono, DateTime fechaNacimiento,
            string sexo, string correoElectronico)
        {
            Cedula = cedula;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            CorreoElectronico = correoElectronico;

 
        }
    }
}
