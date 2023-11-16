using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAPP;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace GUIPrinc
{
    public partial class ProgramCita : Form
    {
        String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public ProgramCita()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form btVolver = new GestCitas();
            btVolver.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProgramCita_Load(object sender, EventArgs e)
        {
            
        }

        public void CrearPDF()
        {
            //var exportarPDF = Path.Combine(path, "CitaProgramada.pdf");
            //using (var writer = new PdfWriter(exportarPDF))
            //{
            //    using (var pdf = new PdfWriter(writer))
            //    {
            //        var doc = new Document(pdf, iText.Kernel.Geom.PageSize.A4);
            //        doc.SetMargins(90, 0 , 0 , 0);
            //        ImageData imagedata = new ImageDataFactory.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\NewLogo_1.ico");
            //        var image = new iText.Layout.Element.Image(imagedata)
            //             .SetTextAlignment(TextAlignment.CENTER)
            //             .SetFixedPosition(1, 10, 700);
            //        doc.Add(image);
            //        Paragraph encabezado = new Paragraph("CITA PROGRAMADA");
            //        encabezado.Add(new(image));
            //        doc.Add(encabezado);

            //        String nombreEmpresa = "CLINICA TRES RIOS";
            //        String sitioweb = "www.clinicatresrios.com.co";
            //        String nombreCiudad = "Valledupar - Cesar";
            //        String direccion = "Cra 19D1 #14B-60";

            //        PdfFont font = PdfFontFactory.CreateFont(FontStyle.Bold);

            //    }
            //}
        }

        private void btnProgramarCita_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtNombre.Text) || String.IsNullOrWhiteSpace(txtIdent.Text) 
                || String.IsNullOrWhiteSpace(txtNumCel.Text) || String.IsNullOrWhiteSpace(txtDireccion.Text) 
                || cmbTipoIdent.SelectedIndex == -1 || cmbGenero.SelectedIndex == -1 
                || cmbTipoCita.SelectedIndex == -1 || String.IsNullOrEmpty(FechaNaci.Text) 
                || String.IsNullOrEmpty(FechaCita.Text)) 
            {
                MessageBox.Show("Por favor, complete todos los campos.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fechaNac = DateTime.Parse(FechaNaci.Text);
                DateTime fechaCit = DateTime.Parse(FechaCita.Text); 
                if ((fechaNac >= DateTime.Now ) || (fechaCit <= DateTime.Now))
                {
                    MessageBox.Show("Fechas Invalidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        TextWriter RegistrarUser = new StreamWriter("CITAS.txt", true);
                        RegistrarUser.WriteLine("Nombre: " + txtNombre.Text);
                        RegistrarUser.WriteLine("Tipo Ident: " + cmbTipoIdent.Text);
                        RegistrarUser.WriteLine("Identificación: " + txtIdent.Text);
                        RegistrarUser.WriteLine("Fecha de Nacimiento: " + FechaNaci.Text);
                        RegistrarUser.WriteLine("Sexo: " + cmbGenero.Text);
                        RegistrarUser.WriteLine("Celular: " + txtNumCel.Text);
                        RegistrarUser.WriteLine("Dirección: " + txtDireccion.Text);
                        RegistrarUser.WriteLine("Tipo de Cita: " + cmbTipoCita.Text);
                        RegistrarUser.WriteLine("Fecha de Cita:" + FechaCita.Text);
                        RegistrarUser.WriteLine("\n");
                        RegistrarUser.Close();

                        MessageBox.Show("La cita fue agendadad con exito", "Verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNombre.Clear();
                        cmbGenero.SelectedIndex = -1;
                        txtIdent.Clear();
                        cmbGenero.SelectedIndex = -1;
                        txtNumCel.Clear();
                        txtDireccion.Clear();
                        cmbTipoCita.SelectedIndex = -1;
                        FechaNaci.Value = DateTime.Now;
                        FechaCita.Value = DateTime.Now;
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo agendar la cita", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarPC_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cmbTipoIdent.SelectedIndex = -1;
            txtIdent.Clear();
            cmbGenero.SelectedIndex = -1;
            txtNumCel.Clear();
            txtDireccion.Clear();
            cmbTipoCita.SelectedIndex = -1;
            txtCorreo.Clear();
            FechaNaci.Value = DateTime.Now;
            FechaCita.Value = DateTime.Now;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back) 
            {
                e.Handled = true;
            }
        }

        private void txtIdent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumCel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            
        }
    }
}
