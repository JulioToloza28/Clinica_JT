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
    public partial class FrmTurno : Form
    {
        private Paciente Turno_Paciente;
        private bool Bandera = false;
        private bool Termino = false;
        Turno_Paciente TurnoFinal = new Turno_Paciente();
        Empleado_Service Medico_Es=new Empleado_Service();
        Horario_service Horarios = new Horario_service();
        Turno_Service TURNOS = new Turno_Service();
        Empleado Medico = new Empleado();
        Int32 ADM;



        public FrmTurno()
        {
            InitializeComponent();
        }
        public FrmTurno(Int32 id)
        {
            InitializeComponent();
            ADM = id;
        }
        public FrmTurno(Paciente Pacient,bool bn,Int32 id_Adm)
        {
            InitializeComponent();
            Turno_Paciente = Pacient;
            Bandera = bn;
            ADM = id_Adm;
        }
        public bool VerificarDias(string dia)
        {
            if (ckxLunes.Checked == true)
            {
                if (dia == "Lunes")
                {
                    return true;
                }
            }
            if (ckxMartes.Checked == true)
            {
                if (dia == "Martes")
                {
                    return true;
                }
            }
            if (ckxMiercoles.Checked == true)
            {
                if (dia == "Miercoles")
                {
                    return true;
                }
            }
            if (ckxJueves.Checked == true)
            {
                if (dia == "Jueves")
                {
                    return true;
                }
            }
            if (ckxViernes.Checked == true)
            {
                if (dia == "Viernes")
                {
                    return true;
                }
            }
            
                return false;
            
        }
        public void CargarDias(string Dia)
        {
            List<Horario> Lista_Horario = new List<Horario>(Horarios.BuscarHorario(Medico.ID_Empleado1,Dia));
            pnOcho.Enabled = true;
            pnnueve.Enabled = true;
            pnDiez.Enabled = true;
            pnOnce.Enabled = true;
            pnDoce.Enabled = true;
            pntrece.Enabled = true;
            pncatorce.Enabled = true;
            pnquince.Enabled = true;
            pndieciseis.Enabled = true;
            pndiecisiete.Enabled = true;
            for (int i = 0; i < Lista_Horario.Count; i++)
            {
                if (Lista_Horario[i].Desde1.Hours == 16)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
                    pnDiez.Enabled = false;
                    pnOnce.Enabled = false;
                    pnDoce.Enabled = false;
                    pntrece.Enabled = false;
                    pncatorce.Enabled = false;
                    pnquince.Enabled = false;
                  
                }
                if (Lista_Horario[i].Desde1.Hours == 15)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
                    pnDiez.Enabled = false;
                    pnOnce.Enabled = false;
                    pnDoce.Enabled = false;
                    pntrece.Enabled = false;
                    pncatorce.Enabled = false;
                 


                }
                if (Lista_Horario[i].Desde1.Hours == 14)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
                    pnDiez.Enabled = false;
                    pnOnce.Enabled = false;
                    pnDoce.Enabled = false;
                    pntrece.Enabled = false;
               


                }
                if (Lista_Horario[i].Desde1.Hours == 13)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
                    pnDiez.Enabled = false;
                    pnOnce.Enabled = false;
                    pnDoce.Enabled = false;
             

                }
                if (Lista_Horario[i].Desde1.Hours == 12)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
                    pnDiez.Enabled = false;
                    pnOnce.Enabled = false;
                

                }
                if (Lista_Horario[i].Desde1.Hours == 11)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
                    pnDiez.Enabled = false;
               

                }
                if (Lista_Horario[i].Desde1.Hours == 10)
                {
                    pnOcho.Enabled = false;
                    pnnueve.Enabled = false;
             
                }
                if (Lista_Horario[i].Desde1.Hours == 9)
                {
                    pnOcho.Enabled = false;
                   
                }
                if (Lista_Horario[i].Hasta1.Hours == 9)
                {
                    pnDiez.Enabled = false;
                    pnOnce.Enabled = false;
                    pnDoce.Enabled = false;
                    pntrece.Enabled = false;
                    pncatorce.Enabled = false;
                    pnquince.Enabled = false;
                    pndieciseis.Enabled = false;
                    pndiecisiete.Enabled = false;

                

                }
                if (Lista_Horario[i].Hasta1.Hours == 10)
                {
                    pnOnce.Enabled = false;
                    pnDoce.Enabled = false;
                    pntrece.Enabled = false;
                    pncatorce.Enabled = false;
                    pnquince.Enabled = false;
                    pndieciseis.Enabled = false;
                    pndiecisiete.Enabled = false;

            
                }
                if (Lista_Horario[i].Hasta1.Hours == 11)
                {
                    pnDoce.Enabled = false;
                    pntrece.Enabled = false;
                    pncatorce.Enabled = false;
                    pnquince.Enabled = false;
                    pndieciseis.Enabled = false;
                    pndiecisiete.Enabled = false;

             
                }
                if (Lista_Horario[i].Hasta1.Hours == 12)
                {
                    pntrece.Enabled = false;
                    pncatorce.Enabled = false;                  
                    pnquince.Enabled = false;                
                    pndieciseis.Enabled = false;                  
                    pndiecisiete.Enabled = false;
               
                }
                if (Lista_Horario[i].Hasta1.Hours == 13)
                {

                    pncatorce.Enabled = false;
                    pnquince.Enabled = false;
                    pndieciseis.Enabled = false;
                    pndiecisiete.Enabled = false;

            
                }
                if (Lista_Horario[i].Hasta1.Hours == 14)
                {
                    pnquince.Enabled = false;
                    pndieciseis.Enabled = false;
                    pndiecisiete.Enabled = false;

                }
                if (Lista_Horario[i].Hasta1.Hours == 15)
                {
                    pndieciseis.Enabled = false;
                    pndiecisiete.Enabled = false;
               
                }
                if (Lista_Horario[i].Hasta1.Hours == 16)
                {
                    pndiecisiete.Enabled = false;
                  
                }

            }

        }
        public void Dias_Medicos()
        {
            Medico = (Empleado)dgvMedicos.CurrentRow.DataBoundItem;
            List<Horario> Lista_Horario = new List<Horario>(Horarios.BuscarHorario(Medico.ID_Empleado1));
            ckxLunes.Checked =false;
            ckxMartes.Checked = false;
            ckxMiercoles.Checked = false;
            ckxJueves.Checked = false;
            ckxViernes.Checked = false;

            for (int i = 0; i < Lista_Horario.Count; i++)
            {
                if (Lista_Horario[i].Dia1 == "Lunes")
                {
                    ckxLunes.Checked = true;
                }
                if (Lista_Horario[i].Dia1 == "Martes")
                {
                    ckxMartes.Checked = true;
                }
                if (Lista_Horario[i].Dia1 == "Miercoles")
                {
                    ckxMiercoles.Checked = true;
                }
                if (Lista_Horario[i].Dia1 == "Jueves")
                {
                    ckxJueves.Checked = true;
                }
                if (Lista_Horario[i].Dia1 == "Viernes")
                {
                    ckxViernes.Checked = true;
                }
            }
            pnDias.Visible = true;

        }
        private void FrmTurno_Load(object sender, EventArgs e)
        {
            try
            {
                if (Turno_Paciente != null)
                {
                    mtxtDNI.Text = Turno_Paciente.DNI1.ToString();
                    txtNombre.Text = Turno_Paciente.Nombre1.ToString();
                    txtApellido.Text = Turno_Paciente.Apellido1.ToString();
                    mtxtTelefono.Text = Turno_Paciente.Telefono1.ToString();
                    Bandera = false;
                }


                Especialidad_service especialidad = new Especialidad_service();
                cbxEspecialidad.DataSource = especialidad.traerEspecialidades();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pbxBuscar_Click(object sender, EventArgs e)
        {
            Paciente_service pacientes = new Paciente_service();
            Paciente PacienteTurno = new Paciente();
            var bandera = false;
            try
            {
                ptbVerificacion4.Visible = false;
                ptbVerificacion5.Visible = false;
                ptbVerificacion6.Visible = false;

                if (Termino == true)
                {
                    MessageBox.Show("Debe guardar el turno seleccionado");
                }
                else
                {
                    if (mtxtDNI.Text == "  ,   ," && mtxtDNI.Enabled == true)
                    {
                        MessageBox.Show("Complete el campo con el numero de DNI ");
                        bandera = true;

                    }
                    else
                    {
                        PacienteTurno = pacientes.BuscarPaciente(mtxtDNI.Text.Trim());
                        txtNombre.Text = PacienteTurno.Nombre1;
                        txtApellido.Text = PacienteTurno.Apellido1;
                        mtxtTelefono.Text = PacienteTurno.Telefono1;
                        Turno_Paciente = PacienteTurno;

                    }
                    if (txtNombre.Text == "" && bandera == false)
                    {
                        gbxMedicos.Enabled = false;
                        dgvMedicos.Visible = false;
                        gbxMedicos.Visible = false;
                        ptbverificacion1.Visible = false;
                        MessageBox.Show("No se encontro ninguna ficha con ese DNI");                 


                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void pbxMedicos_Click(object sender, EventArgs e)
        {

        }

        private void mtxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            gbxMedicos.Enabled = true;
            dgvMedicos.Visible = true;
            gbxMedicos.Visible = true;
            ptbverificacion1.Visible = true;
        }

        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ptbVerificacion5.Visible = false;
                ptbVerificacion6.Visible = false;
                dgvMedicos.DataSource = Medico_Es.buscarMedicoXec(4, cbxEspecialidad.SelectedIndex+1);
                dgvMedicos.Columns[0].Visible = false;
                dgvMedicos.Columns[1].Visible = false;
                dgvMedicos.Columns[2].Visible = false;
                dgvMedicos.Columns[3].Visible = false;
                dgvMedicos.Columns[4].Visible = false;
                dgvMedicos.Columns[5].Visible = false;
                dgvMedicos.Columns[6].Visible = false;
                dgvMedicos.Columns[7].Visible = false;
                //dgvMedicos.Columns[8].Visible = false;
                //dgvMedicos.Columns[9].Visible = false;
                dgvMedicos.Columns[10].Visible = false;
                dgvMedicos.Columns[11].Visible = false;
                dgvMedicos.Columns[12].Visible = false;
                dgvMedicos.Columns[13].Visible = false;
                dgvMedicos.Columns[14].Visible = false;
                dgvMedicos.Columns[15].Visible = false;
             


                dgvMedicos.Columns[8].ReadOnly = true;
                dgvMedicos.Columns[8].HeaderText = "Nombre";
                dgvMedicos.Columns[9].ReadOnly = true;
                dgvMedicos.Columns[9].HeaderText = "Apellido";
                pnDias.Visible = false;
                PNHorarios.Visible = false;
                ptbverificacion2.Visible = false;

                if (gbxMedicos.Enabled == true && dgvMedicos.CurrentRow!=null)
                {
                    gbxAgenda.Enabled = true;
                    mcAgenda.Enabled = true;
                    gbxAgenda.Visible = true;
                    Dias_Medicos();
                    ptbverificacion2.Visible = true;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void mcAgenda_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void mcAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {
            Horario Hora = new Horario();
            Turno_Service Turno_S = new Turno_Service();
            DateTime prueba = new DateTime(mcAgenda.SelectionRange.Start.Year, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Day);
            List<Turno_Paciente> ListaTurnos = new List<Turno_Paciente>(Turno_S.BuscarTurnos(Medico.ID_Empleado1, mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year));
            string Dia;

            //Verifica que no se seleccione una fecha mayor o igual
            if (mcAgenda.SelectionRange.Start.Date >= mcAgenda.TodayDate)
            {

            Dia = prueba.DayOfWeek.ToString();
            switch (Dia)
            {
                case "Monday":
                    Dia = "Lunes";
                    break;
                case "Tuesday":
                    Dia = "Martes";
                    break;
                case "Wednesday":
                    Dia = "Miercoles";
                    break;
                case "Thursday":
                    Dia = "Jueves";
                    break;
                case "Friday":
                    Dia = "Viernes";
                    break;
                case "Saturday":
                    Dia = "Sabado";
                    break;
                case "Sunday":
                    Dia = "Domingo";
                    break;
            }
            CargarDias(Dia);
            if (VerificarDias(Dia) == false)
            {
                MessageBox.Show("No hay Turnos disponible el " + Dia);
                PNHorarios.Visible = false;
            }
            else
            {
             
                PNHorarios.Visible = true;
                btnOcho.Text = "Libre";
                btnOcho.Enabled = true;
                btnNueve.Text = "Libre";
                btnNueve.Enabled = true;
                btnDiez.Text = "Libre";
                btnDiez.Enabled = true;
                btnonce.Text = "Libre";
                btnonce.Enabled = true;
                btnDoce.Text = "Libre";
                btnDoce.Enabled = true;
                btntrece.Text = "Libre";
                btntrece.Enabled = true;
                btncatorce.Text = "Libre";
                btncatorce.Enabled = true;
                btnQuince.Text = "Libre";
                btnQuince.Enabled = true;
                btnDieciseis.Text = "Libre";
                btnDieciseis.Enabled = true;
                btnDiecisiete.Text = "Libre";
                btnDiecisiete.Enabled = true;
                for (int i = 0; i < ListaTurnos.Count; i++)
                {
                    if (ListaTurnos[i].Hora1.Hours == 8)
                    {
                        btnOcho.Text = "Ocupado";
                        btnOcho.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 9)
                    {
                        btnNueve.Text = "Ocupado";
                        btnNueve.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 10)
                    {
                        btnDiez.Text = "Ocupado";
                        btnDiez.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 11)
                    {
                        btnonce.Text = "Ocupado";
                        btnonce.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 12)
                    {
                        btnDoce.Text = "Ocupado";
                        btnDoce.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 13)
                    {
                        btntrece.Text = "Ocupado";
                        btntrece.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 14)
                    {
                        btncatorce.Text = "Ocupado";
                        btncatorce.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 15)
                    {
                        btnQuince.Text = "Ocupado";
                        btnQuince.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 16)
                    {
                        btnDieciseis.Text = "Ocupado";
                        btnDieciseis.Enabled = false;
                    }
                    if (ListaTurnos[i].Hora1.Hours == 17)
                    {
                        btnDiecisiete.Text = "Ocupado";
                        btnDiecisiete.Enabled = false;
                    }
                }
                if (btnOcho.Text == "Ocupado" && btnNueve.Text == "Ocupado" && btnDiez.Text == "Ocupado"&& btnonce.Text == "Ocupado" && btnDoce.Text == "Ocupado" && btntrece.Text == "Ocupado" && btncatorce.Text == "Ocupado" && btnQuince.Text == "Ocupado" && btnDieciseis.Text == "Ocupado" && btnDiecisiete.Text == "Ocupado")
                {
                    MessageBox.Show("No hay Turnos disponible");
                    PNHorarios.Visible = false;

                }

            }
            }
            else
            {
                MessageBox.Show("La fecha no es Valida");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar el turno? ", "Cancelar Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "8:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(08, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnOcho.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }

        }

        private void gbxAgenda_Enter(object sender, EventArgs e)
        {

        }

        private void dgvMedicos_SelectionChanged(object sender, EventArgs e)
        {

            Dias_Medicos();

               
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "9:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(09, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnNueve.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }

        }

        private void btnDiez_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "10:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(10, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnDiez.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;

                }


            }




        }

        private void btnonce_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "11:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(11, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnonce.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                   
                }


            }
        }

        private void btnDoce_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "12:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(12, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnDoce.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }
        }

        private void btntrece_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "13:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(13, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btntrece.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }
        }

        private void btncatorce_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "14:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(14, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btncatorce.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }
        }

        private void btnQuince_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "15:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(15, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnQuince.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }
        }

        private void btnDieciseis_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "16:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(16, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnDieciseis.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }
        }

        private void btnDiecisiete_Click(object sender, EventArgs e)
        {
            if (Termino == true)
            {
                MessageBox.Show("Debes guardar el turno antes seleccionado");
            }
            else
            {
                Especialidad esp = new Especialidad();
                esp = (Especialidad)cbxEspecialidad.SelectedItem;
                FrmConfirTurno Confirmar = new FrmConfirTurno(Medico.Nombre1, Medico.Apellido1, txtNombre.Text.ToString(), txtApellido.Text.ToString(), mcAgenda.SelectionRange.Start.Day, mcAgenda.SelectionRange.Start.Month, mcAgenda.SelectionRange.Start.Year, esp.Nombre1, "17:00");
                Confirmar.ShowDialog();
                TimeSpan hora = new TimeSpan(17, 00, 00);

                if (Confirmar.DialogResult == DialogResult.OK)
                {
                    Termino = true;
                    btnDiecisiete.Text = "Ocupado";
                    TurnoFinal.ID_Estado1 = 1;
                    TurnoFinal.ID_Empleado1 = ADM;
                    TurnoFinal.ID_Paciente1 = Turno_Paciente.ID_Paciente1;
                    TurnoFinal.Fecha1 = Convert.ToString(mcAgenda.SelectionRange.Start.Day) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Month) + "/" + Convert.ToString(mcAgenda.SelectionRange.Start.Year);
                    TurnoFinal.Hora1 = hora;
                    TurnoFinal.ID_Medico1 = Medico.ID_Empleado1;
                    TurnoFinal.Obs1 = "";
                    TurnoFinal.Eliminado1 = false;
                    ptbverificacion3.Visible = true;
                }


            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Termino != true)
            {
                MessageBox.Show("No se registra ningun turno");
                if (ptbverificacion1.Visible == false)
                {
                    ptbVerificacion4.Visible = true;
                    ptbVerificacion5.Visible = true;
                    ptbVerificacion6.Visible = true;
                }
                if (ptbverificacion2.Visible == false)
                { 
                    ptbVerificacion5.Visible = true;
                    ptbVerificacion6.Visible = true;
                }
                if (ptbverificacion3.Visible == false)
                {
                    ptbVerificacion6.Visible = true;
                }
            }
            else
            {
                TURNOS.GuardarTurnos(TurnoFinal);
                MessageBox.Show("Se guardo con exito");
                this.Dispose();
            }
        }

        private void pbxBuscarPA_Click(object sender, EventArgs e)
        {
          
        }

        private void mcAgenda_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpDatosP_Click(object sender, EventArgs e)
        {

        }
    }
}
