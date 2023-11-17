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
        bool TipoUsuario = true;
       
        public GestCitas()
        {
            InitializeComponent();

        }
        public GestCitas(bool TipoUsuario)
        {
            InitializeComponent();
            this.TipoUsuario = TipoUsuario;

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
            Form GrillCitas = new GrillCitas();
            GrillCitas.Show();
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

            if (!TipoUsuario)
            {
                Form BtnGestionUsu = new GrillUsuario(TipoUsuario);
                BtnGestionUsu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lo sentimos, no tiene permisos para acceder a esta sección");
            }

            
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            Form BtnHistorial = new GrillHistoriac();
            BtnHistorial.Show();
            this.Hide();
        }
    }
}
