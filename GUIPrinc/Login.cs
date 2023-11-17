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
using HospitalAPP;
using static Logica.LPacientes.L_Paciente;
using static Logica.LDoctor.L_Doctor;
using Logica.LDoctor;
using System.Security.Cryptography.X509Certificates;

namespace GUIPrinc
{
    public partial class Login : Form
    {
        bool marca = false;
        bool marca1 = false;
        private bool TipoUsuario = true;


        public Login()
        {
            InitializeComponent();
            ChbUsuario.CheckedChanged += ChbUsuario_CheckedChanged;
            ChbDoctor.CheckedChanged += ChbDoctor_CheckedChanged;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void btnIngresarIS_Click(object sender, EventArgs e)
        {
            if (marca1 == false && marca == false)
            {
                MessageBox.Show("Inicio de sesión fallido no ha marcado alguna de las 2 casillas.");
            }
            else
            {
                string username = txtUserPaCC.Text;
                string password = txtPassPaCC.Text;
                string username1 = txtUserPaCC.Text;
                string password1 = txtPassPaCC.Text;


                if (TipoUsuario)
                {

                    BusinessLayer businessLayer = new BusinessLayer();

                    bool isAuthenticated = businessLayer.AuthenticateUser(username, password);

                    if (isAuthenticated)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        Form btIngresar = new GestCitas(TipoUsuario);
                        btIngresar.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Inicio de sesión fallido.");
                    }
                }
                else if (!TipoUsuario)
                {
                    BusinessLayerDoctor businessLayerDoctor = new BusinessLayerDoctor();
                    bool isAuthenticated = businessLayerDoctor.AuthenticateUser(username1, password1);

                    if (isAuthenticated)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        Form btIngresar = new GestCitas(TipoUsuario);
                        btIngresar.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Inicio de sesión fallido.");
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form btCrearCuenta = new LoginRegistrar();
            btCrearCuenta.Show();
            this.Hide();
        }

        private void btnLimpiarIS_Click(object sender, EventArgs e)
        {
            txtPassPaCC.Clear();
            txtUserPaCC.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUserPaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            TipoUsuario = true;
            if (sender == ChbUsuario && ChbUsuario.Checked)
            {
                 marca = true;
                // Si checkBox1 está marcado, deshabilita checkBox2
                ChbDoctor.Enabled = false;
            }
            else if (sender == ChbDoctor && ChbDoctor.Checked)
            {
                 marca = false;
                 marca1 = true;
                // Si checkBox2 está marcado, deshabilita checkBox1
                ChbUsuario.Enabled = false;
            }
            else
            {
                marca = false;
                marca1 = false;
                // Si uno de los CheckBox se desmarca, habilita ambos
                ChbUsuario.Enabled = true;
                ChbDoctor.Enabled = true;
            }

        }

        private void ChbDoctor_CheckedChanged(object sender, EventArgs e)
        {
            TipoUsuario = false;
            if (sender == ChbUsuario && ChbUsuario.Checked)
            {
                marca = true;
                // Si checkBox1 está marcado, deshabilita checkBox2
                ChbDoctor.Enabled = false;
            }
            else if (sender == ChbDoctor && ChbDoctor.Checked)
            {
                marca = false;
                marca1 = true;
                // Si checkBox2 está marcado, deshabilita checkBox1
                ChbUsuario.Enabled = false;
            }
            else
            {
                marca = false;
                marca1 = false;
                // Si uno de los CheckBox se desmarca, habilita ambos
                ChbUsuario.Enabled = true;
                ChbDoctor.Enabled = true;
            }
            
           
        }

    }
}
