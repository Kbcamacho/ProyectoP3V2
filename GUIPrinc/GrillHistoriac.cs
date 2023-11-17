using HospitalAPP;
using HospitalAPP.Admin;
using Logica.LCitas;
using Logica.LHistorial;
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
    public partial class GrillHistoriac : Form
    {
        public GrillHistoriac()
        {
            InitializeComponent();
        }
        int nCodigo_pr = 0;
        int IdCi;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GrillHistoriac_Load(object sender, EventArgs e)
        {
            MostrarHistorial("%");
        }
        private void MostrarHistorial(string cTexto)
        {
            try
            {

                dataGridView1.DataSource = L_Historial.Mostrar(cTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Guardar()
        {
            if (txtPacID.Text == string.Empty || txtRecom.Text == string.Empty || txtObser.Text == string.Empty || txtIndic.Text == string.Empty || txtClasif.Text == string.Empty || txtMotiv.Text == string.Empty || txtHallaz.Text == string.Empty || txtIndic.Text == string.Empty || dtpFechaHistorial.Text == string.Empty || txtDiag.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Guardamos la Informacion
            {
                HistorialMedico oHi = new HistorialMedico();
                string Rpta = "";
                oHi.IdHistorial = nCodigo_pr;
                oHi.Id_usuario = Convert.ToString(txtPacID.Text);
                oHi.Recomendacion = Convert.ToString(txtRecom.Text);
                oHi.Observacion = Convert.ToString(txtObser.Text);
                oHi.Indicacion = Convert.ToString(txtIndic.Text);
                oHi.Clasificacion = Convert.ToString(txtClasif.Text);
                oHi.Motivo = Convert.ToString(txtMotiv.Text);
                oHi.Hallazgo = Convert.ToString(txtHallaz.Text);
                oHi.Diagnostico = Convert.ToString(txtDiag.Text);
                oHi.FechaCreacion = DateTime.Parse(dtpFechaHistorial.Text);



                //L_Citas.GuardarCita_Servicios(serviciosSeleccionados);
                Rpta = L_Historial.Guardar(oHi);
                if (Rpta == "OK")
                {
                    MostrarHistorial("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
