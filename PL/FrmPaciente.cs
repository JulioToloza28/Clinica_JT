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
    public partial class FrmPaciente : Form
    {
        private Paciente paciente;
        List<Alergia> lista = new List<Alergia>();
        List<Medicamento> listaM = new List<Medicamento>();
        List<Medicamento_X> ModificarLista = new List<Medicamento_X>();        
        private Int32 Id_empleado;
        Alergias_X_Paciente_Service T_Alergias = new Alergias_X_Paciente_Service();
        MedicamentoXpaciente_Service T_Medicamntos = new MedicamentoXpaciente_Service();
        

        public FrmPaciente()
        {
            InitializeComponent();
            
        }
        public FrmPaciente( int id)
        {
            InitializeComponent();
            Id_empleado = id;

        }

        public FrmPaciente(Paciente Pacient,int emp)
        {
            InitializeComponent();
            paciente = Pacient;
            Id_empleado = emp;
            

        }
        public FrmPaciente(Paciente Pacientee)
        {
            InitializeComponent();
            paciente = Pacientee;


        }

        private void tpgAntecedentes_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != ""||txtApellido.Text!=""||txtDNI.Text!="")
            {
                if (btnAceptar.Visible != false)
                {
                    if (MessageBox.Show("Esta seguro que desea Cerrar? " + "\nSe perderan todos los datos", "Cerrar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }

                }
                else { this.Close();}
               
            }
            else
            {
                this.Close();
            }


        }

        public Paciente CargarFormulario(Paciente paciente)
        {
            paciente.Nombre1 = txtNombre.Text.Trim();
            paciente.Apellido1 = txtApellido.Text.Trim();
            paciente.DNI1 = txtDNI.Text.Trim();
            paciente.Fecha_Nac1 = Convert.ToString(dtpFechaNac.Text.Trim());
            if (rdbMasculino.Checked)
            {
                paciente.Sexo1 = true;
            }
            else
            {
                paciente.Sexo1 = false;
            }
            paciente.Direccion1 = txtDireccion.Text.Trim();
            paciente.Localidad = (Localidad)cbxLocalidad.SelectedItem;
            paciente.Telefono1 = txtTelefono.Text.Trim();
            paciente.Email1 = txtCorreo.Text.Trim();
            paciente.Obs1 = txtObs.Text.Trim();
            paciente.InicialesEmp1 = Id_empleado;
            paciente.Eliminado = false;
            Grupo_Sanguineo Grupo = (Grupo_Sanguineo)cbxSangre.SelectedItem;
            paciente.Antecedente.ID_Grupo_Sanguineo1 = Grupo.ID_Grupo_Sanguineo1;
            paciente.Antecedente.Altura1 = Convert.ToDecimal(txtAltura.Text.Trim());
            paciente.Antecedente.Peso1 = Convert.ToDecimal(txtPeso.Text.Trim());
            paciente.Lista_Medicamentos = listaM;
            paciente.Lista_Alergias = lista;

            return paciente;
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            rdbMasculino.Checked = true;

            try

            {            
                 
                Grupo_SanguineoService TipoSan = new Grupo_SanguineoService();
                cbxSangre.DataSource = TipoSan.traerTipoDeSangre();
                cbxSangre.DisplayMember ="Nombre1";
                cbxSangre.ValueMember = "ID_Grupo_Sanguineo1";

                Alergia_Service Alergias = new Alergia_Service();
                cbxAlergias.DataSource = Alergias.TraerAlergias();
                cbxAlergias.DisplayMember = "Nombre1";
                cbxAlergias.ValueMember = "ID_Alergia1";

                Medicamento_Service MedicamentoS = new Medicamento_Service();
                cbxMedicamento.DataSource = MedicamentoS.traerMedicamentos();
                cbxMedicamento.DisplayMember = "Nombre1";
                cbxMedicamento.ValueMember = "ID_Medicamento1";

                ProvinciaService Provincia = new ProvinciaService();
                cbxProvincia.DataSource = null;
                cbxProvincia.DataSource = Provincia.traerProvincias();
                cbxProvincia.DisplayMember = "N_Provincia1";
                cbxProvincia.ValueMember = "ID_Provincia1";
                
                if (paciente != null)
                {
                  
                    txtNombre.Text = paciente.Nombre1;
                    txtApellido.Text = paciente.Apellido1;
                    dtpFechaNac.Text = paciente.Fecha_Nac1;
                    txtDNI.Text = paciente.DNI1;
                    if (paciente.Sexo1 == true)
                    {
                        rdbMasculino.Checked = true;
                    }
                    else
                    {
                        rdbFemenino.Checked = true;
                    }
                    txtDireccion.Text = paciente.Direccion1;
                    lblEdad.Text = Convert.ToString(paciente.Edad1);
                    lblEdad.Visible = true;
                    txtCorreo.Text = paciente.Email1;
                    txtObs.Text = paciente.Obs1;
                    txtAltura.Text = paciente.Antecedente.Altura1.ToString();
                    txtPeso.Text = paciente.Antecedente.Peso1.ToString();
                    txtTelefono.Text = paciente.Telefono1.ToString();
                    cbxProvincia.SelectedValue = paciente.Provincia.ID_Provincia1;
                    cbxLocalidad.SelectedValue = paciente.Localidad.ID_Localidad1;
                    cbxSangre.SelectedValue = paciente.Antecedente.ID_Grupo_Sanguineo1;
                    dgvAlergias.DataSource=T_Alergias.TraerAlergias_P(paciente.ID_Paciente1);
                    ModificarLista= T_Medicamntos.TraerMedicamntos_P(paciente.ID_Paciente1);
                    Medicamento medicag = new Medicamento();
                    for (int i=0; i < ModificarLista.Count; i++)
                    {
                        medicag.ID_Medicamento1=ModificarLista[i].ID_Medicamento1;
                        medicag.Nombre1=ModificarLista[i].N_Medicamento1;
                        listaM.Add(medicag);    
                    }
                    dgvMedicamento.DataSource = listaM; 
                    dgvMedicamento.Columns[0].Visible = false;
                    dgvAlergias.Columns[0].Visible = false;                    


                    if (this.Text == "Vista General")
                    {
                        btnAceptar.Visible = false;
                        txtNombre.Enabled = false;
                        txtApellido.Enabled= false;
                        cbxLocalidad.Enabled = false;
                        cbxProvincia.Enabled = false;
                        txtDNI.Enabled = false;
                        dtpFechaNac.Enabled = false;
                        txtDireccion.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtPeso.Enabled = false;
                        txtAltura.Enabled = false;
                        txtObs.Enabled = false;
                        txtCorreo.Enabled = false;
                        cbxAlergias.Enabled = false;
                        cbxMedicamento.Enabled = false;
                        cbxSangre.Enabled = false;
                        rdbMasculino.Enabled = false;
                        rdbFemenino.Enabled = false;
                        pbxADDA.Visible = false;
                        pbxADDM.Visible = false;
                        ptbAgregarAlergia.Visible = false;
                        pbxDELA.Visible = false;
                        ptbAgregarMedicamento.Visible = false;
                        pbxDELM.Visible = false;
                        dgvAlergias.Enabled = false;
                        dgvMedicamento.Enabled = false;
                    }

                }
                else
                {
                    this.Text = "Creando...";
                  
                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CbxSangre_ValueMemberChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbxProvincia_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void cbxLocalidad_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void cbxProvincia_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text != "" && txtApellido.Text!="" && txtDireccion.Text!="" && txtDNI.Text!="" && txtTelefono.Text!=""&& cbxSangre.SelectedIndex!=0 && txtAltura.Text != " ."&& txtPeso.Text!="")
                {
                    Paciente_service Pac_service = new Paciente_service();
                    Paciente VerfPac = new Paciente();
                    VerfPac = Pac_service.BuscarPaciente(txtDNI.Text);
                    if(VerfPac.DNI1==txtDNI.Text && this.Text == "Creando..." )
                    {
                        MessageBox.Show("El paciente ya existe");
                    }
                    else
                    {
                        if (paciente == null || paciente.ID_Paciente1 == 0)
                        {
                            if (paciente == null)
                            {
                                paciente = new Paciente();
                                paciente.Antecedente = new Antecedente();
                                paciente.Nombre1 = txtNombre.Text.Trim();
                                paciente.Apellido1 = txtApellido.Text.Trim();
                                paciente.DNI1 = txtDNI.Text.Trim();
                                paciente.Fecha_Nac1 = Convert.ToString(dtpFechaNac.Text.Trim());
                                if (rdbMasculino.Checked)
                                {
                                    paciente.Sexo1 = true;
                                }
                                else
                                {
                                    paciente.Sexo1 = false;
                                }
                                paciente.Direccion1 = txtDireccion.Text.Trim();
                                paciente.Localidad = (Localidad)cbxLocalidad.SelectedItem;
                                paciente.Telefono1 = txtTelefono.Text.Trim();
                                paciente.Email1 = txtCorreo.Text.Trim();
                                paciente.Obs1 = txtObs.Text.Trim();
                                paciente.InicialesEmp1 = Id_empleado;
                                paciente.Eliminado = false;
                                Grupo_Sanguineo Grupo = (Grupo_Sanguineo)cbxSangre.SelectedItem;
                                paciente.Antecedente.ID_Grupo_Sanguineo1 = Grupo.ID_Grupo_Sanguineo1;
                                paciente.Antecedente.Altura1 = Convert.ToDecimal(txtAltura.Text.Trim());
                                paciente.Antecedente.Peso1 = Convert.ToDecimal(txtPeso.Text.Trim());
                                paciente.Lista_Alergias = lista;
                                paciente.Lista_Medicamentos = listaM;

                            }
                        }
                        if (paciente.ID_Paciente1 == 0)
                        {
                            Pac_service.GuardarPaciente(paciente);
                            DialogResult resul = MessageBox.Show("Desea sacar un turno?", "Paciente agregado Exitosamente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resul == DialogResult.Yes)
                            {
                                FrmTurno TurnoN = new FrmTurno();
                                TurnoN.ShowDialog();
                                Dispose();
                            }
                            else
                            {
                                Dispose();
                            }

                        }
                        else
                        {
                            CargarFormulario(paciente);
                            Pac_service.ModificarPaciente(paciente, Id_empleado);
                            MessageBox.Show("Paciente modificado Exitosamente");
                            Dispose();
                        }

                    }

     
                }
                else
                {
                    lblobligatorio1.Visible = true;
                    lblobligatorio2.Visible = true;
                    lblobligatorio4.Visible = true;
                    lblobligatorio5.Visible = true;
                    lblobligatorio6.Visible = true;
                    lblobligatorio7.Visible = true;
                    lblobligatorio8.Visible = true;
                    lblobligatoriol3.Visible = true;
                    lblobligatorio9.Visible = true;
                    lblobligatorioAn.Visible = true;
                    lblobligatorioAns.Visible = true;
                    MessageBox.Show("Complete los campos obligatorios (*)","Completar",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;

        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia Prov = (Provincia)cbxProvincia.SelectedItem;
            LocalidadService Localidad = new LocalidadService();
            cbxLocalidad.DataSource = Localidad.traerLocalidades(Prov.ID_Provincia1);
            cbxLocalidad.DisplayMember = "N_Localidad1";
            cbxLocalidad.ValueMember = "ID_Localidad1";

          

        }

        private void lbltelefono_Click(object sender, EventArgs e)
        {

        }

        private void ptbAgregarAlergia_Click(object sender, EventArgs e)
        {
            FrmAlergias cargar_A = new FrmAlergias();
            cargar_A.Text = "Cargar Alergia";
            cargar_A.ShowDialog();
        }

        private void ptbAgregarMedicamento_Click(object sender, EventArgs e)
        {
            FrmAlergias cargar_M = new FrmAlergias();
            cargar_M.Text = "Cargar Medicamento";
            cargar_M.ShowDialog();
        }

        private void mtxtTelefono_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void cbxAlergias_MouseClick(object sender, MouseEventArgs e)
        {
            Alergia_Service Alergias = new Alergia_Service();
            cbxAlergias.DataSource = Alergias.TraerAlergias();
        }

        private void cbxAlergias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxMedicamento_MouseClick(object sender, MouseEventArgs e)
        {
            Medicamento_Service MedicamentoS = new Medicamento_Service();
            cbxMedicamento.DataSource = MedicamentoS.traerMedicamentos();
        }

        private void dtpFechaNac_Validated(object sender, EventArgs e)
        {
         
        }

        private void dtpFechaNac_CloseUp(object sender, EventArgs e)
        {
            
        }

        private void dtpFechaNac_MouseEnter(object sender, EventArgs e)
        {
          
        }

        public int CalcularEdad(int dia, int mes, int año)
        {
            int Edad;
            Edad = DateTime.Today.Year - año;
            if (mes >= DateTime.Today.Month)
            {
                if (dia >= DateTime.Today.Day)
                {
                    return Edad;
                }

            }
            return Edad-1 ;

        }

        private void dtpFechaNac_Leave(object sender, EventArgs e)
        {
             if (dtpFechaNac.Value.Year != 2017)
            {
                
                lblEdad.Text =Convert.ToString(CalcularEdad(dtpFechaNac.Value.Day, dtpFechaNac.Value.Month, dtpFechaNac.Value.Year));
                lblEdad.Visible = true;
            }
           
        }

        private void pbxADDA_Click(object sender, EventArgs e)
        {
            try
            {
                Alergia nuevoAlergia = new Alergia();

                if (cbxAlergias.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Items");
                }
                else if (lista.Contains((Alergia)cbxAlergias.SelectedItem))
                {
                    MessageBox.Show("Ya existe");
                }
                else
                {
                    nuevoAlergia = (Alergia)cbxAlergias.SelectedItem;
                    lista.Add(nuevoAlergia);
                    dgvAlergias.DataSource = null;
                    dgvAlergias.DataSource = lista;
                    dgvAlergias.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        

            

        }

        private void pbxADDM_Click(object sender, EventArgs e)
        {
            try
            {
                Medicamento nuevoMedicamento = new Medicamento();

                if (cbxMedicamento.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Items");
                    return;
                }
                nuevoMedicamento = (Medicamento)cbxMedicamento.SelectedItem;
                for (int i = 0; i < listaM.Count; i++)
                {
                    if (listaM[i].Nombre1 ==nuevoMedicamento.Nombre1)
                    {
                        MessageBox.Show("Ya existe");
                        return;
                    }
                }
                if (listaM.Contains((Medicamento)cbxMedicamento.SelectedItem))
                {
                    MessageBox.Show("Ya existe");
                }

                else
                {
                    nuevoMedicamento = (Medicamento)cbxMedicamento.SelectedItem;
                    listaM.Add(nuevoMedicamento);
                    dgvMedicamento.DataSource = null;
                    dgvMedicamento.DataSource = listaM;
                    dgvMedicamento.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void pbxDELA_Click(object sender, EventArgs e)
        {
            if (dgvAlergias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item");
            }
            else
            {
                lista.Remove((Alergia)dgvAlergias.CurrentRow.DataBoundItem);
                dgvAlergias.DataSource = null;
                dgvAlergias.DataSource = lista;
                dgvAlergias.Columns[0].Visible = false;
            }
         
        }

        private void pbxDELM_Click(object sender, EventArgs e)
        {
            if (dgvMedicamento.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item");
            }
            else
            {
                    listaM.Remove((Medicamento)dgvMedicamento.CurrentRow.DataBoundItem);
                    dgvMedicamento.DataSource = null;
                    dgvMedicamento.DataSource = listaM;
                    dgvMedicamento.Columns[0].Visible = false;               
            }
      
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void mtxtDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FrmTurno TurnoN = new FrmTurno();
            //    TurnoN.ShowDialog();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utiliza la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que verifica si hay un punto decimal
            else if ((e.KeyChar=='.')&&(!txtDNI.Text.Contains("..")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '-') && (!txtDNI.Text.Contains("--")))
            {
                e.Handled = false;
            }
            else
            {
               

                MessageBox.Show("Solo se admiten numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utiliza la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que verifica si hay un punto decimal
            else if ((e.KeyChar == ',') && (!txtDNI.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utiliza la tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que verifica si hay un punto decimal
            else if ((e.KeyChar == ',') && (!txtDNI.Text.Contains(",")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se admiten numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
