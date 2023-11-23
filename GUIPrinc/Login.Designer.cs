namespace GUIPrinc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChbUsuario = new System.Windows.Forms.CheckBox();
            this.btnIngresarIS = new System.Windows.Forms.Button();
            this.ChbDoctor = new System.Windows.Forms.CheckBox();
            this.btnLimpiarIS = new System.Windows.Forms.Button();
            this.btnCrearCuentaIS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassPaCC = new System.Windows.Forms.TextBox();
            this.txtUserPaCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIO DE SESIÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.ChbUsuario);
            this.groupBox1.Controls.Add(this.btnIngresarIS);
            this.groupBox1.Controls.Add(this.ChbDoctor);
            this.groupBox1.Controls.Add(this.btnLimpiarIS);
            this.groupBox1.Controls.Add(this.btnCrearCuentaIS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassPaCC);
            this.groupBox1.Controls.Add(this.txtUserPaCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los Datos:";
            // 
            // ChbUsuario
            // 
            this.ChbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbUsuario.Location = new System.Drawing.Point(132, 138);
            this.ChbUsuario.Name = "ChbUsuario";
            this.ChbUsuario.Size = new System.Drawing.Size(150, 38);
            this.ChbUsuario.TabIndex = 4;
            this.ChbUsuario.Text = "Usuarios";
            this.ChbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChbUsuario.UseVisualStyleBackColor = true;
            this.ChbUsuario.CheckedChanged += new System.EventHandler(this.ChbUsuario_CheckedChanged);
            // 
            // btnIngresarIS
            // 
            this.btnIngresarIS.BackColor = System.Drawing.Color.LightBlue;
            this.btnIngresarIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarIS.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarIS.Location = new System.Drawing.Point(332, 182);
            this.btnIngresarIS.Name = "btnIngresarIS";
            this.btnIngresarIS.Size = new System.Drawing.Size(100, 38);
            this.btnIngresarIS.TabIndex = 6;
            this.btnIngresarIS.Text = "Ingresar";
            this.btnIngresarIS.UseVisualStyleBackColor = false;
            this.btnIngresarIS.Click += new System.EventHandler(this.btnIngresarIS_Click);
            // 
            // ChbDoctor
            // 
            this.ChbDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbDoctor.Location = new System.Drawing.Point(282, 138);
            this.ChbDoctor.Name = "ChbDoctor";
            this.ChbDoctor.Size = new System.Drawing.Size(150, 38);
            this.ChbDoctor.TabIndex = 5;
            this.ChbDoctor.Text = "Doctor";
            this.ChbDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChbDoctor.UseVisualStyleBackColor = true;
            this.ChbDoctor.CheckedChanged += new System.EventHandler(this.ChbDoctor_CheckedChanged);
            // 
            // btnLimpiarIS
            // 
            this.btnLimpiarIS.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarIS.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarIS.Location = new System.Drawing.Point(208, 182);
            this.btnLimpiarIS.Name = "btnLimpiarIS";
            this.btnLimpiarIS.Size = new System.Drawing.Size(100, 38);
            this.btnLimpiarIS.TabIndex = 7;
            this.btnLimpiarIS.Text = "Limpiar";
            this.btnLimpiarIS.UseVisualStyleBackColor = false;
            this.btnLimpiarIS.Click += new System.EventHandler(this.btnLimpiarIS_Click);
            // 
            // btnCrearCuentaIS
            // 
            this.btnCrearCuentaIS.BackColor = System.Drawing.Color.LightCyan;
            this.btnCrearCuentaIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuentaIS.ForeColor = System.Drawing.Color.Black;
            this.btnCrearCuentaIS.Location = new System.Drawing.Point(251, 240);
            this.btnCrearCuentaIS.Name = "btnCrearCuentaIS";
            this.btnCrearCuentaIS.Size = new System.Drawing.Size(146, 28);
            this.btnCrearCuentaIS.TabIndex = 8;
            this.btnCrearCuentaIS.Text = "Crear Cuenta!";
            this.btnCrearCuentaIS.UseVisualStyleBackColor = false;
            this.btnCrearCuentaIS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(45, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // txtPassPaCC
            // 
            this.txtPassPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassPaCC.Location = new System.Drawing.Point(132, 100);
            this.txtPassPaCC.Name = "txtPassPaCC";
            this.txtPassPaCC.PasswordChar = '*';
            this.txtPassPaCC.Size = new System.Drawing.Size(300, 27);
            this.txtPassPaCC.TabIndex = 3;
            // 
            // txtUserPaCC
            // 
            this.txtUserPaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPaCC.Location = new System.Drawing.Point(132, 42);
            this.txtUserPaCC.Name = "txtUserPaCC";
            this.txtUserPaCC.Size = new System.Drawing.Size(300, 27);
            this.txtUserPaCC.TabIndex = 2;
            this.txtUserPaCC.TextChanged += new System.EventHandler(this.txtUserPaCC_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(477, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarIS;
        private System.Windows.Forms.Button btnIngresarIS;
        private System.Windows.Forms.TextBox txtPassPaCC;
        private System.Windows.Forms.TextBox txtUserPaCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearCuentaIS;
        private System.Windows.Forms.CheckBox ChbUsuario;
        private System.Windows.Forms.CheckBox ChbDoctor;
    }
}