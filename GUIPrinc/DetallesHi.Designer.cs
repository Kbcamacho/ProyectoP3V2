namespace GUIPrinc
{
    partial class DetallesHi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesHi));
            this.GHistorial = new System.Windows.Forms.DataGridView();
            this.btnVolverCC = new System.Windows.Forms.Button();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscaslblIMG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GHistorial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GHistorial
            // 
            this.GHistorial.AllowUserToAddRows = false;
            this.GHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GHistorial.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            this.GHistorial.Location = new System.Drawing.Point(13, 120);
            this.GHistorial.Name = "GHistorial";
            this.GHistorial.ReadOnly = true;
            this.GHistorial.RowHeadersWidth = 51;
            this.GHistorial.RowTemplate.Height = 24;
            this.GHistorial.Size = new System.Drawing.Size(1464, 494);
            this.GHistorial.TabIndex = 1;
            // 
            // btnVolverCC
            // 
            this.btnVolverCC.BackColor = System.Drawing.Color.LightBlue;
            this.btnVolverCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCC.Location = new System.Drawing.Point(13, 12);
            this.btnVolverCC.Name = "btnVolverCC";
            this.btnVolverCC.Size = new System.Drawing.Size(125, 33);
            this.btnVolverCC.TabIndex = 2;
            this.btnVolverCC.Text = "Volver";
            this.btnVolverCC.UseVisualStyleBackColor = false;
            this.btnVolverCC.Click += new System.EventHandler(this.btnVolverCC_Click);
            // 
            // txtHistorial
            // 
            this.txtHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorial.Location = new System.Drawing.Point(180, 19);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(227, 24);
            this.txtHistorial.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 28);
            this.label16.TabIndex = 17;
            this.label16.Text = "N° Historial:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 57);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // buscaslblIMG
            // 
            this.buscaslblIMG.Image = global::GUIPrinc.Properties.Resources._1490793870_user_interface25_82355;
            this.buscaslblIMG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscaslblIMG.Location = new System.Drawing.Point(446, 63);
            this.buscaslblIMG.Name = "buscaslblIMG";
            this.buscaslblIMG.Size = new System.Drawing.Size(110, 51);
            this.buscaslblIMG.TabIndex = 18;
            this.buscaslblIMG.Click += new System.EventHandler(this.buscaslblIMG_Click);
            // 
            // DetallesHi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1489, 626);
            this.Controls.Add(this.GHistorial);
            this.Controls.Add(this.buscaslblIMG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolverCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetallesHi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Historial";
            this.Load += new System.EventHandler(this.DetallesHi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GHistorial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GHistorial;
        private System.Windows.Forms.Button btnVolverCC;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtHistorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label buscaslblIMG;
    }
}