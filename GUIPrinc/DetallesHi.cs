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
    public partial class DetallesHi : Form
    {
        bool TipoUsuario = true;
        public DetallesHi(bool tipoUsuario)
        {
            InitializeComponent();
            
        }

        private void Mostrar(string cTexto)
        {
            try
            {

                GHistorial.DataSource = L_Historial.Mostrar(cTexto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DetallesHi_Load(object sender, EventArgs e)
        {
            Mostrar(txtHistorial.Text.Trim());
        }

        private void btnVolverCC_Click(object sender, EventArgs e)
        {
            GrillHistoriac grillHistoriac = new GrillHistoriac(TipoUsuario);
            grillHistoriac.Show();
            this.Close();
        }

        private void buscaslblIMG_Click(object sender, EventArgs e)
        {
            Mostrar(txtHistorial.Text.Trim());
        }
    }
}
