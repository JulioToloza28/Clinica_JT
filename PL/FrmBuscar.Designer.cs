namespace PL
{
    partial class FrmBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscar));
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.cbxDescripcion = new System.Windows.Forms.ComboBox();
            this.pbxEliminar = new System.Windows.Forms.PictureBox();
            this.pbxModificarP = new System.Windows.Forms.PictureBox();
            this.pbxAgregarP = new System.Windows.Forms.PictureBox();
            this.pbxBuscar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxtDNI = new System.Windows.Forms.MaskedTextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(135)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.Location = new System.Drawing.Point(6, 72);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(633, 172);
            this.dgvPacientes.TabIndex = 0;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            this.dgvPacientes.DoubleClick += new System.EventHandler(this.dgvPacientes_DoubleClick);
            // 
            // cbxDescripcion
            // 
            this.cbxDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDescripcion.FormattingEnabled = true;
            this.cbxDescripcion.Items.AddRange(new object[] {
            "DNI",
            "Nombre",
            "Apellido"});
            this.cbxDescripcion.Location = new System.Drawing.Point(32, 26);
            this.cbxDescripcion.Name = "cbxDescripcion";
            this.cbxDescripcion.Size = new System.Drawing.Size(106, 21);
            this.cbxDescripcion.TabIndex = 20;
            this.cbxDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbxDescripcion_SelectedIndexChanged);
            this.cbxDescripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxDescripcion_MouseClick);
            // 
            // pbxEliminar
            // 
            this.pbxEliminar.AccessibleDescription = "Eliminar";
            this.pbxEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbxEliminar.Image")));
            this.pbxEliminar.Location = new System.Drawing.Point(535, 261);
            this.pbxEliminar.Name = "pbxEliminar";
            this.pbxEliminar.Size = new System.Drawing.Size(67, 38);
            this.pbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEliminar.TabIndex = 21;
            this.pbxEliminar.TabStop = false;
            this.pbxEliminar.Click += new System.EventHandler(this.pbxEliminar_Click);
            // 
            // pbxModificarP
            // 
            this.pbxModificarP.AccessibleDescription = "Modificar";
            this.pbxModificarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxModificarP.Image = ((System.Drawing.Image)(resources.GetObject("pbxModificarP.Image")));
            this.pbxModificarP.Location = new System.Drawing.Point(447, 261);
            this.pbxModificarP.Name = "pbxModificarP";
            this.pbxModificarP.Size = new System.Drawing.Size(67, 38);
            this.pbxModificarP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxModificarP.TabIndex = 22;
            this.pbxModificarP.TabStop = false;
            this.pbxModificarP.Click += new System.EventHandler(this.pbxModificarP_Click);
            // 
            // pbxAgregarP
            // 
            this.pbxAgregarP.AccessibleDescription = "Agregar";
            this.pbxAgregarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAgregarP.Image = ((System.Drawing.Image)(resources.GetObject("pbxAgregarP.Image")));
            this.pbxAgregarP.Location = new System.Drawing.Point(359, 261);
            this.pbxAgregarP.Name = "pbxAgregarP";
            this.pbxAgregarP.Size = new System.Drawing.Size(67, 38);
            this.pbxAgregarP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarP.TabIndex = 23;
            this.pbxAgregarP.TabStop = false;
            this.pbxAgregarP.Click += new System.EventHandler(this.pbxAgregarP_Click);
            // 
            // pbxBuscar
            // 
            this.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbxBuscar.Image")));
            this.pbxBuscar.Location = new System.Drawing.Point(515, 15);
            this.pbxBuscar.Name = "pbxBuscar";
            this.pbxBuscar.Size = new System.Drawing.Size(67, 38);
            this.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscar.TabIndex = 15;
            this.pbxBuscar.TabStop = false;
            this.pbxBuscar.Click += new System.EventHandler(this.pbxBuscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 347);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.mtxtDNI);
            this.tabPage1.Controls.Add(this.txtBusqueda);
            this.tabPage1.Controls.Add(this.dgvPacientes);
            this.tabPage1.Controls.Add(this.pbxEliminar);
            this.tabPage1.Controls.Add(this.pbxModificarP);
            this.tabPage1.Controls.Add(this.pbxAgregarP);
            this.tabPage1.Controls.Add(this.cbxDescripcion);
            this.tabPage1.Controls.Add(this.pbxBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "Agregar";
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(32, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Turno";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtxtDNI
            // 
            this.mtxtDNI.Location = new System.Drawing.Point(144, 26);
            this.mtxtDNI.Mask = "00.000.000";
            this.mtxtDNI.Name = "mtxtDNI";
            this.mtxtDNI.PromptChar = 'x';
            this.mtxtDNI.Size = new System.Drawing.Size(117, 20);
            this.mtxtDNI.TabIndex = 33;
            this.mtxtDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDNI_MaskInputRejected);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(267, 26);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(199, 20);
            this.txtBusqueda.TabIndex = 24;
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 371);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 410);
            this.MinimumSize = new System.Drawing.Size(702, 410);
            this.Name = "FrmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Paciente";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.ComboBox cbxDescripcion;
        private System.Windows.Forms.PictureBox pbxEliminar;
        private System.Windows.Forms.PictureBox pbxModificarP;
        private System.Windows.Forms.PictureBox pbxAgregarP;
        private System.Windows.Forms.PictureBox pbxBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.MaskedTextBox mtxtDNI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}