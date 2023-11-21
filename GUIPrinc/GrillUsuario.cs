using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAPP;
using Logica.LCitas;
using Logica.LPacientes;

namespace GUIPrinc
{
    
    public partial class GrillUsuario : Form
    {
        bool TipoUsuario = true;
        public GrillUsuario()
        {
            InitializeComponent();
        }

        string Cedula;
        public GrillUsuario(bool TipoUsuario)
        {
            InitializeComponent();
            this.TipoUsuario = TipoUsuario;


        }

        private void Mostrar(string cTexto)
        {
            try
            {

                Grillausuarios.DataSource = L_Paciente.Mostrar(cTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GrillUsuario_Load(object sender, EventArgs e)
        {


        }

        private void GrillUsuario_Load_1(object sender, EventArgs e)
        {
           
                Mostrar("%");

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (Grillausuarios.SelectedRows.Count > 0)
            {
                LimpiaTexto();
                Selecciona_Item();
                txtIdent.Focus();

            }
            else
            {
                MessageBox.Show("La tabla esta vacia", "Avisos Del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolverCC_Click_1(object sender, EventArgs e)
        {

            Form btantCitas = new GestCitas(TipoUsuario);
            btantCitas.Show();
            this.Dispose();



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GuardarAc();
            Mostrar("%");
            LimpiaTexto();



        }
        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Grillausuarios.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Seleccione un Registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                txtIdent.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[1].Value);
                txtApellido.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[2].Value);
                cmbSexo.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[3].Value);
                dtpFechaNac.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[4].Value);
                txtCorreo.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[5].Value);
                txtNumero.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[6].Value);
                txtPass.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[7].Value);
                cmbSangre.Text = Convert.ToString(Grillausuarios.CurrentRow.Cells[8].Value);
            }
        }

        private void LimpiaTexto()
        {
            txtIdent.Clear();
            txtPass.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumero.Clear();
            dtpFechaNac.Text = string.Empty;
            cmbSexo.Text = "";
            txtCorreo.Clear();
            cmbSangre.Text = "";

        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mostrar(txtBuscar.Text.Trim());
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            Eliminar();
        }

        private void GuardarAc()
        {
            DateTime fechaNacimiento = DateTime.Parse(dtpFechaNac.Text);
            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("Por favor, digite una fecha valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else //Actualizamos la Informacion
                {

                    Paciente oPa = new Paciente();
                    string Rpta = "";
                    oPa.Cedula = txtIdent.Text;
                    oPa.Nombre = txtNombre.Text;
                    oPa.Apellido = txtApellido.Text;
                    oPa.TipoSangre = cmbSangre.Text;
                    oPa.Telefono = txtNumero.Text;
                    oPa.FechaNacimiento = Convert.ToDateTime(dtpFechaNac.Text);
                    oPa.Sexo = cmbSexo.Text;
                    oPa.CorreoElectronico = txtCorreo.Text;
                    Rpta = L_Paciente.Actualizar(oPa, txtIdent.Text);
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

        private void Eliminar()
        {
            if (Grillausuarios.SelectedRows.Count > 0)
            {
                if (string.IsNullOrEmpty(Grillausuarios.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Seleccione un Registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este Cliente?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string Rpta = "";
                        Cedula = Convert.ToString(Grillausuarios.CurrentRow.Cells[0].Value);
                        Rpta = L_Paciente.Eliminar(Cedula);

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

        private void txtIdent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
