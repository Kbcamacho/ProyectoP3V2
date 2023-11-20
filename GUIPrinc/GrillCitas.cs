using HospitalAPP;
using Logica.LCitas;
using Logica.LPacientes;
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
        int IdCi; 
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GrillCitas_Load(object sender, EventArgs e)
        {
            Listado_Do();
            Listado_IdDo();
            Mostrar("%");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Guardar();
            Validaciones();
            Mostrar("%");
            
        }

        private void Guardar()
        {
            DateTime fechaCita = DateTime.Parse(dtpFechaCita.Text);
            if (fechaCita < DateTime.Now)
            {
                MessageBox.Show("Por favor, digite una fecha valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
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
        }
        private void GuardarAc()
        {
            DateTime fechaCita = DateTime.Parse(dtpFechaCita.Text);
            if (fechaCita < DateTime.Now)
            {
                MessageBox.Show("Por favor, digite una fecha valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtCedula.Text == string.Empty)
                {
                    MessageBox.Show("Faltan Datos por ingresar", "Avisos del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else //Actualizamos la Informacion
                {

                    Cita oCi = new Cita();
                    string Rpta = "";
                    oCi.IdCita = IdCi;
                    oCi.IdPaciente = txtCedula.Text;
                    oCi.IdDoctor = Convert.ToString(CmbCedulaDoctor.Text);
                    oCi.MedicoAsignado = Convert.ToString(CmbNombreDoctor.Text);
                    oCi.FechaCita = Convert.ToDateTime(dtpFechaCita.Text);
                    oCi.HoraCita = CmbHoraCita.Text;
                    Rpta = L_Citas.Actualizar(oCi);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Mostrar(txtBuscar.Text.Trim());
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
                txtCedula.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                CmbCedulaDoctor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                dtpFechaCita.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
                CmbHoraCita.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                CmbNombreDoctor.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);


            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Selecciona_Item();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Eliminar();
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
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar esta Cita?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string Rpta = "";
                        IdCi = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        Rpta = L_Citas.Eliminar(IdCi);

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
        private void BtnGuardarActualizado_Click(object sender, EventArgs e)
        {
            GuardarAc();
            Mostrar("%");
        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            Form btaGestCitas = new GestCitas();
            btaGestCitas.Show();
            this.Hide();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CmbCedulaDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void CmbNombreDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }    
    }
}