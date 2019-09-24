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
    public partial class FrmPantallaPrincipal : Form
    {
        private Usuario OB_Usuario;
        private Empleado D_Empleado;
        Turno_Service turnos = new Turno_Service();
        //IList<Turno_Paciente> listaT = new List<Turno_Paciente>();

        public FrmPantallaPrincipal()
        {
            InitializeComponent();
            
        }
        public FrmPantallaPrincipal(Usuario User,Empleado Emp)
        {
            InitializeComponent();
            OB_Usuario = User;
            D_Empleado = Emp;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblNom_Usuario.Text = D_Empleado.Nombre1.ToString()+" "+ D_Empleado.Apellido1.ToString();
            lblcategoria.Text = OB_Usuario.Categoria1.ToString();
            
            dgvturnos.DataSource = turnos.Visualizarturnos(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            dgvturnos.Columns[0].Visible = false;
            dgvturnos.Columns[1].Visible = false;
            dgvturnos.Columns[2].Visible = false;
            dgvturnos.Columns[4].Visible = false;
            dgvturnos.Columns[5].Visible = false;
            dgvturnos.Columns[6].Visible = false;
            dgvturnos.Columns[7].Visible = false;
            dgvturnos.Columns[8].Visible = false;


            if (D_Empleado.Sexo1==true)
            {

                pbMa.Image = System.Drawing.Image.FromFile(Application.StartupPath + "/usuario_masc.png");

            }
            else
            {
                pbMa.Image = System.Drawing.Image.FromFile(Application.StartupPath + "/usuario_fem.png");

            }
            if (D_Empleado.ID_Categoria1 == 4)
            {
                
                configuracionToolStripMenuItem.Visible = false;
                pacientesToolStripMenuItem.Visible = false;
                medicosToolStripMenuItem.Visible = false;
                tsmTurnos.Visible = false;
            }
            if (D_Empleado.ID_Categoria1 == 3)
            {
                
                configuracionToolStripMenuItem.Visible = false;
                tsmAgregarM.Visible = false;
            }

        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            FrmPaciente FichaPac = new FrmPaciente(D_Empleado.ID_Empleado1);
            FichaPac.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedico FichaMed = new FrmMedico();
            FichaMed.ShowDialog();
        }

        private void tsmTurnos_Click(object sender, EventArgs e)
        {
            FrmTurno FichaTurnos = new FrmTurno(D_Empleado.ID_Empleado1);
            FichaTurnos.ShowDialog();
        }

        private void tsmBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar Buscar_Paciente = new FrmBuscar(D_Empleado.ID_Empleado1);
            Buscar_Paciente.ShowDialog();
        }

        private void tsmAgrgarPersonal_Click(object sender, EventArgs e)
        {
           
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ptbAgenda_Click(object sender, EventArgs e)
        {
            frmMedico_Turnos Turnos_x_M = new frmMedico_Turnos();
            Turnos_x_M.ShowDialog();
        }

        private void tsmBuscar_m_Click(object sender, EventArgs e)
        {
            frmBuscarMedico BuscarM = new frmBuscarMedico();
            BuscarM.ShowDialog();
        }

        private void pbxCerrarS_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmLogin loguin = new frmLogin();
            loguin.ShowDialog();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado Personal = new frmEmpleado();
            Personal.ShowDialog();
        }

        private void dgvturnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            dgvturnos.DataSource = turnos.Visualizarturnos(monthCalendar1.SelectionRange.Start.Day, monthCalendar1.SelectionRange.Start.Month, monthCalendar1.SelectionRange.Start.Year);
            dgvturnos.Columns[0].Visible = false;
            dgvturnos.Columns[1].Visible = false;
            dgvturnos.Columns[2].Visible = false;
            dgvturnos.Columns[4].Visible = false;
            dgvturnos.Columns[5].Visible = false;
            dgvturnos.Columns[6].Visible = false;
            dgvturnos.Columns[7].Visible = false;
            dgvturnos.Columns[8].Visible = false;

            if (dgvturnos.RowCount == 0)
            {
                MessageBox.Show("No hay turnos para esta fecha");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            bool banderam=false;
            try
            {
                if (mtxtDNI.Text == "  ,   ,")
                {
                    MessageBox.Show("Complete el campo con el numero de DNI ");
                    banderam = true;
                }
                DGWB_TURNOS.DataSource=turnos.buscarpor(mtxtDNI.Text.Trim());

                DGWB_TURNOS.Columns[0].Visible = false;
                DGWB_TURNOS.Columns[1].Visible = false;
                DGWB_TURNOS.Columns[4].Visible = false;
                DGWB_TURNOS.Columns[5].Visible = false;
                DGWB_TURNOS.Columns[6].Visible = false;
                DGWB_TURNOS.Columns[7].Visible = false;
                DGWB_TURNOS.Columns[8].Visible = false;

                if (DGWB_TURNOS.RowCount == 0 && banderam==false)
                {
                    MessageBox.Show("No hay turnos para esta paciente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedico_Turnos Turnos_x_M = new frmMedico_Turnos();
            Turnos_x_M.ShowDialog();
        }

        private void porEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DGWB_TURNOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbxVistaAg_Click(object sender, EventArgs e)
        {
            if (TLP_principal.Visible == true)
            {
             TLP_principal.Visible = false;
            }
            else
            {
             TLP_principal.Visible = true;
            }
        }
    }
}
