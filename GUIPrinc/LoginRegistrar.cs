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
            
        }

        private void Guardar()
        {
            DateTime fechaNacimiento = DateTime.Now;
            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("Por favor, digite una fecha valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtPassPaCC.Text == string.Empty || txtNombrePaCC.Text == string.Empty || TxtApellido.Text == string.Empty || txtIdenPaCC.Text == string.Empty || cmbSangre.Text == string.Empty || txtNumPaCC.Text == string.Empty || dtFechaNacimiento.Text == string.Empty || cmbGeneroPaCC.Text == string.Empty || txtCorreoPaCC.Text == string.Empty)
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
                            oPa.TipoSangre = cmbSangre.Text;
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
            TxtApellido.Clear();
            txtIdenPaCC.Clear();
            txtNumPaCC.Clear();
            txtCorreoPaCC.Clear();
            cmbGeneroPaCC.SelectedIndex = -1;
            dtFechaNacimiento.Value = DateTime.Now;
            cmbSangre.SelectedIndex = -1;
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

        private void cmbSangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
