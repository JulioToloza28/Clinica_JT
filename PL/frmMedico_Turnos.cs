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
    public partial class frmMedico_Turnos : Form
    {
        bool verif=false;
        public frmMedico_Turnos()
        {
            InitializeComponent();
        }
        public frmMedico_Turnos(bool medic)
        {
            verif = medic;
        }
        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {
            dgvPacientes.ClearSelection();
            try
            {
                Turno_Service turnos = new Turno_Service();
                if (cbxDescripcion.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar un campo para poder buscar");
                    return;
                }
                if (mtxtDNI.Text == "  ,   ," && mtxtDNI.Enabled == true)
                {
                    MessageBox.Show("Complete el campo con el numero de DNI ");
                    return;
                }
                dgvPacientes.DataSource = turnos.Buscar_turnoPor(cbxDescripcion.SelectedItem.ToString(), txtBusqueda.Text.Trim(), mtxtDNI.Text.Trim());
                dgvPacientes.Columns[0].Visible = false;
                dgvPacientes.Columns[1].Visible = false;
                dgvPacientes.Columns[4].Visible = false;
                dgvPacientes.Columns[5].Visible = false;
                dgvPacientes.Columns[6].Visible = false;
                dgvPacientes.Columns[7].Visible = false;
                dgvPacientes.Columns[8].Visible = false;
                if (dgvPacientes.RowCount == 0)
                {
                    MessageBox.Show("No hay datos disponible");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDescripcion.SelectedIndex != 0)
            {
                txtBusqueda.Enabled = true;
                mtxtDNI.Enabled = false;
            }
            else
            {
                txtBusqueda.Enabled = false;
                mtxtDNI.Enabled = true;
            }
        }

        private void frmMedico_Turnos_Load(object sender, EventArgs e)
        {
            cbxDescripcion.SelectedIndex = 1;
            //if (verif == true)
            //{
               

            //}
        }

        private void btnFicha_Click(object sender, EventArgs e)
        {
            Paciente_service paciente = new Paciente_service();
            Turno_Paciente turnoP = new Turno_Paciente();
            Paciente FichaP = new Paciente();

            try
            {

                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar el Paciente");
                }
                else
                {
                    turnoP = (Turno_Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                    FichaP = paciente.BuscarPaciente(turnoP.ID_Paciente1);
                    FrmPaciente pacient = new FrmPaciente(FichaP);
                    pacient.Text = "Vista General";
                    pacient.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Paciente_service paciente = new Paciente_service();
            Turno_Paciente turnoP = new Turno_Paciente();
            Paciente FichaP = new Paciente();

            try
            {

                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar el Paciente");
                }
                else
                {
                    turnoP = (Turno_Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                    FichaP = paciente.BuscarPaciente(turnoP.ID_Paciente1);
                    FrmPaciente pacient = new FrmPaciente(FichaP);
                    pacient.Text = "Vista General";
                    pacient.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar el Paciente");
                }
                else
                {

                    if (MessageBox.Show("Esta seguro que desea cancelar el turno?", "Cancelar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FRM_CANCELAR motivo = new FRM_CANCELAR();
                        motivo.ShowDialog();
                    }
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
