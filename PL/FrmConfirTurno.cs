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
    public partial class FrmConfirTurno : Form
    {
        string NombreP, ApellidoP,NombreM,ApellidoM;
        Int32 dia,mes,anio;
        string Especilidad,Hora;


        public FrmConfirTurno()
        {
            InitializeComponent();
        }

        public FrmConfirTurno(string nombreM,string apellidoM,string nombreP,string apellidoP,Int32 Dia,Int32 Mes,Int32 Anio,string esp,string hora)
        {
            InitializeComponent();
          
            dia = Dia;
            mes = Mes;
            anio = Anio;
            Especilidad = esp;
            Hora = hora;
            NombreM = nombreM;
            ApellidoM = apellidoM;
            NombreP = nombreP;
            ApellidoP = apellidoP;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar el turno? ", "Cancelar Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmConfirTurno_Load(object sender, EventArgs e)
        {
            txtbNombreP.Text = NombreP;
            txtbApellidoP.Text = ApellidoP;
            txtbEsp.Text = Especilidad;
            txtbNombreM.Text = NombreM;
            txtbApellidoM.Text = ApellidoM;
            txtbFecha.Text = Convert.ToString(dia) + "/" + Convert.ToString(mes) + "/" + Convert.ToString(anio);
            txtbHora.Text = Hora;
        }
    }
}
