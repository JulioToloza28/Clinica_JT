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
    public partial class FrmBuscar : Form
    {
        Int32 ADM; 
        public FrmBuscar()
        {
            InitializeComponent();
        }
        public FrmBuscar(Int32 id_emp)
        {
            InitializeComponent();
            ADM = id_emp;
        }

        private void pbxAgregarP_Click(object sender, EventArgs e)
        {
            FrmPaciente agregarP = new FrmPaciente(ADM);
            agregarP.ShowDialog();
            cargarGrillaContactos();
        }
        private void cargarGrillaContactos()
        {
            try
            {
                Paciente_service pacientes = new Paciente_service();
                dgvPacientes.DataSource = pacientes.traerTodosPacientes();

                dgvPacientes.Columns[0].Visible = false;
                dgvPacientes.Columns[1].Visible = false;
                dgvPacientes.Columns[2].Visible = false;
                dgvPacientes.Columns[3].Visible = false;
                dgvPacientes.Columns[4].Visible = false;
                dgvPacientes.Columns[5].Visible = false;
                dgvPacientes.Columns[16].Visible = false;



                dgvPacientes.Columns[9].DisplayIndex = 0;
                dgvPacientes.Columns[10].DisplayIndex = 1;
                dgvPacientes.Columns[11].DisplayIndex = 2;
                dgvPacientes.Columns[6].DisplayIndex = 3;


                dgvPacientes.Columns[9].ReadOnly = true;
                dgvPacientes.Columns[9].HeaderText = "Nombre";
                dgvPacientes.Columns[10].ReadOnly = true;
                dgvPacientes.Columns[10].HeaderText = "Apellido";
                dgvPacientes.Columns[11].ReadOnly = true;
                dgvPacientes.Columns[11].HeaderText = "DNI";
                dgvPacientes.Columns[12].ReadOnly = true;
                dgvPacientes.Columns[12].HeaderText = "Fecha de Nac";
                dgvPacientes.Columns[6].ReadOnly = true;
                dgvPacientes.Columns[6].HeaderText = "Edad";
                //dgvPacientes.Columns[15].ReadOnly = true;
                //dgvPacientes.Columns[15].HeaderText = "Direccion";
                //dgvPacientes.Columns[16].ReadOnly = true;
                //dgvPacientes.Columns[16].HeaderText = "Telefono";
                ////dgvPacientes.Columns[17].ReadOnly = true;
                ////dgvPacientes.Columns[17].HeaderText = "Correo";
                //dgvPacientes.Columns[2].ReadOnly = true;
                //dgvPacientes.Columns[2].HeaderText = "Observacion";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Que lastima, faló... " + ex.ToString());
            }

        }


        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            try
            {
                cbxDescripcion.SelectedIndex = 1;
                          
              
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }

        }

        private void pbxModificarP_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dgvPacientes.CurrentRow == null)
                    MessageBox.Show("Debe seleccionar el elemento que quiere modificar");
                else
                {
                    Paciente aux = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                    FrmPaciente modificar = new FrmPaciente(aux,ADM);
                    modificar.Text = "Modificando";
                    modificar.ShowDialog();
                    cargarGrillaContactos();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pbxEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null)
                    MessageBox.Show("Debe seleccionar el elemento que quiere eliminar");
                else
                {

                    if (MessageBox.Show("Esta seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Paciente_service pacientes = new Paciente_service();
                        Paciente Aux = new Paciente();
                        Aux = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                        pacientes.EliminarPaciente(Aux);
                        cargarGrillaContactos();
                    }
                    
                }
                   

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {
            Paciente_service pacientes = new Paciente_service();
            bool bandera=false;
            try
            {
                if (cbxDescripcion.SelectedIndex <0)
                {
                    MessageBox.Show("Debe seleccionar un campo para poder buscar");
                    return;
                }
                if (mtxtDNI.Text== "  ,   ,"&& mtxtDNI.Enabled==true)
                {
                    MessageBox.Show("Complete el campo con el numero de DNI ");
                    return;
                }
                dgvPacientes.DataSource = pacientes.BuscarPaciente(cbxDescripcion.SelectedItem.ToString(), txtBusqueda.Text.Trim(), mtxtDNI.Text.Trim());
                if(dgvPacientes.RowCount == 0 && txtBusqueda.Text=="")
                {

                    cargarGrillaContactos();
                    MessageBox.Show("No hay datos disponible");
                    bandera = true;

                }

                dgvPacientes.Columns[0].Visible = false;
                dgvPacientes.Columns[1].Visible = false;
                dgvPacientes.Columns[2].Visible = false;
                dgvPacientes.Columns[3].Visible = false;
                dgvPacientes.Columns[4].Visible = false;
                dgvPacientes.Columns[5].Visible = false;
                //dgvPacientes.Columns[6].Visible = false; edad
                //dgvPacientes.Columns[7].Visible = false; localidad
                //dgvPacientes.Columns[8].Visible = false; provincia
                dgvPacientes.Columns[16].Visible = false;



                dgvPacientes.Columns[9].DisplayIndex = 0;
                dgvPacientes.Columns[10].DisplayIndex = 1;
                dgvPacientes.Columns[11].DisplayIndex = 2;
                dgvPacientes.Columns[6].DisplayIndex = 3;
                //dgvPacientes.Columns[15].DisplayIndex = 3;
                //dgvPacientes.Columns[10].DisplayIndex = 6;
                //dgvPacientes.Columns[11].DisplayIndex = 4;
                //dgvPacientes.Columns[9].DisplayIndex = 7;
                //dgvPacientes.Columns[16].DisplayIndex = 8;
                //dgvPacientes.Columns[17].DisplayIndex = 9;
                //dgvPacientes.Columns[2].DisplayIndex = 10;

                dgvPacientes.Columns[9].ReadOnly = true;
                dgvPacientes.Columns[9].HeaderText = "Nombre";
                dgvPacientes.Columns[10].ReadOnly = true;
                dgvPacientes.Columns[10].HeaderText = "Apellido";
                dgvPacientes.Columns[11].ReadOnly = true;
                dgvPacientes.Columns[11].HeaderText = "DNI";
                dgvPacientes.Columns[12].ReadOnly = true;
                dgvPacientes.Columns[12].HeaderText = "Fecha de Nac";
                dgvPacientes.Columns[6].ReadOnly = true;
                dgvPacientes.Columns[6].HeaderText = "Edad";
                //dgvPacientes.Columns[15].ReadOnly = true;
                //dgvPacientes.Columns[15].HeaderText = "Direccion";
                //dgvPacientes.Columns[16].ReadOnly = true;
                //dgvPacientes.Columns[16].HeaderText = "Telefono";
                ////dgvPacientes.Columns[17].ReadOnly = true;
                ////dgvPacientes.Columns[17].HeaderText = "Correo";
                //dgvPacientes.Columns[2].ReadOnly = true;
                //dgvPacientes.Columns[2].HeaderText = "Observacion";



                if (dgvPacientes.RowCount == 0 && bandera==false)
                {
                    if (MessageBox.Show("No se encontro ninguna ficha, desea agregarlo?", "Cargar Paciente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        FrmPaciente Agregar = new FrmPaciente();
                        Agregar.ShowDialog();
                    }
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

        private void cbxDescripcion_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbxDescripcion.SelectedIndex!=0)
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

        private void dgvPacientes_DoubleClick(object sender, EventArgs e)
        {
            Paciente aux = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
            FrmPaciente modificar = new FrmPaciente(aux,ADM);
            modificar.Text = "Vista General";
            modificar.ShowDialog();
            cargarGrillaContactos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar al Paciente");
                    
                }
                    
                else
                {
                    bool bna = true;
                    Paciente Aux = new Paciente();
                    Aux = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;
                    FrmTurno TurnoN = new FrmTurno(Aux,bna,ADM);
                    TurnoN.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtxtDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
