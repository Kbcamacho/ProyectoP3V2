namespace GUIPrinc
{
    partial class LoginRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegistrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolverCC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombrePaCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiarCP = new System.Windows.Forms.Button();
            this.cmbGeneroPaCC = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCrearPacCC = new System.Windows.Forms.Button();
            this.txtCorreoPaCC = new System.Windows.Forms.TextBox();
            this.txtNumPaCC = new System.Windows.Forms.TextBox();
            this.txtIdenPaCC = new System.Windows.Forms.TextBox();
            this.txtPassPaCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSangre = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnVolverCC);
            this.panel1.Location = new System.Drawing.Point(-16, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnVolverCC
            // 
            this.btnVolverCC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolverCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCC.Location = new System.Drawing.Point(28, 32);
            this.btnVolverCC.Name = "btnVolverCC";
            this.btnVolverCC.Size = new System.Drawing.Size(104, 31);
            this.btnVolverCC.TabIndex = 0;
            this.btnVolverCC.Text = "Volver";
            this.btnVolverCC.UseVisualStyleBackColor = false;
            this.btnVolverCC.Click += new System.EventHandler(this.btnVolverCC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSangre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.dtFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtNombrePaCC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLimpiarCP);
            this.groupBox1.Controls.Add(this.cmbGeneroPaCC);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnCrearPacCC);
            this.groupBox1.Controls.Add(this.txtCorreoPaCC);
            this.groupBox1.Controls.Add(this.txtNumPaCC);
            this.groupBox1.Controls.Add(this.txtIdenPaCC);
            this.groupBox1.Controls.Add(this.txtPassPaCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta para Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tipo de sangre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Apellidos:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(21, 194);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(297, 27);
            this.TxtApellido.TabIndex = 34;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(364, 130);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(297, 22);
            this.dtFechaNacimiento.TabIndex = 33;
            this.dtFechaNacimiento.ValueChanged += new System.EventHandler(this.dtFechaNacimiento_ValueChanged);
            // 
            // txtNombrePaCC
            // 
            this.txtNombrePaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaCC.Location = new System.Drawing.Point(21, 129);
            this.txtNombrePaCC.Name = "txtNombrePaCC";
            this.txtNombrePaCC.Size = new System.Drawing.Size(297, 27);
            this.txtNombrePaCC.TabIndex = 30;
            this.txtNombrePaCC.TextChanged += new System.EventHandler(this.txtNombrePaCC_TextChanged);
            this.txtNombrePaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePaCC_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nombres:";
            // 
            // btnLimpiarCP
            // 
            this.btnLimpiarCP.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCP.Location = new System.Drawing.Point(463, 318);
            this.btnLimpiarCP.Name = "btnLimpiarCP";
            this.btnLimpiarCP.Size = new System.Drawing.Size(94, 36);
            this.btnLimpiarCP.TabIndex = 28;
            this.btnLimpiarCP.Text = "Limpiar";
            this.btnLimpiarCP.UseVisualStyleBackColor = false;
            this.btnLimpiarCP.Click += new System.EventHandler(this.btnLimpiarCP_Click);
            // 
            // cmbGeneroPaCC
            // 
            this.cmbGeneroPaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGeneroPaCC.FormattingEnabled = true;
            this.cmbGeneroPaCC.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbGeneroPaCC.Location = new System.Drawing.Point(364, 193);
            this.cmbGeneroPaCC.Name = "cmbGeneroPaCC";
            this.cmbGeneroPaCC.Size = new System.Drawing.Size(297, 28);
            this.cmbGeneroPaCC.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(360, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Sexo:";
            // 
            // btnCrearPacCC
            // 
            this.btnCrearPacCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrearPacCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPacCC.ForeColor = System.Drawing.Color.Black;
            this.btnCrearPacCC.Location = new System.Drawing.Point(586, 318);
            this.btnCrearPacCC.Name = "btnCrearPacCC";
            this.btnCrearPacCC.Size = new System.Drawing.Size(75, 36);
            this.btnCrearPacCC.TabIndex = 12;
            this.btnCrearPacCC.Text = "Crear";
            this.btnCrearPacCC.UseVisualStyleBackColor = false;
            this.btnCrearPacCC.Click += new System.EventHandler(this.btnCrearPacCC_Click);
            // 
            // txtCorreoPaCC
            // 
            this.txtCorreoPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPaCC.Location = new System.Drawing.Point(364, 259);
            this.txtCorreoPaCC.Name = "txtCorreoPaCC";
            this.txtCorreoPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtCorreoPaCC.TabIndex = 10;
            this.txtCorreoPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreoPaCC_KeyPress);
            // 
            // txtNumPaCC
            // 
            this.txtNumPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPaCC.Location = new System.Drawing.Point(364, 64);
            this.txtNumPaCC.Name = "txtNumPaCC";
            this.txtNumPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtNumPaCC.TabIndex = 9;
            this.txtNumPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPaCC_KeyPress);
            // 
            // txtIdenPaCC
            // 
            this.txtIdenPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdenPaCC.Location = new System.Drawing.Point(21, 259);
            this.txtIdenPaCC.Name = "txtIdenPaCC";
            this.txtIdenPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtIdenPaCC.TabIndex = 8;
            this.txtIdenPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdenPaCC_KeyPress);
            // 
            // txtPassPaCC
            // 
            this.txtPassPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassPaCC.Location = new System.Drawing.Point(21, 64);
            this.txtPassPaCC.Name = "txtPassPaCC";
            this.txtPassPaCC.Size = new System.Drawing.Size(297, 27);
            this.txtPassPaCC.TabIndex = 7;
            this.txtPassPaCC.TextChanged += new System.EventHandler(this.txtPassPaCC_TextChanged);
            this.txtPassPaCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassPaCC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Identificación:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo Electronico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // cmbSangre
            // 
            this.cmbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSangre.FormattingEnabled = true;
            this.cmbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.cmbSangre.Location = new System.Drawing.Point(21, 326);
            this.cmbSangre.Name = "cmbSangre";
            this.cmbSangre.Size = new System.Drawing.Size(297, 28);
            this.cmbSangre.TabIndex = 38;
            // 
            // LoginRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(707, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.LoginRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoPaCC;
        private System.Windows.Forms.TextBox txtNumPaCC;
        private System.Windows.Forms.TextBox txtIdenPaCC;
        private System.Windows.Forms.TextBox txtPassPaCC;
        private System.Windows.Forms.Button btnCrearPacCC;
        private System.Windows.Forms.Button btnVolverCC;
        private System.Windows.Forms.ComboBox cmbGeneroPaCC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimpiarCP;
        private System.Windows.Forms.TextBox txtNombrePaCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSangre;
    }
}