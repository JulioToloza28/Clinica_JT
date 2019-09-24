namespace PL
{
    partial class frmBuscarMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarMedico));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBuscar = new System.Windows.Forms.TabPage();
            this.cbbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.pbxEliminar = new System.Windows.Forms.PictureBox();
            this.pbxModificarP = new System.Windows.Forms.PictureBox();
            this.pbxAgregarP = new System.Windows.Forms.PictureBox();
            this.cbxDescripcion = new System.Windows.Forms.ComboBox();
            this.pbxBuscar = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBuscar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 347);
            this.tabControl1.TabIndex = 25;
            // 
            // tpBuscar
            // 
            this.tpBuscar.Controls.Add(this.cbbEspecialidad);
            this.tpBuscar.Controls.Add(this.txtBusqueda);
            this.tpBuscar.Controls.Add(this.dgvMedicos);
            this.tpBuscar.Controls.Add(this.pbxEliminar);
            this.tpBuscar.Controls.Add(this.pbxModificarP);
            this.tpBuscar.Controls.Add(this.pbxAgregarP);
            this.tpBuscar.Controls.Add(this.cbxDescripcion);
            this.tpBuscar.Controls.Add(this.pbxBuscar);
            this.tpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tpBuscar.Name = "tpBuscar";
            this.tpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuscar.Size = new System.Drawing.Size(654, 321);
            this.tpBuscar.TabIndex = 0;
            this.tpBuscar.Text = "Buscar";
            this.tpBuscar.UseVisualStyleBackColor = true;
            this.tpBuscar.Click += new System.EventHandler(this.tpBuscar_Click);
            // 
            // cbbEspecialidad
            // 
            this.cbbEspecialidad.FormattingEnabled = true;
            this.cbbEspecialidad.Location = new System.Drawing.Point(373, 27);
            this.cbbEspecialidad.Name = "cbbEspecialidad";
            this.cbbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbbEspecialidad.TabIndex = 25;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(168, 27);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(199, 20);
            this.txtBusqueda.TabIndex = 24;
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Location = new System.Drawing.Point(6, 72);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(633, 172);
            this.dgvMedicos.TabIndex = 0;
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
            // cbxDescripcion
            // 
            this.cbxDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDescripcion.FormattingEnabled = true;
            this.cbxDescripcion.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Especialidad"});
            this.cbxDescripcion.Location = new System.Drawing.Point(19, 26);
            this.cbxDescripcion.Name = "cbxDescripcion";
            this.cbxDescripcion.Size = new System.Drawing.Size(143, 21);
            this.cbxDescripcion.TabIndex = 20;
            this.cbxDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbxDescripcion_SelectedIndexChanged);
            // 
            // pbxBuscar
            // 
            this.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbxBuscar.Image")));
            this.pbxBuscar.Location = new System.Drawing.Point(519, 26);
            this.pbxBuscar.Name = "pbxBuscar";
            this.pbxBuscar.Size = new System.Drawing.Size(30, 30);
            this.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxBuscar.TabIndex = 15;
            this.pbxBuscar.TabStop = false;
            this.pbxBuscar.Click += new System.EventHandler(this.pbxBuscar_Click);
            // 
            // frmBuscarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 371);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(702, 410);
            this.MinimumSize = new System.Drawing.Size(702, 410);
            this.Name = "frmBuscarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Medico";
            this.Load += new System.EventHandler(this.frmBuscarMedico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpBuscar.ResumeLayout(false);
            this.tpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.PictureBox pbxEliminar;
        private System.Windows.Forms.PictureBox pbxModificarP;
        private System.Windows.Forms.PictureBox pbxAgregarP;
        private System.Windows.Forms.ComboBox cbxDescripcion;
        private System.Windows.Forms.PictureBox pbxBuscar;
        private System.Windows.Forms.ComboBox cbbEspecialidad;
    }
}