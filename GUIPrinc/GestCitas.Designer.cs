namespace GUIPrinc
{
    partial class GestCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestCitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSacarCita = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGestionUsu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 52);
            this.panel1.TabIndex = 4;
            // 
            // btnSacarCita
            // 
            this.btnSacarCita.BackColor = System.Drawing.Color.LightCyan;
            this.btnSacarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacarCita.ForeColor = System.Drawing.Color.Black;
            this.btnSacarCita.Location = new System.Drawing.Point(50, 83);
            this.btnSacarCita.Name = "btnSacarCita";
            this.btnSacarCita.Size = new System.Drawing.Size(199, 58);
            this.btnSacarCita.TabIndex = 2;
            this.btnSacarCita.Text = "Programar Cita";
            this.btnSacarCita.UseVisualStyleBackColor = false;
            this.btnSacarCita.Click += new System.EventHandler(this.btnSacarCita_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(248, 274);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 47);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGestionUsu);
            this.groupBox1.Controls.Add(this.btnSacarCita);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 196);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opción de su preferencia:";
            // 
            // BtnGestionUsu
            // 
            this.BtnGestionUsu.BackColor = System.Drawing.Color.LightCyan;
            this.BtnGestionUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionUsu.ForeColor = System.Drawing.Color.Black;
            this.BtnGestionUsu.Location = new System.Drawing.Point(327, 83);
            this.BtnGestionUsu.Name = "BtnGestionUsu";
            this.BtnGestionUsu.Size = new System.Drawing.Size(199, 58);
            this.BtnGestionUsu.TabIndex = 5;
            this.BtnGestionUsu.Text = "Gestion de usuario";
            this.BtnGestionUsu.UseVisualStyleBackColor = false;
            this.BtnGestionUsu.Click += new System.EventHandler(this.BtnGestionUsu_Click);
            // 
            // GestCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 352);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Citas";
            this.Load += new System.EventHandler(this.GestCitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSacarCita;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGestionUsu;
    }
}