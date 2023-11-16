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
    public partial class GestCitas : Form
    {
        public GestCitas()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form btantLogin = new Login();
            btantLogin.Show();
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSacarCita_Click(object sender, EventArgs e)
        {
            Form btProgCita = new ProgramCita();
            btProgCita.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            Form btantLogin = new Login();
            btantLogin.Show();
            this.Hide();
        }

        private void GestCitas_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnGestionUsu_Click(object sender, EventArgs e)
        {

            Form BtnGestionUsu = new GrillUsuario();
            BtnGestionUsu.Show();
            this.Hide();
        }
    }
}
