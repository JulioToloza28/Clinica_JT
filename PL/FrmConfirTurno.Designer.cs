namespace PL
{
    partial class FrmConfirTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirTurno));
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbApellidoP = new System.Windows.Forms.TextBox();
            this.txtbNombreP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbHora = new System.Windows.Forms.TextBox();
            this.txtbFecha = new System.Windows.Forms.TextBox();
            this.txtbEsp = new System.Windows.Forms.TextBox();
            this.txtbApellidoM = new System.Windows.Forms.TextBox();
            this.txtbNombreM = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreP.Location = new System.Drawing.Point(30, 30);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(47, 13);
            this.lblNombreP.TabIndex = 0;
            this.lblNombreP.Text = "Nombre:";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoP.Location = new System.Drawing.Point(30, 59);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoP.TabIndex = 1;
            this.lblApellidoP.Text = "Apellido:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtbApellidoP);
            this.groupBox1.Controls.Add(this.txtbNombreP);
            this.groupBox1.Controls.Add(this.lblNombreP);
            this.groupBox1.Controls.Add(this.lblApellidoP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente:";
            // 
            // txtbApellidoP
            // 
            this.txtbApellidoP.Enabled = false;
            this.txtbApellidoP.Location = new System.Drawing.Point(76, 56);
            this.txtbApellidoP.Name = "txtbApellidoP";
            this.txtbApellidoP.Size = new System.Drawing.Size(124, 20);
            this.txtbApellidoP.TabIndex = 3;
            this.txtbApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbNombreP
            // 
            this.txtbNombreP.Enabled = false;
            this.txtbNombreP.Location = new System.Drawing.Point(76, 27);
            this.txtbNombreP.Name = "txtbNombreP";
            this.txtbNombreP.Size = new System.Drawing.Size(124, 20);
            this.txtbNombreP.TabIndex = 2;
            this.txtbNombreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtbHora);
            this.groupBox2.Controls.Add(this.txtbFecha);
            this.groupBox2.Controls.Add(this.txtbEsp);
            this.groupBox2.Controls.Add(this.txtbApellidoM);
            this.groupBox2.Controls.Add(this.txtbNombreM);
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.lblEspecialidad);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.lblNombreM);
            this.groupBox2.Controls.Add(this.lblApellidoM);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(27, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medico:";
            // 
            // txtbHora
            // 
            this.txtbHora.Enabled = false;
            this.txtbHora.Location = new System.Drawing.Point(151, 126);
            this.txtbHora.Name = "txtbHora";
            this.txtbHora.Size = new System.Drawing.Size(49, 20);
            this.txtbHora.TabIndex = 9;
            this.txtbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbFecha
            // 
            this.txtbFecha.Enabled = false;
            this.txtbFecha.Location = new System.Drawing.Point(123, 100);
            this.txtbFecha.Name = "txtbFecha";
            this.txtbFecha.Size = new System.Drawing.Size(77, 20);
            this.txtbFecha.TabIndex = 8;
            this.txtbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbEsp
            // 
            this.txtbEsp.Enabled = false;
            this.txtbEsp.Location = new System.Drawing.Point(101, 74);
            this.txtbEsp.Name = "txtbEsp";
            this.txtbEsp.Size = new System.Drawing.Size(99, 20);
            this.txtbEsp.TabIndex = 7;
            this.txtbEsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbApellidoM
            // 
            this.txtbApellidoM.Enabled = false;
            this.txtbApellidoM.Location = new System.Drawing.Point(76, 48);
            this.txtbApellidoM.Name = "txtbApellidoM";
            this.txtbApellidoM.Size = new System.Drawing.Size(124, 20);
            this.txtbApellidoM.TabIndex = 6;
            this.txtbApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbNombreM
            // 
            this.txtbNombreM.Enabled = false;
            this.txtbNombreM.Location = new System.Drawing.Point(76, 22);
            this.txtbNombreM.Name = "txtbNombreM";
            this.txtbNombreM.Size = new System.Drawing.Size(124, 20);
            this.txtbNombreM.TabIndex = 5;
            this.txtbNombreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(30, 134);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Location = new System.Drawing.Point(30, 79);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(30, 106);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreM.Location = new System.Drawing.Point(30, 25);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(44, 13);
            this.lblNombreM.TabIndex = 0;
            this.lblNombreM.Text = "Nombre";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoM.Location = new System.Drawing.Point(31, 52);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoM.TabIndex = 1;
            this.lblApellidoM.Text = "Apellido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(27, 292);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmConfirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(282, 333);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 372);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 372);
            this.Name = "FrmConfirTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Turno";
            this.Load += new System.EventHandler(this.FrmConfirTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtbApellidoP;
        private System.Windows.Forms.TextBox txtbNombreP;
        private System.Windows.Forms.TextBox txtbHora;
        private System.Windows.Forms.TextBox txtbFecha;
        private System.Windows.Forms.TextBox txtbEsp;
        private System.Windows.Forms.TextBox txtbApellidoM;
        private System.Windows.Forms.TextBox txtbNombreM;
    }
}