namespace PL
{
    partial class frmMedico_Turnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedico_Turnos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPbusPaciente = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnatender = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pbxBuscar = new System.Windows.Forms.PictureBox();
            this.cbxDescripcion = new System.Windows.Forms.ComboBox();
            this.mtxtDNI = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFicha = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tPbusPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPbusPaciente);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 478);
            this.tabControl1.TabIndex = 25;
            // 
            // tPbusPaciente
            // 
            this.tPbusPaciente.Controls.Add(this.pictureBox4);
            this.tPbusPaciente.Controls.Add(this.pictureBox5);
            this.tPbusPaciente.Controls.Add(this.btnatender);
            this.tPbusPaciente.Controls.Add(this.pictureBox3);
            this.tPbusPaciente.Controls.Add(this.pictureBox2);
            this.tPbusPaciente.Controls.Add(this.btncancelar);
            this.tPbusPaciente.Controls.Add(this.groupBox1);
            this.tPbusPaciente.Controls.Add(this.pictureBox1);
            this.tPbusPaciente.Controls.Add(this.btnFicha);
            this.tPbusPaciente.Controls.Add(this.dgvPacientes);
            this.tPbusPaciente.Location = new System.Drawing.Point(4, 22);
            this.tPbusPaciente.Name = "tPbusPaciente";
            this.tPbusPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tPbusPaciente.Size = new System.Drawing.Size(681, 452);
            this.tPbusPaciente.TabIndex = 0;
            this.tPbusPaciente.Text = "Busqueda";
            this.tPbusPaciente.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(556, 409);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.AccessibleDescription = "Agregar";
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(537, 393);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // btnatender
            // 
            this.btnatender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnatender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatender.Location = new System.Drawing.Point(533, 391);
            this.btnatender.Name = "btnatender";
            this.btnatender.Size = new System.Drawing.Size(105, 38);
            this.btnatender.TabIndex = 43;
            this.btnatender.Text = " Finalizar";
            this.btnatender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnatender.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(417, 409);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleDescription = "Agregar";
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(398, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Location = new System.Drawing.Point(394, 391);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(116, 38);
            this.btncancelar.TabIndex = 40;
            this.btncancelar.Text = "Cancelar Cita";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.pbxBuscar);
            this.groupBox1.Controls.Add(this.cbxDescripcion);
            this.groupBox1.Controls.Add(this.mtxtDNI);
            this.groupBox1.Location = new System.Drawing.Point(23, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(307, 47);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(199, 20);
            this.txtBusqueda.TabIndex = 24;
            // 
            // pbxBuscar
            // 
            this.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbxBuscar.Image")));
            this.pbxBuscar.Location = new System.Drawing.Point(533, 47);
            this.pbxBuscar.Name = "pbxBuscar";
            this.pbxBuscar.Size = new System.Drawing.Size(30, 30);
            this.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBuscar.TabIndex = 15;
            this.pbxBuscar.TabStop = false;
            this.pbxBuscar.Click += new System.EventHandler(this.pbxBuscar_Click);
            // 
            // cbxDescripcion
            // 
            this.cbxDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDescripcion.FormattingEnabled = true;
            this.cbxDescripcion.Items.AddRange(new object[] {
            "DNI",
            "Nombre",
            "Apellido"});
            this.cbxDescripcion.Location = new System.Drawing.Point(82, 47);
            this.cbxDescripcion.Name = "cbxDescripcion";
            this.cbxDescripcion.Size = new System.Drawing.Size(136, 21);
            this.cbxDescripcion.TabIndex = 20;
            this.cbxDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbxDescripcion_SelectedIndexChanged);
            // 
            // mtxtDNI
            // 
            this.mtxtDNI.Location = new System.Drawing.Point(224, 47);
            this.mtxtDNI.Mask = "00.000.000";
            this.mtxtDNI.Name = "mtxtDNI";
            this.mtxtDNI.PromptChar = 'x';
            this.mtxtDNI.Size = new System.Drawing.Size(77, 20);
            this.mtxtDNI.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Agregar";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFicha
            // 
            this.btnFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFicha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFicha.Location = new System.Drawing.Point(284, 391);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(81, 38);
            this.btnFicha.TabIndex = 35;
            this.btnFicha.Text = "Ficha";
            this.btnFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFicha.UseVisualStyleBackColor = true;
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(23, 121);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(633, 255);
            this.dgvPacientes.TabIndex = 0;
            // 
            // frmMedico_Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(713, 502);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(729, 541);
            this.MinimumSize = new System.Drawing.Size(729, 541);
            this.Name = "frmMedico_Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.frmMedico_Turnos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPbusPaciente.ResumeLayout(false);
            this.tPbusPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPbusPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFicha;
        private System.Windows.Forms.MaskedTextBox mtxtDNI;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ComboBox cbxDescripcion;
        private System.Windows.Forms.PictureBox pbxBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnatender;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncancelar;
    }
}