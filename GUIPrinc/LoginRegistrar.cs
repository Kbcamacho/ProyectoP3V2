using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using HospitalAPP;
using Logica.LPacientes;

namespace GUIPrinc
{
    public partial class LoginRegistrar : Form
    {
        public LoginRegistrar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            Form btVolverLR = new Login();
            btVolverLR.Show();
            this.Close();
        }

        private void btnCrearDocCC_Click(object sender, EventArgs e)
        {

        }

        private void txtUserPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearPacCC_Click(object sender, EventArgs e)
        {
            Guardar();
            //if (String.IsNullOrWhiteSpace(txtUserPaCC.Text) || String.IsNullOrWhiteSpace(txtPassPaCC.Text)
            //    || String.IsNullOrWhiteSpace(txtNombrePaCC.Text) || String.IsNullOrWhiteSpace(txtIdenPaCC.Text)
            //    || String.IsNullOrWhiteSpace(txtNumPaCC.Text) || String.IsNullOrWhiteSpace(txtCorreoPaCC.Text)
            //    || String.IsNullOrWhiteSpace(dtFechaNacimiento.Text) || cmbGeneroPaCC.SelectedIndex == -1
            //    )
            //{
            //    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    DateTime fechaNacimiento = DateTime.Parse(dtFechaNacimiento.Text);
            //    if (fechaNacimiento >= DateTime.Now)
            //    {
            //        MessageBox.Show("Fecha de Nacimiento invalida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        try
            //        {

            //            //TextWriter RegistrarUser = new StreamWriter(txtUserPaCC.Text + ".txt", true);
            //            //RegistrarUser.WriteLine(txtPassPaCC.Text);
            //            //RegistrarUser.WriteLine("Nombre: " + txtNombrePaCC.Text);
            //            //RegistrarUser.WriteLine("Tipo de Ident: " + cmbTipoIdenPaCC.Text);
            //            //RegistrarUser.WriteLine("Identificación: " + txtIdenPaCC.Text);
            //            //RegistrarUser.WriteLine("Celular: " + txtNumPaCC.Text);
            //            //RegistrarUser.WriteLine("Sexo: " + cmbGeneroPaCC.Text);
            //            //RegistrarUser.WriteLine("Correo: " + txtCorreoPaCC.Text);
            //            //RegistrarUser.WriteLine("Fecha de Nacimiento: " + dtFechaNacimiento.Text);
            //            //RegistrarUser.Close();

            //            //MessageBox.Show("El Usuario fue registrado con Exito", "Verificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            txtUserPaCC.Clear();
            //            txtPassPaCC.Clear();
            //            txtNombrePaCC.Clear();
            //            txtIdenPaCC.Clear();
            //            txtNumPaCC.Clear();
            //            txtCorreoPaCC.Clear();
            //            cmbGeneroPaCC.SelectedIndex = -1;
            //            dtFechaNacimiento.Value = DateTime.Now;

            //        }
            //        catch
            //        {
            //            MessageBox.Show("No se pudo registrar al usuario", "ERROR", MessageBoxButtons.OKCancel);
            //        }
            //    }
            //}
        }

        private void Guardar()
        {
            if ( txtPassPaCC.Text == string.Empty || txtNombrePaCC.Text == string.Empty || TxtApellido.Text == string.Empty || txtIdenPaCC.Text == string.Empty || TxtTSangre.Text == string.Empty || txtNumPaCC.Text == string.Empty || dtFechaNacimiento.Text == string.Empty || cmbGeneroPaCC.Text == string.Empty || txtCorreoPaCC.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Guardamos la Informacion
            {
                string Rpta = "";
                try
                {

                    {
                        Paciente oPa = new Paciente();
                        //string Rpta = "";
                        oPa.Password = txtPassPaCC.Text;
                        oPa.Cedula = txtIdenPaCC.Text;
                        oPa.Nombre = txtNombrePaCC.Text;
                        oPa.Apellido = TxtApellido.Text;
                        oPa.TipoSangre = TxtTSangre.Text;
                        oPa.Telefono = txtNumPaCC.Text;
                        oPa.FechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.Text);
                        oPa.Sexo = cmbGeneroPaCC.Text;
                        oPa.CorreoElectronico = txtCorreoPaCC.Text;
                        
                        Rpta = L_Paciente.Guardar(oPa);
                        if (Rpta == "OK")
                        {
                            
                            MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Rpta = ex.Message;
                    MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void txtPassPaCC_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpiarCD_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpiarCP_Click(object sender, EventArgs e)
        {

            txtPassPaCC.Clear();
            txtNombrePaCC.Clear();
            txtIdenPaCC.Clear();
            txtNumPaCC.Clear();
            txtCorreoPaCC.Clear();
            cmbGeneroPaCC.SelectedIndex = -1;
            dtFechaNacimiento.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNombrePaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtIdenPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtEdadPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCorreoPaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombrePaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LoginRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
