using HospitalAPP;
using Logica.LCitas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPrinc
{
    public partial class GrillCitas : Form
    {
        public GrillCitas()
        {
            InitializeComponent();

        }
        int nCodigo_pr = 0;
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GrillCitas_Load(object sender, EventArgs e)
        {
            Listado_Do();
            Listado_IdDo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Guardar();
            Validaciones();
        }

        private void Guardar()
        {
            if (txtCedula.Text == string.Empty || CmbCedulaDoctor.Text == string.Empty || dtpFechaCita.Text == string.Empty || CmbHoraCita.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Guardamos la Informacion
            {
                    Cita oCi = new Cita();
                    string Rpta = "";
                    oCi.IdCita = nCodigo_pr;
                    oCi.FechaCita = DateTime.Parse(dtpFechaCita.Text);
                    oCi.HoraCita = Convert.ToString(CmbHoraCita.Text); 
                    oCi.IdPaciente = Convert.ToString(txtCedula.Text); 
                    oCi.IdDoctor = Convert.ToString(CmbCedulaDoctor.SelectedValue);
                    oCi.MedicoAsignado = Convert.ToString(CmbNombreDoctor.SelectedValue);
                

                    //L_Citas.GuardarCita_Servicios(serviciosSeleccionados);
                    Rpta = L_Citas.Guardar(oCi);
                    if (Rpta == "OK")
                    {
                        Mostrar("%");
                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



            }

        }
        public void Validaciones()
        {

        }

        private void Mostrar(string cTexto)
        {
            try
            {

                dataGridView1.DataSource = L_Citas.Mostrar(cTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listado_Do()
        {
            L_Citas Logica = new L_Citas();
            CmbNombreDoctor.DataSource = L_Citas.listado_Do();
            CmbNombreDoctor.ValueMember = "Nombres";
            CmbNombreDoctor.DisplayMember = "Nombre";
        }
        private void Listado_IdDo()
        {
            L_Citas Logica = new L_Citas();
            CmbCedulaDoctor.DataSource = L_Citas.listado_IdDo();
            CmbCedulaDoctor.ValueMember = "Cedula";
            CmbCedulaDoctor.DisplayMember = "Id_doctor";
        }
    }
}