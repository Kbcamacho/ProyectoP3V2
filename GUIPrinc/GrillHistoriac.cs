using HospitalAPP;
using HospitalAPP.Admin;
using Logica.LAntecedente;
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
        int nValor_pr = 0;
        int idHis;
        int IdCi;
        int IdHis;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GrillHistoriac_Load(object sender, EventArgs e)
        {
            MostrarHistorial("%");
            MostrarAntecedentes("%");
        }
        private void MostrarAntecedentes(string cTexto)
        {
            try
            {

                dataGridView2.DataSource = L_Antecedente.Mostrar(cTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void GuardarAntecedentes()
        {
            if ( cmbCirugia.Text == string.Empty || cmbAlergias.Text == string.Empty || cmbEnferm.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Guardamos la Informacion
            {
                Antecedentes oAn = new Antecedentes();
                string Rpta = "";
                oAn.IdAntecedente = nValor_pr;
                oAn.Cirugia = Convert.ToString(cmbCirugia.Text);
                oAn.Alergia = Convert.ToString(cmbAlergias.Text);
                oAn.Enfermedad = Convert.ToString(cmbEnferm.Text);
                oAn.IdHistorial = IdHis;



                //L_Citas.GuardarCita_Servicios(serviciosSeleccionados);
                Rpta = L_Antecedente.Guardar(oAn);
                if (Rpta == "OK")
                {
                    MostrarAntecedentes("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

        }
        private void Selecciona_ItemAntecedente()
        {
            if (string.IsNullOrEmpty(dataGridView2.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Seleccione un Registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                idHis = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                cmbCirugia.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
                cmbAlergias.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value);
                cmbEnferm.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
                idHis = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value);

            }

        }
        private void EliminarAntecedente()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (string.IsNullOrEmpty(dataGridView2.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Seleccione un Registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                  
                        string Rpta = "";
                    idHis = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                        Rpta = L_Antecedente.Eliminar(idHis);

                        if (Rpta == "OK")
                        {
                            MostrarAntecedentes("%");
                            MessageBox.Show("Los datos han sido eliminados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }               
                }
            }
            else
            {
                MessageBox.Show("La tabla esta vacia", "Avisos Del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GuardarAntecedentesAc()
        {
            if (cmbCirugia.Text == string.Empty || cmbAlergias.Text == string.Empty || cmbEnferm.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Actualizamos la Informacion
            {

                Antecedentes oAn = new Antecedentes();
                string Rpta = "";
                oAn.IdAntecedente = idHis;
                oAn.Cirugia = Convert.ToString(cmbCirugia.Text);
                oAn.Alergia = Convert.ToString(cmbAlergias.Text);
                oAn.Enfermedad = Convert.ToString(cmbEnferm.Text);
                oAn.IdHistorial = idHis;
                Rpta = L_Antecedente.Actualizar(oAn);
                if (Rpta == "OK")
                {

                    MessageBox.Show("Los datos han sido actualizados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

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
            GuardarAntecedentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Mostrar(txtBuscar.Text.Trim());
            MostrarAntecedentes(txtBuscar.Text.Trim());
        }

        private void Mostrar(string cTexto)
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

        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Seleccione un Registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                IdCi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtPacID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtRecom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtObser.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtIndic.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                txtClasif.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                txtMotiv.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                txtHallaz.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                dtpFechaHistorial.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
                txtDiag.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
                



            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Selecciona_Item();
            Selecciona_ItemAntecedente();
        }

        private void BtnGuardarM_Click(object sender, EventArgs e)
        {
            GuardarAc();
            GuardarAntecedentesAc();
            Mostrar("%");
            MostrarAntecedentes("%");
        }
        private void GuardarAc()
        {
            if (txtPacID.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Actualizamos la Informacion
            {

                HistorialMedico oHi = new HistorialMedico();
                string Rpta = "";
                oHi.IdHistorial = IdCi;
                oHi.Id_usuario = Convert.ToString(txtPacID.Text);
                oHi.Recomendacion = Convert.ToString(txtRecom.Text);
                oHi.Observacion = Convert.ToString(txtObser.Text);
                oHi.Indicacion = Convert.ToString(txtIndic.Text);
                oHi.Clasificacion = Convert.ToString(txtClasif.Text);
                oHi.Motivo = Convert.ToString(txtMotiv.Text);
                oHi.Hallazgo = Convert.ToString(txtHallaz.Text);
                oHi.Diagnostico = Convert.ToString(txtDiag.Text);
                oHi.FechaCreacion = DateTime.Parse(dtpFechaHistorial.Text);
                Rpta = L_Historial.Actualizar(oHi);
                if (Rpta == "OK")
                {

                    MessageBox.Show("Los datos han sido actualizados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            EliminarAntecedente();
        }
        private void Eliminar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Seleccione un Registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este historial?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string Rpta = "";
                        IdCi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        Rpta = L_Historial.Eliminar(IdCi);

                        if (Rpta == "OK")
                        {
                            Mostrar("%");
                            MessageBox.Show("Los datos han sido eliminados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("La tabla esta vacia", "Avisos Del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
