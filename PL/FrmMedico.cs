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
    public partial class FrmMedico : Form
    {
        private Empleado Obj_Emp_Medico;
        List<Especialidad> lista = new List<Especialidad>();
        
       

        public FrmMedico()
        {
            InitializeComponent();
        }
        public FrmMedico(Empleado Medico)
        {
            InitializeComponent();
            Obj_Emp_Medico = Medico;
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            rdbMasculino.Checked = true;

            try

            {
                Especialidad_service especialidad = new Especialidad_service();
                cbxEspecialidad.DataSource = especialidad.traerEspecialidades();


                ProvinciaService Provincia = new ProvinciaService();
                cbxProvincia.DataSource = null;
                cbxProvincia.DataSource = Provincia.traerProvincias();
                cbxProvincia.DisplayMember = "N_Provincia1";
                cbxProvincia.ValueMember = "ID_Provincia1";

                if (Obj_Emp_Medico != null)
                {
                   
                    
                    txtNombre.Text = Obj_Emp_Medico.Nombre1;
                    txtApellido.Text = Obj_Emp_Medico.Apellido1;
                    dtpFechaNac.Text = Obj_Emp_Medico.Fecha_Nac1;
                    if (Obj_Emp_Medico.Sexo1 == true) { rdbMasculino.Checked = true; }
                    else { rdbFemenino.Checked = true; }
                    txtDireccion.Text = Obj_Emp_Medico.Direccion1;
                    txtCorreo.Text = Obj_Emp_Medico.Email1;
                    mtxtTelefono.Text = Obj_Emp_Medico.Telefono1.ToString();
                    cbxProvincia.SelectedValue = Obj_Emp_Medico.Provincia.ID_Provincia1;
                    cbxLocalidad.SelectedValue = Obj_Emp_Medico.Localidad.ID_Localidad1;
                    if (Obj_Emp_Medico.ListaHorarios!=null)
                    {
                        for (int i = 0; i < Obj_Emp_Medico.ListaHorarios.Count; i++)
                        {
                            if (Obj_Emp_Medico.ListaHorarios[i].Dia1 == "Lunes")
                            {
                                ckxLunes.Checked = true;
                                nUDDesdeLunes.Value = Obj_Emp_Medico.ListaHorarios[i].Desde1.Hours;
                                nUDhastaLunes.Value= Obj_Emp_Medico.ListaHorarios[i].Hasta1.Hours;
                            }
                            if (Obj_Emp_Medico.ListaHorarios[i].Dia1 == "Martes")
                            {
                                ckxMartes.Checked = true;
                                nUDDesdeMartes.Value = Obj_Emp_Medico.ListaHorarios[i].Desde1.Hours;
                                nUDhastaMartes.Value = Obj_Emp_Medico.ListaHorarios[i].Hasta1.Hours;
                            }
                            if (Obj_Emp_Medico.ListaHorarios[i].Dia1 == "Miercoles")
                            {
                                ckxMiercoles.Checked = true;
                                nUDDesdeMiercoles.Value = Obj_Emp_Medico.ListaHorarios[i].Desde1.Hours;
                                nUDhastaMiercoles.Value = Obj_Emp_Medico.ListaHorarios[i].Hasta1.Hours;
                            }
                            if (Obj_Emp_Medico.ListaHorarios[i].Dia1 == "Jueves")
                            {
                                ckxJueves.Checked = true;
                                nUDDesdeJueves.Value = Obj_Emp_Medico.ListaHorarios[i].Desde1.Hours;
                                nUDhastaJueves.Value = Obj_Emp_Medico.ListaHorarios[i].Hasta1.Hours;
                            }
                            if (Obj_Emp_Medico.ListaHorarios[i].Dia1 == "Viernes")
                            {
                                ckxViernes.Checked = true;
                                nUDDesdeViernes.Value = Obj_Emp_Medico.ListaHorarios[i].Desde1.Hours;
                                nUDhastaViernes.Value = Obj_Emp_Medico.ListaHorarios[i].Hasta1.Hours;
                            }
                        }

                    }
                    dgvEspecialidad.DataSource = Obj_Emp_Medico.Lista_Especialidades;
                    txtN_Ususario.Text = Obj_Emp_Medico.Usser.NombreUsuario1;
                    txtbContraseña.Text = Obj_Emp_Medico.Usser.Contraseña1;
                    txtbContraseñaR.Text = Obj_Emp_Medico.Usser.Contraseña1;


                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Provincia Prov = (Provincia)cbxProvincia.SelectedItem;
            LocalidadService Localidad = new LocalidadService();
            cbxLocalidad.DataSource = Localidad.traerLocalidades(Prov.ID_Provincia1);
            cbxLocalidad.DisplayMember = "N_Localidad1";
            cbxLocalidad.ValueMember = "ID_Localidad1";
        }

        private void ckxLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxLunes.Checked == true)
            {
                nUDDesdeLunes.Enabled = true;
                nUDhastaLunes.Enabled = true;
                nUDDesdeLunes.Focus();
            }
            else
            {
                nUDDesdeLunes.Enabled = false;
                nUDhastaLunes.Enabled = false;
            }
        }

        private void ckxMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxMartes.Checked == true)
            {
                nUDDesdeMartes.Enabled = true;
                nUDhastaMartes.Enabled = true;
                nUDDesdeMartes.Focus();
            }
            else
            {
                nUDDesdeMartes.Enabled = false;
                nUDhastaMartes.Enabled = false;
            }
        }

        private void ckxMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxMiercoles.Checked == true)
            {
                nUDDesdeMiercoles.Enabled = true;
                nUDhastaMiercoles.Enabled = true;
                nUDDesdeMiercoles.Focus();
            }
            else
            {
                nUDDesdeMiercoles.Enabled = false;
                nUDhastaMiercoles.Enabled = false;
            }
        }

        private void ckxJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxJueves.Checked == true)
            {
                nUDDesdeJueves.Enabled = true;
                nUDhastaJueves.Enabled = true;
                nUDDesdeJueves.Focus();
            }
            else
            {
                nUDDesdeJueves.Enabled = false;
                nUDhastaJueves.Enabled = false;
            }
        }

        private void ckxViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxViernes.Checked == true)
            {
                nUDDesdeViernes.Enabled = true;
                nUDhastaViernes.Enabled = true;
                nUDDesdeViernes.Focus();
            }
            else
            {
                nUDDesdeViernes.Enabled = false;
                nUDhastaViernes.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApellido.Text != "" || mtxtDNI.Text != "")
            {
                if (btnAceptar.Visible != false)
                {
                    if (MessageBox.Show("Esta seguro que desea Cerrar? " + "\nSe perderan todos los datos", "Cerrar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }

                }
                else { this.Close(); }

            }
            else
            {
                this.Close();
            }
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

        private void pbxADDA_Click(object sender, EventArgs e)
        {
       
        }

        private void pbxDELA_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbMasculino.Checked == true)
                {

                    pbMa.Image = System.Drawing.Image.FromFile(Application.StartupPath+ "/usuario_masc.png");
                        
                    
                }
                else
                {
                    pbMa.Image = System.Drawing.Image.FromFile(Application.StartupPath + "/usuario_fem.png");
                   


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
            }
            
        }

        private void pbxADDA_Click_1(object sender, EventArgs e)
        {
            try
            {
                Especialidad nuevoE = new Especialidad();
                if (cbxEspecialidad.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Items");
                }
                else if (lista.Contains((Especialidad)cbxEspecialidad.SelectedItem))
                {
                    MessageBox.Show("Ya existe");
                }
                else
                {
                    nuevoE = (Especialidad)cbxEspecialidad.SelectedItem;
                    lista.Add(nuevoE);
                    dgvEspecialidad.DataSource = null;
                    dgvEspecialidad.DataSource = lista;
                    dgvEspecialidad.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void pbxDELA_Click_1(object sender, EventArgs e)
        {
            if (dgvEspecialidad.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item");
            }
            else
            {
                lista.Remove((Especialidad)dgvEspecialidad.CurrentRow.DataBoundItem);
                dgvEspecialidad.DataSource = null;
                dgvEspecialidad.DataSource = lista;
                dgvEspecialidad.Columns[0].Visible = false;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                Empleado_Service Medic_ser = new Empleado_Service();
                List<Horario> listaH = new List<Horario>();
                

                if (txtNombre.Text != "" && txtApellido.Text != "" && mtxtDNI.Text != "")
                {

                    
                    if (Obj_Emp_Medico == null || Obj_Emp_Medico.ID_Empleado1 == 0)
                    {
                        int i = 0;
                        Obj_Emp_Medico = new Empleado();
                        Obj_Emp_Medico.ID_Categoria1 = 4;
                        Obj_Emp_Medico.Nombre1 = txtNombre.Text.Trim();
                        Obj_Emp_Medico.Apellido1 = txtApellido.Text.Trim();
                        Obj_Emp_Medico.DNI1 = mtxtDNI.Text.Trim();
                        Obj_Emp_Medico.Fecha_Nac1 = Convert.ToString(dtpFechaNac.Text.Trim());
                        if (rdbMasculino.Checked == true) { Obj_Emp_Medico.Sexo1 = true; }
                        else { Obj_Emp_Medico.Sexo1 = false; }
                        Obj_Emp_Medico.Direccion1 = txtDireccion.Text.Trim();
                        Obj_Emp_Medico.Telefono1 = mtxtTelefono.Text.Trim();
                        Obj_Emp_Medico.Email1 = txtCorreo.Text.Trim();
                        Obj_Emp_Medico.Localidad = (Localidad)cbxLocalidad.SelectedItem;
                        Obj_Emp_Medico.ListaHorarios = new List<Horario>();
                        Obj_Emp_Medico.Lista_Especialidades = new List<Especialidad>();
                        Obj_Emp_Medico.Usser = new Usuario();

                        
                        if (ckxLunes.Checked)
                        {
                            Horario horariosM = new Horario();
                            int m = 00;
                            horariosM.ID_Empleado1 = 0;
                            horariosM.Dia1 = "Lunes";
                            horariosM.Desde1 = new TimeSpan(Convert.ToInt32(nUDDesdeLunes.Value), m, m);
                            horariosM.Hasta1 = new TimeSpan(Convert.ToInt32(nUDhastaLunes.Value), m, m);
                            Obj_Emp_Medico.ListaHorarios.Add(horariosM);
                            i++;
                            
                        }
                        

                        if (ckxMartes.Checked)
                        {
                            Horario horariosM = new Horario();
                            int m = 00;
                            horariosM.ID_Empleado1 = 0;
                            horariosM.Dia1 = "Martes";
                            horariosM.Desde1 = new TimeSpan(Convert.ToInt32(nUDDesdeMartes.Value), m, m);
                            horariosM.Hasta1 = new TimeSpan(Convert.ToInt32(nUDhastaMartes.Value), m, m);
                            Obj_Emp_Medico.ListaHorarios.Add(horariosM);
                            i++;

                        }
                       

                        if (ckxMiercoles.Checked)
                        {
                            Horario horariosM = new Horario();
                            int m = 00;
                            horariosM.ID_Empleado1 = 0;
                            horariosM.Dia1 = "Miercoles";
                            horariosM.Desde1 = new TimeSpan(Convert.ToInt32(nUDDesdeMiercoles.Value), m, m);
                            horariosM.Hasta1 = new TimeSpan(Convert.ToInt32(nUDhastaMiercoles.Value), m, m);
                            Obj_Emp_Medico.ListaHorarios.Add(horariosM);
                            i++;
                        }
                       
                        if (ckxJueves.Checked)
                        {
                            int m = 00;
                            Horario horariosM = new Horario();
                            horariosM.ID_Empleado1 = 0;
                            horariosM.Dia1 = "Jueves";
                            horariosM.Desde1 = new TimeSpan(Convert.ToInt32(nUDDesdeJueves.Value), m, m);
                            horariosM.Hasta1 = new TimeSpan(Convert.ToInt32(nUDhastaJueves.Value), m, m);
                            Obj_Emp_Medico.ListaHorarios.Add(horariosM);
                            i++;
                        }
                        
                        if (ckxViernes.Checked)
                        {
                            int m = 00;
                            Horario horariosM = new Horario();
                            horariosM.ID_Empleado1 = 0;
                            horariosM.Dia1 = "Viernes";
                            horariosM.Desde1 = new TimeSpan(Convert.ToInt32(nUDDesdeViernes.Value), m, m);
                            horariosM.Hasta1 = new TimeSpan(Convert.ToInt32(nUDhastaViernes.Value), m, m);
                            Obj_Emp_Medico.ListaHorarios.Add(horariosM);
                            i++;
                        }

                 

                        

                        if (i == 0)
                        {
                            MessageBox.Show("Debe seleccionar uno o mas dias y horarios");
                            Obj_Emp_Medico = null;
                            lblobligatorioH.Visible = true;
                            ckxLunes.Focus();
                            return;
                        }



                        if (lista.Count != 0)
                        {
                            Obj_Emp_Medico.Lista_Especialidades = lista;
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar uno o mas especialidades");
                            Obj_Emp_Medico = null;
                            lblobligatorioES.Visible = true;
                            return;
                        }
                        if (txtN_Ususario.Text != "")
                        {
                            Obj_Emp_Medico.Usser.NombreUsuario1 = txtN_Ususario.Text;
                            if (txtbContraseña.Text == txtbContraseñaR.Text)
                            {
                                Obj_Emp_Medico.Usser.Contraseña1 = txtbContraseña.Text;
                                Obj_Emp_Medico.Usser.Eliminado1 = false;
                            }
                            else
                            {
                                MessageBox.Show("Verifique que la contraseña coincida");
                                Obj_Emp_Medico = null;
                                return;
                            }

                        }
                        else
                        {
                            lblobligatoriousser.Visible = true;
                            MessageBox.Show("Complete los campos obligatorios para el usuario");
                        }
                    
                    }
                }
                else
                {
                    lblobligatorio1.Visible = true;
                    lblobligatorio2.Visible = true;
                    lblobligatorio4.Visible = true;
                    lblobligatoriol3.Visible = true;
                    lblobligatorio5.Visible = true;
                    lblobligatorio6.Visible = true;
                    lblobligatorio7.Visible = true;
                    lblobligatorio8.Visible = true;
                    MessageBox.Show("Complete los campos obligatorios");
                    Obj_Emp_Medico = null;
                }
                if (Obj_Emp_Medico.ID_Empleado1 == 0)
                {
                    Medic_ser.GuardarMedico(Obj_Emp_Medico);
                    MessageBox.Show("Medico agregado exitosamente");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Medico modificado exitosamente");
                    this.Dispose();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            ptbVerificacion1.Visible = false;
            ptbVerificacion2.Visible = false;
            ptbVerificacion3.Visible = false;
            ptbVerificacion4.Visible = false;
            if (txtbContraseña.Text==""&& txtbContraseñaR.Text=="")
            {
                MessageBox.Show("Los campos no pueden quedar vacios");
            }
            else
            {
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
            
        }

        private void nUDhastaLunes_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void nUDhastaLunes_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeLunes.Value >= nUDhastaLunes.Value)
            {
                MessageBox.Show("Verifique que el horario sea despues de las " + nUDDesdeLunes.Value + ":00");
                nUDhastaLunes.Value = nUDDesdeLunes.Value + 1;
            }
        }

        private void nUDDesdeLunes_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeLunes.Value >= nUDhastaLunes.Value)
            {
                nUDhastaLunes.Value = nUDDesdeLunes.Value + 1;
            }
            
        }

        private void nUDDesdeMartes_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeMartes.Value >= nUDhastaMartes.Value)
            {
                nUDhastaMartes.Value = nUDDesdeMartes.Value + 1;
            }
        }

        private void nUDhastaMartes_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeMartes.Value >= nUDhastaMartes.Value)
            {
                MessageBox.Show("Verifique que el horario sea despues de las " + nUDDesdeMartes.Value + ":00");
                nUDhastaMartes.Value = nUDDesdeMartes.Value + 1;
            }

        }

        private void nUDDesdeMiercoles_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeMiercoles.Value >= nUDhastaMiercoles.Value)
            {
                nUDhastaMiercoles.Value = nUDDesdeMiercoles.Value + 1;
            }
        }

        private void nUDhastaMiercoles_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeMiercoles.Value >= nUDhastaMiercoles.Value)
            {
                MessageBox.Show("Verifique que el horario sea despues de las " + nUDDesdeMiercoles.Value + ":00");
                nUDhastaMiercoles.Value = nUDDesdeMiercoles.Value + 1;
            }

        }

        private void nUDDesdeJueves_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeJueves.Value >= nUDhastaJueves.Value)
            {
                nUDhastaJueves.Value = nUDDesdeJueves.Value + 1;
            }
        }

        private void nUDhastaJueves_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeJueves.Value >= nUDhastaJueves.Value)
            {
                MessageBox.Show("Verifique que el horario sea despues de las " + nUDDesdeJueves.Value + ":00");
                nUDhastaJueves.Value = nUDDesdeJueves.Value + 1;
            }
        }

        private void nUDDesdeViernes_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeViernes.Value >= nUDhastaViernes.Value)
            {
                nUDhastaViernes.Value = nUDDesdeViernes.Value + 1;
            }
        }

        private void nUDhastaViernes_ValueChanged(object sender, EventArgs e)
        {
            if (nUDDesdeViernes.Value >= nUDhastaViernes.Value)
            {
                MessageBox.Show("Verifique que el horario sea despues de las " + nUDDesdeViernes.Value + ":00");
                nUDhastaViernes.Value = nUDDesdeViernes.Value + 1;
            }
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
