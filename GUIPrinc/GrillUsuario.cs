using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAPP;
using Logica.LPacientes;

namespace GUIPrinc
{
    public partial class GrillUsuario : Form
    {
        public GrillUsuario()
        {
            InitializeComponent();
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

        }
    }
}
