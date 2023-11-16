﻿using Logica.LCitas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using HospitalAPP;
using static Datos.DUsuarios;

namespace Logica.LPacientes
{
    public class L_Paciente
    {
        public static DataTable Mostrar(string cTexto)
        {
            DUsuarios Datos = new DUsuarios();
            return Datos.Mostrar(cTexto);
        }

        public static string Guardar(Paciente oPa)
        {
            if (Exist(oPa))
            {
                return "ID Repetido";
            }
            else
            {
                DUsuarios Datos = new DUsuarios();
                return Datos.Guardar(oPa);
            }

        }
        public static bool Exist(Paciente oPa)
        {
            try
            {
                DataTable dataTable = Mostrar("%");

                foreach (DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);

                    if (id == int.Parse(oPa.Cedula))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string Actualizar(Paciente NewPaciente, string Cedula)
        {
            String PacienteOld;
            DataTable dataTable = Mostrar("%");
            DataRow[] rows = dataTable.Select($"CEDULA = '{Cedula}'");

            if (dataTable.Rows.Count == 0)
            {
                return "Lista vacía";
            }
            else if (rows.Length == 0)
            {
                return "No se encontró el ID";
            }
            else if (Exist(NewPaciente) && NewPaciente.Cedula != (Cedula))
            {
                return "El cliente ingresado ya existe";
            }
            else
            {
                //E_Clientes cliente_old = new E_Clientes;
                //DataRow row = rows[0];
                //row["Id"] = cliente_new.Id;
                //row["Nombre"] = cliente_new.Nombre;
                //row["Apellido"] = cliente_new.Apellido;
                //row["Telefono"] = cliente_new.Telefono;
                //row["Correo"] = cliente_new.Correo;

                PacienteOld = Cedula;
                DUsuarios Datos = new DUsuarios();
                return Datos.Actualizar(NewPaciente, Cedula);
            }



        }



        public class BusinessLayer
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer();

            public bool AuthenticateUser(string username, string password)
            {
                // Lógica de autenticación
                return dataAccessLayer.AuthenticateUser(username, password);
            }
        }
    }
}   
