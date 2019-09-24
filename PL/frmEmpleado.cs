using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void pbxADDA_Click(object sender, EventArgs e)
        {

        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            ptbVerificacion1.Visible = false;
            ptbVerificacion2.Visible = false;
            ptbVerificacion3.Visible = false;
            ptbVerificacion4.Visible = false;
            if (txtbContraseña.Text != txtbContraseñaR.Text)
            {
                lblnoconicide.Visible = true;
                ptbVerificacion1.Visible = true;
                ptbVerificacion2.Visible = true;
            }
            else
            {
                ptbVerificacion3.Visible = true;
                ptbVerificacion4.Visible = true;
                ptbVerificacion1.Visible = false;
                ptbVerificacion2.Visible = false;
                lblnoconicide.Visible = false;

            }
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            rdbMasculino.Checked = true;

        }
    }
}
