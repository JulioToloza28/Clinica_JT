using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void lblCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void cbxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMostrar.Checked==true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario obj_Usuario = new Usuario();
            Empleado obj_empleado = new Empleado();
            Empleado_Service emp = new Empleado_Service();

            obj_Usuario.NombreUsuario1 = this.txtUsuario.Text;
            obj_Usuario.Contraseña1 = this.txtContraseña.Text;

            if(obj_Usuario.Buscar()==true)
            {
                obj_empleado=emp.BuscarEmpleado(obj_Usuario.ID_Empleado1);
                this.Hide();
                FrmPantallaPrincipal PantallaPri = new FrmPantallaPrincipal(obj_Usuario,obj_empleado);
                PantallaPri.ShowDialog();
                this.Close();
            }
            else if(obj_Usuario.NombreUsuario1=="")
            {
                MessageBox.Show("No ha ingresado el Usuario", "Login", MessageBoxButtons.OK);
                txtUsuario.Focus();

            }
            else if (obj_Usuario.Contraseña1== "")
            {

                MessageBox.Show("No ha ingresado la contraseña", "Login", MessageBoxButtons.OK);
                txtContraseña.Focus();
            }
            else
            {
                MessageBox.Show(obj_Usuario.Mensaje, "Login", MessageBoxButtons.OK);
            }

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
