namespace PL
{
    partial class FrmAlergias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlergias));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbCargaDe = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbCargaDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(230, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbCargaDe
            // 
            this.grbCargaDe.BackColor = System.Drawing.Color.Transparent;
            this.grbCargaDe.Controls.Add(this.txtNombre);
            this.grbCargaDe.Controls.Add(this.btnAgregar);
            this.grbCargaDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbCargaDe.Location = new System.Drawing.Point(18, 14);
            this.grbCargaDe.Name = "grbCargaDe";
            this.grbCargaDe.Size = new System.Drawing.Size(323, 99);
            this.grbCargaDe.TabIndex = 1;
            this.grbCargaDe.TabStop = false;
            this.grbCargaDe.Text = "Ingrese Alergia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // FrmAlergias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 134);
            this.Controls.Add(this.grbCargaDe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 173);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 173);
            this.Name = "FrmAlergias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlergias_FormClosed);
            this.Load += new System.EventHandler(this.FrmAlergias_Load);
            this.grbCargaDe.ResumeLayout(false);
            this.grbCargaDe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grbCargaDe;
        private System.Windows.Forms.TextBox txtNombre;
    }
}