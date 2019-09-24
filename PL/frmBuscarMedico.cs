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
    public partial class frmBuscarMedico : Form
    {
        public frmBuscarMedico()
        {
            InitializeComponent();
        }



        private void tpBuscar_Click(object sender, EventArgs e)
        {

        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {
            Empleado_Service Medicos = new Empleado_Service();
            try
            {
                if(cbxDescripcion.SelectedIndex==2)
                {
                    txtBusqueda.Enabled = false;
                    cbbEspecialidad.Enabled = true;
                    if (cbbEspecialidad.SelectedIndex ==0)
                    {
                        MessageBox.Show("Debe seleccionar una Especialidad");
                        return;
                    }

                }
                if (cbxDescripcion.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar un campo para poder buscar");
                    return;
                }
                if (txtBusqueda.Text == "" && txtBusqueda.Enabled == true)
                {
                    MessageBox.Show("Complete el campo ");
                    return;
                }

                if(txtBusqueda.Enabled == true)
                {
                    dgvMedicos.DataSource = Medicos.buscarMedicoXec(cbxDescripcion.SelectedItem.ToString(), txtBusqueda.Text.Trim());
                    dgvMedicos.Columns[0].Visible = false;
                    dgvMedicos.Columns[1].Visible = false;
                    dgvMedicos.Columns[2].Visible = false;
                    dgvMedicos.Columns[3].Visible = false;
                    dgvMedicos.Columns[4].Visible = false;
                    dgvMedicos.Columns[5].Visible = false;
                    dgvMedicos.Columns[6].Visible = false;
                    dgvMedicos.Columns[7].Visible = false;
                    dgvMedicos.Columns[15].Visible = false;
                }
                else
                {

                    dgvMedicos.DataSource = Medicos.buscarMedicoXec(cbxDescripcion.SelectedItem.ToString(), cbbEspecialidad.SelectedItem.ToString());
                    dgvMedicos.Columns[0].Visible = false;
                    dgvMedicos.Columns[1].Visible = false;
                    dgvMedicos.Columns[2].Visible = false;
                    dgvMedicos.Columns[3].Visible = false;
                    dgvMedicos.Columns[4].Visible = false;
                    dgvMedicos.Columns[5].Visible = false;
                    dgvMedicos.Columns[6].Visible = false;
                    dgvMedicos.Columns[7].Visible = false;
                    dgvMedicos.Columns[15].Visible = false;
                }
               
                if (dgvMedicos.RowCount == 0)
                {
                    MessageBox.Show("No hay datos disponible");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmBuscarMedico_Load(object sender, EventArgs e)
        {
            try
            {
                cbxDescripcion.SelectedIndex = 1;
                Especialidad_service especialidad = new Especialidad_service();
                cbbEspecialidad.DataSource = especialidad.traerEspecialidades();
                cbbEspecialidad.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDescripcion.SelectedIndex == 2)
            {
                cbbEspecialidad.Enabled = true;
                txtBusqueda.Enabled = false;
                txtBusqueda.Clear();
            }
            if (cbxDescripcion.SelectedIndex != 2)
            {
                cbbEspecialidad.Enabled = false;
                txtBusqueda.Enabled = true;
            }
        }

        private void pbxEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (dgvMedicos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar el elemento que quiere eliminar");
                bandera = true;

            }
            if (bandera == false)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar esta ficha?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Empleado aux = new Empleado();
                    aux = (Empleado)dgvMedicos.CurrentRow.DataBoundItem;
                    Empleado_Service medicos = new Empleado_Service();
                    medicos.eliminarMedico(aux.ID_Empleado1);
                    dgvMedicos.DataSource = medicos.buscarMedicoXec(aux.ID_Categoria1,aux.ID_Empleado1);
                    MessageBox.Show("Se elimino con exito");
                }
                

            }


        }

        private void pbxAgregarP_Click(object sender, EventArgs e)
        {
            FrmMedico FICHAm = new FrmMedico();
            FICHAm.ShowDialog();
        }

        private void pbxModificarP_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar el elemento que quiere eliminar");
                

            }
            else
            {
                Empleado_Service Medicos = new Empleado_Service();
                Empleado aux = new Empleado();
                aux = (Empleado)dgvMedicos.CurrentRow.DataBoundItem;
                FrmMedico FICHAm = new FrmMedico(Medicos.BuscarEmpleado(aux));
                FICHAm.ShowDialog();
            }

        }
    }
}
