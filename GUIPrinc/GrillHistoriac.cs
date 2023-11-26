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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace GUIPrinc
{
    public partial class GrillHistoriac : Form
    {

        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public GrillHistoriac(bool tipoUsuario)
        {
            InitializeComponent();
            TipoUsuario = tipoUsuario;
        }
        bool TipoUsuario = true;
        int nCodigo_pr = 0;
        int nValor_pr = 0;
        int idHis;
        String IdHist;
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
                txtHistoAntID.Text = txtHistoID.Text;
                idHis = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtAnteceID.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
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
            DateTime fechaCreacion = DateTime.Parse(dtpFechaHistorial.Text);
            if (fechaCreacion > DateTime.Now)
            {
                MessageBox.Show("Por favor, digite una fecha valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtPacID.Text == string.Empty || txtRecom.Text == string.Empty || txtObser.Text == string.Empty || txtIndic.Text == string.Empty || cmbClasif.Text == string.Empty || txtMotiv.Text == string.Empty || txtHallaz.Text == string.Empty || txtIndic.Text == string.Empty || dtpFechaHistorial.Text == string.Empty || txtDiag.Text == string.Empty)
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
                    oHi.Clasificacion = Convert.ToString(cmbClasif.Text);
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
            GuardarAntecedentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Mostrar(txtBuscar.Text.Trim());
            if (dataGridView1.Rows.Count == 0)
            {
                IdHist = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                MostrarAntecedentes(IdHist);

            }

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
                txtHistoID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                txtPacID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                txtRecom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                txtObser.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                txtIndic.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                cmbClasif.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
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
            DateTime fechaCreacion = DateTime.Parse(dtpFechaHistorial.Text);
            if (fechaCreacion > DateTime.Now)
            {
                MessageBox.Show("Por favor, digite una fecha valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
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
                    oHi.Clasificacion = Convert.ToString(cmbClasif.Text);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            Form btaGestCitas = new GestCitas(TipoUsuario);
            btaGestCitas.Show();
            this.Hide();
        }

        private void txtHistoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPacID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = (txtHistoID.Text + ".pdf");
            guardar.ShowDialog();

            string paginahtml_texto = Properties.Resources.plantilla.ToString();

            paginahtml_texto = paginahtml_texto.Replace("@HISTORIAL", txtHistoID.Text);

            paginahtml_texto = paginahtml_texto.Replace("@IDENTIFICACION", txtPacID.Text);

            paginahtml_texto = paginahtml_texto.Replace("@FECONSUL", DateTime.Now.ToString());

            paginahtml_texto = paginahtml_texto.Replace("@CLASIF",  cmbClasif.Text);

            paginahtml_texto = paginahtml_texto.Replace("@MOTIVO", txtMotiv.Text);

            paginahtml_texto = paginahtml_texto.Replace("@RECO", txtRecom.Text);

            paginahtml_texto = paginahtml_texto.Replace("@OBSERVACION", txtObser.Text);

            paginahtml_texto = paginahtml_texto.Replace("@HALLAZGO", txtHallaz.Text);

            paginahtml_texto = paginahtml_texto.Replace("@DIAG", txtDiag.Text);

            paginahtml_texto = paginahtml_texto.Replace("@CIRUGIAS", cmbCirugia.Text);

            paginahtml_texto = paginahtml_texto.Replace("@ALERGIAS", cmbAlergias.Text);

            paginahtml_texto = paginahtml_texto.Replace("@ENFERMEDADES", cmbEnferm.Text);

            paginahtml_texto = paginahtml_texto.Replace("@INDIC", txtIndic.Text);

            paginahtml_texto = paginahtml_texto.Replace("@FECHA", dtpFechaHistorial.Text);


            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Imagen2, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer,pdfDoc,sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }
            }
        }

        private void txtClasif_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fi = new FileInfo(sfd.FileName);
                            using (ExcelPackage package = new ExcelPackage(fi))
                            {
                                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Nomina");
                                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i].Value = dataGridView1.Columns[i - 1].HeaderText;
                                    worksheet.Cells[1, i].Style.Font.Bold = true;
                                    worksheet.Cells[1, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                    worksheet.Cells[1, i].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));
                                    worksheet.Cells[1, i].Style.Font.Color.SetColor(Color.White);
                                }
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                    {
                                        worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                    }
                                }

                                package.Save();
                            }

                            MessageBox.Show("Datos exportados a Excel con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}