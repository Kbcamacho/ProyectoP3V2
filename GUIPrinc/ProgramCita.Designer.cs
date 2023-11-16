namespace GUIPrinc
{
    partial class ProgramCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramCita));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarPC = new System.Windows.Forms.Button();
            this.cmbTipoCita = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVolverPC = new System.Windows.Forms.Button();
            this.btnProgramarCita = new System.Windows.Forms.Button();
            this.FechaCita = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNumCel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoIdent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnLimpiarPC);
            this.panel1.Controls.Add(this.cmbTipoCita);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnVolverPC);
            this.panel1.Controls.Add(this.btnProgramarCita);
            this.panel1.Controls.Add(this.FechaCita);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtNumCel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FechaNaci);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIdent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipoIdent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 362);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLimpiarPC
            // 
            this.btnLimpiarPC.BackColor = System.Drawing.Color.Wheat;
            this.btnLimpiarPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPC.Location = new System.Drawing.Point(122, 308);
            this.btnLimpiarPC.Name = "btnLimpiarPC";
            this.btnLimpiarPC.Size = new System.Drawing.Size(84, 33);
            this.btnLimpiarPC.TabIndex = 22;
            this.btnLimpiarPC.Text = "Limpiar";
            this.btnLimpiarPC.UseVisualStyleBackColor = false;
            this.btnLimpiarPC.Click += new System.EventHandler(this.btnLimpiarPC_Click);
            // 
            // cmbTipoCita
            // 
            this.cmbTipoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCita.FormattingEnabled = true;
            this.cmbTipoCita.Items.AddRange(new object[] {
            "Acupuntura",
            "Cardiologia",
            "Cirugia General",
            "Cirugia Maxilofacial (odontologia)",
            "Cirugia Plastica",
            "Dermatologia",
            "Endocrinologia",
            "Endodoncia",
            "Gastroenterologia",
            "Laboratorio Clinico",
            "Medicina General",
            "Neumologia",
            "Neurologia",
            "Nutricion y Dietetica",
            "Odontologia",
            "Odontologia Estetica",
            "Odontologia Pediatrica",
            "Oftalmologia",
            "Optometria",
            "Ortodoncia",
            "Otorrinolaringologia",
            "Psicologia",
            "Radiologia",
            "Urologia",
            "Vacunacion"});
            this.cmbTipoCita.Location = new System.Drawing.Point(328, 139);
            this.cmbTipoCita.Name = "cmbTipoCita";
            this.cmbTipoCita.Size = new System.Drawing.Size(272, 24);
            this.cmbTipoCita.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo de Cita:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnVolverPC
            // 
            this.btnVolverPC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolverPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolverPC.Location = new System.Drawing.Point(212, 308);
            this.btnVolverPC.Name = "btnVolverPC";
            this.btnVolverPC.Size = new System.Drawing.Size(76, 33);
            this.btnVolverPC.TabIndex = 19;
            this.btnVolverPC.Text = "Volver";
            this.btnVolverPC.UseVisualStyleBackColor = false;
            this.btnVolverPC.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProgramarCita
            // 
            this.btnProgramarCita.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProgramarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramarCita.Location = new System.Drawing.Point(17, 308);
            this.btnProgramarCita.Name = "btnProgramarCita";
            this.btnProgramarCita.Size = new System.Drawing.Size(100, 33);
            this.btnProgramarCita.TabIndex = 18;
            this.btnProgramarCita.Text = "Programar";
            this.btnProgramarCita.UseVisualStyleBackColor = false;
            this.btnProgramarCita.Click += new System.EventHandler(this.btnProgramarCita_Click);
            // 
            // FechaCita
            // 
            this.FechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCita.Location = new System.Drawing.Point(328, 194);
            this.FechaCita.Name = "FechaCita";
            this.FechaCita.Size = new System.Drawing.Size(272, 22);
            this.FechaCita.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Fecha para la Cita:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(328, 82);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(272, 22);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNumCel
            // 
            this.txtNumCel.Location = new System.Drawing.Point(328, 28);
            this.txtNumCel.Name = "txtNumCel";
            this.txtNumCel.Size = new System.Drawing.Size(272, 22);
            this.txtNumCel.TabIndex = 11;
            this.txtNumCel.TextChanged += new System.EventHandler(this.txtNumCel_TextChanged);
            this.txtNumCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Numero Celular:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbGenero.Location = new System.Drawing.Point(16, 249);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(272, 24);
            this.cmbGenero.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sexo:";
            // 
            // FechaNaci
            // 
            this.FechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNaci.Location = new System.Drawing.Point(16, 194);
            this.FechaNaci.Name = "FechaNaci";
            this.FechaNaci.Size = new System.Drawing.Size(272, 22);
            this.FechaNaci.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(16, 139);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(272, 22);
            this.txtIdent.TabIndex = 5;
            this.txtIdent.TextChanged += new System.EventHandler(this.txtIdent_TextChanged);
            this.txtIdent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdent_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Identificación:";
            // 
            // cmbTipoIdent
            // 
            this.cmbTipoIdent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdent.FormattingEnabled = true;
            this.cmbTipoIdent.Items.AddRange(new object[] {
            "Cedula de Ciudadanía",
            "Cedula de Extranjeria",
            "Pasaporte",
            "Tarjeta de Identidad",
            "Registro Civil"});
            this.cmbTipoIdent.Location = new System.Drawing.Point(16, 82);
            this.cmbTipoIdent.Name = "cmbTipoIdent";
            this.cmbTipoIdent.Size = new System.Drawing.Size(272, 24);
            this.cmbTipoIdent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Identificación:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(17, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programar una Cita.";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(328, 250);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(272, 22);
            this.txtCorreo.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Correo:";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Azure;
            this.btnPDF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPDF.Image = global::GUIPrinc.Properties.Resources.pdf;
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(457, 290);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(143, 51);
            this.btnPDF.TabIndex = 25;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // ProgramCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(643, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProgramCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programar Cita";
            this.Load += new System.EventHandler(this.ProgramCita_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaNaci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoIdent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumCel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolverPC;
        private System.Windows.Forms.Button btnProgramarCita;
        private System.Windows.Forms.DateTimePicker FechaCita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiarPC;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPDF;
    }
}